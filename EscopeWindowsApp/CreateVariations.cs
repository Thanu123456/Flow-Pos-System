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
    public partial class CreateVariations : Form
    {
        private List<string> variationTypes;
        private List<string> variations;

        public CreateVariations()
        {
            InitializeComponent();
            variationTypes = new List<string>();
            variations = new List<string>();
        }

        private void CreateVariations_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
            // For example, populate controls or set default values
        }

        private void addVarTypeBtn_Click(object sender, EventArgs e)
        {
            // Add a new variation type button
            string varType = varTypeTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(varType))
            {
                if (!variationTypes.Contains(varType))
                {
                    variationTypes.Add(varType);
                    // Update UI elements if necessary
                    MessageBox.Show("Variation type added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    varTypeTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("This variation type already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a variation type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void varTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            // Add a new variation type / not empty (ex: size, 35,36,37)
            // Validation can be added here if needed
        }

        private void createVarNameText_TextChanged(object sender, EventArgs e)
        {
            // Create a new variation / not empty (ex: Pieces, colores, Gram)
            // Validation can be added here if needed
        }

        private void creCatSaveBtn_Click(object sender, EventArgs e)
        {
            // Save the new variation
            string varName = createVarNameText.Text.Trim();

            if (!string.IsNullOrEmpty(varName))
            {
                if (!variations.Contains(varName))
                {
                    variations.Add(varName);
                    // Code to save the variation, e.g., to a database
                    MessageBox.Show("Variation saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    createVarNameText.Clear();
                }
                else
                {
                    MessageBox.Show("This variation already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a variation name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creCatCancelBtn_Click(object sender, EventArgs e)
        {
            // Cancel the new variation
            this.Close();
        }
    }
}
