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
    public partial class CreateUnits : Form
    {
        // Error providers for validation
        private ErrorProvider unitNameErrorProvider = new ErrorProvider();
        private ErrorProvider shortNameErrorProvider = new ErrorProvider();
        private ErrorProvider baseUnitErrorProvider = new ErrorProvider();

        public CreateUnits()
        {
            InitializeComponent();
            SetupErrorProviders();
        }

        private void SetupErrorProviders()
        {
            unitNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            shortNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            baseUnitErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateUnits_Load(object sender, EventArgs e)
        {
            // Load base units into the combo box
            LoadBaseUnits();
        }

        private void LoadBaseUnits()
        {
            // Replace this with actual code to load base units from your data source
            List<string> baseUnits = new List<string> { "Select Base Unit", "Meter", "Kilogram", "Piece", "Liter" };
            baseUnitComboBox.DataSource = baseUnits;
        }

        private bool ValidateUnitName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(createUnitNameText.Text);
            if (!isValid)
            {
                unitNameErrorProvider.SetError(createUnitNameText, "Full unit name is required.");
            }
            else
            {
                unitNameErrorProvider.SetError(createUnitNameText, string.Empty);
            }
            return isValid;
        }

        private bool ValidateShortName()
        {
            bool isValid = !string.IsNullOrWhiteSpace(shortUnitNameTextBox.Text);
            if (!isValid)
            {
                shortNameErrorProvider.SetError(shortUnitNameTextBox, "Short name is required.");
            }
            else
            {
                shortNameErrorProvider.SetError(shortUnitNameTextBox, string.Empty);
            }
            return isValid;
        }

        private bool ValidateBaseUnit()
        {
            bool isValid = baseUnitComboBox.SelectedIndex > 0; // Assuming first item is a placeholder
            if (!isValid)
            {
                baseUnitErrorProvider.SetError(baseUnitComboBox, "Please select a base unit.");
            }
            else
            {
                baseUnitErrorProvider.SetError(baseUnitComboBox, string.Empty);
            }
            return isValid;
        }

        private void createUnitNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateUnitName();
        }

        private void shortUnitNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateShortName();
        }

        private void baseUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateBaseUnit();
        }

        private void creCatSaveBtn_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateUnitName() & ValidateShortName() & ValidateBaseUnit();
            if (isValid)
            {
                // Save the unit
                // Add your code to save the unit here
                MessageBox.Show("Unit created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creCatCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
