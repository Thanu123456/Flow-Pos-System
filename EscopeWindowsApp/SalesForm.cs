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

        public SalesForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            LoadSalesData();
            // Explicitly wire events
            saleDataGridView.CellFormatting += SaleDataGridView_CellFormatting;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            saleDataGridView.DataSource = bindingSource;
        }

        private void ConfigureDataGridView()
        {
            saleDataGridView.AutoGenerateColumns = false;
            saleDataGridView.Columns.Clear();

            // Add columns based on the sales table structure
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "bill_no",
                Name = "bill_no",
                HeaderText = "REFERENCE NO"
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "customer",
                Name = "customer",
                HeaderText = "CUSTOMER"
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "user_name",
                Name = "user_name",
                HeaderText = "USER NAME"
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "quantity_of_items",
                Name = "quantity_of_items",
                HeaderText = "QUANTITY OF ITEMS"
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "payment_method",
                Name = "payment_method",
                HeaderText = "PAYMENT METHOD"
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "total_price",
                Name = "total_price",
                HeaderText = "TOTAL PRICE",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } // Format as currency
            });
            saleDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sale_date",
                Name = "sale_date",
                HeaderText = "SALE DATE"
            });

            // Prevent the empty row at the end
            saleDataGridView.AllowUserToAddRows = false;
        }

        private void SaleDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Format the bill_no to ensure consistency
            if (saleDataGridView.Columns[e.ColumnIndex].Name == "bill_no")
            {
                if (e.Value != null)
                {
                    e.Value = e.Value.ToString(); // Already in BILLyyyyMMddHHmmss format
                    e.FormattingApplied = true;
                }
            }
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

        private void saleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No action needed since we are not adding Edit or Delete columns
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

        private void saleFilterBtn_Click(object sender, EventArgs e)
        {
            // Empty method as requested
        }

        private void saleDataComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Empty method as requested
        }

        private void saleFirstBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the first sale
            if (saleDataGridView.Rows.Count > 0)
            {
                currentIndex = 0;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void salePrevBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the previous sale
            if (currentIndex > 0)
            {
                currentIndex--;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleNextBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the next sale
            if (currentIndex < saleDataGridView.Rows.Count - 1)
            {
                currentIndex++;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }

        private void saleLastBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the last sale
            if (saleDataGridView.Rows.Count > 0)
            {
                currentIndex = saleDataGridView.Rows.Count - 1;
                saleDataGridView.CurrentCell = saleDataGridView.Rows[currentIndex].Cells[0];
            }
        }
    }
}