using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;

namespace EscopeWindowsApp
{
    public partial class HoldForm : Form
    {
        private POS posForm;
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public HoldForm(POS posForm)
        {
            InitializeComponent();
            this.posForm = posForm;
            holdListDataGridView.CellPainting += HoldListDataGridView_CellPainting;
            holdListDataGridView.CellFormatting += HoldListDataGridView_CellFormatting;
            holdListDataGridView.CellContentClick += holdListDataGridView_CellContentClick;
        }

        private void HoldForm_Load(object sender, EventArgs e)
        {
            ConfigureHoldListDataGridView();
            LoadHeldSales();
        }

        private void ConfigureHoldListDataGridView()
        {
            holdListDataGridView.AutoGenerateColumns = false;
            holdListDataGridView.Columns.Clear();

            holdListDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "hold_id",
                HeaderText = "HOLD ID",
                DataPropertyName = "hold_id",
                Width = 70
            });
            holdListDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "hold_date",
                HeaderText = "DATE",
                DataPropertyName = "hold_date",
                Width = 150
            });
            holdListDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "reference_number",
                HeaderText = "REF. ID",
                DataPropertyName = "reference_number",
                Width = 100
            });
            holdListDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "EDIT",
                Width = 50,
                ToolTipText = "Edit this held sale"
            });
            holdListDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this held sale"
            });

            // Additional styling
            holdListDataGridView.RowHeadersVisible = false;
            holdListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            holdListDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            holdListDataGridView.AllowUserToAddRows = false;
        }

        private void LoadHeldSales()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT hold_id, hold_date, reference_number FROM held_sales ORDER BY hold_date DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        holdListDataGridView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading held sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HoldListDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (holdListDataGridView.Columns[e.ColumnIndex].Name == "hold_id")
            {
                if (e.Value != null)
                {
                    int holdId = Convert.ToInt32(e.Value);
                    e.Value = $"hold{holdId:D3}";
                    e.FormattingApplied = true;
                }
            }

            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }

        private void HoldListDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    if (holdListDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
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
                    else if (holdListDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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

        private void holdListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid (not header and within range)
            if (e.RowIndex >= 0 && e.RowIndex < holdListDataGridView.Rows.Count)
            {
                // Ensure the column clicked is either "EditColumn" or "DeleteColumn"
                if (holdListDataGridView.Columns[e.ColumnIndex].Name == "EditColumn" ||
                    holdListDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    int holdId = Convert.ToInt32(holdListDataGridView.Rows[e.RowIndex].Cells["hold_id"].Value);

                    if (holdListDataGridView.Columns[e.ColumnIndex].Name == "EditColumn")
                    {
                        posForm.LoadHeldSale(holdId);
                        this.Close(); // Ensure HoldForm closes after loading the sale
                    }
                    else if (holdListDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                    {
                        if (MessageBox.Show("Are you sure you want to delete this held sale?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                using (MySqlConnection connection = new MySqlConnection(connectionString))
                                {
                                    connection.Open();
                                    string deleteDetailsQuery = "DELETE FROM held_sale_details WHERE hold_id = @holdId";
                                    using (MySqlCommand cmd = new MySqlCommand(deleteDetailsQuery, connection))
                                    {
                                        cmd.Parameters.AddWithValue("@holdId", holdId);
                                        cmd.ExecuteNonQuery();
                                    }
                                    string deleteHeaderQuery = "DELETE FROM held_sales WHERE hold_id = @holdId";
                                    using (MySqlCommand cmd = new MySqlCommand(deleteHeaderQuery, connection))
                                    {
                                        cmd.Parameters.AddWithValue("@holdId", holdId);
                                        cmd.ExecuteNonQuery();
                                    }
                                    MessageBox.Show("Held sale deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadHeldSales();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error deleting held sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}