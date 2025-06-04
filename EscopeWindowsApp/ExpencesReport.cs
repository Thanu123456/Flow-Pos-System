using ClosedXML.Excel;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class ExpencesReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable expensesTable;

        public ExpencesReport()
        {
            InitializeComponent();
            expencesReportDataGrid.CellFormatting += ExpencesReportDataGrid_CellFormatting;
        }

        private void ExpencesReport_Load(object sender, EventArgs e)
        {
            expensesTable = new DataTable();
            dateFilterCombo.Items.AddRange(new string[] { "This Week", "Last Week", "Last Month", "Yearly" });
            dateFilterCombo.SelectedIndex = 0; // Default to This Week
            LoadExpensesData();
            UpdateTotalAmountLabel();
        }

        private void UpdateTotalAmountLabel(string searchText = "", string dateFilter = "This Week")
        {
            try
            {
                decimal totalAmount = 0m;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT SUM(e.amount)
                        FROM expenses e
                        WHERE e.expense_date >= @start AND e.expense_date < @end";

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (e.title LIKE @searchText OR e.details LIKE @searchText)";
                    }

                    DateTime now = DateTime.Now;
                    DateTime start;
                    DateTime end;

                    switch (dateFilter)
                    {
                        case "This Week":
                            start = now.Date.AddDays(-(int)now.DayOfWeek); // Start from Sunday
                            end = start.AddDays(7); // End at next Sunday
                            break;
                        case "Last Week":
                            start = now.Date.AddDays(-(int)now.DayOfWeek - 7); // Sunday of last week
                            end = start.AddDays(7); // End at this Sunday
                            break;
                        case "Last Month":
                            DateTime firstDayOfCurrentMonth = new DateTime(now.Year, now.Month, 1);
                            start = firstDayOfCurrentMonth.AddMonths(-1); // First day of last month
                            end = firstDayOfCurrentMonth; // First day of this month
                            break;
                        case "Yearly":
                            start = new DateTime(now.Year, 1, 1); // January 1st of this year
                            end = new DateTime(now.Year + 1, 1, 1); // January 1st of next year
                            break;
                        default:
                            start = DateTime.MinValue;
                            end = DateTime.MaxValue;
                            break;
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@start", start);
                        command.Parameters.AddWithValue("@end", end);

                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalAmount = Convert.ToDecimal(result);
                        }
                    }
                }

                expTotAmontLabel.Text = totalAmount.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expTotAmontLabel.Text = "0.00";
            }
        }

        private void LoadExpensesData(string searchText = "", string dateFilter = "This Week")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT e.id, e.expense_date, e.title, w.name AS warehouse_name, c.name AS category_name, e.amount, e.details
                        FROM expenses e
                        LEFT JOIN warehouses w ON e.warehouse_id = w.id
                        LEFT JOIN categories c ON e.category_id = c.id
                        WHERE e.expense_date >= @start AND e.expense_date < @end";

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (e.title LIKE @searchText OR e.details LIKE @searchText)";
                    }

                    DateTime now = DateTime.Now;
                    DateTime start;
                    DateTime end;

                    switch (dateFilter)
                    {
                        case "This Week":
                            start = now.Date.AddDays(-(int)now.DayOfWeek); // Start from Sunday
                            end = start.AddDays(7); // End at next Sunday
                            break;
                        case "Last Week":
                            start = now.Date.AddDays(-(int)now.DayOfWeek - 7); // Sunday of last week
                            end = start.AddDays(7); // End at this Sunday
                            break;
                        case "Last Month":
                            DateTime firstDayOfCurrentMonth = new DateTime(now.Year, now.Month, 1);
                            start = firstDayOfCurrentMonth.AddMonths(-1); // First day of last month
                            end = firstDayOfCurrentMonth; // First day of this month
                            break;
                        case "Yearly":
                            start = new DateTime(now.Year, 1, 1); // January 1st of this year
                            end = new DateTime(now.Year + 1, 1, 1); // January 1st of next year
                            break;
                        default:
                            start = DateTime.MinValue;
                            end = DateTime.MaxValue;
                            break;
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@start", start);
                        command.Parameters.AddWithValue("@end", end);

                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            expensesTable.Clear();
                            adapter.Fill(expensesTable);
                            expencesReportDataGrid.DataSource = expensesTable;
                        }
                    }
                }

                ConfigureDataGridView();
                generatePdfBtn.Enabled = expensesTable.Rows.Count > 0;
                generateExcel.Enabled = expensesTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expenses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generatePdfBtn.Enabled = false;
                generateExcel.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            if (expencesReportDataGrid.Columns["id"] != null)
                expencesReportDataGrid.Columns["id"].HeaderText = "EXPENSES ID";
            if (expencesReportDataGrid.Columns["expense_date"] != null)
            {
                expencesReportDataGrid.Columns["expense_date"].HeaderText = "DATE";
                expencesReportDataGrid.Columns["expense_date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            }
            if (expencesReportDataGrid.Columns["title"] != null)
                expencesReportDataGrid.Columns["title"].HeaderText = "TITLE";
            if (expencesReportDataGrid.Columns["warehouse_name"] != null)
                expencesReportDataGrid.Columns["warehouse_name"].HeaderText = "WAREHOUSE";
            if (expencesReportDataGrid.Columns["category_name"] != null)
                expencesReportDataGrid.Columns["category_name"].HeaderText = "CATEGORY";
            if (expencesReportDataGrid.Columns["amount"] != null)
            {
                expencesReportDataGrid.Columns["amount"].HeaderText = "AMOUNT";
                expencesReportDataGrid.Columns["amount"].DefaultCellStyle.Format = "N2";
            }
            if (expencesReportDataGrid.Columns["details"] != null)
                expencesReportDataGrid.Columns["details"].HeaderText = "DETAILS";

            expencesReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ExpencesReportDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (expencesReportDataGrid.Columns[e.ColumnIndex].Name == "id")
            {
                if (e.Value is int id)
                {
                    e.Value = $"EXP{id:D3}";
                    e.FormattingApplied = true;
                }
            }
            else if (expencesReportDataGrid.Columns[e.ColumnIndex].Name == "expense_date")
            {
                if (e.Value is DateTime date && date != DateTime.MinValue)
                {
                    e.Value = date.ToString("yyyy-MM-dd HH:mm:ss");
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "N/A";
                    e.FormattingApplied = true;
                }
            }
            else if (expencesReportDataGrid.Columns[e.ColumnIndex].Name == "amount")
            {
                if (e.Value is decimal amount)
                {
                    e.Value = amount.ToString("N2");
                    e.FormattingApplied = true;
                }
                else
                {
                    e.Value = "N/A";
                    e.FormattingApplied = true;
                }
            }
        }

        private void expencesSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = expencesSearchText.Text;
            string dateFilter = dateFilterCombo.SelectedItem?.ToString() ?? "This Week";
            LoadExpensesData(searchText, dateFilter);
            UpdateTotalAmountLabel(searchText, dateFilter);
        }

        private void dateFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchText = expencesSearchText.Text;
            string dateFilter = dateFilterCombo.SelectedItem?.ToString() ?? "This Week";
            LoadExpensesData(searchText, dateFilter);
            UpdateTotalAmountLabel(searchText, dateFilter);
        }

        private void expencesReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = expencesReportDataGrid.Rows[e.RowIndex];
                string expenseId = row.Cells["id"].Value is int id ? $"EXP{id:D3}" : "N/A";
                string expenseDate = row.Cells["expense_date"].Value is DateTime date && date != DateTime.MinValue
                    ? date.ToString("yyyy-MM-dd HH:mm:ss") : "N/A";
                string amount = row.Cells["amount"].Value is decimal amt ? amt.ToString("N2") : "N/A";
                string details = $@"Expense Details:
ID: {expenseId}
Date: {expenseDate}
Title: {row.Cells["title"].Value?.ToString() ?? "N/A"}
Warehouse Name: {row.Cells["warehouse_name"].Value?.ToString() ?? "N/A"}
Category Name: {row.Cells["category_name"].Value?.ToString() ?? "N/A"}
Amount: {amount}
Details: {row.Cells["details"].Value?.ToString() ?? "N/A"}";
                MessageBox.Show(details, "Expense Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void generatePdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"ExpensesReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Expenses Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    ReportDesigner reportDesigner = new ReportDesigner();
                    Document document = reportDesigner.CreateExpensesReportDocument(expensesTable, dateFilterCombo.SelectedItem?.ToString() ?? "This Week");

                    // Replace the obsolete constructor with the parameterless constructor
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer();
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
                        MessageBox.Show($"Error opening PDF in browser: {ex.Message}. Please open the file manually at {saveFileDialog.FileName} using a PDF viewer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (MessageBox.Show("Would you like to print the PDF now?", "Print PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
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
                            MessageBox.Show($"Error printing PDF: {ex.Message}. Please open the file at {saveFileDialog.FileName} in a PDF viewer and print manually. Ensure a default printer is configured and a PDF viewer supporting printing is installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void expTotAmontLabel_Click(object sender, EventArgs e)
        {
            UpdateTotalAmountLabel();
        }

        private void generateExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"ExpensesReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.Title = "Save Expenses Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Expenses Report");
                        string reportTitle = $"Expenses Report ({dateFilterCombo.SelectedItem?.ToString() ?? "This Week"}) - {DateTime.Now:yyyy-MM-dd}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 7).Merge().Style.Font.Bold = true;

                        worksheet.Cell(2, 1).Value = "ID";
                        worksheet.Cell(2, 2).Value = "Date";
                        worksheet.Cell(2, 3).Value = "Title";
                        worksheet.Cell(2, 4).Value = "Warehouse Name";
                        worksheet.Cell(2, 5).Value = "Category Name";
                        worksheet.Cell(2, 6).Value = "Amount";
                        worksheet.Cell(2, 7).Value = "Details";
                        worksheet.Range(2, 1, 2, 7).Style.Font.Bold = true;

                        for (int i = 0; i < expensesTable.Rows.Count; i++)
                        {
                            DataRow row = expensesTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["id"] is int id ? $"EXP{id:D3}" : "N/A";
                            worksheet.Cell(i + 3, 2).Value = row["expense_date"] is DateTime date && date != DateTime.MinValue
                                ? date.ToString("yyyy-MM-dd HH:mm:ss")
                                : "N/A";
                            worksheet.Cell(i + 3, 3).Value = row["title"]?.ToString() ?? "N/A";
                            worksheet.Cell(i + 3, 4).Value = row["warehouse_name"]?.ToString() ?? "N/A";
                            worksheet.Cell(i + 3, 5).Value = row["category_name"]?.ToString() ?? "N/A";
                            worksheet.Cell(i + 3, 6).Value = row["amount"] is decimal amount ? amount.ToString("N2") : "N/A";
                            worksheet.Cell(i + 3, 7).Value = row["details"]?.ToString() ?? "N/A";
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