using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class PurchasesForm : Form
    {
        private DataTable purchasesTable; // Data source for purchases
        private BindingSource bindingSource; // Binding source for filtering
        private int currentIndex = 0; // Current index for navigation
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        

        public PurchasesForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadPurchasesData();
            purDataGridView.CellFormatting += PurDataGridView_CellFormatting;
        }

        private void PurchasesForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            purDataGridView.DataSource = bindingSource;

            // Populate filterPurDateCombo with date options
            filterPurDateCombo.Items.Clear();
            filterPurDateCombo.Items.AddRange(new string[] { "Select Date", "TODAY", "THIS WEEK", "THIS MONTH", "THIS YEAR" });
            filterPurDateCombo.SelectedIndex = 0; // Default to "Select Date"
        }

        private void ConfigureDataGridView()
        {
            purDataGridView.AutoGenerateColumns = false;
            purDataGridView.Columns.Clear();

            // Add columns with consistent styling, preserving original design
            purDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_id",
                Name = "product_id",
                HeaderText = "PRODUCT ID",
                
            });
            purDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                Name = "product_name",
                HeaderText = "PRODUCT NAME",
                
            });
            purDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "brand_name",
                Name = "brand_name",
                HeaderText = "BRAND NAME",
               
            });
            purDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_type",
                Name = "variation_type",
                HeaderText = "VARIATION TYPE",
                
            });
            purDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit",
                Name = "unit",
                HeaderText = "UNIT",
                
            });
            purDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "quantity",
                Name = "quantity",
                HeaderText = "QUANTITY",
                
            });
            purDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "payment_method",
                Name = "payment_method",
                HeaderText = "PAYMENT METHOD",
                
            });
            purDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "net_price",
                Name = "net_price",
                HeaderText = "TOTAL COST",
               
            });
            purDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "date",
                Name = "date",
                HeaderText = "DATE",
                
            });

            // Prevent the empty row at the end
            purDataGridView.AllowUserToAddRows = false;

            // Set column headers font and ensure consistent row styling
            purDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
           
            purDataGridView.RowTemplate.Height = 35; // Ensure uniform row height
            purDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; // Prevent auto-resizing
        }

        private void LoadPurchasesData()
        {
            try
            {
                purchasesTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            gi.product_id,
                            p.name AS product_name,
                            b.name AS brand_name,
                            gi.variation_type,
                            gi.unit,
                            gi.quantity,
                            g.payment_method,
                            gi.net_price,
                            g.date
                        FROM grn_items gi
                        INNER JOIN grn g ON gi.grn_id = g.id
                        INNER JOIN products p ON gi.product_id = p.id
                        INNER JOIN brands b ON p.brand_id = b.id
                        ORDER BY g.date DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(purchasesTable);
                    }
                }

                // Replace DBNull with default values
                foreach (DataRow row in purchasesTable.Rows)
                {
                    for (int i = 0; i < purchasesTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (purchasesTable.Columns[i].DataType == typeof(string))
                            {
                                row[i] = "";
                            }
                            else if (purchasesTable.Columns[i].DataType == typeof(DateTime))
                            {
                                row[i] = DateTime.MinValue;
                            }
                            else if (purchasesTable.Columns[i].DataType == typeof(decimal))
                            {
                                row[i] = 0.00m;
                            }
                            else if (purchasesTable.Columns[i].DataType == typeof(int))
                            {
                                row[i] = 0;
                            }
                        }
                    }
                }

                bindingSource.DataSource = purchasesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading purchases: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                purchasesTable = new DataTable();
                purchasesTable.Columns.Add("product_id", typeof(int));
                purchasesTable.Columns.Add("product_name", typeof(string));
                purchasesTable.Columns.Add("brand_name", typeof(string));
                purchasesTable.Columns.Add("variation_type", typeof(string));
                purchasesTable.Columns.Add("unit", typeof(string));
                purchasesTable.Columns.Add("quantity", typeof(decimal));
                purchasesTable.Columns.Add("payment_method", typeof(string));
                purchasesTable.Columns.Add("net_price", typeof(decimal));
                purchasesTable.Columns.Add("date", typeof(DateTime));
                bindingSource.DataSource = purchasesTable;
            }
        }

        private void PurDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Explicitly set the font for every cell to ensure consistency
           

            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
            else if (purDataGridView.Columns[e.ColumnIndex].Name == "product_id")
            {
                // Format product_id as "PRO" followed by zero-padded number (e.g., PRO001)
                if (int.TryParse(e.Value.ToString(), out int id))
                {
                    e.Value = $"PRO{id:D3}";
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "N/A";
                    e.FormattingApplied = true;
                }
            }
            else if (purDataGridView.Columns[e.ColumnIndex].Name == "variation_type")
            {
                // Display "N/A" if variation_type is empty or whitespace
                string value = e.Value.ToString().Trim();
                e.Value = string.IsNullOrWhiteSpace(value) ? "N/A" : value;
                e.FormattingApplied = true;
            }
        }

        private void purSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = purSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    // Handle product_id search: support both "PRO001" and numeric "1"
                    string productIdFilter = searchText;
                    if (searchText.StartsWith("pro", StringComparison.OrdinalIgnoreCase))
                    {
                        // Extract numeric part from "PRO001"
                        string numericPart = searchText.Substring(3); // Remove "pro"
                        if (int.TryParse(numericPart, out int id))
                        {
                            productIdFilter = id.ToString();
                        }
                    }

                    // Escape single quotes in search text to prevent SQL-like syntax errors
                    searchText = searchText.Replace("'", "''");

                    bindingSource.Filter = $@"product_name LIKE '%{searchText}%' OR 
                                            product_id = '{productIdFilter}' OR 
                                            payment_method LIKE '%{searchText}%'";
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

        private void purRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadPurchasesData(); // Reload data from the database
            purSearchText.Text = string.Empty; // Clear search text
            filterPurDateCombo.SelectedIndex = 0; // Reset to "Select Date"
            bindingSource.Filter = null; // Remove any filters
        }

        private void filterPurDateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // If "Select Date" is selected, show all data
                if (filterPurDateCombo.SelectedIndex == 0) // "Select Date"
                {
                    bindingSource.Filter = null;
                    return;
                }

                DateTime now = DateTime.Now;
                string filter = string.Empty;

                switch (filterPurDateCombo.SelectedItem.ToString())
                {
                    case "TODAY":
                        filter = $"date >= '{now.ToString("yyyy-MM-dd 00:00:00")}' AND date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                    case "THIS WEEK":
                        DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek); // Sunday as start
                        filter = $"date >= '{startOfWeek.ToString("yyyy-MM-dd 00:00:00")}' AND date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                    case "THIS MONTH":
                        DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
                        filter = $"date >= '{startOfMonth.ToString("yyyy-MM-dd 00:00:00")}' AND date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                    case "THIS YEAR":
                        DateTime startOfYear = new DateTime(now.Year, 1, 1);
                        filter = $"date >= '{startOfYear.ToString("yyyy-MM-dd 00:00:00")}' AND date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
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

        private void purFirstBtn_Click(object sender, EventArgs e)
        {
            if (purDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                purDataGridView.CurrentCell = purDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void purPrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                purDataGridView.CurrentCell = purDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void purNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < purDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                purDataGridView.CurrentCell = purDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void purLastBtn_Click(object sender, EventArgs e)
        {
            if (purDataGridView.Rows.Count > 0)
            {
                currentIndex = purDataGridView.Rows.Count - 1;
                purDataGridView.CurrentCell = purDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void purDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell clicks if specific actions are needed (e.g., view details)
        }
    }
}