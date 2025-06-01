using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Diagnostics;
using System.Configuration;
using System.Linq;

namespace EscopeWindowsApp
{
    public partial class POS : Form
    {
        private Timer timeTimer;
        private Timer dateTimer;
        private DataTable productsTable;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private int itemNumberCounter = 1;
        private ListBox suggestionListBox;
        private Panel suggestionPanel;
        private Timer searchTimer;
        private bool suppressTextChanged;
        private string username;
        private string userEmail;
        private TextBox scannerInputTextBox;

        // Panel-related fields for product display
        private int currentPage = 0;
        private const int itemsPerPage = 6;
        private Panel[] proPanels;
        private PictureBox[] productPictureBoxes;
        private Label[] productLabels;
        private Label[] proPriceLabels;

        public POS(string username, string userEmail)
        {
            InitializeComponent();
            posClientNameLabel.Text = "Walk-In Customer";
            posClientNumLabel.Text = "";

            this.username = username;
            this.userEmail = userEmail;

            LoadCompanyDetails();

            timeTimer = new Timer();
            timeTimer.Interval = 1000;
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();

            dateTimer = new Timer();
            dateTimer.Interval = 1000;
            dateTimer.Tick += DateTimer_Tick;
            dateTimer.Start();

            posTimeLabel.AutoSize = false;
            posDateLabel.AutoSize = false;

            productsTable = new DataTable();

            discountText.Enabled = false;
            payNowBtn.Enabled = false;

            posCashRadioBtn.Enabled = true;
            posCashRadioBtn.Checked = true;
            paymentText.Enabled = true;

            suggestionListBox = new ListBox
            {
                Size = new Size(posCusSearchText.Width, 100),
                Font = new Font("Calibri", 12),
                Visible = true,
                BorderStyle = BorderStyle.None
            };
            suggestionListBox.SelectedIndexChanged += SuggestionListBox_SelectedIndexChanged;
            suggestionListBox.MouseClick += SuggestionListBox_MouseClick;
            suggestionListBox.LostFocus += SuggestionListBox_LostFocus;

            suggestionPanel = new Panel
            {
                Size = new Size(posCusSearchText.Width, 102),
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

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
            suggestionListBox.Location = new Point(1, 1);
            suggestionListBox.Size = new Size(suggestionPanel.Width - 2, suggestionPanel.Height - 2);
            suggestionPanel.Controls.Add(suggestionListBox);
            this.Controls.Add(suggestionPanel);

            posCusSearchText.LocationChanged += (s, e) => UpdateSuggestionPanelPosition();
            posCusSearchText.SizeChanged += (s, e) => UpdateSuggestionPanelPosition();

            searchTimer = new Timer
            {
                Interval = 300
            };
            searchTimer.Tick += SearchTimer_Tick;

            posCusSearchText.TextChanged += PosCusSearchText_TextChanged;
            posCusSearchText.KeyDown += PosCusSearchText_KeyDown;
            posCusSearchText.GotFocus += PosCusSearchText_GotFocus;
            posCusSearchText.LostFocus += PosCusSearchText_LostFocus;

            scannerInputTextBox = new TextBox
            {
                Location = new Point(-100, -100),
                Size = new Size(0, 0),
                Multiline = false
            };
            scannerInputTextBox.KeyPress += ScannerInputTextBox_KeyPress;
            this.Controls.Add(scannerInputTextBox);

            this.Load += POS_Load;
            ConfigureSupDataGridView();

            discountText.KeyPress += TextBox_NumericalKeyPress;
            paymentText.KeyPress += TextBox_NumericalKeyPress;

            UpdatePayNowButtonState();

            InitializeProductPanels();
        }

        private void InitializeProductPanels()
        {
            proPanels = new Panel[] { proPanel1, proPanel2, proPanel3, proPanel4, proPanel5, proPanel6 };
            productPictureBoxes = new PictureBox[] { productPictureBox1, productPictureBox2, productPictureBox3, productPictureBox4, productPictureBox5, productPictureBox6 };
            productLabels = new Label[] { productLabel1, productLabel2, productLabel3, productLabel4, productLabel5, productLabel6 };
            proPriceLabels = new Label[] { proPriceLabel1, proPriceLabel2, proPriceLabel3, proPriceLabel4, proPriceLabel5, proPriceLabel6 };

            foreach (var panel in proPanels)
            {
                panel.Click += ProductPanel_Click;
            }
            foreach (var pb in productPictureBoxes)
            {
                pb.Click += ProductPanel_Click;
            }
            foreach (var label in productLabels)
            {
                label.Click += ProductPanel_Click;
            }
            foreach (var priceLabel in proPriceLabels)
            {
                priceLabel.Click += ProductPanel_Click;
            }
        }

        private void POS_Load(object sender, EventArgs e)
        {
            LoadProductsData();
            DisplayProducts();
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
                                    row[i] = "N/A";
                                else if (productsTable.Columns[i].DataType == typeof(decimal))
                                    row[i] = 0.00m;
                                else if (productsTable.Columns[i].DataType == typeof(int))
                                    row[i] = 0;
                            }
                        }
                    }
                }
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
            }
        }

        private void DisplayProducts()
        {
            int startIndex = currentPage * itemsPerPage;
            for (int i = 0; i < itemsPerPage; i++)
            {
                int rowIndex = startIndex + i;
                if (rowIndex < productsTable.DefaultView.Count)
                {
                    DataRowView rowView = productsTable.DefaultView[rowIndex];
                    DataRow row = rowView.Row;
                    proPanels[i].Tag = rowIndex;
                    productPictureBoxes[i].Image = GetProductImage(row);
                    productLabels[i].Text = row["product_name"].ToString();
                    proPriceLabels[i].Text = Convert.ToDecimal(row["retail_price"]).ToString("N2");
                    proPanels[i].Visible = true;
                }
                else
                {
                    proPanels[i].Tag = null;
                    productPictureBoxes[i].Image = null;
                    productLabels[i].Text = "";
                    proPriceLabels[i].Text = "";
                    proPanels[i].Visible = false;
                }
            }
            productPrevBtn.Enabled = currentPage > 0;
            productNextBtn.Enabled = (startIndex + itemsPerPage < productsTable.DefaultView.Count);
        }

        private Image GetProductImage(DataRow row)
        {
            if (row["image_path"] != DBNull.Value && row["image_path"] is byte[] imageData && imageData.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        return Image.FromStream(ms);
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        private void ProductPanel_Click(object sender, EventArgs e)
        {
            Panel panel = null;
            if (sender is Panel)
            {
                panel = sender as Panel;
            }
            else if (sender is Control)
            {
                panel = (sender as Control).Parent as Panel;
            }
            if (panel != null && panel.Tag != null)
            {
                int index = (int)panel.Tag;
                DataRowView rowView = productsTable.DefaultView[index];
                DataRow row = rowView.Row;
                int productId = Convert.ToInt32(row["id"]);
                string productName = row["product_name"].ToString();
                string variationType = row["variation_type"].ToString();
                string unit = row["unit_name"].ToString();
                decimal price = Convert.ToDecimal(row["retail_price"]);
                decimal stock = Convert.ToDecimal(row["stock"]);

                if (stock <= 0)
                {
                    MessageBox.Show($"Cannot add {productName} ({variationType}) to cart. Stock is 0.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (unit == "Kilogram" || unit == "Liter" || unit == "Meter")
                {
                    using (POSWeightForm weightForm = new POSWeightForm(unit, stock, productName, variationType))
                    {
                        if (weightForm.ShowDialog() == DialogResult.OK)
                        {
                            decimal quantity = weightForm.GetQuantity();
                            AddToCart(productId, productName, variationType, unit, price, stock, quantity);
                        }
                    }
                }
                else
                {
                    AddToCart(productId, productName, variationType, unit, price, stock, 1m);
                }
            }
        }

        private void AddToCart(int productId, string productName, string variationType, string unit, decimal price, decimal stock, decimal quantity)
        {
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

        private void productNextBtn_Click(object sender, EventArgs e)
        {
            if ((currentPage + 1) * itemsPerPage < productsTable.DefaultView.Count)
            {
                currentPage++;
                DisplayProducts();
            }
        }

        private void productPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayProducts();
            }
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = siticoneTextBox1.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                productsTable.DefaultView.RowFilter = null;
            }
            else
            {
                productsTable.DefaultView.RowFilter = $"product_name LIKE '%{searchText}%'";
            }
            currentPage = 0;
            DisplayProducts();
        }

        private void ScannerInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string barcode = scannerInputTextBox.Text.Trim();
                if (!string.IsNullOrEmpty(barcode))
                {
                    ProcessScannedBarcode(barcode);
                }
                scannerInputTextBox.Clear();
                e.Handled = true;
            }
        }

        private void ProcessScannedBarcode(string barcode)
        {
            try
            {
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
                        WHERE p.barcode = @barcode
                        GROUP BY p.id, p.name, pr.variation_type, u.unit_name, pr.retail_price, p.image_path
                        LIMIT 1";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@barcode", barcode);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int productId = reader.GetInt32("id");
                                string productName = reader.GetString("product_name");
                                string variationType = reader["variation_type"] != DBNull.Value ? reader.GetString("variation_type") : "N/A";
                                string unitName = reader["unit_name"] != DBNull.Value ? reader.GetString("unit_name") : "N/A";
                                decimal stock = reader.GetDecimal("stock");
                                decimal price = reader.GetDecimal("retail_price");

                                if (stock <= 0)
                                {
                                    MessageBox.Show($"Cannot add {productName} ({variationType}) to cart. Stock is 0.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                if (unitName == "Kilogram" || unitName == "Liter" || unitName == "Meter")
                                {
                                    using (POSWeightForm weightForm = new POSWeightForm(unitName, stock, productName, variationType))
                                    {
                                        if (weightForm.ShowDialog() == DialogResult.OK)
                                        {
                                            decimal quantity = weightForm.GetQuantity();
                                            AddToCart(productId, productName, variationType, unitName, price, stock, quantity);
                                        }
                                    }
                                }
                                else
                                {
                                    AddToCart(productId, productName, variationType, unitName, price, stock, 1m);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Product with barcode {barcode} not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing barcode: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetStock(int productId, string variationType)
        {
            DataRow[] rows = productsTable.Select($"id = {productId} AND variation_type = '{variationType}'");
            return rows.Length > 0 ? Convert.ToDecimal(rows[0]["stock"]) : 0m;
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            posTimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt") + "\n" + DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            posDateLabel.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy");
        }

        private void ConfigureSupDataGridView()
        {
            supDataGridView.AutoGenerateColumns = false;
            supDataGridView.Columns.Clear();

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
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
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
                HeaderText = "",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 80
            };
            supDataGridView.Columns.Add(removeColumn);

            supDataGridView.AllowUserToAddRows = false;

            supDataGridView.CellPainting += supDataGridView_CellPainting;
            supDataGridView.CellFormatting += supDataGridView_CellFormatting;
            supDataGridView.CellContentClick += supDataGridView_CellContentClick;
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
                    decimal stock = GetStock(productId, variationType);
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
            posCusSearchText.Text = "";
            suggestionPanel.Visible = false;
            UpdatePayNowButtonState();
        }

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

        private void posDateLabel_Click(object sender, EventArgs e)
        {
            posDateLabel.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy");
        }

        private void posHoldFormBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is HoldForm)
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
            HoldForm holdForm = new HoldForm(this);
            holdForm.Show();
        }

        private void posTimeLabel_Click(object sender, EventArgs e) { }

        private void companyNameLabel_Click(object sender, EventArgs e)
        {
        }

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

                        var stockKeys = supDataGridView.Rows.Cast<DataGridViewRow>()
                            .Select(row => new
                            {
                                ProductId = Convert.ToInt32(row.Cells["product_id"].Value),
                                VariationType = row.Cells["variation_type"].Value.ToString()
                            })
                            .Distinct()
                            .ToList();

                        string lockQuery = "SELECT product_id, variation_type, stock FROM stock WHERE ";
                        for (int i = 0; i < stockKeys.Count; i++)
                        {
                            if (i > 0) lockQuery += " OR ";
                            lockQuery += $"(product_id = @pid{i} AND variation_type = @vtype{i})";
                        }
                        lockQuery += " FOR UPDATE";

                        using (MySqlCommand lockCmd = new MySqlCommand(lockQuery, connection, transaction))
                        {
                            for (int i = 0; i < stockKeys.Count; i++)
                            {
                                lockCmd.Parameters.AddWithValue($"@pid{i}", stockKeys[i].ProductId);
                                lockCmd.Parameters.AddWithValue($"@vtype{i}", stockKeys[i].VariationType == "N/A" ? (object)DBNull.Value : stockKeys[i].VariationType);
                            }
                            lockCmd.ExecuteNonQuery();
                        }

                        string detailsQuery = @"
                    INSERT INTO sales_details (bill_no, product_id, product_name, variation_type, unit, quantity, price, total_price)
                    VALUES (@billNo, @productId, @productName, @variationType, @unit, @quantity, @price, @totalPrice)";

                        foreach (DataGridViewRow row in supDataGridView.Rows)
                        {
                            int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                            string variationType = row.Cells["variation_type"].Value.ToString();
                            if (variationType == "N/A") variationType = null;
                            decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                            string unit = row.Cells["unit"].Value.ToString();

                            string checkStockQuery = @"
                        SELECT COALESCE((SELECT SUM(sd.remaining_qty) 
                                         FROM stock_details sd
                                         JOIN grn_items gi ON sd.grn_items_id = gi.id
                                         WHERE gi.product_id = @productId
                                         AND (gi.variation_type = @variationType OR (gi.variation_type IS NULL AND @variationType IS NULL))
                                         AND (gi.unit = @unit OR (gi.unit IS NULL AND @unit IS NULL))
                                         AND sd.is_expired = 0
                                         AND sd.remaining_qty > 0), 0) AS available_stock";
                            using (MySqlCommand checkCmd = new MySqlCommand(checkStockQuery, connection, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@productId", productId);
                                checkCmd.Parameters.AddWithValue("@variationType", variationType == null ? (object)DBNull.Value : variationType);
                                checkCmd.Parameters.AddWithValue("@unit", unit);
                                decimal availableStock = Convert.ToDecimal(checkCmd.ExecuteScalar());
                                if (availableStock < quantity)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Insufficient non-expired stock for product {row.Cells["product_name"].Value}. Available: {availableStock}, Required: {quantity}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            using (MySqlCommand detailsCommand = new MySqlCommand(detailsQuery, connection, transaction))
                            {
                                detailsCommand.Parameters.AddWithValue("@billNo", billNo);
                                detailsCommand.Parameters.AddWithValue("@productId", productId);
                                detailsCommand.Parameters.AddWithValue("@productName", row.Cells["product_name"].Value.ToString());
                                detailsCommand.Parameters.AddWithValue("@variationType", variationType == null ? (object)DBNull.Value : variationType);
                                detailsCommand.Parameters.AddWithValue("@unit", unit);
                                detailsCommand.Parameters.AddWithValue("@quantity", quantity);
                                detailsCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells["price"].Value));
                                detailsCommand.Parameters.AddWithValue("@totalPrice", Convert.ToDecimal(row.Cells["total_price"].Value));
                                detailsCommand.ExecuteNonQuery();
                            }

                            StockManager stockManager = new StockManager(connectionString);
                            stockManager.ReduceStockFromBatches(productId, variationType, unit, quantity, connection, transaction);
                        }

                        transaction.Commit();

                        UpdateSessionManager(paymentMethod, totalPrice);

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

                        resetBtn_Click(sender, e);
                        LoadProductsData();
                        DisplayProducts();
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
                if (cashBookFlowPanel.Height >= 187)
                {
                    cashBooktimer.Stop();
                    btnExpand = true;
                }
            }
            else
            {
                cashBookFlowPanel.Height -= 10;
                if (cashBookFlowPanel.Height <= 62)
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

        private void webcamscan_Click(object sender, EventArgs e)
        {
            using (CodeReaderForm codeReader = new CodeReaderForm())
            {
                if (codeReader.ShowDialog() == DialogResult.OK)
                {
                    string scannedBarcode = codeReader.ScannedCode;
                    ProcessScannedBarcode(scannedBarcode);
                }
            }
        }

        private void calculatorFormBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CalculatorForm)
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
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
        }

        private void cashBookFlowPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LoadCompanyDetails()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name, logo FROM company_details LIMIT 1";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                companyNameLabel.Text = reader["name"] != DBNull.Value ? reader["name"].ToString() : "Company Name Not Found";

                                if (reader["logo"] != DBNull.Value)
                                {
                                    byte[] logoData = (byte[])reader["logo"];
                                    Debug.WriteLine($"Logo data size: {logoData.Length} bytes");
                                    using (MemoryStream ms = new MemoryStream(logoData))
                                    {
                                        Image logoImage = Image.FromStream(ms);
                                        logoPicBox.Image = logoImage;
                                        logoPicBox.SizeMode = PictureBoxSizeMode.Zoom;
                                        Debug.WriteLine($"Logo dimensions: {logoImage.Width}x{logoImage.Height}");
                                    }
                                }
                                else
                                {
                                    logoPicBox.Image = null;
                                    Debug.WriteLine("No logo found in company_details.");
                                }
                            }
                            else
                            {
                                companyNameLabel.Text = "Company Name Not Found";
                                logoPicBox.Image = null;
                                Debug.WriteLine("No records found in company_details.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading company details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                companyNameLabel.Text = "Error";
                logoPicBox.Image = null;
                Debug.WriteLine($"Error loading company details: {ex.Message}");
            }
        }

        private void LoadCompanyLogo()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT logo FROM company_details LIMIT 1";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            byte[] logoData = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(logoData))
                            {
                                logoPicBox.Image = Image.FromStream(ms);
                                logoPicBox.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                        else
                        {
                            logoPicBox.Image = null;
                            Debug.WriteLine("No logo found in company_details.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading company logo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logoPicBox.Image = null;
                Debug.WriteLine($"Error loading logo: {ex.Message}");
            }
        }

        private void logoPicBox_Click(object sender, EventArgs e)
        {
            LoadCompanyLogo();
        }

        private void SaveHeldSale(string referenceNumber)
        {
            if (supDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No items to hold.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        string insertHeaderQuery = "INSERT INTO held_sales (reference_number, hold_date) VALUES (@refNumber, @holdDate)";
                        using (MySqlCommand cmd = new MySqlCommand(insertHeaderQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@refNumber", referenceNumber);
                            cmd.Parameters.AddWithValue("@holdDate", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }

                        string getHoldIdQuery = "SELECT LAST_INSERT_ID()";
                        long holdId;
                        using (MySqlCommand cmd = new MySqlCommand(getHoldIdQuery, connection, transaction))
                        {
                            holdId = Convert.ToInt64(cmd.ExecuteScalar());
                        }

                        string insertDetailQuery = @"
                    INSERT INTO held_sale_details (hold_id, product_id, variation_type, quantity, price)
                    VALUES (@holdId, @productId, @variationType, @quantity, @price)";
                        foreach (DataGridViewRow row in supDataGridView.Rows)
                        {
                            int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                            string variationType = row.Cells["variation_type"].Value.ToString();
                            if (variationType == "N/A") variationType = null;
                            decimal quantity = Convert.ToDecimal(row.Cells["quantity"].Value);
                            decimal price = Convert.ToDecimal(row.Cells["price"].Value);

                            using (MySqlCommand cmd = new MySqlCommand(insertDetailQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@holdId", holdId);
                                cmd.Parameters.AddWithValue("@productId", productId);
                                cmd.Parameters.AddWithValue("@variationType", variationType == null ? (object)DBNull.Value : variationType);
                                cmd.Parameters.AddWithValue("@quantity", quantity);
                                cmd.Parameters.AddWithValue("@price", price);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Sale held successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        supDataGridView.Rows.Clear();
                        ReassignItemNumbers();
                        UpdateAllLabels();
                    }
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Reference number already exists. Please choose a different one.", "Duplicate Reference", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error holding sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadHeldSale(int holdId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    hsd.product_id,
                    p.name AS product_name,
                    hsd.variation_type,
                    u.unit_name,
                    hsd.quantity,
                    hsd.price
                FROM held_sale_details hsd
                JOIN products p ON hsd.product_id = p.id
                LEFT JOIN units u ON p.unit_id = u.id
                WHERE hsd.hold_id = @holdId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@holdId", holdId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            supDataGridView.Rows.Clear();
                            itemNumberCounter = 1;
                            foreach (DataRow row in dt.Rows)
                            {
                                string variationType = row["variation_type"] != DBNull.Value ? row["variation_type"].ToString() : "N/A";
                                supDataGridView.Rows.Add(
                                    itemNumberCounter++,
                                    row["product_id"],
                                    row["product_name"],
                                    variationType,
                                    row["unit_name"],
                                    null,
                                    row["quantity"],
                                    null,
                                    row["price"],
                                    Convert.ToDecimal(row["quantity"]) * Convert.ToDecimal(row["price"]),
                                    null
                                );
                            }
                        }
                    }

                    string deleteDetailsQuery = "DELETE FROM held_sale_details WHERE hold_id = @holdId";
                    using (MySqlCommand cmd = new MySqlCommand(deleteDetailsQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@holdId", holdId);
                        cmd.ExecuteNonQuery();
                    }

                    string deleteHeaderQuery = "DELETE FROM held_sales WHERE hold_id = @holdId";
                    using (MySqlCommand cmd = new MySqlCommand(deleteHeaderQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@holdId", holdId);
                        cmd.ExecuteNonQuery();
                    }

                    UpdateAllLabels();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading held sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void holdBtn_Click(object sender, EventArgs e)
        {
            using (HoldReference holdReference = new HoldReference())
            {
                if (holdReference.ShowDialog() == DialogResult.OK)
                {
                    string referenceNumber = holdReference.ReferenceNumber;
                    SaveHeldSale(referenceNumber);
                }
            }
        }

        private void proPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productPictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void productLabel1_Click(object sender, EventArgs e)
        {
        }

        private void proPriceLabel1_Click(object sender, EventArgs e)
        {
        }

        private void proPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productPictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void productLabel2_Click(object sender, EventArgs e)
        {
        }

        private void proPriceLabel2_Click(object sender, EventArgs e)
        {
        }

        private void proPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productPictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void productLabel3_Click(object sender, EventArgs e)
        {
        }

        private void proPriceLabel3_Click(object sender, EventArgs e)
        {
        }

        private void proPanel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productPictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void productLabel4_Click(object sender, EventArgs e)
        {
        }

        private void proPriceLabel4_Click(object sender, EventArgs e)
        {
        }

        private void proPanel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productPictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void productLabel5_Click(object sender, EventArgs e)
        {
        }

        private void proPriceLabel5_Click(object sender, EventArgs e)
        {
        }

        private void proPanel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void productPictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void productLabel6_Click(object sender, EventArgs e)
        {
        }

        private void proPriceLabel6_Click(object sender, EventArgs e)
        {
        }
    }
}