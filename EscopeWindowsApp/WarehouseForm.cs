using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class WarehouseForm : Form
    {
        private DataTable warehousesTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public WarehouseForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadWarehousesData(); // Load data first
            wareDataGridView.CellPainting += WareDataGridView_CellPainting;
            wareDataGridView.CellFormatting += WareDataGridView_CellFormatting;
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ConfigureDataGridView()
        {
            wareDataGridView.AutoGenerateColumns = false;
            wareDataGridView.Columns.Clear();

            wareDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "Warehouse ID"
            });
            wareDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "Name"
            });
            wareDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "email",
                Name = "email",
                HeaderText = "Email"
            });
            wareDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "phone",
                Name = "phone",
                HeaderText = "Phone"
            });
            wareDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "city",
                Name = "city",
                HeaderText = "City"
            });
            wareDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "zip_code",
                Name = "zip_code",
                HeaderText = "Zip Code"
            });

            wareDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                Width = 50,
                ToolTipText = "Edit this warehouse"
            });

            wareDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "Delete",
                Width = 50,
                ToolTipText = "Delete this warehouse"
            });

            wareDataGridView.AllowUserToAddRows = false;
        }

        private void WareDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (wareDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                int warehouseId = Convert.ToInt32(e.Value);
                e.Value = $"wh{warehouseId:D3}"; // Format as "wh001", "wh002", etc.
                e.FormattingApplied = true;
            }
        }

        private void WareDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (wareDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                    {
                        e.PaintBackground(e.CellBounds, true);
                        Image editIcon = Properties.Resources.edit ?? SystemIcons.Question.ToBitmap(); // Fallback if missing
                        int iconSize = (int)(Math.Min(e.CellBounds.Width, e.CellBounds.Height) * 0.7);
                        if (iconSize <= 0) iconSize = 16;
                        int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;
                        e.Graphics.DrawImage(editIcon, x, y, iconSize, iconSize);
                        e.Handled = true;
                    }

                    if (wareDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                    {
                        e.PaintBackground(e.CellBounds, true);
                        Image deleteIcon = Properties.Resources.delete ?? SystemIcons.Warning.ToBitmap(); // Fallback if missing
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

        private void LoadWarehousesData()
        {
            try
            {
                warehousesTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name, email, phone, city, zip_code FROM warehouses";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(warehousesTable);
                    }
                }

                foreach (DataRow row in warehousesTable.Rows)
                {
                    for (int i = 0; i < warehousesTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i) && warehousesTable.Columns[i].DataType == typeof(string))
                        {
                            row[i] = "";
                        }
                    }
                }

                bindingSource.DataSource = warehousesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading warehouses: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                warehousesTable = new DataTable();
                warehousesTable.Columns.Add("id", typeof(int));
                warehousesTable.Columns.Add("name", typeof(string));
                warehousesTable.Columns.Add("email", typeof(string));
                warehousesTable.Columns.Add("phone", typeof(string));
                warehousesTable.Columns.Add("city", typeof(string));
                warehousesTable.Columns.Add("zip_code", typeof(string));
                bindingSource.DataSource = warehousesTable;
            }
        }

        private void createWareBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddWarehouseForm)
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
            AddWarehouseForm addForm = new AddWarehouseForm();
            addForm.FormClosed += (s, args) => LoadWarehousesData();
            addForm.Show();
        }

        private void wareSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = wareSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"name LIKE '%{searchText}%' OR " +
                                           $"email LIKE '%{searchText}%' OR " +
                                           $"phone LIKE '%{searchText}%' OR " +
                                           $"city LIKE '%{searchText}%' OR " +
                                           $"zip_code LIKE '%{searchText}%'";
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

        private void wareFilterBtn_Click(object sender, EventArgs e)
        {
            LoadWarehousesData();
            wareSearchText.Text = string.Empty;
            bindingSource.Filter = null;
        }

        

        private void wareDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = wareDataGridView.Rows[e.RowIndex];

                if (wareDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    int warehouseId = Convert.ToInt32(row.Cells["id"].Value);
                    string name = row.Cells["name"].Value.ToString();
                    string email = row.Cells["email"].Value.ToString();
                    string phone = row.Cells["phone"].Value.ToString();
                    string city = row.Cells["city"].Value.ToString();
                    string zipCode = row.Cells["zip_code"].Value.ToString();

                    string address = "";
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "SELECT address FROM warehouses WHERE id = @warehouseId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@warehouseId", warehouseId);
                                object result = command.ExecuteScalar();
                                address = result?.ToString() ?? "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error fetching address: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    AddWarehouseForm editForm = new AddWarehouseForm(warehouseId, name, email, phone, city, address, zipCode);
                    editForm.FormClosed += (s, args) => LoadWarehousesData();
                    editForm.Show();
                }

                if (wareDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    int warehouseId = Convert.ToInt32(row.Cells["id"].Value);
                    string formattedId = $"wh{warehouseId:D3}";

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete warehouse {formattedId}?",
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
                                string query = "DELETE FROM warehouses WHERE id = @warehouseId";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@warehouseId", warehouseId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            LoadWarehousesData();
                            MessageBox.Show($"Warehouse {formattedId} deleted successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting warehouse: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void wareFirstBtn_Click(object sender, EventArgs e)
        {
            if (wareDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                wareDataGridView.CurrentCell = wareDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void warePrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                wareDataGridView.CurrentCell = wareDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void wareNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < wareDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                wareDataGridView.CurrentCell = wareDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void wareLastBtn_Click(object sender, EventArgs e)
        {
            if (wareDataGridView.Rows.Count > 0)
            {
                currentIndex = wareDataGridView.Rows.Count - 1;
                wareDataGridView.CurrentCell = wareDataGridView.Rows[currentIndex].Cells[0];
            }
        }
        private void WarehouseForm_Load_1(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            wareDataGridView.DataSource = bindingSource; // Bind after configuration
            if (warehousesTable.Rows.Count == 0)
            {
                MessageBox.Show("No warehouse data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}