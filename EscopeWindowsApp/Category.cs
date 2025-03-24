using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class Category : Form
    {
        private DataTable categoriesTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public Category()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            // Explicitly wire all events
            categoryDataGridView.CellPainting += CategoryDataGridView_CellPainting;
            categoryDataGridView.CellFormatting += CategoryDataGridView_CellFormatting;
            categoryDataGridView.CellContentClick += categoryDataGridView_CellContentClick; // Ensure click event is hooked
        }

        private void Category_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();     // First configure columns
            categoryDataGridView.DataSource = bindingSource; // Then bind data source
            LoadCategoriesData();       // Finally load data

            if (categoriesTable.Rows.Count == 0)
            {
                MessageBox.Show("No category data found.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfigureDataGridView()
        {
            categoryDataGridView.AutoGenerateColumns = false;
            categoryDataGridView.Columns.Clear();

            categoryDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "CATEGORY ID"
            });
            categoryDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "NAME"
            });

            categoryDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "EDIT",
                Width = 50,
                ToolTipText = "Edit this category"
            });

            categoryDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this category"
            });

            categoryDataGridView.AllowUserToAddRows = false;
        }

        private void CategoryDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (categoryDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                int categoryId = Convert.ToInt32(e.Value);
                e.Value = $"cat{categoryId:D3}"; // Format as "cat001", "cat002", etc.
                e.FormattingApplied = true;
            }
        }

        private void CategoryDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (categoryDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
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

                    if (categoryDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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
                    string query = "SELECT id, name FROM categories ORDER BY id ASC";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                categoriesTable = new DataTable();
                categoriesTable.Columns.Add("id", typeof(int));
                categoriesTable.Columns.Add("name", typeof(string));
                categoriesTable.Rows.Add(1, "Test Category 1");
                categoriesTable.Rows.Add(2, "Test Category 2");
                bindingSource.DataSource = categoriesTable;
            }
        }

        private void createCategoryBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateCategory)
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
            CreateCategory createForm = new CreateCategory();
            createForm.FormClosed += (s, args) => LoadCategoriesData();
            createForm.Show();
        }

        private void categorySearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = categorySearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"name LIKE '%{searchText}%'";
                }
                else
                {
                    bindingSource.Filter = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying search filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
            }
        }

        private void categoryRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadCategoriesData();
            categorySearchText.Text = string.Empty;
            bindingSource.Filter = null;
        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = categoryDataGridView.Rows[e.RowIndex];
                string columnName = categoryDataGridView.Columns[e.ColumnIndex].Name;

                // Debugging: Confirm the column clicked
                Console.WriteLine($"Clicked column: {columnName}");

                if (columnName == "EditColumn")
                {
                    try
                    {
                        int categoryId = Convert.ToInt32(row.Cells["id"].Value);
                        string name = row.Cells["name"].Value.ToString();
                        byte[] logo = null;

                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT logo FROM categories WHERE id = @categoryId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@categoryId", categoryId);
                                object result = command.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                {
                                    logo = (byte[])result;
                                }
                            }
                        }

                        CreateCategory editForm = new CreateCategory(categoryId, name, logo);
                        editForm.FormClosed += (s, args) => LoadCategoriesData();
                        editForm.Show();

                        Console.WriteLine($"Edit button clicked for category ID: {categoryId}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening edit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (columnName == "DeleteColumn")
                {
                    int categoryId = Convert.ToInt32(row.Cells["id"].Value);
                    string formattedId = $"cat{categoryId:D3}";

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete category {formattedId}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();
                                string query = "DELETE FROM categories WHERE id = @categoryId";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@categoryId", categoryId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            LoadCategoriesData();
                            MessageBox.Show($"Category {formattedId} deleted successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting category: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    Console.WriteLine($"Delete button clicked for category ID: {categoryId}");
                }
            }
        }

        private void categoryFirstBtn_Click(object sender, EventArgs e)
        {
            if (categoryDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                categoryDataGridView.CurrentCell = categoryDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void categoryPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                categoryDataGridView.CurrentCell = categoryDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void categoryNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < categoryDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                categoryDataGridView.CurrentCell = categoryDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void categoryLastBtn_Click(object sender, EventArgs e)
        {
            if (categoryDataGridView.Rows.Count > 0)
            {
                currentIndex = categoryDataGridView.Rows.Count - 1;
                categoryDataGridView.CurrentCell = categoryDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}