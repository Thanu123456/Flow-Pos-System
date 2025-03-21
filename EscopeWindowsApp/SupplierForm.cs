using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class SupplierForm : Form
    {
        private DataTable suppliersTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public SupplierForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadSuppliersData();
            supDataGridView.CellPainting += SupDataGridView_CellPainting;
            supDataGridView.CellFormatting += SupDataGridView_CellFormatting;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            supDataGridView.DataSource = bindingSource;
        }

        private void ConfigureDataGridView()
        {
            supDataGridView.AutoGenerateColumns = false;
            supDataGridView.Columns.Clear();

            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "Supplier ID"
            });
            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "Name"
            });
            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "email",
                Name = "email",
                HeaderText = "Email"
            });
            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "phone",
                Name = "phone",
                HeaderText = "Phone"
            });
            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "city",
                Name = "city",
                HeaderText = "City"
            });
            
            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "item",
                Name = "item",
                HeaderText = "Item"
            });
            supDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "created_at",
                Name = "created_at",
                HeaderText = "Created At"
            });

            supDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                Width = 50,
                ToolTipText = "Edit this supplier"
            });

            supDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "Delete",
                Width = 50,
                ToolTipText = "Delete this supplier"
            });

            // Prevent the empty row at the end
            supDataGridView.AllowUserToAddRows = false;
        }

        private void SupDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (supDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                if (e.Value != null)
                {
                    int supplierId = Convert.ToInt32(e.Value);
                    e.Value = $"sup{supplierId:D3}";
                    e.FormattingApplied = true;
                }
            }
        }

        private void SupDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (supDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
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

                if (supDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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

        private void LoadSuppliersData()
        {
            try
            {
                suppliersTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name, email, phone, city, address, item, created_at FROM suppliers";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(suppliersTable);
                    }
                }

                // Replace DBNull with default values
                foreach (DataRow row in suppliersTable.Rows)
                {
                    for (int i = 0; i < suppliersTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (suppliersTable.Columns[i].DataType == typeof(string))
                            {
                                row[i] = "";
                            }
                            else if (suppliersTable.Columns[i].DataType == typeof(DateTime))
                            {
                                row[i] = DateTime.MinValue;
                            }
                        }
                    }
                }

                bindingSource.DataSource = suppliersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                suppliersTable = new DataTable();
                suppliersTable.Columns.Add("id", typeof(int));
                suppliersTable.Columns.Add("name", typeof(string));
                suppliersTable.Columns.Add("email", typeof(string));
                suppliersTable.Columns.Add("phone", typeof(string));
                suppliersTable.Columns.Add("city", typeof(string));
                suppliersTable.Columns.Add("address", typeof(string));
                suppliersTable.Columns.Add("item", typeof(string));
                suppliersTable.Columns.Add("created_at", typeof(DateTime));
                bindingSource.DataSource = suppliersTable;
            }
        }

        private void createSupBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddSupplierForm)
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
            AddSupplierForm addForm = new AddSupplierForm();
            addForm.FormClosed += (s, args) => LoadSuppliersData();
            addForm.Show();
        }

        private void supSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = supSearchText.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchText))
            {
                bindingSource.Filter = $"name LIKE '%{searchText}%' OR " +
                                       $"email LIKE '%{searchText}%' OR " +
                                       $"phone LIKE '%{searchText}%' OR " +
                                       $"city LIKE '%{searchText}%' OR " +
                                       $"item LIKE '%{searchText}%'";
            }
            else
            {
                bindingSource.Filter = null;
            }
        }

        private void supFilterBtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = selectSupDateTime.Value.Date;
            bindingSource.Filter = $"created_at >= #{selectedDate:yyyy-MM-dd}# AND created_at < #{selectedDate.AddDays(1):yyyy-MM-dd}#";
        }

        private void supRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadSuppliersData();
            supSearchText.Text = string.Empty;
            selectSupDateTime.Value = DateTime.Now;
            bindingSource.Filter = null; // Explicitly clear any existing filter
        }

        private void supDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = supDataGridView.Rows[e.RowIndex];

                if (supDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    int supplierId = Convert.ToInt32(row.Cells["id"].Value);
                    string name = row.Cells["name"].Value.ToString();
                    string email = row.Cells["email"].Value.ToString();
                    string phone = row.Cells["phone"].Value.ToString();
                    string city = row.Cells["city"].Value.ToString();
                    string item = row.Cells["item"].Value.ToString();

                    // Fetch the address from the database since it's not shown in the grid
                    string address = "";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT address FROM suppliers WHERE id = @supplierId";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@supplierId", supplierId);
                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                address = result.ToString();
                            }
                        }
                    }

                    AddSupplierForm editForm = new AddSupplierForm(supplierId, name, email, phone, city, address, item);
                    editForm.FormClosed += (s, args) => LoadSuppliersData();
                    editForm.Show();
                }

                if (supDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    int supplierId = Convert.ToInt32(row.Cells["id"].Value);
                    string formattedId = $"sup{supplierId:D3}";

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete supplier {formattedId}?",
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
                                string query = "DELETE FROM suppliers WHERE id = @supplierId";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@supplierId", supplierId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            LoadSuppliersData();
                            MessageBox.Show($"Supplier {formattedId} deleted successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting supplier: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void supFirstBtn_Click(object sender, EventArgs e)
        {
            if (supDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                supDataGridView.CurrentCell = supDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void supPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                supDataGridView.CurrentCell = supDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void supNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < supDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                supDataGridView.CurrentCell = supDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void supLastBtn_Click(object sender, EventArgs e)
        {
            if (supDataGridView.Rows.Count > 0)
            {
                currentIndex = supDataGridView.Rows.Count - 1;
                supDataGridView.CurrentCell = supDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void selectSupDateTime_ValueChanged(object sender, EventArgs e)
        {
            // No action needed; filtering is handled by supFilterBtn_Click
        }
    }
}