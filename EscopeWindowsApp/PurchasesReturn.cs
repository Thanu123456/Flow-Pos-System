using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class PurchasesReturn : Form
    {
        private DataTable returnsTable; // Data source for purchase returns
        private BindingSource bindingSource; // Binding source for filtering
        private int currentIndex = 0; // Current index for navigation
        private readonly string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";

        public PurchasesReturn()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadReturnsData();
            purRetDataGridView.CellFormatting += PurRetDataGridView_CellFormatting;
            purRetDataGridView.CellDoubleClick += PurRetDataGridView_CellContentClick; // Changed to double-click
            this.Load += new System.EventHandler(this.PurchasesReturn_Load);
        }

        private void PurchasesReturn_Load(object sender, EventArgs e)
        {

        }

        private void ConfigureDataGridView()
        {
            purRetDataGridView.AutoGenerateColumns = false;
            purRetDataGridView.Columns.Clear();

            // Define columns matching purchase_returns table plus return_qty
            purRetDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "grn_no",
                Name = "grn_no",
                HeaderText = "GRN NO",
                Width = 100
            });
            purRetDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "return_no",
                Name = "return_no",
                HeaderText = "RETURN NO",
                Width = 100
            });
            purRetDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "note",
                Name = "note",
                HeaderText = "NOTE",
                Width = 200
            });
            purRetDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "total_amount",
                Name = "total_amount",
                HeaderText = "TOTAL AMOUNT",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
            purRetDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "return_qty",
                Name = "return_qty",
                HeaderText = "RETURN QTY",
                Width = 100
            });
            purRetDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "created_at",
                Name = "created_at",
                HeaderText = "CREATED DATE",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }
            });

            // Styling and behavior
            purRetDataGridView.AllowUserToAddRows = false;
            purRetDataGridView.ReadOnly = true;
            purRetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            purRetDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            purRetDataGridView.RowTemplate.Height = 35;
            purRetDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            purRetDataGridView.BackgroundColor = Color.White;
            purRetDataGridView.BorderStyle = BorderStyle.None; // From your previous request
        }

        private void LoadReturnsData()
        {
            try
            {
                returnsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            pr.grn_no,
                            pr.return_no,
                            pr.note,
                            pr.total_amount,
                            (SELECT SUM(prd.quantity) 
                             FROM purchase_return_details prd 
                             WHERE prd.return_id = pr.id) AS return_qty,
                            pr.created_at
                        FROM purchase_returns pr
                        ORDER BY pr.created_at DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(returnsTable);
                    }
                }

                // Handle null values
                foreach (DataRow row in returnsTable.Rows)
                {
                    row["grn_no"] = row["grn_no"] ?? "";
                    row["return_no"] = row["return_no"] ?? "";
                    row["note"] = row["note"] ?? "";
                    row["total_amount"] = row["total_amount"] ?? 0.00m;
                    row["return_qty"] = row["return_qty"] ?? 0; // Handle null return_qty
                    row["created_at"] = row["created_at"] ?? DateTime.Now;
                }

                bindingSource.DataSource = returnsTable;
                purRetDataGridView.DataSource = null; // Reset binding
                purRetDataGridView.DataSource = bindingSource;
                purRetDataGridView.Refresh();
            }
            catch (Exception)
            {
                // Fallback: Create empty DataTable with structure
                returnsTable = new DataTable();
                returnsTable.Columns.Add("grn_no", typeof(string));
                returnsTable.Columns.Add("return_no", typeof(string));
                returnsTable.Columns.Add("note", typeof(string));
                returnsTable.Columns.Add("total_amount", typeof(decimal));
                returnsTable.Columns.Add("return_qty", typeof(int));
                returnsTable.Columns.Add("created_at", typeof(DateTime));
                bindingSource.DataSource = returnsTable;
                purRetDataGridView.DataSource = bindingSource;
            }
        }

        private void PurRetDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
            else if (purRetDataGridView.Columns[e.ColumnIndex].Name == "note")
            {
                string value = e.Value.ToString().Trim();
                e.Value = string.IsNullOrWhiteSpace(value) ? "N/A" : value;
                e.FormattingApplied = true;
            }
            else if (purRetDataGridView.Columns[e.ColumnIndex].Name == "return_qty")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int qty))
                {
                    e.Value = qty.ToString();
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "0";
                    e.FormattingApplied = true;
                }
            }
        }

        private void purRetSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = purRetSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    searchText = searchText.Replace("'", "''");
                    bindingSource.Filter = $"grn_no LIKE '%{searchText}%' OR return_no LIKE '%{searchText}%'";
                }
                else
                {
                    bindingSource.Filter = null;
                }
                purRetDataGridView.Refresh();
            }
            catch (Exception)
            {
                bindingSource.Filter = null;
                purRetDataGridView.Refresh();
            }
        }

        private void purRetRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadReturnsData();
            purRetSearchText.Text = string.Empty;
            bindingSource.Filter = null;
            purRetDataGridView.Refresh();
        }

        private void createPurRetBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CreatePurchasesReturn)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            CreatePurchasesReturn createPurchasesReturn = new CreatePurchasesReturn();
            createPurchasesReturn.FormClosed += (s, args) => LoadReturnsData(); // Refresh data after creating a return
            createPurchasesReturn.Show();
        }

        private void purRetFirstBtn_Click(object sender, EventArgs e)
        {
            if (purRetDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                purRetDataGridView.CurrentCell = purRetDataGridView.Rows[currentIndex].Cells[0];
                purRetDataGridView.Rows[currentIndex].Selected = true;
            }
        }

        private void purRetPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                purRetDataGridView.CurrentCell = purRetDataGridView.Rows[currentIndex].Cells[0];
                purRetDataGridView.Rows[currentIndex].Selected = true;
            }
        }

        private void purRetNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < purRetDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                purRetDataGridView.CurrentCell = purRetDataGridView.Rows[currentIndex].Cells[0];
                purRetDataGridView.Rows[currentIndex].Selected = true;
            }
        }

        private void purRetLastBtn_Click(object sender, EventArgs e)
        {
            if (purRetDataGridView.Rows.Count > 0)
            {
                currentIndex = purRetDataGridView.Rows.Count - 1;
                purRetDataGridView.CurrentCell = purRetDataGridView.Rows[currentIndex].Cells[0];
                purRetDataGridView.Rows[currentIndex].Selected = true;
            }
        }

        private void PurRetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            try
            {
                string returnNo = purRetDataGridView.Rows[e.RowIndex].Cells["return_no"].Value?.ToString();
                if (string.IsNullOrEmpty(returnNo)) return;

                int returnId;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id FROM purchase_returns WHERE return_no = @returnNo";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@returnNo", returnNo);
                        object result = cmd.ExecuteScalar();
                        if (result == null || !int.TryParse(result.ToString(), out returnId))
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
                            prd.product_id,
                            p.name AS product_name,
                            prd.variation_type,
                            prd.unit,
                            prd.quantity,
                            prd.cost_price,
                            prd.net_price
                        FROM purchase_return_details prd
                        INNER JOIN products p ON prd.product_id = p.id
                        WHERE prd.return_id = @returnId";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@returnId", returnId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(detailsTable);
                        }
                    }
                }

                Form detailsForm = new Form
                {
                    Text = $"Return Details - {returnNo}",
                    Size = new Size(850, 300), // Increased width to 850
                    StartPosition = FormStartPosition.CenterScreen,
                    BackColor = Color.White,
                    MinimumSize = new Size(850, 300),
                    MaximumSize = new Size(850, 300),
                    MaximizeBox = false,
                    MinimizeBox = false,
                    AutoScroll = false,
                    
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
                    Width = 100 // Increased width
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "product_name",
                    HeaderText = "PRODUCT NAME",
                    Width = 180 // Increased width
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "variation_type",
                    HeaderText = "VARIATION TYPE",
                    Width = 120 // Increased width
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "unit",
                    HeaderText = "UNIT",
                    Width = 100 // Increased width
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "quantity",
                    HeaderText = "QUANTITY",
                    Width = 100 // Increased width
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "cost_price",
                    HeaderText = "COST PRICE",
                    Width = 100, // Increased width
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "net_price",
                    HeaderText = "NET PRICE",
                    Width = 100, // Increased width
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
                // Silently fail as per request to remove MessageBox
            }
        }

        private void PurchasesReturn_Load_1(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            purRetDataGridView.DataSource = null; // Reset to avoid binding issues
            purRetDataGridView.DataSource = bindingSource;
            purRetSearchText.Text = string.Empty; // Clear search filter
            bindingSource.Filter = null; // Ensure no filter is applied
            purRetDataGridView.Refresh();
            purRetDataGridView.Invalidate(); // Force UI redraw
        }
    }
}