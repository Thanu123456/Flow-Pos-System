using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class PreviousGRN : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable grnTable;
        private BindingSource bindingSource;

        public PreviousGRN()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            // Wire up events
            preGRNDataGridView.CellPainting += PreGRNDataGridView_CellPainting;
            preGRNDataGridView.CellFormatting += PreGRNDataGridView_CellFormatting;
            preGRNDataGridView.CellContentClick += PreGRNDataGridView_CellContentClick;
            preGRNDataGridView.CellDoubleClick += PreGRNDataGridView_CellDoubleClick; // New double-click event
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
            

            // Add columns for grn table
            preGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "grn_no",
                Name = "grn_no",
                HeaderText = "GRN NUMBER",
                Width = 150,
               
            });
            preGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "payment_method",
                Name = "payment_method",
                HeaderText = "PAYMENT METHOD",
                Width = 120,
               
            });
            preGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "total_amount",
                Name = "total_amount",
                HeaderText = "TOTAL AMOUNT",
                Width = 100,
                
            });
            preGRNDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "date",
                Name = "date",
                HeaderText = "DATE",
                Width = 140,
                
            });

            // Add Delete button column
            preGRNDataGridView.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "DELETE",
                Width = 50,
                ToolTipText = "Delete this GRN",
               
            });

            // Prevent the empty row at the end
            preGRNDataGridView.AllowUserToAddRows = false;

            // Styling
           
            preGRNDataGridView.RowHeadersVisible = false;
          
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

                // Replace DBNull with default values
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

            // Handle null values
            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }

            // Ensure font consistency
            e.CellStyle.Font = new Font("Segoe UI", 12F);
        }

        private void PreGRNDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && preGRNDataGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
            {
                try
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

        private void PreGRNDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            try
            {
                string grnNo = preGRNDataGridView.Rows[e.RowIndex].Cells["grn_no"].Value?.ToString();
                if (string.IsNullOrEmpty(grnNo)) return;

                int grnId;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id FROM grn WHERE grn_no = @grnNo";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@grnNo", grnNo);
                        object result = cmd.ExecuteScalar();
                        if (result == null || !int.TryParse(result.ToString(), out grnId))
                        {
                            return;
                        }
                    }
                }

                DataTable detailsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            gi.product_id,
                            p.name AS product_name,
                            gi.variation_type,
                            gi.unit,
                            gi.quantity,
                            gi.cost_price,
                            gi.net_price
                        FROM grn_items gi
                        INNER JOIN products p ON gi.product_id = p.id
                        WHERE gi.grn_id = @grnId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@grnId", grnId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(detailsTable);
                        }
                    }
                }

                Form detailsForm = new Form
                {
                    Text = $"GRN Products - {grnNo}",
                    Size = new Size(850, 300),
                    StartPosition = FormStartPosition.CenterScreen,
                    BackColor = Color.White,
                    MinimumSize = new Size(850, 300),
                    MaximumSize = new Size(850, 300),
                    MaximizeBox = false,
                    MinimizeBox = false,
                    AutoScroll = false
                };

                DataGridView detailsGrid = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    AutoGenerateColumns = false,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AllowUserToResizeRows = false,
                    AllowUserToResizeColumns = false,
                    BackgroundColor = Color.White,
                    RowTemplate = { Height = 35 },
                    ColumnHeadersHeight = 45,
                    ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                    ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F, FontStyle.Bold) }
                };

                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "product_id",
                    HeaderText = "PRODUCT ID",
                    Width = 100
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "product_name",
                    HeaderText = "PRODUCT NAME",
                    Width = 180
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "variation_type",
                    HeaderText = "VARIATION TYPE",
                    Width = 120
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "unit",
                    HeaderText = "UNIT",
                    Width = 100
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "quantity",
                    HeaderText = "QUANTITY",
                    Width = 100
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "cost_price",
                    HeaderText = "COST PRICE",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "net_price",
                    HeaderText = "NET PRICE",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
                });

                detailsGrid.DataSource = detailsTable;
                detailsGrid.CellFormatting += (s, args) =>
                {
                    if (args.RowIndex < 0) return;
                    if (args.Value == DBNull.Value || args.Value == null || (args.Value is string str && string.IsNullOrWhiteSpace(str)))
                    {
                        args.Value = "N/A";
                        args.FormattingApplied = true;
                    }
                    else if (detailsGrid.Columns[args.ColumnIndex].DataPropertyName == "product_id")
                    {
                        if (int.TryParse(args.Value.ToString(), out int id))
                        {
                            args.Value = $"PRO{id:D3}";
                            args.FormattingApplied = true;
                        }
                    }
                };

                detailsForm.Controls.Add(detailsGrid);
                detailsForm.ShowDialog();
            }
            catch (Exception)
            {
                // Silently fail to avoid disrupting user experience
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
            filterDateComboBox.SelectedIndex = 0;
            filterPaymentComboBox.SelectedIndex = 0;
            bindingSource.Filter = null;
        }

        private void filterDateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (filterDateComboBox.SelectedIndex == 0)
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
                        DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek);
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
                if (filterPaymentComboBox.SelectedIndex == 0)
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