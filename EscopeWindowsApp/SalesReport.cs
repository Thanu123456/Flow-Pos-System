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

namespace EscopeWindowsApp
{
    public partial class SalesReport : Form
    {
        private string connectionString = "server=localhost;database=pos_system;uid=root;pwd=7777;";
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

                    // Add search filter if provided
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (bill_no LIKE @searchText OR customer LIKE @searchText OR user_name LIKE @searchText)";
                    }

                    // Add date filter
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
                            salesTable.Clear();
                            adapter.Fill(salesTable);
                            salesReportDataGrid.DataSource = salesTable;
                        }
                    }
                }

                // Configure DataGridView columns
                ConfigureDataGridView();

                // Enable or disable PDF and Excel buttons based on data
                generateSalesPdfBtn.Enabled = salesTable.Rows.Count > 0;
                generateSalesExcelBtn.Enabled = salesTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Disable buttons in case of error
                generateSalesPdfBtn.Enabled = false;
                generateSalesExcelBtn.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            // Ensure columns are correctly formatted
            if (salesReportDataGrid.Columns["bill_no"] != null)
                salesReportDataGrid.Columns["bill_no"].HeaderText = "Bill Number";
            if (salesReportDataGrid.Columns["customer"] != null)
                salesReportDataGrid.Columns["customer"].HeaderText = "Customer Name";
            if (salesReportDataGrid.Columns["user_name"] != null)
                salesReportDataGrid.Columns["user_name"].HeaderText = "Username";
            if (salesReportDataGrid.Columns["quantity_of_items"] != null)
                salesReportDataGrid.Columns["quantity_of_items"].HeaderText = "Quantity of Items";
            if (salesReportDataGrid.Columns["payment_method"] != null)
                salesReportDataGrid.Columns["payment_method"].HeaderText = "Payment Method";
            if (salesReportDataGrid.Columns["total_price"] != null)
                salesReportDataGrid.Columns["total_price"].HeaderText = "Total Price";
            if (salesReportDataGrid.Columns["sale_date"] != null)
                salesReportDataGrid.Columns["sale_date"].HeaderText = "Sale Date";

            // Adjust column widths
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
            // Display details in a message box
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
                // Calculate the total amount based on the current filter
                decimal totalAmount = 0m;
                string dateFilter = dateFilterSaleCombo.SelectedItem?.ToString() ?? "Daily";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to calculate the total amount based on the date filter
                    string query = @"
                        SELECT SUM(total_price)
                        FROM sales
                        WHERE 1=1";

                    // Add date filter
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
                salesTotAmontLabel.Text = totalAmount.ToString("F2");
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
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"SalesReport_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
                    saveFileDialog.Title = "Save Sales Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    // Create a new MigraDoc document
                    Document document = new Document();
                    document.Info.Title = "Sales Report";
                    document.Info.Author = "EscopeWindowsApp";

                    // Add a section to the document
                    Section section = document.AddSection();

                    // Add a title
                    string reportTitle = $"Sales Report ({dateFilterSaleCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now.ToString("yyyy-MM-dd")}";
                    Paragraph title = section.AddParagraph(reportTitle);
                    title.Format.Font.Size = 14;
                    title.Format.Font.Bold = true;
                    title.Format.SpaceAfter = 10;

                    // Create a table
                    Table table = section.AddTable();
                    table.Borders.Width = 0.5;
                    table.Rows.Height = 10;

                    // Define columns
                    table.AddColumn(Unit.FromCentimeter(3));  // Bill Number
                    table.AddColumn(Unit.FromCentimeter(3));  // Customer Name
                    table.AddColumn(Unit.FromCentimeter(3));  // Username
                    table.AddColumn(Unit.FromCentimeter(2));  // Quantity of Items
                    table.AddColumn(Unit.FromCentimeter(2));  // Payment Method
                    table.AddColumn(Unit.FromCentimeter(2));  // Total Price
                    table.AddColumn(Unit.FromCentimeter(3));  // Sale Date

                    // Add header row
                    Row headerRow = table.AddRow();
                    headerRow.HeadingFormat = true;
                    headerRow.Format.Font.Bold = true;
                    headerRow.Cells[0].AddParagraph("Bill Number");
                    headerRow.Cells[1].AddParagraph("Customer Name");
                    headerRow.Cells[2].AddParagraph("Username");
                    headerRow.Cells[3].AddParagraph("Quantity of Items");
                    headerRow.Cells[4].AddParagraph("Payment Method");
                    headerRow.Cells[5].AddParagraph("Total Price");
                    headerRow.Cells[6].AddParagraph("Sale Date");

                    // Add data rows
                    foreach (DataRow row in salesTable.Rows)
                    {
                        Row dataRow = table.AddRow();
                        dataRow.Cells[0].AddParagraph(row["bill_no"].ToString());
                        dataRow.Cells[1].AddParagraph(row["customer"].ToString());
                        dataRow.Cells[2].AddParagraph(row["user_name"].ToString());
                        dataRow.Cells[3].AddParagraph(row["quantity_of_items"].ToString());
                        dataRow.Cells[4].AddParagraph(row["payment_method"].ToString());
                        dataRow.Cells[5].AddParagraph(row["total_price"].ToString());
                        dataRow.Cells[6].AddParagraph(Convert.ToDateTime(row["sale_date"]).ToString("yyyy-MM-dd"));
                    }

                    // Render the document to PDF
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
                    renderer.Document = document;
                    renderer.RenderDocument();

                    // Save the PDF to the user-selected location
                    renderer.PdfDocument.Save(saveFileDialog.FileName);

                    MessageBox.Show($"PDF generated successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the PDF in the default browser
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
                        MessageBox.Show($"Error opening PDF in browser: {ex.Message}. Please ensure a default browser is set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Print the PDF using the default printer via the default PDF viewer
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
                            printProcess.WaitForExit(); // Wait for the printing process to complete
                        }

                        MessageBox.Show("PDF sent to printer successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error printing PDF: {ex.Message}. Ensure a default printer is configured and a PDF viewer supporting printing is installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"SalesReport_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
                    saveFileDialog.Title = "Save Sales Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Sales Report");

                        // Add title
                        string reportTitle = $"Sales Report ({dateFilterSaleCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now.ToString("yyyy-MM-dd")}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 7).Merge().Style.Font.Bold = true;

                        // Add headers
                        worksheet.Cell(2, 1).Value = "Bill Number";
                        worksheet.Cell(2, 2).Value = "Customer Name";
                        worksheet.Cell(2, 3).Value = "Username";
                        worksheet.Cell(2, 4).Value = "Quantity of Items";
                        worksheet.Cell(2, 5).Value = "Payment Method";
                        worksheet.Cell(2, 6).Value = "Total Price";
                        worksheet.Cell(2, 7).Value = "Sale Date";
                        worksheet.Range(2, 1, 2, 7).Style.Font.Bold = true;

                        // Add data rows
                        for (int i = 0; i < salesTable.Rows.Count; i++)
                        {
                            DataRow row = salesTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["bill_no"].ToString();
                            worksheet.Cell(i + 3, 2).Value = row["customer"].ToString();
                            worksheet.Cell(i + 3, 3).Value = row["user_name"].ToString();
                            worksheet.Cell(i + 3, 4).Value = row["quantity_of_items"].ToString();
                            worksheet.Cell(i + 3, 5).Value = row["payment_method"].ToString();
                            worksheet.Cell(i + 3, 6).Value = row["total_price"].ToString();
                            worksheet.Cell(i + 3, 7).Value = row["sale_date"].ToString();
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