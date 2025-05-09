using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Drawing; // For Color.White

namespace EscopeWindowsApp
{
    public partial class AddCustomerForm : Form
    {
        private bool isEditMode = false;
        private int editCustomerId = -1;

        // Error providers for validation
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider emailErrorProvider = new ErrorProvider();
        private ErrorProvider phoneErrorProvider = new ErrorProvider();
        private ErrorProvider dobErrorProvider = new ErrorProvider();
        private ErrorProvider cityErrorProvider = new ErrorProvider();
        private ErrorProvider addressErrorProvider = new ErrorProvider();

        public AddCustomerForm(int customerId = -1, string name = "", string email = "", string phone = "", DateTime? dob = null, string city = "", string address = "")
        {
            InitializeComponent();
            SetupErrorProviders();
            CustomizeDateTimePicker(); // Customize SiticoneDateTimePicker

            if (customerId != -1)
            {
                isEditMode = true;
                editCustomerId = customerId;
                this.Text = "Edit Customer";
                cusSaveBtn.Text = "Update";
            }

            // Pre-fill form fields
            createCusNameText.Text = name;
            addCusEmailText.Text = email;
            CreateCusPhoneText.Text = phone;
            createCusDateTime.Value = dob.HasValue ? dob.Value : DateTime.Now.AddYears(-18);
            createCusCityText.Text = city;
            createCusAddressText.Text = address;

            UpdateSaveButtonState();

            // Enable Enter key to trigger save
            this.KeyPreview = true;
            this.KeyDown += AddCustomerForm_KeyDown;

            // Restrict phone textbox to numeric input
            CreateCusPhoneText.KeyPress += CreateCusPhoneText_KeyPress;
        }

        #region DateTimePicker Customization
        private void CustomizeDateTimePicker()
        {
            // Set fill color to White for SiticoneDateTimePicker
            createCusDateTime.FillColor = Color.White;
            createCusDateTime.HoverState.FillColor = Color.White; // Maintain white on hover
            createCusDateTime.BorderColor = Color.Gray; // Optional: subtle border
        }
        #endregion

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            phoneErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dobErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            cityErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            addressErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private void AddCustomerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cusSaveBtn.Enabled)
            {
                cusSaveBtn.PerformClick();
                e.Handled = true;
            }
        }

        private void CreateCusPhoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            // Limit to 10 digits
            if (CreateCusPhoneText.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidateCustomerName()
        {
            if (string.IsNullOrWhiteSpace(createCusNameText.Text))
            {
                nameErrorProvider.SetError(createCusNameText, "Name is required.");
                return false;
            }
            if (createCusNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(createCusNameText, "Name must be at least 2 characters.");
                return false;
            }
            nameErrorProvider.SetError(createCusNameText, string.Empty);
            return true;
        }

        private bool ValidateEmail()
        {
            if (string.IsNullOrWhiteSpace(addCusEmailText.Text))
            {
                emailErrorProvider.SetError(addCusEmailText, "Email is required.");
                return false;
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(addCusEmailText.Text, emailPattern))
            {
                emailErrorProvider.SetError(addCusEmailText, "Invalid email format.");
                return false;
            }
            emailErrorProvider.SetError(addCusEmailText, string.Empty);
            return true;
        }

        private bool ValidatePhoneNumber()
        {
            if (string.IsNullOrWhiteSpace(CreateCusPhoneText.Text))
            {
                phoneErrorProvider.SetError(CreateCusPhoneText, "Phone number is required.");
                return false;
            }
            string phonePattern = @"^\d{10}$";
            if (!Regex.IsMatch(CreateCusPhoneText.Text, phonePattern))
            {
                phoneErrorProvider.SetError(CreateCusPhoneText, "Phone number must be exactly 10 digits.");
                return false;
            }
            phoneErrorProvider.SetError(CreateCusPhoneText, string.Empty);
            return true;
        }

        private bool ValidateDOB()
        {
            DateTime minDate = DateTime.Now.AddYears(-18);
            if (createCusDateTime.Value >= DateTime.Now)
            {
                dobErrorProvider.SetError(createCusDateTime, "Date of birth must be in the past.");
                return false;
            }
            if (createCusDateTime.Value > minDate)
            {
                dobErrorProvider.SetError(createCusDateTime, "Customer must be at least 18 years old.");
                return false;
            }
            dobErrorProvider.SetError(createCusDateTime, string.Empty);
            return true;
        }

        private bool ValidateCity()
        {
            if (string.IsNullOrWhiteSpace(createCusCityText.Text))
            {
                cityErrorProvider.SetError(createCusCityText, "City is required.");
                return false;
            }
            cityErrorProvider.SetError(createCusCityText, string.Empty);
            return true;
        }

        private bool ValidateAddress()
        {
            if (string.IsNullOrWhiteSpace(createCusAddressText.Text))
            {
                addressErrorProvider.SetError(createCusAddressText, "Address is required.");
                return false;
            }
            addressErrorProvider.SetError(createCusAddressText, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            bool isValid = ValidateCustomerName() && ValidateEmail() && ValidatePhoneNumber() &&
                           ValidateDOB() && ValidateCity() && ValidateAddress();
            cusSaveBtn.Enabled = isValid;
        }

        private void createCusNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateCustomerName();
            UpdateSaveButtonState();
        }

        private void addCusEmailText_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
            UpdateSaveButtonState();
        }

        private void CreateCusPhoneText_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber();
            UpdateSaveButtonState();
        }

        private void createCusDateTime_ValueChanged(object sender, EventArgs e)
        {
            ValidateDOB();
            UpdateSaveButtonState();
        }

        private void createCusCityText_TextChanged(object sender, EventArgs e)
        {
            ValidateCity();
            UpdateSaveButtonState();
        }

        private void createCusAddressText_TextChanged(object sender, EventArgs e)
        {
            ValidateAddress();
            UpdateSaveButtonState();
        }

        private void createCusPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cusSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateCustomerName() && ValidateEmail() && ValidatePhoneNumber() &&
                           ValidateDOB() && ValidateCity() && ValidateAddress();
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
                            string query = "UPDATE customers SET name = @name, email = @email, phone = @phone, dob = @dob, city = @city, address = @address WHERE id = @customerId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createCusNameText.Text.Trim());
                                command.Parameters.AddWithValue("@email", addCusEmailText.Text.Trim());
                                command.Parameters.AddWithValue("@phone", CreateCusPhoneText.Text.Trim());
                                command.Parameters.AddWithValue("@dob", createCusDateTime.Value.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@city", createCusCityText.Text.Trim());
                                command.Parameters.AddWithValue("@address", createCusAddressText.Text.Trim());
                                command.Parameters.AddWithValue("@customerId", editCustomerId);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string query = "INSERT INTO customers (name, email, phone, dob, city, address) " +
                                           "VALUES (@name, @email, @phone, @dob, @city, @address)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createCusNameText.Text.Trim());
                                command.Parameters.AddWithValue("@email", addCusEmailText.Text.Trim());
                                command.Parameters.AddWithValue("@phone", CreateCusPhoneText.Text.Trim());
                                command.Parameters.AddWithValue("@dob", createCusDateTime.Value.ToString("yyyy-MM-dd"));
                                command.Parameters.AddWithValue("@city", createCusCityText.Text.Trim());
                                command.Parameters.AddWithValue("@address", createCusAddressText.Text.Trim());
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Customer registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cusCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}