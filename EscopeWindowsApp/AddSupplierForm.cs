using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Linq; // Added to resolve the 'All' method error

namespace EscopeWindowsApp
{
    public partial class AddSupplierForm : Form
    {
        private bool isEditMode = false;
        private int editSupplierId = -1;

        // Error providers for validation
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider emailErrorProvider = new ErrorProvider();
        private ErrorProvider phoneErrorProvider = new ErrorProvider();
        private ErrorProvider cityErrorProvider = new ErrorProvider();
        private ErrorProvider addressErrorProvider = new ErrorProvider();
        private ErrorProvider itemErrorProvider = new ErrorProvider();

        public AddSupplierForm(int supplierId = -1, string name = "", string email = "", string phone = "", string city = "", string address = "", string item = "")
        {
            InitializeComponent();
            SetupErrorProviders();

            if (supplierId != -1)
            {
                isEditMode = true;
                editSupplierId = supplierId;
                this.Text = "Edit Supplier";
                supSaveBtn.Text = "Update";
            }

            // Pre-fill form fields
            createSupNameText.Text = name;
            createSupEmailText.Text = email;
            createSupPhoneText.Text = phone;
            createSupCityText.Text = city;
            createSupAddressText.Text = address;
            createSupItemText.Text = item;

            UpdateSaveButtonState();

            // Enable key preview to capture keyboard events at the form level
            this.KeyPreview = true;
            this.KeyDown += AddSupplierForm_KeyDown;

            // Restrict createSupPhoneText to numeric input and max 10 digits
            createSupPhoneText.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (char.IsDigit(e.KeyChar) && createSupPhoneText.Text.Length >= 10)
                {
                    e.Handled = true;
                }
            };
        }

        private void AddSupplierForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Enter key to trigger Save button
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                supSaveBtn.PerformClick();
            }
            // Handle Escape key to trigger Cancel button
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                supCancelBtn.PerformClick();
            }
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            phoneErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            cityErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            addressErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            itemErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private bool ValidateSupplierName()
        {
            if (string.IsNullOrWhiteSpace(createSupNameText.Text))
            {
                nameErrorProvider.SetError(createSupNameText, "Supplier name is required.");
                return false;
            }
            if (createSupNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(createSupNameText, "Name must be at least 2 characters.");
                return false;
            }
            nameErrorProvider.SetError(createSupNameText, string.Empty);
            return true;
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(createSupEmailText.Text))
            {
                emailErrorProvider.SetError(createSupEmailText, "Email is required.");
                return false;
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(createSupEmailText.Text, emailPattern))
            {
                emailErrorProvider.SetError(createSupEmailText, "Invalid email format.");
                return false;
            }
            emailErrorProvider.SetError(createSupEmailText, string.Empty);
            return true;
        }

        private bool ValidatePhoneNumber()
        {
            if (string.IsNullOrWhiteSpace(createSupPhoneText.Text))
            {
                phoneErrorProvider.SetError(createSupPhoneText, "Phone number is required.");
                return false;
            }
            if (createSupPhoneText.Text.Length != 10 || !createSupPhoneText.Text.All(char.IsDigit))
            {
                phoneErrorProvider.SetError(createSupPhoneText, "Phone number must be exactly 10 digits.");
                return false;
            }
            phoneErrorProvider.SetError(createSupPhoneText, string.Empty);
            return true;
        }

        private bool ValidateCity()
        {
            if (string.IsNullOrWhiteSpace(createSupCityText.Text))
            {
                cityErrorProvider.SetError(createSupCityText, "City is required.");
                return false;
            }
            cityErrorProvider.SetError(createSupCityText, string.Empty);
            return true;
        }

        private bool ValidateAddress()
        {
            if (string.IsNullOrWhiteSpace(createSupAddressText.Text))
            {
                addressErrorProvider.SetError(createSupAddressText, "Address is required.");
                return false;
            }
            addressErrorProvider.SetError(createSupAddressText, string.Empty);
            return true;
        }

        private bool ValidateItem()
        {
            if (string.IsNullOrWhiteSpace(createSupItemText.Text))
            {
                itemErrorProvider.SetError(createSupItemText, "Item is required.");
                return false;
            }
            itemErrorProvider.SetError(createSupItemText, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            bool isValid = ValidateSupplierName() && ValidateEmail() && ValidatePhoneNumber() &&
                           ValidateCity() && ValidateAddress() && ValidateItem();
            supSaveBtn.Enabled = isValid;
        }

        private void createSupNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateSupplierName();
            UpdateSaveButtonState();
        }

        private void createSupEmailText_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
            UpdateSaveButtonState();
        }

        private void createSupPhoneText_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber();
            UpdateSaveButtonState();
        }

        private void createSupCityText_TextChanged(object sender, EventArgs e)
        {
            ValidateCity();
            UpdateSaveButtonState();
        }

        private void createSupAddressText_TextChanged(object sender, EventArgs e)
        {
            ValidateAddress();
            UpdateSaveButtonState();
        }

        private void createSupItemText_TextChanged(object sender, EventArgs e)
        {
            ValidateItem();
            UpdateSaveButtonState();
        }

        private void supSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateSupplierName() && ValidateEmail() && ValidatePhoneNumber() &&
                           ValidateCity() && ValidateAddress() && ValidateItem();
            if (isValid)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        if (isEditMode)
                        {
                            string query = "UPDATE suppliers SET name = @name, email = @email, phone = @phone, city = @city, address = @address, item = @item WHERE id = @supplierId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createSupNameText.Text.Trim());
                                command.Parameters.AddWithValue("@email", createSupEmailText.Text.Trim());
                                command.Parameters.AddWithValue("@phone", createSupPhoneText.Text.Trim());
                                command.Parameters.AddWithValue("@city", createSupCityText.Text.Trim());
                                command.Parameters.AddWithValue("@address", createSupAddressText.Text.Trim());
                                command.Parameters.AddWithValue("@item", createSupItemText.Text.Trim());
                                command.Parameters.AddWithValue("@supplierId", editSupplierId);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string query = "INSERT INTO suppliers (name, email, phone, city, address, item) " +
                                           "VALUES (@name, @email, @phone, @city, @address, @item)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createSupNameText.Text.Trim());
                                command.Parameters.AddWithValue("@email", createSupEmailText.Text.Trim());
                                command.Parameters.AddWithValue("@phone", createSupPhoneText.Text.Trim());
                                command.Parameters.AddWithValue("@city", createSupCityText.Text.Trim());
                                command.Parameters.AddWithValue("@address", createSupAddressText.Text.Trim());
                                command.Parameters.AddWithValue("@item", createSupItemText.Text.Trim());
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Supplier registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void supCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void craeteSupItemLabel_Click(object sender, EventArgs e)
        {

        }
    }
}