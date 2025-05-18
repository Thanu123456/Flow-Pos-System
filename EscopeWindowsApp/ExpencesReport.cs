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
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using ClosedXML.Excel;
using System.IO;
using System.Configuration;

namespace EscopeWindowsApp
{
    public partial class ExpencesReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable expensesTable;

        public ExpencesReport()
        {
            InitializeComponent();
            // Hook up CellFormatting event
            expencesReportDataGrid.CellFormatting += ExpencesReportDataGrid_CellFormatting;
        }

        private void ExpencesReport_Load(object sender, EventArgs e)
        {
            // Initialize DataTable for expenses
            expensesTable = new DataTable();

            // Set up the date filter combo box
            dateFilterCombo.Items.AddRange(new string[] { "Daily", "Weekly", "Monthly", "Yearly" });
            dateFilterCombo.SelectedIndex = 0; // Default to Daily

            // Load all expenses initially and update total amount
            LoadExpensesData();
            UpdateTotalAmountLabel();
        }

        private void UpdateTotalAmountLabel(string searchText = "", string dateFilter = "Daily")
        {
            try
            {
                decimal totalAmount = 0m;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to calculate the total amount based on the date filter and search text
                    string query = @"
                    SELECT SUM(e.amount)
                    FROM expenses e
                    WHERE 1=1";

                    // Add search filter if provided
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (e.title LIKE @searchText OR e.details LIKE @searchText)";
                    }

                    // Add date filter
                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND DATE(e.expense_date) = @today";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND e.expense_date >= @weekStart AND e.expense_date <= @weekEnd";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND MONTH(e.expense_date) = @month AND YEAR(e.expense_date) = @year";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND YEAR(e.expense_date) = @year";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters for search
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }

                        // Add parameters for date filter
                        if (dateFilter == "Daily")
                        {
                            command.Parameters.AddWithValue("@today", now.Date);
                        }
                        else if (dateFilter == "Weekly")
                        {
                            DateTime weekStart = now.Date.AddDays(-(int)now.DayOfWeek); // Start of the week (Sunday)
                            DateTime weekEnd = weekStart.AddDays(6); // End of the week (Saturday)
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

                        // Execute the query
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalAmount = Convert.ToDecimal(result);
                        }
                    }
                }

                // Update the label with the total amount
                expTotAmontLabel.Text = totalAmount.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expTotAmontLabel.Text = "0.00";
            }
        }

        private void LoadExpensesData(string searchText = "", string dateFilter = "Daily")
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
                    WHERE 1=1";

                    // Add search filter if provided
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (e.title LIKE @searchText OR e.details LIKE @searchText)";
                    }

                    // Add date filter
                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND DATE(e.expense_date) = @today";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND e.expense_date >= @weekStart AND e.expense_date <= @weekEnd";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND MONTH(e.expense_date) = @month AND YEAR(e.expense_date) = @year";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND YEAR(e.expense_date) = @year";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters for search
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }

                        // Add parameters for date filter
                        if (dateFilter == "Daily")
                        {
                            command.Parameters.AddWithValue("@today", now.Date);
                        }
                        else if (dateFilter == "Weekly")
                        {
                            DateTime weekStart = now.Date.AddDays(-(int)now.DayOfWeek); // Start of the week (Sunday)
                            DateTime weekEnd = weekStart.AddDays(6); // End of the week (Saturday)
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
                            expensesTable.Clear();
                            adapter.Fill(expensesTable);
                            expencesReportDataGrid.DataSource = expensesTable;
                        }
                    }
                }

                // Configure DataGridView columns
                ConfigureDataGridView();

                // Enable or disable PDF and Excel buttons based on data
                generatePdfBtn.Enabled = expensesTable.Rows.Count > 0;
                generateExcel.Enabled = expensesTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expenses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Disable buttons in case of error
                generatePdfBtn.Enabled = false;
                generateExcel.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            // Ensure columns are correctly formatted
            if (expencesReportDataGrid.Columns["id"] != null)
                expencesReportDataGrid.Columns["id"].HeaderText = "EXPENSES ID";
            if (expencesReportDataGrid.Columns["expense_date"] != null)
            {
                expencesReportDataGrid.Columns["expense_date"].HeaderText = "DATE";
                expencesReportDataGrid.Columns["expense_date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"; // Format matching Sales table
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
                expencesReportDataGrid.Columns["amount"].DefaultCellStyle.Format = "N2"; // Format as numeric with 2 decimal places
            }
            if (expencesReportDataGrid.Columns["details"] != null)
                expencesReportDataGrid.Columns["details"].HeaderText = "DETAILS";

            // Adjust column widths
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
            string dateFilter = dateFilterCombo.SelectedItem?.ToString() ?? "Daily";
            LoadExpensesData(searchText, dateFilter);
            UpdateTotalAmountLabel(searchText, dateFilter);
        }

        private void dateFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchText = expencesSearchText.Text;
            string dateFilter = dateFilterCombo.SelectedItem?.ToString() ?? "Daily";
            LoadExpensesData(searchText, dateFilter);
            UpdateTotalAmountLabel(searchText, dateFilter);
        }

        private void expencesReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display details in a message box
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = expencesReportDataGrid.Rows[e.RowIndex];
                string expenseId = row.Cells["id"].Value is int id ? $"EXP{id:D3}" : "N/A";
                string expenseDate = row.Cells["expense_date"].Value is DateTime date && date != DateTime.MinValue
                    ? date.ToString("yyyy-MM-dd HH:mm:ss")
                    : "N/A";
                string amount = row.Cells["amount"].Value is decimal amt ? amt.ToString("N2") : "N/A";
                string details = $@"Expense Details:
                ID: {expenseId}
                Date: {expenseDate}
                Title: {row.Cells["title"].Value ?? "N/A"}
                Warehouse Name: {row.Cells["warehouse_name"].Value ?? "N/A"}
                Category Name: {row.Cells["category_name"].Value ?? "N/A"}
                Amount: {amount}
                Details: {row.Cells["details"].Value ?? "N/A"}";
                MessageBox.Show(details, "Expense Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void generatePdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"ExpensesReport_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
                    saveFileDialog.Title = "Save Expenses Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    // Create a new MigraDoc document
                    Document document = new Document();
                    document.Info.Title = "Expenses Report";
                    document.Info.Author = "EscopeWindowsApp";

                    // Add a section to the document
                    Section section = document.AddSection();

                    // Add a title
                    string reportTitle = $"Expenses Report ({dateFilterCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now.ToString("yyyy-MM-dd")}";
                    Paragraph title = section.AddParagraph(reportTitle);
                    title.Format.Font.Size = 14;
                    title.Format.Font.Bold = true;
                    title.Format.SpaceAfter = 10;

                    // Create a table
                    Table table = section.AddTable();
                    table.Borders.Width = 0.5;
                    table.Rows.Height = 10;

                    // Define columns
                    table.AddColumn(Unit.FromCentimeter(1));  // ID
                    table.AddColumn(Unit.FromCentimeter(3));  // Date
                    table.AddColumn(Unit.FromCentimeter(3));  // Title
                    table.AddColumn(Unit.FromCentimeter(3));  // Warehouse Name
                    table.AddColumn(Unit.FromCentimeter(3));  // Category Name
                    table.AddColumn(Unit.FromCentimeter(2));  // Amount
                    table.AddColumn(Unit.FromCentimeter(5));  // Details

                    // Add header row
                    Row headerRow = table.AddRow();
                    headerRow.HeadingFormat = true;
                    headerRow.Format.Font.Bold = true;
                    headerRow.Cells[0].AddParagraph("ID");
                    headerRow.Cells[1].AddParagraph("Date");
                    headerRow.Cells[2].AddParagraph("Title");
                    headerRow.Cells[3].AddParagraph("Warehouse Name");
                    headerRow.Cells[4].AddParagraph("Category Name");
                    headerRow.Cells[5].AddParagraph("Amount");
                    headerRow.Cells[6].AddParagraph("Details");

                    // Add data rows
                    foreach (DataRow row in expensesTable.Rows)
                    {
                        Row dataRow = table.AddRow();
                        dataRow.Cells[0].AddParagraph(row["id"] is int id ? $"EXP{id:D3}" : "N/A");
                        dataRow.Cells[1].AddParagraph(row["expense_date"] is DateTime date && date != DateTime.MinValue
                            ? date.ToString("yyyy-MM-dd HH:mm:ss")
                            : "N/A");
                        dataRow.Cells[2].AddParagraph(row["title"]?.ToString() ?? "N/A");
                        dataRow.Cells[3].AddParagraph(row["warehouse_name"]?.ToString() ?? "N/A");
                        dataRow.Cells[4].AddParagraph(row["category_name"]?.ToString() ?? "N/A");
                        dataRow.Cells[5].AddParagraph(row["amount"] is decimal amount ? amount.ToString("N2") : "N/A");
                        dataRow.Cells[6].AddParagraph(row["details"]?.ToString() ?? "N/A");
                    }

                    // Render the document to PDF
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
                    renderer.Document = document;
                    renderer.RenderDocument();

                    // Save the PDF to the user-selected location
                    renderer.PdfDocument.Save(saveFileDialog.FileName);

                    MessageBox.Show($"PDF generated successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"ExpensesReport_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
                    saveFileDialog.Title = "Save Expenses Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Expenses Report");

                        // Add title
                        string reportTitle = $"Expenses Report ({dateFilterCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now.ToString("yyyy-MM-dd")}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 7).Merge().Style.Font.Bold = true;

                        // Add headers
                        worksheet.Cell(2, 1).Value = "ID";
                        worksheet.Cell(2, 2).Value = "Date";
                        worksheet.Cell(2, 3).Value = "Title";
                        worksheet.Cell(2, 4).Value = "Warehouse Name";
                        worksheet.Cell(2, 5).Value = "Category Name";
                        worksheet.Cell(2, 6).Value = "Amount";
                        worksheet.Cell(2, 7).Value = "Details";
                        worksheet.Range(2, 1, 2, 7).Style.Font.Bold = true;

                        // Add data rows
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

                        // Adjust column widths
                        worksheet.Columns().AdjustToContents();

                        // Save the Excel file to the user-selected location
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