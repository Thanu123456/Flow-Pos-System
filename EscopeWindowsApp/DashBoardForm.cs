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
        private DataTable stockAlertTable;
        private BindingSource salesBindingSource;
        private BindingSource expiryBindingSource;
        private BindingSource stockAlertBindingSource;
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
        private Font gridFont = new Font("Segoe UI", 12F);

        public DashBoardForm()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            salesBindingSource = new BindingSource();
            expiryBindingSource = new BindingSource();
            stockAlertBindingSource = new BindingSource();
            recentDataGridView.CellFormatting += RecentDataGridView_CellFormatting;
            expireDateAlertGridView.CellFormatting += ExpireDateAlertGridView_CellFormatting;
            stockAlertDataGrid.CellFormatting += StockAlertDataGrid_CellFormatting;
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

            ConfigureTopProductsPieChart();
            LoadTopProducts();

            ConfigureStockAlertGridView();
            LoadLowStockProducts();
            stockAlertDataGrid.DataSource = stockAlertBindingSource;

            // Initialize financial labels with today's data
            todayBtn_Click(this, EventArgs.Empty);
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

        private void ConfigureStockAlertGridView()
        {
            stockAlertDataGrid.AutoGenerateColumns = false;
            stockAlertDataGrid.Columns.Clear();
            stockAlertDataGrid.DefaultCellStyle.Font = gridFont;
            stockAlertDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            stockAlertDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_id",
                Name = "product_id",
                HeaderText = "PRODUCT ID",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            stockAlertDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                Name = "product_name",
                HeaderText = "PRODUCT NAME",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            stockAlertDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "brand_name",
                Name = "brand_name",
                HeaderText = "BRAND NAME",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            stockAlertDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "variation_type",
                Name = "variation_type",
                HeaderText = "VARIATION TYPE",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            stockAlertDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "unit_name",
                Name = "unit_name",
                HeaderText = "UNIT",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });
            stockAlertDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "stock",
                Name = "stock",
                HeaderText = "STOCK",
                DefaultCellStyle = new DataGridViewCellStyle { Font = gridFont }
            });

            stockAlertDataGrid.AllowUserToAddRows = false;
            stockAlertDataGrid.RowTemplate.Height = 45;
            stockAlertDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            stockAlertDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            stockAlertDataGrid.ReadOnly = true;
            stockAlertDataGrid.RowHeadersVisible = false;
        }

        private void LoadLowStockProducts()
        {
            try
            {
                stockAlertTable = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            CONCAT('pro', LPAD(p.id, 3, '0')) AS product_id,
                            p.name AS product_name,
                            COALESCE(b.name, 'N/A') AS brand_name,
                            COALESCE(pr.variation_type, 'N/A') AS variation_type,
                            COALESCE(u.unit_name, 'N/A') AS unit_name,
                            SUM(COALESCE(s.stock, 0)) AS stock
                        FROM products p
                        LEFT JOIN brands b ON p.brand_id = b.id
                        LEFT JOIN units u ON p.unit_id = u.id
                        LEFT JOIN pricing pr ON p.id = pr.product_id
                        LEFT JOIN stock s ON p.id = s.product_id AND 
                            (pr.variation_type IS NULL OR pr.variation_type = s.variation_type)
                        GROUP BY p.id, p.name, b.name, pr.variation_type, u.unit_name
                        HAVING SUM(COALESCE(s.stock, 0)) > 0 AND SUM(COALESCE(s.stock, 0)) < 11
                        ORDER BY stock ASC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(stockAlertTable);
                    }
                }

                foreach (DataRow row in stockAlertTable.Rows)
                {
                    for (int i = 0; i < stockAlertTable.Columns.Count; i++)
                    {
                        if (row.IsNull(i))
                        {
                            if (stockAlertTable.Columns[i].DataType == typeof(string))
                            {
                                row[i] = "N/A";
                            }
                            else if (stockAlertTable.Columns[i].DataType == typeof(decimal))
                            {
                                row[i] = 0.00m;
                            }
                        }
                    }
                }

                stockAlertBindingSource.DataSource = stockAlertTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading low stock products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stockAlertTable = new DataTable();
                stockAlertTable.Columns.Add("product_id", typeof(string));
                stockAlertTable.Columns.Add("product_name", typeof(string));
                stockAlertTable.Columns.Add("brand_name", typeof(string));
                stockAlertTable.Columns.Add("variation_type", typeof(string));
                stockAlertTable.Columns.Add("unit_name", typeof(string));
                stockAlertTable.Columns.Add("stock", typeof(decimal));
                stockAlertBindingSource.DataSource = stockAlertTable;
            }
        }

        private void StockAlertDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            e.CellStyle.Font = gridFont;

            if (stockAlertDataGrid.Columns[e.ColumnIndex].Name == "stock")
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.Red;

                if (e.Value != null && e.Value != DBNull.Value)
                {
                    decimal stockValue = Convert.ToDecimal(e.Value);
                    string unitName = stockAlertDataGrid.Rows[e.RowIndex].Cells["unit_name"].Value?.ToString()?.ToLower() ?? "";
                    e.Value = unitName == "pieces" ? ((int)stockValue).ToString("D2") : stockValue.ToString("F2");
                    e.FormattingApplied = true;
                }
            }

            if (e.Value == DBNull.Value || e.Value == null)
            {
                e.Value = "N/A";
                e.FormattingApplied = true;
            }
        }

        private void stockAlertDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = stockAlertDataGrid.Rows[e.RowIndex];
                string details = $@"Low Stock Product Details:
                    Product ID: {row.Cells["product_id"].Value}
                    Product Name: {row.Cells["product_name"].Value}
                    Brand Name: {row.Cells["brand_name"].Value}
                    Variation Type: {row.Cells["variation_type"].Value}
                    Unit: {row.Cells["unit_name"].Value}
                    Stock: {row.Cells["stock"].Value}";
                MessageBox.Show(details, "Low Stock Product Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigureTopCustomerPieChart()
        {
            topCustomerPieChart.Series.Clear();
            Series series = new Series("TopCustomers")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true, // Enable labels on slices
                Label = "#PERCENT{P0}%",    // Show only the percentage
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
                IsValueShownAsLabel = true, // Enable labels on slices
                Label = "#PERCENT{P0}%",    // Show only the percentage
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
        }

        private void ConfigureSalesPurchColumnChart()
        {
            salesPurchStackedColumn.Series.Clear();

            Series salesSeries = new Series("Sales")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(64, 64, 128),
                ToolTip = "Sales on #VALX: #VALY{N2} LKR (in thousands)"
            };

            Series purchSeries = new Series("Purchases")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(200, 200, 230),
                ToolTip = "Purchases on #VALX: #VALY{N2} LKR (in thousands)"
            };

            salesPurchStackedColumn.Series.Add(salesSeries);
            salesPurchStackedColumn.Series.Add(purchSeries);

            salesPurchStackedColumn.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            salesPurchStackedColumn.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            salesPurchStackedColumn.ChartAreas[0].AxisY.Title = "(LKR thousand)";
            salesPurchStackedColumn.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 9F);
            salesPurchStackedColumn.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            salesPurchStackedColumn.ChartAreas[0].AxisY.Minimum = 0;
            salesPurchStackedColumn.ChartAreas[0].AxisY.Maximum = double.NaN;
            salesPurchStackedColumn.ChartAreas[0].AxisY.Interval = 0;

            if (salesPurchStackedColumn.Legends.Count == 0)
            {
                salesPurchStackedColumn.Legends.Add(new Legend("Default"));
            }
            salesPurchStackedColumn.Legends[0].Enabled = true;
            salesPurchStackedColumn.Legends[0].Docking = Docking.Top;
            salesPurchStackedColumn.Legends[0].Font = new Font("Segoe UI", 9F);

            salesPurchStackedColumn.Titles.Clear();
        }

        private void ConfigureTopProductsPieChart()
        {
            topProductsPieChart.Series.Clear();
            Series series = new Series("TopProducts")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true, // Enable labels on slices
                Label = "#PERCENT{P0}%",    // Show only the percentage
                Font = new Font("Segoe UI", 9F),
                ToolTip = "#VALX: #VALY (#PERCENT{P0})"
            };
            topProductsPieChart.Series.Add(series);
            topProductsPieChart.ChartAreas[0].Area3DStyle.Enable3D = true;

            if (topProductsPieChart.Legends.Count == 0)
            {
                topProductsPieChart.Legends.Add(new Legend("Default"));
            }
            topProductsPieChart.Legends[0].Enabled = true;
            topProductsPieChart.Legends[0].Docking = Docking.Bottom;
            topProductsPieChart.Legends[0].Font = new Font("Segoe UI", 9F);

            topProductsPieChart.Titles.Clear();
        }

        private void LoadTopProducts()
        {
            try
            {
                topProductsPieChart.Series["TopProducts"].Points.Clear();
                topProductsPieChart.Titles.Clear();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            sd.product_name,
                            sd.variation_type,
                            SUM(sd.quantity) AS total_quantity
                        FROM sales_details sd
                        INNER JOIN sales s ON sd.bill_no = s.bill_no
                        WHERE YEAR(s.sale_date) = YEAR(CURDATE())
                        AND MONTH(s.sale_date) = MONTH(CURDATE())
                        GROUP BY sd.product_name, sd.variation_type
                        ORDER BY total_quantity DESC
                        LIMIT 5";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productName = reader["product_name"].ToString();
                                string variationType = reader["variation_type"]?.ToString() ?? "N/A";
                                string displayName = $"{productName} - {variationType}";
                                decimal totalQuantity = Convert.ToDecimal(reader["total_quantity"]);
                                int pointIndex = topProductsPieChart.Series["TopProducts"].Points.AddXY(displayName, totalQuantity);
                                topProductsPieChart.Series["TopProducts"].Points[pointIndex].LegendText = displayName;
                            }
                        }
                    }
                }

                if (topProductsPieChart.Series["TopProducts"].Points.Count == 0)
                {
                    topProductsPieChart.Titles.Clear();
                    topProductsPieChart.Titles.Add(new Title
                    {
                        Text = "No Sales Data for Current Month",
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                        ForeColor = Color.Gray
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading top products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                topProductsPieChart.Series.Clear();
                topProductsPieChart.Titles.Clear();
                topProductsPieChart.Titles.Add(new Title
                {
                    Text = "Error Loading Data",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Red
                });
            }
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

        private void recentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = recentDataGridView.Rows[e.RowIndex];
                string details = $@"Recent Sale Details:
                    Reference No: {row.Cells["bill_no"].Value}
                    Customer: {row.Cells["customer"].Value}
                    User Name: {row.Cells["user_name"].Value}
                    Quantity of Items: {row.Cells["quantity_of_items"].Value}
                    Payment Method: {row.Cells["payment_method"].Value}
                    Total Price: LKR {Convert.ToDecimal(row.Cells["total_price"].Value):#,##0.00}
                    Sale Date: {Convert.ToDateTime(row.Cells["sale_date"].Value):yyyy-MM-dd HH:mm:ss}";
                MessageBox.Show(details, "Recent Sale Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void expireDateAlertGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = expireDateAlertGridView.Rows[e.RowIndex];
                string details = $@"Expiring Product Details:
                    Product ID: {row.Cells["product_id"].Value}
                    Product Name: {row.Cells["product_name"].Value}
                    Variation Type: {row.Cells["variation_type"].Value}
                    Purchase Date: {Convert.ToDateTime(row.Cells["purchase_date"].Value):yyyy-MM-dd}
                    Expiry Date: {Convert.ToDateTime(row.Cells["expiry_date"].Value):yyyy-MM-dd}";
                MessageBox.Show(details, "Expiring Product Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void topCustomerPieChart_Click(object sender, EventArgs e) { }
        private void topExpensesDoughnutChart_Click(object sender, EventArgs e) { }

        private void salesPurchStackedColumn_Click(object sender, EventArgs e)
        {
            ConfigureSalesPurchColumnChart();
            LoadSalesPurchData();
        }

        private void topProductsPieChart_Click(object sender, EventArgs e)
        {
            ConfigureTopProductsPieChart();
            LoadTopProducts();
        }

        private void UpdateFinancialLabels(string period, string salesQuery, string purchasesQuery, string refundsQuery)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch total sales
                    decimal totalSales = 0;
                    using (MySqlCommand salesCmd = new MySqlCommand(salesQuery, connection))
                    {
                        object result = salesCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalSales = Convert.ToDecimal(result);
                        }
                    }

                    // Fetch total purchases
                    decimal totalPurchases = 0;
                    using (MySqlCommand purchCmd = new MySqlCommand(purchasesQuery, connection))
                    {
                        object result = purchCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalPurchases = Convert.ToDecimal(result);
                        }
                    }

                    // Fetch total sales returns
                    decimal totalRefunds = 0;
                    using (MySqlCommand refundCmd = new MySqlCommand(refundsQuery, connection))
                    {
                        object result = refundCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalRefunds = Convert.ToDecimal(result);
                        }
                    }

                    // Update labels with formatted currency
                    dashTotSalePriceLabel.Text = $" {totalSales:#,##0.00}";
                    purAmountLabel.Text = $" {totalPurchases:#,##0.00}";
                    saleReAmountLabel.Text = $" {totalRefunds:#,##0.00}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading {period} financial data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dashTotSalePriceLabel.Text = " 0.00";
                purAmountLabel.Text = " 0.00";
                saleReAmountLabel.Text = " 0.00";
            }
        }

        private void thisYearBtn_Click(object sender, EventArgs e)
        {
            string salesQuery = "SELECT SUM(total_price) FROM sales WHERE YEAR(sale_date) = YEAR(CURDATE())";
            string purchasesQuery = "SELECT SUM(total_amount) FROM grn WHERE YEAR(date) = YEAR(CURDATE())";
            string refundsQuery = "SELECT SUM(total_price) FROM refunds WHERE YEAR(refund_date) = YEAR(CURDATE())";
            UpdateFinancialLabels("yearly", salesQuery, purchasesQuery, refundsQuery);
        }

        private void todayBtn_Click(object sender, EventArgs e)
        {
            string salesQuery = "SELECT SUM(total_price) FROM sales WHERE DATE(sale_date) = CURDATE()";
            string purchasesQuery = "SELECT SUM(total_amount) FROM grn WHERE DATE(date) = CURDATE()";
            string refundsQuery = "SELECT SUM(total_price) FROM refunds WHERE DATE(refund_date) = CURDATE()";
            UpdateFinancialLabels("today's", salesQuery, purchasesQuery, refundsQuery);
        }

        private void Last30DaysBtn_Click(object sender, EventArgs e)
        {
            string salesQuery = "SELECT SUM(total_price) FROM sales WHERE sale_date >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)";
            string purchasesQuery = "SELECT SUM(total_amount) FROM grn WHERE date >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)";
            string refundsQuery = "SELECT SUM(total_price) FROM refunds WHERE refund_date >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)";
            UpdateFinancialLabels("last 30 days", salesQuery, purchasesQuery, refundsQuery);
        }

        private void last7DaysBtn_Click(object sender, EventArgs e)
        {
            string salesQuery = "SELECT SUM(total_price) FROM sales WHERE sale_date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)";
            string purchasesQuery = "SELECT SUM(total_amount) FROM grn WHERE date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)";
            string refundsQuery = "SELECT SUM(total_price) FROM refunds WHERE refund_date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)";
            UpdateFinancialLabels("last 7 days", salesQuery, purchasesQuery, refundsQuery);
        }

        private void dashTotSalePriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void purAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void saleReAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void numberOrderLabel_Click(object sender, EventArgs e) { }
        private void grossRevenueChart_Click(object sender, EventArgs e) { }
        private void numberTrevenueLabel_Click(object sender, EventArgs e) { }
        private void siticonePanel1_Paint(object sender, PaintEventArgs e) { }
        private void tNOCLabel_Click(object sender, EventArgs e) { }
        private void tNOPLabel_Click(object sender, EventArgs e) { }
        private void dashTotPurPanel_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void profitAmoutLabel_Click(object sender, EventArgs e)
        {

        }

        private void siticonePanel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}