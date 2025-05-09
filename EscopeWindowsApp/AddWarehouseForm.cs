using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class AddWarehouseForm : Form
    {
        private bool isEditMode = false;
        private int editWarehouseId = -1;

        // Error providers for validation
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider emailErrorProvider = new ErrorProvider();
        private ErrorProvider phoneErrorProvider = new ErrorProvider();
        private ErrorProvider cityErrorProvider = new ErrorProvider();
        private ErrorProvider addressErrorProvider = new ErrorProvider();
        private ErrorProvider zipCodeErrorProvider = new ErrorProvider();

        public AddWarehouseForm(int warehouseId = -1, string name = "", string email = "", string phone = "", string city = "", string address = "", string zipCode = "")
        {
            InitializeComponent();
            SetupErrorProviders();

            if (warehouseId != -1)
            {
                isEditMode = true;
                editWarehouseId = warehouseId;
                this.Text = "Edit Warehouse";
                addWarehouseSaveBtn.Text = "Update";
            }

            // Pre-fill form fields
            addWarehouseNameText.Text = name;
            addWarehouseEmailText.Text = email;
            addWarehousePhoneText.Text = phone;
            addWarehouseCityText.Text = city;
            addWarehouseAddressText.Text = address;
            addWarehouseZipCodeText.Text = zipCode;

            UpdateSaveButtonState();

            // Enable key preview to capture keyboard events at the form level
            this.KeyPreview = true;
            this.KeyDown += AddWarehouseForm_KeyDown;

            // Restrict addWarehousePhoneText to numeric input and max 10 digits
            addWarehousePhoneText.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (char.IsDigit(e.KeyChar) && addWarehousePhoneText.Text.Length >= 10)
                {
                    e.Handled = true;
                }
            };
        }

        private void AddWarehouseForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Enter key to trigger Save button
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                addWarehouseSaveBtn.PerformClick();
            }
            // Handle Escape key to trigger Cancel button
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                addWarehouseCancelBtn.PerformClick();
            }
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            phoneErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            cityErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            addressErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            zipCodeErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void AddWarehouseForm_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private bool ValidateWarehouseName()
        {
            if (string.IsNullOrWhiteSpace(addWarehouseNameText.Text))
            {
                nameErrorProvider.SetError(addWarehouseNameText, "Warehouse name is required.");
                return false;
            }
            if (addWarehouseNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(addWarehouseNameText, "Name must be at least 2 characters.");
                return false;
            }
            nameErrorProvider.SetError(addWarehouseNameText, string.Empty);
            return true;
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(addWarehouseEmailText.Text))
            {
                emailErrorProvider.SetError(addWarehouseEmailText, "Email is required.");
                return false;
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(addWarehouseEmailText.Text, emailPattern))
            {
                emailErrorProvider.SetError(addWarehouseEmailText, "Invalid email format.");
                return false;
            }
            emailErrorProvider.SetError(addWarehouseEmailText, string.Empty);
            return true;
        }

        private bool ValidatePhoneNumber()
        {
            if (string.IsNullOrWhiteSpace(addWarehousePhoneText.Text))
            {
                phoneErrorProvider.SetError(addWarehousePhoneText, "Phone number is required.");
                return false;
            }
            string phonePattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
            if (!Regex.IsMatch(addWarehousePhoneText.Text, phonePattern))
            {
                phoneErrorProvider.SetError(addWarehousePhoneText, "Invalid phone number format.");
                return false;
            }
            phoneErrorProvider.SetError(addWarehousePhoneText, string.Empty);
            return true;
        }

        private bool ValidateCity()
        {
            if (string.IsNullOrWhiteSpace(addWarehouseCityText.Text))
            {
                cityErrorProvider.SetError(addWarehouseCityText, "City is required.");
                return false;
            }
            cityErrorProvider.SetError(addWarehouseCityText, string.Empty);
            return true;
        }

        private bool ValidateAddress()
        {
            if (string.IsNullOrWhiteSpace(addWarehouseAddressText.Text))
            {
                addressErrorProvider.SetError(addWarehouseAddressText, "Address is required.");
                return false;
            }
            addressErrorProvider.SetError(addWarehouseAddressText, string.Empty);
            return true;
        }

        private bool ValidateZipCode()
        {
            if (string.IsNullOrWhiteSpace(addWarehouseZipCodeText.Text))
            {
                zipCodeErrorProvider.SetError(addWarehouseZipCodeText, "Zip code is required.");
                return false;
            }
            string zipPattern = @"^\d{5}(-\d{4})?$"; // Example for US ZIP codes, adjust as needed
            if (!Regex.IsMatch(addWarehouseZipCodeText.Text, zipPattern))
            {
                zipCodeErrorProvider.SetError(addWarehouseZipCodeText, "Invalid zip code format.");
                return false;
            }
            zipCodeErrorProvider.SetError(addWarehouseZipCodeText, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            bool isValid = ValidateWarehouseName() && ValidateEmail() && ValidatePhoneNumber() &&
                           ValidateCity() && ValidateAddress() && ValidateZipCode();
            addWarehouseSaveBtn.Enabled = isValid;
        }

        private void addWarehouseNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateWarehouseName();
            UpdateSaveButtonState();
        }

        private void addWarehouseEmailText_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
            UpdateSaveButtonState();
        }

        private void addWarehousePhoneText_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber();
            UpdateSaveButtonState();
        }

        private void addWarehouseCityText_TextChanged(object sender, EventArgs e)
        {
            ValidateCity();
            UpdateSaveButtonState();
        }

        private void addWarehouseAddressText_TextChanged(object sender, EventArgs e)
        {
            ValidateAddress();
            UpdateSaveButtonState();
        }

        private void addWarehouseZipCodeText_TextChanged(object sender, EventArgs e)
        {
            ValidateZipCode();
            UpdateSaveButtonState();
        }

        private void addWarehouseSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateWarehouseName() && ValidateEmail() && ValidatePhoneNumber() &&
                           ValidateCity() && ValidateAddress() && ValidateZipCode();
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
                            string query = "UPDATE warehouses SET name = @name, email = @email, phone = @phone, city = @city, address = @address, zip_code = @zipCode WHERE id = @warehouseId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", addWarehouseNameText.Text.Trim());
                                command.Parameters.AddWithValue("@email", addWarehouseEmailText.Text.Trim());
                                command.Parameters.AddWithValue("@phone", addWarehousePhoneText.Text.Trim());
                                command.Parameters.AddWithValue("@city", addWarehouseCityText.Text.Trim());
                                command.Parameters.AddWithValue("@address", addWarehouseAddressText.Text.Trim());
                                command.Parameters.AddWithValue("@zipCode", addWarehouseZipCodeText.Text.Trim());
                                command.Parameters.AddWithValue("@warehouseId", editWarehouseId);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Warehouse updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string query = "INSERT INTO warehouses (name, email, phone, city, address, zip_code) " +
                                           "VALUES (@name, @email, @phone, @city, @address, @zipCode)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", addWarehouseNameText.Text.Trim());
                                command.Parameters.AddWithValue("@email", addWarehouseEmailText.Text.Trim());
                                command.Parameters.AddWithValue("@phone", addWarehousePhoneText.Text.Trim());
                                command.Parameters.AddWithValue("@city", addWarehouseCityText.Text.Trim());
                                command.Parameters.AddWithValue("@address", addWarehouseAddressText.Text.Trim());
                                command.Parameters.AddWithValue("@zipCode", addWarehouseZipCodeText.Text.Trim());
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Warehouse added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving warehouse: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addWarehouseCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}