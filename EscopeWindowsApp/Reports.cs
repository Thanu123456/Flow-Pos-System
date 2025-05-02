using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class Reports : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;

        public Reports()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.Height = 850;
        }

        private void LoadTopProductsPieChart()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            product_name,
                            variation_type,
                            SUM(quantity) AS total_quantity
                        FROM 
                            sales_details
                        GROUP BY 
                            product_name, variation_type
                        ORDER BY 
                            total_quantity DESC
                        LIMIT 5";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            topProductsPieChart.Series.Clear();
                            var series = new Series
                            {
                                Name = "Top Products",
                                ChartType = SeriesChartType.Doughnut,
                                Label = "#PERCENT{P0}",
                                ToolTip = "#VALX: #VALY (#PERCENT{P0})"
                            };

                            while (reader.Read())
                            {
                                string productName = reader["product_name"].ToString();
                                string variationType = reader["variation_type"]?.ToString() ?? "N/A";
                                string displayName = $"{productName} - {variationType}";
                                decimal totalQuantity = Convert.ToDecimal(reader["total_quantity"]);
                                int pointIndex = series.Points.AddXY(displayName, totalQuantity);
                                series.Points[pointIndex].LegendText = displayName;
                            }

                            topProductsPieChart.Series.Add(series);
                            topProductsPieChart.Titles.Clear();

                            // Fixing the CS1503 error by using the correct constructor for the Title class.
                            topProductsPieChart.Titles.Add(new Title
                            {
                                Text = "Top 5 Products by Sales Quantity (All Time)",
                                Font = new Font("Segoe UI", 16, FontStyle.Bold)
                            });

                            // Ensure the legend is enabled and visible
                            if (topProductsPieChart.Legends.Count == 0)
                            {
                                topProductsPieChart.Legends.Add(new Legend("Default"));
                            }
                            topProductsPieChart.Legends[0].Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading top products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDailySalesBarChart()
        {
            try
            {
                DateTime today = DateTime.Today;
                int daysToSunday = (int)today.DayOfWeek;
                DateTime startOfWeek = today.AddDays(-daysToSunday);
                DateTime endOfWeek = startOfWeek.AddDays(7);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT DATE(sale_date) AS sale_day, SUM(total_price) AS daily_total
                        FROM sales
                        WHERE sale_date >= @startOfWeek AND sale_date < @endOfWeek
                        GROUP BY sale_day
                        ORDER BY sale_day";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@startOfWeek", startOfWeek);
                        command.Parameters.AddWithValue("@endOfWeek", endOfWeek);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            var salesData = new Dictionary<DateTime, decimal>();
                            while (reader.Read())
                            {
                                DateTime saleDay = reader.GetDateTime("sale_day");
                                decimal dailyTotal = reader.GetDecimal("daily_total");
                                salesData[saleDay] = dailyTotal;
                            }

                            var daysOfWeek = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
                            var dailyTotals = new decimal[7];
                            for (int i = 0; i < 7; i++)
                            {
                                DateTime day = startOfWeek.AddDays(i);
                                dailyTotals[i] = salesData.TryGetValue(day, out decimal total) ? total : 0;
                            }

                            // Calculate the maximum sales value for dynamic Y-axis scaling
                            decimal maxSales = dailyTotals.Any() ? dailyTotals.Max() : 1000; // Default to 1000 if no data
                            if (maxSales == 0) maxSales = 1000; // Ensure non-zero maximum for empty data

                            // Set Y-axis properties
                            chart1.ChartAreas[0].AxisY.Maximum = (double)(Math.Ceiling(maxSales / 1000) * 1000); // Round up to nearest 1000
                            chart1.ChartAreas[0].AxisY.Interval = chart1.ChartAreas[0].AxisY.Maximum / 5; // Divide into 5 intervals
                            chart1.ChartAreas[0].AxisY.Minimum = 0; // Start at 0
                            //chart1.ChartAreas[0].AxisY.Title = "Total Sales (LKR)";
                            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "LKR #,##0.00";

                            chart1.Series.Clear();
                            var series = new Series
                            {
                                Name = "Daily Sales",
                                ChartType = SeriesChartType.Column
                            };
                            for (int i = 0; i < 7; i++)
                            {
                                series.Points.AddXY(daysOfWeek[i], dailyTotals[i]);
                            }
                            chart1.Series.Add(series);

                            chart1.Titles.Clear();
                            string title = $"Daily Sales Total for Week of {startOfWeek.ToShortDateString()} to {startOfWeek.AddDays(6).ToShortDateString()}";
                            var chartTitle = new Title
                            {
                                Text = title,
                                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                                Alignment = ContentAlignment.MiddleCenter
                            };
                            chart1.Titles.Add(chartTitle);
                            //chart1.ChartAreas[0].AxisX.Title = "Day of Week";
                            //chart1.ChartAreas[0].AxisY.Title = "Total Sales (LKR)"; // Moved to Y-axis properties above
                            //chart1.ChartAreas[0].AxisY.LabelStyle.Format = "LKR #,##0.00"; // Moved to Y-axis properties above
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading daily sales chart: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadTopProductsPieChart();
            LoadDailySalesBarChart();
        }

        private void topProductsPieChart_Click(object sender, EventArgs e)
        {
            LoadTopProductsPieChart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            LoadDailySalesBarChart();
        }

        private void expReportBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is ExpencesReport)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            ExpencesReport expencesReport = new ExpencesReport();
            expencesReport.Show();
        }

        private void saleReportBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is SalesReport)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            SalesReport salesReport = new SalesReport();
            salesReport.Show();
        }

        private void stockReportBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is StockReport)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            StockReport stockReport = new StockReport();
            stockReport.Show();
        }

        private void cusReportBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is CustomersReport)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            CustomersReport customersReport = new CustomersReport();
            customersReport.Show();
        }

        private void supReportBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is SuppliersReport)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            SuppliersReport suppliersReport = new SuppliersReport();
            suppliersReport.Show();
        }

        private void logHistoryBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is LogsReport)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            LogsReport logsReport = new LogsReport();
            logsReport.Show();
        }

        private void purchasesReportBtn_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is PurchasesReport)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Normal;
                    }
                    form.BringToFront();
                    form.Activate();
                    return;
                }
            }
            PurchasesReport purchasesReport = new PurchasesReport();
            purchasesReport.Show();
        }
    }
}