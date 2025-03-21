using MySql.Data.MySqlClient;
using System;
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
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public CustomerForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadCustomersData();
            cusDataGridView.CellPainting += CustomerDataGridView_CellPainting;
            cusDataGridView.CellFormatting += CustomerDataGridView_CellFormatting;
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
                HeaderText = "Customer ID"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "Name"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "email",
                Name = "email",
                HeaderText = "Email"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "phone",
                Name = "phone",
                HeaderText = "Phone"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "city",
                Name = "city",
                HeaderText = "City"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "address",
                Name = "address",
                HeaderText = "Address"
            });
            cusDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "created_at",
                Name = "created_at",
                HeaderText = "Created At"
            });

            cusDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                Width = 50,
                ToolTipText = "Edit this customer"
            });

            cusDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "Delete",
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
                if (cusDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    e.PaintBackground(e.CellBounds, true);
                    Image editIcon = Properties.Resources.edit;
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
                    Image deleteIcon = Properties.Resources.delete;
                    int iconSize = (int)(Math.Min(e.CellBounds.Width, e.CellBounds.Height) * 0.7);
                    if (iconSize <= 0) iconSize = 16;
                    int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                    int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                    e.Graphics.DrawImage(deleteIcon, x, y, iconSize, iconSize);
                    e.Handled = true;
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

        private void cusFilterBtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = selectCusDateTime.Value.Date;
            bindingSource.Filter = $"created_at >= #{selectedDate:yyyy-MM-dd}# AND created_at < #{selectedDate.AddDays(1):yyyy-MM-dd}#";
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

                if (cusDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
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
                            dob = Convert.ToDateTime(command.ExecuteScalar());
                        }
                    }

                    AddCustomerForm editForm = new AddCustomerForm(customerId, name, email, phone, dob, city, address);
                    editForm.FormClosed += (s, args) => LoadCustomersData();
                    editForm.Show();
                }

                if (cusDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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