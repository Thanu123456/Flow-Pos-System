using System;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class POSWeightForm : Form
    {
        private string unitName;
        private decimal stock; // Available stock for the product
        private string productName; // Product name for the warning message
        private string variationType; // Variation type for the warning message

        public POSWeightForm(string unit, decimal stock, string productName, string variationType)
        {
            InitializeComponent();
            unitName = unit;
            this.stock = stock;
            this.productName = productName;
            this.variationType = variationType;
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            switch (unitName.ToLower())
            {
                case "kilogram": // Corrected from "killogram"
                    kilogramLabel.Text = "Kilogram";
                    kilogramNameLabel.Text = "Kilogram:"; // Update label next to kilogramText
                    gramLabel.Text = "Gram";
                    unitShortName.Text = "Kg";
                    unitsCal.Text = "Kilogram"; // Update unitsCal label
                    break;
                case "liter":
                    kilogramLabel.Text = "Liter";
                    kilogramNameLabel.Text = "Liter:"; // Update label next to kilogramText
                    gramLabel.Text = "Milliliter";
                    unitShortName.Text = "L";
                    unitsCal.Text = "Liter"; // Update unitsCal label
                    break;
                case "meter":
                    kilogramLabel.Text = "Meter";
                    kilogramNameLabel.Text = "Meter:"; // Update label next to kilogramText
                    gramLabel.Text = "Centimeter";
                    unitShortName.Text = "m";
                    unitsCal.Text = "Meter"; // Update unitsCal label
                    break;
                default:
                    kilogramLabel.Text = unitName;
                    kilogramNameLabel.Text = unitName + ":";
                    gramLabel.Text = "";
                    unitShortName.Text = "";
                    unitsCal.Text = unitName;
                    break;
            }
        }

        private void kilogramText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kilogramText.Text))
            {
                gramText.Enabled = false;
            }
            else
            {
                gramText.Enabled = true;
            }
            CalculateQuantity();
        }

        private void gramText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gramText.Text))
            {
                kilogramText.Enabled = false;
            }
            else
            {
                kilogramText.Enabled = true;
            }
            CalculateQuantity();
        }

        private void CalculateQuantity()
        {
            decimal quantity = 0m;

            if (!string.IsNullOrEmpty(kilogramText.Text))
            {
                if (decimal.TryParse(kilogramText.Text, out decimal mainValue) && mainValue >= 0)
                {
                    quantity = mainValue;
                }
                else
                {
                    quantity = 0m;
                }
            }
            else if (!string.IsNullOrEmpty(gramText.Text))
            {
                if (decimal.TryParse(gramText.Text, out decimal subValue) && subValue >= 0)
                {
                    switch (unitName.ToLower())
                    {
                        case "kilogram":
                            quantity = subValue / 1000m; // Grams to Kilograms
                            break;
                        case "liter":
                            quantity = subValue / 1000m; // Milliliters to Liters
                            break;
                        case "meter":
                            quantity = subValue / 100m; // Centimeters to Meters
                            break;
                    }
                }
                else
                {
                    quantity = 0m;
                }
            }

            // Update calculateNum label with a cleaner format: "0.30 Kg"
            calculateNum.Text = $"{quantity.ToString("N2")} {unitShortName.Text}";

            // Optional: Change color to indicate if quantity exceeds stock
            if (quantity > stock)
            {
                calculateNum.ForeColor = Color.Red; // Indicate excess quantity
            }
            else
            {
                calculateNum.ForeColor = Color.Black; // Normal color
            }
        }

        public decimal GetQuantity()
        {
            // Since calculateNum.Text is now in the format "0.30 Kg", split by space and parse the first part
            if (decimal.TryParse(calculateNum.Text.Split(' ')[0], out decimal quantity))
            {
                return quantity;
            }
            return 0m; // Fallback in case parsing fails
        }

        private void kiloSaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kilogramText.Text) && string.IsNullOrEmpty(gramText.Text))
            {
                MessageBox.Show("Please enter a value.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal quantity = GetQuantity();
            if (quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than 0.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the entered quantity exceeds available stock
            if (quantity > stock)
            {
                MessageBox.Show($"Cannot add more {productName} ({variationType}). Only {stock} in stock.",
                    "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void kiloCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Event handlers
        private void kilogramLabel_Click(object sender, EventArgs e) { }

        private void POSWeightForm_Load(object sender, EventArgs e) { }

        private void kilogramNameLabel_Click(object sender, EventArgs e)
        {
            // Update the label to display the unit name (e.g., "Kilogram:", "Liter:", "Meter:")
            switch (unitName.ToLower())
            {
                case "kilogram": // Corrected from "killogram"
                    kilogramNameLabel.Text = "Kilogram:";
                    break;
                case "liter":
                    kilogramNameLabel.Text = "Liter:";
                    break;
                case "meter":
                    kilogramNameLabel.Text = "Meter:";
                    break;
                default:
                    kilogramNameLabel.Text = unitName + ":";
                    break;
            }
        }

        private void gramLabel_Click(object sender, EventArgs e) { }

        private void unitsCal_Click(object sender, EventArgs e)
        {
            // Update the label to display the unit name (e.g., "Kilogram", "Liter", "Meter")
            switch (unitName.ToLower())
            {
                case "kilogram": // Corrected from "killogram"
                    unitsCal.Text = "Kilogram";
                    break;
                case "liter":
                    unitsCal.Text = "Liter";
                    break;
                case "meter":
                    unitsCal.Text = "Meter";
                    break;
                default:
                    unitsCal.Text = unitName;
                    break;
            }
        }

        private void calculateNum_Click(object sender, EventArgs e) { }

        private void unitShortName_Click(object sender, EventArgs e) { }
    }
}