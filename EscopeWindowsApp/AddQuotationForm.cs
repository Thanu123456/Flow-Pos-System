using Siticone.Desktop.UI.WinForms;
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
    public partial class AddQuotationForm : Form
    {
        // Error providers for validation
        private ErrorProvider customerNameErrorProvider = new ErrorProvider();
        private ErrorProvider dateErrorProvider = new ErrorProvider();
        private ErrorProvider warehouseErrorProvider = new ErrorProvider();
        private ErrorProvider productErrorProvider = new ErrorProvider();
        private ErrorProvider taxErrorProvider = new ErrorProvider();
        private ErrorProvider discountErrorProvider = new ErrorProvider();
        private ErrorProvider statusErrorProvider = new ErrorProvider();
        private ErrorProvider notesErrorProvider = new ErrorProvider();
        private ErrorProvider searchTextErrorProvider = new ErrorProvider();


        public AddQuotationForm()
        {
            InitializeComponent();
            SetupErrorProviders();
        }

        private void SetupErrorProviders()
        {
            // Set the blink style to never blink.
            customerNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dateErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            warehouseErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            productErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            taxErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            discountErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            statusErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            notesErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            
        }

        private bool ValidateCustomerName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createQuoText.Text);
            if (!isValid)
            {
                customerNameErrorProvider.SetError(createQuoText, "Customer name is required.");
            }
            else
            {
                customerNameErrorProvider.SetError(createQuoText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateDate()
        {
            bool isValid = createQuotaDateTime.Value.Date <= DateTime.Now.Date;
            if (!isValid)
            {
                dateErrorProvider.SetError(createQuotaDateTime, "Date cannot be in the future.");
            }
            else
            {
                dateErrorProvider.SetError(createQuotaDateTime, string.Empty);
            }
            return isValid;
        }

        private bool ValidateWarehouseSelection()
        {
            bool isValid = createQuoWareCombo.SelectedIndex > 0; // Assuming the first item is a placeholder
            if (!isValid)
            {
                warehouseErrorProvider.SetError(createQuoWareCombo, "Please select a warehouse.");
            }
            else
            {
                warehouseErrorProvider.SetError(createQuoWareCombo, string.Empty);
            }
            return isValid;
        }

        private bool ValidateProductSelection()
        {
            bool isValid = quotaOrderDataGrid.Rows.Count > 0;
            if (!isValid)
            {
                productErrorProvider.SetError(quotaOrderDataGrid, "Please add at least one product.");
            }
            else
            {
                productErrorProvider.SetError(quotaOrderDataGrid, string.Empty);
            }
            return isValid;
        }

        private bool ValidateTax()
        {
            bool isValid = decimal.TryParse(createQuoOderTaxText.Text, out decimal tax) && tax >= 0;
            if (!isValid)
            {
                taxErrorProvider.SetError(createQuoOderTaxText, "Please enter a valid tax amount.");
            }
            else
            {
                taxErrorProvider.SetError(createQuoOderTaxText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateDiscount()
        {
            bool isValid = decimal.TryParse(createQuotaDisText.Text, out decimal discount) && discount >= 0;
            if (!isValid)
            {
                discountErrorProvider.SetError(createQuotaDisText, "Please enter a valid discount amount.");
            }
            else
            {
                discountErrorProvider.SetError(createQuotaDisText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateStatus()
        {
            bool isValid = createQuotaStatusCombo.SelectedIndex > 0; // Assuming the first item is a placeholder
            if (!isValid)
            {
                statusErrorProvider.SetError(createQuotaStatusCombo, "Please select a status.");
            }
            else
            {
                statusErrorProvider.SetError(createQuotaStatusCombo, string.Empty);
            }
            return isValid;
        }

        private void ValidateNotes()
        {
            // Example validation: notes should not exceed 500 characters
            bool isValid = createQuotaNoteText.Text.Length <= 500;
            if (!isValid)
            {
                // Ensure you have an ErrorProvider for notes
                notesErrorProvider.SetError(createQuotaNoteText, "Notes cannot exceed 500 characters.");
            }
            else
            {
                notesErrorProvider.SetError(createQuotaNoteText, string.Empty);
            }
        }

        private void ValidateProductSearch()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createQuoSearchText.Text);
            if (!isValid)
            {
                searchTextErrorProvider.SetError(createQuoSearchText, "Please enter a search term.");
            }
            else
            {
                searchTextErrorProvider.SetError(createQuoSearchText, string.Empty);
            }
        }

        private void siticoneTextBox4_TextChanged(object sender, EventArgs e)
        {
            // Validate product shipping (This is shipping charge)
        }

        private void createQuotaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createQuotaDateTime_ValueChanged(object sender, EventArgs e)
        {
            ValidateDate();
        }

        private void createQuoWareCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateWarehouseSelection();
        }

        private void createQuoText_TextChanged(object sender, EventArgs e)
        {
            ValidateCustomerName();
        }

        private void createQuoSearchText_TextChanged(object sender, EventArgs e)
        {
            ValidateProductSearch();
        }

        private void createQuoOderTaxText_TextChanged(object sender, EventArgs e)
        {
            ValidateTax();
        }

        private void createQuotaDisText_TextChanged(object sender, EventArgs e)
        {
            ValidateDiscount();
        }

        private void createQuotaStatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateStatus();
        }

        private void createQuotaNoteText_TextChanged(object sender, EventArgs e)
        {
            ValidateNotes();
        }

        private void quotaSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateCustomerName()
                & ValidateDate()
                & ValidateWarehouseSelection()
                & ValidateProductSelection()
                & ValidateTax()
                & ValidateDiscount()
                & ValidateStatus();

            if (isValid)
            {
                // Save the quotation
                // Add your code to save the quotation details here
                MessageBox.Show("Quotation saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void quotaCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddQuotationForm_Load(object sender, EventArgs e)
        {

        }

        private void quotaOrderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle adding/removing products to/from the quotation
            ValidateProductSelection();
        }
    }
}
