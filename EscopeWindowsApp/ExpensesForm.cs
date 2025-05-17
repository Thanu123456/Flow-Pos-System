using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class ExpensesForm : Form
    {
        private DataTable expensesTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public ExpensesForm()
        {
            InitializeComponent();
            this.Load += ExpensesForm_Load;
            bindingSource = new BindingSource();
            expDataGridView.CellPainting += ExpDataGridView_CellPainting;
            expDataGridView.CellFormatting += ExpDataGridView_CellFormatting;
            expDataGridView.CellContentClick += expDataGridView_CellContentClick;
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            expDataGridView.DataSource = bindingSource;
            LoadExpensesData();

            if (expensesTable.Rows.Count == 0)
            {
                MessageBox.Show("No expense data found.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfigureDataGridView()
        {
            expDataGridView.AutoGenerateColumns = false;
            expDataGridView.Columns.Clear();

            expDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "Expense ID"
            });
            expDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "expense_date",
                Name = "expense_date",
                HeaderText = "DATE"
            });
            expDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "title",
                Name = "title",
                HeaderText = "TITLE"
            });
            expDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "warehouse_name",
                Name = "warehouse_name",
                HeaderText = "WAREHOUSE"
            });
            expDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "category_name",
                Name = "category_name",
                HeaderText = "CATEGORY"
            });
            expDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "amount",
                Name = "amount",
                HeaderText = "AMOUNT"
            });

            expDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "EDIT",
                Width = 50,
                ToolTipText = "Edit this expense"
            });

            expDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this expense"
            });

            expDataGridView.AllowUserToAddRows = false;
            expDataGridView.ScrollBars = ScrollBars.Horizontal;
        }

        private void ExpDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (expDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                int expenseId = Convert.ToInt32(e.Value);
                e.Value = $"EXP{expenseId:D3}";
                e.FormattingApplied = true;
            }
            else if (expDataGridView.Columns[e.ColumnIndex].Name == "amount")
            {
                e.Value = String.Format("{0:C}", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void ExpDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (expDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
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

                    if (expDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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

        private void LoadExpensesData()
        {
            try
            {
                expensesTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT e.id, e.expense_date, e.title, 
                               w.name AS warehouse_name, ec.name AS category_name, 
                               e.amount, e.details, e.warehouse_id, e.category_id
                        FROM expenses e
                        LEFT JOIN warehouses w ON e.warehouse_id = w.id
                        LEFT JOIN expenses_categories ec ON e.category_id = ec.id
                        ORDER BY e.id ASC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(expensesTable);
                    }
                }

                foreach (DataRow row in expensesTable.Rows)
                {
                    if (row.IsNull("title")) row["title"] = "";
                    if (row.IsNull("warehouse_name")) row["warehouse_name"] = "";
                    if (row.IsNull("category_name")) row["category_name"] = "";
                    if (row.IsNull("details")) row["details"] = "";
                }

                bindingSource.DataSource = expensesTable;

                // Adjust currentIndex after loading data
                if (expDataGridView.Rows.Count > 0)
                {
                    currentIndex = Math.Min(currentIndex, expDataGridView.Rows.Count - 1);
                    expDataGridView.CurrentCell = expDataGridView.Rows[currentIndex].Cells[0];
                }
                else
                {
                    currentIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expenses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expensesTable = new DataTable();
                expensesTable.Columns.Add("id", typeof(int));
                expensesTable.Columns.Add("expense_date", typeof(DateTime));
                expensesTable.Columns.Add("title", typeof(string));
                expensesTable.Columns.Add("warehouse_name", typeof(string));
                expensesTable.Columns.Add("category_name", typeof(string));
                expensesTable.Columns.Add("amount", typeof(decimal));
                expensesTable.Columns.Add("details", typeof(string));
                expensesTable.Columns.Add("warehouse_id", typeof(int));
                expensesTable.Columns.Add("category_id", typeof(int));

                bindingSource.DataSource = expensesTable;
                currentIndex = 0;
            }
        }

        private void createExpBtn_Click(object sender, EventArgs e)
        {
            using (CreateExpenses createForm = new CreateExpenses())
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    LoadExpensesData();
                }
            }
        }

        private void expSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = expSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"title LIKE '%{searchText}%'";
                }
                else
                {
                    bindingSource.Filter = null;
                }

                if (expDataGridView.Rows.Count > 0)
                {
                    currentIndex = Math.Min(currentIndex, expDataGridView.Rows.Count - 1);
                    expDataGridView.CurrentCell = expDataGridView.Rows[currentIndex].Cells[0];
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

        private void expRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadExpensesData();
            expSearchText.Text = string.Empty;
            bindingSource.Filter = null;
        }

        private void expDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on headers or invalid indices
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Check if the row index is still valid after any UI updates
            if (e.RowIndex >= expDataGridView.Rows.Count)
            {
                return; // Exit if the index is out of range
            }

            DataGridViewRow row = expDataGridView.Rows[e.RowIndex];
            DataRow dataRow = (row.DataBoundItem as DataRowView)?.Row;

            if (dataRow == null)
            {
                MessageBox.Show("Error accessing row data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (expDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
            {
                try
                {
                    int expenseId = Convert.ToInt32(dataRow["id"]);
                    DateTime expenseDate = Convert.ToDateTime(dataRow["expense_date"]);
                    string title = dataRow["title"].ToString();
                    int warehouseId = dataRow["warehouse_id"] != DBNull.Value ? Convert.ToInt32(dataRow["warehouse_id"]) : 0;
                    int categoryId = dataRow["category_id"] != DBNull.Value ? Convert.ToInt32(dataRow["category_id"]) : 0;
                    decimal amount = Convert.ToDecimal(dataRow["amount"]);
                    string details = dataRow["details"].ToString();

                    // Check if edit form is already open for this expense
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is CreateExpenses editForm && editForm.Tag?.ToString() == expenseId.ToString())
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

                    CreateExpenses editFormNew = new CreateExpenses(expenseId, expenseDate, title, warehouseId, categoryId, amount, details);
                    editFormNew.Tag = expenseId;
                    editFormNew.FormClosed += (s, args) => LoadExpensesData();
                    editFormNew.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening edit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (expDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
            {
                int expenseId = Convert.ToInt32(dataRow["id"]);
                string formattedId = $"exp{expenseId:D3}";

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete expense {formattedId}?",
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
                            string query = "DELETE FROM expenses WHERE id = @expenseId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@expenseId", expenseId);
                                command.ExecuteNonQuery();
                            }
                        }

                        LoadExpensesData();
                        MessageBox.Show($"Expense {formattedId} deleted successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1451) // Foreign key constraint violation
                        {
                            MessageBox.Show($"Cannot delete expense {formattedId} as it is referenced by other records.",
                                "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Error deleting expense: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting expense: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void expFirstBtn_Click(object sender, EventArgs e)
        {
            if (expDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                expDataGridView.CurrentCell = expDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void expPrevBtn_Click(object sender, EventArgs e)
        {
            if (expDataGridView.Rows.Count > 0 && currentIndex > 0)
            {
                currentIndex--;
                expDataGridView.CurrentCell = expDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void expNextBtn_Click(object sender, EventArgs e)
        {
            if (expDataGridView.Rows.Count > 0 && currentIndex < expDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                expDataGridView.CurrentCell = expDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void expLastBtn_Click(object sender, EventArgs e)
        {
            if (expDataGridView.Rows.Count > 0)
            {
                currentIndex = expDataGridView.Rows.Count - 1;
                expDataGridView.CurrentCell = expDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}