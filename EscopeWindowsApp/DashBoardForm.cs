using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
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

            ConfigureDailyProfitLineChart();
            LoadDailyProfitData();

            todayBtn_Click(this, EventArgs.Empty);

            UpdateAlertPanel();
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

        private void ConfigureTopCustomerPieChart()
        {
            topCustomerPieChart.Series.Clear();
            Series series = new Series("TopCustomers")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#PERCENT{P0}",
                Font = new Font("Segoe UI", 9F),
                ToolTip = "#VALX: #VALY{N2} LKR",
                ["PointDepth"] = "0"
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
            topCustomerPieChart.Legends[0].IsTextAutoFit = true;
            topCustomerPieChart.Legends[0].CustomItems.Clear();

            topCustomerPieChart.Titles.Clear();
        }

        private void ConfigureTopExpensesDoughnutChart()
        {
            topExpensesDoughnutChart.Series.Clear();
            Series series = new Series("TopExpenses")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true,
                Label = "#PERCENT{P0}",
                Font = new Font("Segoe UI", 9F),
                ToolTip = "#VALX: #VALY{N2} LKR",
                ["PointDepth"] = "0"
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
            topExpensesDoughnutChart.Legends[0].IsTextAutoFit = true;
            topExpensesDoughnutChart.Legends[0].CustomItems.Clear();

            topExpensesDoughnutChart.Titles.Clear();
        }

        private void ConfigureTopProductsPieChart()
        {
            topProductsPieChart.Series.Clear();
            Series series = new Series("TopProducts")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#PERCENT{P0}",
                Font = new Font("Segoe UI", 9F),
                ToolTip = "#VALX: #VALY",
                ["PointDepth"] = "0"
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
            topProductsPieChart.Legends[0].IsTextAutoFit = true;
            topProductsPieChart.Legends[0].CustomItems.Clear();

            topProductsPieChart.Titles.Clear();
        }

        private void ConfigureSalesPurchColumnChart()
        {
            salesPurchStackedColumn.Series.Clear();

            Series salesSeries = new Series("Sales")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(64, 64, 128),
                ToolTip = "Sales on : #VALY{N2} LKR (in thousands)"
            };

            Series purchSeries = new Series("Purchases")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(200, 200, 230),
                ToolTip = "Purchases on : #VALY{N2} LKR (in thousands)"
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

        private void ConfigureDailyProfitLineChart()
        {
            dailyProfitLineChart.Series.Clear();
            dailyProfitLineChart.ChartAreas.Clear();
            dailyProfitLineChart.Legends.Clear();
            dailyProfitLineChart.Titles.Clear();

            ChartArea chartArea = new ChartArea("ProfitArea")
            {
                BackColor = Color.FromArgb(240, 240, 245),
                BackGradientStyle = GradientStyle.TopBottom,
                BackSecondaryColor = Color.White,
                BorderColor = Color.FromArgb(200, 200, 200),
                BorderDashStyle = ChartDashStyle.Solid,
                BorderWidth = 1
            };

            chartArea.AxisX.TitleFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisX.LabelStyle.Format = "dd-MMM";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartArea.AxisX.MinorGrid.Enabled = false;
            chartArea.AxisX.LineColor = Color.FromArgb(150, 150, 150);

            chartArea.AxisY.TitleFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Format = "N0";
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartArea.AxisY.MinorGrid.Enabled = false;
            chartArea.AxisY.LineColor = Color.FromArgb(150, 150, 150);

            chartArea.CursorX.IsUserEnabled = false;
            chartArea.CursorX.IsUserSelectionEnabled = false;
            chartArea.CursorY.IsUserEnabled = false;
            chartArea.CursorY.IsUserSelectionEnabled = false;
            chartArea.AxisX.ScaleView.Zoomable = false;
            chartArea.AxisY.ScaleView.Zoomable = false;
            chartArea.AxisX.ScrollBar.Enabled = false;
            chartArea.AxisY.ScrollBar.Enabled = false;
            chartArea.AxisX.Enabled = AxisEnabled.True;
            chartArea.AxisY.Enabled = AxisEnabled.True;
            chartArea.AxisX.ScaleView.Size = double.NaN;
            chartArea.AxisY.ScaleView.Size = double.NaN;

            dailyProfitLineChart.ChartAreas.Add(chartArea);

            Series profitSeries = new Series("DailyProfit")
            {
                ChartType = SeriesChartType.Spline,
                Color = Color.FromArgb(0, 120, 215),
                BorderWidth = 3,
                ToolTip = "Date: #VALX{dd-MMM-yyyy}, Profit: #VALY{N2} LKR",
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = Color.FromArgb(0, 120, 215),
                MarkerBorderColor = Color.White,
                MarkerBorderWidth = 1
            };
            dailyProfitLineChart.Series.Add(profitSeries);

            dailyProfitLineChart.Size = new Size(dailyProfitLineChart.Width + 50, dailyProfitLineChart.Height + 75);

            chartArea.AxisX.ScaleView.ZoomReset(0);
            chartArea.AxisY.ScaleView.ZoomReset(0);

            dailyProfitLineChart.MouseWheel += (s, e) => { };
            dailyProfitLineChart.MouseDown += (s, e) => { };
            dailyProfitLineChart.MouseMove += (s, e) => { };
            dailyProfitLineChart.MouseClick += (s, e) => { };

            Console.WriteLine($"DailyProfitLineChart Type: {dailyProfitLineChart.GetType().FullName}");
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
                            CONCAT('PRO', LPAD(gi.product_id, 3, '0')) AS product_id,
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
                            CONCAT('PRO', LPAD(p.id, 3, '0')) AS product_id,
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
                        HAVING SUM(COALESCE(s.stock, 0)) > 0 AND SUM(COALESCE(s.stock, 0)) < 21
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
            catch (Exception)
            {
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

        private void LoadTopCustomers()
        {
            try
            {
                topCustomersTable = new DataTable();
                topCustomerPieChart.Series["TopCustomers"].Points.Clear();
                topCustomerPieChart.Titles.Clear();

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

                Color[] colors = new Color[] { Color.FromArgb(0, 120, 215), Color.FromArgb(255, 99, 132), Color.FromArgb(75, 192, 192), Color.FromArgb(255, 159, 64), Color.FromArgb(153, 102, 255) };
                int colorIndex = 0;

                topCustomerPieChart.Legends[0].CustomItems.Clear();

                foreach (DataRow row in topCustomersTable.Rows)
                {
                    string customerName = row["customer_name"].ToString();
                    decimal totalSpent = Convert.ToDecimal(row["total_spent"]);
                    int pointIndex = topCustomerPieChart.Series["TopCustomers"].Points.AddXY(customerName, totalSpent);
                    var point = topCustomerPieChart.Series["TopCustomers"].Points[pointIndex];
                    point.LegendText = customerName;
                    point.Color = colors[colorIndex % colors.Length];
                    point.BackGradientStyle = GradientStyle.None;
                    point.BackSecondaryColor = Color.Transparent;
                    point.Font = new Font("Segoe UI", 9F);

                    colorIndex++;
                }

                if (topCustomerPieChart.Series["TopCustomers"].Points.Count == 0)
                {
                    topCustomerPieChart.Titles.Add(new Title
                    {
                        Text = "No Customer Data Available",
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                        ForeColor = Color.Gray
                    });
                }
            }
            catch (Exception)
            {
                topCustomersTable = new DataTable();
                topCustomersTable.Columns.Add("customer_name", typeof(string));
                topCustomersTable.Columns.Add("total_spent", typeof(decimal));
                topCustomerPieChart.Series["TopCustomers"].Points.Clear();
                topCustomerPieChart.Titles.Add(new Title
                {
                    Text = "Error Loading Data",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Red
                });
            }
        }

        private void LoadTopExpenses()
        {
            try
            {
                topExpensesTable = new DataTable();
                topExpensesDoughnutChart.Series["TopExpenses"].Points.Clear();
                topExpensesDoughnutChart.Titles.Clear();

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

                Color[] colors = new Color[] { Color.FromArgb(255, 99, 132), Color.FromArgb(54, 162, 235), Color.FromArgb(255, 206, 86), Color.FromArgb(75, 192, 192), Color.FromArgb(153, 102, 255) };
                int colorIndex = 0;

                topExpensesDoughnutChart.Legends[0].CustomItems.Clear();

                foreach (DataRow row in topExpensesTable.Rows)
                {
                    string expenseTitle = row["expense_title"].ToString();
                    decimal totalAmount = Convert.ToDecimal(row["total_amount"]);
                    int pointIndex = topExpensesDoughnutChart.Series["TopExpenses"].Points.AddXY(expenseTitle, totalAmount);
                    var point = topExpensesDoughnutChart.Series["TopExpenses"].Points[pointIndex];
                    point.LegendText = expenseTitle;
                    point.Color = colors[colorIndex % colors.Length];
                    point.BackGradientStyle = GradientStyle.None;
                    point.BackSecondaryColor = Color.Transparent;
                    point.Font = new Font("Segoe UI", 9F);

                    colorIndex++;
                }

                if (topExpensesDoughnutChart.Series["TopExpenses"].Points.Count == 0)
                {
                    topExpensesDoughnutChart.Titles.Add(new Title
                    {
                        Text = "No Expense Data Available",
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                        ForeColor = Color.Gray
                    });
                }
            }
            catch (Exception)
            {
                topExpensesTable = new DataTable();
                topExpensesTable.Columns.Add("expense_title", typeof(string));
                topExpensesTable.Columns.Add("total_amount", typeof(decimal));
                topExpensesDoughnutChart.Series["TopExpenses"].Points.Clear();
                topExpensesDoughnutChart.Titles.Add(new Title
                {
                    Text = "Error Loading Data",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Red
                });
            }
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
                            COALESCE(sd.variation_type, 'N/A') AS variation_type,
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
                            Color[] colors = new Color[] {
                                Color.FromArgb(54, 162, 235),
                                Color.FromArgb(255, 99, 132),
                                Color.FromArgb(255, 206, 86),
                                Color.FromArgb(75, 192, 192),
                                Color.FromArgb(153, 102, 255)
                            };
                            int colorIndex = 0;

                            topProductsPieChart.Legends[0].CustomItems.Clear();

                            HashSet<string> uniqueDisplayNames = new HashSet<string>();

                            while (reader.Read())
                            {
                                string productName = reader["product_name"].ToString();
                                string variationType = reader["variation_type"].ToString();
                                string displayName = variationType == "N/A" ? productName : $"{productName} ({variationType})";
                                decimal totalQuantity = Convert.ToDecimal(reader["total_quantity"]);

                                int pointIndex = topProductsPieChart.Series["TopProducts"].Points.AddXY(displayName, totalQuantity);
                                var point = topProductsPieChart.Series["TopProducts"].Points[pointIndex];

                                point.LegendText = displayName;
                                point.Color = colors[colorIndex % colors.Length];
                                point.BackGradientStyle = GradientStyle.None;
                                point.BackSecondaryColor = Color.Transparent;
                                point.Font = new Font("Segoe UI", 9F);

                                if (uniqueDisplayNames.Add(displayName))
                                {
                                    colorIndex++;
                                }
                            }
                        }
                    }
                }

                if (topProductsPieChart.Series["TopProducts"].Points.Count == 0)
                {
                    topProductsPieChart.Titles.Add(new Title
                    {
                        Text = "No Sales Data for Current Month",
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                        ForeColor = Color.Gray
                    });
                }
            }
            catch (Exception)
            {
                topProductsPieChart.Series["TopProducts"].Points.Clear();
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
            catch (Exception)
            {
                string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
                for (int i = 0; i < 7; i++)
                {
                    salesPurchStackedColumn.Series["Sales"].Points.AddXY(days[i], 0);
                    salesPurchStackedColumn.Series["Purchases"].Points.AddXY(days[i], 0);
                }
            }
        }

        private void LoadDailyProfitData()
        {
            try
            {
                dailyProfitLineChart.Series["DailyProfit"].Points.Clear();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    DateTime endDate = DateTime.Today;
                    DateTime startDate = endDate.AddDays(-29);

                    Dictionary<DateTime, decimal> salesData = new Dictionary<DateTime, decimal>();
                    Dictionary<DateTime, decimal> refundData = new Dictionary<DateTime, decimal>();
                    Dictionary<DateTime, decimal> expenseData = new Dictionary<DateTime, decimal>();
                    Dictionary<DateTime, decimal> purchaseData = new Dictionary<DateTime, decimal>();
                    Dictionary<DateTime, decimal> purchaseReturnData = new Dictionary<DateTime, decimal>();

                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        salesData[date] = 0;
                        refundData[date] = 0;
                        expenseData[date] = 0;
                        purchaseData[date] = 0;
                        purchaseReturnData[date] = 0;
                    }

                    string salesQuery = @"
                        SELECT DATE(sale_date) AS sale_day, SUM(total_price) AS total_sales
                        FROM sales
                        WHERE sale_date >= @startDate AND sale_date <= @endDate
                        GROUP BY DATE(sale_date)";
                    using (MySqlCommand cmd = new MySqlCommand(salesQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate.AddDays(1).AddSeconds(-1));
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime saleDay = reader.GetDateTime("sale_day");
                                decimal totalSales = reader.GetDecimal("total_sales");
                                salesData[saleDay] = totalSales;
                            }
                        }
                    }

                    string refundQuery = @"
                        SELECT DATE(refund_date) AS refund_day, SUM(total_price) AS total_refunds
                        FROM refunds
                        WHERE refund_date >= @startDate AND refund_date <= @endDate
                        GROUP BY DATE(refund_date)";
                    using (MySqlCommand cmd = new MySqlCommand(refundQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate.AddDays(1).AddSeconds(-1));
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime refundDay = reader.GetDateTime("refund_day");
                                decimal totalRefunds = reader.GetDecimal("total_refunds");
                                refundData[refundDay] = totalRefunds;
                            }
                        }
                    }

                    string expenseQuery = @"
                        SELECT DATE(expense_date) AS expense_day, SUM(amount) AS total_expenses
                        FROM expenses
                        WHERE expense_date >= @startDate AND expense_date <= @endDate
                        GROUP BY DATE(expense_date)";
                    using (MySqlCommand cmd = new MySqlCommand(expenseQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate.AddDays(1).AddSeconds(-1));
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime expenseDay = reader.GetDateTime("expense_day");
                                decimal totalExpenses = reader.GetDecimal("total_expenses");
                                expenseData[expenseDay] = totalExpenses;
                            }
                        }
                    }

                    string purchaseQuery = @"
                        SELECT DATE(date) AS purchase_day, SUM(total_amount) AS total_purchases
                        FROM grn
                        WHERE date >= @startDate AND date <= @endDate
                        GROUP BY DATE(date)";
                    using (MySqlCommand cmd = new MySqlCommand(purchaseQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate.AddDays(1).AddSeconds(-1));
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime purchaseDay = reader.GetDateTime("purchase_day");
                                decimal totalPurchases = reader.GetDecimal("total_purchases");
                                purchaseData[purchaseDay] = totalPurchases;
                            }
                        }
                    }

                    string purchaseReturnQuery = @"
                        SELECT DATE(created_at) AS return_day, SUM(total_amount) AS total_returns
                        FROM purchase_returns
                        WHERE created_at >= @startDate AND created_at <= @endDate
                        GROUP BY DATE(created_at)";
                    using (MySqlCommand cmd = new MySqlCommand(purchaseReturnQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@endDate", endDate.AddDays(1).AddSeconds(-1));
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime returnDay = reader.GetDateTime("return_day");
                                decimal totalReturns = reader.GetDecimal("total_returns");
                                purchaseReturnData[returnDay] = totalReturns;
                            }
                        }
                    }

                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        decimal sales = salesData[date];
                        decimal refunds = refundData[date];
                        decimal expenses = expenseData[date];
                        decimal purchases = purchaseData[date];
                        decimal purchaseReturns = purchaseReturnData[date];

                        decimal profit = sales - (refunds + expenses + (purchases - purchaseReturns));
                        dailyProfitLineChart.Series["DailyProfit"].Points.AddXY(date, profit);
                    }
                }

                dailyProfitLineChart.ChartAreas["ProfitArea"].RecalculateAxesScale();

                dailyProfitLineChart.ChartAreas["ProfitArea"].AxisX.ScaleView.ZoomReset(0);
                dailyProfitLineChart.ChartAreas["ProfitArea"].AxisY.ScaleView.ZoomReset(0);
            }
            catch (Exception)
            {
                dailyProfitLineChart.Series["DailyProfit"].Points.Clear();
                for (int i = 29; i >= 0; i--)
                {
                    DateTime date = DateTime.Today.AddDays(-i);
                    dailyProfitLineChart.Series["DailyProfit"].Points.AddXY(date, 0);
                }
            }
        }

        private Color LightenColor(Color color)
        {
            int r = Math.Min(255, (int)(color.R * 1.3));
            int g = Math.Min(255, (int)(color.G * 1.3));
            int b = Math.Min(255, (int)(color.B * 1.3));
            return Color.FromArgb(color.A, r, g, b);
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

        private void UpdateFinancialLabels(string period, string salesQuery, string purchasesQuery, string refundsQuery, string expensesQuery, string purchaseReturnsQuery)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    decimal totalSales = 0;
                    using (MySqlCommand salesCmd = new MySqlCommand(salesQuery, connection))
                    {
                        object result = salesCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalSales = Convert.ToDecimal(result);
                        }
                    }

                    decimal totalPurchases = 0;
                    using (MySqlCommand purchCmd = new MySqlCommand(purchasesQuery, connection))
                    {
                        object result = purchCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalPurchases = Convert.ToDecimal(result);
                        }
                    }

                    decimal totalRefunds = 0;
                    using (MySqlCommand refundCmd = new MySqlCommand(refundsQuery, connection))
                    {
                        object result = refundCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalRefunds = Convert.ToDecimal(result);
                        }
                    }

                    decimal totalExpenses = 0;
                    using (MySqlCommand expenseCmd = new MySqlCommand(expensesQuery, connection))
                    {
                        object result = expenseCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalExpenses = Convert.ToDecimal(result);
                        }
                    }

                    decimal totalPurchaseReturns = 0;
                    using (MySqlCommand purchaseReturnCmd = new MySqlCommand(purchaseReturnsQuery, connection))
                    {
                        object result = purchaseReturnCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalPurchaseReturns = Convert.ToDecimal(result);
                        }
                    }

                    decimal profit = totalSales - (totalRefunds + totalExpenses + (totalPurchases - totalPurchaseReturns));

                    dashTotSalePriceLabel.Text = $" {totalSales:#,##0.00}";
                    purAmountLabel.Text = $" {totalPurchases:#,##0.00}";
                    saleReAmountLabel.Text = $" {totalRefunds:#,##0.00}";

                    if (profit < 0)
                    {
                        label6.Text = "LOSS";
                        profitAmoutLabel.Text = $" {Math.Abs(profit):#,##0.00}";
                        profitAmoutLabel.ForeColor = Color.Red;
                    }
                    else
                    {
                        label6.Text = "PROFIT";
                        profitAmoutLabel.Text = $" {profit:#,##0.00}";
                        profitAmoutLabel.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception)
            {
                dashTotSalePriceLabel.Text = " 0.00";
                purAmountLabel.Text = " 0.00";
                saleReAmountLabel.Text = " 0.00";
                profitAmoutLabel.Text = " 0.00";
                profitAmoutLabel.ForeColor = Color.Black;
                label6.Text = "PROFIT";
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

        private void dailyProfitLineChart_Click(object sender, EventArgs e)
        {
            LoadDailyProfitData();
        }

        private void thisYearBtn_Click(object sender, EventArgs e)
        {
            string salesQuery = "SELECT SUM(total_price) FROM sales WHERE YEAR(sale_date) = YEAR(CURDATE())";
            string purchasesQuery = "SELECT SUM(total_amount) FROM grn WHERE YEAR(date) = YEAR(CURDATE())";
            string refundsQuery = "SELECT SUM(total_price) FROM refunds WHERE YEAR(refund_date) = YEAR(CURDATE())";
            string expensesQuery = "SELECT SUM(amount) FROM expenses WHERE YEAR(expense_date) = YEAR(CURDATE())";
            string purchaseReturnsQuery = "SELECT SUM(total_amount) FROM purchase_returns WHERE YEAR(created_at) = YEAR(CURDATE())";
            UpdateFinancialLabels("yearly", salesQuery, purchasesQuery, refundsQuery, expensesQuery, purchaseReturnsQuery);
        }

        private void todayBtn_Click(object sender, EventArgs e)
        {
            string salesQuery = "SELECT SUM(total_price) FROM sales WHERE DATE(sale_date) = CURDATE()";
            string purchasesQuery = "SELECT SUM(total_amount) FROM grn WHERE DATE(date) = CURDATE()";
            string refundsQuery = "SELECT SUM(total_price) FROM refunds WHERE DATE(refund_date) = CURDATE()";
            string expensesQuery = "SELECT SUM(amount) FROM expenses WHERE DATE(expense_date) = CURDATE()";
            string purchaseReturnsQuery = "SELECT SUM(total_amount) FROM purchase_returns WHERE DATE(created_at) = CURDATE()";
            UpdateFinancialLabels("today's", salesQuery, purchasesQuery, refundsQuery, expensesQuery, purchaseReturnsQuery);
        }

        private void Last30DaysBtn_Click(object sender, EventArgs e)
        {
            string salesQuery = "SELECT SUM(total_price) FROM sales WHERE sale_date >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)";
            string purchasesQuery = "SELECT SUM(total_amount) FROM grn WHERE date >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)";
            string refundsQuery = "SELECT SUM(total_price) FROM refunds WHERE refund_date >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)";
            string expensesQuery = "SELECT SUM(amount) FROM expenses WHERE expense_date >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)";
            string purchaseReturnsQuery = "SELECT SUM(total_amount) FROM purchase_returns WHERE created_at >= DATE_SUB(CURDATE(), INTERVAL 30 DAY)";
            UpdateFinancialLabels("last 30 days", salesQuery, purchasesQuery, refundsQuery, expensesQuery, purchaseReturnsQuery);
        }

        private void last7DaysBtn_Click(object sender, EventArgs e)
        {
            string salesQuery = "SELECT SUM(total_price) FROM sales WHERE sale_date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)";
            string purchasesQuery = "SELECT SUM(total_amount) FROM grn WHERE date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)";
            string refundsQuery = "SELECT SUM(total_price) FROM refunds WHERE refund_date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)";
            string expensesQuery = "SELECT SUM(amount) FROM expenses WHERE expense_date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)";
            string purchaseReturnsQuery = "SELECT SUM(total_amount) FROM purchase_returns WHERE created_at >= DATE_SUB(CURDATE(), INTERVAL 7 DAY)";
            UpdateFinancialLabels("last 7 days", salesQuery, purchasesQuery, refundsQuery, expensesQuery, purchaseReturnsQuery);
        }

        private void UpdateAlertPanel()
        {
            bool hasStockAlert = stockAlertDataGrid.RowCount > 0;
            bool hasExpireAlert = expireDateAlertGridView.RowCount > 0;

            if (hasStockAlert && hasExpireAlert)
            {
                alertMessageLabel.Text = "Check Stock Alert Table and Expire Date Table !";
                alertPanel.Visible = true;
            }
            else if (hasStockAlert)
            {
                alertMessageLabel.Text = "Your stock is low, Check Stock Alert Table !";
                alertPanel.Visible = true;
            }
            else if (hasExpireAlert)
            {
                alertMessageLabel.Text = "Check Expire Date Table !";
                alertPanel.Visible = true;
            }
            else
            {
                alertPanel.Visible = false;
            }
        }

        private void dashTotSalePriceLabel_Click(object sender, EventArgs e) { }
        private void purAmountLabel_Click(object sender, EventArgs e) { }
        private void saleReAmountLabel_Click(object sender, EventArgs e) { }
        private void numberOrderLabel_Click(object sender, EventArgs e) { }
        private void grossRevenueChart_Click(object sender, EventArgs e) { }
        private void numberTrevenueLabel_Click(object sender, EventArgs e) { }
        private void siticonePanel1_Paint(object sender, PaintEventArgs e) { }
        private void tNOCLabel_Click(object sender, EventArgs e) { }
        private void tNOPLabel_Click(object sender, EventArgs e) { }
        private void dashTotPurPanel_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void profitAmoutLabel_Click(object sender, EventArgs e) { }
        private void siticonePanel11_Paint(object sender, PaintEventArgs e) { }
        private void siticonePanel3_Paint(object sender, PaintEventArgs e) { }
        private void siticonePanel7_Paint(object sender, PaintEventArgs e) { }

        private void alertPanel_Paint(object sender, PaintEventArgs e)
        {
            // This panel is invisible by default but shown if stockAlertDataGrid or expireDateAlertGridView has at least one row
        }

        private void alertMessageLabel_Click(object sender, EventArgs e)
        {
            // This label is invisible by default but displays appropriate messages based on stockAlertDataGrid or expireDateAlertGridView row counts
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
            alertPanel.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string profitText = profitAmoutLabel.Text.Trim();
            if (decimal.TryParse(profitText, out decimal profit))
            {
                if (profit < 0)
                {
                    label6.Text = "LOSS";
                    profitAmoutLabel.Text = $" {Math.Abs(profit):#,##0.00}";
                    profitAmoutLabel.ForeColor = Color.Red;
                }
                else
                {
                    label6.Text = "PROFIT";
                    profitAmoutLabel.Text = $" {profit:#,##0.00}";
                    profitAmoutLabel.ForeColor = Color.Green;
                }
            }
            else
            {
                label6.Text = "PROFIT";
                profitAmoutLabel.Text = " 0.00";
                profitAmoutLabel.ForeColor = Color.Black;
            }
        }
    }
}