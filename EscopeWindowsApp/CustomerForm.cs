using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class CustomerForm : Form
    {
        private DataTable customersTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public CustomerForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadCustomersData();
            // Explicitly wire all events
            cusDataGridView.CellPainting += CustomerDataGridView_CellPainting;
            cusDataGridView.CellFormatting += CustomerDataGridView_CellFormatting;
            cusDataGridView.CellContentClick += cusDataGridView_CellContentClick; // Ensure click event is hooked
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            cusDataGridView.DataSource = bindingSource;
        }

        private void ConfigureDataGridView()
        {
            cusDataGridView.AutoGenerateColumns = false;
            cusDataGridView.Columns.Clear();

            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "CUSTOMER ID"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "NAME"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "email",
                Name = "email",
                HeaderText = "EMAIL"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "phone",
                Name = "phone",
                HeaderText = "PHONE"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "city",
                Name = "city",
                HeaderText = "CITY"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "address",
                Name = "address",
                HeaderText = "ADDRESS"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "created_at",
                Name = "created_at",
                HeaderText = "CREATED AT"
            });

            cusDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "EDIT",
                Width = 50,
                ToolTipText = "Edit this customer"
            });

            cusDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this customer"
            });

            // Prevent the empty row at the end
            cusDataGridView.AllowUserToAddRows = false;
        }

        private void CustomerDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (cusDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                if (e.Value != null)
                {
                    int customerId = Convert.ToInt32(e.Value);
                    e.Value = $"cus{customerId:D3}";
                    e.FormattingApplied = true;
                }
            }
        }

        private void CustomerDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (cusDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                    {
                        e.PaintBackground(e.CellBounds, true);
                        Image editIcon = Properties.Resources.edit ?? SystemIcons.Question.ToBitmap(); // Fallback if resource is missing
                        int iconSize = (int)(Math.Min(e.CellBounds.Width, e.CellBounds.Height) * 0.7);
                        if (iconSize <= 0) iconSize = 16;
                        int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(editIcon, x, y, iconSize, iconSize);
                        e.Handled = true;
                    }

                    if (cusDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                    {
                        e.PaintBackground(e.CellBounds, true);
                        Image deleteIcon = Properties.Resources.delete ?? SystemIcons.Warning.ToBitmap(); // Fallback if resource is missing
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

        private void LoadCustomersData()
        {
            try
            {
                customersTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name, email, phone, city, address, created_at FROM customers";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(customersTable);
                    }
                }

                // Replace DBNull with default values
                foreach (DataRow row in customersTable.Rows)
                {
                    for (int i = 0; i < customersTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (customersTable.Columns[i].DataType == typeof(string))
                            {
                                row[i] = "";
                            }
                            else if (customersTable.Columns[i].DataType == typeof(DateTime))
                            {
                                row[i] = DateTime.MinValue;
                            }
                        }
                    }
                }

                bindingSource.DataSource = customersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                customersTable = new DataTable();
                customersTable.Columns.Add("id", typeof(int));
                customersTable.Columns.Add("name", typeof(string));
                customersTable.Columns.Add("email", typeof(string));
                customersTable.Columns.Add("phone", typeof(string));
                customersTable.Columns.Add("city", typeof(string));
                customersTable.Columns.Add("address", typeof(string));
                customersTable.Columns.Add("created_at", typeof(DateTime));
                bindingSource.DataSource = customersTable;
            }
        }

        private void createCusBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddCustomerForm)
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
            AddCustomerForm addForm = new AddCustomerForm();
            addForm.FormClosed += (s, args) => LoadCustomersData();
            addForm.Show();
        }

        private void cusSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = cusSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"name LIKE '%{searchText}%' OR " +
                                           $"email LIKE '%{searchText}%' OR " +
                                           $"phone LIKE '%{searchText}%' OR " +
                                           $"city LIKE '%{searchText}%' OR " +
                                           $"address LIKE '%{searchText}%'";
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

        private void cusFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = selectCusDateTime.Value.Date;
                bindingSource.Filter = $"created_at >= #{selectedDate:yyyy-MM-dd}# AND created_at < #{selectedDate.AddDays(1):yyyy-MM-dd}#";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying date filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
            }
        }

        private void cusRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadCustomersData();
            cusSearchText.Text = string.Empty;
            selectCusDateTime.Value = DateTime.Now;
            bindingSource.Filter = null; // Explicitly clear any existing filter
        }

        private void cusDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = cusDataGridView.Rows[e.RowIndex];
                string columnName = cusDataGridView.Columns[e.ColumnIndex].Name;

                // Debugging: Confirm the column clicked
                Console.WriteLine($"Clicked column: {columnName}");

                if (columnName == "EditColumn")
                {
                    try
                    {
                        int customerId = Convert.ToInt32(row.Cells["id"].Value);
                        string name = row.Cells["name"].Value.ToString();
                        string email = row.Cells["email"].Value.ToString();
                        string phone = row.Cells["phone"].Value.ToString();
                        string city = row.Cells["city"].Value.ToString();
                        string address = row.Cells["address"].Value.ToString();

                        // Fetch DOB from the database since it's not in the grid
                        DateTime dob;
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT dob FROM customers WHERE id = @customerId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@customerId", customerId);
                                object result = command.ExecuteScalar();
                                dob = result == null || result == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(result);
                            }
                        }

                        AddCustomerForm editForm = new AddCustomerForm(customerId, name, email, phone, dob, city, address);
                        editForm.FormClosed += (s, args) => LoadCustomersData();
                        editForm.Show();

                        Console.WriteLine($"Edit button clicked for customer ID: {customerId}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening edit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (columnName == "DeleteColumn")
                {
                    int customerId = Convert.ToInt32(row.Cells["id"].Value);
                    string formattedId = $"cus{customerId:D3}";

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete customer {formattedId}?",
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
                                string query = "DELETE FROM customers WHERE id = @customerId";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@customerId", customerId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            LoadCustomersData();
                            MessageBox.Show($"Customer {formattedId} deleted successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting customer: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    Console.WriteLine($"Delete button clicked for customer ID: {customerId}");
                }
            }
        }

        private void cusFirstBtn_Click(object sender, EventArgs e)
        {
            if (cusDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                cusDataGridView.CurrentCell = cusDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void cusPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                cusDataGridView.CurrentCell = cusDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void cusNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < cusDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                cusDataGridView.CurrentCell = cusDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void cusLastBtn_Click(object sender, EventArgs e)
        {
            if (cusDataGridView.Rows.Count > 0)
            {
                currentIndex = cusDataGridView.Rows.Count - 1;
                cusDataGridView.CurrentCell = cusDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void cusPageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add pagination logic here if needed
        }

        private void selectCusDateTime_ValueChanged(object sender, EventArgs e)
        {
            // No action needed; filtering is handled by cusFilterBtn_Click
        }
    }
}