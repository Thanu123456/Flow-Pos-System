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
        }

        private void PurchasesReturn_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            purRetDataGridView.DataSource = bindingSource;
            purRetSearchText.Text = string.Empty; // Clear search filter
            purRetDataGridView.Refresh(); // Force UI redraw
            MessageBox.Show($"DataGridView Rows: {purRetDataGridView.Rows.Count}", "Debug Info");
        }

        private void ConfigureDataGridView()
        {
            purRetDataGridView.AutoGenerateColumns = false;
            purRetDataGridView.Columns.Clear();

            // Define columns matching purchase_returns table
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
                DataPropertyName = "created_at",
                Name = "created_at",
                HeaderText = "CREATED DATE",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }
            });

            // Styling and behavior
            purRetDataGridView.AllowUserToAddRows = false;
            purRetDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            purRetDataGridView.RowTemplate.Height = 35;
            purRetDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            purRetDataGridView.BackgroundColor = Color.White; // Ensure visibility
        }

        private void LoadReturnsData()
        {
            try
            {
                returnsTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Test connection
                    connection.Open();
                    MessageBox.Show("Database connection successful!", "Debug Info");

                    string query = @"
                        SELECT 
                            grn_no,
                            return_no,
                            note,
                            total_amount,
                            created_at
                        FROM purchase_returns
                        ORDER BY created_at DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(returnsTable);
                    }
                }

                // Handle null values
                foreach (DataRow row in returnsTable.Rows)
                {
                    for (int i = 0; i < returnsTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (returnsTable.Columns[i].DataType == typeof(string))
                                row[i] = "";
                            else if (returnsTable.Columns[i].DataType == typeof(DateTime))
                                row[i] = DateTime.Now;
                            else if (returnsTable.Columns[i].DataType == typeof(decimal))
                                row[i] = 0.00m;
                        }
                    }
                }

                bindingSource.DataSource = returnsTable;

                // Debug: Show row count
                MessageBox.Show($"Loaded {returnsTable.Rows.Count} rows into DataTable", "Debug Info");
                if (returnsTable.Rows.Count == 0)
                {
                    MessageBox.Show("No records found in purchase_returns table. Adding dummy data.", "Information");
                    returnsTable.Rows.Add("GRN001", "RET001", "Test return", 100.00m, DateTime.Now);
                    bindingSource.DataSource = returnsTable; // Rebind with dummy data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Fallback: Create DataTable with dummy data
                returnsTable = new DataTable();
                returnsTable.Columns.Add("grn_no", typeof(string));
                returnsTable.Columns.Add("return_no", typeof(string));
                returnsTable.Columns.Add("note", typeof(string));
                returnsTable.Columns.Add("total_amount", typeof(decimal));
                returnsTable.Columns.Add("created_at", typeof(DateTime));
                returnsTable.Rows.Add("GRN_ERR", "RET_ERR", "Error fallback", 999.99m, DateTime.Now);
                bindingSource.DataSource = returnsTable;
                MessageBox.Show("Added dummy data due to error", "Debug Info");
            }
        }

        private void PurRetDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

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
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bindingSource.Filter = null;
            }
        }

        private void purRetRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadReturnsData();
            purRetSearchText.Text = string.Empty;
            bindingSource.Filter = null;
            purRetDataGridView.Refresh();
            MessageBox.Show($"Refreshed. DataGridView Rows: {purRetDataGridView.Rows.Count}", "Debug Info");
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
            createPurchasesReturn.Show();
        }

        private void purRetFirstBtn_Click(object sender, EventArgs e)
        {
            if (purRetDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                purRetDataGridView.CurrentCell = purRetDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void purRetPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                purRetDataGridView.CurrentCell = purRetDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void purRetNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < purRetDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                purRetDataGridView.CurrentCell = purRetDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void purRetLastBtn_Click(object sender, EventArgs e)
        {
            if (purRetDataGridView.Rows.Count > 0)
            {
                currentIndex = purRetDataGridView.Rows.Count - 1;
                purRetDataGridView.CurrentCell = purRetDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void purRetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                            MessageBox.Show("Unable to retrieve return details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Size = new Size(600, 400),
                    StartPosition = FormStartPosition.CenterParent
                };

                DataGridView detailsGrid = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    AutoGenerateColumns = false,
                    AllowUserToAddRows = false,
                    RowTemplate = { Height = 35 },
                    ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F, FontStyle.Bold) }
                };

                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "product_id",
                    HeaderText = "PRODUCT ID",
                    Width = 80
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "product_name",
                    HeaderText = "PRODUCT NAME",
                    Width = 150
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "variation_type",
                    HeaderText = "VARIATION TYPE",
                    Width = 100
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "unit",
                    HeaderText = "UNIT",
                    Width = 80
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "quantity",
                    HeaderText = "QUANTITY",
                    Width = 80
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "cost_price",
                    HeaderText = "COST PRICE",
                    Width = 80,
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
                });
                detailsGrid.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "net_price",
                    HeaderText = "NET PRICE",
                    Width = 80,
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}