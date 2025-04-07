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
            this.Load += Units_Load;
            bindingSource = new BindingSource();
            unitsDataGridView.CellFormatting += UnitsDataGridView_CellFormatting;
        }

        private void Units_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            unitsDataGridView.DataSource = bindingSource;
            LoadUnitsData();
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

            unitsDataGridView.AllowUserToAddRows = false;
            unitsDataGridView.ScrollBars = ScrollBars.Horizontal;
        }

        private void UnitsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (unitsDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                int unitId = Convert.ToInt32(e.Value);
                e.Value = $"un{unitId:D3}";
                e.FormattingApplied = true;
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
                UpdateCreateButtonState(); // Update button state after loading data
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
                UpdateCreateButtonState(); // Update button state in case of error
            }

            // Show message if no data is found
            if (unitsTable.Rows.Count == 0)
            {
                MessageBox.Show("No unit data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateCreateButtonState()
        {
            // Check the number of rows in the unitsTable
            int rowCount = unitsTable.Rows.Count;
            // Disable the button if there are 4 or more rows
            createUnitsBtn.Enabled = rowCount < 4;
            // Optional: Add a tooltip to explain why the button is disabled
            if (!createUnitsBtn.Enabled)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(createUnitsBtn, "Maximum of 4 units reached.");
            }
        }

        private void createUnitsBtn_Click(object sender, EventArgs e)
        {
            using (CreateUnits createForm = new CreateUnits())
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUnitsData(); // This will call UpdateCreateButtonState
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
                UpdateCreateButtonState(); // Update button state after filtering
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying search filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
                UpdateCreateButtonState(); // Update button state in case of error
            }
        }

        private void unitsFilterBtn_Click(object sender, EventArgs e)
        {
            LoadUnitsData(); // This will call UpdateCreateButtonState
            unitsSearchText.Text = string.Empty;
            bindingSource.Filter = null;
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