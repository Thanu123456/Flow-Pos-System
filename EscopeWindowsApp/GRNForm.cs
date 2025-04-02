using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Linq;

namespace EscopeWindowsApp
{
    public partial class GRNForm : Form
    {
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private string paymentMethod;
        private bool isFormLoading = true;
        private int? currentProductId = null; // Store the current product ID
        private string currentVariationType = null; // Store the current variation type

        public GRNForm()
        {
            InitializeComponent();
        }

        private void GRNForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (grnDataGridView.Columns.Count == 0)
                {
                    grnDataGridView.Columns.Add("ProductID", "Product ID");
                    grnDataGridView.Columns.Add("ProductName", "Product Name");
                    grnDataGridView.Columns.Add("VariationType", "Variation Type");
                    grnDataGridView.Columns.Add("Quantity", "Quantity");
                    grnDataGridView.Columns.Add("CostPrice", "Cost Price");
                    grnDataGridView.Columns.Add("RetailPrice", "Retail Price");
                    grnDataGridView.Columns.Add("WholesalePrice", "Wholesale Price");
                    grnDataGridView.Columns.Add("NetPrice", "Net Price");
                    grnDataGridView.Columns.Add("ExpiryDate", "Expiry Date");
                    grnDataGridView.Columns.Add("Warranty", "Warranty");
                }

                grnDataGridView.AllowUserToAddRows = false;
                grnProSearchText.Text = "";
                grnWarrantyComboBox.Items.Add("No Warranty");
                grnWarrantyComboBox.Items.Add("6 Months");
                grnWarrantyComboBox.Items.Add("1 Year");
                grnWarrantyComboBox.Items.Add("2 Years");
                grnWarrantyComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading GRNForm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isFormLoading = false;
            }
        }

        #region Payment Method Handling
        private void cashPaymentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (cashPaymentRadioBtn.Checked)
                paymentMethod = "Cash";
        }

        private void chequePaymentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (chequePaymentRadioBtn.Checked)
                paymentMethod = "Cheque";
        }

        private void creaditPayementRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (creaditPayementRadioBtn.Checked)
                paymentMethod = "Credit";
        }
        #endregion

        #region Product Search
        private void grnProSearchText_TextChanged(object sender, EventArgs e)
        {
            if (isFormLoading) return;

            string searchText = grnProSearchText.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable products = SearchProducts(searchText);
                if (products.Rows.Count > 0)
                {
                    int productId = Convert.ToInt32(products.Rows[0]["id"]);
                    FillProductDetails(productId);
                }
            }
        }

        private DataTable SearchProducts(string searchText)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, name FROM products WHERE name LIKE @searchText OR id = @searchId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        cmd.Parameters.AddWithValue("@searchId", int.TryParse(searchText, out int id) ? id : (object)DBNull.Value);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
        #endregion

        #region Auto-Fill Product Details
        private void FillProductDetails(int productId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT p.id, p.name, c.name AS category, v.name AS variation_name " +
                                   "FROM products p " +
                                   "LEFT JOIN categories c ON p.category_id = c.id " +
                                   "LEFT JOIN variations v ON p.variation_type_id = v.id " +
                                   "WHERE p.id = @productId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                grnProIDText.Text = reader["id"].ToString();
                                grnProNameText.Text = reader["name"].ToString();
                                grnProCatText.Text = reader["category"].ToString();
                                grnVarText.Text = reader.IsDBNull(reader.GetOrdinal("variation_name")) ? "N/A" : reader["variation_name"].ToString();
                                grnStockText.Text = "0"; // Initially set to 0; will update based on variation

                                grnProIDText.ReadOnly = true;
                                grnProNameText.ReadOnly = true;
                                grnProCatText.ReadOnly = true;
                                grnVarText.ReadOnly = true;
                                grnStockText.ReadOnly = true;

                                currentProductId = productId; // Store the current product ID

                                if (!reader.IsDBNull(reader.GetOrdinal("variation_name")))
                                {
                                    LoadVariationTypes(productId);
                                    grnVarTypCombo.Enabled = true;
                                }
                                else
                                {
                                    grnVarTypCombo.Items.Clear();
                                    grnVarTypCombo.Enabled = false;
                                    LoadSinglePricing(productId);
                                    LoadStockForNoVariation(productId);
                                    currentVariationType = null; // No variation
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filling product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadVariationTypes(int productId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT variation_type FROM pricing WHERE product_id = @productId AND variation_id IS NOT NULL";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            grnVarTypCombo.Items.Clear();
                            while (reader.Read())
                            {
                                grnVarTypCombo.Items.Add(reader["variation_type"].ToString());
                            }
                            if (grnVarTypCombo.Items.Count > 0)
                                grnVarTypCombo.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading variation types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSinglePricing(int productId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT cost_price, retail_price, wholesale_price FROM pricing " +
                                   "WHERE product_id = @productId AND variation_type IS NULL LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                grnCostPriText.Text = reader["cost_price"].ToString();
                                grnRetPriText.Text = reader["retail_price"].ToString();
                                grnWholePriText.Text = reader["wholesale_price"].ToString();

                                grnCostPriText.ReadOnly = true;
                                grnRetPriText.ReadOnly = true;
                                grnWholePriText.ReadOnly = true;

                                UpdateNetPrice();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading single pricing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStockForNoVariation(int productId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // Fetch the total stock for the product with no variation
                    string query = "SELECT COALESCE(SUM(stock), 0) AS total_stock " +
                                   "FROM stock " +
                                   "WHERE product_id = @productId AND variation_type IS NULL";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        object result = cmd.ExecuteScalar();
                        grnStockText.Text = result != null ? Convert.ToInt32(result).ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock for product without variation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grnStockText.Text = "0"; // Fallback on error
            }
        }
        #endregion

        #region Variation Type and Pricing
        private void grnVarTypCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grnVarTypCombo.SelectedItem != null)
            {
                string selectedType = grnVarTypCombo.SelectedItem.ToString();
                int productId = int.Parse(grnProIDText.Text);
                LoadPricingDetails(productId, selectedType);
                LoadStockForVariation(productId, selectedType);
                currentVariationType = selectedType; // Store the current variation type
            }
        }

        private void LoadPricingDetails(int productId, string variationType)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT cost_price, retail_price, wholesale_price FROM pricing " +
                                   "WHERE product_id = @productId AND variation_type = @variationType LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@variationType", variationType);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                grnCostPriText.Text = reader["cost_price"].ToString();
                                grnRetPriText.Text = reader["retail_price"].ToString();
                                grnWholePriText.Text = reader["wholesale_price"].ToString();

                                grnCostPriText.ReadOnly = true;
                                grnRetPriText.ReadOnly = true;
                                grnWholePriText.ReadOnly = true;

                                UpdateNetPrice();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading pricing details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStockForVariation(int productId, string variationType)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COALESCE(SUM(stock), 0) AS total_stock " +
                                   "FROM stock " +
                                   "WHERE product_id = @productId AND variation_type = @variationType";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@variationType", variationType);
                        object result = cmd.ExecuteScalar();
                        grnStockText.Text = result != null ? Convert.ToInt32(result).ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock for variation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grnStockText.Text = "0"; // Fallback on error
            }
        }
        #endregion

        #region Net Price Calculation
        private void grnQuantityText_TextChanged(object sender, EventArgs e)
        {
            UpdateNetPrice();
        }

        private void UpdateNetPrice()
        {
            if (decimal.TryParse(grnQuantityText.Text, out decimal quantity) &&
                decimal.TryParse(grnCostPriText.Text, out decimal costPrice))
            {
                decimal netPrice = quantity * costPrice;
                grnNetPriceText.Text = netPrice.ToString("F2");
            }
            else
            {
                grnNetPriceText.Text = "0.00";
            }
            grnNetPriceText.ReadOnly = true;
        }
        #endregion

        #region Add to List
        private void addToListBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(grnProIDText.Text) || string.IsNullOrEmpty(grnQuantityText.Text))
            {
                MessageBox.Show("Please select a product and enter quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string warranty = grnWarrantyComboBox.SelectedItem?.ToString() ?? "No Warranty";

            grnDataGridView.Rows.Add(
                grnProIDText.Text,
                grnProNameText.Text,
                grnVarTypCombo.SelectedItem?.ToString() ?? "N/A",
                grnQuantityText.Text,
                grnCostPriText.Text,
                grnRetPriText.Text,
                grnWholePriText.Text,
                grnNetPriceText.Text,
                grnExpireDatePicker.Value.ToString("yyyy-MM-dd"),
                warranty
            );

            // Clear fields but preserve currentProductId and currentVariationType
            grnProSearchText.Text = "";
            grnProIDText.Text = "";
            grnProNameText.Text = "";
            grnProCatText.Text = "";
            grnVarText.Text = "";
            grnStockText.Text = "";
            grnVarTypCombo.Items.Clear();
            grnQuantityText.Text = "";
            grnCostPriText.Text = "";
            grnRetPriText.Text = "";
            grnWholePriText.Text = "";
            grnNetPriceText.Text = "";
            grnExpireDatePicker.Value = DateTime.Now;
            grnWarrantyComboBox.SelectedIndex = 0;
        }
        #endregion

        #region Save GRN
        private void grnSaveBtn_Click(object sender, EventArgs e)
        {
            if (grnDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Please add products to the GRN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        // Insert GRN
                        string grnQuery = "INSERT INTO grn (grn_no, payment_method, total_amount, date) " +
                                          "VALUES (@grnNo, @paymentMethod, @totalAmount, @date)";
                        using (MySqlCommand cmd = new MySqlCommand(grnQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@grnNo", GenerateGRNNumber());
                            cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                            cmd.Parameters.AddWithValue("@totalAmount", CalculateTotalAmount());
                            cmd.Parameters.AddWithValue("@date", DateTime.Now);
                            cmd.ExecuteNonQuery();
                            int grnId = (int)cmd.LastInsertedId;

                            // Insert GRN items and update stock
                            foreach (DataGridViewRow row in grnDataGridView.Rows)
                            {
                                string varType = row.Cells[2].Value?.ToString() == "N/A" ? null : row.Cells[2].Value?.ToString();
                                int productId = Convert.ToInt32(row.Cells[0].Value);
                                int quantity = Convert.ToInt32(row.Cells[3].Value);
                                string warranty = row.Cells[9].Value?.ToString() ?? "No Warranty";

                                // Insert into grn_items
                                string itemQuery = "INSERT INTO grn_items (grn_id, product_id, variation_type, quantity, cost_price, net_price, expiry_date, warranty) " +
                                                  "VALUES (@grnId, @productId, @variationType, @quantity, @costPrice, @netPrice, @expiryDate, @warranty)";
                                using (MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn, transaction))
                                {
                                    itemCmd.Parameters.AddWithValue("@grnId", grnId);
                                    itemCmd.Parameters.AddWithValue("@productId", productId);
                                    itemCmd.Parameters.AddWithValue("@variationType", string.IsNullOrEmpty(varType) ? (object)DBNull.Value : varType);
                                    itemCmd.Parameters.AddWithValue("@quantity", quantity);
                                    itemCmd.Parameters.AddWithValue("@costPrice", Convert.ToDecimal(row.Cells[4].Value));
                                    itemCmd.Parameters.AddWithValue("@netPrice", Convert.ToDecimal(row.Cells[7].Value));
                                    itemCmd.Parameters.AddWithValue("@expiryDate", Convert.ToDateTime(row.Cells[8].Value));
                                    itemCmd.Parameters.AddWithValue("@warranty", warranty);
                                    itemCmd.ExecuteNonQuery();
                                }

                                // Update stock table (consolidate stock for existing product_id and variation_type)
                                string stockQuery = "INSERT INTO stock (product_id, variation_type, stock) " +
                                                   "VALUES (@productId, @variationType, @quantity) " +
                                                   "ON DUPLICATE KEY UPDATE stock = stock + @quantity";
                                using (MySqlCommand stockCmd = new MySqlCommand(stockQuery, conn, transaction))
                                {
                                    stockCmd.Parameters.AddWithValue("@productId", productId);
                                    stockCmd.Parameters.AddWithValue("@variationType", string.IsNullOrEmpty(varType) ? (object)DBNull.Value : varType);
                                    stockCmd.Parameters.AddWithValue("@quantity", quantity);
                                    stockCmd.ExecuteNonQuery();
                                }

                                // Update products table stock (total stock for the product)
                                string productStockQuery = "UPDATE products SET stock = stock + @quantity WHERE id = @productId";
                                using (MySqlCommand productCmd = new MySqlCommand(productStockQuery, conn, transaction))
                                {
                                    productCmd.Parameters.AddWithValue("@quantity", quantity);
                                    productCmd.Parameters.AddWithValue("@productId", productId);
                                    productCmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                    }

                    MessageBox.Show("GRN saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh stock display for the current product (if still selected) before closing
                    if (currentProductId.HasValue)
                    {
                        if (currentVariationType == null)
                            LoadStockForNoVariation(currentProductId.Value);
                        else
                            LoadStockForVariation(currentProductId.Value, currentVariationType);
                    }

                    // Clear the form and reset for a new GRN (optional: comment out this.Close() to keep form open)
                    ResetForm();
                    // this.Close(); // Uncomment if you want to close the form after saving
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving GRN: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            grnDataGridView.Rows.Clear();
            grnProSearchText.Text = "";
            grnProIDText.Text = "";
            grnProNameText.Text = "";
            grnProCatText.Text = "";
            grnVarText.Text = "";
            grnStockText.Text = "";
            grnVarTypCombo.Items.Clear();
            grnVarTypCombo.Enabled = false;
            grnQuantityText.Text = "";
            grnCostPriText.Text = "";
            grnRetPriText.Text = "";
            grnWholePriText.Text = "";
            grnNetPriceText.Text = "";
            grnExpireDatePicker.Value = DateTime.Now;
            grnWarrantyComboBox.SelectedIndex = 0;
            paymentMethod = null;
            cashPaymentRadioBtn.Checked = false;
            chequePaymentRadioBtn.Checked = false;
            creaditPayementRadioBtn.Checked = false;
            currentProductId = null;
            currentVariationType = null;
        }

        private string GenerateGRNNumber()
        {
            return "GRN-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private decimal CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in grnDataGridView.Rows)
            {
                total += Convert.ToDecimal(row.Cells[7].Value);
            }
            return total;
        }
        #endregion

        #region Cancel
        private void grnCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Previous GRN
        private void previousGRNBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is PreviousGRN)
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
            PreviousGRN previousGRN = new PreviousGRN();
            previousGRN.Show();
        }
        #endregion

        #region Expiry Date and Miscellaneous
        private void siticoneDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Expiry date is set by the user and saved with each GRN item
        }

        private void grnNoLabel_Click(object sender, EventArgs e) 
        {
            // GRN number is here, my previous GRN-ID + 1
            // 
        }
        private void creatProductLabel_Click(object sender, EventArgs e) { }
        private void grnPictureBox_Click(object sender, EventArgs e) { }
        private void ceaditPayementLabel_Click(object sender, EventArgs e) { }
        private void grnPricingPanel_Paint(object sender, PaintEventArgs e) { }
        private void grnPriceLabel_Click(object sender, EventArgs e) { }
        private void cashPaymentLabel_Click(object sender, EventArgs e) { }
        private void grnCostPriText_TextChanged(object sender, EventArgs e) { }
        private void grnRetPriText_TextChanged(object sender, EventArgs e) { }
        private void grnWholePriText_TextChanged(object sender, EventArgs e) { }
        private void grnNetPriceText_TextChanged(object sender, EventArgs e) { }
        private void grnStockText_TextChanged(object sender, EventArgs e) { }
        private void grnVarText_TextChanged(object sender, EventArgs e) { }
        private void grnProCatText_TextChanged(object sender, EventArgs e) { }
        private void expireDateText_TextChanged(object sender, EventArgs e) { }
        private void grnDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void grnWarrantyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grnWarrantyComboBox.SelectedItem != null)
            {
                string selectedWarranty = grnWarrantyComboBox.SelectedItem.ToString();
                // Optional: Display the selected warranty in a label for user feedback
                // grnWarrantyLabel.Text = $"Warranty: {selectedWarranty}";
            }
        }
        private void grnProIDText_TextChanged(object sender, EventArgs e) { }
        private void grnProNameText_TextChanged(object sender, EventArgs e) { }
        #endregion
    }
}