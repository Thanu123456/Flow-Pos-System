using MySql.Data.MySqlClient;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class AddQuotationForm : Form
    {
        private Timer timeTimer;       // Timer for time updates
        private Timer dateTimer;       // Timer for date updates
        private DataTable productsTable;
        private BindingSource bindingSource;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private int itemNumberCounter = 1; // To assign unique item numbers in addQuotaDataGridView
        private Panel scrollablePanel;     // Panel for scrollable content

        public AddQuotationForm()
        {
            InitializeComponent();
            createQuoText.Text = "Walk-In Customer";
            CustomizeDateTimePicker(); // Customize SiticoneDateTimePicker

            // Fix headerPanel to prevent scrolling
            headerPanel.Parent = this; // Make headerPanel a direct child of the form
            headerPanel.Dock = DockStyle.Top;
            headerPanel.AutoScroll = false;
            headerPanel.BringToFront();

            // Create a scrollable panel for other controls
            scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Top = headerPanel.Height, // Position below headerPanel
                Height = this.ClientSize.Height - headerPanel.Height
            };
            this.Controls.Add(scrollablePanel);

            // Move scrollable controls to scrollablePanel
            foreach (Control control in this.Controls.Cast<Control>().ToList())
            {
                if (control != headerPanel && control != scrollablePanel)
                {
                    this.Controls.Remove(control);
                    scrollablePanel.Controls.Add(control);
                }
            }

            // Handle form scrolling to keep headerPanel fixed
            this.Scroll += (s, e) => headerPanel.Location = new Point(0, 0);

            // Initialize and start the time timer
            timeTimer = new Timer();
            timeTimer.Interval = 1000;
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();

            // Initialize and start the date timer
            dateTimer = new Timer();
            dateTimer.Interval = 1000;
            dateTimer.Tick += DateTimer_Tick;
            dateTimer.Start();

            // Initialize BindingSource and DataTable for products
            bindingSource = new BindingSource();
            productsTable = new DataTable();

            // Enable discountText
            createQuotaDisText.Enabled = true;

            // Add KeyPress handlers for numerical input
            createQuotaDisText.KeyPress += TextBox_NumericalKeyPress;
            quotaShippingCharge.KeyPress += TextBox_NumericalKeyPress;

            // Load product data on form load
            this.Load += AddQuotationForm_Load;
            ConfigureAddQuotaDataGridView();

            quotaProductDataGrid.CellPainting += quotaProductDataGrid_CellPainting;
            quotaProductDataGrid.CellFormatting += quotaProductDataGrid_CellFormatting;
        }

        #region DateTimePicker Customization
        private void CustomizeDateTimePicker()
        {
            // Set fill color to White for SiticoneDateTimePicker using System.Drawing.Color
            createQuotaDateTime.FillColor = System.Drawing.Color.White;
            createQuotaDateTime.HoverState.FillColor = System.Drawing.Color.White; // Maintain white on hover
            createQuotaDateTime.BorderColor = System.Drawing.Color.Gray; // Subtle border
        }
        #endregion

        private void TextBox_NumericalKeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, decimal point, and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void AddQuotationForm_Load(object sender, EventArgs e)
        {
            LoadProductsData();
            ConfigureQuotaProductDataGrid();
            quotaProductDataGrid.DataSource = bindingSource;
        }

        #region quotaProductDataGrid Methods

        private void ConfigureQuotaProductDataGrid()
        {
            quotaProductDataGrid.AutoGenerateColumns = false;
            quotaProductDataGrid.Columns.Clear();

            // Add image column
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                DataPropertyName = "image_path",
                Name = "image_path",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 80
            };
            quotaProductDataGrid.Columns.Add(imageColumn);

            // Add product ID column
            quotaProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "Product ID",
                Width = 80
            });

            // Add product name column
            quotaProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                Name = "product_name",
                HeaderText = "Product Name",
                Width = 150
            });

            // Add variation type column
            quotaProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_type",
                Name = "variation_type",
                HeaderText = "Variation Type",
                Width = 100
            });

            // Add unit column
            quotaProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit_name",
                Name = "unit_name",
                HeaderText = "Unit",
                Width = 80
            });

            // Add stock column
            quotaProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "stock",
                Name = "stock",
                HeaderText = "Stock",
                Width = 80
            });

            // Add retail price column
            quotaProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "retail_price",
                Name = "retail_price",
                HeaderText = "Retail Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" },
                Width = 100
            });

            // Add "Add" button column
            DataGridViewButtonColumn addColumn = new DataGridViewButtonColumn
            {
                Name = "AddColumn",
                HeaderText = "Add",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 50
            };
            quotaProductDataGrid.Columns.Add(addColumn);

            quotaProductDataGrid.AllowUserToAddRows = false;
        }

        private void LoadProductsData()
        {
            try
            {
                productsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    p.id,
                    p.name AS product_name,
                    pr.variation_type,
                    u.unit_name,
                    SUM(COALESCE(s.stock, 0)) AS stock,
                    pr.retail_price,
                    p.image_path
                FROM products p
                LEFT JOIN units u ON p.unit_id = u.id
                LEFT JOIN pricing pr ON p.id = pr.product_id
                LEFT JOIN stock s ON p.id = s.product_id AND 
                    (pr.variation_type IS NULL OR pr.variation_type = s.variation_type)
                GROUP BY p.id, p.name, pr.variation_type, u.unit_name, pr.retail_price, p.image_path
                ORDER BY p.id, pr.variation_type";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(productsTable);
                    }
                }

                // Ensure the stock column is of type decimal
                if (productsTable.Columns["stock"].DataType != typeof(decimal))
                {
                    DataTable tempTable = productsTable.Clone();
                    tempTable.Columns["stock"].DataType = typeof(decimal);
                    foreach (DataRow row in productsTable.Rows)
                    {
                        tempTable.ImportRow(row);
                    }
                    productsTable = tempTable;
                }

                foreach (DataRow row in productsTable.Rows)
                {
                    for (int i = 0; i < productsTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (productsTable.Columns[i].ColumnName != "image_path")
                            {
                                if (productsTable.Columns[i].DataType == typeof(string))
                                {
                                    row[i] = "N/A";
                                }
                                else if (productsTable.Columns[i].DataType == typeof(decimal))
                                {
                                    row[i] = 0.00m;
                                }
                                else if (productsTable.Columns[i].DataType == typeof(int))
                                {
                                    row[i] = 0;
                                }
                            }
                        }
                    }
                }

                bindingSource.DataSource = productsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productsTable = new DataTable();
                productsTable.Columns.Add("id", typeof(int));
                productsTable.Columns.Add("product_name", typeof(string));
                productsTable.Columns.Add("variation_type", typeof(string));
                productsTable.Columns.Add("unit_name", typeof(string));
                productsTable.Columns.Add("stock", typeof(decimal));
                productsTable.Columns.Add("retail_price", typeof(decimal));
                productsTable.Columns.Add("image_path", typeof(byte[]));
                bindingSource.DataSource = productsTable;
            }
        }

        private void quotaProductDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (quotaProductDataGrid.Columns[e.ColumnIndex].Name == "id")
            {
                if (e.Value != null)
                {
                    int productId = Convert.ToInt32(e.Value);
                    e.Value = $"pro{productId:D3}";
                    e.FormattingApplied = true;
                }
            }
            else if (quotaProductDataGrid.Columns[e.ColumnIndex].Name == "stock")
            {
                if (e.Value != null)
                {
                    decimal stock = Convert.ToDecimal(e.Value);
                    string unit = quotaProductDataGrid.Rows[e.RowIndex].Cells["unit_name"].Value?.ToString();

                    if (unit == "Pieces")
                    {
                        e.Value = stock.ToString("F0");
                    }
                    else
                    {
                        e.Value = stock.ToString("F2");
                    }
                    e.FormattingApplied = true;
                }
            }
            else if (quotaProductDataGrid.Columns[e.ColumnIndex].Name != "image_path")
            {
                if (e.Value == DBNull.Value || e.Value == null)
                {
                    e.Value = "N/A";
                    e.FormattingApplied = true;
                }
            }
        }

        private void quotaProductDataGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (quotaProductDataGrid.Columns[e.ColumnIndex].Name == "image_path")
                {
                    e.PaintBackground(e.CellBounds, true);
                    object cellValue = quotaProductDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    byte[] imageData = cellValue as byte[];

                    if (cellValue == null || cellValue == DBNull.Value || (imageData != null && imageData.Length == 0))
                    {
                        string text = "Null";
                        using (System.Drawing.Font font = new System.Drawing.Font("Arial", 10))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                    }
                    else if (imageData != null && imageData.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                Image image = Image.FromStream(ms);
                                e.Graphics.DrawImage(image, e.CellBounds);
                            }
                        }
                        catch
                        {
                            string text = "Null";
                            using (System.Drawing.Font font = new System.Drawing.Font("Arial", 10))
                            {
                                SizeF size = e.Graphics.MeasureString(text, font);
                                PointF location = new PointF(
                                    e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                    e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                                );
                                e.Graphics.DrawString(text, font, Brushes.Black, location);
                            }
                        }
                    }
                    e.Handled = true;
                }
                else if (quotaProductDataGrid.Columns[e.ColumnIndex].Name == "AddColumn")
                {
                    e.PaintBackground(e.CellBounds, true);

                    try
                    {
                        Image addIcon = Properties.Resources.posadd_;
                        int iconSize = 24;
                        int x = e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(addIcon, x, y, iconSize, iconSize);
                    }
                    catch (Exception ex)
                    {
                        string text = "Add";
                        using (System.Drawing.Font font = new System.Drawing.Font("Arial", 8))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                        System.Diagnostics.Debug.WriteLine($"Error loading Add icon: {ex.Message}");
                    }

                    e.Handled = true;
                }
            }
        }

        private void quotaProductDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && quotaProductDataGrid.Columns[e.ColumnIndex].Name == "AddColumn")
            {
                DataGridViewRow row = quotaProductDataGrid.Rows[e.RowIndex];
                decimal stock = Convert.ToDecimal(row.Cells["stock"].Value);
                if (stock <= 0)
                {
                    MessageBox.Show($"Cannot add {row.Cells["product_name"].Value} ({row.Cells["variation_type"].Value}) to quotation. Stock is 0.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string unitName = row.Cells["unit_name"].Value.ToString();
                string productName = row.Cells["product_name"].Value.ToString();
                string variationType = row.Cells["variation_type"].Value.ToString();

                if (unitName == "Kilogram" || unitName == "Liter" || unitName == "Meter")
                {
                    using (POSWeightForm weightForm = new POSWeightForm(unitName, stock, productName, variationType))
                    {
                        if (weightForm.ShowDialog() == DialogResult.OK)
                        {
                            decimal quantity = weightForm.GetQuantity();
                            AddToCart(row, quantity);
                        }
                    }
                }
                else
                {
                    AddToCart(row, 1m);
                }
            }
        }

        private void AddToCart(DataGridViewRow productRow, decimal quantity)
        {
            int productId = Convert.ToInt32(productRow.Cells["id"].Value);
            string productName = productRow.Cells["product_name"].Value.ToString();
            string variationType = productRow.Cells["variation_type"].Value.ToString();
            string unit = productRow.Cells["unit_name"].Value.ToString();
            decimal price = Convert.ToDecimal(productRow.Cells["retail_price"].Value);
            decimal stock = Convert.ToDecimal(productRow.Cells["stock"].Value);

            bool itemExists = false;
            DataGridViewRow existingRow = null;

            foreach (DataGridViewRow cartRow in addQuotaDataGridView.Rows)
            {
                int cartProductId = Convert.ToInt32(cartRow.Cells["product_id"].Value);
                string cartVariationType = cartRow.Cells["variation_type"].Value.ToString();

                if (cartProductId == productId && cartVariationType == variationType)
                {
                    itemExists = true;
                    existingRow = cartRow;
                    break;
                }
            }

            if (itemExists && existingRow != null)
            {
                decimal currentQuantity = Convert.ToDecimal(existingRow.Cells["quantity"].Value);
                decimal newQuantity = currentQuantity + quantity;

                if (newQuantity > stock)
                {
                    MessageBox.Show($"Cannot add more {productName} ({variationType}). Only {stock} in stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                existingRow.Cells["quantity"].Value = newQuantity;
                UpdateTotalPrice(existingRow);
            }
            else
            {
                addQuotaDataGridView.Rows.Add(
                    itemNumberCounter++,
                    productId,
                    productName,
                    variationType,
                    unit,
                    null,
                    quantity,
                    null,
                    price,
                    price * quantity,
                    null
                );
            }

            UpdateAllLabels();
        }

        #endregion

        #region Timer Methods

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            // Assuming you have a label to display time
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            // Assuming you have a label to display date
        }

        #endregion

        #region addQuotaDataGridView Configuration and Event Handling

        private void ConfigureAddQuotaDataGridView()
        {
            addQuotaDataGridView.AutoGenerateColumns = false;
            addQuotaDataGridView.Columns.Clear();

            addQuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "item_number",
                HeaderText = "No",
                Width = 30
            });

            addQuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_id",
                HeaderText = "Product ID",
                Visible = false
            });

            addQuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_name",
                HeaderText = "Name",
                Width = 150
            });

            addQuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "variation_type",
                HeaderText = "Type",
                Width = 80
            });

            addQuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "unit",
                HeaderText = "Unit",
                Width = 120
            });

            DataGridViewButtonColumn decreaseColumn = new DataGridViewButtonColumn
            {
                Name = "decrease",
                HeaderText = "",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 30
            };
            addQuotaDataGridView.Columns.Add(decreaseColumn);

            addQuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "quantity",
                HeaderText = "Quantity",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            DataGridViewButtonColumn increaseColumn = new DataGridViewButtonColumn
            {
                Name = "increase",
                HeaderText = "",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 30
            };
            addQuotaDataGridView.Columns.Add(increaseColumn);

            addQuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "price",
                HeaderText = "Price",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2"
                }
            });

            addQuotaDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "total_price",
                HeaderText = "Total Price",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            DataGridViewButtonColumn removeColumn = new DataGridViewButtonColumn
            {
                Name = "remove",
                HeaderText = "Delete",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 80
            };
            addQuotaDataGridView.Columns.Add(removeColumn);

            addQuotaDataGridView.AllowUserToAddRows = false;

            addQuotaDataGridView.CellPainting += addQuotaDataGridView_CellPainting;
        }

        private void addQuotaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (addQuotaDataGridView.Columns[e.ColumnIndex].Name == "quantity")
            {
                if (e.Value != null)
                {
                    string unit = addQuotaDataGridView.Rows[e.RowIndex].Cells["unit"].Value?.ToString();
                    if (unit == "Pieces")
                    {
                        e.Value = Convert.ToDecimal(e.Value).ToString("F0");
                    }
                    else
                    {
                        e.Value = Convert.ToDecimal(e.Value).ToString("F2");
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void addQuotaDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (addQuotaDataGridView.Columns[e.ColumnIndex].Name == "decrease")
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
                        string text = "-";
                        using (System.Drawing.Font font = new System.Drawing.Font("Arial", 8))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                        System.Diagnostics.Debug.WriteLine($"Error loading minus icon: {ex.Message}");
                    }
                    e.Handled = true;
                }
                else if (addQuotaDataGridView.Columns[e.ColumnIndex].Name == "increase")
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
                        string text = "+";
                        using (System.Drawing.Font font = new System.Drawing.Font("Arial", 8))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                        System.Diagnostics.Debug.WriteLine($"Error loading plus icon: {ex.Message}");
                    }
                    e.Handled = true;
                }
                else if (addQuotaDataGridView.Columns[e.ColumnIndex].Name == "remove")
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
                        string text = "X";
                        using (System.Drawing.Font font = new System.Drawing.Font("Arial", 8))
                        {
                            SizeF size = e.Graphics.MeasureString(text, font);
                            PointF location = new PointF(
                                e.CellBounds.Left + (e.CellBounds.Width - size.Width) / 2,
                                e.CellBounds.Top + (e.CellBounds.Height - size.Height) / 2
                            );
                            e.Graphics.DrawString(text, font, Brushes.Black, location);
                        }
                        System.Diagnostics.Debug.WriteLine($"Error loading delete icon: {ex.Message}");
                    }
                    e.Handled = true;
                }
            }
        }

        private void addQuotaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = addQuotaDataGridView.Rows[e.RowIndex];
                string unit = row.Cells["unit"].Value?.ToString();
                bool isUnitDisabled = unit == "Kilogram" || unit == "Meter" || unit == "Liter";

                if (addQuotaDataGridView.Columns[e.ColumnIndex].Name == "decrease")
                {
                    if (isUnitDisabled)
                    {
                        MessageBox.Show("Cannot modify quantity for items measured in Kilogram, Meter, or Liter directly. Please remove and re-add the item with the correct quantity.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                    if (quantity > 1m)
                    {
                        quantity -= 1m;
                        row.Cells["quantity"].Value = quantity;
                        UpdateTotalPrice(row);
                    }
                }
                else if (addQuotaDataGridView.Columns[e.ColumnIndex].Name == "increase")
                {
                    if (isUnitDisabled)
                    {
                        MessageBox.Show("Cannot modify quantity for items measured in Kilogram, Meter, or Liter directly. Please remove and re-add the item with the correct quantity.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                    string variationType = row.Cells["variation_type"].Value.ToString();

                    decimal stock = 0m;
                    foreach (DataGridViewRow productRow in quotaProductDataGrid.Rows)
                    {
                        if (Convert.ToInt32(productRow.Cells["id"].Value) == productId &&
                            productRow.Cells["variation_type"].Value.ToString() == variationType)
                        {
                            stock = Convert.ToDecimal(productRow.Cells["stock"].Value);
                            break;
                        }
                    }

                    decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                    decimal newQuantity = quantity + 1m;

                    if (newQuantity > stock)
                    {
                        string productName = row.Cells["product_name"].Value.ToString();
                        MessageBox.Show($"Cannot add more {productName} ({variationType}). Only {stock} in stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row.Cells["quantity"].Value = newQuantity;
                    UpdateTotalPrice(row);
                }
                else if (addQuotaDataGridView.Columns[e.ColumnIndex].Name == "remove")
                {
                    addQuotaDataGridView.Rows.RemoveAt(e.RowIndex);
                    ReassignItemNumbers();
                    UpdateAllLabels();
                }
            }
        }

        private void UpdateTotalPrice(DataGridViewRow row)
        {
            decimal price = Convert.ToDecimal(row.Cells["price"].Value);
            decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
            decimal totalPrice = price * quantity;
            row.Cells["total_price"].Value = totalPrice;
            UpdateAllLabels();
        }

        private void ReassignItemNumbers()
        {
            itemNumberCounter = 1;
            foreach (DataGridViewRow row in addQuotaDataGridView.Rows)
            {
                row.Cells["item_number"].Value = itemNumberCounter++;
            }
        }

        private void UpdateAllLabels()
        {
            quotaSubTotLabel_Click(null, null);
            createQuotaDisText_TextChanged(null, null);
            quotaShippingCharge_TextChanged(null, null);
        }

        #endregion

        #region Discount Handling

        private void createQuotaDisText_TextChanged(object sender, EventArgs e)
        {
            decimal discountAmount = 0m;
            decimal subTotal = CalculateSubTotal();

            if (decimal.TryParse(createQuotaDisText.Text, out discountAmount) && discountAmount >= 0)
            {
                UpdateDiscountLabels(discountAmount);
            }
            else
            {
                addQuoDisCostLabel.Text = "0.00";
                decimal total = subTotal + (decimal.TryParse(quotaShippingCharge.Text, out decimal shipping) ? shipping : 0m);
                AddQuoTotAmoCostLabel.Text = total.ToString("N2");
            }
        }

        private decimal CalculateSubTotal()
        {
            decimal subTotal = 0m;
            foreach (DataGridViewRow row in addQuotaDataGridView.Rows)
            {
                subTotal += Convert.ToDecimal(row.Cells["total_price"].Value);
            }
            return subTotal;
        }

        private void UpdateDiscountLabels(decimal discountAmount)
        {
            addQuoDisCostLabel.Text = discountAmount.ToString("N2");
            decimal subTotal = CalculateSubTotal();
            decimal shippingCharge = decimal.TryParse(quotaShippingCharge.Text, out decimal shipping) ? shipping : 0m;
            decimal totalAmount = subTotal - discountAmount + shippingCharge;
            AddQuoTotAmoCostLabel.Text = totalAmount >= 0 ? totalAmount.ToString("N2") : "0.00";
        }

        #endregion

        #region Shipping Charge Handling

        private void quotaShippingCharge_TextChanged(object sender, EventArgs e)
        {
            decimal subTotal = CalculateSubTotal();
            decimal discountAmount = decimal.TryParse(addQuoDisCostLabel.Text, out decimal discount) ? discount : 0m;
            decimal shippingCharge = decimal.TryParse(quotaShippingCharge.Text, out decimal shipping) ? shipping : 0m;
            decimal totalAmount = subTotal - discountAmount + shippingCharge;
            AddQuoTotAmoCostLabel.Text = totalAmount >= 0 ? totalAmount.ToString("N2") : "0.00";
            addQuoShipCostLabel.Text = shippingCharge.ToString("N2");
        }

        #endregion

        #region Label Updates

        private void quotaSubTotLabel_Click(object sender, EventArgs e)
        {
            decimal subTotal = CalculateSubTotal();
            quotaSubTotLabel.Text = subTotal.ToString("N2");
        }

        private void addQuoDisCostLabel_Click(object sender, EventArgs e)
        {
        }

        private void AddQuoTotAmoCostLabel_Click(object sender, EventArgs e)
        {
        }

        private void addQuoShipCostLabel_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Customer Search

        private void createQuoText_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic to validate or search for customer name
        }

        private void createQuoSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = createQuoSearchText.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                bindingSource.Filter = null;
            }
            else
            {
                try
                {
                    // Escape single quotes in the search text to prevent filter errors
                    searchText = searchText.Replace("'", "''");
                    // Use LIKE for product_name and CONVERT for id
                    bindingSource.Filter = $"product_name LIKE '%{searchText}%' OR CONVERT(id, System.String) LIKE '%{searchText}%'";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error applying filter: {ex.Message}", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bindingSource.Filter = null; // Reset filter on error
                }
            }
        }

        #endregion

        #region Form Controls

        private void createQuotaPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void createQuotaDateTime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void createQuotaNoteText_TextChanged(object sender, EventArgs e)
        {
        }

        private void siticoneTextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void printPdfBtn_Click(object sender, EventArgs e)
        {
            if (addQuotaDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No items in the quotation to print.", "Empty Quotation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = decimal.Parse(AddQuoTotAmoCostLabel.Text);
            if (totalAmount <= 0)
            {
                MessageBox.Show("Total amount must be greater than zero.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string quotationNo = "QUOT_" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Step 1: Save data to the database
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        string customerName = createQuoText.Text;
                        DateTime quotationDate = createQuotaDateTime.Value;
                        int totalItems = addQuotaDataGridView.Rows.Count;
                        decimal subTotal = CalculateSubTotal();
                        decimal discountAmount = decimal.TryParse(addQuoDisCostLabel.Text, out decimal discount) ? discount : 0m;
                        decimal shippingCharge = decimal.TryParse(quotaShippingCharge.Text, out decimal shipping) ? shipping : 0m;
                        string shippingAddress = siticoneTextBox4.Text;
                        string notes = createQuotaNoteText.Text;

                        // Insert quotation record
                        string quotationQuery = @"
                            INSERT INTO quotations (quotation_no, customer_name, quotation_date, quantity_of_items, subtotal, discount_amount, shipping_charge, total_amount, shipping_address, notes)
                            VALUES (@quotationNo, @customerName, @quotationDate, @quantityOfItems, @subtotal, @discountAmount, @shippingCharge, @totalAmount, @shippingAddress, @notes)";
                        using (MySqlCommand quotationCommand = new MySqlCommand(quotationQuery, connection, transaction))
                        {
                            quotationCommand.Parameters.AddWithValue("@quotationNo", quotationNo);
                            quotationCommand.Parameters.AddWithValue("@customerName", customerName);
                            quotationCommand.Parameters.AddWithValue("@quotationDate", quotationDate);
                            quotationCommand.Parameters.AddWithValue("@quantityOfItems", totalItems);
                            quotationCommand.Parameters.AddWithValue("@subtotal", subTotal);
                            quotationCommand.Parameters.AddWithValue("@discountAmount", discountAmount);
                            quotationCommand.Parameters.AddWithValue("@shippingCharge", shippingCharge);
                            quotationCommand.Parameters.AddWithValue("@totalAmount", totalAmount);
                            quotationCommand.Parameters.AddWithValue("@shippingAddress", string.IsNullOrEmpty(shippingAddress) ? (object)DBNull.Value : shippingAddress);
                            quotationCommand.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes);
                            quotationCommand.ExecuteNonQuery();
                        }

                        // Insert quotation details
                        string detailsQuery = @"
                            INSERT INTO quotation_details (quotation_no, product_name, variation_type, unit, quantity, price, total_price)
                            VALUES (@quotationNo, @productName, @variationType, @unit, @quantity, @price, @totalPrice)";
                        foreach (DataGridViewRow row in addQuotaDataGridView.Rows)
                        {
                            string variationType = row.Cells["variation_type"].Value.ToString();
                            if (variationType == "N/A") variationType = null;
                            decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);

                            using (MySqlCommand detailsCommand = new MySqlCommand(detailsQuery, connection, transaction))
                            {
                                detailsCommand.Parameters.AddWithValue("@quotationNo", quotationNo);
                                detailsCommand.Parameters.AddWithValue("@productName", row.Cells["product_name"].Value.ToString());
                                detailsCommand.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                detailsCommand.Parameters.AddWithValue("@unit", row.Cells["unit"].Value.ToString());
                                detailsCommand.Parameters.AddWithValue("@quantity", quantity);
                                detailsCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells["price"].Value));
                                detailsCommand.Parameters.AddWithValue("@totalPrice", Convert.ToDecimal(row.Cells["total_price"].Value));
                                detailsCommand.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving quotation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if saving fails
            }

            // Step 2: Generate and print the PDF
            try
            {
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (.pdf)|.pdf";
                    saveFileDialog.FileName = $"Quotation_{quotationNo}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
                    saveFileDialog.Title = "Save Quotation PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    // Create a new MigraDoc document
                    Document document = new Document();
                    document.Info.Title = "Quotation";
                    document.Info.Author = "EscopeWindowsApp";

                    // Add a section to the document
                    Section section = document.AddSection();

                    // Add a title
                    string reportTitle = $"Quotation - {quotationNo} ({DateTime.Now.ToString("yyyy-MM-dd")})";
                    Paragraph title = section.AddParagraph(reportTitle);
                    title.Format.Font.Size = 14;
                    title.Format.Font.Bold = true;
                    title.Format.SpaceAfter = 10;

                    // Add quotation details
                    section.AddParagraph($"Customer Name: {createQuoText.Text}");
                    section.AddParagraph($"Quotation Date: {createQuotaDateTime.Value.ToString("yyyy-MM-dd")}");
                    section.AddParagraph($"Shipping Address: {(string.IsNullOrEmpty(siticoneTextBox4.Text) ? "N/A" : siticoneTextBox4.Text)}");
                    section.AddParagraph($"Notes: {(string.IsNullOrEmpty(createQuotaNoteText.Text) ? "N/A" : createQuotaNoteText.Text)}");
                    section.AddParagraph().Format.SpaceAfter = 10;

                    // Create a table for items
                    Table table = section.AddTable();
                    table.Borders.Width = 0.5;
                    table.Rows.Height = 10;

                    // Define columns
                    table.AddColumn(Unit.FromCentimeter(1));  // No
                    table.AddColumn(Unit.FromCentimeter(4));  // Product Name
                    table.AddColumn(Unit.FromCentimeter(2));  // Variation Type
                    table.AddColumn(Unit.FromCentimeter(2));  // Unit
                    table.AddColumn(Unit.FromCentimeter(2));  // Quantity
                    table.AddColumn(Unit.FromCentimeter(2));  // Price
                    table.AddColumn(Unit.FromCentimeter(2));  // Total Price

                    // Add header row
                    Row headerRow = table.AddRow();
                    headerRow.HeadingFormat = true;
                    headerRow.Format.Font.Bold = true;
                    headerRow.Cells[0].AddParagraph("No");
                    headerRow.Cells[1].AddParagraph("Product Name");
                    headerRow.Cells[2].AddParagraph("Variation Type");
                    headerRow.Cells[3].AddParagraph("Unit");
                    headerRow.Cells[4].AddParagraph("Quantity");
                    headerRow.Cells[5].AddParagraph("Price");
                    headerRow.Cells[6].AddParagraph("Total Price");

                    // Add data rows
                    foreach (DataGridViewRow row in addQuotaDataGridView.Rows)
                    {
                        Row dataRow = table.AddRow();
                        dataRow.Cells[0].AddParagraph(row.Cells["item_number"].Value.ToString());
                        dataRow.Cells[1].AddParagraph(row.Cells["product_name"].Value.ToString());
                        dataRow.Cells[2].AddParagraph(row.Cells["variation_type"].Value.ToString());
                        dataRow.Cells[3].AddParagraph(row.Cells["unit"].Value.ToString());
                        dataRow.Cells[4].AddParagraph(Convert.ToDecimal(row.Cells["quantity"].Value).ToString(row.Cells["unit"].Value.ToString() == "Pieces" ? "F0" : "F2"));
                        dataRow.Cells[5].AddParagraph(Convert.ToDecimal(row.Cells["price"].Value).ToString("F2"));
                        dataRow.Cells[6].AddParagraph(Convert.ToDecimal(row.Cells["total_price"].Value).ToString("F2"));
                    }

                    // Add summary section
                    section.AddParagraph().Format.SpaceBefore = 10;
                    section.AddParagraph($"Subtotal: {quotaSubTotLabel.Text}");
                    section.AddParagraph($"Discount Amount: {addQuoDisCostLabel.Text}");
                    section.AddParagraph($"Shipping Charge: {addQuoShipCostLabel.Text}");
                    section.AddParagraph($"Total Amount: {AddQuoTotAmoCostLabel.Text}").Format.Font.Bold = true;

                    // Render the document to PDF
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
                    renderer.Document = document;
                    renderer.RenderDocument();

                    // Save the PDF to the user-selected location
                    renderer.PdfDocument.Save(saveFileDialog.FileName);

                    MessageBox.Show($"PDF generated successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the PDF in the default browser
                    try
                    {
                        string fileUrl = $"file:///{saveFileDialog.FileName.Replace("\\", "/")}";
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = fileUrl,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening PDF in browser: {ex.Message}. Please ensure a default browser is set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Print the PDF using the default printer via the default PDF viewer
                    try
                    {
                        System.Diagnostics.ProcessStartInfo printInfo = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            Verb = "print",
                            CreateNoWindow = true,
                            WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                            UseShellExecute = true
                        };

                        using (System.Diagnostics.Process printProcess = System.Diagnostics.Process.Start(printInfo))
                        {
                            printProcess.WaitForExit(); // Wait for the printing process to complete
                        }

                        MessageBox.Show("PDF sent to printer successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error printing PDF: {ex.Message}. Ensure a default printer is configured and a PDF viewer supporting printing is installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Reset form after successful save and print
                    quotaCancelBtn_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quotaCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createQuotaNoteLabel_Click(object sender, EventArgs e)
        {
        }

        private void quotaSaveBtn_Click(object sender, EventArgs e)
        {
            if (addQuotaDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No items in the quotation to save.", "Empty Quotation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = decimal.Parse(AddQuoTotAmoCostLabel.Text);
            if (totalAmount <= 0)
            {
                MessageBox.Show("Total amount must be greater than zero.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        string quotationNo = "QUOT_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        string customerName = createQuoText.Text;
                        DateTime quotationDate = createQuotaDateTime.Value;
                        int totalItems = addQuotaDataGridView.Rows.Count;
                        decimal subTotal = CalculateSubTotal();
                        decimal discountAmount = decimal.TryParse(addQuoDisCostLabel.Text, out decimal discount) ? discount : 0m;
                        decimal shippingCharge = decimal.TryParse(quotaShippingCharge.Text, out decimal shipping) ? shipping : 0m;
                        string shippingAddress = siticoneTextBox4.Text;
                        string notes = createQuotaNoteText.Text;

                        // Insert quotation record
                        string quotationQuery = @"
                            INSERT INTO quotations (quotation_no, customer_name, quotation_date, quantity_of_items, subtotal, discount_amount, shipping_charge, total_amount, shipping_address, notes)
                            VALUES (@quotationNo, @customerName, @quotationDate, @quantityOfItems, @subtotal, @discountAmount, @shippingCharge, @totalAmount, @shippingAddress, @notes)";
                        using (MySqlCommand quotationCommand = new MySqlCommand(quotationQuery, connection, transaction))
                        {
                            quotationCommand.Parameters.AddWithValue("@quotationNo", quotationNo);
                            quotationCommand.Parameters.AddWithValue("@customerName", customerName);
                            quotationCommand.Parameters.AddWithValue("@quotationDate", quotationDate);
                            quotationCommand.Parameters.AddWithValue("@quantityOfItems", totalItems);
                            quotationCommand.Parameters.AddWithValue("@subtotal", subTotal);
                            quotationCommand.Parameters.AddWithValue("@discountAmount", discountAmount);
                            quotationCommand.Parameters.AddWithValue("@shippingCharge", shippingCharge);
                            quotationCommand.Parameters.AddWithValue("@totalAmount", totalAmount);
                            quotationCommand.Parameters.AddWithValue("@shippingAddress", string.IsNullOrEmpty(shippingAddress) ? (object)DBNull.Value : shippingAddress);
                            quotationCommand.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes);
                            quotationCommand.ExecuteNonQuery();
                        }

                        // Insert quotation details
                        string detailsQuery = @"
                            INSERT INTO quotation_details (quotation_no, product_name, variation_type, unit, quantity, price, total_price)
                            VALUES (@quotationNo, @productName, @variationType, @unit, @quantity, @price, @totalPrice)";
                        foreach (DataGridViewRow row in addQuotaDataGridView.Rows)
                        {
                            string variationType = row.Cells["variation_type"].Value.ToString();
                            if (variationType == "N/A") variationType = null;
                            decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);

                            using (MySqlCommand detailsCommand = new MySqlCommand(detailsQuery, connection, transaction))
                            {
                                detailsCommand.Parameters.AddWithValue("@quotationNo", quotationNo);
                                detailsCommand.Parameters.AddWithValue("@productName", row.Cells["product_name"].Value.ToString());
                                detailsCommand.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                detailsCommand.Parameters.AddWithValue("@unit", row.Cells["unit"].Value.ToString());
                                detailsCommand.Parameters.AddWithValue("@quantity", quantity);
                                detailsCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells["price"].Value));
                                detailsCommand.Parameters.AddWithValue("@totalPrice", Convert.ToDecimal(row.Cells["total_price"].Value));
                                detailsCommand.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show($"Quotation {quotationNo} saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form after saving
                        quotaCancelBtn_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving quotation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
#endregion