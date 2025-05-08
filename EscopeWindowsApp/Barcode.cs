using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.IO;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Drawing.Printing;

// Aliases to resolve ambiguous references
using WinForms = System.Windows.Forms;
using SysDrawing = System.Drawing;

namespace EscopeWindowsApp
{
    public partial class Barcode : Form
    {
        private Bitmap generatedBarcode; // Store the generated barcode image
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable productsTable;
        private BindingSource bindingSource;
        private ListBox suggestionListBox; // ListBox for autocomplete suggestions
        private Panel suggestionPanel;      // Panel to wrap ListBox for border
        private Timer searchTimer;         // Timer for delayed search
        private bool suppressTextChanged;  // Flag to prevent recursive TextChanged events
        private int itemNumberCounter = 1; // To assign unique item numbers in serialNoDataGridView

        public Barcode()
        {
            InitializeComponent();
            this.AutoScroll = false; // Disable auto-scroll for the main Barcode form

            // Initialize BindingSource and DataTable for products
            bindingSource = new BindingSource();
            productsTable = new DataTable();

            // Initialize suggestion ListBox and Panel
            suggestionListBox = new ListBox
            {
                Size = new Size(productSearchText.Width, 100),
                Font = new SysDrawing.Font("Calibri", 12),
                Visible = true,
                BorderStyle = WinForms.BorderStyle.None
            };
            suggestionListBox.SelectedIndexChanged += SuggestionListBox_SelectedIndexChanged;
            suggestionListBox.MouseClick += SuggestionListBox_MouseClick;
            suggestionListBox.LostFocus += SuggestionListBox_LostFocus;

            suggestionPanel = new Panel
            {
                Size = new Size(productSearchText.Width, 102),
                BorderStyle = WinForms.BorderStyle.FixedSingle,
                Visible = false
            };

            Point searchBarLocation = productSearchText.Location;
            Point panelLocation = new Point(
                searchBarLocation.X,
                searchBarLocation.Y + productSearchText.Height
            );

            if (productSearchText.Parent != this)
            {
                panelLocation = this.PointToClient(productSearchText.Parent.PointToScreen(panelLocation));
            }

            suggestionPanel.Location = panelLocation;
            suggestionListBox.Location = new Point(1, 1);
            suggestionListBox.Size = new Size(suggestionPanel.Width - 2, suggestionPanel.Height - 2);
            suggestionPanel.Controls.Add(suggestionListBox);
            this.Controls.Add(suggestionPanel);

            productSearchText.LocationChanged += (s, e) => UpdateSuggestionPanelPosition();
            productSearchText.SizeChanged += (s, e) => UpdateSuggestionPanelPosition();

            // Initialize search timer
            searchTimer = new Timer
            {
                Interval = 300
            };
            searchTimer.Tick += SearchTimer_Tick;

            // Subscribe to search events
            productSearchText.TextChanged += productSearchText_TextChanged;
            productSearchText.KeyDown += ProductSearchText_KeyDown;
            productSearchText.GotFocus += ProductSearchText_GotFocus;
            productSearchText.LostFocus += ProductSearchText_LostFocus;

            // Ensure CellContentClick is subscribed
            serialNoDataGridView.CellContentClick += serialNoDataGridView_CellContentClick;
        }

        private void Barcode_Load(object sender, EventArgs e)
        {
            InitializeSerialNoDataGridView();
            LoadProductsData();
        }

        private void InitializeSerialNoDataGridView()
        {
            serialNoDataGridView.AutoGenerateColumns = false;
            serialNoDataGridView.Columns.Clear();
            serialNoDataGridView.RowTemplate.Height = 35;

            DataGridViewTextBoxColumn productIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "product_id",
                HeaderText = "PRODUCT ID",
                DataPropertyName = "id",
                Width = 80
            };
            productIdColumn.DefaultCellStyle.Format = "\"PRO\"000"; // Format as PRO followed by zero-padded ID
            serialNoDataGridView.Columns.Add(productIdColumn);

            serialNoDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_name",
                HeaderText = "PRODUCT NAME",
                DataPropertyName = "name",
                Width = 200
            });

            serialNoDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "brand_name",
                HeaderText = "BRAND",
                DataPropertyName = "brand_name",
                Width = 100
            });

            serialNoDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "variation_type_name",
                HeaderText = "VARIATION TYPE",
                DataPropertyName = "variation_type_name",
                Width = 80
            });

            serialNoDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "upc_number",
                HeaderText = "UPC NO",
                DataPropertyName = "barcode",
                Width = 120
            });

            DataGridViewButtonColumn decreaseColumn = new DataGridViewButtonColumn
            {
                Name = "decrease",
                HeaderText = "",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 30 // Increased width for better clickability
            };
            serialNoDataGridView.Columns.Add(decreaseColumn);

            serialNoDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quantity",
                HeaderText = "QUANTITY",
                Width = 40,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            DataGridViewButtonColumn increaseColumn = new DataGridViewButtonColumn
            {
                Name = "increase",
                HeaderText = "",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 30 // Increased width for better clickability
            };
            serialNoDataGridView.Columns.Add(increaseColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                Name = "delete",
                HeaderText = "",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 30 // Increased width for better clickability
            };
            serialNoDataGridView.Columns.Add(deleteColumn);

            serialNoDataGridView.AllowUserToAddRows = false;
            serialNoDataGridView.CellPainting += SerialNoDataGridView_CellPainting;
        }

        private void LoadProductsData()
        {
            try
            {
                productsTable = new DataTable();
                productsTable.Columns.Add("id", typeof(int));
                productsTable.Columns.Add("name", typeof(string));
                productsTable.Columns.Add("brand_name", typeof(string));
                productsTable.Columns.Add("variation_type_name", typeof(string));
                productsTable.Columns.Add("barcode", typeof(string));

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            p.id,
                            p.name,
                            IFNULL(b.name, 'N/A') AS brand_name,
                            IFNULL(v.type1, 'N/A') AS variation_type_name,
                            p.barcode
                        FROM products p
                        LEFT JOIN brands b ON p.brand_id = b.id
                        LEFT JOIN variations v ON p.variation_type_id = v.id
                        WHERE p.barcode IS NOT NULL AND p.barcode != ''
                        ORDER BY p.id";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(productsTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productsTable = new DataTable();
                productsTable.Columns.Add("id", typeof(int));
                productsTable.Columns.Add("name", typeof(string));
                productsTable.Columns.Add("brand_name", typeof(string));
                productsTable.Columns.Add("variation_type_name", typeof(string));
                productsTable.Columns.Add("barcode", typeof(string));
            }
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (serialNoDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please select a product to generate barcode.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = serialNoDataGridView.SelectedRows.Count > 0 ? serialNoDataGridView.SelectedRows[0] : serialNoDataGridView.Rows[0];
            string barcodeText = selectedRow.Cells["upc_number"].Value.ToString();

            if (string.IsNullOrEmpty(barcodeText))
            {
                MessageBox.Show("Selected product has no UPC number.", "Invalid Barcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and adjust barcode length to get 12-digit base
            barcodeText = ValidateBarcodeLength(barcodeText);
            if (barcodeText == null)
            {
                MessageBox.Show("Invalid UPC number length. Must be 13 or 14 digits with a valid 12-digit base.", "Invalid Barcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                BarcodeWriter writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.EAN_13,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Width = 300,
                        Height = 100,
                        Margin = 10
                    }
                };
                generatedBarcode = writer.Write(barcodeText);
                MessageBox.Show("Barcode generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating barcode: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (serialNoDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No products selected for printing.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalBarcodes = 0;
            foreach (DataGridViewRow row in serialNoDataGridView.Rows)
            {
                totalBarcodes += Convert.ToInt32(row.Cells["quantity"].Value);
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // A4 size in pixels at 100 DPI (8.27 x 11.69 inches)
            printDoc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0); // No margins for full A4 usage

            int currentPage = 0;
            int barcodesPerPage = 30; // 3 columns x 10 rows
            int barcodesProcessed = 0;

            printDoc.PrintPage += (s, args) =>
            {
                int pageWidth = args.PageBounds.Width;
                int pageHeight = args.PageBounds.Height;

                // Calculate optimal sizing
                int barcodesPerRow = 3;
                int barcodesPerColumn = 10;
                int maxBarcodesThisPage = Math.Min(barcodesPerPage, totalBarcodes - (currentPage * barcodesPerPage));

                // Calculate exact barcode dimensions to fill the entire page width
                int barcodeWidth = pageWidth / barcodesPerRow;
                int verticalSpace = pageHeight / barcodesPerColumn;
                int barcodeHeight = (int)(verticalSpace * 0.85); // Use 85% of vertical space for barcode
                int labelHeight = (int)(verticalSpace * 0.15); // Use 15% of vertical space for label

                int barcodeCount = 0;
                int yStart = 5; // Small top margin

                foreach (DataGridViewRow row in serialNoDataGridView.Rows)
                {
                    string barcodeText = row.Cells["upc_number"].Value.ToString();
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    string productName = row.Cells["product_name"].Value.ToString();

                    // Validate barcode
                    barcodeText = ValidateBarcodeLength(barcodeText);
                    if (barcodeText == null)
                    {
                        MessageBox.Show($"Invalid UPC number for product: {productName}", "Invalid Barcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    for (int i = 0; i < quantity && barcodeCount < maxBarcodesThisPage; i++)
                    {
                        if (barcodesProcessed >= (currentPage * barcodesPerPage) && barcodeCount < maxBarcodesThisPage)
                        {
                            // Calculate position
                            int column = barcodeCount % barcodesPerRow;
                            int rowPosition = barcodeCount / barcodesPerRow;

                            int x = column * barcodeWidth;
                            int y = yStart + (rowPosition * verticalSpace);

                            try
                            {
                                // Generate and draw barcode
                                BarcodeWriter writer = new BarcodeWriter
                                {
                                    Format = BarcodeFormat.EAN_13,
                                    Options = new ZXing.Common.EncodingOptions
                                    {
                                        Width = barcodeWidth - 2, // Leave tiny margin
                                        Height = barcodeHeight - 2,
                                        Margin = 0 // No margin to maximize space
                                    }
                                };

                                using (Bitmap barcode = writer.Write(barcodeText))
                                {
                                    // Center the barcode in its cell
                                    int xOffset = (barcodeWidth - (barcodeWidth - 2)) / 2;
                                    args.Graphics.DrawImage(barcode, x + xOffset, y, barcodeWidth - 2, barcodeHeight - 2);
                                }

                                // Draw product name below barcode
                                using (SysDrawing.Font font = new SysDrawing.Font("Arial", 9, FontStyle.Regular))
                                {
                                    // Truncate product name if too long
                                    string displayName = productName;
                                    SizeF textSize = args.Graphics.MeasureString(displayName, font);

                                    while (textSize.Width > (barcodeWidth - 4) && displayName.Length > 5)
                                    {
                                        displayName = displayName.Substring(0, displayName.Length - 1);
                                        textSize = args.Graphics.MeasureString(displayName + "...", font);
                                    }

                                    if (displayName.Length < productName.Length)
                                        displayName += "...";

                                    // Center text below barcode
                                    float textX = x + ((barcodeWidth - textSize.Width) / 2);
                                    float textY = y + barcodeHeight;

                                    args.Graphics.DrawString(
                                        displayName,
                                        font,
                                        Brushes.Black,
                                        new PointF(textX, textY)
                                    );
                                }

                                barcodeCount++;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error generating barcode for printing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                        }
                        barcodesProcessed++;
                        if (barcodesProcessed >= (currentPage + 1) * barcodesPerPage) break;
                    }
                    if (barcodesProcessed >= (currentPage + 1) * barcodesPerPage) break;
                }

                currentPage++;
                args.HasMorePages = currentPage * barcodesPerPage < totalBarcodes;
            };

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDoc,
                AllowSomePages = true
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    barcodesProcessed = 0; // Reset for actual printing
                    currentPage = 0; // Reset page counter
                    printDoc.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error printing: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            if (serialNoDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No products selected for preview.", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalBarcodes = 0;
            foreach (DataGridViewRow row in serialNoDataGridView.Rows)
            {
                totalBarcodes += Convert.ToInt32(row.Cells["quantity"].Value);
            }

            // Create a bitmap with initial A4 size, extend as needed
            Bitmap previewBitmap = new Bitmap(595, 842);
            Graphics gfx = Graphics.FromImage(previewBitmap);
            gfx.Clear(System.Drawing.Color.White);

            int x = 20, y = 20;
            int barcodesPerRow = 3;
            int barcodeWidth = 180;
            int barcodeHeight = 70;
            int spacing = 10;
            int maxY = 842 - 40; // Initial A4 height minus bottom margin
            int barcodeCount = 0;

            foreach (DataGridViewRow row in serialNoDataGridView.Rows)
            {
                string barcodeText = row.Cells["upc_number"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);

                barcodeText = ValidateBarcodeLength(barcodeText);
                if (barcodeText == null)
                {
                    MessageBox.Show($"Invalid UPC number for product: {row.Cells["product_name"].Value}", "Invalid Barcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }

                for (int i = 0; i < quantity; i++)
                {
                    if (y > maxY)
                    {
                        // Extend the bitmap height
                        Bitmap newBitmap = new Bitmap(595, previewBitmap.Height + (barcodeHeight + 40));
                        using (Graphics newGfx = Graphics.FromImage(newBitmap))
                        {
                            newGfx.Clear(System.Drawing.Color.White);
                            newGfx.DrawImage(previewBitmap, 0, 0);
                        }
                        previewBitmap.Dispose();
                        previewBitmap = newBitmap;
                        gfx.Dispose();
                        gfx = Graphics.FromImage(previewBitmap);
                        maxY = previewBitmap.Height - 40;
                    }

                    try
                    {
                        BarcodeWriter writer = new BarcodeWriter
                        {
                            Format = BarcodeFormat.EAN_13,
                            Options = new ZXing.Common.EncodingOptions
                            {
                                Width = barcodeWidth,
                                Height = barcodeHeight,
                                Margin = 5
                            }
                        };
                        using (Bitmap barcode = writer.Write(barcodeText))
                        {
                            gfx.DrawImage(barcode, x, y, barcodeWidth, barcodeHeight);
                        }

                        string productName = row.Cells["product_name"].Value.ToString();
                        using (SysDrawing.Font font = new SysDrawing.Font("Arial", 8))
                        {
                            SizeF textSize = gfx.MeasureString(productName, font);
                            float textX = x + (barcodeWidth - textSize.Width) / 2;
                            gfx.DrawString(
                                productName,
                                font,
                                Brushes.Black,
                                new RectangleF(textX, y + barcodeHeight, barcodeWidth, 20)
                            );
                        }

                        x += barcodeWidth + spacing;
                        if ((barcodeCount + 1) % barcodesPerRow == 0)
                        {
                            x = 20;
                            y += barcodeHeight + 40;
                        }

                        barcodeCount++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating barcode: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                }
            }

            gfx.Dispose();
            // Show the preview in the BarcodePreview form
            BarcodePreview previewForm = new BarcodePreview((Bitmap)previewBitmap.Clone());
            previewForm.ShowDialog();
            previewBitmap.Dispose();
        }

        private void productSearchText_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            PerformProductSearch();
        }

        private void PerformProductSearch()
        {
            string searchText = productSearchText.Text.Trim();
            suggestionListBox.Items.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                suggestionPanel.Visible = false;
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            p.id,
                            p.name,
                            IFNULL(b.name, 'N/A') AS brand_name,
                            IFNULL(v.type1, 'N/A') AS variation_type_name,
                            p.barcode
                        FROM products p
                        LEFT JOIN brands b ON p.brand_id = b.id
                        LEFT JOIN variations v ON p.variation_type_id = v.id
                        WHERE (p.name LIKE @search OR p.id = @id) 
                        AND p.barcode IS NOT NULL AND p.barcode != ''
                        LIMIT 10";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", $"%{searchText}%");
                        command.Parameters.AddWithValue("@id", int.TryParse(searchText, out int id) ? id : -1);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                suggestionListBox.Items.Add(new ProductItem(
                                    reader["name"].ToString(),
                                    reader["barcode"].ToString(),
                                    reader["variation_type_name"].ToString()
                                ));
                            }
                        }
                    }
                }

                if (suggestionListBox.Items.Count > 0)
                {
                    UpdateSuggestionPanelPosition();
                    suggestionPanel.Visible = true;
                    suggestionPanel.BringToFront();
                    int itemHeight = suggestionListBox.ItemHeight;
                    int maxVisibleItems = Math.Min(suggestionListBox.Items.Count, 5);
                    int newHeight = maxVisibleItems * itemHeight + 2;
                    suggestionPanel.Height = newHeight;
                    suggestionListBox.Height = newHeight - 2;
                    suggestionListBox.Width = suggestionPanel.Width - 2;
                }
                else
                {
                    suggestionPanel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                suggestionPanel.Visible = false;
            }
        }

        private void ProductSearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (suggestionPanel.Visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        if (suggestionListBox.SelectedIndex < suggestionListBox.Items.Count - 1)
                        {
                            suggestionListBox.SelectedIndex++;
                        }
                        e.Handled = true;
                        break;
                    case Keys.Up:
                        if (suggestionListBox.SelectedIndex > 0)
                        {
                            suggestionListBox.SelectedIndex--;
                        }
                        e.Handled = true;
                        break;
                    case Keys.Enter:
                        if (suggestionListBox.SelectedIndex >= 0)
                        {
                            SelectProduct();
                        }
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Escape:
                        suggestionPanel.Visible = false;
                        productSearchText.Text = "";
                        e.Handled = true;
                        break;
                }
            }
        }

        private void ProductSearchText_GotFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productSearchText.Text))
            {
                PerformProductSearch();
            }
        }

        private void ProductSearchText_LostFocus(object sender, EventArgs e)
        {
            Timer hideTimer = new Timer { Interval = 200 };
            hideTimer.Tick += (s, args) =>
            {
                if (!suggestionListBox.Focused && !productSearchText.Focused)
                {
                    suggestionPanel.Visible = false;
                }
                hideTimer.Stop();
                hideTimer.Dispose();
            };
            hideTimer.Start();
        }

        private void SuggestionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suggestionListBox.SelectedIndex >= 0)
            {
                ProductItem selected = (ProductItem)suggestionListBox.SelectedItem;
                suppressTextChanged = true;
                productSearchText.Text = selected.Name;
                suppressTextChanged = false;
            }
        }

        private void SuggestionListBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectProduct();
        }

        private void SuggestionListBox_LostFocus(object sender, EventArgs e)
        {
            if (!productSearchText.Focused)
            {
                suggestionPanel.Visible = false;
            }
        }

        private void SelectProduct()
        {
            if (suggestionListBox.SelectedIndex >= 0)
            {
                ProductItem selected = (ProductItem)suggestionListBox.SelectedItem;
                productSearchText.Text = selected.Name;
                suggestionPanel.Visible = false;

                // Check if the product is already in the DataGridView
                bool productExists = false;
                foreach (DataGridViewRow row in serialNoDataGridView.Rows)
                {
                    if (row.Cells["product_name"].Value?.ToString() == selected.Name &&
                        row.Cells["upc_number"].Value?.ToString() == selected.Barcode)
                    {
                        productExists = true;
                        int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                        row.Cells["quantity"].Value = quantity + 1; // Increment quantity
                        break;
                    }
                }

                // If product doesn't exist, add it as a new row
                if (!productExists)
                {
                    foreach (DataRow row in productsTable.Rows)
                    {
                        if (row["name"].ToString() == selected.Name && row["barcode"].ToString() == selected.Barcode)
                        {
                            serialNoDataGridView.Rows.Add(
                                row["id"],
                                row["name"],
                                row["brand_name"],
                                row["variation_type_name"],
                                row["barcode"],
                                null,
                                1, // Default quantity to 1
                                null,
                                null
                            );
                            break;
                        }
                    }
                }

                // Clear the search bar and keep focus
                suppressTextChanged = true;
                productSearchText.Text = "";
                suppressTextChanged = false;
                productSearchText.Focus();
            }
        }

        private void UpdateSuggestionPanelPosition()
        {
            if (suggestionPanel != null && productSearchText != null)
            {
                Point searchBarLocation = productSearchText.Location;
                Point panelLocation = new Point(
                    searchBarLocation.X,
                    searchBarLocation.Y + productSearchText.Height
                );
                if (productSearchText.Parent != this)
                {
                    panelLocation = this.PointToClient(productSearchText.Parent.PointToScreen(panelLocation));
                }
                suggestionPanel.Location = panelLocation;
                suggestionPanel.Width = productSearchText.Width;
                suggestionListBox.Width = suggestionPanel.Width - 2;
                suggestionListBox.Height = suggestionPanel.Height - 2;
            }
        }

        private void SerialNoDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (serialNoDataGridView.Columns[e.ColumnIndex].Name == "decrease")
                {
                    e.PaintBackground(e.CellBounds, true);
                    try
                    {
                        Image minusIcon = Properties.Resources.posminus1;
                        int iconSize = 24;
                        int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(minusIcon, x, y, iconSize, iconSize);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading minus icon: {ex.Message}", "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string text = "-";
                        using (SysDrawing.Font font = new SysDrawing.Font("Arial", 8))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                    }
                    e.Handled = true;
                }
                else if (serialNoDataGridView.Columns[e.ColumnIndex].Name == "increase")
                {
                    e.PaintBackground(e.CellBounds, true);
                    try
                    {
                        Image plusIcon = Properties.Resources.posplus1;
                        int iconSize = 24;
                        int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(plusIcon, x, y, iconSize, iconSize);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading plus icon: {ex.Message}", "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string text = "+";
                        using (SysDrawing.Font font = new SysDrawing.Font("Arial", 8))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                    }
                    e.Handled = true;
                }
                else if (serialNoDataGridView.Columns[e.ColumnIndex].Name == "delete")
                {
                    e.PaintBackground(e.CellBounds, true);
                    try
                    {
                        Image deleteIcon = Properties.Resources.delete;
                        int iconSize = 24;
                        int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(deleteIcon, x, y, iconSize, iconSize);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading delete icon: {ex.Message}", "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string text = "X";
                        using (SysDrawing.Font font = new SysDrawing.Font("Arial", 8))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                    }
                    e.Handled = true;
                }
            }
        }

        private void serialNoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = serialNoDataGridView.Rows[e.RowIndex];
                if (serialNoDataGridView.Columns[e.ColumnIndex].Name == "decrease")
                {
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    if (quantity > 1)
                    {
                        row.Cells["quantity"].Value = quantity - 1;
                    }
                }
                else if (serialNoDataGridView.Columns[e.ColumnIndex].Name == "increase")
                {
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    row.Cells["quantity"].Value = quantity + 1;
                }
                else if (serialNoDataGridView.Columns[e.ColumnIndex].Name == "delete")
                {
                    serialNoDataGridView.Rows.RemoveAt(e.RowIndex);
                    ReassignItemNumbers();
                }
            }
        }

        private void ReassignItemNumbers()
        {
            itemNumberCounter = 1;
            foreach (DataGridViewRow row in serialNoDataGridView.Rows)
            {
                // Note: There is no "item_number" column in the DataGridView; this may be a leftover from previous code.
                // If you intended to use "product_id" or another column, update accordingly.
                // row.Cells["item_number"].Value = itemNumberCounter++;
            }
        }

        private class ProductItem
        {
            public string Name { get; }
            public string Barcode { get; }
            public string VariationType { get; }

            public ProductItem(string name, string barcode, string variationType)
            {
                Name = name;
                Barcode = barcode;
                VariationType = variationType;
            }

            public override string ToString()
            {
                return $"{Name} (Variation: {VariationType})";
            }
        }

        private string ValidateBarcodeLength(string barcodeText)
        {
            if (string.IsNullOrEmpty(barcodeText) || !long.TryParse(barcodeText, out _))
                return null;

            string digits = new string(barcodeText.Where(char.IsDigit).ToArray());
            if (digits.Length >= 13 && digits.Length <= 14)
            {
                return digits.Substring(0, 12); // Return first 12 digits for ZXing to calculate check digit
            }
            return null;
        }
    }
}