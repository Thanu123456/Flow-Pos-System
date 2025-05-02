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

        // Animation fields for pie charts
        private Dictionary<Chart, int> lastHoveredPointIndices = new Dictionary<Chart, int>();
        private Dictionary<Chart, Dictionary<int, Color>> originalColors = new Dictionary<Chart, Dictionary<int, Color>>();
        private Dictionary<Chart, Dictionary<int, string>> originalGradients = new Dictionary<Chart, Dictionary<int, string>>();
        private Dictionary<Chart, Dictionary<int, Color>> originalSecondaryColors = new Dictionary<Chart, Dictionary<int, Color>>();
        private Dictionary<Chart, Dictionary<int, Font>> originalFonts = new Dictionary<Chart, Dictionary<int, Font>>();
        private Dictionary<Chart, Timer> loadingTimers = new Dictionary<Chart, Timer>();
        private Dictionary<Chart, Timer> hoverTimers = new Dictionary<Chart, Timer>();
        private Dictionary<Chart, int> animationSteps = new Dictionary<Chart, int>();
        private Dictionary<Chart, Dictionary<int, double>> sliceProgress = new Dictionary<Chart, Dictionary<int, double>>();
        private Dictionary<Chart, double> currentHoverRadius = new Dictionary<Chart, double>();
        private Dictionary<Chart, int> currentHoverOpacity = new Dictionary<Chart, int>();
        private Dictionary<Chart, Color> currentHoverColor = new Dictionary<Chart, Color>();
        private Dictionary<Chart, bool> isHovering = new Dictionary<Chart, bool>();
        private Dictionary<Chart, Dictionary<int, double>> originalYValues = new Dictionary<Chart, Dictionary<int, double>>();
        private Dictionary<Chart, double> titleOpacity = new Dictionary<Chart, double>();
        private Dictionary<Chart, double> titleOffset = new Dictionary<Chart, double>();

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

            // Initialize animation dictionaries for each pie chart
            InitializeChartAnimation(topCustomerPieChart);
            InitializeChartAnimation(topExpensesDoughnutChart);
            InitializeChartAnimation(topProductsPieChart);

            // Add hover event handlers
            topCustomerPieChart.MouseMove += PieChart_MouseMove;
            topCustomerPieChart.MouseLeave += PieChart_MouseLeave;
            topExpensesDoughnutChart.MouseMove += PieChart_MouseMove;
            topExpensesDoughnutChart.MouseLeave += PieChart_MouseLeave;
            topProductsPieChart.MouseMove += PieChart_MouseMove;
            topProductsPieChart.MouseLeave += PieChart_MouseLeave;
        }

        private void InitializeChartAnimation(Chart chart)
        {
            lastHoveredPointIndices[chart] = -1;
            originalColors[chart] = new Dictionary<int, Color>();
            originalGradients[chart] = new Dictionary<int, string>();
            originalSecondaryColors[chart] = new Dictionary<int, Color>();
            originalFonts[chart] = new Dictionary<int, Font>();
            originalYValues[chart] = new Dictionary<int, double>();
            sliceProgress[chart] = new Dictionary<int, double>();
            animationSteps[chart] = 0;
            currentHoverRadius[chart] = 100.0;
            currentHoverOpacity[chart] = 0;
            currentHoverColor[chart] = Color.Transparent;
            isHovering[chart] = false;
            titleOpacity[chart] = 1.0;
            titleOffset[chart] = -50.0;
            loadingTimers[chart] = new Timer { Interval = 30 };
            loadingTimers[chart].Tick += (s, e) => LoadingAnimationTick(chart);
            hoverTimers[chart] = new Timer { Interval = 15 };
            hoverTimers[chart].Tick += (s, e) => HoverAnimationTick(chart);
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
                IsValueShownAsLabel = false,
                Font = new Font("Segoe UI", 9F),
                ToolTip = "#VALX: #VALY{C2}",
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
            topCustomerPieChart.Titles.Add(new Title
            {
                Text = "Loading...",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.Gray
            });
        }

        private void ConfigureTopExpensesDoughnutChart()
        {
            topExpensesDoughnutChart.Series.Clear();
            Series series = new Series("TopExpenses")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = false,
                Font = new Font("Segoe UI", 9F),
                ToolTip = "#VALX: #VALY{C2}",
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
            topExpensesDoughnutChart.Titles.Add(new Title
            {
                Text = "Loading...",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.Gray
            });
        }

        private void ConfigureTopProductsPieChart()
        {
            topProductsPieChart.Series.Clear();
            Series series = new Series("TopProducts")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#VALX",
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
            topProductsPieChart.Titles.Add(new Title
            {
                Text = "Loading...",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.Gray
            });
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
                topCustomerPieChart.Titles.Add(new Title
                {
                    Text = "Loading...",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Gray
                });

                originalColors[topCustomerPieChart].Clear();
                originalGradients[topCustomerPieChart].Clear();
                originalSecondaryColors[topCustomerPieChart].Clear();
                originalFonts[topCustomerPieChart].Clear();
                originalYValues[topCustomerPieChart].Clear();
                StartLoadingAnimation(topCustomerPieChart);

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
                    originalColors[topCustomerPieChart][pointIndex] = point.Color;
                    originalGradients[topCustomerPieChart][pointIndex] = point.BackGradientStyle.ToString();
                    originalSecondaryColors[topCustomerPieChart][pointIndex] = point.BackSecondaryColor;
                    originalFonts[topCustomerPieChart][pointIndex] = point.Font;
                    originalYValues[topCustomerPieChart][pointIndex] = (double)totalSpent;

                    LegendItem customItem = new LegendItem
                    {
                        Name = customerName,
                        Color = point.Color,
                        MarkerStyle = MarkerStyle.Circle,
                        MarkerSize = 8
                    };
                    topCustomerPieChart.Legends[0].CustomItems.Add(customItem);

                    colorIndex++;
                }

                if (topCustomerPieChart.Series["TopCustomers"].Points.Count == 0)
                {
                    loadingTimers[topCustomerPieChart].Stop();
                    topCustomerPieChart.Titles.Clear();
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
                loadingTimers[topCustomerPieChart].Stop();
                topCustomersTable = new DataTable();
                topCustomersTable.Columns.Add("customer_name", typeof(string));
                topCustomersTable.Columns.Add("total_spent", typeof(decimal));
                topCustomerPieChart.Series["TopCustomers"].Points.Clear();
                topCustomerPieChart.Titles.Clear();
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
                topExpensesDoughnutChart.Titles.Add(new Title
                {
                    Text = "Loading...",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Gray
                });

                originalColors[topExpensesDoughnutChart].Clear();
                originalGradients[topExpensesDoughnutChart].Clear();
                originalSecondaryColors[topExpensesDoughnutChart].Clear();
                originalFonts[topExpensesDoughnutChart].Clear();
                originalYValues[topExpensesDoughnutChart].Clear();
                StartLoadingAnimation(topExpensesDoughnutChart);

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
                    originalColors[topExpensesDoughnutChart][pointIndex] = point.Color;
                    originalGradients[topExpensesDoughnutChart][pointIndex] = point.BackGradientStyle.ToString();
                    originalSecondaryColors[topExpensesDoughnutChart][pointIndex] = point.BackSecondaryColor;
                    originalFonts[topExpensesDoughnutChart][pointIndex] = point.Font;
                    originalYValues[topExpensesDoughnutChart][pointIndex] = (double)totalAmount;

                    LegendItem customItem = new LegendItem
                    {
                        Name = expenseTitle,
                        Color = point.Color,
                        MarkerStyle = MarkerStyle.Circle,
                        MarkerSize = 8
                    };
                    topExpensesDoughnutChart.Legends[0].CustomItems.Add(customItem);

                    colorIndex++;
                }

                if (topExpensesDoughnutChart.Series["TopExpenses"].Points.Count == 0)
                {
                    loadingTimers[topExpensesDoughnutChart].Stop();
                    topExpensesDoughnutChart.Titles.Clear();
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
                loadingTimers[topExpensesDoughnutChart].Stop();
                topExpensesTable = new DataTable();
                topExpensesTable.Columns.Add("expense_title", typeof(string));
                topExpensesTable.Columns.Add("total_amount", typeof(decimal));
                topExpensesDoughnutChart.Series["TopExpenses"].Points.Clear();
                topExpensesDoughnutChart.Titles.Clear();
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
                topProductsPieChart.Titles.Add(new Title
                {
                    Text = "Loading...",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                    ForeColor = Color.Gray
                });

                originalColors[topProductsPieChart].Clear();
                originalGradients[topProductsPieChart].Clear();
                originalSecondaryColors[topProductsPieChart].Clear();
                originalFonts[topProductsPieChart].Clear();
                originalYValues[topProductsPieChart].Clear();
                StartLoadingAnimation(topProductsPieChart);

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
                                Color.FromArgb(54, 162, 235),  // Blue
                                Color.FromArgb(255, 99, 132),  // Pink
                                Color.FromArgb(255, 206, 86),  // Yellow
                                Color.FromArgb(75, 192, 192),  // Teal
                                Color.FromArgb(153, 102, 255)  // Purple
                            };
                            int colorIndex = 0;

                            topProductsPieChart.Legends[0].CustomItems.Clear();

                            // Use a HashSet to track unique display names
                            HashSet<string> uniqueDisplayNames = new HashSet<string>();

                            while (reader.Read())
                            {
                                string productName = reader["product_name"].ToString();
                                string variationType = reader["variation_type"].ToString();
                                string displayName = variationType == "N/A" ? productName : $"{productName} ({variationType})";
                                decimal totalQuantity = Convert.ToDecimal(reader["total_quantity"]);

                                // Add the data point to the chart
                                int pointIndex = topProductsPieChart.Series["TopProducts"].Points.AddXY(displayName, totalQuantity);
                                var point = topProductsPieChart.Series["TopProducts"].Points[pointIndex];

                                point.LegendText = displayName;
                                point.Color = colors[colorIndex % colors.Length];
                                point.BackGradientStyle = GradientStyle.None;
                                point.BackSecondaryColor = Color.Transparent;
                                point.Font = new Font("Segoe UI", 9F);
                                originalColors[topProductsPieChart][pointIndex] = point.Color;
                                originalGradients[topProductsPieChart][pointIndex] = point.BackGradientStyle.ToString();
                                originalSecondaryColors[topProductsPieChart][pointIndex] = point.BackSecondaryColor;
                                originalFonts[topProductsPieChart][pointIndex] = point.Font;
                                originalYValues[topProductsPieChart][pointIndex] = (double)totalQuantity;

                                // Add legend item only if the display name is unique
                                if (uniqueDisplayNames.Add(displayName))
                                {
                                    LegendItem customItem = new LegendItem
                                    {
                                        Name = displayName,
                                        Color = point.Color,
                                        MarkerStyle = MarkerStyle.Circle,
                                        MarkerSize = 8
                                    };
                                    topProductsPieChart.Legends[0].CustomItems.Add(customItem);
                                    colorIndex++;
                                }
                            }
                        }
                    }
                }

                if (topProductsPieChart.Series["TopProducts"].Points.Count == 0)
                {
                    loadingTimers[topProductsPieChart].Stop();
                    topProductsPieChart.Titles.Clear();
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
                loadingTimers[topProductsPieChart].Stop();
                topProductsPieChart.Series["TopProducts"].Points.Clear();
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

        private void StartLoadingAnimation(Chart chart)
        {
            animationSteps[chart] = 0;
            sliceProgress[chart].Clear();
            for (int i = 0; i < chart.Series[0].Points.Count; i++)
            {
                sliceProgress[chart][i] = 0.0;
                chart.Series[0].Points[i]["PieStartAngle"] = "0";
                chart.Series[0].Points[i]["PieSweepAngle"] = "0";
                chart.Series[0].Points[i].Color = Color.FromArgb(0, chart.Series[0].Points[i].Color);
            }
            titleOpacity[chart] = 1.0;
            titleOffset[chart] = -50.0;
            loadingTimers[chart].Start();
        }

        private void LoadingAnimationTick(Chart chart)
        {
            animationSteps[chart]++;
            int totalSteps = 33;
            double progress = (double)animationSteps[chart] / totalSteps;

            double scaleProgress = progress < 0.5 ? 4 * progress * progress * progress : 1 - Math.Pow(-2 * progress + 2, 3) / 2;
            double scale = 0.8 + 0.3 * scaleProgress - 0.1 * Math.Sin(scaleProgress * Math.PI);

            double cumulativeAngle = 0;
            for (int i = 0; i < chart.Series[0].Points.Count; i++)
            {
                double sliceProgressValue = Math.Min(1.0, progress * chart.Series[0].Points.Count - i);
                if (sliceProgressValue < 0) sliceProgressValue = 0;
                sliceProgress[chart][i] = sliceProgressValue;

                double originalAngle = originalYValues[chart][i] / originalYValues[chart].Values.Sum() * 360;
                double currentAngle = originalAngle * sliceProgressValue;

                chart.Series[0].Points[i]["PieStartAngle"] = cumulativeAngle.ToString();
                chart.Series[0].Points[i]["PieSweepAngle"] = currentAngle.ToString();
                chart.Series[0].Points[i].Color = Color.FromArgb((int)(255 * sliceProgressValue), originalColors[chart][i]);
                chart.Series[0].Points[i]["PieRadius"] = (100 * scale).ToString();

                cumulativeAngle += currentAngle;
            }

            string titleText = chart == topCustomerPieChart ? "Top Customers" : chart == topExpensesDoughnutChart ? "Top Expenses" : "Top Products";
            titleOpacity[chart] = 1.0 - progress;
            titleOffset[chart] = -50.0 * (1.0 - progress);
            chart.Titles[0].Text = progress < 0.5 ? "Loading..." : titleText;
            chart.Titles[0].ForeColor = Color.FromArgb((int)(255 * (progress < 0.5 ? titleOpacity[chart] : progress)), progress < 0.5 ? Color.Gray : Color.Black);
            chart.Titles[0].Position.X = (float)(5 + titleOffset[chart] / 10);

            if (animationSteps[chart] >= totalSteps)
            {
                loadingTimers[chart].Stop();
                for (int i = 0; i < chart.Series[0].Points.Count; i++)
                {
                    chart.Series[0].Points[i]["PieRadius"] = "100";
                    chart.Series[0].Points[i].Color = originalColors[chart][i];
                }
                chart.Titles[0].Text = titleText;
                chart.Titles[0].ForeColor = Color.Black;
                chart.Titles[0].Position.X = 5;
            }

            chart.Invalidate();
        }

        private void StartHoverAnimation(Chart chart, int pointIndex, bool isHovering)
        {
            this.isHovering[chart] = isHovering;
            lastHoveredPointIndices[chart] = isHovering ? pointIndex : -1;
            animationSteps[chart] = 0;
            hoverTimers[chart].Start();
        }

        private void HoverAnimationTick(Chart chart)
        {
            animationSteps[chart]++;
            int totalSteps = 17;
            double progress = (double)animationSteps[chart] / totalSteps;

            double easeProgress = 1 - Math.Pow(1 - progress, 3);
            double targetRadius = isHovering[chart] ? 110.0 : 100.0;
            double targetOpacity = isHovering[chart] ? 100 : 0;
            Color targetColor = isHovering[chart] && lastHoveredPointIndices[chart] >= 0
                ? Color.FromArgb(
                    Math.Min(255, originalColors[chart][lastHoveredPointIndices[chart]].R + 50),
                    Math.Min(255, originalColors[chart][lastHoveredPointIndices[chart]].G + 50),
                    Math.Min(255, originalColors[chart][lastHoveredPointIndices[chart]].B + 50))
                : Color.Transparent;

            currentHoverRadius[chart] = currentHoverRadius[chart] + (targetRadius - currentHoverRadius[chart]) * easeProgress;
            currentHoverOpacity[chart] = (int)(currentHoverOpacity[chart] + (targetOpacity - currentHoverOpacity[chart]) * easeProgress);
            currentHoverColor[chart] = Color.FromArgb(
                (int)(currentHoverColor[chart].R + (targetColor.R - currentHoverColor[chart].R) * easeProgress),
                (int)(currentHoverColor[chart].G + (targetColor.G - currentHoverColor[chart].G) * easeProgress),
                (int)(currentHoverColor[chart].B + (targetColor.B - currentHoverColor[chart].B) * easeProgress));

            for (int i = 0; i < chart.Series[0].Points.Count; i++)
            {
                chart.Series[0].Points[i]["PieRadius"] = (i == lastHoveredPointIndices[chart] && isHovering[chart] ? currentHoverRadius[chart] : 100.0).ToString();
                chart.Series[0].Points[i].Color = i == lastHoveredPointIndices[chart] && isHovering[chart] ? currentHoverColor[chart] : originalColors[chart][i];
                chart.Series[0].Points[i].BackSecondaryColor = i == lastHoveredPointIndices[chart] && isHovering[chart]
                    ? Color.FromArgb(currentHoverOpacity[chart], 50, 50, 50)
                    : originalSecondaryColors[chart][i];
                chart.Legends[0].Font = i == lastHoveredPointIndices[chart] && isHovering[chart]
                    ? new Font("Segoe UI", 9F, FontStyle.Bold)
                    : originalFonts[chart][i];
                if (chart.Legends[0].CustomItems.Count > i)
                {
                    chart.Legends[0].CustomItems[i].MarkerSize = i == lastHoveredPointIndices[chart] && isHovering[chart] ? 10 : 8;
                }
            }

            if (animationSteps[chart] >= totalSteps)
            {
                hoverTimers[chart].Stop();
                for (int i = 0; i < chart.Series[0].Points.Count; i++)
                {
                    chart.Series[0].Points[i]["PieRadius"] = isHovering[chart] && i == lastHoveredPointIndices[chart] ? "110" : "100";
                    chart.Series[0].Points[i].Color = isHovering[chart] && i == lastHoveredPointIndices[chart] ? targetColor : originalColors[chart][i];
                    chart.Series[0].Points[i].BackSecondaryColor = isHovering[chart] && i == lastHoveredPointIndices[chart]
                        ? Color.FromArgb(100, 50, 50, 50)
                        : originalSecondaryColors[chart][i];
                }
            }

            chart.Invalidate();
        }

        private void PieChart_MouseMove(object sender, MouseEventArgs e)
        {
            Chart chart = (Chart)sender;
            var hit = chart.HitTest(e.X, e.Y);
            int pointIndex = hit.PointIndex;

            if (pointIndex >= 0 && hit.ChartElementType == ChartElementType.DataPoint)
            {
                if (lastHoveredPointIndices[chart] != pointIndex)
                {
                    StartHoverAnimation(chart, pointIndex, true);
                }
            }
            else if (lastHoveredPointIndices[chart] != -1)
            {
                StartHoverAnimation(chart, -1, false);
            }
        }

        private void PieChart_MouseLeave(object sender, EventArgs e)
        {
            Chart chart = (Chart)sender;
            if (lastHoveredPointIndices[chart] != -1)
            {
                StartHoverAnimation(chart, -1, false);
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
                    profitAmoutLabel.Text = $" {profit:#,##0.00}";

                    profitAmoutLabel.ForeColor = profit >= 0 ? Color.Green : Color.Red;
                }
            }
            catch (Exception)
            {
                dashTotSalePriceLabel.Text = " 0.00";
                purAmountLabel.Text = " 0.00";
                saleReAmountLabel.Text = " 0.00";
                profitAmoutLabel.Text = " 0.00";
                profitAmoutLabel.ForeColor = Color.Black;
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
        private void profitAmoutLabel_Click(object sender, EventArgs e)
        {
            todayBtn_Click(sender, e);
        }
        private void siticonePanel11_Paint(object sender, PaintEventArgs e) { }
        private void siticonePanel3_Paint(object sender, PaintEventArgs e) { }
    }
}