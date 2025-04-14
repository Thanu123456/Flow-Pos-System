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
        private int? currentProductId = null;
        private string currentVariationType = null;
        private bool isSerialNumberRequired = false;

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
                    grnDataGridView.Columns.Add("Unit", "Unit");
                    grnDataGridView.Columns.Add("SerialNumber", "Serial Number"); // New column
                }

                grnDataGridView.AllowUserToAddRows = false;
                grnProSearchText.Text = "";
                grnWarrantyComboBox.Items.Add("No Warranty");
                grnWarrantyComboBox.Items.Add("6 Months");
                grnWarrantyComboBox.Items.Add("1 Year");
                grnWarrantyComboBox.Items.Add("2 Years");
                grnWarrantyComboBox.SelectedIndex = 0;

                UpdateUnitLabels();
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
            else
            {
                ClearProductDetails();
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
                        // Handle "PROxxx" format in search if entered
                        int searchId = searchText.StartsWith("PRO") && int.TryParse(searchText.Substring(3), out int id) ? id : (int.TryParse(searchText, out id) ? id : -1);
                        cmd.Parameters.AddWithValue("@searchId", searchId != -1 ? searchId : (object)DBNull.Value);
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
                    string query = @"
                        SELECT p.id, p.name, c.name AS category, v.name AS variation_name, u.unit_name AS unit_name
                        FROM products p
                        LEFT JOIN categories c ON p.category_id = c.id
                        LEFT JOIN variations v ON p.variation_type_id = v.id
                        LEFT JOIN units u ON p.unit_id = u.id
                        WHERE p.id = @productId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                grnProIDText.Text = $"PRO{productId:D3}"; // Format as "PRO001"
                                grnProNameText.Text = reader["name"].ToString();
                                grnProCatText.Text = reader["category"].ToString();
                                grnVarText.Text = reader.IsDBNull(reader.GetOrdinal("variation_name")) ? "N/A" : reader["variation_name"].ToString();
                                grnStockText.Text = "0";
                                grnUnitText.Text = reader["unit_name"] != DBNull.Value ? reader["unit_name"].ToString() : "N/A";

                                grnProIDText.ReadOnly = true;
                                grnProNameText.ReadOnly = true;
                                grnProCatText.ReadOnly = true;
                                grnVarText.ReadOnly = true;
                                grnStockText.ReadOnly = true;
                                grnUnitText.ReadOnly = true;

                                currentProductId = productId;

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
                                    currentVariationType = null;
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
                    string query = "SELECT DISTINCT variation_type FROM pricing WHERE product_id = @productId AND variation_type IS NOT NULL";
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
                    string query = "SELECT COALESCE(SUM(stock), 0) AS total_stock " +
                                  "FROM stock WHERE product_id = @productId AND variation_type IS NULL";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        object result = cmd.ExecuteScalar();
                        grnStockText.Text = result != null ? result.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock for product without variation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grnStockText.Text = "0";
            }
        }
        #endregion

        #region Variation Type and Pricing
        private void grnVarTypCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentProductId.HasValue && grnVarTypCombo.SelectedItem != null)
            {
                currentVariationType = grnVarTypCombo.SelectedItem.ToString();
                LoadPricingDetails(currentProductId.Value, currentVariationType);
                LoadStockForVariation(currentProductId.Value, currentVariationType);
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
                                  "FROM stock WHERE product_id = @productId AND variation_type = @variationType";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@variationType", variationType);
                        object result = cmd.ExecuteScalar();
                        grnStockText.Text = result != null ? result.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock for variation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grnStockText.Text = "0";
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
                grnNetPriceText.Text = (quantity * costPrice).ToString("F2");
            }
            else
            {
                grnNetPriceText.Text = "0.00";
            }
        }
        #endregion

        #region Add to List
        private void addToListBtn_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrEmpty(grnProIDText.Text) || string.IsNullOrEmpty(grnQuantityText.Text))
            {
                MessageBox.Show("Please select a product and enter quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(grnQuantityText.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extract numeric product ID from formatted string (e.g., "PRO001" -> "1")
            string formattedProductId = grnProIDText.Text;
            int productId = int.Parse(formattedProductId.Replace("PRO", ""));

            string variationType = grnVarTypCombo.SelectedItem?.ToString() ?? "N/A";
            string warranty = grnWarrantyComboBox.SelectedItem?.ToString() ?? "No Warranty";
            string unit = grnUnitText.Text;

            if (isSerialNumberRequired)
            {
                if (quantity != (int)quantity)
                {
                    MessageBox.Show("Serial numbers require whole number quantities.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Open AddBarcodeForm and wait for it to close
                AddBarcodeForm barcodeForm = new AddBarcodeForm(productId.ToString(), variationType, (int)quantity);
                barcodeForm.FormClosed += (s, args) =>
                {
                    // Check if the form was saved (we'll add a property to AddBarcodeForm to track this)
                    if (barcodeForm.IsSaved)
                    {
                        // Check for duplicate entries and consolidate quantities
                        foreach (DataGridViewRow row in grnDataGridView.Rows)
                        {
                            if (row.Cells["ProductID"].Value.ToString() == formattedProductId &&
                                row.Cells["VariationType"].Value.ToString() == variationType)
                            {
                                // Update existing row
                                decimal existingQuantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                                decimal newQuantity = existingQuantity + quantity;
                                row.Cells["Quantity"].Value = newQuantity;
                                row.Cells["NetPrice"].Value = (newQuantity * Convert.ToDecimal(row.Cells["CostPrice"].Value)).ToString("F2");
                                ClearItemFields();
                                return;
                            }
                        }

                        // Add new row to DataGridView
                        grnDataGridView.Rows.Add(
                            formattedProductId,
                            grnProNameText.Text,
                            variationType,
                            grnQuantityText.Text,
                            grnCostPriText.Text,
                            grnRetPriText.Text,
                            grnWholePriText.Text,
                            grnNetPriceText.Text,
                            grnExpireDatePicker.Value.ToString("yyyy-MM-dd"),
                            warranty,
                            unit,
                            "Yes" // Indicate serial numbers are required
                        );

                        ClearItemFields();
                    }
                    // If not saved, do nothing (item is not added)
                };
                barcodeForm.ShowDialog();
            }
            else
            {
                // No serial numbers required, add directly to DataGridView
                // Check for duplicate entries and consolidate quantities
                foreach (DataGridViewRow row in grnDataGridView.Rows)
                {
                    if (row.Cells["ProductID"].Value.ToString() == formattedProductId &&
                        row.Cells["VariationType"].Value.ToString() == variationType)
                    {
                        // Update existing row
                        decimal existingQuantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                        decimal newQuantity = existingQuantity + quantity;
                        row.Cells["Quantity"].Value = newQuantity;
                        row.Cells["NetPrice"].Value = (newQuantity * Convert.ToDecimal(row.Cells["CostPrice"].Value)).ToString("F2");
                        ClearItemFields();
                        return;
                    }
                }

                // Add new row to DataGridView
                grnDataGridView.Rows.Add(
                    formattedProductId,
                    grnProNameText.Text,
                    variationType,
                    grnQuantityText.Text,
                    grnCostPriText.Text,
                    grnRetPriText.Text,
                    grnWholePriText.Text,
                    grnNetPriceText.Text,
                    grnExpireDatePicker.Value.ToString("yyyy-MM-dd"),
                    warranty,
                    unit,
                    "No" // No serial numbers
                );

                ClearItemFields();
            }
        }

        private void ClearItemFields()
        {
            grnQuantityText.Text = "";
            grnNetPriceText.Text = "0.00";
            grnExpireDatePicker.Value = DateTime.Now;
            grnWarrantyComboBox.SelectedIndex = 0;

            if (currentProductId.HasValue)
            {
                if (currentVariationType == null)
                    LoadStockForNoVariation(currentProductId.Value);
                else
                    LoadStockForVariation(currentProductId.Value, currentVariationType);
            }
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
                            string grnNo = GenerateGRNNumber();
                            cmd.Parameters.AddWithValue("@grnNo", grnNo);
                            cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                            cmd.Parameters.AddWithValue("@totalAmount", CalculateTotalAmount());
                            cmd.Parameters.AddWithValue("@date", DateTime.Now);
                            cmd.ExecuteNonQuery();
                            long grnId = cmd.LastInsertedId;

                            // Insert GRN items and update stock
                            foreach (DataGridViewRow row in grnDataGridView.Rows)
                            {
                                string varType = row.Cells["VariationType"].Value?.ToString();
                                if (varType == "N/A") varType = null;
                                string formattedProductId = row.Cells["ProductID"].Value.ToString();
                                int productId = int.Parse(formattedProductId.Replace("PRO", "")); // Extract numeric ID
                                decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                                decimal costPrice = Convert.ToDecimal(row.Cells["CostPrice"].Value);
                                decimal netPrice = Convert.ToDecimal(row.Cells["NetPrice"].Value);
                                DateTime expiryDate = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
                                string warranty = row.Cells["Warranty"].Value?.ToString() ?? "No Warranty";
                                string unit = row.Cells["Unit"].Value?.ToString();
                                string serialNumberFlag = row.Cells["SerialNumber"].Value.ToString(); // Get "Yes" or "No"

                                // Insert into grn_items
                                string itemQuery = @"
                                    INSERT INTO grn_items (grn_id, product_id, variation_type, quantity, cost_price, net_price, expiry_date, warranty, unit, serial_numbers)
                                    VALUES (@grnId, @productId, @variationType, @quantity, @costPrice, @netPrice, @expiryDate, @warranty, @unit, @serialNumbers)";
                                using (MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn, transaction))
                                {
                                    itemCmd.Parameters.AddWithValue("@grnId", grnId);
                                    itemCmd.Parameters.AddWithValue("@productId", productId);
                                    itemCmd.Parameters.AddWithValue("@variationType", varType ?? (object)DBNull.Value);
                                    itemCmd.Parameters.AddWithValue("@quantity", quantity);
                                    itemCmd.Parameters.AddWithValue("@costPrice", costPrice);
                                    itemCmd.Parameters.AddWithValue("@netPrice", netPrice);
                                    itemCmd.Parameters.AddWithValue("@expiryDate", expiryDate);
                                    itemCmd.Parameters.AddWithValue("@warranty", warranty);
                                    itemCmd.Parameters.AddWithValue("@unit", unit == "N/A" ? (object)DBNull.Value : unit);
                                    itemCmd.Parameters.AddWithValue("@serialNumbers", serialNumberFlag); // Save "Yes" or "No"
                                    itemCmd.ExecuteNonQuery();
                                }

                                // Update stock table
                                string stockQuery = @"
                                    INSERT INTO stock (product_id, variation_type, stock, unit)
                                    VALUES (@productId, @variationType, @quantity, @unit)
                                    ON DUPLICATE KEY UPDATE stock = stock + @quantity, unit = @unit";
                                using (MySqlCommand stockCmd = new MySqlCommand(stockQuery, conn, transaction))
                                {
                                    stockCmd.Parameters.AddWithValue("@productId", productId);
                                    stockCmd.Parameters.AddWithValue("@variationType", varType ?? (object)DBNull.Value);
                                    stockCmd.Parameters.AddWithValue("@quantity", quantity);
                                    stockCmd.Parameters.AddWithValue("@unit", unit == "N/A" ? (object)DBNull.Value : unit);
                                    stockCmd.ExecuteNonQuery();
                                }

                                // Update products table stock
                                string productStockQuery = "UPDATE products SET stock = stock + @quantity WHERE id = @productId";
                                using (MySqlCommand productCmd = new MySqlCommand(productStockQuery, conn, transaction))
                                {
                                    productCmd.Parameters.AddWithValue("@quantity", quantity);
                                    productCmd.Parameters.AddWithValue("@productId", productId);
                                    productCmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("GRN saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    if (currentProductId.HasValue)
                    {
                        if (currentVariationType == null)
                            LoadStockForNoVariation(currentProductId.Value);
                        else
                            LoadStockForVariation(currentProductId.Value, currentVariationType);
                    }

                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving GRN: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearProductDetails()
        {
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
            grnNetPriceText.Text = "0.00";
            grnUnitText.Text = "";
            grnExpireDatePicker.Value = DateTime.Now;
            grnWarrantyComboBox.SelectedIndex = 0;
            currentProductId = null;
            currentVariationType = null;

            UpdateUnitLabels();
        }

        private void ResetForm()
        {
            grnDataGridView.Rows.Clear();
            grnProSearchText.Text = "";
            ClearProductDetails();
            paymentMethod = null;
            cashPaymentRadioBtn.Checked = false;
            chequePaymentRadioBtn.Checked = false;
            creaditPayementRadioBtn.Checked = false;
            checkSerialNumber.Checked = false;
            isSerialNumberRequired = false;
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
                if (decimal.TryParse(row.Cells["NetPrice"].Value?.ToString(), out decimal netPrice))
                {
                    total += netPrice;
                }
            }
            return total;
        }
        #endregion

        private void OpenAddBarcodeForm(string productId, string variationType, decimal quantity)
        {
            try
            {
                int qty = (int)quantity;
                if (qty != quantity)
                {
                    MessageBox.Show("Serial numbers require whole number quantities.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pass numeric product ID to AddBarcodeForm (strip "PRO" prefix)
                string numericProductId = productId.Replace("PRO", "");
                AddBarcodeForm barcodeForm = new AddBarcodeForm(numericProductId, variationType, qty);
                barcodeForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening barcode form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
        private void siticoneDateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void grnNoLabel_Click(object sender, EventArgs e) { }
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
        private void grnWarrantyComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void grnProIDText_TextChanged(object sender, EventArgs e) { }
        private void grnProNameText_TextChanged(object sender, EventArgs e) { }

        private void UpdateUnitLabels()
        {
            string unit = grnUnitText.Text.Trim().ToLower();
            switch (unit)
            {
                case "liter":
                    sUnitNameLabel.Text = "L";
                    qUnitNameLabel.Text = "L";
                    break;
                case "kilogram":
                    sUnitNameLabel.Text = "Kg";
                    qUnitNameLabel.Text = "Kg";
                    break;
                case "meter":
                    sUnitNameLabel.Text = "M";
                    qUnitNameLabel.Text = "M";
                    break;
                default:
                    sUnitNameLabel.Text = "";
                    qUnitNameLabel.Text = "";
                    break;
            }
        }

        private void grnUnitText_TextChanged(object sender, EventArgs e)
        {
            UpdateUnitLabels();
        }

        private void sUnitNameLabel_Click(object sender, EventArgs e) { }
        private void qUnitNameLabel_Click(object sender, EventArgs e) { }
        #endregion

        private void checkSerialNumber_CheckedChanged(object sender, EventArgs e)
        {
            isSerialNumberRequired = checkSerialNumber.Checked;
        }
    }
}