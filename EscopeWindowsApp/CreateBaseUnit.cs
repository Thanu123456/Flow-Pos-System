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
    public partial class CreateBaseUnit : Form
    {
        // Error provider for validation
        private ErrorProvider baseUnitNameErrorProvider = new ErrorProvider();

        public CreateBaseUnit()
        {
            InitializeComponent();
            SetupErrorProvider();
        }

        private void SetupErrorProvider()
        {
            // Set the blink style to never blink.
            baseUnitNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void createBaseUnitNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateBaseUnitName();
        }

        private bool ValidateBaseUnitName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createBaseUnitNameText.Text);
            if (!isValid)
            {
                baseUnitNameErrorProvider.SetError(createBaseUnitNameText, "Base unit name is required.");
            }
            else
            {
                baseUnitNameErrorProvider.SetError(createBaseUnitNameText, string.Empty);
            }
            return isValid;
        }

        private void creCatSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateBaseUnitName())
            {
                // Save the base unit
                // Add your code to save the base unit here
                MessageBox.Show("Base unit created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid base unit name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creCatCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBaseUnit_Load(object sender, EventArgs e)
        {
            // Initialization code here if needed
        }
    }
}
