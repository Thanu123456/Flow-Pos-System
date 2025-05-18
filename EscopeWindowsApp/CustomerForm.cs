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
        private int currentIndex = -1; // Start with -1 to indicate no selection
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public CustomerForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            // Hook up BindingSource events to track position
            bindingSource.PositionChanged += BindingSource_PositionChanged;
            LoadCustomersData();
            // Explicitly wire all events
            cusDataGridView.CellPainting += CustomerDataGridView_CellPainting;
            cusDataGridView.CellFormatting += CustomerDataGridView_CellFormatting;
            cusDataGridView.CellContentClick += cusDataGridView_CellContentClick; // Ensure click event is hooked
        }

        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            // Sync currentIndex with the BindingSource position
            currentIndex = bindingSource.Position;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            cusDataGridView.DataSource = bindingSource;
            UpdateNavigation();
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
                HeaderText = "CREATED AT",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm:ss" } // Date format matching Sales form

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
                    e.Value = $"CUS{customerId:D3}";
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

                // Reset currentIndex and sync with BindingSource
                if (customersTable.Rows.Count > 0)
                {
                    bindingSource.Position = 0; // Move to the first row
                }
                else
                {
                    bindingSource.Position = -1; // No rows, no selection
                }

                UpdateNavigation();
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
                bindingSource.Position = -1; // No rows, no selection
                UpdateNavigation();
            }
        }

        private void UpdateNavigation()
        {
            // Enable/disable navigation buttons based on row count and position
            cusFirstBtn.Enabled = bindingSource.Count > 0 && bindingSource.Position > 0;
            cusPrevBtn.Enabled = bindingSource.Count > 0 && bindingSource.Position > 0;
            cusNextBtn.Enabled = bindingSource.Count > 0 && bindingSource.Position < bindingSource.Count - 1;
            cusLastBtn.Enabled = bindingSource.Count > 0 && bindingSource.Position < bindingSource.Count - 1;
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

                // Reset position after filtering
                if (bindingSource.Count > 0)
                {
                    bindingSource.Position = 0; // Move to the first row
                }
                else
                {
                    bindingSource.Position = -1; // No rows, no selection
                }

                UpdateNavigation();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying search filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
                bindingSource.Position = -1; // No rows, no selection
                UpdateNavigation();
            }
        }

        private void cusRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadCustomersData();
            cusSearchText.Text = string.Empty;
            bindingSource.Filter = null; // Explicitly clear any existing filter
        }

        private void cusDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Log event details for debugging
            Console.WriteLine($"CellContentClick triggered: RowIndex={e.RowIndex}, ColumnIndex={e.ColumnIndex}, Rows.Count={cusDataGridView.Rows.Count}");

            // Validate row index
            if (e.RowIndex >= 0 && e.RowIndex < cusDataGridView.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = cusDataGridView.Rows[e.RowIndex];
                    if (row == null || row.IsNewRow) // Additional safety check
                    {
                        Console.WriteLine("Row is null or new row, skipping.");
                        return;
                    }

                    string columnName = cusDataGridView.Columns[e.ColumnIndex].Name;
                    Console.WriteLine($"Clicked column: {columnName}");

                    if (columnName == "EditColumn")
                    {
                        int customerId = Convert.ToInt32(row.Cells["id"].Value);

                        // Fetch the latest customer data from the database instead of using grid data
                        string name, email, phone, city, address;
                        DateTime dob;
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT name, email, phone, dob, city, address FROM customers WHERE id = @customerId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@customerId", customerId);
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        name = reader["name"].ToString();
                                        email = reader["email"].ToString();
                                        phone = reader["phone"].ToString();
                                        dob = Convert.ToDateTime(reader["dob"]);
                                        city = reader["city"].ToString();
                                        address = reader["address"].ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }

                        // Check if an AddCustomerForm is already open for this customer
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form is AddCustomerForm existingForm && existingForm.Tag is int existingId && existingId == customerId)
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

                        AddCustomerForm editForm = new AddCustomerForm(customerId, name, email, phone, dob, city, address);
                        editForm.Tag = customerId; // Tag the form with the customer ID for identification
                        editForm.FormClosed += (s, args) => LoadCustomersData();
                        editForm.Show();

                        Console.WriteLine($"Edit button clicked for customer ID: {customerId}");
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
                            // Temporarily disable the grid to prevent further clicks during delete
                            cusDataGridView.Enabled = false;
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
                            finally
                            {
                                cusDataGridView.Enabled = true;
                            }
                        }

                        Console.WriteLine($"Delete button clicked for customer ID: {customerId}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception in CellContentClick: {ex.Message}");
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Console.WriteLine($"Invalid RowIndex: {e.RowIndex}, Rows.Count={cusDataGridView.Rows.Count}");
            }
        }

        private void cusFirstBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0)
            {
                bindingSource.Position = 0;
                UpdateNavigation();
            }
        }

        private void cusPrevBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0 && bindingSource.Position > 0)
            {
                bindingSource.Position--;
                UpdateNavigation();
            }
        }

        private void cusNextBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0 && bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.Position++;
                UpdateNavigation();
            }
        }

        private void cusLastBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0)
            {
                bindingSource.Position = bindingSource.Count - 1;
                UpdateNavigation();
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