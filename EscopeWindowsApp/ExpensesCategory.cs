using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class ExpensesCategory : Form
    {
        private DataTable categoriesTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public ExpensesCategory()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            expCatDataGridView.CellPainting += ExpCatDataGridView_CellPainting;
            expCatDataGridView.CellFormatting += ExpCatDataGridView_CellFormatting;
            expCatDataGridView.CellContentClick += expCatDataGridView_CellContentClick;
        }

        private void ExpensesCategory_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            expCatDataGridView.DataSource = bindingSource;
            LoadCategoriesData();

            if (categoriesTable.Rows.Count == 0)
            {
                MessageBox.Show("No expense category data found.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfigureDataGridView()
        {
            expCatDataGridView.AutoGenerateColumns = false;
            expCatDataGridView.Columns.Clear();

            expCatDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "CATEGORY ID"
            });
            expCatDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "NAME"
            });
            expCatDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "EDIT",
                Width = 50,
                ToolTipText = "Edit this category"
            });
            expCatDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this category"
            });

            expCatDataGridView.AllowUserToAddRows = false;
        }

        private void ExpCatDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (expCatDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                int categoryId = Convert.ToInt32(e.Value);
                e.Value = $"exp{categoryId:D3}";
                e.FormattingApplied = true;
            }
        }

        private void ExpCatDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (expCatDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                    {
                        e.PaintBackground(e.CellBounds, true);
                        Image editIcon = Properties.Resources.edit ?? SystemIcons.Question.ToBitmap();
                        int iconSize = (int)(Math.Min(e.CellBounds.Width, e.CellBounds.Height) * 0.7);
                        if (iconSize <= 0) iconSize = 16;
                        int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(editIcon, x, y, iconSize, iconSize);
                        e.Handled = true;
                    }
                    if (expCatDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                    {
                        e.PaintBackground(e.CellBounds, true);
                        Image deleteIcon = Properties.Resources.delete ?? SystemIcons.Warning.ToBitmap();
                        int iconSize = (int)(Math.Min(e.CellBounds.Width, e.CellBounds.Height) * 0.7);
                        if (iconSize <= 0) iconSize = 16;
                        int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(deleteIcon, x, y, iconSize, iconSize);
                        e.Handled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error rendering icons: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCategoriesData()
        {
            try
            {
                categoriesTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name FROM expenses_categories ORDER BY id ASC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(categoriesTable);
                    }
                }

                foreach (DataRow row in categoriesTable.Rows)
                {
                    if (row.IsNull("name"))
                    {
                        row["name"] = "";
                    }
                }

                bindingSource.DataSource = categoriesTable;

                // Adjust currentIndex after loading data
                if (expCatDataGridView.Rows.Count > 0)
                {
                    currentIndex = Math.Min(currentIndex, expCatDataGridView.Rows.Count - 1);
                    expCatDataGridView.CurrentCell = expCatDataGridView.Rows[currentIndex].Cells[0];
                }
                else
                {
                    currentIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expense categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                categoriesTable = new DataTable();
                categoriesTable.Columns.Add("id", typeof(int));
                categoriesTable.Columns.Add("name", typeof(string));
                categoriesTable.Rows.Add(1, "Test Expense Category 1");
                categoriesTable.Rows.Add(2, "Test Expense Category 2");
                bindingSource.DataSource = categoriesTable;
                currentIndex = 0;
            }
        }

        private void createExpCatBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is ExpensesCreateCategory)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            ExpensesCreateCategory createForm = new ExpensesCreateCategory();
            createForm.FormClosed += (s, args) => LoadCategoriesData();
            createForm.Show();
        }

        private void expCatSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = expCatSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"name LIKE '%{searchText}%'";
                }
                else
                {
                    bindingSource.Filter = null;
                }

                // Adjust currentIndex after filtering
                if (expCatDataGridView.Rows.Count > 0)
                {
                    currentIndex = Math.Min(currentIndex, expCatDataGridView.Rows.Count - 1);
                    expCatDataGridView.CurrentCell = expCatDataGridView.Rows[currentIndex].Cells[0];
                }
                else
                {
                    currentIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying search filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
                currentIndex = 0;
            }
        }

        private void expCatRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadCategoriesData();
            expCatSearchText.Text = string.Empty;
            bindingSource.Filter = null;
        }

        private void expCatDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on headers or invalid indices
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Check if the row index is still valid after any UI updates
            if (e.RowIndex >= expCatDataGridView.Rows.Count)
            {
                return; // Exit if the index is out of range, likely due to a refresh after deletion
            }

            // Get the row and column clicked
            DataGridViewRow row = expCatDataGridView.Rows[e.RowIndex];
            string columnName = expCatDataGridView.Columns[e.ColumnIndex].Name;

            // Handle Edit button click
            if (columnName == "EditColumn")
            {
                try
                {
                    int categoryId = Convert.ToInt32(row.Cells["id"].Value);
                    string name = row.Cells["name"].Value.ToString();

                    // Check if the edit form is already open for this category
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is ExpensesCreateCategory editForm && editForm.Tag?.ToString() == categoryId.ToString())
                        {
                            if (form.WindowState == FormWindowState.Minimized)
                            {
                                form.WindowState = FormWindowState.Normal;
                            }
                            form.BringToFront();
                            form.Activate();
                            return;
                        }
                    }

                    // Open a new edit form
                    ExpensesCreateCategory editFormNew = new ExpensesCreateCategory(categoryId, name);
                    editFormNew.Tag = categoryId;
                    editFormNew.FormClosed += (s, args) => LoadCategoriesData();
                    editFormNew.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening edit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Handle Delete button click
            else if (columnName == "DeleteColumn")
            {
                int categoryId = Convert.ToInt32(row.Cells["id"].Value);
                string formattedId = $"exp{categoryId:D3}";

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete expense category {formattedId}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Delete the category from the database
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM expenses_categories WHERE id = @categoryId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@categoryId", categoryId);
                                command.ExecuteNonQuery();
                            }
                        }

                        // Refresh the DataGridView after deletion
                        LoadCategoriesData();

                        MessageBox.Show($"Expense category {formattedId} deleted successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting expense category: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void expCatFirstBtn_Click(object sender, EventArgs e)
        {
            if (expCatDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                expCatDataGridView.CurrentCell = expCatDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void expCatPrevBtn_Click(object sender, EventArgs e)
        {
            if (expCatDataGridView.Rows.Count > 0 && currentIndex > 0)
            {
                currentIndex--;
                expCatDataGridView.CurrentCell = expCatDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void expCatNextBtn_Click(object sender, EventArgs e)
        {
            if (expCatDataGridView.Rows.Count > 0 && currentIndex < expCatDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                expCatDataGridView.CurrentCell = expCatDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void expCatLastBtn_Click(object sender, EventArgs e)
        {
            if (expCatDataGridView.Rows.Count > 0)
            {
                currentIndex = expCatDataGridView.Rows.Count - 1;
                expCatDataGridView.CurrentCell = expCatDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}