using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class CreateProduct : Form
    {
        private List<PricingDetail> pricingDetails;
        private bool isEditMode = false;
        private int editProductId = -1;

        // Error providers
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider categoryErrorProvider = new ErrorProvider();
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public CreateProduct(int productId = -1, string name = "", string category = "", string imagePath = "",
            int unitId = 0, int warehouseId = 0, int supplierId = 0, int brandId = 0, string variationType = "")
        {
            InitializeComponent();
            SetupErrorProviders();

            if (productId != -1)
            {
                isEditMode = true;
                editProductId = productId;
                this.Text = "Edit Product";
                creProSaveBtn.Text = "Update";
            }

            createProductNameText.Text = name;
            ProCatComboox.Text = category;
            createProductMultipleImgText.Text = imagePath;
            creProVarTypeComboBox.Enabled = false;

            this.Load += CreateProduct_Load;
            UpdateSaveButtonState();
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            categoryErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadUnits();
            LoadWarehouses();
            LoadSuppliers();
            LoadBrands();
            LoadVariationTypes();
            UpdateSaveButtonState();
        }

        // Load dropdown data methods
        private void LoadCategories()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT name FROM categories ORDER BY name";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            ProCatComboox.Items.Clear();
                            ProCatComboox.Items.Add("Select Category");
                            while (reader.Read())
                            {
                                ProCatComboox.Items.Add(reader.GetString("name"));
                            }
                            ProCatComboox.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUnits()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, unit_name FROM units ORDER BY unit_name";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<KeyValuePair<int, string>> units = new List<KeyValuePair<int, string>>();
                            units.Add(new KeyValuePair<int, string>(0, "Select Unit"));
                            while (reader.Read())
                            {
                                units.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("unit_name")));
                            }
                            creProUnitComboBox.DataSource = new BindingSource(units, null);
                            creProUnitComboBox.DisplayMember = "Value";
                            creProUnitComboBox.ValueMember = "Key";
                            creProUnitComboBox.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error교육 loading units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadWarehouses()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, name FROM warehouses ORDER BY name";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<KeyValuePair<int, string>> warehouses = new List<KeyValuePair<int, string>>();
                            warehouses.Add(new KeyValuePair<int, string>(0, "Select Warehouse"));
                            while (reader.Read())
                            {
                                warehouses.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("name")));
                            }
                            creProWareComboBox.DataSource = new BindingSource(warehouses, null);
                            creProWareComboBox.DisplayMember = "Value";
                            creProWareComboBox.ValueMember = "Key";
                            creProWareComboBox.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading warehouses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, name FROM suppliers ORDER BY name";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<KeyValuePair<int, string>> suppliers = new List<KeyValuePair<int, string>>();
                            suppliers.Add(new KeyValuePair<int, string>(0, "Select Supplier"));
                            while (reader.Read())
                            {
                                suppliers.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("name")));
                            }
                            creProSupComboBox.DataSource = new BindingSource(suppliers, null);
                            creProSupComboBox.DisplayMember = "Value";
                            creProSupComboBox.ValueMember = "Key";
                            creProSupComboBox.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBrands()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, name FROM brands ORDER BY name";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<KeyValuePair<int, string>> brands = new List<KeyValuePair<int, string>>();
                            brands.Add(new KeyValuePair<int, string>(0, "Select Brand"));
                            while (reader.Read())
                            {
                                brands.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("name")));
                            }
                            creProBrandComboBox.DataSource = new BindingSource(brands, null);
                            creProBrandComboBox.DisplayMember = "Value";
                            creProBrandComboBox.ValueMember = "Key";
                            creProBrandComboBox.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading brands: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadVariationTypes()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, name FROM variations ORDER BY name";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<KeyValuePair<int, string>> variations = new List<KeyValuePair<int, string>>();
                            variations.Add(new KeyValuePair<int, string>(0, "Select Variation Type"));
                            while (reader.Read())
                            {
                                variations.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("name")));
                            }
                            creProVarTypeComboBox.DataSource = new BindingSource(variations, null);
                            creProVarTypeComboBox.DisplayMember = "Value";
                            creProVarTypeComboBox.ValueMember = "Key";
                            creProVarTypeComboBox.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading variation types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validation methods
        private bool ValidateProductName()
        {
            if (string.IsNullOrWhiteSpace(createProductNameText.Text))
            {
                nameErrorProvider.SetError(createProductNameText, "Product name is required.");
                return false;
            }
            if (createProductNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(createProductNameText, "Product name must be at least 2 characters.");
                return false;
            }
            nameErrorProvider.SetError(createProductNameText, string.Empty);
            return true;
        }

        private bool ValidateCategory()
        {
            if (ProCatComboox.SelectedIndex <= 0)
            {
                categoryErrorProvider.SetError(ProCatComboox, "Please select a category.");
                return false;
            }
            categoryErrorProvider.SetError(ProCatComboox, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            creProSaveBtn.Enabled = ValidateProductName() && ValidateCategory();
        }

        // Event handlers
        private void createProductNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateProductName();
            UpdateSaveButtonState();
        }

        private void ProCatComboox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateCategory();
            UpdateSaveButtonState();
        }

        private void creProSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateProductName() && ValidateCategory())
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        int productId;

                        // Step 1: Save or update the product
                        string query = isEditMode
                            ? "UPDATE products SET name = @name, category = @category, image_path = @imagePath, " +
                              "unit_id = @unitId, warehouse_id = @warehouseId, supplier_id = @supplierId, " +
                              "brand_id = @brandId, variation_type_id = @variationTypeId WHERE id = @productId"
                            : "INSERT INTO products (name, category, image_path, unit_id, warehouse_id, supplier_id, " +
                              "brand_id, variation_type_id) VALUES (@name, @category, @imagePath, @unitId, @warehouseId, " +
                              "@supplierId, @brandId, @variationTypeId)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", createProductNameText.Text.Trim());
                            cmd.Parameters.AddWithValue("@category", ProCatComboox.Text);
                            cmd.Parameters.AddWithValue("@imagePath", createProductMultipleImgText.Text ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@unitId", (int)creProUnitComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProUnitComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@warehouseId", (int)creProWareComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProWareComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@supplierId", (int)creProSupComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProSupComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@brandId", (int)creProBrandComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProBrandComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@variationTypeId", (int)creProVarTypeComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProVarTypeComboBox.SelectedValue);

                            if (isEditMode)
                            {
                                cmd.Parameters.AddWithValue("@productId", editProductId);
                                cmd.ExecuteNonQuery();
                                productId = editProductId;
                            }
                            else
                            {
                                cmd.ExecuteNonQuery();
                                productId = (int)cmd.LastInsertedId; // Get the new product ID
                            }
                        }

                        // Step 2: Handle pricing based on variation selection
                        if (creProVarTypeComboBox.SelectedIndex > 0 && pricingDetails != null && pricingDetails.Count > 0)
                        {
                            // Variation-based pricing from ProductPricing form
                            // Delete existing pricing for this product and variation to avoid duplicates
                            string deleteQuery = "DELETE FROM pricing WHERE product_id = @productId AND variation_id = @variationId";
                            using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@productId", productId);
                                deleteCmd.Parameters.AddWithValue("@variationId", (int)creProVarTypeComboBox.SelectedValue);
                                deleteCmd.ExecuteNonQuery();
                            }

                            // Insert new pricing details for each variation
                            foreach (var detail in pricingDetails)
                            {
                                string insertQuery = "INSERT INTO pricing (product_id, variation_id, variation_type, cost_price, retail_price, wholesale_price) " +
                                                    "VALUES (@productId, @variationId, @variationType, @costPrice, @retailPrice, @wholesalePrice)";
                                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@productId", productId);
                                    insertCmd.Parameters.AddWithValue("@variationId", (int)creProVarTypeComboBox.SelectedValue);
                                    insertCmd.Parameters.AddWithValue("@variationType", detail.VariationType);
                                    insertCmd.Parameters.AddWithValue("@costPrice", detail.CostPrice);
                                    insertCmd.Parameters.AddWithValue("@retailPrice", detail.RetailPrice);
                                    insertCmd.Parameters.AddWithValue("@wholesalePrice", detail.WholesalePrice);
                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (creProVarTypeComboBox.SelectedIndex == 0 && singlePricingPanel.Enabled)
                        {
                            // Single pricing for products without variations
                            // Validate that all pricing fields are filled
                            if (string.IsNullOrWhiteSpace(singleCostPriText.Text) ||
                                string.IsNullOrWhiteSpace(singleRetPriText.Text) ||
                                string.IsNullOrWhiteSpace(singleWholePriText.Text))
                            {
                                MessageBox.Show("Please fill in all single pricing fields.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Delete any existing single pricing for this product
                            string deleteQuery = "DELETE FROM pricing WHERE product_id = @productId AND variation_id IS NULL";
                            using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@productId", productId);
                                deleteCmd.ExecuteNonQuery();
                            }

                            // Insert new single pricing
                            string insertQuery = "INSERT INTO pricing (product_id, variation_id, variation_type, cost_price, retail_price, wholesale_price) " +
                                                "VALUES (@productId, NULL, NULL, @costPrice, @retailPrice, @wholesalePrice)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@productId", productId);
                                insertCmd.Parameters.AddWithValue("@costPrice", decimal.Parse(singleCostPriText.Text));
                                insertCmd.Parameters.AddWithValue("@retailPrice", decimal.Parse(singleRetPriText.Text));
                                insertCmd.Parameters.AddWithValue("@wholesalePrice", decimal.Parse(singleWholePriText.Text));
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please provide pricing details.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Step 3: Notify user of success
                        MessageBox.Show($"Product {(isEditMode ? "updated" : "created")} successfully.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creProCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void createProductMultipleImgBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    createProductMultipleImgText.Text = dialog.FileName;
                }
            }
        }

        private void creProVarTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (creProVarTypeComboBox.SelectedIndex > 0) // Assuming index 0 is "None" or similar
            {
                int variationId = (int)creProVarTypeComboBox.SelectedValue;
                int productId = isEditMode ? editProductId : -1; // Assuming isEditMode and editProductId exist

                using (ProductPricing productPricing = new ProductPricing(variationId, productId))
                {
                    if (productPricing.ShowDialog() == DialogResult.OK)
                    {
                        pricingDetails = productPricing.PricingDetails;
                    }
                    else
                    {
                        pricingDetails = null; // Reset if cancelled
                    }
                }
            }
        }

        private void enabalVTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            creProVarTypeComboBox.Enabled = enabalVTypeCheckBox.Checked;
            singlePricingPanel.Enabled = !enabalVTypeCheckBox.Checked;
            if (!enabalVTypeCheckBox.Checked)
            {
                creProVarTypeComboBox.SelectedIndex = 0;
            }
        }

        private void singleWholePriText_TextChanged(object sender, EventArgs e) { }
        private void singleRetPriText_TextChanged(object sender, EventArgs e) { }
        private void singleCostPriText_TextChanged(object sender, EventArgs e) { }
        private void singlePricingPanel_Paint(object sender, PaintEventArgs e) { }
        private void headerPanel_Paint(object sender, PaintEventArgs e) { }
        private void creProWareComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void creProUnitComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void creProSupComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void creProBrandComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void createProductMainPanel_Paint(object sender, PaintEventArgs e) { }
        private void createProductMultipleImgText_TextChanged(object sender, EventArgs e) { }

    }
}