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
    public partial class CustomersReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable customersTable;

        public CustomersReport()
        {
            InitializeComponent();
        }

        private void CustomersReport_Load(object sender, EventArgs e)
        {
            customersTable = new DataTable();
            dateFilterCusCombo.Items.AddRange(new string[] { "Daily", "Weekly", "Monthly", "Yearly" });
            dateFilterCusCombo.SelectedIndex = 0;
            SetupActionColumn();
            LoadCustomersData();
        }

        private void SetupActionColumn()
        {
            DataGridViewImageColumn actionColumn = new DataGridViewImageColumn
            {
                Name = "Action",
                HeaderText = "ACTION",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Image = Properties.Resources.export_pdf
            };
            customersReportDataGrid.Columns.Add(actionColumn);
        }

        private void LoadCustomersData(string searchText = "", string dateFilter = "Daily")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            c.name AS customer_name, 
                            c.phone AS phone_number, 
                            COUNT(DISTINCT s.bill_no) AS total_sales, 
                            SUM(s.total_price) AS amount,
                            SUM(CASE WHEN s.payment_method = 'Cash' THEN s.total_price ELSE 0 END) AS paid
                        FROM customers c
                        LEFT JOIN sales s ON c.name = s.customer
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (c.name LIKE @searchText OR c.phone LIKE @searchText)";
                    }

                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND (s.sale_date IS NULL OR DATE(s.sale_date) = @today)";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND (s.sale_date IS NULL OR (s.sale_date >= @weekStart AND s.sale_date <= @weekEnd))";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND (s.sale_date IS NULL OR (MONTH(s.sale_date) = @month AND YEAR(s.sale_date) = @year))";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND (s.sale_date IS NULL OR YEAR(s.sale_date) = @year)";
                    }

                    query += " GROUP BY c.name, c.phone";

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
                            customersTable.Clear();
                            adapter.Fill(customersTable);
                            customersReportDataGrid.AutoGenerateColumns = false;
                            if (customersReportDataGrid.Columns.Count == 1) // Only Action column exists initially
                            {
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "customer_name", DataPropertyName = "customer_name", HeaderText = "CUSTOMER" });
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "phone_number", DataPropertyName = "phone_number", HeaderText = "PHONE NUMBER" });
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "total_sales", DataPropertyName = "total_sales", HeaderText = "TOTAL SALES" });
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "amount", DataPropertyName = "amount", HeaderText = "AMOUNT" });
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "paid", DataPropertyName = "paid", HeaderText = "CASH" });

                                customersReportDataGrid.Columns["customer_name"].DisplayIndex = 0;
                                customersReportDataGrid.Columns["phone_number"].DisplayIndex = 1;
                                customersReportDataGrid.Columns["total_sales"].DisplayIndex = 2;
                                customersReportDataGrid.Columns["amount"].DisplayIndex = 3;
                                customersReportDataGrid.Columns["paid"].DisplayIndex = 4;
                                customersReportDataGrid.Columns["Action"].DisplayIndex = 5;
                            }
                            customersReportDataGrid.DataSource = customersTable;
                        }
                    }
                }

                ConfigureDataGridView();
                generateCustomersPdfBtn.Enabled = customersTable.Rows.Count > 0;
                generateCustomersExcelBtn.Enabled = customersTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generateCustomersPdfBtn.Enabled = false;
                generateCustomersExcelBtn.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            if (customersReportDataGrid.Columns["amount"] != null)
                customersReportDataGrid.Columns["amount"].DefaultCellStyle.Format = "LKR #,##0.00";
            if (customersReportDataGrid.Columns["paid"] != null)
                customersReportDataGrid.Columns["paid"].DefaultCellStyle.Format = "LKR #,##0.00";

            customersReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void customerSearchText_TextChanged(object sender, EventArgs e)
        {
            LoadCustomersData(customerSearchText.Text, dateFilterCusCombo.SelectedItem?.ToString() ?? "Daily");
        }

        private void dateFilterCusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomersData(customerSearchText.Text, dateFilterCusCombo.SelectedItem?.ToString() ?? "Daily");
        }

        private void customersReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && customersReportDataGrid.Columns[e.ColumnIndex].Name == "Action")
            {
                string customerName = customersReportDataGrid.Rows[e.RowIndex].Cells["customer_name"].Value?.ToString() ?? "";
                GenerateCustomerHistoryPdf(customerName);
            }
        }

        private void GenerateCustomerHistoryPdf(string customerName)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"CustomerHistory_{customerName}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Customer History PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    DataTable customerSales = new DataTable();
                    DataTable customerDetails = new DataTable();
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string salesQuery = @"
                            SELECT 
                                s.bill_no, 
                                s.customer, 
                                s.user_name, 
                                s.quantity_of_items, 
                                s.payment_method, 
                                s.total_price, 
                                s.sale_date
                            FROM sales s
                            WHERE s.customer = @customerName";
                        using (MySqlCommand command = new MySqlCommand(salesQuery, connection))
                        {
                            command.Parameters.AddWithValue("@customerName", customerName);
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(customerSales);
                            }
                        }

                        string detailsQuery = @"
                            SELECT 
                                sd.bill_no, 
                                sd.product_name, 
                                sd.variation_type, 
                                sd.unit, 
                                sd.quantity, 
                                sd.price, 
                                sd.total_price
                            FROM sales_details sd
                            WHERE sd.bill_no IN (
                                SELECT bill_no FROM sales WHERE customer = @customerName
                            )";
                        using (MySqlCommand command = new MySqlCommand(detailsQuery, connection))
                        {
                            command.Parameters.AddWithValue("@customerName", customerName);
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(customerDetails);
                            }
                        }
                    }

                    Document document = new Document();
                    document.Info.Title = $"Customer History - {customerName}";
                    document.Info.Author = "EscopeWindowsApp";

                    Section section = document.AddSection();
                    section.PageSetup = document.DefaultPageSetup.Clone();
                    section.PageSetup.TopMargin = Unit.FromCentimeter(4);
                    section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
                    section.PageSetup.RightMargin = Unit.FromCentimeter(2);
                    section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

                    // Use the constructor to initialize ReportDesigner
                    ReportDesigner reportDesigner = new ReportDesigner(document, section);

                    // Call methods directly
                    reportDesigner.DefineStyles();
                    reportDesigner.AddHeader();

                    // Add report title
                    Paragraph title = section.AddParagraph($"Customer Sales History: {customerName}");
                    title.Format.Font.Size = 14;
                    title.Format.Font.Bold = true;
                    title.Format.Alignment = ParagraphAlignment.Center;
                    title.Format.SpaceBefore = 20;
                    title.Format.SpaceAfter = 10;

                    // Call AddCustomerHistoryTable
                    reportDesigner.AddCustomerHistoryTable(customerSales, customerDetails);

                    // Add footer
                    reportDesigner.AddFooter();

                    // Replace the obsolete constructor with the parameterless constructor
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer();
                    renderer.Document = document;
                    renderer.RenderDocument();
                    renderer.PdfDocument.Save(saveFileDialog.FileName);

                    MessageBox.Show($"Customer history PDF generated successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Exception: {ex.InnerException.Message}";
                    if (ex.InnerException.StackTrace != null)
                    {
                        errorMessage += $"\nStack Trace: {ex.InnerException.StackTrace}";
                    }
                }
                MessageBox.Show($"Error generating customer history PDF: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateCustomersPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"CustomersReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Customers Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    ReportDesigner reportDesigner = new ReportDesigner();
                    string dateFilter = dateFilterCusCombo.SelectedItem?.ToString() ?? "Daily";
                    Document document = reportDesigner.CreateCustomersReportDocument(customersTable, dateFilter);

                    // Replace the obsolete constructor with the parameterless constructor
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer();
                    renderer.Document = document;
                    renderer.RenderDocument();
                    renderer.PdfDocument.Save(saveFileDialog.FileName);

                    MessageBox.Show($"PDF generated successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Attempt to open in browser
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

                    // Optional printing with user confirmation
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

        private void generateCustomersExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"CustomersReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.Title = "Save Customers Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Customers Report");

                        string reportTitle = $"Customers Report ({dateFilterCusCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now:yyyy-MM-dd}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 5).Merge().Style.Font.Bold = true;

                        worksheet.Cell(2, 1).Value = "CUSTOMER";
                        worksheet.Cell(2, 2).Value = "PHONE NUMBER";
                        worksheet.Cell(2, 3).Value = "TOTAL SALES";
                        worksheet.Cell(2, 4).Value = "AMOUNT";
                        worksheet.Cell(2, 5).Value = "PAID";
                        worksheet.Range(2, 1, 2, 5).Style.Font.Bold = true;

                        for (int i = 0; i < customersTable.Rows.Count; i++)
                        {
                            DataRow row = customersTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["customer_name"].ToString();
                            worksheet.Cell(i + 3, 2).Value = row["phone_number"].ToString();
                            worksheet.Cell(i + 3, 3).Value = row["total_sales"]?.ToString() ?? "0";
                            worksheet.Cell(i + 3, 4).Value = Convert.ToDecimal(row["amount"] ?? 0);
                            // Use LKR to match the DataGridView
                            worksheet.Cell(i + 3, 4).Style.NumberFormat.Format = "LKR #,##0.00";
                            worksheet.Cell(i + 3, 5).Value = Convert.ToDecimal(row["paid"] ?? 0);
                            worksheet.Cell(i + 3, 5).Style.NumberFormat.Format = "LKR #,##0.00";
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