using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class CreateUnits : Form
    {
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
            LoadBaseUnits();
        }

        private void LoadBaseUnits()
        {
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
            bool isValid = baseUnitComboBox.SelectedIndex > 0;
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
                try
                {
                    string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO units (unit_name, short_name, base_unit) " +
                                       "VALUES (@unitName, @shortName, @baseUnit)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@unitName", createUnitNameText.Text.Trim());
                            command.Parameters.AddWithValue("@shortName", shortUnitNameTextBox.Text.Trim());
                            command.Parameters.AddWithValue("@baseUnit", baseUnitComboBox.SelectedItem.ToString());
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Unit created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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