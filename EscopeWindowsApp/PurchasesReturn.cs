using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EscopeWindowsApp
{
    public partial class PurchasesReturn : Form
    {
        private DataTable returnsTable;
        private BindingSource bindingSource;
        private int currentIndex = 0;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"]?.ConnectionString;

        public PurchasesReturn()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            filterResonsPurchasReturnCombo.Items.AddRange(new string[] { "All Reasons", "Product Damaged or Defective", "Product Not as Described or Expected", "Expired Products", "Other" });
            filterResonsPurchasReturnCombo.SelectedIndex = 0;
            LoadReturnsData();
            purRetDataGridView.CellFormatting += PurRetDataGridView_CellFormatting;
            purRetDataGridView.CellDoubleClick += PurRetDataGridView_CellContentClick;
            purRetDataGridView.CellClick += PurRetDataGridView_CellClick; // Added for edit functionality
            this.Load += new System.EventHandler(this.PurchasesReturn_Load);
        }

        private void PurchasesReturn_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            purRetDataGridView.DataSource = null;
            purRetDataGridView.DataSource = bindingSource;
            purRetSearchText.Text = string.Empty;
            bindingSource.Filter = null;
            purRetDataGridView.Refresh();
            purRetDataGridView.Invalidate();
        }

        private void ConfigureDataGridView()
        {
            purRetDataGridView.AutoGenerateColumns = false;
            purRetDataGridView.Columns.Clear();

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
                DataPropertyName = "reason",
                Name = "reason",
                HeaderText = "REASON",
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
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "F2" }
            });
            purRetDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "created_at",
                Name = "created_at",
                HeaderText = "CREATED DATE",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }
            });
            purRetDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "status",
                Name = "status",
                HeaderText = "STATUS",
                Width = 100
            });
            DataGridViewImageColumn editColumn = new DataGridViewImageColumn
            {
                Name = "edit",
                HeaderText = "EDIT",
                Width = 50,
                Image = Properties.Resources.edit, // Ensure you have an edit icon in resources
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            purRetDataGridView.Columns.Add(editColumn);

            purRetDataGridView.AllowUserToAddRows = false;
            purRetDataGridView.ReadOnly = true;
            purRetDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            purRetDataGridView.RowTemplate.Height = 35;
            purRetDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            purRetDataGridView.BackgroundColor = Color.White;
            purRetDataGridView.BorderStyle = BorderStyle.None;
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
                            pr.id,
                            pr.grn_no,
                            pr.return_no,
                            pr.reason,
                            pr.total_amount,
                            (SELECT SUM(prd.quantity) 
                             FROM purchase_return_details prd 
                             WHERE prd.return_id = pr.id) AS return_qty,
                            pr.created_at,
                            pr.status
                        FROM purchase_returns pr
                        ORDER BY pr.created_at DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(returnsTable);
                    }
                }

                foreach (DataRow row in returnsTable.Rows)
                {
                    row["id"] = row["id"] ?? 0;
                    row["grn_no"] = row["grn_no"] ?? "";
                    row["return_no"] = row["return_no"] ?? "";
                    row["reason"] = row["reason"] ?? "N/A";
                    row["total_amount"] = row["total_amount"] ?? 0.00m;
                    row["return_qty"] = row["return_qty"] ?? 0.0m;
                    row["created_at"] = row["created_at"] ?? DateTime.Now;
                    row["status"] = row["status"] ?? "Pending";
                }

                bindingSource.DataSource = returnsTable;
                purRetDataGridView.DataSource = null;
                purRetDataGridView.DataSource = bindingSource;
                purRetDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading returns data: {ex.Message}");
                returnsTable = new DataTable();
                returnsTable.Columns.Add("id", typeof(int));
                returnsTable.Columns.Add("grn_no", typeof(string));
                returnsTable.Columns.Add("return_no", typeof(string));
                returnsTable.Columns.Add("reason", typeof(string));
                returnsTable.Columns.Add("total_amount", typeof(decimal));
                returnsTable.Columns.Add("return_qty", typeof(decimal));
                returnsTable.Columns.Add("created_at", typeof(DateTime));
                returnsTable.Columns.Add("status", typeof(string));
                bindingSource.DataSource = returnsTable;
                purRetDataGridView.DataSource = bindingSource;
            }
        }

        private void PurRetDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = purRetDataGridView.Rows[e.RowIndex];
            string status = row.Cells["status"].Value?.ToString();

            if (purRetDataGridView.Columns[e.ColumnIndex].Name == "total_amount")
            {
                if (status == "Pending")
                {
                    e.Value = "Pending";
                    e.FormattingApplied = true;
                }
                else if (e.Value == null || e.Value == DBNull.Value)
                {
                    e.Value = "0.00";
                    e.FormattingApplied = true;
                }
            }
            else if (purRetDataGridView.Columns[e.ColumnIndex].Name == "return_qty")
            {
                if (e.Value == null || e.Value == DBNull.Value)
                {
                    e.Value = "0.00";
                    e.FormattingApplied = true;
                }
                else if (decimal.TryParse(e.Value.ToString(), out decimal qty))
                {
                    e.Value = qty.ToString("F2");
                    e.FormattingApplied = true;
                }
            }
            else if (e.Value == null || e.Value == DBNull.Value)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }

        private void PurRetDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && purRetDataGridView.Columns[e.ColumnIndex].Name == "edit")
            {
                DataRowView rowView = (DataRowView)purRetDataGridView.Rows[e.RowIndex].DataBoundItem;
                int returnId = Convert.ToInt32(rowView["id"]);
                OpenEditForm(returnId);
            }
        }

        private void OpenEditForm(int returnId)
        {
            CreatePurchasesReturn editForm = new CreatePurchasesReturn(returnId);
            editForm.FormClosed += (s, args) => LoadReturnsData();
            editForm.Show();
        }

        private void PurRetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Existing double-click details view logic remains unchanged
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
                    Size = new Size(850, 300),
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
                // Silent failure as per original design
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
            filterResonsPurchasReturnCombo.SelectedIndex = 0;
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
            createPurchasesReturn.FormClosed += (s, args) => LoadReturnsData();
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

        private void filterResonsPurchasReturnCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedReason = filterResonsPurchasReturnCombo.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedReason) || selectedReason == "All Reasons")
                {
                    bindingSource.Filter = null;
                }
                else
                {
                    bindingSource.Filter = $"reason = '{selectedReason}'";
                }

                if (purRetDataGridView.Rows.Count > 0)
                {
                    currentIndex = 0;
                    purRetDataGridView.CurrentCell = purRetDataGridView.Rows[currentIndex].Cells[0];
                    purRetDataGridView.Rows[currentIndex].Selected = true;
                }
                purRetDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying reason filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
                purRetDataGridView.Refresh();
            }
        }
    }
}