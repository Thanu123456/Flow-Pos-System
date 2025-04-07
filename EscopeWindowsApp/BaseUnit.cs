using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class BaseUnit : Form
    {
        private DataTable baseUnitsTable;
        private BindingSource bindingSource;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public BaseUnit()
        {
            InitializeComponent();
            this.Load += BaseUnit_Load;
            bindingSource = new BindingSource();
            baseUnitDataGridView.CellFormatting += BaseUnitDataGridView_CellFormatting;
        }

        private void BaseUnit_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            baseUnitDataGridView.DataSource = bindingSource;
            LoadBaseUnitsData();
        }

        private void ConfigureDataGridView()
        {
            baseUnitDataGridView.AutoGenerateColumns = false;
            baseUnitDataGridView.Columns.Clear();

            baseUnitDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "BASEUNIT ID",
                Width = 100,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            baseUnitDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "NAME",
                Width = 200,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            baseUnitDataGridView.AllowUserToAddRows = false;
        }

        private void BaseUnitDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (baseUnitDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                int baseUnitId = Convert.ToInt32(e.Value);
                e.Value = $"bu{baseUnitId:D3}";
                e.FormattingApplied = true;
            }
        }

        private void LoadBaseUnitsData()
        {
            try
            {
                baseUnitsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name FROM base_units ORDER BY id ASC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(baseUnitsTable);
                    }
                }

                foreach (DataRow row in baseUnitsTable.Rows)
                {
                    if (row.IsNull("name"))
                    {
                        row["name"] = "";
                    }
                }

                bindingSource.DataSource = baseUnitsTable;
                UpdateCreateButtonState(); // Update button state after loading data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading base units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baseUnitsTable = new DataTable();
                baseUnitsTable.Columns.Add("id", typeof(int));
                baseUnitsTable.Columns.Add("name", typeof(string));
                baseUnitsTable.Rows.Add(1, "Test Unit 1");
                baseUnitsTable.Rows.Add(2, "Test Unit 2");
                bindingSource.DataSource = baseUnitsTable;
                UpdateCreateButtonState(); // Update button state in case of error
            }

            // Show message if no data is found
            if (baseUnitsTable.Rows.Count == 0)
            {
                MessageBox.Show("No base unit data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateCreateButtonState()
        {
            // Check the number of rows in the baseUnitsTable
            int rowCount = baseUnitsTable.Rows.Count;
            // Disable the button if there are 4 or more rows
            baseUnitsBtn.Enabled = rowCount < 4;
            // Optional: Add a tooltip to explain why the button is disabled
            if (!baseUnitsBtn.Enabled)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(baseUnitsBtn, "Maximum of 4 base units reached.");
            }
        }

        private void baseUnitsBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateBaseUnit)
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
            CreateBaseUnit createForm = new CreateBaseUnit();
            createForm.FormClosed += (s, args) =>
            {
                LoadBaseUnitsData(); // This will call UpdateCreateButtonState
            };
            createForm.Show();
        }

        private void baseUnitSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = baseUnitSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"name LIKE '%{searchText}%'";
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

        private void baseUnitFilterBtn_Click(object sender, EventArgs e)
        {
            LoadBaseUnitsData(); // This will call UpdateCreateButtonState
            baseUnitSearchText.Text = string.Empty;
            bindingSource.Filter = null;
        }

        private int CountUnitsUsingBaseUnit(int baseUnitId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM units WHERE base_unit_id = @baseUnitId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@baseUnitId", baseUnitId);
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking dependent units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void baseUnitsFirstBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0)
            {
                bindingSource.Position = 0;
            }
        }

        private void baseUnitsPrevBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.Position--;
            }
        }

        private void baseUnitsNextBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.Position++;
            }
        }

        private void baseUnitsLastBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0)
            {
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void baseUnitsOfLabel_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality if needed
        }
    }
}