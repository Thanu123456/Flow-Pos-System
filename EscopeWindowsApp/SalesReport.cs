using System;
using System.Data;
using System.Windows.Forms;
using MigraDoc.Rendering;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using System.Configuration;
using System.IO;

namespace EscopeWindowsApp
{
    public partial class SalesReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable salesTable;

        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            // Initialize DataTable for sales
            salesTable = new DataTable();

            // Set up the date filter combo box
            dateFilterSaleCombo.Items.AddRange(new string[] { "Daily", "Weekly", "Monthly", "Yearly" });
            dateFilterSaleCombo.SelectedIndex = 0; // Default to Daily

            // Load all sales initially and update total amount
            LoadSalesData();
            UpdateTotalAmount();
        }

        private void LoadSalesData(string searchText = "", string dateFilter = "Daily")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT bill_no, customer, user_name, quantity_of_items, payment_method, total_price, sale_date
                        FROM sales
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (bill_no LIKE @searchText OR customer LIKE @searchText OR user_name LIKE @searchText)";
                    }

                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND DATE(sale_date) = @today";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND sale_date >= @weekStart AND sale_date <= @weekEnd";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND MONTH(sale_date) = @month AND YEAR(sale_date) = @year";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND YEAR(sale_date) = @year";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }

                        if (dateFilter == "Daily")
                        {
                            command.Parameters.AddWithValue("@today", now.Date);
                        }
                        else if (dateFilter == "Weekly")
                        {
                            DateTime weekStart = now.Date.AddDays(-(int)now.DayOfWeek);
                            DateTime weekEnd = weekStart.AddDays(6);
                            command.Parameters.AddWithValue("@weekStart", weekStart);
                            command.Parameters.AddWithValue("@weekEnd", weekEnd);
                        }
                        else if (dateFilter == "Monthly")
                        {
                            command.Parameters.AddWithValue("@month", now.Month);
                            command.Parameters.AddWithValue("@year", now.Year);
                        }
                        else if (dateFilter == "Yearly")
                        {
                            command.Parameters.AddWithValue("@year", now.Year);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            salesTable.Clear();
                            adapter.Fill(salesTable);
                            salesReportDataGrid.DataSource = salesTable;
                        }
                    }
                }

                ConfigureDataGridView();

                generateSalesPdfBtn.Enabled = salesTable.Rows.Count > 0;
                generateSalesExcelBtn.Enabled = salesTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generateSalesPdfBtn.Enabled = false;
                generateSalesExcelBtn.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            if (salesReportDataGrid.Columns["bill_no"] != null)
                salesReportDataGrid.Columns["bill_no"].HeaderText = "BILL NO";
            if (salesReportDataGrid.Columns["customer"] != null)
                salesReportDataGrid.Columns["customer"].HeaderText = "CUSTOMER";
            if (salesReportDataGrid.Columns["user_name"] != null)
                salesReportDataGrid.Columns["user_name"].HeaderText = "USERNAME";
            if (salesReportDataGrid.Columns["quantity_of_items"] != null)
                salesReportDataGrid.Columns["quantity_of_items"].HeaderText = "QUANTITY OF ITEMS";
            if (salesReportDataGrid.Columns["payment_method"] != null)
                salesReportDataGrid.Columns["payment_method"].HeaderText = "PAYMENT METHOD";
            if (salesReportDataGrid.Columns["total_price"] != null)
                salesReportDataGrid.Columns["total_price"].HeaderText = "TOTAL PRICE";
            if (salesReportDataGrid.Columns["sale_date"] != null)
                salesReportDataGrid.Columns["sale_date"].HeaderText = "SALE DATE";

            salesReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void salesSearchText_TextChanged(object sender, EventArgs e)
        {
            LoadSalesData(salesSearchText.Text, dateFilterSaleCombo.SelectedItem?.ToString() ?? "Daily");
            UpdateTotalAmount();
        }

        private void dateFilterSaleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSalesData(salesSearchText.Text, dateFilterSaleCombo.SelectedItem?.ToString() ?? "Daily");
            UpdateTotalAmount();
        }

        private void salesReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = salesReportDataGrid.Rows[e.RowIndex];
                string details = $@"Sale Details:
                    Bill Number: {row.Cells["bill_no"].Value}
                    Customer Name: {row.Cells["customer"].Value}
                    Username: {row.Cells["user_name"].Value}
                    Quantity of Items: {row.Cells["quantity_of_items"].Value}
                    Payment Method: {row.Cells["payment_method"].Value}
                    Total Price: {row.Cells["total_price"].Value}
                    Sale Date: {row.Cells["sale_date"].Value}";
                MessageBox.Show(details, "Sale Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salesTotAmontLabel_Click(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            try
            {
                decimal totalAmount = 0m;
                string dateFilter = dateFilterSaleCombo.SelectedItem?.ToString() ?? "Daily";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT SUM(total_price)
                        FROM sales
                        WHERE 1=1";

                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND DATE(sale_date) = @today";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND sale_date >= @weekStart AND sale_date <= @weekEnd";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND MONTH(sale_date) = @month AND YEAR(sale_date) = @year";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND YEAR(sale_date) = @year";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        if (dateFilter == "Daily")
                        {
                            command.Parameters.AddWithValue("@today", now.Date);
                        }
                        else if (dateFilter == "Weekly")
                        {
                            DateTime weekStart = now.Date.AddDays(-(int)now.DayOfWeek);
                            DateTime weekEnd = weekStart.AddDays(6);
                            command.Parameters.AddWithValue("@weekStart", weekStart);
                            command.Parameters.AddWithValue("@weekEnd", weekEnd);
                        }
                        else if (dateFilter == "Monthly")
                        {
                            command.Parameters.AddWithValue("@month", now.Month);
                            command.Parameters.AddWithValue("@year", now.Year);
                        }
                        else if (dateFilter == "Yearly")
                        {
                            command.Parameters.AddWithValue("@year", now.Year);
                        }

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalAmount = Convert.ToDecimal(result);
                        }
                    }
                }

                salesTotAmontLabel.Text = totalAmount.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                salesTotAmontLabel.Text = "0.00";
            }
        }

        private void generateSalesPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"SalesReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Sales Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    ReportDesigner designer = new ReportDesigner();
                    var document = designer.CreateSalesReportDocument(salesTable, dateFilterSaleCombo.SelectedItem?.ToString() ?? "Daily");

                    PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
                    renderer.Document = document;
                    renderer.RenderDocument();
                    renderer.PdfDocument.Save(saveFileDialog.FileName);

                    MessageBox.Show($"PDF generated successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        string fileUrl = $"file:///{saveFileDialog.FileName.Replace("\\", "/")}";
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = fileUrl,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    try
                    {
                        System.Diagnostics.ProcessStartInfo printInfo = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            Verb = "print",
                            CreateNoWindow = true,
                            WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                            UseShellExecute = true
                        };

                        using (System.Diagnostics.Process printProcess = System.Diagnostics.Process.Start(printInfo))
                        {
                            printProcess.WaitForExit();
                        }

                        MessageBox.Show("PDF sent to printer successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error printing PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateSalesExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"SalesReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.Title = "Save Sales Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Sales Report");

                        string reportTitle = $"Sales Report ({dateFilterSaleCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now:yyyy-MM-dd}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 7).Merge().Style.Font.Bold = true;

                        worksheet.Cell(2, 1).Value = "Bill Number";
                        worksheet.Cell(2, 2).Value = "Customer Name";
                        worksheet.Cell(2, 3).Value = "Username";
                        worksheet.Cell(2, 4).Value = "Quantity of Items";
                        worksheet.Cell(2, 5).Value = "Payment Method";
                        worksheet.Cell(2, 6).Value = "Total Price";
                        worksheet.Cell(2, 7).Value = "Sale Date";
                        worksheet.Range(2, 1, 2, 7).Style.Font.Bold = true;

                        for (int i = 0; i < salesTable.Rows.Count; i++)
                        {
                            DataRow row = salesTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["bill_no"].ToString().Replace("BILL_", "");
                            worksheet.Cell(i + 3, 2).Value = row["customer"].ToString();
                            worksheet.Cell(i + 3, 3).Value = row["user_name"].ToString();
                            worksheet.Cell(i + 3, 4).Value = row["quantity_of_items"].ToString();
                            worksheet.Cell(i + 3, 5).Value = row["payment_method"].ToString();
                            worksheet.Cell(i + 3, 6).Value = Convert.ToDecimal(row["total_price"]).ToString("N2");
                            worksheet.Cell(i + 3, 7).Value = row["sale_date"].ToString();
                        }

                        worksheet.Columns().AdjustToContents();

                        workbook.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show($"Excel generated successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}