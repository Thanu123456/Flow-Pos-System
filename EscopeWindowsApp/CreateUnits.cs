using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class CreateUnits : Form
    {
        private bool isEditMode = false;
        private int editUnitId = -1;
        private int selectedBaseUnitId = 0; // New field to store base unit ID
        private ErrorProvider unitNameErrorProvider = new ErrorProvider();
        private ErrorProvider shortNameErrorProvider = new ErrorProvider();

        public CreateUnits(int unitId = -1, string unitName = "", string shortName = "", int baseUnitId = 0)
        {
            InitializeComponent();
            SetupErrorProviders();

            if (unitId != -1)
            {
                isEditMode = true;
                editUnitId = unitId;
                this.Text = "Edit Unit";
                creCatSaveBtn.Text = "Update";
            }

            createUnitNameText.Text = unitName;
            shortUnitNameTextBox.Text = shortName;
            selectedBaseUnitId = baseUnitId; // Store the baseUnitId

            // Remove LoadBaseUnits call here
            this.Load += CreateUnits_Load; // Add Load event handler
            UpdateSaveButtonState();
        }


        private void SetupErrorProviders()
        {
            unitNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            shortNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void LoadBaseUnits()
        {
            string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, name FROM base_units";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<KeyValuePair<int, string>> baseUnits = new List<KeyValuePair<int, string>>();
                            baseUnits.Add(new KeyValuePair<int, string>(0, "Select Base Unit"));
                            while (reader.Read())
                            {
                                baseUnits.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("name")));
                            }
                            baseUnitComboBox.DataSource = new BindingSource(baseUnits, null);
                            baseUnitComboBox.DisplayMember = "Value";
                            baseUnitComboBox.ValueMember = "Key";

                            // Set the selected value after data binding
                            if (selectedBaseUnitId != 0)
                            {
                                baseUnitComboBox.SelectedValue = selectedBaseUnitId;
                            }
                            else
                            {
                                baseUnitComboBox.SelectedIndex = 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading base units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateSaveButtonState()
        {
            creCatSaveBtn.Enabled = ValidateUnitName() && ValidateShortName();
        }

        private bool ValidateUnitName()
        {
            if (string.IsNullOrWhiteSpace(createUnitNameText.Text))
            {
                unitNameErrorProvider.SetError(createUnitNameText, "Full unit name is required.");
                return false;
            }
            if (createUnitNameText.Text.Length < 2)
            {
                unitNameErrorProvider.SetError(createUnitNameText, "Unit name must be at least 2 characters.");
                return false;
            }
            unitNameErrorProvider.SetError(createUnitNameText, "");
            return true;
        }

        private bool ValidateShortName()
        {
            if (string.IsNullOrWhiteSpace(shortUnitNameTextBox.Text))
            {
                shortNameErrorProvider.SetError(shortUnitNameTextBox, "Short name is required.");
                return false;
            }
            if (shortUnitNameTextBox.Text.Length < 1)
            {
                shortNameErrorProvider.SetError(shortUnitNameTextBox, "Short name must be at least 1 character.");
                return false;
            }
            shortNameErrorProvider.SetError(shortUnitNameTextBox, "");
            return true;
        }

        private void createUnitNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateUnitName();
            UpdateSaveButtonState();
        }

        private void shortUnitNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateShortName();
            UpdateSaveButtonState();
        }

        private void creCatSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateUnitName() && ValidateShortName())
            {
                try
                {
                    string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        int selectedBaseUnitId = (int)baseUnitComboBox.SelectedValue;
                        object baseUnitIdParam = selectedBaseUnitId == 0 ? DBNull.Value : (object)selectedBaseUnitId;

                        if (isEditMode)
                        {
                            string query = "UPDATE units SET unit_name = @unitName, short_name = @shortName, base_unit_id = @baseUnitId WHERE id = @unitId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@unitName", createUnitNameText.Text.Trim());
                                command.Parameters.AddWithValue("@shortName", shortUnitNameTextBox.Text.Trim());
                                command.Parameters.AddWithValue("@baseUnitId", baseUnitIdParam);
                                command.Parameters.AddWithValue("@unitId", editUnitId);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Unit updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("The unit no longer exists in the database and cannot be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.DialogResult = DialogResult.Cancel;
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            string query = "INSERT INTO units (unit_name, short_name, base_unit_id) VALUES (@unitName, @shortName, @baseUnitId)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@unitName", createUnitNameText.Text.Trim());
                                command.Parameters.AddWithValue("@shortName", shortUnitNameTextBox.Text.Trim());
                                command.Parameters.AddWithValue("@baseUnitId", baseUnitIdParam);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Unit created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // Duplicate entry error
                    {
                        MessageBox.Show("Unit name or short name already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Error saving unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return; // Keep form open on error
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CreateUnits_Load(object sender, EventArgs e)
        {
            LoadBaseUnits();
        }

        private void baseUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void creCatCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}