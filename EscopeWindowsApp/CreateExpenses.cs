using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class CreateExpenses : Form
    {
        private bool isEditMode = false;
        private int editExpenseId = -1;
        private int initialWarehouseId;  // Store initial values for edit mode
        private int initialCategoryId;
        private ErrorProvider titleErrorProvider = new ErrorProvider();
        private ErrorProvider amountErrorProvider = new ErrorProvider();

        public CreateExpenses(int expenseId = -1, DateTime? expenseDate = null, string title = "",
            int warehouseId = 0, int categoryId = 0, decimal amount = 0, string details = "")
        {
            InitializeComponent();
            SetupErrorProviders();

            if (expenseId != -1)
            {
                isEditMode = true;
                editExpenseId = expenseId;
                this.Text = "Edit Expense";
                creExpSaveBtn.Text = "Update";
            }

            creExpDateTimePicker.Value = expenseDate ?? DateTime.Now;
            creExpTitleText.Text = title;
            creExpAmountText.Text = amount.ToString();
            creExpDetailsext.Text = details;
            initialWarehouseId = warehouseId;  // Store these for use after loading
            initialCategoryId = categoryId;

            this.Load += CreateExpenses_Load;
            UpdateSaveButtonState();
        }

        private void SetupErrorProviders()
        {
            titleErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            amountErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void CreateExpenses_Load(object sender, EventArgs e)
        {
            LoadWarehouses();
            LoadCategories();

            // Set the selected values for edit mode after data is loaded
            if (isEditMode)
            {
                creExpWarehouseComboBox.SelectedValue = initialWarehouseId;
                creExpCatComboBox.SelectedValue = initialCategoryId;
            }
        }

        private void LoadWarehouses()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, name FROM warehouses";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<KeyValuePair<int, string>> warehouses = new List<KeyValuePair<int, string>>();
                            warehouses.Add(new KeyValuePair<int, string>(0, "Select Warehouse"));
                            while (reader.Read())
                            {
                                warehouses.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("name")));
                            }
                            creExpWarehouseComboBox.DataSource = new BindingSource(warehouses, null);
                            creExpWarehouseComboBox.DisplayMember = "Value";
                            creExpWarehouseComboBox.ValueMember = "Key";
                            // Don't set SelectedIndex here; let edit mode handle it
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading warehouses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCategories()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, name FROM expenses_categories";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<KeyValuePair<int, string>> categories = new List<KeyValuePair<int, string>>();
                            categories.Add(new KeyValuePair<int, string>(0, "Select Category"));
                            while (reader.Read())
                            {
                                categories.Add(new KeyValuePair<int, string>(reader.GetInt32("id"), reader.GetString("name")));
                            }
                            creExpCatComboBox.DataSource = new BindingSource(categories, null);
                            creExpCatComboBox.DisplayMember = "Value";
                            creExpCatComboBox.ValueMember = "Key";
                            // Don't set SelectedIndex here; let edit mode handle it
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateSaveButtonState()
        {
            creExpSaveBtn.Enabled = ValidateTitle() && ValidateAmount();
        }

        private bool ValidateTitle()
        {
            if (string.IsNullOrWhiteSpace(creExpTitleText.Text))
            {
                titleErrorProvider.SetError(creExpTitleText, "Expense title is required.");
                return false;
            }
            if (creExpTitleText.Text.Length < 2)
            {
                titleErrorProvider.SetError(creExpTitleText, "Title must be at least 2 characters.");
                return false;
            }
            titleErrorProvider.SetError(creExpTitleText, "");
            return true;
        }

        private bool ValidateAmount()
        {
            if (string.IsNullOrWhiteSpace(creExpAmountText.Text) || !decimal.TryParse(creExpAmountText.Text, out decimal amount) || amount <= 0)
            {
                amountErrorProvider.SetError(creExpAmountText, "Valid amount greater than 0 is required.");
                return false;
            }
            amountErrorProvider.SetError(creExpAmountText, "");
            return true;
        }

        private void creExpTitleText_TextChanged(object sender, EventArgs e)
        {
            ValidateTitle();
            UpdateSaveButtonState();
        }

        private void creExpAmountText_TextChanged(object sender, EventArgs e)
        {
            ValidateAmount();
            UpdateSaveButtonState();
        }

        private void creExpSaveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateTitle() && ValidateAmount())
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        int warehouseId = (int)creExpWarehouseComboBox.SelectedValue;
                        int categoryId = (int)creExpCatComboBox.SelectedValue;
                        decimal amount = decimal.Parse(creExpAmountText.Text);

                        if (isEditMode)
                        {
                            string query = @"UPDATE expenses SET expense_date = @date, title = @title, 
                                          warehouse_id = @warehouseId, category_id = @categoryId, 
                                          amount = @amount, details = @details WHERE id = @expenseId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@date", creExpDateTimePicker.Value);
                                command.Parameters.AddWithValue("@title", creExpTitleText.Text.Trim());
                                command.Parameters.AddWithValue("@warehouseId", warehouseId == 0 ? DBNull.Value : (object)warehouseId);
                                command.Parameters.AddWithValue("@categoryId", categoryId == 0 ? DBNull.Value : (object)categoryId);
                                command.Parameters.AddWithValue("@amount", amount);
                                command.Parameters.AddWithValue("@details", creExpDetailsext.Text.Trim());
                                command.Parameters.AddWithValue("@expenseId", editExpenseId);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Expense updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("The expense no longer exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.DialogResult = DialogResult.Cancel;
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            string query = @"INSERT INTO expenses (expense_date, title, warehouse_id, 
                                          category_id, amount, details) 
                                          VALUES (@date, @title, @warehouseId, @categoryId, @amount, @details)";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@date", creExpDateTimePicker.Value);
                                command.Parameters.AddWithValue("@title", creExpTitleText.Text.Trim());
                                command.Parameters.AddWithValue("@warehouseId", warehouseId == 0 ? DBNull.Value : (object)warehouseId);
                                command.Parameters.AddWithValue("@categoryId", categoryId == 0 ? DBNull.Value : (object)categoryId);
                                command.Parameters.AddWithValue("@amount", amount);
                                command.Parameters.AddWithValue("@details", creExpDetailsext.Text.Trim());

                                command.ExecuteNonQuery();
                                MessageBox.Show("Expense created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error saving expense: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void creExpCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void creExpDetailsext_TextChanged(object sender, EventArgs e)
        {
            // this is the details of the expense
        }

        private void creExpWarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this is the warehouse where the expense is being made
        }

        private void creExpCatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this is the category of the expense
        }

        private void creExpDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // choose date for expense
        }
    }
}