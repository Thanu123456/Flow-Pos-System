using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace EscopeWindowsApp
{
    public partial class POS : Form
    {
        private Timer timeTimer;       // Timer for time updates
        private Timer dateTimer;       // Timer for date updates
        private DataTable productsTable;
        private BindingSource bindingSource;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;"; // Adjust as needed
        private int itemNumberCounter = 1; // To assign unique item numbers in supDataGridView

        public POS()
        {
            InitializeComponent();
            posClientNameLabel.Text = "Walking Customer"; // Set default client name here
            posClientNumLabel.Text = ""; // Set default client number here

            // Initialize and start the time timer
            timeTimer = new Timer();
            timeTimer.Interval = 1000; // Update every 1 second
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();

            // Initialize and start the date timer
            dateTimer = new Timer();
            dateTimer.Interval = 1000; // Update every 1 second
            dateTimer.Tick += DateTimer_Tick;
            dateTimer.Start();

            // Ensure labels can display their content
            posTimeLabel.AutoSize = false;
            posDateLabel.AutoSize = false;

            // Initialize BindingSource and DataTable for products
            bindingSource = new BindingSource();
            productsTable = new DataTable();

            // Load product data on form load
            this.Load += POS_Load;
            ConfigureSupDataGridView(); // Configure supDataGridView during initialization

            // Subscribe to events
            posProductDataGrid.CellPainting += posProductDataGrid_CellPainting;
            posProductDataGrid.CellFormatting += posProductDataGrid_CellFormatting;
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

            // Prevent the empty row at the end
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
                productsTable.Columns.Add("stock", typeof(int));
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
                        Image addIcon = Properties.Resources.posadd_; // Updated to posplus.png if needed
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
                int stock = Convert.ToInt32(row.Cells["stock"].Value);
                if (stock <= 0)
                {
                    MessageBox.Show($"Cannot add {row.Cells["product_name"].Value} ({row.Cells["variation_type"].Value}) to cart. Stock is 0.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                supDataGridView.Rows.Add(
                    itemNumberCounter++,
                    row.Cells["product_name"].Value,
                    row.Cells["variation_type"].Value,
                    row.Cells["unit_name"].Value,
                    null, // Decrease button (icon will be painted)
                    1,    // Default quantity
                    null, // Increase button (icon will be painted)
                    row.Cells["retail_price"].Value, // Price per unit
                    row.Cells["retail_price"].Value, // Total price (retail_price * 1)
                    null  // Remove button (icon will be painted)
                );
                UpdateAllLabels();
            }
        }

        #endregion

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

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "item_number",
                HeaderText = "No",
                Width = 30
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

            // Removed stock and retail_price columns

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
                HeaderText = "Delete",
                Text = "",
                UseColumnTextForButtonValue = false,
                Width = 80
            };
            supDataGridView.Columns.Add(removeColumn);

            supDataGridView.AllowUserToAddRows = false;

            // Subscribe to CellPainting for icons
            supDataGridView.CellPainting += supDataGridView_CellPainting;
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
                        Image minusIcon = Properties.Resources.posminus1; // posminus.png
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
                        Image plusIcon = Properties.Resources.posplus1; // posplus.png
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
                        Image deleteIcon = Properties.Resources.delete; // delete.png
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

                if (supDataGridView.Columns[e.ColumnIndex].Name == "decrease")
                {
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    if (quantity > 1)
                    {
                        quantity--;
                        row.Cells["quantity"].Value = quantity;
                        UpdateTotalPrice(row);
                    }
                }
                else if (supDataGridView.Columns[e.ColumnIndex].Name == "increase")
                {
                    int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                    // No stock check here since stock is not in supDataGridView
                    quantity++;
                    row.Cells["quantity"].Value = quantity;
                    UpdateTotalPrice(row);
                }
                else if (supDataGridView.Columns[e.ColumnIndex].Name == "remove")
                {
                    supDataGridView.Rows.RemoveAt(e.RowIndex);
                    UpdateAllLabels();
                }
            }
        }

        private void UpdateTotalPrice(DataGridViewRow row)
        {
            decimal price = Convert.ToDecimal(row.Cells["price"].Value);
            int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
            decimal totalPrice = price * quantity;
            row.Cells["total_price"].Value = totalPrice;
            UpdateAllLabels();
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
            }
        }

        private void disPercentageRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (disPercentageRadioBtn.Checked)
            {
                discountText.Text = "";
                discountText.Text += "%";
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
            paymentText_TextChanged(null, null); // Update balance
        }

        #endregion

        #region Payment Handling

        private void posCashRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (posCashRadioBtn.Checked)
            {
                paymentText.Enabled = true; // Enable textbox for cash
            }
        }

        private void posCardRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (posCardRadioBtn.Checked)
            {
                paymentText.Enabled = false; // Disable textbox for card
                paymentText.Text = ""; // Clear the textbox
            }
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
            int totalItems = supDataGridView.Rows.Count; // Count total item_numbers (rows)
            totQtyCountLabel.Text = totalItems.ToString();
        }

        private void subTotPriLabel_Click(object sender, EventArgs e)
        {
            decimal subTotal = CalculateSubTotal();
            subTotPriLabel.Text = subTotal.ToString("N2");
        }

        private void discountPriLabel_Click(object sender, EventArgs e)
        {
            // Handled in discountText_TextChanged
        }

        private void totPriceCountLabel_Click(object sender, EventArgs e)
        {
            // Handled in discountText_TextChanged
        }

        private void balancePriceCountLabel_Click(object sender, EventArgs e)
        {
            // Handled in paymentText_TextChanged
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
            posCashRadioBtn.Checked = false;
            posCardRadioBtn.Checked = false;
            itemNumberCounter = 1; // Reset item number counter
            paymentText.Enabled = true; // Reset textbox to enabled
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void cashBookBtn_Click_1(object sender, EventArgs e) { }

        private void posClientNameLabel_Click(object sender, EventArgs e) { }
        private void posClientNumLabel_Click(object sender, EventArgs e) { }

        private void posCusSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = posCusSearchText.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                posClientNameLabel.Text = "Walking Customer";
                posClientNumLabel.Text = "";
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name, phone FROM customers WHERE phone LIKE @phone LIMIT 1";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@phone", $"%{searchText}%");
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                posClientNameLabel.Text = reader["name"].ToString();
                                posClientNumLabel.Text = reader["phone"].ToString();
                            }
                            else
                            {
                                posClientNameLabel.Text = "Not Found";
                                posClientNumLabel.Text = "Not Found";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                posClientNameLabel.Text = "Error";
                posClientNumLabel.Text = "Error";
            }
        }

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
    }
}