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
using System.Windows.Forms.DataVisualization.Charting;

namespace EscopeWindowsApp
{
    public partial class DashBoardForm : Form
    {
        private DataTable salesTable;
        private DataTable expiryTable;
        private DataTable topCustomersTable;
        private DataTable topExpensesTable;
        private BindingSource salesBindingSource;
        private BindingSource expiryBindingSource;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private Font gridFont = new Font("Segoe UI", 9F);

        public DashBoardForm()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            salesBindingSource = new BindingSource();
            expiryBindingSource = new BindingSource();
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

            ConfigureTopExpensesDoughnutChart();
            LoadTopExpenses();

            ConfigureSalesPurchColumnChart();
            LoadSalesPurchData();
        }

        private void ConfigureRecentSalesGridView()
        {
            recentDataGridView.AutoGenerateColumns = false;
            recentDataGridView.Columns.Clear();
            recentDataGridView.DefaultCellStyle.Font = gridFont;
            recentDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

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
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "N2" }
            });
            recentDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "sale_date",
                Name = "sale_date",
                HeaderText = "SALE DATE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "yyyy-MM-dd HH:mm:ss" }
            });

            recentDataGridView.AllowUserToAddRows = false;
            recentDataGridView.RowTemplate.Height = 45;
            recentDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            recentDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            recentDataGridView.ReadOnly = true;
            recentDataGridView.RowHeadersVisible = false;
        }

        private void ConfigureExpiryAlertGridView()
        {
            expireDateAlertGridView.AutoGenerateColumns = false;
            expireDateAlertGridView.Columns.Clear();
            expireDateAlertGridView.DefaultCellStyle.Font = gridFont;
            expireDateAlertGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

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
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "yyyy-MM-dd" }
            });
            expireDateAlertGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "expiry_date",
                Name = "expiry_date",
                HeaderText = "EXPIRY DATE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont, Format = "yyyy-MM-dd" }
            });

            expireDateAlertGridView.AllowUserToAddRows = false;
            expireDateAlertGridView.RowTemplate.Height = 45;
            expireDateAlertGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            expireDateAlertGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            expireDateAlertGridView.ReadOnly = true;
            expireDateAlertGridView.RowHeadersVisible = false;
        }

        private void ConfigureTopCustomerPieChart()
        {
            topCustomerPieChart.Series.Clear();
            Series series = new Series("TopCustomers")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = false,
                Font = new Font("Segoe UI", 9F),
                ToolTip = "#VALX: #VALY{C2}"
            };
            topCustomerPieChart.Series.Add(series);
            topCustomerPieChart.ChartAreas[0].Area3DStyle.Enable3D = true;

            if (topCustomerPieChart.Legends.Count == 0)
            {
                topCustomerPieChart.Legends.Add(new Legend("Default"));
            }
            topCustomerPieChart.Legends[0].Enabled = true;
            topCustomerPieChart.Legends[0].Docking = Docking.Bottom;
            topCustomerPieChart.Legends[0].Font = new Font("Segoe UI", 9F);

            topCustomerPieChart.Titles.Clear();
        }

        private void ConfigureTopExpensesDoughnutChart()
        {
            topExpensesDoughnutChart.Series.Clear();
            Series series = new Series("TopExpenses")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = false,
                Font = new Font("Segoe UI", 9F),
                ToolTip = "#VALX: #VALY{C2}"
            };
            topExpensesDoughnutChart.Series.Add(series);
            topExpensesDoughnutChart.ChartAreas[0].Area3DStyle.Enable3D = true;

            if (topExpensesDoughnutChart.Legends.Count == 0)
            {
                topExpensesDoughnutChart.Legends.Add(new Legend("Default"));
            }
            topExpensesDoughnutChart.Legends[0].Enabled = true;
            topExpensesDoughnutChart.Legends[0].Docking = Docking.Bottom;
            topExpensesDoughnutChart.Legends[0].Font = new Font("Segoe UI", 9F);

            topExpensesDoughnutChart.Titles.Clear();
            topExpensesDoughnutChart.Titles.Add(new Title
            {
                Text = "Top 5 Expenses This Month",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Docking = Docking.Top
            });
        }

        private void ConfigureSalesPurchColumnChart()
        {
            salesPurchStackedColumn.Series.Clear();

            Series salesSeries = new Series("Sales")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(64, 64, 128), // Dark blue
                ToolTip = "Sales on #VALX: #VALY{N2} LKR (in thousands)"
            };

            Series purchSeries = new Series("Purchases")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(200, 200, 230), // Light purple
                ToolTip = "Purchases on #VALX: #VALY{N2} LKR (in thousands)"
            };

            salesPurchStackedColumn.Series.Add(salesSeries);
            salesPurchStackedColumn.Series.Add(purchSeries);

            salesPurchStackedColumn.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            salesPurchStackedColumn.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            salesPurchStackedColumn.ChartAreas[0].AxisY.Title = "(LKR thousand)";
            salesPurchStackedColumn.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 9F);
            salesPurchStackedColumn.ChartAreas[0].AxisY.LabelStyle.Format = "N0"; // No decimal places
            salesPurchStackedColumn.ChartAreas[0].AxisY.Minimum = 0;
            // Remove fixed maximum to allow auto-scaling
            salesPurchStackedColumn.ChartAreas[0].AxisY.Maximum = double.NaN; // Let chart auto-scale
            salesPurchStackedColumn.ChartAreas[0].AxisY.Interval = 0; // Let chart determine interval automatically

            if (salesPurchStackedColumn.Legends.Count == 0)
            {
                salesPurchStackedColumn.Legends.Add(new Legend("Default"));
            }
            salesPurchStackedColumn.Legends[0].Enabled = true;
            salesPurchStackedColumn.Legends[0].Docking = Docking.Top;
            salesPurchStackedColumn.Legends[0].Font = new Font("Segoe UI", 9F);

            salesPurchStackedColumn.Titles.Clear();
            
        }

        private void LoadSalesPurchData()
        {
            try
            {
                salesPurchStackedColumn.Series["Sales"].Points.Clear();
                salesPurchStackedColumn.Series["Purchases"].Points.Clear();

                string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
                decimal[] salesData = new decimal[7];
                decimal[] purchData = new decimal[7];

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    DateTime today = DateTime.Today;
                    DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Monday);
                    if (today.DayOfWeek == DayOfWeek.Sunday) startOfWeek = startOfWeek.AddDays(-7);
                    DateTime endOfWeek = startOfWeek.AddDays(6);

                    string salesQuery = @"
                        SELECT 
                            DAYOFWEEK(sale_date) AS day_of_week,
                            SUM(total_price) / 1000 AS total_sales_thousands
                        FROM sales
                        WHERE sale_date >= @startDate AND sale_date <= @endDate
                        GROUP BY DAYOFWEEK(sale_date)";
                    using (MySqlCommand salesCmd = new MySqlCommand(salesQuery, connection))
                    {
                        salesCmd.Parameters.AddWithValue("@startDate", startOfWeek);
                        salesCmd.Parameters.AddWithValue("@endDate", endOfWeek.AddDays(1).AddSeconds(-1));
                        using (MySqlDataReader reader = salesCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int dayOfWeek = reader.GetInt32("day_of_week");
                                decimal totalSales = reader.GetDecimal("total_sales_thousands");
                                int index = (dayOfWeek == 1) ? 6 : dayOfWeek - 2;
                                salesData[index] = totalSales;
                            }
                        }
                    }

                    string purchQuery = @"
                        SELECT 
                            DAYOFWEEK(date) AS day_of_week,
                            SUM(total_amount) / 1000 AS total_purch_thousands
                        FROM grn
                        WHERE date >= @startDate AND date <= @endDate
                        GROUP BY DAYOFWEEK(date)";
                    using (MySqlCommand purchCmd = new MySqlCommand(purchQuery, connection))
                    {
                        purchCmd.Parameters.AddWithValue("@startDate", startOfWeek);
                        purchCmd.Parameters.AddWithValue("@endDate", endOfWeek.AddDays(1).AddSeconds(-1));
                        using (MySqlDataReader reader = purchCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int dayOfWeek = reader.GetInt32("day_of_week");
                                decimal totalPurch = reader.GetDecimal("total_purch_thousands");
                                int index = (dayOfWeek == 1) ? 6 : dayOfWeek - 2;
                                purchData[index] = totalPurch;
                            }
                        }
                    }
                }

                for (int i = 0; i < 7; i++)
                {
                    salesPurchStackedColumn.Series["Sales"].Points.AddXY(days[i], salesData[i]);
                    salesPurchStackedColumn.Series["Purchases"].Points.AddXY(days[i], purchData[i]);
                }

                // Recalculate Y-axis scale based on data
                salesPurchStackedColumn.ChartAreas[0].RecalculateAxesScale();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales and purchases data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
                for (int i = 0; i < 7; i++)
                {
                    salesPurchStackedColumn.Series["Sales"].Points.AddXY(days[i], 0);
                    salesPurchStackedColumn.Series["Purchases"].Points.AddXY(days[i], 0);
                }
            }
        }

        private void LoadTopCustomers()
        {
            try
            {
                topCustomersTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
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

                topCustomerPieChart.Series["TopCustomers"].Points.Clear();

                foreach (DataRow row in topCustomersTable.Rows)
                {
                    string customerName = row["customer_name"].ToString();
                    decimal totalSpent = Convert.ToDecimal(row["total_spent"]);
                    int pointIndex = topCustomerPieChart.Series["TopCustomers"].Points.AddXY(customerName, totalSpent);
                    topCustomerPieChart.Series["TopCustomers"].Points[pointIndex].LegendText = customerName;
                }
            }
            catch (Exception)
            {
                topCustomersTable = new DataTable();
                topCustomersTable.Columns.Add("customer_name", typeof(string));
                topCustomersTable.Columns.Add("total_spent", typeof(decimal));
            }
        }

        private void LoadTopExpenses()
        {
            try
            {
                topExpensesTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            title AS expense_title,
                            SUM(amount) AS total_amount
                        FROM expenses
                        WHERE YEAR(expense_date) = YEAR(CURDATE())
                        AND MONTH(expense_date) = MONTH(CURDATE())
                        GROUP BY title
                        ORDER BY total_amount DESC
                        LIMIT 5";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(topExpensesTable);
                    }
                }

                topExpensesDoughnutChart.Series["TopExpenses"].Points.Clear();

                foreach (DataRow row in topExpensesTable.Rows)
                {
                    string expenseTitle = row["expense_title"].ToString();
                    decimal totalAmount = Convert.ToDecimal(row["total_amount"]);
                    int pointIndex = topExpensesDoughnutChart.Series["TopExpenses"].Points.AddXY(expenseTitle, totalAmount);
                    topExpensesDoughnutChart.Series["TopExpenses"].Points[pointIndex].LegendText = expenseTitle;
                }
            }
            catch (Exception)
            {
                topExpensesTable = new DataTable();
                topExpensesTable.Columns.Add("expense_title", typeof(string));
                topExpensesTable.Columns.Add("total_amount", typeof(decimal));
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
                    string query = "SELECT bill_no, customer, user_name, quantity_of_items, payment_method, total_price, sale_date FROM sales ORDER BY sale_date DESC LIMIT 7";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(salesTable);
                    }
                }

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
            catch (Exception)
            {
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
            catch (Exception)
            {
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
            e.CellStyle.Font = gridFont;

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
            e.CellStyle.Font = gridFont;

            if (expireDateAlertGridView.Columns[e.ColumnIndex].Name == "expiry_date")
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.Red;
            }

            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }

        private void recentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void expireDateAlertGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void topCustomerPieChart_Click(object sender, EventArgs e) { }
        private void topExpensesDoughnutChart_Click(object sender, EventArgs e) { }

        private void salesPurchStackedColumn_Click(object sender, EventArgs e)
        {
            ConfigureSalesPurchColumnChart();
            LoadSalesPurchData();
        }

        private void numberOrderLabel_Click(object sender, EventArgs e) { }
        private void grossRevenueChart_Click(object sender, EventArgs e) { }
       
        private void numberTrevenueLabel_Click(object sender, EventArgs e) { }
        private void last7DaysBtn_Click(object sender, EventArgs e) { }
        private void siticonePanel1_Paint(object sender, PaintEventArgs e) { }
        private void tNOCLabel_Click(object sender, EventArgs e) { }
        private void tNOPLabel_Click(object sender, EventArgs e) { }
        private void dashTotPurPanel_Paint(object sender, PaintEventArgs e) { }
        private void dashTotSalePriceLabel_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void thisYearBtn_Click(object sender, EventArgs e) { }
        private void stockAlertDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void topProductsPieChart_Click(object sender, EventArgs e)
        {
            //This is Top 05 product pie chart, that should display, daily, Weekly, Monthly, and this year Top product when i filter that, I will give to you that filter system later, now only make for this week
        }
    }
}