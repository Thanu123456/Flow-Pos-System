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
    public partial class AddAdjustments : Form
    {
        // Error providers for validation
        private ErrorProvider warehouseErrorProvider = new ErrorProvider();
        private ErrorProvider dateErrorProvider = new ErrorProvider();
        private ErrorProvider productErrorProvider = new ErrorProvider();

        public AddAdjustments()
        {
            InitializeComponent();
            SetupErrorProviders();
        }

        private void SetupErrorProviders()
        {
            warehouseErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            dateErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            productErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void AddAdjustments_Load(object sender, EventArgs e)
        {
            // Initialization code here
            // For example, populate warehouse combo box
        }

        private bool ValidateWarehouseSelection()
        {
            bool isValid = createAdjWareCombo.SelectedIndex > 0; // Assuming first item is placeholder
            if (!isValid)
            {
                warehouseErrorProvider.SetError(createAdjWareCombo, "Please select a warehouse.");
            }
            else
            {
                warehouseErrorProvider.SetError(createAdjWareCombo, string.Empty);
            }
            return isValid;
        }

        private bool ValidateAdjustmentDate()
        {
            bool isValid = createAdjDate.Value.Date <= DateTime.Now.Date;
            if (!isValid)
            {
                dateErrorProvider.SetError(createAdjDate, "Date cannot be in the future.");
            }
            else
            {
                dateErrorProvider.SetError(createAdjDate, string.Empty);
            }
            return isValid;
        }

        private bool ValidateProductSelection()
        {
            bool isValid = adjOrderDataGrid.Rows.Count > 0;
            if (!isValid)
            {
                productErrorProvider.SetError(adjOrderDataGrid, "Please add at least one product.");
            }
            else
            {
                productErrorProvider.SetError(adjOrderDataGrid, string.Empty);
            }
            return isValid;
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createAdjWareCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateWarehouseSelection();
        }

        private void createAdjDate_ValueChanged(object sender, EventArgs e)
        {
            ValidateAdjustmentDate();
        }

        private void adProductSearchText_TextChanged(object sender, EventArgs e)
        {
            // Code to search and filter products
        }

        private void adjOrderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Code to handle adding/removing products to adjustment list
            ValidateProductSelection();
        }

        private void adjSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateWarehouseSelection() & ValidateAdjustmentDate() & ValidateProductSelection();
            if (isValid)
            {
                // Save the adjustment
                // Add your code to save the adjustment details
                MessageBox.Show("Adjustment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void adjCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
