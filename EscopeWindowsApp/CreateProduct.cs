﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Linq;

namespace EscopeWindowsApp
{
    public partial class CreateProduct : Form
    {
        private List<PricingData> pricingDetails;
        private bool isEditMode = false;
        private int editProductId = -1;
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider categoryErrorProvider = new ErrorProvider();
        private ErrorProvider upcErrorProvider = new ErrorProvider();
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private byte[] productImageData;
        private string selectedVariationType;

        public CreateProduct(int productId = -1, string name = "", string category = "",
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
                createProductNameText.ReadOnly = true;
                selectedVariationType = variationType;
                enabalVTypeCheckBox.Enabled = false;
                creProVarTypeComboBox.Enabled = false;
                upcNumberText.Enabled = string.IsNullOrEmpty(variationType) || variationType == "N/A";
            }

            createProductNameText.Text = name;
            ProCatComboox.Text = category;

            this.Load += CreateProduct_Load;
            UpdateSaveButtonState();

            // Enable key preview to capture keyboard events at the form level
            this.KeyPreview = true;
            this.KeyDown += CreateProduct_KeyDown;

            // Restrict text boxes to numeric input only
            singleCostPriText.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
                {
                    e.Handled = true;
                }
            };
            singleRetPriText.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
                {
                    e.Handled = true;
                }
            };
            upcNumberText.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        private void CreateProduct_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Enter key to trigger Save button
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                creProSaveBtn.PerformClick();
            }
            // Handle Escape key to trigger Cancel button
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                creProCancelBtn.PerformClick();
            }
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            categoryErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            upcErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadUnits();
            LoadWarehouses();
            LoadSuppliers();
            LoadBrands();
            LoadVariationTypes();
            if (isEditMode)
            {
                LoadExistingProductData();
            }
            UpdateSaveButtonState();
        }

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

        private void LoadExistingProductData()
        {
            if (!isEditMode || editProductId == -1) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            p.name, c.name AS category, p.image_path, p.unit_id, p.warehouse_id, 
                            p.supplier_id, p.brand_id, p.variation_type_id, v.name AS variation_name,
                            pr.cost_price, pr.retail_price, p.barcode
                        FROM products p
                        LEFT JOIN categories c ON p.category_id = c.id
                        LEFT JOIN variations v ON p.variation_type_id = v.id
                        LEFT JOIN pricing pr ON p.id = pr.product_id AND pr.variation_type IS NULL
                        WHERE p.id = @productId";
                    if (!string.IsNullOrEmpty(selectedVariationType) && selectedVariationType != "N/A")
                    {
                        query = query.Replace("pr.variation_type IS NULL", "pr.variation_type = @variationType");
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productId", editProductId);
                        if (!string.IsNullOrEmpty(selectedVariationType) && selectedVariationType != "N/A")
                        {
                            cmd.Parameters.AddWithValue("@variationType", selectedVariationType);
                        }
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                createProductNameText.Text = reader.GetString("name");
                                ProCatComboox.Text = reader.IsDBNull(reader.GetOrdinal("category")) ? "Select Category" : reader.GetString("category");
                                upcNumberText.Text = reader.IsDBNull(reader.GetOrdinal("barcode")) ? "" : reader.GetString("barcode");

                                if (!reader.IsDBNull(reader.GetOrdinal("image_path")))
                                {
                                    productImageData = (byte[])reader["image_path"];
                                    using (MemoryStream ms = new MemoryStream(productImageData))
                                    {
                                        productImagePictureBox.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    productImageData = null;
                                    productImagePictureBox.Image = null;
                                }

                                int unitId = reader.IsDBNull(reader.GetOrdinal("unit_id")) ? 0 : reader.GetInt32("unit_id");
                                creProUnitComboBox.SelectedValue = unitId;

                                int warehouseId = reader.IsDBNull(reader.GetOrdinal("warehouse_id")) ? 0 : reader.GetInt32("warehouse_id");
                                creProWareComboBox.SelectedValue = warehouseId;

                                int supplierId = reader.IsDBNull(reader.GetOrdinal("supplier_id")) ? 0 : reader.GetInt32("supplier_id");
                                creProSupComboBox.SelectedValue = supplierId;

                                int brandId = reader.IsDBNull(reader.GetOrdinal("brand_id")) ? 0 : reader.GetInt32("brand_id");
                                creProBrandComboBox.SelectedValue = brandId;

                                int variationTypeId = reader.IsDBNull(reader.GetOrdinal("variation_type_id")) ? 0 : reader.GetInt32("variation_type_id");
                                string variationName = reader.IsDBNull(reader.GetOrdinal("variation_name")) ? "Select Variation Type" : reader.GetString("variation_name");

                                creProVarTypeComboBox.SelectedValue = variationTypeId;
                                enabalVTypeCheckBox.Checked = variationTypeId != 0;
                                enabalVTypeCheckBox.Enabled = false;
                                creProVarTypeComboBox.Enabled = false;
                                singlePricingPanel.Enabled = variationTypeId == 0 || !string.IsNullOrEmpty(selectedVariationType);

                                if (variationTypeId != 0)
                                {
                                    varTypeLabel.Text = selectedVariationType != "N/A" ? selectedVariationType : "";
                                    varTypeLabel.Visible = true;
                                }
                                else
                                {
                                    varTypeLabel.Text = "";
                                    varTypeLabel.Visible = false;
                                }

                                if (!reader.IsDBNull(reader.GetOrdinal("cost_price")))
                                {
                                    singleCostPriText.Text = reader.GetDecimal("cost_price").ToString();
                                    singleRetPriText.Text = reader.GetDecimal("retail_price").ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Error loading units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool ValidateUPC()
        {
            if (enabalVTypeCheckBox.Checked)
            {
                upcErrorProvider.SetError(upcNumberText, string.Empty);
                return true; // UPC is handled in ProductPricing for variations
            }

            string upc = upcNumberText.Text.Trim();
            if (string.IsNullOrEmpty(upc))
            {
                upcErrorProvider.SetError(upcNumberText, string.Empty);
                return true; // UPC can be null
            }

            if (!Regex.IsMatch(upc, @"^\d+$"))
            {
                upcErrorProvider.SetError(upcNumberText, "UPC/EAN must be numeric.");
                return false;
            }

            if (upc.Length < 12)
            {
                upcErrorProvider.SetError(upcNumberText, "UPC/EAN must be at least 12 digits.");
                return false;
            }

            upcErrorProvider.SetError(upcNumberText, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            creProSaveBtn.Enabled = ValidateProductName() && ValidateCategory() && ValidateUPC();
        }

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

        private void upcNumberText_TextChanged(object sender, EventArgs e)
        {
            ValidateUPC();
            UpdateSaveButtonState();
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
                    productImageData = File.ReadAllBytes(dialog.FileName);
                    using (MemoryStream ms = new MemoryStream(productImageData))
                    {
                        productImagePictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void creProSaveBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateProductName() || !ValidateCategory() || !ValidateUPC())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    if (!enabalVTypeCheckBox.Checked && !string.IsNullOrEmpty(upcNumberText.Text.Trim()))
                    {
                        string checkQuery = "SELECT COUNT(*) FROM products WHERE barcode = @barcode AND id != @productId";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@barcode", upcNumberText.Text.Trim());
                            checkCmd.Parameters.AddWithValue("@productId", isEditMode ? editProductId : -1);
                            if ((long)checkCmd.ExecuteScalar() > 0)
                            {
                                MessageBox.Show("This UPC/EAN is already used by another product.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    if (isEditMode)
                    {
                        string query = @"
                            UPDATE products 
                            SET name = @name, 
                                category_id = (SELECT id FROM categories WHERE name = @category), 
                                image_path = @imagePath, 
                                unit_id = @unitId, 
                                warehouse_id = @warehouseId, 
                                supplier_id = @supplierId, 
                                brand_id = @brandId, 
                                variation_type_id = @variationTypeId, 
                                barcode = @barcode 
                            WHERE id = @productId";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", createProductNameText.Text.Trim());
                            cmd.Parameters.AddWithValue("@category", ProCatComboox.Text);
                            cmd.Parameters.AddWithValue("@imagePath", productImageData ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@unitId", (int)creProUnitComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProUnitComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@warehouseId", (int)creProWareComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProWareComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@supplierId", (int)creProSupComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProSupComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@brandId", (int)creProBrandComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProBrandComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@variationTypeId", (int)creProVarTypeComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProVarTypeComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@barcode", (enabalVTypeCheckBox.Checked || string.IsNullOrEmpty(upcNumberText.Text.Trim())) ? (object)DBNull.Value : upcNumberText.Text.Trim());
                            cmd.Parameters.AddWithValue("@productId", editProductId);
                            cmd.ExecuteNonQuery();
                        }

                        string pricingQuery = (int)creProVarTypeComboBox.SelectedValue == 0 || string.IsNullOrEmpty(varTypeLabel.Text)
                            ? "UPDATE pricing SET cost_price = @costPrice, retail_price = @retailPrice WHERE product_id = @productId AND variation_type IS NULL"
                            : "UPDATE pricing SET cost_price = @costPrice, retail_price = @retailPrice WHERE product_id = @productId AND variation_type = @variationType";

                        using (MySqlCommand pricingCmd = new MySqlCommand(pricingQuery, conn))
                        {
                            if (string.IsNullOrWhiteSpace(singleCostPriText.Text) ||
                                string.IsNullOrWhiteSpace(singleRetPriText.Text))
                            {
                                MessageBox.Show("Please fill in all single pricing fields.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            pricingCmd.Parameters.AddWithValue("@productId", editProductId);
                            pricingCmd.Parameters.AddWithValue("@costPrice", decimal.Parse(singleCostPriText.Text));
                            pricingCmd.Parameters.AddWithValue("@retailPrice", decimal.Parse(singleRetPriText.Text));
                            if ((int)creProVarTypeComboBox.SelectedValue != 0 && !string.IsNullOrEmpty(varTypeLabel.Text))
                            {
                                pricingCmd.Parameters.AddWithValue("@variationType", varTypeLabel.Text);
                            }
                            pricingCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        if ((int)creProVarTypeComboBox.SelectedValue != 0 && pricingDetails != null && pricingDetails.Count > 0)
                        {
                            foreach (var detail in pricingDetails)
                            {
                                string productQuery = @"
                                    INSERT INTO products (
                                        name, category_id, image_path, unit_id, warehouse_id, 
                                        supplier_id, brand_id, variation_type_id, barcode
                                    ) VALUES (
                                        @name, (SELECT id FROM categories WHERE name = @category), 
                                        @imagePath, @unitId, @warehouseId, @supplierId, @brandId, 
                                        @variationTypeId, @barcode
                                    )";
                                using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                                {
                                    string variationName = $"{createProductNameText.Text.Trim()} ({detail.TypeName})";
                                    cmd.Parameters.AddWithValue("@name", variationName);
                                    cmd.Parameters.AddWithValue("@category", ProCatComboox.Text);
                                    cmd.Parameters.AddWithValue("@imagePath", productImageData ?? (object)DBNull.Value);
                                    cmd.Parameters.AddWithValue("@unitId", (int)creProUnitComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProUnitComboBox.SelectedValue);
                                    cmd.Parameters.AddWithValue("@warehouseId", (int)creProWareComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProWareComboBox.SelectedValue);
                                    cmd.Parameters.AddWithValue("@supplierId", (int)creProSupComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProSupComboBox.SelectedValue);
                                    cmd.Parameters.AddWithValue("@brandId", (int)creProBrandComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProBrandComboBox.SelectedValue);
                                    cmd.Parameters.AddWithValue("@variationTypeId", (int)creProVarTypeComboBox.SelectedValue);
                                    cmd.Parameters.AddWithValue("@barcode", string.IsNullOrEmpty(detail.UPC) ? (object)DBNull.Value : detail.UPC);
                                    cmd.ExecuteNonQuery();

                                    int newProductId = (int)cmd.LastInsertedId;

                                    // Initialize stock using StockManager
                                    StockManager stockManager = new StockManager(connectionString);
                                    stockManager.UpdateStock(newProductId, detail.TypeName, 0, creProUnitComboBox.Text, true);

                                    string pricingQuery = @"
                                        INSERT INTO pricing (
                                            product_id, variation_id, variation_type, cost_price, retail_price
                                        ) VALUES (
                                            @productId, @variationId, @variationType, @costPrice, @retailPrice
                                        )";
                                    using (MySqlCommand pricingCmd = new MySqlCommand(pricingQuery, conn))
                                    {
                                        pricingCmd.Parameters.AddWithValue("@productId", newProductId);
                                        pricingCmd.Parameters.AddWithValue("@variationId", (int)creProVarTypeComboBox.SelectedValue);
                                        pricingCmd.Parameters.AddWithValue("@variationType", detail.TypeName);
                                        pricingCmd.Parameters.AddWithValue("@costPrice", detail.CostPrice);
                                        pricingCmd.Parameters.AddWithValue("@retailPrice", detail.RetailPrice);
                                        pricingCmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        else
                        {
                            string productQuery = @"
                                INSERT INTO products (
                                    name, category_id, image_path, unit_id, warehouse_id, 
                                    supplier_id, brand_id, variation_type_id, barcode
                                ) VALUES (
                                    @name, (SELECT id FROM categories WHERE name = @category), 
                                    @imagePath, @unitId, @warehouseId, @supplierId, @brandId, 
                                    @variationTypeId, @barcode
                                )";
                            using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@name", createProductNameText.Text.Trim());
                                cmd.Parameters.AddWithValue("@category", ProCatComboox.Text);
                                cmd.Parameters.AddWithValue("@imagePath", productImageData ?? (object)DBNull.Value);
                                cmd.Parameters.AddWithValue("@unitId", (int)creProUnitComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProUnitComboBox.SelectedValue);
                                cmd.Parameters.AddWithValue("@warehouseId", (int)creProWareComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProWareComboBox.SelectedValue);
                                cmd.Parameters.AddWithValue("@supplierId", (int)creProSupComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProSupComboBox.SelectedValue);
                                cmd.Parameters.AddWithValue("@brandId", (int)creProBrandComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProBrandComboBox.SelectedValue);
                                cmd.Parameters.AddWithValue("@variationTypeId", (int)creProVarTypeComboBox.SelectedValue == 0 ? (object)DBNull.Value : creProVarTypeComboBox.SelectedValue);
                                cmd.Parameters.AddWithValue("@barcode", string.IsNullOrEmpty(upcNumberText.Text.Trim()) ? (object)DBNull.Value : upcNumberText.Text.Trim());
                                cmd.ExecuteNonQuery();

                                int productId = (int)cmd.LastInsertedId;

                                // Initialize stock using StockManager
                                StockManager stockManager = new StockManager(connectionString);
                                stockManager.UpdateStock(productId, null, 0, creProUnitComboBox.Text, true);

                                string pricingQuery = @"
                                    INSERT INTO pricing (
                                        product_id, variation_id, variation_type, cost_price, retail_price
                                    ) VALUES (
                                        @productId, @variationId, @variationType, @costPrice, @retailPrice
                                    )";
                                using (MySqlCommand pricingCmd = new MySqlCommand(pricingQuery, conn))
                                {
                                    if (string.IsNullOrWhiteSpace(singleCostPriText.Text) ||
                                        string.IsNullOrWhiteSpace(singleRetPriText.Text))
                                    {
                                        MessageBox.Show("Please fill in all single pricing fields.", "Validation Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                    pricingCmd.Parameters.AddWithValue("@productId", productId);
                                    pricingCmd.Parameters.AddWithValue("@costPrice", decimal.Parse(singleCostPriText.Text));
                                    pricingCmd.Parameters.AddWithValue("@retailPrice", decimal.Parse(singleRetPriText.Text));
                                    if ((int)creProVarTypeComboBox.SelectedValue == 0)
                                    {
                                        pricingCmd.Parameters.AddWithValue("@variationId", DBNull.Value);
                                        pricingCmd.Parameters.AddWithValue("@variationType", DBNull.Value);
                                    }
                                    else
                                    {
                                        pricingCmd.Parameters.AddWithValue("@variationId", (int)creProVarTypeComboBox.SelectedValue);
                                        pricingCmd.Parameters.AddWithValue("@variationType", varTypeLabel.Text);
                                    }
                                    pricingCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

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

        private void creProCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void creProVarTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (creProVarTypeComboBox.SelectedIndex > 0)
            {
                upcNumberText.Enabled = false;
                if (isEditMode)
                {
                    varTypeLabel.Text = creProVarTypeComboBox.Text;
                    varTypeLabel.Visible = true;
                    singlePricingPanel.Enabled = true;

                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = @"
                                SELECT cost_price, retail_price
                                FROM pricing
                                WHERE product_id = @productId AND variation_type = @variationType";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@productId", editProductId);
                                cmd.Parameters.AddWithValue("@variationType", creProVarTypeComboBox.Text);
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        singleCostPriText.Text = reader.GetDecimal("cost_price").ToString();
                                        singleRetPriText.Text = reader.GetDecimal("retail_price").ToString();
                                    }
                                    else
                                    {
                                        singleCostPriText.Text = "";
                                        singleRetPriText.Text = "";
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading variation pricing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    singlePricingPanel.Enabled = false;
                    int variationId = (int)creProVarTypeComboBox.SelectedValue;
                    int productId = -1;

                    using (ProductPricing productPricing = new ProductPricing(variationId, productId))
                    {
                        if (productPricing.ShowDialog() == DialogResult.OK)
                        {
                            pricingDetails = productPricing.PricingDetails;
                            varTypeLabel.Text = "";
                            varTypeLabel.Visible = false;
                            singlePricingPanel.Enabled = false;
                        }
                        else
                        {
                            pricingDetails = null;
                            creProVarTypeComboBox.SelectedIndex = 0;
                            singlePricingPanel.Enabled = false;
                            upcNumberText.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                upcNumberText.Enabled = true;
                varTypeLabel.Text = "";
                varTypeLabel.Visible = false;
                singleCostPriText.Text = "";
                singleRetPriText.Text = "";
                singlePricingPanel.Enabled = !isEditMode && !enabalVTypeCheckBox.Checked;
                pricingDetails = null;
            }
        }

        private void enabalVTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            creProVarTypeComboBox.Enabled = enabalVTypeCheckBox.Checked;
            upcNumberText.Enabled = !enabalVTypeCheckBox.Checked;
            singlePricingPanel.Enabled = isEditMode ? enabalVTypeCheckBox.Checked : !enabalVTypeCheckBox.Checked;
            if (!enabalVTypeCheckBox.Checked)
            {
                creProVarTypeComboBox.SelectedIndex = 0;
                varTypeLabel.Text = "";
                varTypeLabel.Visible = false;
                singleCostPriText.Text = "";
                singleRetPriText.Text = "";
                pricingDetails = null;
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
        private void productImagePictureBox_Click(object sender, EventArgs e) { }
        private void varTypeLabel_Click(object sender, EventArgs e) { }
    }
}