using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class ExpensesCreateCategory : Form
    {
        private bool isEditMode = false;
        private int editCategoryId = -1;
        private ErrorProvider nameErrorProvider = new ErrorProvider();

        public ExpensesCreateCategory(int categoryId = -1, string name = "")
        {
            InitializeComponent();
            SetupErrorProviders();

            if (categoryId != -1)
            {
                isEditMode = true;
                editCategoryId = categoryId;
                this.Text = "Edit Expense Category";
                creExpSaveBtn.Text = "Update";
            }

            createExpNameText.Text = name;
            UpdateSaveButtonState();

            // Enable key preview to capture keyboard events at the form level
            this.KeyPreview = true;
            this.KeyDown += ExpensesCreateCategory_KeyDown;
        }

        private void ExpensesCreateCategory_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Enter key to trigger Save button
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                creExpSaveBtn.PerformClick();
            }
            // Handle Escape key to trigger Cancel button
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent beep sound
                creExpCancelBtn.PerformClick();
            }
        }

        private void SetupErrorProviders()
        {
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void ExpensesCreateCategory_Load(object sender, EventArgs e)
        {
            UpdateSaveButtonState();
        }

        private bool ValidateCategoryName()
        {
            if (string.IsNullOrWhiteSpace(createExpNameText.Text))
            {
                nameErrorProvider.SetError(createExpNameText, "Category name is required.");
                return false;
            }
            if (createExpNameText.Text.Length < 2)
            {
                nameErrorProvider.SetError(createExpNameText, "Category name must be at least 2 characters.");
                return false;
            }
            nameErrorProvider.SetError(createExpNameText, string.Empty);
            return true;
        }

        private void UpdateSaveButtonState()
        {
            creExpSaveBtn.Enabled = ValidateCategoryName();
        }

        private void createExpNameText_TextChanged(object sender, EventArgs e)
        {
            ValidateCategoryName();
            UpdateSaveButtonState();
        }

        private void creExpSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateCategoryName())
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        if (isEditMode)
                        {
                            string query = "UPDATE expenses_categories SET name = @name WHERE id = @categoryId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createExpNameText.Text.Trim());
                                command.Parameters.AddWithValue("@categoryId", editCategoryId);
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected == 0)
                                {
                                    throw new Exception($"No expense category found with ID {editCategoryId} to update.");
                                }
                            }
                            MessageBox.Show("Expense category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string query = "INSERT INTO expenses_categories (name) VALUES (@name)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@name", createExpNameText.Text.Trim());
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Expense category created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    this.Close();
                }
                catch (MySqlException myEx)
                {
                    MessageBox.Show($"Database error: {myEx.Message}\nError Code: {myEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving expense category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creExpCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}