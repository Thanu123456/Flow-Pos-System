using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class AddCustomerForm : Form
    {
        // Error providers for validation
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider emailErrorProvider = new ErrorProvider();
        private ErrorProvider phoneErrorProvider = new ErrorProvider();
        private ErrorProvider dobErrorProvider = new ErrorProvider();
        private ErrorProvider cityErrorProvider = new ErrorProvider();
        private ErrorProvider addressErrorProvider = new ErrorProvider();

        public AddCustomerForm()
        {
            InitializeComponent();
            SetupErrorProviders();
        }

        private void SetupErrorProviders()
        {
            // Set the blink style to never blink.
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            emailErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            phoneErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dobErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            cityErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            addressErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            // Initialization code here
        }

        private bool ValidateCustomerName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createCusNameText.Text);
            if (!isValid)
            {
                nameErrorProvider.SetError(createCusNameText, "Customer name is required.");
            }
            else
            {
                nameErrorProvider.SetError(createCusNameText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateEmail()
        {
            bool isValid = !string.IsNullOrWhiteSpace(addCusEmailText.Text) && addCusEmailText.Text.Contains("@");
            if (!isValid)
            {
                emailErrorProvider.SetError(addCusEmailText, "Valid email is required.");
            }
            else
            {
                emailErrorProvider.SetError(addCusEmailText, string.Empty);
            }
            return isValid;
        }

        private bool ValidatePhoneNumber()
        {
            bool isValid = !string.IsNullOrWhiteSpace(CreateCusPhoneText.Text);
            if (!isValid)
            {
                phoneErrorProvider.SetError(CreateCusPhoneText, "Phone number is required.");
            }
            else
            {
                phoneErrorProvider.SetError(CreateCusPhoneText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateDOB()
        {
            bool isValid = createCusDateTime.Value < DateTime.Now;
            if (!isValid)
            {
                dobErrorProvider.SetError(createCusDateTime, "Date of birth must be in the past.");
            }
            else
            {
                dobErrorProvider.SetError(createCusDateTime, string.Empty);
            }
            return isValid;
        }

        private bool ValidateCity()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createCusCityText.Text);
            if (!isValid)
            {
                cityErrorProvider.SetError(createCusCityText, "City is required.");
            }
            else
            {
                cityErrorProvider.SetError(createCusCityText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateAddress()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createCusAddressText.Text);
            if (!isValid)
            {
                addressErrorProvider.SetError(createCusAddressText, "Address is required.");
            }
            else
            {
                addressErrorProvider.SetError(createCusAddressText, string.Empty);
            }
            return isValid;
        }

        private void createCusPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createCusNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateCustomerName();
        }

        private void addCusEmailText_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void CreateCusPhoneText_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber();
        }

        private void createCusDateTime_ValueChanged(object sender, EventArgs e)
        {
            ValidateDOB();
        }

        private void createCusCityText_TextChanged(object sender, EventArgs e)
        {
            ValidateCity();
        }

        private void createCusAddressText_TextChanged(object sender, EventArgs e)
        {
            ValidateAddress();
        }

        private void cusSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateCustomerName() & ValidateEmail() & ValidatePhoneNumber() & ValidateDOB() & ValidateCity() & ValidateAddress();
            if (isValid)
            {
                // Save the customer information
                // Add your customer registration code here
                MessageBox.Show("Customer registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
