using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class AddVariationItem : Form
    {
        private bool isEditMode = false;
        private int editVariationId = -1;

        // Error providers for validation
        private ErrorProvider nameErrorProvider = new ErrorProvider();
        private ErrorProvider typeErrorProvider = new ErrorProvider();

        public AddVariationItem(int variationId = -1, string name = "", string type1 = "", string type2 = "", string type3 = "", string type4 = "", string type5 = "")
        {
            InitializeComponent();
            SetupErrorProviders();

            if (variationId != -1)
            {
                isEditMode = true;
                editVariationId = variationId;
                this.Text = "Edit Variation";
                creVarSaveBtn.Text = "Update";
            }

            // Pre-fill form fields
            createVarNameText.Text = name;
            addVarTypeTextBox.Text = type1;
            addVarTypeTextBox2.Text = type2;
            addVarTypeTextBox3.Text = type3;
            addVarTypeTextBox4.Text = type4;
            addVarTypeTextBox5.Text = type5;

            UpdateSaveButtonState();

            // Enable key preview to capture keyboard events at the form level
            this.KeyPreview = true;
            this.KeyDown += AddVariationItem_KeyDown;
        }

        private void AddVariationItem_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Enter key to trigger Save button
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                creVarSaveBtn.PerformClick();
            }
            // Handle Escape key to trigger Cancel button
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                CreVarCancelBtn.PerformClick();
            }
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            typeErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void AddVariationItem_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private bool ValidateVariationName()
        {
            if (string.IsNullOrWhiteSpace(createVarNameText.Text))
            {
                nameErrorProvider.SetError(createVarNameText, "Variation name is required.");
                return false;
            }
            if (createVarNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(createVarNameText, "Variation name must be at least 2 characters.");
                return false;
            }
            nameErrorProvider.SetError(createVarNameText, string.Empty);
            return true;
        }

        private bool ValidateVariationTypes()
        {
            // Check if at least one type is filled
            bool hasOneType = !string.IsNullOrWhiteSpace(addVarTypeTextBox.Text) ||
                             !string.IsNullOrWhiteSpace(addVarTypeTextBox2.Text) ||
                             !string.IsNullOrWhiteSpace(addVarTypeTextBox3.Text) ||
                             !string.IsNullOrWhiteSpace(addVarTypeTextBox4.Text) ||
                             !string.IsNullOrWhiteSpace(addVarTypeTextBox5.Text);

            if (!hasOneType)
            {
                typeErrorProvider.SetError(addVarTypeTextBox, "At least one variation type is required.");
                return false;
            }
            typeErrorProvider.SetError(addVarTypeTextBox, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            creVarSaveBtn.Enabled = ValidateVariationName() && ValidateVariationTypes();
        }

        private void createVarNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateVariationName();
            UpdateSaveButtonState();
        }

        private void addVarTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateVariationTypes();
            UpdateSaveButtonState();
        }

        private void addVarTypeTextBox2_TextChanged(object sender, EventArgs e)
        {
            ValidateVariationTypes();
            UpdateSaveButtonState();
        }

        private void addVarTypeTextBox3_TextChanged(object sender, EventArgs e)
        {
            ValidateVariationTypes();
            UpdateSaveButtonState();
        }

        private void addVarTypeTextBox4_TextChanged(object sender, EventArgs e)
        {
            ValidateVariationTypes();
            UpdateSaveButtonState();
        }

        private void addVarTypeTextBox5_TextChanged(object sender, EventArgs e)
        {
            ValidateVariationTypes();
            UpdateSaveButtonState();
        }

        private void creVarSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateVariationName() && ValidateVariationTypes())
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        if (isEditMode)
                        {
                            string query = "UPDATE variations SET name = @name, type1 = @type1, type2 = @type2, type3 = @type3, type4 = @type4, type5 = @type5 WHERE id = @variationId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", CapitalizeName(createVarNameText.Text.Trim()));
                                command.Parameters.AddWithValue("@type1", addVarTypeTextBox.Text.Trim() ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@type2", addVarTypeTextBox2.Text.Trim() ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@type3", addVarTypeTextBox3.Text.Trim() ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@type4", addVarTypeTextBox4.Text.Trim() ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@type5", addVarTypeTextBox5.Text.Trim() ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@variationId", editVariationId);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Variation updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string query = "INSERT INTO variations (name, type1, type2, type3, type4, type5) VALUES (@name, @type1, @type2, @type3, @type4, @type5)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", CapitalizeName(createVarNameText.Text.Trim()));
                                command.Parameters.AddWithValue("@type1", addVarTypeTextBox.Text.Trim() ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@type2", addVarTypeTextBox2.Text.Trim() ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@type3", addVarTypeTextBox3.Text.Trim() ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@type4", addVarTypeTextBox4.Text.Trim() ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@type5", addVarTypeTextBox5.Text.Trim() ?? (object)DBNull.Value);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Variation created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving variation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreVarCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add this helper method to the AddVariationItem class
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