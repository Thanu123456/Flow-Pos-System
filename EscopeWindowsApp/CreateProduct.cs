using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Siticone.Desktop.UI.WinForms;

namespace EscopeWindowsApp
{
    public partial class CreateProduct : Form
    {
        private bool isEditMode = false;
        private int editProductId = -1;
        private Dictionary<Control, int> originalPositions = new Dictionary<Control, int>();

        // Error providers for validation
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider categoryErrorProvider = new ErrorProvider();

        public CreateProduct(int productId = -1, string name = "", string category = "", string barcodeSym = "", string imagePath = "")
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

            // Pre-fill form fields
            createProductNameText.Text = name;
            ProCatComboox.Text = category;
            //creProBarcodeSymComboBox.Text = barcodeSym;
            createProductMultipleImgText.Text = imagePath;

            UpdateSaveButtonState();
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            categoryErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
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
            if (string.IsNullOrWhiteSpace(ProCatComboox.Text))
            {
                categoryErrorProvider.SetError(ProCatComboox, "Category is required.");
                return false;
            }
            categoryErrorProvider.SetError(ProCatComboox, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            creProSaveBtn.Enabled = ValidateProductName() && ValidateCategory();
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

        private void createProductMultipleImgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
                    dialog.FilterIndex = 1;
                    dialog.RestoreDirectory = true;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = dialog.FileName;
                        string fileName = System.IO.Path.GetFileName(filePath);
                        createProductMultipleImgText.Text = fileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void creProVarTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(creProVarTypeComboBox.Text))
            {
                try
                {
                    ProductPricing productPricing = new ProductPricing();
                    productPricing.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening ProductPricing form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void creProSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateProductName() && ValidateCategory())
            {
                try
                {
                    string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        if (isEditMode)
                        {
                            string query = "UPDATE products SET name = @name, category = @category, barcode_sym = @barcodeSym, image_path = @imagePath WHERE id = @productId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createProductNameText.Text.Trim());
                                command.Parameters.AddWithValue("@category", ProCatComboox.Text);
                                //command.Parameters.AddWithValue("@barcodeSym", creProBarcodeSymComboBox.Text ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@imagePath", createProductMultipleImgText.Text ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@productId", editProductId);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string query = "INSERT INTO products (name, category, barcode_sym, image_path) VALUES (@name, @category, @barcodeSym, @imagePath)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createProductNameText.Text.Trim());
                                command.Parameters.AddWithValue("@category", ProCatComboox.Text);
                                //command.Parameters.AddWithValue("@barcodeSym", creProBarcodeSymComboBox.Text ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@imagePath", createProductMultipleImgText.Text ?? (object)DBNull.Value);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Product created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creProCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenAddVariationForm()
        {
            try
            {
                AddVariationItem addVariationForm = new AddVariationItem();
                addVariationForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening AddVariationItem form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Missing Event Handlers Added Below
        private void singleWholePriText_TextChanged(object sender, EventArgs e)
        {
            // Placeholder: Add logic if needed (e.g., validate wholesale price)
        }

        private void singleRetPriText_TextChanged(object sender, EventArgs e)
        {
            // Placeholder: Add logic if needed (e.g., validate retail price)
        }

        private void singleCostPriText_TextChanged(object sender, EventArgs e)
        {
            // Placeholder: Add logic if needed (e.g., validate cost price)
        }

        private void singlePricingPanel_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder: Add custom painting logic if needed
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder: Add custom painting logic if needed
        }

        private void creProWareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder: Add logic for warehouse selection if needed
        }

        private void creProUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder: Add logic for unit selection if needed
        }

        private void creProSupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder: Add logic for supplier selection if needed
        }

        private void creProBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder: Add logic for brand selection if needed
        }

        // Placeholder for ProductPricing form

        private void enabalVTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            creProVarTypeComboBox.Enabled = enabalVTypeCheckBox.Checked;
            singlePricingPanel.Enabled = !enabalVTypeCheckBox.Checked;

            if (!enabalVTypeCheckBox.Checked)
            {
                creProVarTypeComboBox.SelectedIndex = -1;
            }
        }
    }
}