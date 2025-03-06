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
    public partial class AddSupplierForm : Form
    {
        // Error providers for validation
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider emailErrorProvider = new ErrorProvider();
        private ErrorProvider phoneErrorProvider = new ErrorProvider();
        private ErrorProvider cityErrorProvider = new ErrorProvider();
        private ErrorProvider addressErrorProvider = new ErrorProvider();
        private ErrorProvider itemErrorProvider = new ErrorProvider();

        public AddSupplierForm()
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
            cityErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            addressErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            itemErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void AddSupplierForm_Load(object sender, EventArgs e)
        {
            // Initialization code here
        }

        private bool ValidateSupplierName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createSupNameText.Text);
            if (!isValid)
            {
                nameErrorProvider.SetError(createSupNameText, "Supplier name is required.");
            }
            else
            {
                nameErrorProvider.SetError(createSupNameText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateEmail()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createSupEmailText.Text) && createSupEmailText.Text.Contains("@");
            if (!isValid)
            {
                emailErrorProvider.SetError(createSupEmailText, "Valid email is required.");
            }
            else
            {
                emailErrorProvider.SetError(createSupEmailText, string.Empty);
            }
            return isValid;
        }

        private bool ValidatePhoneNumber()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createSupPhoneText.Text);
            if (!isValid)
            {
                phoneErrorProvider.SetError(createSupPhoneText, "Phone number is required.");
            }
            else
            {
                phoneErrorProvider.SetError(createSupPhoneText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateCity()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createSupCityText.Text);
            if (!isValid)
            {
                cityErrorProvider.SetError(createSupCityText, "City is required.");
            }
            else
            {
                cityErrorProvider.SetError(createSupCityText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateAddress()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createSupAddressText.Text);
            if (!isValid)
            {
                addressErrorProvider.SetError(createSupAddressText, "Address is required.");
            }
            else
            {
                addressErrorProvider.SetError(createSupAddressText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateItem()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createSupItemText.Text);
            if (!isValid)
            {
                itemErrorProvider.SetError(createSupItemText, "Item is required.");
            }
            else
            {
                itemErrorProvider.SetError(createSupItemText, string.Empty);
            }
            return isValid;
        }

        private void createSupNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateSupplierName();
        }

        private void createSupEmailText_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void createSupPhoneText_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneNumber();
        }

        private void createSupCityText_TextChanged(object sender, EventArgs e)
        {
            ValidateCity();
        }

        private void createSupAddressText_TextChanged(object sender, EventArgs e)
        {
            ValidateAddress();
        }

        private void createSupItemText_TextChanged(object sender, EventArgs e)
        {
            ValidateItem();
        }

        private void supSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateSupplierName() & ValidateEmail() & ValidatePhoneNumber() & ValidateCity() & ValidateAddress() & ValidateItem();
            if (isValid)
            {
                // Save the supplier information
                // Add your supplier registration code here
                MessageBox.Show("Supplier registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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
