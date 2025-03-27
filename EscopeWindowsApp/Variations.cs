using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class Variations : Form
    {
        private DataTable variationsTable;
        private BindingSource bindingSource;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public Variations()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            variationsDataGridView.CellPainting += VariationsDataGridView_CellPainting;
            variationsDataGridView.CellFormatting += VariationsDataGridView_CellFormatting;
            this.Load += Variations_Load;
        }

        private void Variations_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            variationsDataGridView.DataSource = bindingSource;
            LoadVariationsData();

            if (variationsTable.Rows.Count == 0)
            {
                MessageBox.Show("No variation data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfigureDataGridView()
        {
            variationsDataGridView.AutoGenerateColumns = false;
            variationsDataGridView.Columns.Clear();

            // Variation ID column
            variationsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "VariationId",
                HeaderText = "Variation ID",
                Width = 100,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });

            // Name column
            variationsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "name",
                Name = "VariationName",
                HeaderText = "Name",
                Width = 150,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });

            // Types column
            variationsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "types",
                Name = "VariationTypes",
                HeaderText = "Types",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Edit button column
            variationsDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                ToolTipText = "Edit this variation"
            });

            // Delete button column
            variationsDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "Delete",
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                ToolTipText = "Delete this variation"
            });

            variationsDataGridView.AllowUserToAddRows = false;
        }

        private void LoadVariationsData()
        {
            try
            {
                variationsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Updated query to include individual type columns
                    string query = "SELECT id, name, type1, type2, type3, type4, type5, " +
                                   "CONCAT_WS(', ', NULLIF(type1, ''), NULLIF(type2, ''), NULLIF(type3, ''), " +
                                   "NULLIF(type4, ''), NULLIF(type5, '')) AS types " +
                                   "FROM variations ORDER BY id ASC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(variationsTable);
                    }
                }

                // Handle null names
                foreach (DataRow row in variationsTable.Rows)
                {
                    if (row.IsNull("name"))
                    {
                        row["name"] = "";
                    }
                }

                bindingSource.DataSource = variationsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading variations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                variationsTable = new DataTable();
                // Define all columns, including individual types and concatenated types
                variationsTable.Columns.Add("id", typeof(int));
                variationsTable.Columns.Add("name", typeof(string));
                variationsTable.Columns.Add("type1", typeof(string));
                variationsTable.Columns.Add("type2", typeof(string));
                variationsTable.Columns.Add("type3", typeof(string));
                variationsTable.Columns.Add("type4", typeof(string));
                variationsTable.Columns.Add("type5", typeof(string));
                variationsTable.Columns.Add("types", typeof(string));

                bindingSource.DataSource = variationsTable;
            }
        }

        private void VariationsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (variationsDataGridView.Columns[e.ColumnIndex].Name == "VariationId")
            {
                int variationId = Convert.ToInt32(e.Value);
                e.Value = $"var{variationId:D3}"; // Format as "var001", "var002", etc.
                e.FormattingApplied = true;
            }
        }

        private void VariationsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (variationsDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
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

                    if (variationsDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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

        private void createVariationsBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AddVariationItem)
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
            AddVariationItem addVariationItem = new AddVariationItem();
            addVariationItem.FormClosed += (s, args) => LoadVariationsData();
            addVariationItem.Show();
        }

        private void variationsSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = variationsSearchText.Text.Trim().ToLower();
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

        private void variationsFilterBtn_Click(object sender, EventArgs e)
        {
            LoadVariationsData();
            variationsSearchText.Text = string.Empty;
            bindingSource.Filter = null;
        }

        private void variationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView rowView = (DataRowView)bindingSource[e.RowIndex];
                DataRow row = rowView.Row;

                if (variationsDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    int variationId = Convert.ToInt32(row["id"]);
                    string name = row["name"].ToString();
                    string type1 = row["type1"] != DBNull.Value ? row["type1"].ToString() : "";
                    string type2 = row["type2"] != DBNull.Value ? row["type2"].ToString() : "";
                    string type3 = row["type3"] != DBNull.Value ? row["type3"].ToString() : "";
                    string type4 = row["type4"] != DBNull.Value ? row["type4"].ToString() : "";
                    string type5 = row["type5"] != DBNull.Value ? row["type5"].ToString() : "";

                    AddVariationItem editForm = new AddVariationItem(variationId, name, type1, type2, type3, type4, type5);
                    editForm.FormClosed += (s, args) => LoadVariationsData();
                    editForm.Show();
                }

                if (variationsDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    int variationId = Convert.ToInt32(row["id"]);
                    string formattedId = $"var{variationId:D3}";

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete variation {formattedId}?",
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
                                string query = "DELETE FROM variations WHERE id = @variationId";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@variationId", variationId);
                                    command.ExecuteNonQuery();
                                }
                            }
                            LoadVariationsData();
                            MessageBox.Show($"Variation {formattedId} deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting variation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void variationsFirstBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0)
            {
                bindingSource.Position = 0;
            }
        }

        private void variationsPrevBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.Position--;
            }
        }

        private void variationsNextBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.Position++;
            }
        }

        private void variationsLastBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0)
            {
                bindingSource.Position = bindingSource.Count - 1;
            }
        }
    }
}