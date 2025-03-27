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
            baseUnitDataGridView.CellPainting += BaseUnitDataGridView_CellPainting;
            baseUnitDataGridView.CellFormatting += BaseUnitDataGridView_CellFormatting;
            baseUnitDataGridView.CellContentClick += baseUnitDataGridView_CellContentClick; // Ensure event is wired
        }

        private void BaseUnit_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            baseUnitDataGridView.DataSource = bindingSource;
            LoadBaseUnitsData();

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

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "EDIT",
                Width = 50,
                ToolTipText = "Edit this base unit",
                Text = "Edit",
                UseColumnTextForButtonValue = true // Ensures "Edit" text is displayed
            };
            baseUnitDataGridView.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this base unit",
                Text = "Delete",
                UseColumnTextForButtonValue = true // Ensures "Delete" text is displayed
            };
            baseUnitDataGridView.Columns.Add(deleteColumn);

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
                baseUnitsTable.Rows.Add(1, "Test Unit 1");
                baseUnitsTable.Rows.Add(2, "Test Unit 2");
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
            LoadBaseUnitsData();
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

        private void baseUnitDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Ignore header clicks

            DataRowView rowView = (DataRowView)bindingSource[e.RowIndex];
            DataRow row = rowView.Row;

            try
            {
                if (baseUnitDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    int baseUnitId = Convert.ToInt32(row["id"]);
                    string name = row["name"].ToString();

                    CreateBaseUnit editForm = new CreateBaseUnit(baseUnitId, name);
                    editForm.FormClosed += (s, args) => LoadBaseUnitsData();
                    editForm.ShowDialog(); // Use ShowDialog for modal behavior
                }
                else if (baseUnitDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    int baseUnitId = Convert.ToInt32(row["id"]);
                    string formattedId = $"bu{baseUnitId:D3}";

                    int dependentUnitCount = CountUnitsUsingBaseUnit(baseUnitId);
                    if (dependentUnitCount == -1)
                    {
                        return; // Error already shown
                    }

                    if (dependentUnitCount > 0)
                    {
                        MessageBox.Show(
                            $"Warning: Base unit {formattedId} is currently used by {dependentUnitCount} unit(s). " +
                            "You cannot delete this base unit until the dependent units are deleted or reassigned.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    DialogResult confirmResult = MessageBox.Show(
                        $"Are you sure you want to delete base unit {formattedId}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult == DialogResult.Yes)
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in cell action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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