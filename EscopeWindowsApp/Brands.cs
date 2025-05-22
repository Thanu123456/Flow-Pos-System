using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class Brands : Form
    {
        private DataTable brandsTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public Brands()
        {
            InitializeComponent();
            this.Load += Brands_Load;
            bindingSource = new BindingSource();
            brandsDataGridView.CellPainting += BrandsDataGridView_CellPainting;
            brandsDataGridView.CellFormatting += BrandsDataGridView_CellFormatting;
            brandsDataGridView.CellContentClick += brandsDataGridView_CellContentClick; // Ensure event is wired
        }

        private void Brands_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            brandsDataGridView.DataSource = bindingSource;
            LoadBrandsData();

            
        }

        private void ConfigureDataGridView()
        {
            brandsDataGridView.AutoGenerateColumns = false;
            brandsDataGridView.Columns.Clear();

            brandsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                Name = "id",
                HeaderText = "BRAND ID",
                Width = 100,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            brandsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
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
                ToolTipText = "Edit this brand",
                Text = "Edit",
                UseColumnTextForButtonValue = true // Ensures "Edit" text is displayed
            };
            brandsDataGridView.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this brand",
                Text = "Delete",
                UseColumnTextForButtonValue = true // Ensures "Delete" text is displayed
            };
            brandsDataGridView.Columns.Add(deleteColumn);

            brandsDataGridView.AllowUserToAddRows = false;
        }

        private void BrandsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (brandsDataGridView.Columns[e.ColumnIndex].Name == "id")
            {
                int brandId = Convert.ToInt32(e.Value);
                e.Value = $"BRN{brandId:D3}";
                e.FormattingApplied = true;
            }
        }

        private void BrandsDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (brandsDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
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

                    if (brandsDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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

        private void LoadBrandsData()
        {
            try
            {
                brandsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name FROM brands ORDER BY id ASC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(brandsTable);
                    }
                }

                foreach (DataRow row in brandsTable.Rows)
                {
                    if (row.IsNull("name"))
                    {
                        row["name"] = "";
                    }
                }

                bindingSource.DataSource = brandsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading brands: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                brandsTable = new DataTable();
                brandsTable.Columns.Add("id", typeof(int));
                brandsTable.Columns.Add("name", typeof(string));
                brandsTable.Rows.Add(1, "Test Brand 1");
                brandsTable.Rows.Add(2, "Test Brand 2");
                bindingSource.DataSource = brandsTable;
            }
        }

        private void createBrandsBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreateBrand)
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
            CreateBrand createForm = new CreateBrand();
            createForm.FormClosed += (s, args) => LoadBrandsData();
            createForm.Show();
        }

        private void brandsSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = brandsSearchText.Text.Trim().ToLower();
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

        private void brandsFilterBtn_Click(object sender, EventArgs e)
        {
            LoadBrandsData();
            brandsSearchText.Text = string.Empty;
            bindingSource.Filter = null;
        }

        private void brandsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Ignore header clicks

            DataRowView rowView = (DataRowView)bindingSource[e.RowIndex];
            DataRow row = rowView.Row;

            try
            {
                if (brandsDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    int brandId = Convert.ToInt32(row["id"]);
                    string name = row["name"].ToString();
                    byte[] logo = null;

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT logo FROM brands WHERE id = @brandId";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@brandId", brandId);
                            object result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                logo = (byte[])result;
                            }
                        }
                    }

                    CreateBrand editForm = new CreateBrand(brandId, name, logo);
                    editForm.FormClosed += (s, args) => LoadBrandsData();
                    editForm.ShowDialog(); // Use ShowDialog for modal behavior
                }
                else if (brandsDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    int brandId = Convert.ToInt32(row["id"]);
                    string formattedId = $"BRA{brandId:D3}";

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete brand {formattedId}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM brands WHERE id = @brandId";
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@brandId", brandId);
                                command.ExecuteNonQuery();
                            }
                        }
                        LoadBrandsData();
                        MessageBox.Show($"Brand {formattedId} deleted successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in cell action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brandsFirstBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0)
            {
                bindingSource.Position = 0;
            }
        }

        private void brandsPrevBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position > 0)
            {
                bindingSource.Position--;
            }
        }

        private void brandsNextBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Position < bindingSource.Count - 1)
            {
                bindingSource.Position++;
            }
        }

        private void brandsLastBtn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Count > 0)
            {
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void brandsRecordsPerLabel_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality if needed
        }

        private void Brands_Load_1(object sender, EventArgs e)
        {
            // Remove or merge with Brands_Load if not needed
        }
    }
}