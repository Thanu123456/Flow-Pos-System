using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class CreateBaseUnit : Form
    {
        private bool isEditMode = false;
        private int editBaseUnitId = -1;

        // Error provider for validation
        private ErrorProvider baseUnitNameErrorProvider = new ErrorProvider();

        public CreateBaseUnit(int baseUnitId = -1, string name = "")
        {
            InitializeComponent();
            SetupErrorProvider();

            if (baseUnitId != -1)
            {
                isEditMode = true;
                editBaseUnitId = baseUnitId;
                this.Text = "Edit Base Unit";
                creCatSaveBtn.Text = "Update"; // Assuming creCatSaveBtn is the save button
            }

            // Pre-fill form fields
            createBaseUnitNameText.Text = name;
            UpdateSaveButtonState();

            // Enable key preview to capture keyboard events at the form level
            this.KeyPreview = true;
            this.KeyDown += CreateBaseUnit_KeyDown;
        }

        private void CreateBaseUnit_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Enter key to trigger Save button
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                creCatSaveBtn.PerformClick();
            }
            // Handle Escape key to trigger Cancel button
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                creCatCancelBtn.PerformClick();
            }
        }

        private void SetupErrorProvider()
        {
            baseUnitNameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateBaseUnit_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private bool ValidateBaseUnitName()
        {
            if (string.IsNullOrWhiteSpace(createBaseUnitNameText.Text))
            {
                baseUnitNameErrorProvider.SetError(createBaseUnitNameText, "Base unit name is required.");
                return false;
            }
            if (createBaseUnitNameText.Text.Length < 2)
            {
                baseUnitNameErrorProvider.SetError(createBaseUnitNameText, "Base unit name must be at least 2 characters.");
                return false;
            }
            baseUnitNameErrorProvider.SetError(createBaseUnitNameText, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            creCatSaveBtn.Enabled = ValidateBaseUnitName();
        }

        private void createBaseUnitNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateBaseUnitName();
            UpdateSaveButtonState();
        }

        private void creCatSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateBaseUnitName())
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        if (isEditMode)
                        {
                            string query = "UPDATE base_units SET name = @name WHERE id = @baseUnitId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", CapitalizeName(createBaseUnitNameText.Text.Trim()));
                                command.Parameters.AddWithValue("@baseUnitId", editBaseUnitId);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Base unit updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string query = "INSERT INTO base_units (name) VALUES (@name)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", CapitalizeName(createBaseUnitNameText.Text.Trim()));
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Base unit created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving base unit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Add this helper method to the CreateBaseUnit class
        private string CapitalizeName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return name;
            
            // Split the name by spaces
            string[] words = name.Split(' ');
            
            // Capitalize the first letter of each word
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + 
                              (words[i].Length > 1 ? words[i].Substring(1).ToLower() : "");
                }
            }
            
            // Join the words back together
            return string.Join(" ", words);
        }
    }
}