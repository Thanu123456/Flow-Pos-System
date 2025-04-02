using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace EscopeWindowsApp
{
    public partial class PreviousGRN : Form
    {
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private DataTable grnTable;
        private BindingSource bindingSource;

        public PreviousGRN()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            // Wire up events like Production
            preGRNDataGridView.CellPainting += PreGRNDataGridView_CellPainting;
            preGRNDataGridView.CellFormatting += PreGRNDataGridView_CellFormatting;
            preGRNDataGridView.CellContentClick += PreGRNDataGridView_CellContentClick;
        }

        private void PreviousGRN_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadGRNData();
            preGRNDataGridView.DataSource = bindingSource;

            // Populate filterDateComboBox with "Select Date" as default
            filterDateComboBox.Items.Clear();
            filterDateComboBox.Items.AddRange(new string[] { "Select Date", "TODAY", "THIS WEEK", "LAST WEEK", "THIS MONTH" });
            filterDateComboBox.SelectedIndex = 0; // Default to "Select Date"

            // Populate filterPaymentComboBox with "Select Payment Method" as default
            filterPaymentComboBox.Items.Clear();
            filterPaymentComboBox.Items.AddRange(new string[] { "Select Payment Method", "Cash", "Cheque", "Credit Supplier" });
            filterPaymentComboBox.SelectedIndex = 0; // Default to "Select Payment Method"
        }

        private void ConfigureDataGridView()
        {
            preGRNDataGridView.AutoGenerateColumns = false;
            preGRNDataGridView.Columns.Clear();

            // Define the uniform font for all cells
            Font gridFont = new Font("Segoe UI", 9F);

            // Add columns for grn table
            preGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "grn_no",
                Name = "grn_no",
                HeaderText = "GRN NUMBER",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont } // Explicitly set font
            });
            preGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "payment_method",
                Name = "payment_method",
                HeaderText = "PAYMENT METHOD",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            preGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "total_amount",
                Name = "total_amount",
                HeaderText = "TOTAL AMOUNT",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "N2" } // Currency format
            });
            preGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "date",
                Name = "date",
                HeaderText = "DATE",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "yyyy-MM-dd HH:mm:ss" } // Date format
            });

            // Add Delete button column (styled like Production)
            preGRNDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this GRN",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont } // Ensure button text (if any) uses same font
            });

            // Prevent the empty row at the end
            preGRNDataGridView.AllowUserToAddRows = false;

            // Styling consistent with Production, enforce uniform font
            preGRNDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            preGRNDataGridView.DefaultCellStyle.Font = gridFont; // Set globally
            preGRNDataGridView.RowHeadersVisible = false;

            // Ensure no inherited or runtime font changes
            preGRNDataGridView.Font = gridFont; // Set at grid level as fallback
        }

        private void LoadGRNData()
        {
            try
            {
                grnTable = new DataTable();
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT grn_no, payment_method, total_amount, date FROM grn ORDER BY date DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(grnTable);
                    }
                }

                // Replace DBNull with default values (like Production)
                foreach (DataRow row in grnTable.Rows)
                {
                    for (int i = 0; i < grnTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (grnTable.Columns[i].DataType == typeof(string))
                                row[i] = "N/A";
                            else if (grnTable.Columns[i].DataType == typeof(decimal))
                                row[i] = 0.00m;
                        }
                    }
                }

                bindingSource.DataSource = grnTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading GRN data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grnTable = new DataTable();
                grnTable.Columns.Add("grn_no", typeof(string));
                grnTable.Columns.Add("payment_method", typeof(string));
                grnTable.Columns.Add("total_amount", typeof(decimal));
                grnTable.Columns.Add("date", typeof(DateTime));
                bindingSource.DataSource = grnTable;
            }
        }

        private void PreGRNDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Handle null values like Production
            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }

            // Ensure font consistency in CellFormatting
            e.CellStyle.Font = new Font("Segoe UI", 9F);
        }

        private void PreGRNDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (preGRNDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
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
                    MessageBox.Show($"Error rendering delete icon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PreGRNDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && preGRNDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
            {
                DataGridViewRow row = preGRNDataGridView.Rows[e.RowIndex];
                string grnNo = row.Cells["grn_no"].Value.ToString();

                // Confirmation prompt styled like Production
                DialogResult result = MessageBox.Show($"Are you sure you want to delete GRN '{grnNo}'?\nThis will also remove associated items and update stock.",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            using (MySqlTransaction transaction = conn.BeginTransaction())
                            {
                                // Fetch grn_items to adjust stock
                                string itemsQuery = "SELECT product_id, variation_type, quantity FROM grn_items WHERE grn_id = (SELECT id FROM grn WHERE grn_no = @grnNo)";
                                using (MySqlCommand itemsCmd = new MySqlCommand(itemsQuery, conn, transaction))
                                {
                                    itemsCmd.Parameters.AddWithValue("@grnNo", grnNo);
                                    using (MySqlDataReader reader = itemsCmd.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            int productId = reader.GetInt32("product_id");
                                            string variationType = reader.IsDBNull(reader.GetOrdinal("variation_type")) ? null : reader.GetString("variation_type");
                                            int quantity = reader.GetInt32("quantity");

                                            // Reduce stock in stock table
                                            string stockQuery = @"
                                                UPDATE stock 
                                                SET stock = GREATEST(stock - @quantity, 0)
                                                WHERE product_id = @productId AND (variation_type = @variationType OR (variation_type IS NULL AND @variationType IS NULL))";
                                            using (MySqlCommand stockCmd = new MySqlCommand(stockQuery, conn, transaction))
                                            {
                                                stockCmd.Parameters.AddWithValue("@quantity", quantity);
                                                stockCmd.Parameters.AddWithValue("@productId", productId);
                                                stockCmd.Parameters.AddWithValue("@variationType", variationType ?? (object)DBNull.Value);
                                                stockCmd.ExecuteNonQuery();
                                            }

                                            // Reduce total stock in products table
                                            string productStockQuery = "UPDATE products SET stock = GREATEST(stock - @quantity, 0) WHERE id = @productId";
                                            using (MySqlCommand productCmd = new MySqlCommand(productStockQuery, conn, transaction))
                                            {
                                                productCmd.Parameters.AddWithValue("@quantity", quantity);
                                                productCmd.Parameters.AddWithValue("@productId", productId);
                                                productCmd.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                }

                                // Delete grn_items
                                string deleteItemsQuery = "DELETE FROM grn_items WHERE grn_id = (SELECT id FROM grn WHERE grn_no = @grnNo)";
                                using (MySqlCommand deleteItemsCmd = new MySqlCommand(deleteItemsQuery, conn, transaction))
                                {
                                    deleteItemsCmd.Parameters.AddWithValue("@grnNo", grnNo);
                                    deleteItemsCmd.ExecuteNonQuery();
                                }

                                // Delete grn record
                                string deleteGrnQuery = "DELETE FROM grn WHERE grn_no = @grnNo";
                                using (MySqlCommand deleteGrnCmd = new MySqlCommand(deleteGrnQuery, conn, transaction))
                                {
                                    deleteGrnCmd.Parameters.AddWithValue("@grnNo", grnNo);
                                    deleteGrnCmd.ExecuteNonQuery();
                                }

                                transaction.Commit();
                            }
                        }

                        // Refresh the DataGridView
                        LoadGRNData();
                        MessageBox.Show($"GRN '{grnNo}' deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting GRN: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void preGRNCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preGRNSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = preGRNSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"grn_no LIKE '%{searchText}%' OR " +
                                           $"payment_method LIKE '%{searchText}%'";
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

        private void preGRNRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadGRNData();
            preGRNSearchText.Text = string.Empty;
            filterDateComboBox.SelectedIndex = 0; // Reset to "Select Date"
            filterPaymentComboBox.SelectedIndex = 0; // Reset to "Select Payment Method"
            bindingSource.Filter = null;
        }

        private void filterDateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // If "Select Date" is selected, show all data
                if (filterDateComboBox.SelectedIndex == 0) // "Select Date"
                {
                    bindingSource.Filter = null;
                    return;
                }

                DateTime now = DateTime.Now;
                string filter = string.Empty;

                switch (filterDateComboBox.SelectedItem.ToString())
                {
                    case "TODAY":
                        filter = $"date >= '{now.ToString("yyyy-MM-dd 00:00:00")}' AND date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                    case "THIS WEEK":
                        DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek); // Sunday as start
                        filter = $"date >= '{startOfWeek.ToString("yyyy-MM-dd 00:00:00")}' AND date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                    case "LAST WEEK":
                        DateTime lastWeekStart = now.AddDays(-(int)now.DayOfWeek - 7);
                        DateTime lastWeekEnd = lastWeekStart.AddDays(6);
                        filter = $"date >= '{lastWeekStart.ToString("yyyy-MM-dd 00:00:00")}' AND date <= '{lastWeekEnd.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                    case "THIS MONTH":
                        DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
                        filter = $"date >= '{startOfMonth.ToString("yyyy-MM-dd 00:00:00")}' AND date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                }

                bindingSource.Filter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying date filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
            }
        }
        private void preGRNDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filterPaymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (filterPaymentComboBox.SelectedIndex == 0) // "Select Payment Method"
                {
                    bindingSource.Filter = null;
                    return;
                }

                string selectedPayment = filterPaymentComboBox.SelectedItem.ToString();
                bindingSource.Filter = $"payment_method = '{selectedPayment}'";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying payment filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
            }
        }
    }
}