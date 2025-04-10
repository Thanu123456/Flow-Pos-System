using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.Generic;

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

        public POS()
        {
            InitializeComponent();
            posClientNameLabel.Text = "Walk-In Customer";
            posClientNumLabel.Text = "";

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

            // Load product data on form load
            this.Load += POS_Load;
            ConfigureSupDataGridView();

            // Subscribe to events
            posProductDataGrid.CellPainting += posProductDataGrid_CellPainting;
            posProductDataGrid.CellFormatting += posProductDataGrid_CellFormatting;
            supDataGridView.CellFormatting += supDataGridView_CellFormatting; // Added for dynamic quantity formatting
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
                decimal stock = Convert.ToDecimal(row.Cells["stock"].Value); // Use decimal to match stock type
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
                    // Open POSWeightForm with stock, product name, and variation type
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
                    // Default behavior: add with quantity 1
                    AddToCart(row, 1m);
                }
            }
        }

        private void AddToCart(DataGridViewRow productRow, decimal quantity)
        {
            int productId = Convert.ToInt32(productRow.Cells["id"].Value); // Get product_id
            string productName = productRow.Cells["product_name"].Value.ToString();
            string variationType = productRow.Cells["variation_type"].Value.ToString();
            string unit = productRow.Cells["unit_name"].Value.ToString();
            decimal price = Convert.ToDecimal(productRow.Cells["retail_price"].Value);
            int stock = Convert.ToInt32(productRow.Cells["stock"].Value);

            // Check if the item already exists in the cart
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
                // Item already exists, increase the quantity
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
                // Item does not exist, add a new row
                supDataGridView.Rows.Add(
                    itemNumberCounter++,
                    productId, // Store product_id
                    productName,
                    variationType,
                    unit,
                    null, // Decrease button
                    quantity,
                    null, // Increase button
                    price,
                    price * quantity,
                    null  // Remove button
                );
            }

            UpdateAllLabels();
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

            // Add hidden product_id column
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
                        // For "Pieces", display as whole number without decimals
                        e.Value = Convert.ToDecimal(e.Value).ToString("F0");
                    }
                    else
                    {
                        // For other units (e.g., Kilogram), use two decimal places
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

                if (supDataGridView.Columns[e.ColumnIndex].Name == "decrease")
                {
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
                    int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                    string variationType = row.Cells["variation_type"].Value.ToString();

                    decimal stock = 0;
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
        }

        private void posCardRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (posCardRadioBtn.Checked)
            {
                paymentText.Enabled = false;
                paymentText.Text = "";
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
            itemNumberCounter = 1;
            paymentText.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void cashBookBtn_Click_1(object sender, EventArgs e) 
        {
            cashBooktimer.Start();
        }

        private void posClientNameLabel_Click(object sender, EventArgs e) { }
        private void posClientNumLabel_Click(object sender, EventArgs e) { }

        private void posCusSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = posCusSearchText.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                posClientNameLabel.Text = "Walk-In Customer";
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

            // Validate payment details
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
                        // Generate a unique Bill No
                        string billNo = "BILL_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        string customerName = posClientNameLabel.Text;
                        string userName = "Cashier";
                        int totalItems = supDataGridView.Rows.Count;

                        // Insert into sales table
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

                        // Insert into sales_details and update stock
                        string detailsQuery = @"
                    INSERT INTO sales_details (bill_no, product_name, variation_type, unit, quantity, price, total_price)
                    VALUES (@billNo, @productName, @variationType, @unit, @quantity, @price, @totalPrice)";
                        string updateStockQuery = @"
                    UPDATE stock 
                    SET stock = stock - @quantity 
                    WHERE product_id = @productId 
                    AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))";

                        foreach (DataGridViewRow row in supDataGridView.Rows)
                        {
                            int productId = Convert.ToInt32(row.Cells["product_id"].Value);
                            string variationType = row.Cells["variation_type"].Value.ToString();
                            if (variationType == "N/A") variationType = null; // Normalize "N/A" to NULL

                            // Insert sales details
                            using (MySqlCommand detailsCommand = new MySqlCommand(detailsQuery, connection, transaction))
                            {
                                detailsCommand.Parameters.AddWithValue("@billNo", billNo);
                                detailsCommand.Parameters.AddWithValue("@productName", row.Cells["product_name"].Value.ToString());
                                detailsCommand.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                detailsCommand.Parameters.AddWithValue("@unit", row.Cells["unit"].Value.ToString());
                                detailsCommand.Parameters.AddWithValue("@quantity", Convert.ToDecimal(row.Cells["quantity"].Value));
                                detailsCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells["price"].Value));
                                detailsCommand.Parameters.AddWithValue("@totalPrice", Convert.ToDecimal(row.Cells["total_price"].Value));
                                detailsCommand.ExecuteNonQuery();
                            }

                            // Update stock
                            using (MySqlCommand stockCommand = new MySqlCommand(updateStockQuery, connection, transaction))
                            {
                                stockCommand.Parameters.AddWithValue("@quantity", Convert.ToDecimal(row.Cells["quantity"].Value));
                                stockCommand.Parameters.AddWithValue("@productId", productId);
                                stockCommand.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                int rowsAffected = stockCommand.ExecuteNonQuery();
                                if (rowsAffected == 0)
                                {
                                    // Log for debugging
                                    MessageBox.Show($"Warning: Stock not updated for Product ID {productId}, Variation: {variationType ?? "NULL"}", "Stock Update Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }

                        transaction.Commit();

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
            if(btnExpand == false)
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
    }
}