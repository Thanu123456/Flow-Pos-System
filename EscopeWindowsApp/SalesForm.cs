using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class SalesForm : Form
    {
        private DataTable salesTable; // Data source for sales
        private BindingSource bindingSource; // Binding source for filtering
        private int currentIndex = 0; // Current index for navigation
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private Font gridFont = new Font("Segoe UI", 9F); // Uniform font for DataGridView

        public SalesForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadSalesData();
            saleDataGridView.CellFormatting += SaleDataGridView_CellFormatting;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            saleDataGridView.DataSource = bindingSource;

            // Populate filterSaleDateCombo with date options
            filterSaleDateCombo.Items.Clear();
            filterSaleDateCombo.Items.AddRange(new string[] { "Select Date", "TODAY", "THIS WEEK", "LAST WEEK", "THIS MONTH" });
            filterSaleDateCombo.SelectedIndex = 0; // Default to "Select Date"
        }

        private void ConfigureDataGridView()
        {
            saleDataGridView.AutoGenerateColumns = false;
            saleDataGridView.Columns.Clear();

            // Add columns with consistent styling
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "bill_no",
                Name = "bill_no",
                HeaderText = "REFERENCE NO",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "customer",
                Name = "customer",
                HeaderText = "CUSTOMER",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "user_name",
                Name = "user_name",
                HeaderText = "USER NAME",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "quantity_of_items",
                Name = "quantity_of_items",
                HeaderText = "QUANTITY OF ITEMS",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "payment_method",
                Name = "payment_method",
                HeaderText = "PAYMENT METHOD",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "total_price",
                Name = "total_price",
                HeaderText = "TOTAL PRICE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "N2" } // Currency format
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sale_date",
                Name = "sale_date",
                HeaderText = "SALE DATE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "yyyy-MM-dd HH:mm:ss" } // Date format
            });

            // Prevent the empty row at the end
            saleDataGridView.AllowUserToAddRows = false;

            // Set column headers font
            saleDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            saleDataGridView.DefaultCellStyle.Font = gridFont;
        }

        private void LoadSalesData()
        {
            try
            {
                salesTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT bill_no, customer, user_name, quantity_of_items, payment_method, total_price, sale_date FROM sales ORDER BY sale_date DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(salesTable);
                    }
                }

                // Replace DBNull with default values
                foreach (DataRow row in salesTable.Rows)
                {
                    for (int i = 0; i < salesTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (salesTable.Columns[i].DataType == typeof(string))
                            {
                                row[i] = "";
                            }
                            else if (salesTable.Columns[i].DataType == typeof(DateTime))
                            {
                                row[i] = DateTime.MinValue;
                            }
                            else if (salesTable.Columns[i].DataType == typeof(decimal))
                            {
                                row[i] = 0.00m;
                            }
                            else if (salesTable.Columns[i].DataType == typeof(int))
                            {
                                row[i] = 0;
                            }
                        }
                    }
                }

                bindingSource.DataSource = salesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                salesTable = new DataTable();
                salesTable.Columns.Add("bill_no", typeof(string));
                salesTable.Columns.Add("customer", typeof(string));
                salesTable.Columns.Add("user_name", typeof(string));
                salesTable.Columns.Add("quantity_of_items", typeof(int));
                salesTable.Columns.Add("payment_method", typeof(string));
                salesTable.Columns.Add("total_price", typeof(decimal));
                salesTable.Columns.Add("sale_date", typeof(DateTime));
                bindingSource.DataSource = salesTable;
            }
        }

        private void SaleDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
            else if (saleDataGridView.Columns[e.ColumnIndex].Name == "bill_no")
            {
                e.Value = e.Value.ToString();
                e.FormattingApplied = true;
            }
        }

        private void saleSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = saleSearchText.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchText))
                {
                    bindingSource.Filter = $"customer LIKE '%{searchText}%' OR bill_no LIKE '%{searchText}%'";
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

        private void saleFirstBtn_Click(object sender, EventArgs e)
        {
            if (saleDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void salePrevBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleNextBtn_Click(object sender, EventArgs e)
        {
            if (currentIndex < saleDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleLastBtn_Click(object sender, EventArgs e)
        {
            if (saleDataGridView.Rows.Count > 0)
            {
                currentIndex = saleDataGridView.Rows.Count - 1;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void salesRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadSalesData(); // Reload data from the database
            saleSearchText.Text = string.Empty; // Clear search text
            filterSaleDateCombo.SelectedIndex = 0; // Reset to "Select Date"
            bindingSource.Filter = null; // Remove any filters
        }

        private void filterSaleDateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // If "Select Date" is selected, show all data
                if (filterSaleDateCombo.SelectedIndex == 0) // "Select Date"
                {
                    bindingSource.Filter = null;
                    return;
                }

                DateTime now = DateTime.Now;
                string filter = string.Empty;

                switch (filterSaleDateCombo.SelectedItem.ToString())
                {
                    case "TODAY":
                        filter = $"sale_date >= '{now.ToString("yyyy-MM-dd 00:00:00")}' AND sale_date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                    case "THIS WEEK":
                        DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek); // Sunday as start
                        filter = $"sale_date >= '{startOfWeek.ToString("yyyy-MM-dd 00:00:00")}' AND sale_date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                    case "LAST WEEK":
                        DateTime lastWeekStart = now.AddDays(-(int)now.DayOfWeek - 7);
                        DateTime lastWeekEnd = lastWeekStart.AddDays(6);
                        filter = $"sale_date >= '{lastWeekStart.ToString("yyyy-MM-dd 00:00:00")}' AND sale_date <= '{lastWeekEnd.ToString("yyyy-MM-dd 23:59:59")}'";
                        break;
                    case "THIS MONTH":
                        DateTime startOfMonth = new DateTime(now.Year, now.Month, 1);
                        filter = $"sale_date >= '{startOfMonth.ToString("yyyy-MM-dd 00:00:00")}' AND sale_date <= '{now.ToString("yyyy-MM-dd 23:59:59")}'";
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
    }
}