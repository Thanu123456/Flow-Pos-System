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
        private int currentIndex = 0;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public BaseUnit()
        {
            InitializeComponent();
            this.Load += BaseUnit_Load; // Ensure the Load event is subscribed
            bindingSource = new BindingSource();
            baseUnitDataGridView.CellPainting += BaseUnitDataGridView_CellPainting;
            baseUnitDataGridView.CellFormatting += BaseUnitDataGridView_CellFormatting;
        }

        private void BaseUnit_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();     // First configure columns
            baseUnitDataGridView.DataSource = bindingSource; // Then bind data source
            LoadBaseUnitsData();        // Finally load data

            if (baseUnitsTable.Rows.Count == 0)
            {
                MessageBox.Show("No base unit data found.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfigureDataGridView()
        {
            baseUnitDataGridView.AutoGenerateColumns = false;
            baseUnitDataGridView.Columns.Clear();

            baseUnitDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "Base Unit ID"
            });
            baseUnitDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                Name = "name",
                HeaderText = "Name"
            });

            baseUnitDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                Width = 50,
                ToolTipText = "Edit this base unit"
            });

            baseUnitDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "Delete",
                Width = 50,
                ToolTipText = "Delete this base unit"
            });

            baseUnitDataGridView.AllowUserToAddRows = false;
        }

        private void BaseUnitDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (baseUnitDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                int baseUnitId = Convert.ToInt32(e.Value);
                e.Value = $"bu{baseUnitId:D3}"; // Format as "bu001", "bu002", etc.
                e.FormattingApplied = true;
            }
        }

        private void BaseUnitDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (baseUnitDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
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

                    if (baseUnitDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading base units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baseUnitsTable = new DataTable();
                baseUnitsTable.Columns.Add("id", typeof(int));
                baseUnitsTable.Columns.Add("name", typeof(string));

                bindingSource.DataSource = baseUnitsTable;
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
            createForm.FormClosed += (s, args) => LoadBaseUnitsData();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying search filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
            }
        }

        private void baseUnitFilterBtn_Click(object sender, EventArgs e)
        {
            LoadBaseUnitsData();            // Reload the base units data from the database
            baseUnitSearchText.Text = string.Empty;  // Clear the search textbox
            bindingSource.Filter = null;
        }

        // Method to check if a base unit is referenced by any units
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
                return -1; // Indicate an error
            }
        }

        private void baseUnitDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = baseUnitDataGridView.Rows[e.RowIndex];

                if (baseUnitDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    int baseUnitId = Convert.ToInt32(row.Cells["id"].Value);
                    string name = row.Cells["name"].Value.ToString();

                    CreateBaseUnit editForm = new CreateBaseUnit(baseUnitId, name);
                    editForm.FormClosed += (s, args) => LoadBaseUnitsData();
                    editForm.Show();
                }

                if (baseUnitDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    int baseUnitId = Convert.ToInt32(row.Cells["id"].Value);
                    string formattedId = $"bu{baseUnitId:D3}";

                    // Check if the base unit is referenced by any units
                    int dependentUnitCount = CountUnitsUsingBaseUnit(baseUnitId);
                    if (dependentUnitCount == -1)
                    {
                        // Error already shown in CountUnitsUsingBaseUnit
                        return;
                    }

                    // If the base unit is in use, show a warning dialog with only a "Cancel" button (labeled as "OK")
                    if (dependentUnitCount > 0)
                    {
                        MessageBox.Show(
                            $"Warning: Base unit {formattedId} is currently used by {dependentUnitCount} unit(s). " +
                            "You cannot delete this base unit until the dependent units are deleted or reassigned.",
                            "Warning",
                            MessageBoxButtons.OK, // Only one button, labeled "OK" but acts as "Cancel"
                            MessageBoxIcon.Warning
                        );
                        // Abort the deletion process
                        return;
                    }

                    // Proceed to the confirmation dialog if there are no dependent units
                    DialogResult confirmResult = MessageBox.Show(
                        $"Are you sure you want to delete base unit {formattedId}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();
                                string query = "DELETE FROM base_units WHERE id = @baseUnitId";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@baseUnitId", baseUnitId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            LoadBaseUnitsData();
                            MessageBox.Show($"Base unit {formattedId} deleted successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting base unit: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void baseUnitsFirstBtn_Click(object sender, EventArgs e)
        {
            if (baseUnitDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                baseUnitDataGridView.CurrentCell = baseUnitDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void baseUnitsPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                baseUnitDataGridView.CurrentCell = baseUnitDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void baseUnitsNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < baseUnitDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                baseUnitDataGridView.CurrentCell = baseUnitDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void baseUnitsLastBtn_Click(object sender, EventArgs e)
        {
            if (baseUnitDataGridView.Rows.Count > 0)
            {
                currentIndex = baseUnitDataGridView.Rows.Count - 1;
                baseUnitDataGridView.CurrentCell = baseUnitDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void baseUnitsOfLabel_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality if needed
        }
    }
}