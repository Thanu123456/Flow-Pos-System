using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;

namespace EscopeWindowsApp
{
    public partial class POS : Form
    {
        private Timer timeTimer;       // Timer for time updates
        private Timer dateTimer;       // Timer for date updates
        private DataTable productsTable;
        private BindingSource bindingSource;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private int itemNumberCounter = 1; // To assign unique item numbers in supDataGridView
        private ListBox suggestionListBox; // ListBox for autocomplete suggestions
        private Panel suggestionPanel;      // Panel to wrap ListBox for border
        private Timer searchTimer;         // Timer for delayed search
        private bool suppressTextChanged;  // Flag to prevent recursive TextChanged events
        private string username; // Store username
        private string userEmail;

        public POS(string username, string userEmail)
        {
            InitializeComponent();
            posClientNameLabel.Text = "Walk-In Customer";
            posClientNumLabel.Text = "";

            this.username = username;
            this.userEmail = userEmail;

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

            // Ensure labels can display their content
            posTimeLabel.AutoSize = false;
            posDateLabel.AutoSize = false;

            // Initialize BindingSource and DataTable for products
            bindingSource = new BindingSource();
            productsTable = new DataTable();

            // Disable discountText and payNowBtn by default
            discountText.Enabled = false;
            payNowBtn.Enabled = false;

            posCashRadioBtn.Enabled = true;
            posCashRadioBtn.Checked = true; // Optional: Check by default
            paymentText.Enabled = true;

            // Initialize suggestion ListBox and Panel
            suggestionListBox = new ListBox
            {
                Size = new Size(posCusSearchText.Width, 100), // Match search bar width
                Font = new Font("Calibri", 12),
                Visible = true,
                BorderStyle = BorderStyle.None // No border on ListBox
            };
            suggestionListBox.SelectedIndexChanged += SuggestionListBox_SelectedIndexChanged;
            suggestionListBox.MouseClick += SuggestionListBox_MouseClick;
            suggestionListBox.LostFocus += SuggestionListBox_LostFocus;

            // Create a Panel to wrap the ListBox with a border
            suggestionPanel = new Panel
            {
                Size = new Size(posCusSearchText.Width, 102), // +2 for border
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            // Position the panel directly below the search bar
            Point searchBarLocation = posCusSearchText.Location;
            Point panelLocation = new Point(
                searchBarLocation.X,
                searchBarLocation.Y + posCusSearchText.Height // Attach directly to the bottom
            );

            // Adjust for parent container if posCusSearchText is not directly on the form
            if (posCusSearchText.Parent != this)
            {
                panelLocation = this.PointToClient(posCusSearchText.Parent.PointToScreen(panelLocation));
            }

            suggestionPanel.Location = panelLocation;
            suggestionListBox.Location = new Point(1, 1); // Offset inside panel for border
            suggestionListBox.Size = new Size(suggestionPanel.Width - 2, suggestionPanel.Height - 2);
            suggestionPanel.Controls.Add(suggestionListBox);
            this.Controls.Add(suggestionPanel);

            // Ensure panel repositions if search bar moves or resizes
            posCusSearchText.LocationChanged += (s, e) => UpdateSuggestionPanelPosition();
            posCusSearchText.SizeChanged += (s, e) => UpdateSuggestionPanelPosition();

            // Debug panel position
            Debug.WriteLine($"suggestionPanel.Location: {suggestionPanel.Location}, posCusSearchText: {posCusSearchText.Location}, Height: {posCusSearchText.Height}");

            // Initialize search timer
            searchTimer = new Timer
            {
                Interval = 300 // Delay in milliseconds
            };
            searchTimer.Tick += SearchTimer_Tick;

            // Subscribe to posCusSearchText events
            posCusSearchText.TextChanged += PosCusSearchText_TextChanged;
            posCusSearchText.KeyDown += PosCusSearchText_KeyDown;
            posCusSearchText.GotFocus += PosCusSearchText_GotFocus;
            posCusSearchText.LostFocus += PosCusSearchText_LostFocus;

            // Load product data on form load
            this.Load += POS_Load;
            ConfigureSupDataGridView();

            // Subscribe to events
            posProductDataGrid.CellPainting += posProductDataGrid_CellPainting;
            posProductDataGrid.CellFormatting += posProductDataGrid_CellFormatting;
            supDataGridView.CellFormatting += supDataGridView_CellFormatting;

            // Add KeyPress handlers for numerical input
            discountText.KeyPress += TextBox_NumericalKeyPress;
            paymentText.KeyPress += TextBox_NumericalKeyPress;

            UpdatePayNowButtonState();
        }

        private void UpdateSuggestionPanelPosition()
        {
            if (suggestionPanel != null && posCusSearchText != null)
            {
                Point searchBarLocation = posCusSearchText.Location;
                Point panelLocation = new Point(
                    searchBarLocation.X,
                    searchBarLocation.Y + posCusSearchText.Height
                );
                if (posCusSearchText.Parent != this)
                {
                    panelLocation = this.PointToClient(posCusSearchText.Parent.PointToScreen(panelLocation));
                }
                suggestionPanel.Location = panelLocation;
                suggestionPanel.Width = posCusSearchText.Width;
                suggestionListBox.Width = suggestionPanel.Width - 2;
                suggestionListBox.Height = suggestionPanel.Height - 2;
            }
        }

        private void PosCusSearchText_GotFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(posCusSearchText.Text))
            {
                PerformCustomerSearch();
            }
        }

        private void PosCusSearchText_LostFocus(object sender, EventArgs e)
        {
            // Delay hiding to allow click on ListBox
            Timer hideTimer = new Timer { Interval = 200 };
            hideTimer.Tick += (s, args) =>
            {
                if (!suggestionListBox.Focused && !posCusSearchText.Focused)
                {
                    suggestionPanel.Visible = false;
                }
                hideTimer.Stop();
                hideTimer.Dispose();
            };
            hideTimer.Start();
        }

        private void SuggestionListBox_LostFocus(object sender, EventArgs e)
        {
            if (!posCusSearchText.Focused)
            {
                suggestionPanel.Visible = false;
            }
        }

        private void PosCusSearchText_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();
            PerformCustomerSearch();
        }

        private void PerformCustomerSearch()
        {
            string searchText = posCusSearchText.Text.Trim();
            suggestionListBox.Items.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                suggestionPanel.Visible = false;
                posClientNameLabel.Text = "Walk-In Customer";
                posClientNumLabel.Text = "";
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name, phone FROM customers WHERE name LIKE @search OR phone LIKE @search LIMIT 10";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", $"%{searchText}%");
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader["name"].ToString();
                                string phone = reader["phone"].ToString();
                                suggestionListBox.Items.Add(new CustomerItem(name, phone));
                            }
                        }
                    }
                }

                if (suggestionListBox.Items.Count > 0)
                {
                    // Update panel position and size
                    UpdateSuggestionPanelPosition();

                    suggestionPanel.Visible = true;
                    suggestionPanel.BringToFront();
                    // Adjust Panel height based on items, max 5 visible items
                    int itemHeight = suggestionListBox.ItemHeight;
                    int maxVisibleItems = Math.Min(suggestionListBox.Items.Count, 5);
                    int newHeight = maxVisibleItems * itemHeight + 2; // +2 for border
                    suggestionPanel.Height = newHeight;
                    suggestionListBox.Height = newHeight - 2;
                    suggestionListBox.Width = suggestionPanel.Width - 2;
                }
                else
                {
                    suggestionPanel.Visible = false;
                    posClientNameLabel.Text = "Not Found";
                    posClientNumLabel.Text = "Not Found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                suggestionPanel.Visible = false;
                posClientNameLabel.Text = "Error";
                posClientNumLabel.Text = "Error";
            }
        }

        private void PosCusSearchText_KeyDown(object sender, KeyEventArgs e)
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
                            SelectCustomer();
                        }
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.Escape:
                        suggestionPanel.Visible = false;
                        posCusSearchText.Text = "";
                        posClientNameLabel.Text = "Walk-In Customer";
                        posClientNumLabel.Text = "";
                        e.Handled = true;
                        break;
                }
            }
        }

        private void SuggestionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suggestionListBox.SelectedIndex >= 0)
            {
                CustomerItem selected = (CustomerItem)suggestionListBox.SelectedItem;
                suppressTextChanged = true;
                posCusSearchText.Text = selected.Name;
                suppressTextChanged = false;
            }
        }

        private void SuggestionListBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectCustomer();
        }

        private void SelectCustomer()
        {
            if (suggestionListBox.SelectedIndex >= 0)
            {
                CustomerItem selected = (CustomerItem)suggestionListBox.SelectedItem;
                posClientNameLabel.Text = selected.Name;
                posClientNumLabel.Text = selected.Phone;
                suggestionPanel.Visible = false;
                posCusSearchText.Text = selected.Name;
            }
        }

        private class CustomerItem
        {
            public string Name { get; }
            public string Phone { get; }

            public CustomerItem(string name, string phone)
            {
                Name = name;
                Phone = phone;
            }

            public override string ToString()
            {
                return $"{Name} ({Phone})";
            }
        }

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

        private void POS_Load(object sender, EventArgs e)
        {
            LoadProductsData();
            ConfigureDataGridView();
            posProductDataGrid.DataSource = bindingSource;
        }

        #region posProductDataGrid Methods

        private void ConfigureDataGridView()
        {
            posProductDataGrid.AutoGenerateColumns = false;
            posProductDataGrid.Columns.Clear();

            // Add image column
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                DataPropertyName = "image_path",
                Name = "image_path",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 80
            };
            posProductDataGrid.Columns.Add(imageColumn);

            // Add product ID column
            posProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "Product ID",
                Width = 80
            });

            // Add product name column
            posProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                Name = "product_name",
                HeaderText = "Product Name",
                Width = 150
            });

            // Add variation type column
            posProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_type",
                Name = "variation_type",
                HeaderText = "Variation Type",
                Width = 100
            });

            // Add unit column
            posProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit_name",
                Name = "unit_name",
                HeaderText = "Unit",
                Width = 80
            });

            // Add stock column
            posProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "stock",
                Name = "stock",
                HeaderText = "Stock",
                Width = 80
            });

            // Add retail price column
            posProductDataGrid.Columns.Add(new DataGridViewTextBoxColumn
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
            posProductDataGrid.Columns.Add(addColumn);

            posProductDataGrid.AllowUserToAddRows = false;
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

        private void posProductDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (posProductDataGrid.Columns[e.ColumnIndex].Name == "id")
            {
                if (e.Value != null)
                {
                    int productId = Convert.ToInt32(e.Value);
                    e.Value = $"pro{productId:D3}";
                    e.FormattingApplied = true;
                }
            }
            else if (posProductDataGrid.Columns[e.ColumnIndex].Name == "stock")
            {
                if (e.Value != null)
                {
                    decimal stock = Convert.ToDecimal(e.Value);
                    string unit = posProductDataGrid.Rows[e.RowIndex].Cells["unit_name"].Value?.ToString();

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
            else if (posProductDataGrid.Columns[e.ColumnIndex].Name != "image_path")
            {
                if (e.Value == DBNull.Value || e.Value == null)
                {
                    e.Value = "N/A";
                    e.FormattingApplied = true;
                }
            }
        }

        private void posProductDataGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (posProductDataGrid.Columns[e.ColumnIndex].Name == "image_path")
                {
                    e.PaintBackground(e.CellBounds, true);
                    object cellValue = posProductDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    byte[] imageData = cellValue as byte[];

                    if (cellValue == null || cellValue == DBNull.Value || (imageData != null && imageData.Length == 0))
                    {
                        string text = "Null";
                        using (Font font = new Font("Arial", 10))
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
                            using (Font font = new Font("Arial", 10))
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
                else if (posProductDataGrid.Columns[e.ColumnIndex].Name == "AddColumn")
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
                        using (Font font = new Font("Arial", 8))
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

        private void posProductDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && posProductDataGrid.Columns[e.ColumnIndex].Name == "AddColumn")
            {
                DataGridViewRow row = posProductDataGrid.Rows[e.RowIndex];
                decimal stock = Convert.ToDecimal(row.Cells["stock"].Value);
                if (stock <= 0)
                {
                    MessageBox.Show($"Cannot add {row.Cells["product_name"].Value} ({row.Cells["variation_type"].Value}) to cart. Stock is 0.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            foreach (DataGridViewRow cartRow in supDataGridView.Rows)
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
                supDataGridView.Rows.Add(
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

        #region Timer Methods

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            posTimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt") + "\n" + DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            posDateLabel.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy");
        }

        #endregion

        #region supDataGridView Configuration and Event Handling

        private void ConfigureSupDataGridView()
        {
            supDataGridView.AutoGenerateColumns = false;
            supDataGridView.Columns.Clear();

            // Set the row height to 35 pixels
            supDataGridView.RowTemplate.Height = 35;

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "item_number",
                HeaderText = "No",
                Width = 30
            });

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_id",
                HeaderText = "Product ID",
                Visible = false
            });

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "product_name",
                HeaderText = "Name",
                Width = 150
            });

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "variation_type",
                HeaderText = "Type",
                Width = 80
            });

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
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
            supDataGridView.Columns.Add(decreaseColumn);

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
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
            supDataGridView.Columns.Add(increaseColumn);

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "price",
                HeaderText = "Price",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N2"
                }
            });

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
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
            supDataGridView.Columns.Add(removeColumn);

            supDataGridView.AllowUserToAddRows = false;

            supDataGridView.CellPainting += supDataGridView_CellPainting;
        }

        private void supDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (supDataGridView.Columns[e.ColumnIndex].Name == "quantity")
            {
                if (e.Value != null)
                {
                    string unit = supDataGridView.Rows[e.RowIndex].Cells["unit"].Value?.ToString();
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

        private void supDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (supDataGridView.Columns[e.ColumnIndex].Name == "decrease")
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
                        using (Font font = new Font("Arial", 8))
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
                else if (supDataGridView.Columns[e.ColumnIndex].Name == "increase")
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
                        using (Font font = new Font("Arial", 8))
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
                else if (supDataGridView.Columns[e.ColumnIndex].Name == "remove")
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
                        using (Font font = new Font("Arial", 8))
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

        private void supDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = supDataGridView.Rows[e.RowIndex];
                string unit = row.Cells["unit"].Value?.ToString();
                bool isUnitDisabled = unit == "Kilogram" || unit == "Meter" || unit == "Liter";

                if (supDataGridView.Columns[e.ColumnIndex].Name == "decrease")
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
                else if (supDataGridView.Columns[e.ColumnIndex].Name == "increase")
                {
                    if (isUnitDisabled)
                    {
                        MessageBox.Show("Cannot modify quantity for items measured in Kilogram, Meter, or Liter directly. Please remove and re-add the item with the correct quantity.", "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                    string variationType = row.Cells["variation_type"].Value.ToString();

                    decimal stock = 0m;
                    foreach (DataGridViewRow productRow in posProductDataGrid.Rows)
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
                else if (supDataGridView.Columns[e.ColumnIndex].Name == "remove")
                {
                    supDataGridView.Rows.RemoveAt(e.RowIndex);
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
            foreach (DataGridViewRow row in supDataGridView.Rows)
            {
                row.Cells["item_number"].Value = itemNumberCounter++;
            }
        }

        private void UpdateAllLabels()
        {
            totQtyCountLabel_Click(null, null);
            subTotPriLabel_Click(null, null);
            discountText_TextChanged(null, null);
            paymentText_TextChanged(null, null);
        }

        #endregion

        #region Discount Handling

        private void disFixedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (disFixedRadioBtn.Checked)
            {
                discountText.Text = "";
                discountText.Enabled = true;
            }
            else if (!disPercentageRadioBtn.Checked)
            {
                discountText.Enabled = false;
            }
        }

        private void disPercentageRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (disPercentageRadioBtn.Checked)
            {
                discountText.Text = "";
                discountText.Enabled = true;
                discountText.Text += "%";
            }
            else if (!disFixedRadioBtn.Checked)
            {
                discountText.Enabled = false;
            }
        }

        private void discountText_TextChanged(object sender, EventArgs e)
        {
            decimal discountAmount = 0m;
            decimal subTotal = CalculateSubTotal();

            if (disFixedRadioBtn.Checked)
            {
                if (decimal.TryParse(discountText.Text, out discountAmount) && discountAmount >= 0)
                {
                    UpdateDiscountLabels(discountAmount);
                }
                else
                {
                    discountPriLabel.Text = "0.00";
                    totPriceCountLabel.Text = subTotal.ToString("N2");
                }
            }
            else if (disPercentageRadioBtn.Checked)
            {
                string text = discountText.Text.Replace("%", "").Trim();
                if (decimal.TryParse(text, out decimal discountPercentage) && discountPercentage >= 0 && discountPercentage <= 100)
                {
                    discountAmount = (subTotal * discountPercentage) / 100;
                    UpdateDiscountLabels(discountAmount);
                }
                else
                {
                    discountPriLabel.Text = "0.00";
                    totPriceCountLabel.Text = subTotal.ToString("N2");
                }
            }
            else
            {
                discountPriLabel.Text = "0.00";
                totPriceCountLabel.Text = subTotal.ToString("N2");
            }
        }

        private decimal CalculateSubTotal()
        {
            decimal subTotal = 0m;
            foreach (DataGridViewRow row in supDataGridView.Rows)
            {
                subTotal += Convert.ToDecimal(row.Cells["total_price"].Value);
            }
            return subTotal;
        }

        private void UpdateDiscountLabels(decimal discountAmount)
        {
            discountPriLabel.Text = discountAmount.ToString("N2");
            decimal subTotal = CalculateSubTotal();
            decimal totalPrice = subTotal - discountAmount;
            totPriceCountLabel.Text = totalPrice >= 0 ? totalPrice.ToString("N2") : "0.00";
            paymentText_TextChanged(null, null);
        }

        #endregion

        #region Payment Handling

        private void posCashRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (posCashRadioBtn.Checked)
            {
                paymentText.Enabled = true;
            }
            UpdatePayNowButtonState();
        }

        private void posCardRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (posCardRadioBtn.Checked)
            {
                paymentText.Enabled = false;
                paymentText.Text = "";
            }
            UpdatePayNowButtonState();
        }

        private void UpdatePayNowButtonState()
        {
            payNowBtn.Enabled = posCashRadioBtn.Checked || posCardRadioBtn.Checked;
        }

        private void paymentText_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(paymentText.Text, out decimal paymentAmount) && paymentAmount >= 0)
            {
                decimal totalPrice = decimal.Parse(totPriceCountLabel.Text);
                decimal balance = paymentAmount - totalPrice;
                balancePriceCountLabel.Text = balance.ToString("N2");
            }
            else
            {
                balancePriceCountLabel.Text = "0.00";
            }
        }

        #endregion

        #region Label Updates

        private void totQtyCountLabel_Click(object sender, EventArgs e)
        {
            int totalItems = supDataGridView.Rows.Count;
            totQtyCountLabel.Text = totalItems.ToString();
        }

        private void subTotPriLabel_Click(object sender, EventArgs e)
        {
            decimal subTotal = CalculateSubTotal();
            subTotPriLabel.Text = subTotal.ToString("N2");
        }

        private void discountPriLabel_Click(object sender, EventArgs e)
        {
        }

        private void totPriceCountLabel_Click(object sender, EventArgs e)
        {
        }

        private void balancePriceCountLabel_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Reset Functionality

        private void resetBtn_Click(object sender, EventArgs e)
        {
            supDataGridView.Rows.Clear();
            discountText.Text = "";
            paymentText.Text = "";
            totQtyCountLabel.Text = "0";
            subTotPriLabel.Text = "0.00";
            discountPriLabel.Text = "0.00";
            totPriceCountLabel.Text = "0.00";
            balancePriceCountLabel.Text = "0.00";
            disFixedRadioBtn.Checked = false;
            disPercentageRadioBtn.Checked = false;
            posCashRadioBtn.Checked = true;
            posCardRadioBtn.Checked = false;
            posCashRadioBtn.Enabled = true;
            itemNumberCounter = 1;
            paymentText.Enabled = true;
            posCusSearchText.Text = ""; // Clear the search text
            suggestionPanel.Visible = false; // Hide the suggestion Panel
            UpdatePayNowButtonState();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void cashBookBtn_Click_1(object sender, EventArgs e)
        {
            cashBooktimer.Start();
        }

        private void posClientNameLabel_Click(object sender, EventArgs e) { }
        private void posClientNumLabel_Click(object sender, EventArgs e) { }

        private void posCreateCusBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddCustomerForm)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = siticoneTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                bindingSource.Filter = null;
            }
            else
            {
                bindingSource.Filter = $"product_name LIKE '%{searchText}%'";
            }
        }

        private void posDateLabel_Click(object sender, EventArgs e)
        {
            posDateLabel.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy");
        }

        private void posHoldFormBtn_Click(object sender, EventArgs e) { }
        private void posTimeLabel_Click(object sender, EventArgs e) { }

        #endregion

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void payNowBtn_Click(object sender, EventArgs e)
        {
            if (supDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No items in the cart to process payment.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPrice = decimal.Parse(totPriceCountLabel.Text);
            string paymentMethod = posCashRadioBtn.Checked ? "Cash" : posCardRadioBtn.Checked ? "Card" : "Not Specified";

            if (posCashRadioBtn.Checked && (!decimal.TryParse(paymentText.Text, out decimal paymentAmount) || paymentAmount < totalPrice))
            {
                MessageBox.Show("Please enter a valid payment amount greater than or equal to the total price.", "Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        string billNo = "BILL_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        string customerName = posClientNameLabel.Text;
                        string userName = "Cashier";
                        int totalItems = supDataGridView.Rows.Count;

                        // Insert sale record
                        string salesQuery = @"
                    INSERT INTO sales (bill_no, customer, user_name, quantity_of_items, payment_method, total_price)
                    VALUES (@billNo, @customer, @userName, @quantityOfItems, @paymentMethod, @totalPrice)";
                        using (MySqlCommand salesCommand = new MySqlCommand(salesQuery, connection, transaction))
                        {
                            salesCommand.Parameters.AddWithValue("@billNo", billNo);
                            salesCommand.Parameters.AddWithValue("@customer", customerName);
                            salesCommand.Parameters.AddWithValue("@userName", userName);
                            salesCommand.Parameters.AddWithValue("@quantityOfItems", totalItems);
                            salesCommand.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                            salesCommand.Parameters.AddWithValue("@totalPrice", totalPrice);
                            salesCommand.ExecuteNonQuery();
                        }

                        // Insert sales details and update stock
                        string detailsQuery = @"
                    INSERT INTO sales_details (bill_no, product_name, variation_type, unit, quantity, price, total_price)
                    VALUES (@billNo, @productName, @variationType, @unit, @quantity, @price, @totalPrice)";
                        string updateStockQuery = @"
                    UPDATE stock 
                    SET stock = stock - @quantity 
                    WHERE product_id = @productId 
                    AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))
                    LIMIT 1";

                        foreach (DataGridViewRow row in supDataGridView.Rows)
                        {
                            int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                            string variationType = row.Cells["variation_type"].Value.ToString();
                            if (variationType == "N/A") variationType = null;
                            decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);

                            // Insert sales details
                            using (MySqlCommand detailsCommand = new MySqlCommand(detailsQuery, connection, transaction))
                            {
                                detailsCommand.Parameters.AddWithValue("@billNo", billNo);
                                detailsCommand.Parameters.AddWithValue("@productName", row.Cells["product_name"].Value.ToString());
                                detailsCommand.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                detailsCommand.Parameters.AddWithValue("@unit", row.Cells["unit"].Value.ToString());
                                detailsCommand.Parameters.AddWithValue("@quantity", quantity);
                                detailsCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells["price"].Value));
                                detailsCommand.Parameters.AddWithValue("@totalPrice", Convert.ToDecimal(row.Cells["total_price"].Value));
                                detailsCommand.ExecuteNonQuery();
                            }

                            // Update stock
                            using (MySqlCommand stockCommand = new MySqlCommand(updateStockQuery, connection, transaction))
                            {
                                stockCommand.Parameters.AddWithValue("@quantity", quantity);
                                stockCommand.Parameters.AddWithValue("@productId", productId);
                                stockCommand.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                int rowsAffected = stockCommand.ExecuteNonQuery();
                                Debug.WriteLine($"Stock update for Product ID {productId}, Variation: {variationType ?? "NULL"}, Quantity: {quantity}, Rows Affected: {rowsAffected}");
                                if (rowsAffected == 0)
                                {
                                    MessageBox.Show($"Warning: Stock not updated for Product ID {productId}, Variation: {variationType ?? "NULL"}", "Stock Update Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (rowsAffected > 1)
                                {
                                    MessageBox.Show($"Error: Multiple stock rows updated for Product ID {productId}, Variation: {variationType ?? "NULL"}. Please check the stock table for duplicates.", "Stock Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        transaction.Commit();

                        UpdateSessionManager(paymentMethod, totalPrice);

                        // Prepare cart items for printing
                        List<BillPrinter.CartItem> cartItems = new List<BillPrinter.CartItem>();
                        foreach (DataGridViewRow row in supDataGridView.Rows)
                        {
                            cartItems.Add(new BillPrinter.CartItem
                            {
                                ItemNumber = Convert.ToInt32(row.Cells["item_number"].Value),
                                ProductName = row.Cells["product_name"].Value.ToString(),
                                VariationType = row.Cells["variation_type"].Value.ToString(),
                                Unit = row.Cells["unit"].Value.ToString(),
                                Quantity = Convert.ToDecimal(row.Cells["quantity"].Value),
                                Price = Convert.ToDecimal(row.Cells["price"].Value),
                                TotalPrice = Convert.ToDecimal(row.Cells["total_price"].Value)
                            });
                        }

                        decimal discount = decimal.Parse(discountPriLabel.Text);
                        decimal cashPaid = posCashRadioBtn.Checked ? decimal.Parse(paymentText.Text) : 0m;
                        decimal balance = posCashRadioBtn.Checked ? decimal.Parse(balancePriceCountLabel.Text) : 0m;

                        BillPrinter.PrintBill(billNo, customerName, userName, totalItems, paymentMethod, totalPrice, discount, cashPaid, balance, cartItems, paymentMethod == "Card");

                        // Reset form and refresh products
                        resetBtn_Click(sender, e);
                        LoadProductsData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool btnExpand = false;
        private void cashBooktimer_Tick(object sender, EventArgs e)
        {
            if (btnExpand == false)
            {
                cashBookFlowPanel.Height += 10;
                if (cashBookFlowPanel.Height >= 123)
                {
                    cashBooktimer.Stop();
                    btnExpand = true;
                }
            }
            else
            {
                cashBookFlowPanel.Height -= 10;
                if (cashBookFlowPanel.Height <= 41)
                {
                    cashBooktimer.Stop();
                    btnExpand = false;
                }
            }
        }

        private void cashRegBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CashBookDetails)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            CashBookDetails cashBookDetails = new CashBookDetails();
            cashBookDetails.Show();
        }

        private void closeRegBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CloseRegister)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            CloseRegister closeRegister = new CloseRegister();
            closeRegister.Show();
        }

        private void UpdateSessionManager(string paymentMethod, decimal totalPrice)
        {
            if (paymentMethod == "Cash")
            {
                SessionManager.Cash += totalPrice;
            }
            else if (paymentMethod == "Card")
            {
                SessionManager.Card += totalPrice;
            }
            SessionManager.TotalSales += totalPrice;
        }

        private void refundBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Refund)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            Refund refund = new Refund();
            refund.Show();
        }

        private void userPOSProfileBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is LogOutForm)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            LogOutForm logOutForm = new LogOutForm(this.username, this.userEmail);
            logOutForm.Show();
        }
    }
}
#endregion