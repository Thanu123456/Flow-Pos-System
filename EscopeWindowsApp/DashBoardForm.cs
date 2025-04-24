using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // Add this for Chart control

namespace EscopeWindowsApp
{
    public partial class DashBoardForm : Form
    {
        private DataTable salesTable; // Data source for recent sales
        private DataTable expiryTable; // Data source for expiring products
        private DataTable topCustomersTable; // Data source for top customers
        private BindingSource salesBindingSource; // Binding source for recent sales DataGridView
        private BindingSource expiryBindingSource; // Binding source for expire date alert DataGridView
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private Font gridFont = new Font("Segoe UI", 9F); // Uniform font for DataGridView

        public DashBoardForm()
        {
            InitializeComponent();
            // Disable horizontal scrollbar
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            salesBindingSource = new BindingSource();
            expiryBindingSource = new BindingSource();
            // Attach cell formatting events
            recentDataGridView.CellFormatting += RecentDataGridView_CellFormatting;
            expireDateAlertGridView.CellFormatting += ExpireDateAlertGridView_CellFormatting;
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            ConfigureRecentSalesGridView();
            LoadRecentSales();
            recentDataGridView.DataSource = salesBindingSource;

            ConfigureExpiryAlertGridView();
            LoadExpiringProducts();
            expireDateAlertGridView.DataSource = expiryBindingSource;

            ConfigureTopCustomerPieChart();
            LoadTopCustomers();
        }

        private void ConfigureRecentSalesGridView()
        {
            recentDataGridView.AutoGenerateColumns = false;
            recentDataGridView.Columns.Clear();

            // Define the uniform font
            recentDataGridView.DefaultCellStyle.Font = gridFont; // Set at the grid level
            recentDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Add columns with consistent styling
            recentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "bill_no",
                Name = "bill_no",
                HeaderText = "REFERENCE NO",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            recentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "customer",
                Name = "customer",
                HeaderText = "CUSTOMER",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            recentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "user_name",
                Name = "user_name",
                HeaderText = "USER NAME",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            recentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "quantity_of_items",
                Name = "quantity_of_items",
                HeaderText = "QUANTITY OF ITEMS",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            recentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "payment_method",
                Name = "payment_method",
                HeaderText = "PAYMENT METHOD",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            recentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "total_price",
                Name = "total_price",
                HeaderText = "TOTAL PRICE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "N2" } // Currency format
            });
            recentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sale_date",
                Name = "sale_date",
                HeaderText = "SALE DATE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "yyyy-MM-dd HH:mm:ss" } // Date format
            });

            // Prevent the empty row at the end
            recentDataGridView.AllowUserToAddRows = false;

            // Ensure uniform row height and disable auto-sizing
            recentDataGridView.RowTemplate.Height = 45; // 45 is the best size for this
            recentDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            recentDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            recentDataGridView.ReadOnly = true;
            recentDataGridView.RowHeadersVisible = false;
        }

        private void ConfigureExpiryAlertGridView()
        {
            expireDateAlertGridView.AutoGenerateColumns = false;
            expireDateAlertGridView.Columns.Clear();

            // Define the uniform font
            expireDateAlertGridView.DefaultCellStyle.Font = gridFont;
            expireDateAlertGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Add columns with consistent styling
            expireDateAlertGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_id",
                Name = "product_id",
                HeaderText = "PRODUCT ID",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            expireDateAlertGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                Name = "product_name",
                HeaderText = "PRODUCT NAME",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            expireDateAlertGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_type",
                Name = "variation_type",
                HeaderText = "VARIATION TYPE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            expireDateAlertGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "purchase_date",
                Name = "purchase_date",
                HeaderText = "PURCHASE DATE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "yyyy-MM-dd" } // Display only date
            });
            expireDateAlertGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "expiry_date",
                Name = "expiry_date",
                HeaderText = "EXPIRY DATE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "yyyy-MM-dd" }
            });

            // Prevent the empty row at the end
            expireDateAlertGridView.AllowUserToAddRows = false;

            // Ensure uniform row height and disable auto-sizing
            expireDateAlertGridView.RowTemplate.Height = 45; // 45 is the best size for this
            expireDateAlertGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            expireDateAlertGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            expireDateAlertGridView.ReadOnly = true;
            expireDateAlertGridView.RowHeadersVisible = false;
        }

        private void ConfigureTopCustomerPieChart()
        {
            // Clear any existing series
            topCustomerPieChart.Series.Clear();

            // Add a new series for the pie chart
            Series series = new Series("TopCustomers")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true, // Show values on the pie chart
                LabelFormat = "C2", // Currency format
                Font = new Font("Segoe UI", 9F)
            };
            topCustomerPieChart.Series.Add(series);

            // Customize the chart appearance
            topCustomerPieChart.ChartAreas[0].Area3DStyle.Enable3D = true; // 3D effect
            topCustomerPieChart.Legends.Clear(); // Remove legend for simplicity (optional)
            topCustomerPieChart.Titles.Clear();
            //topCustomerPieChart.Titles.Add(new Title("Top 5 Customers This Month", Docking.Top, new Font("Segoe UI", 12F, FontStyle.Bold), Color.Black));
        }

        private void LoadTopCustomers()
        {
            try
            {
                topCustomersTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Query to get the total purchases by customer for the current month
                    string query = @"
                        SELECT 
                            CASE 
                                WHEN customer = 'Walk-In Customer' THEN 'Walk-In Customer'
                                ELSE customer 
                            END AS customer_name,
                            SUM(total_price) AS total_spent
                        FROM sales
                        WHERE YEAR(sale_date) = YEAR(CURDATE())
                        AND MONTH(sale_date) = MONTH(CURDATE())
                        GROUP BY customer_name
                        ORDER BY total_spent DESC
                        LIMIT 5";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(topCustomersTable);
                    }
                }

                // Clear existing data points
                topCustomerPieChart.Series["TopCustomers"].Points.Clear();

                // Add data points to the pie chart
                foreach (DataRow row in topCustomersTable.Rows)
                {
                    string customerName = row["customer_name"].ToString();
                    decimal totalSpent = Convert.ToDecimal(row["total_spent"]);
                    topCustomerPieChart.Series["TopCustomers"].Points.AddXY(customerName, totalSpent);
                }

                // Customize data point labels to show customer name and amount
                foreach (DataPoint point in topCustomerPieChart.Series["TopCustomers"].Points)
                {
                    point.Label = $"{point.AxisLabel}\n{point.YValues[0]:C2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading top customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                topCustomersTable = new DataTable();
                topCustomersTable.Columns.Add("customer_name", typeof(string));
                topCustomersTable.Columns.Add("total_spent", typeof(decimal));
            }
        }

        private void LoadRecentSales()
        {
            try
            {
                salesTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Query to fetch the last 8 sales ordered by sale_date descending
                    string query = "SELECT bill_no, customer, user_name, quantity_of_items, payment_method, total_price, sale_date FROM sales ORDER BY sale_date DESC LIMIT 7";
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

                salesBindingSource.DataSource = salesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recent sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                salesTable = new DataTable();
                salesTable.Columns.Add("bill_no", typeof(string));
                salesTable.Columns.Add("customer", typeof(string));
                salesTable.Columns.Add("user_name", typeof(string));
                salesTable.Columns.Add("quantity_of_items", typeof(int));
                salesTable.Columns.Add("payment_method", typeof(string));
                salesTable.Columns.Add("total_price", typeof(decimal));
                salesTable.Columns.Add("sale_date", typeof(DateTime));
                salesBindingSource.DataSource = salesTable;
            }
        }

        private void LoadExpiringProducts()
        {
            try
            {
                expiryTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // Query to fetch products expiring within the next 14 days
                    string query = @"
                        SELECT 
                            gi.product_id,
                            p.name AS product_name,
                            gi.variation_type,
                            g.date AS purchase_date,
                            gi.expiry_date
                        FROM grn_items gi
                        INNER JOIN grn g ON gi.grn_id = g.id
                        INNER JOIN products p ON gi.product_id = p.id
                        WHERE gi.expiry_date IS NOT NULL
                        AND gi.expiry_date BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 14 DAY)
                        ORDER BY gi.expiry_date ASC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(expiryTable);
                    }
                }

                // Replace DBNull with default values
                foreach (DataRow row in expiryTable.Rows)
                {
                    for (int i = 0; i < expiryTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (expiryTable.Columns[i].DataType == typeof(string))
                            {
                                row[i] = "N/A";
                            }
                            else if (expiryTable.Columns[i].DataType == typeof(DateTime))
                            {
                                row[i] = DateTime.MinValue;
                            }
                            else if (expiryTable.Columns[i].DataType == typeof(int))
                            {
                                row[i] = 0;
                            }
                        }
                    }
                }

                expiryBindingSource.DataSource = expiryTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expiring products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expiryTable = new DataTable();
                expiryTable.Columns.Add("product_id", typeof(int));
                expiryTable.Columns.Add("product_name", typeof(string));
                expiryTable.Columns.Add("variation_type", typeof(string));
                expiryTable.Columns.Add("purchase_date", typeof(DateTime));
                expiryTable.Columns.Add("expiry_date", typeof(DateTime));
                expiryBindingSource.DataSource = expiryTable;
            }
        }

        private void RecentDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Enforce the font for every cell during formatting
            e.CellStyle.Font = gridFont; // Ensure the font is applied consistently

            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
            else if (recentDataGridView.Columns[e.ColumnIndex].Name == "bill_no")
            {
                e.Value = e.Value.ToString();
                e.FormattingApplied = true;
            }
        }

        private void ExpireDateAlertGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Enforce the font for every cell during formatting
            e.CellStyle.Font = gridFont;

            // Highlight expiry_date in red
            if (expireDateAlertGridView.Columns[e.ColumnIndex].Name == "expiry_date")
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.Red; // Ensure visibility when selected
            }

            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }

        private void recentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row and not the header
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = recentDataGridView.Rows[e.RowIndex];

                // Extract data from the row
                string billNo = row.Cells["bill_no"].Value?.ToString() ?? "N/A";
                string customerName = row.Cells["customer"].Value?.ToString() ?? "N/A";
                string cashierName = row.Cells["user_name"].Value?.ToString() ?? "N/A";
                int quantity = row.Cells["quantity_of_items"].Value != null ? Convert.ToInt32(row.Cells["quantity_of_items"].Value) : 0;
                string paymentMethod = row.Cells["payment_method"].Value?.ToString() ?? "N/A";
                decimal totalPrice = row.Cells["total_price"].Value != null ? Convert.ToDecimal(row.Cells["total_price"].Value) : 0.00m;
                DateTime saleDate = row.Cells["sale_date"].Value != null && row.Cells["sale_date"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["sale_date"].Value)
                    : DateTime.MinValue;

                // Show sale details in a message box
                string message = $"Reference No: {billNo}\n" +
                                $"Customer: {customerName}\n" +
                                $"Cashier: {cashierName}\n" +
                                $"Quantity: {quantity}\n" +
                                $"Payment Method: {paymentMethod}\n" +
                                $"Total Price: {totalPrice:N2}\n" +
                                $"Sale Date: {(saleDate == DateTime.MinValue ? "N/A" : saleDate.ToString("yyyy-MM-dd HH:mm:ss"))}";
                MessageBox.Show(message, "Sale Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optional: Open a new form to display detailed sale information
                // Example: SaleDetailsForm detailsForm = new SaleDetailsForm(billNo);
                // detailsForm.ShowDialog();
            }
        }

        private void expireDateAlertGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row and not the header
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = expireDateAlertGridView.Rows[e.RowIndex];

                // Extract data from the row
                int productId = row.Cells["product_id"].Value != null ? Convert.ToInt32(row.Cells["product_id"].Value) : 0;
                string productName = row.Cells["product_name"].Value?.ToString() ?? "N/A";
                string variationType = row.Cells["variation_type"].Value?.ToString() ?? "N/A";
                DateTime purchaseDate = row.Cells["purchase_date"].Value != null && row.Cells["purchase_date"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["purchase_date"].Value)
                    : DateTime.MinValue;
                DateTime expiryDate = row.Cells["expiry_date"].Value != null && row.Cells["expiry_date"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["expiry_date"].Value)
                    : DateTime.MinValue;

                // Show product details in a message box
                string message = $"Product ID: {productId}\n" +
                                $"Product Name: {productName}\n" +
                                $"Variation Type: {variationType}\n" +
                                $"Purchase Date: {(purchaseDate == DateTime.MinValue ? "N/A" : purchaseDate.ToString("yyyy-MM-dd"))}\n" +
                                $"Expiry Date: {(expiryDate == DateTime.MinValue ? "N/A" : expiryDate.ToString("yyyy-MM-dd"))}";
                MessageBox.Show(message, "Expiring Product Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void topCustomerPieChart_Click(object sender, EventArgs e)
        {
            // Display details of the top customers in a message box
            if (topCustomersTable == null || topCustomersTable.Rows.Count == 0)
            {
                MessageBox.Show("No data available for top customers this month.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder message = new StringBuilder("Top 5 Customers This Month:\n\n");
            foreach (DataRow row in topCustomersTable.Rows)
            {
                string customerName = row["customer_name"].ToString();
                decimal totalSpent = Convert.ToDecimal(row["total_spent"]);
                message.AppendLine($"{customerName}: {totalSpent:C2}");
            }

            MessageBox.Show(message.ToString(), "Top Customers Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numberOrderLabel_Click(object sender, EventArgs e)
        {
        }

        private void grossRevenueChart_Click(object sender, EventArgs e)
        {
        }

        private void topProductsPieChart_Click(object sender, EventArgs e)
        {
        }

        private void numberTrevenueLabel_Click(object sender, EventArgs e)
        {
        }

        private void last7DaysBtn_Click(object sender, EventArgs e)
        {
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tNOCLabel_Click(object sender, EventArgs e)
        {
        }

        private void tNOPLabel_Click(object sender, EventArgs e)
        {
        }

        private void dashTotPurPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dashTotSalePriceLabel_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void thisYearBtn_Click(object sender, EventArgs e)
        {
        }
    }
}