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
    public partial class AddSaleForm : Form
    {
        // Error providers for validation
        private ErrorProvider customerNameErrorProvider = new ErrorProvider();
        private ErrorProvider dateErrorProvider = new ErrorProvider();
        private ErrorProvider warehouseErrorProvider = new ErrorProvider();
        private ErrorProvider productErrorProvider = new ErrorProvider();
        private ErrorProvider taxErrorProvider = new ErrorProvider();
        private ErrorProvider discountErrorProvider = new ErrorProvider();
        private ErrorProvider shippingErrorProvider = new ErrorProvider();
        private ErrorProvider saleStatusErrorProvider = new ErrorProvider();
        private ErrorProvider paymentStatusErrorProvider = new ErrorProvider();
        private ErrorProvider notesErrorProvider = new ErrorProvider();

        public AddSaleForm()
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
            shippingErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            saleStatusErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            paymentStatusErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            notesErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private bool ValidateCustomerName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createSaleText.Text);
            if (!isValid)
            {
                customerNameErrorProvider.SetError(createSaleText, "Customer name is required.");
            }
            else
            {
                customerNameErrorProvider.SetError(createSaleText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateDate()
        {
            bool isValid = createSaleDateTime.Value.Date <= DateTime.Now.Date;
            if (!isValid)
            {
                dateErrorProvider.SetError(createSaleDateTime, "Date cannot be in the future.");
            }
            else
            {
                dateErrorProvider.SetError(createSaleDateTime, string.Empty);
            }
            return isValid;
        }

        private bool ValidateWarehouseSelection()
        {
            bool isValid = createSaleWareCombo.SelectedIndex >= 0;
            if (!isValid)
            {
                warehouseErrorProvider.SetError(createSaleWareCombo, "Please select a warehouse.");
            }
            else
            {
                warehouseErrorProvider.SetError(createSaleWareCombo, string.Empty);
            }
            return isValid;
        }

        private bool ValidateProductSelection()
        {
            bool isValid = saleOrderDataGrid.Rows.Count > 0;
            if (!isValid)
            {
                productErrorProvider.SetError(saleOrderDataGrid, "Please add at least one product.");
            }
            else
            {
                productErrorProvider.SetError(saleOrderDataGrid, string.Empty);
            }
            return isValid;
        }

        private bool ValidateTax()
        {
            bool isValid = decimal.TryParse(createSaleOderTaxText.Text, out decimal tax) && tax >= 0;
            if (!isValid)
            {
                taxErrorProvider.SetError(createSaleOderTaxText, "Please enter a valid tax amount.");
            }
            else
            {
                taxErrorProvider.SetError(createSaleOderTaxText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateDiscount()
        {
            bool isValid = decimal.TryParse(createSaleDisText.Text, out decimal discount) && discount >= 0;
            if (!isValid)
            {
                discountErrorProvider.SetError(createSaleDisText, "Please enter a valid discount amount.");
            }
            else
            {
                discountErrorProvider.SetError(createSaleDisText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateShippingCharge()
        {
            bool isValid = decimal.TryParse(createSaleShipText.Text, out decimal shipping) && shipping >= 0;
            if (!isValid)
            {
                shippingErrorProvider.SetError(createSaleShipText, "Please enter a valid shipping charge.");
            }
            else
            {
                shippingErrorProvider.SetError(createSaleShipText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateSaleStatus()
        {
            bool isValid = createSaleStatusCombo.SelectedIndex >= 0;
            if (!isValid)
            {
                saleStatusErrorProvider.SetError(createSaleStatusCombo, "Please select a sale status.");
            }
            else
            {
                saleStatusErrorProvider.SetError(createSaleStatusCombo, string.Empty);
            }
            return isValid;
        }

        private bool ValidatePaymentStatus()
        {
            bool isValid = createSalePaySCombo.SelectedIndex >= 0;
            if (!isValid)
            {
                paymentStatusErrorProvider.SetError(createSalePaySCombo, "Please select a payment status.");
            }
            else
            {
                paymentStatusErrorProvider.SetError(createSalePaySCombo, string.Empty);
            }
            return isValid;
        }

        private void ValidateNotes()
        {
            bool isValid = createSaleNoteText.Text.Length <= 500;
            if (!isValid)
            {
                notesErrorProvider.SetError(createSaleNoteText, "Notes cannot exceed 500 characters.");
            }
            else
            {
                notesErrorProvider.SetError(createSaleNoteText, string.Empty);
            }
        }


        private void createSalePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddSaleForm_Load(object sender, EventArgs e)
        {

        }

        private void createSaleDateTime_ValueChanged(object sender, EventArgs e)
        {
            ValidateDate();
        }

        private void createSaleWareCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateWarehouseSelection();
        }

        private void createSaleText_TextChanged(object sender, EventArgs e)
        {
            ValidateCustomerName();
        }

        private void createSaleSearchText_TextChanged(object sender, EventArgs e)
        {
            // Implement product search logic here
            // For example, filter products based on search term
        }

        private void saleOrderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ValidateProductSelection();
        }

        private void createSaleOderTaxText_TextChanged(object sender, EventArgs e)
        {
            ValidateTax();
            UpdateTotalAmount();
        }

        private void createSaleDisText_TextChanged(object sender, EventArgs e)
        {
            ValidateDiscount();
            UpdateTotalAmount();
        }

        private void createSaleShipText_TextChanged(object sender, EventArgs e)
        {
            ValidateShippingCharge();
            UpdateTotalAmount();
        }

        private void createSaleStatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateSaleStatus();
        }

        private void createSalePaySCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidatePaymentStatus();
        }

        private void createSaleNoteText_TextChanged(object sender, EventArgs e)
        {
            ValidateNotes();
        }

        private void saleSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateCustomerName()
                & ValidateDate()
                & ValidateWarehouseSelection()
                & ValidateProductSelection()
                & ValidateTax()
                & ValidateDiscount()
                & ValidateShippingCharge()
                & ValidateSaleStatus()
                & ValidatePaymentStatus();

            if (isValid)
            {
                // Save the sale
                // Add your code to save the sale details here
                MessageBox.Show("Sale saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saleCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTotalAmount()
        {
            decimal subtotal = CalculateSubtotal();
            decimal tax = decimal.TryParse(createSaleOderTaxText.Text, out decimal taxValue) ? taxValue : 0;
            decimal discount = decimal.TryParse(createSaleDisText.Text, out decimal discountValue) ? discountValue : 0;
            decimal shipping = decimal.TryParse(createSaleShipText.Text, out decimal shippingValue) ? shippingValue : 0;

            decimal total = subtotal + tax + shipping - discount;

            // Display the total amount
            // Assume you have a label or textbox to show the total
            totalAmountLabel.Text = total.ToString("C");
        }

        private decimal CalculateSubtotal()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in saleOrderDataGrid.Rows)
            {
                if (row.Cells["PriceColumn"].Value != null && decimal.TryParse(row.Cells["PriceColumn"].Value.ToString(), out decimal price))
                {
                    subtotal += price;
                }
            }
            return subtotal;
        }
    }
}
