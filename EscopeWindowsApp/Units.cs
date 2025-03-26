using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class Units : Form
    {
        private DataTable unitsTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public Units()
        {
            InitializeComponent();
            this.Load += Units_Load; // Subscribe to Load event
            bindingSource = new BindingSource();
            unitsDataGridView.CellPainting += UnitsDataGridView_CellPainting;
            unitsDataGridView.CellFormatting += UnitsDataGridView_CellFormatting;
        }

        private void Units_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();     // Configure columns first
            unitsDataGridView.DataSource = bindingSource; // Bind data source
            LoadUnitsData();            // Load data last

            if (unitsTable.Rows.Count == 0)
            {
                MessageBox.Show("No unit data found.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfigureDataGridView()
        {
            unitsDataGridView.AutoGenerateColumns = false;
            unitsDataGridView.Columns.Clear();

            unitsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "Unit ID"
            });
            unitsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit_name",
                Name = "unit_name",
                HeaderText = "NAME"
            });
            unitsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "short_name",
                Name = "short_name",
                HeaderText = "SHORT NAME"
            });
            unitsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "base_unit_name",
                Name = "base_unit_name",
                HeaderText = "BASE UNIT"
            });
            unitsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "created_at",
                Name = "created_at",
                HeaderText = "CREATED ON"
            });

            unitsDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                Width = 50,
                ToolTipText = "Edit this unit"
            });

            unitsDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "Delete",
                Width = 50,
                ToolTipText = "Delete this unit"
            });

            unitsDataGridView.AllowUserToAddRows = false;
        }

        private void UnitsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (unitsDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                int unitId = Convert.ToInt32(e.Value);
                e.Value = $"un{unitId:D3}"; // Format as "un001", "un002", etc.
                e.FormattingApplied = true;
            }
        }

        private void UnitsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (unitsDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
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

                    if (unitsDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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

        private void LoadUnitsData()
        {
            try
            {
                unitsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT u.id, u.unit_name, u.short_name, u.base_unit_id, b.name AS base_unit_name, u.created_at
                        FROM units u
                        LEFT JOIN base_units b ON u.base_unit_id = b.id
                        ORDER BY u.id ASC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(unitsTable);
                    }
                }

                foreach (DataRow row in unitsTable.Rows)
                {
                    if (row.IsNull("unit_name")) row["unit_name"] = "";
                    if (row.IsNull("short_name")) row["short_name"] = "";
                    if (row.IsNull("base_unit_name")) row["base_unit_name"] = "";
                }

                bindingSource.DataSource = unitsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unitsTable = new DataTable();
                unitsTable.Columns.Add("id", typeof(int));
                unitsTable.Columns.Add("unit_name", typeof(string));
                unitsTable.Columns.Add("short_name", typeof(string));
                unitsTable.Columns.Add("base_unit_id", typeof(int));
                unitsTable.Columns.Add("base_unit_name", typeof(string));
                unitsTable.Columns.Add("created_at", typeof(DateTime));

                bindingSource.DataSource = unitsTable;
            }
        }

        private void createUnitsBtn_Click(object sender, EventArgs e)
        {
            using (CreateUnits createForm = new CreateUnits())
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUnitsData();
                }
            }
        }

        private void unitsSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = unitsSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"unit_name LIKE '%{searchText}%' OR short_name LIKE '%{searchText}%'";
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

        private void unitsFilterBtn_Click(object sender, EventArgs e)
        {
            LoadUnitsData();
            unitsSearchText.Text = string.Empty;
            bindingSource.Filter = null;
        }

        private void unitsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = unitsDataGridView.Rows[e.RowIndex];
                DataRow dataRow = (row.DataBoundItem as DataRowView)?.Row; // Get the underlying DataRow

                if (dataRow == null)
                {
                    MessageBox.Show("Error accessing row data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (unitsDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    int unitId = Convert.ToInt32(row.Cells["id"].Value);
                    string unitName = row.Cells["unit_name"].Value.ToString();
                    string shortName = row.Cells["short_name"].Value.ToString();
                    // Access base_unit_id directly from the DataRow instead of the DataGridView
                    int baseUnitId = dataRow["base_unit_id"] != DBNull.Value ? Convert.ToInt32(dataRow["base_unit_id"]) : 0;

                    using (CreateUnits editForm = new CreateUnits(unitId, unitName, shortName, baseUnitId))
                    {
                        editForm.ShowDialog(); // Show the edit form
                        LoadUnitsData();       // Refresh grid regardless of result
                    }
                }

                if (unitsDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    int unitId = Convert.ToInt32(row.Cells["id"].Value);
                    string formattedId = $"un{unitId:D3}";

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete unit {formattedId}?",
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
                                string query = "DELETE FROM units WHERE id = @unitId";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@unitId", unitId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            LoadUnitsData();
                            MessageBox.Show($"Unit {formattedId} deleted successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting unit: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void unitsFirstBtn_Click(object sender, EventArgs e)
        {
            if (unitsDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                unitsDataGridView.CurrentCell = unitsDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void unitsPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                unitsDataGridView.CurrentCell = unitsDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void unitsNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < unitsDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                unitsDataGridView.CurrentCell = unitsDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void unitsLastBtn_Click(object sender, EventArgs e)
        {
            if (unitsDataGridView.Rows.Count > 0)
            {
                currentIndex = unitsDataGridView.Rows.Count - 1;
                unitsDataGridView.CurrentCell = unitsDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}