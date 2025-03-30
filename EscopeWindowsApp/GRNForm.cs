using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace EscopeWindowsApp
{
    public partial class GRNForm : Form
    {
        private string connectionString = "your_connection_string_here"; // Replace with your MySQL connection string
        private string paymentMethod;

        public GRNForm()
        {
            InitializeComponent();
        }

        private void GRNForm_Load(object sender, EventArgs e)
        {
            // Initialize form settings
            grnDataGridView.Columns.Add("ProductID", "Product ID");
            grnDataGridView.Columns.Add("ProductName", "Product Name");
            grnDataGridView.Columns.Add("VariationType", "Variation Type");
            grnDataGridView.Columns.Add("Quantity", "Quantity");
            grnDataGridView.Columns.Add("CostPrice", "Cost Price");
            grnDataGridView.Columns.Add("RetailPrice", "Retail Price");
            grnDataGridView.Columns.Add("WholesalePrice", "Wholesale Price");
            grnDataGridView.Columns.Add("NetPrice", "Net Price");
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
            string searchText = grnProSearchText.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable products = SearchProducts(searchText);
                if (products.Rows.Count > 0)
                {
                    // For simplicity, assume the first result is selected
                    int productId = Convert.ToInt32(products.Rows[0]["id"]);
                    FillProductDetails(productId);
                }
            }
        }

        private DataTable SearchProducts(string searchText)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, name FROM products WHERE name LIKE @searchText OR id = @searchId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    cmd.Parameters.AddWithValue("@searchId", searchText);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        #endregion

        #region Auto-Fill Product Details
        private void FillProductDetails(int productId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT p.id, p.name, p.category, v.name AS variation_name, p.stock " +
                               "FROM products p LEFT JOIN variations v ON p.variation_type_id = v.id " +
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
                            grnVarText.Text = reader["variation_name"].ToString();
                            grnStockText.Text = reader["stock"].ToString();

                            // Make fields read-only
                            grnProIDText.ReadOnly = true;
                            grnProNameText.ReadOnly = true;
                            grnProCatText.ReadOnly = true;
                            grnVarText.ReadOnly = true;
                            grnStockText.ReadOnly = true;

                            // Load variation types
                            LoadVariationTypes(productId);
                        }
                    }
                }
            }
        }

        private void LoadVariationTypes(int productId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT variation_type FROM pricing WHERE product_id = @productId AND variation_id IS NOT NULL";
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
                    }
                }
            }
        }
        #endregion

        #region Variation Type and Pricing
        private void grnVarTypCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grnVarTypCombo.SelectedItem != null)
            {
                string selectedType = grnVarTypCombo.SelectedItem.ToString();
                LoadPricingDetails(int.Parse(grnProIDText.Text), selectedType);
            }
        }

        private void LoadPricingDetails(int productId, string variationType)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT cost_price, retail_price, wholesale_price FROM pricing " +
                               "WHERE product_id = @productId AND variation_type = @variationType";
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

                            // Make fields read-only
                            grnCostPriText.ReadOnly = true;
                            grnRetPriText.ReadOnly = true;
                            grnWholePriText.ReadOnly = true;

                            // Update net price if quantity is entered
                            UpdateNetPrice();
                        }
                    }
                }
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

            grnDataGridView.Rows.Add(
                grnProIDText.Text,
                grnProNameText.Text,
                grnVarTypCombo.SelectedItem?.ToString() ?? "N/A",
                grnQuantityText.Text,
                grnCostPriText.Text,
                grnRetPriText.Text,
                grnWholePriText.Text,
                grnNetPriceText.Text
            );

            // Clear fields for next entry
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

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert GRN
                    string grnQuery = "INSERT INTO grn (grn_no, payment_method, total_amount, date) VALUES (@grnNo, @paymentMethod, @totalAmount, @date)";
                    using (MySqlCommand cmd = new MySqlCommand(grnQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@grnNo", GenerateGRNNumber());
                        cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@totalAmount", CalculateTotalAmount());
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        int grnId = (int)cmd.LastInsertedId;

                        // Insert GRN items
                        foreach (DataGridViewRow row in grnDataGridView.Rows)
                        {
                            string itemQuery = "INSERT INTO grn_items (grn_id, product_id, variation_type, quantity, cost_price, net_price, expiry_date) " +
                                               "VALUES (@grnId, @productId, @variationType, @quantity, @costPrice, @netPrice, @expiryDate)";
                            using (MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn))
                            {
                                itemCmd.Parameters.AddWithValue("@grnId", grnId);
                                itemCmd.Parameters.AddWithValue("@productId", row.Cells[0].Value);
                                itemCmd.Parameters.AddWithValue("@variationType", row.Cells[2].Value);
                                itemCmd.Parameters.AddWithValue("@quantity", row.Cells[3].Value);
                                itemCmd.Parameters.AddWithValue("@costPrice", row.Cells[4].Value);
                                itemCmd.Parameters.AddWithValue("@netPrice", row.Cells[7].Value);
                                //itemCmd.Parameters.AddWithValue("@expiryDate", siticoneDateTimePicker1.Value);
                                itemCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("GRN saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving GRN: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            // Load and display the most recent GRN (simplified example)
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT g.grn_no, g.payment_method, g.total_amount, gi.product_id, gi.variation_type, gi.quantity, gi.cost_price, gi.net_price " +
                               "FROM grn g JOIN grn_items gi ON g.id = gi.grn_id " +
                               "WHERE g.id = (SELECT MAX(id) FROM grn)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        grnDataGridView.Rows.Clear();
                        while (reader.Read())
                        {
                            // Populate DataGridView with previous GRN details
                            grnDataGridView.Rows.Add(
                                reader["product_id"].ToString(),
                                "", // Product name would need a join with products table
                                reader["variation_type"].ToString(),
                                reader["quantity"].ToString(),
                                reader["cost_price"].ToString(),
                                "", // Retail price not stored in grn_items
                                "", // Wholesale price not stored in grn_items
                                reader["net_price"].ToString()
                            );
                            // Optionally display GRN number, payment method, etc., in labels
                        }
                    }
                }
            }
        }
        #endregion

        #region Expiry Date
        private void siticoneDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Expiry date is set by the user and saved with each GRN item
        }
        private void grnNoLabel_Click(object sender, EventArgs e)
        {

        }
        private void creatProductLabel_Click(object sender, EventArgs e)
        {

        }
        private void grnPictureBox_Click(object sender, EventArgs e)
        {

        }
        private void ceaditPayementLabel_Click(object sender, EventArgs e)
        {

        }

        private void grnPricingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grnPriceLabel_Click(object sender, EventArgs e)
        {

        }
        private void cashPaymentLabel_Click(object sender, EventArgs e)
        {

        }
        private void grnCostPriText_TextChanged(object sender, EventArgs e)
        {
            // after select a variation type, it should automatically fill in the cost price, and the cost price should be read-only.
        }

        private void grnRetPriText_TextChanged(object sender, EventArgs e)
        {
            // after select a variation type, it should automatically fill in the retail price, and the retail price should be read-only.
        }

        private void grnWholePriText_TextChanged(object sender, EventArgs e)
        {
            // after select a variation type, it should automatically fill in the wholesale price, and the wholesale price should be read-only.
        }
        private void grnNetPriceText_TextChanged(object sender, EventArgs e)
        {
            // this is the net price of the product, it should be read-only. net price = quantity * cost price
        }
        private void grnStockText_TextChanged(object sender, EventArgs e)
        {
            //  After figuring out a product using the search bar, it should automatically fill in the stock, and the stock should be read-only.
        }

        private void grnVarText_TextChanged(object sender, EventArgs e)
        {
            //  After figuring out a product using the search bar, it should automatically fill in the product variation name, and the variation name should be read-only.
        }
        private void grnProCatText_TextChanged(object sender, EventArgs e)
        {
            //  After figuring out a product using the search bar, it should automatically fill in the product category, and the category should be read-only.
        }

        private void expireDateText_TextChanged(object sender, EventArgs e)
        {

        }
        private void grnDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // after click addToListBtn_Click button, it should add the product with all details to the data grid view
        }
        private void grnWarrantyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this is warrenty period of the product
        }
        private void grnProIDText_TextChanged(object sender, EventArgs e)
        {
            // After figuring out a product using the search bar, it should automatically fill in the product ID, and the ID should be read-only.
        }

        private void grnProNameText_TextChanged(object sender, EventArgs e)
        {
            //  After figuring out a product using the search bar, it should automatically fill in the product Name, and the Name should be read-only.
        }

        #endregion
    }
}