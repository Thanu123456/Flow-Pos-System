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
            // Initialize DataTable for customers
            customersTable = new DataTable();

            // Set up the date filter combo box
            dateFilterCusCombo.Items.AddRange(new string[] { "Daily", "Weekly", "Monthly", "Yearly" });
            dateFilterCusCombo.SelectedIndex = 0; // Default to Daily

            // Set up the Action column in the DataGridView before loading data
            SetupActionColumn();

            // Load all customers initially
            LoadCustomersData();
        }

        private void SetupActionColumn()
        {
            // Add an Action column with the export-pdf icon
            DataGridViewImageColumn actionColumn = new DataGridViewImageColumn
            {
                Name = "Action",
                HeaderText = "ACTION",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Image = Properties.Resources.export_pdf // Set the icon directly
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

                    // Query to aggregate customer data by joining customers and sales tables
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

                    // Add search filter if provided
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (c.name LIKE @searchText OR c.phone LIKE @searchText)";
                    }

                    // Add date filter (only apply if there are sales)
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
                            customersTable.Clear();
                            adapter.Fill(customersTable);
                            // Set AutoGenerateColumns to false to prevent overwriting the Action column
                            customersReportDataGrid.AutoGenerateColumns = false;
                            // Define the columns manually to match the DataTable
                            if (customersReportDataGrid.Columns.Count == 1) // Only Action column exists initially
                            {
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "customer_name", DataPropertyName = "customer_name", HeaderText = "CUSTOMER" });
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "phone_number", DataPropertyName = "phone_number", HeaderText = "PHONE NUMBER" });
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "total_sales", DataPropertyName = "total_sales", HeaderText = "TOTAL SALES" });
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "amount", DataPropertyName = "amount", HeaderText = "AMOUNT" });
                                customersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "paid", DataPropertyName = "paid", HeaderText = "CASH" });

                                // Set the display order: customer_name, phone_number, total_sales, amount, paid, Action
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

                // Configure DataGridView columns
                ConfigureDataGridView();

                // Enable or disable PDF and Excel buttons based on data
                generateCustomersPdfBtn.Enabled = customersTable.Rows.Count > 0;
                generateCustomersExcelBtn.Enabled = customersTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Disable buttons in case of error
                generateCustomersPdfBtn.Enabled = false;
                generateCustomersExcelBtn.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            // Format amount and paid columns with currency symbol
            if (customersReportDataGrid.Columns["amount"] != null)
                customersReportDataGrid.Columns["amount"].DefaultCellStyle.Format = "LKR #,##0.00";
            if (customersReportDataGrid.Columns["paid"] != null)
                customersReportDataGrid.Columns["paid"].DefaultCellStyle.Format = "LKR #,##0.00";

            // Adjust column widths
            customersReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Style the CUSTOMER column with a pink background
            foreach (DataGridViewRow row in customersReportDataGrid.Rows)
            {
                //if (row.Cells["customer_name"] != null)
                //{
                //    row.Cells["customer_name"].Style.BackColor = System.Drawing.Color.FromArgb(255, 204, 204); // Light pink color
                //}
            }
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
                // Handle Action column click (export-pdf icon)
                string customerName = customersReportDataGrid.Rows[e.RowIndex].Cells["customer_name"].Value.ToString();
                GenerateCustomerHistoryPdf(customerName);
            }
        }

        private void GenerateCustomerHistoryPdf(string customerName)
        {
            try
            {
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"CustomerHistory_{customerName}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
                    saveFileDialog.Title = "Save Customer History PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    // Fetch the customer's full sales history
                    DataTable customerSales = new DataTable();
                    DataTable customerDetails = new DataTable();
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Fetch sales data
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

                        // Fetch sales details for each bill
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

                    // Create a new MigraDoc document
                    Document document = new Document();
                    document.Info.Title = $"Customer History - {customerName}";
                    document.Info.Author = "EscopeWindowsApp";

                    // Add a section to the document
                    Section section = document.AddSection();

                    // Add a title
                    Paragraph title = section.AddParagraph($"Customer Sales History: {customerName}");
                    title.Format.Font.Size = 14;
                    title.Format.Font.Bold = true;
                    title.Format.SpaceAfter = 10;

                    // Add sales history table
                    foreach (DataRow sale in customerSales.Rows)
                    {
                        string billNo = sale["bill_no"].ToString();
                        Paragraph billTitle = section.AddParagraph($"Bill Number: {billNo} (Date: {Convert.ToDateTime(sale["sale_date"]).ToString("yyyy-MM-dd")})");
                        billTitle.Format.Font.Size = 12;
                        billTitle.Format.Font.Bold = true;
                        billTitle.Format.SpaceAfter = 5;

                        // Sales summary
                        Paragraph saleSummary = section.AddParagraph(
                            $"Username: {sale["user_name"]}, " +
                            $"Total Items: {sale["quantity_of_items"]}, " +
                            $"Payment Method: {sale["payment_method"]}, " +
                            $"Total Price: €{Convert.ToDecimal(sale["total_price"]).ToString("N2")}"
                        );
                        saleSummary.Format.SpaceAfter = 5;

                        // Create a table for sales details
                        Table table = section.AddTable();
                        table.Borders.Width = 0.5;
                        table.Rows.Height = 10;

                        // Define columns
                        table.AddColumn(Unit.FromCentimeter(4));  // Product Name
                        table.AddColumn(Unit.FromCentimeter(3));  // Variation Type
                        table.AddColumn(Unit.FromCentimeter(2));  // Unit
                        table.AddColumn(Unit.FromCentimeter(2));  // Quantity
                        table.AddColumn(Unit.FromCentimeter(2));  // Price
                        table.AddColumn(Unit.FromCentimeter(2));  // Total Price

                        // Add header row
                        Row headerRow = table.AddRow();
                        headerRow.HeadingFormat = true;
                        headerRow.Format.Font.Bold = true;
                        headerRow.Cells[0].AddParagraph("Product Name");
                        headerRow.Cells[1].AddParagraph("Variation Type");
                        headerRow.Cells[2].AddParagraph("Unit");
                        headerRow.Cells[3].AddParagraph("Quantity");
                        headerRow.Cells[4].AddParagraph("Price");
                        headerRow.Cells[5].AddParagraph("Total Price");

                        // Add sales details rows for this bill
                        DataRow[] detailsRows = customerDetails.Select($"bill_no = '{billNo}'");
                        foreach (DataRow detail in detailsRows)
                        {
                            Row dataRow = table.AddRow();
                            dataRow.Cells[0].AddParagraph(detail["product_name"].ToString());
                            dataRow.Cells[1].AddParagraph(detail["variation_type"]?.ToString() ?? "N/A");
                            dataRow.Cells[2].AddParagraph(detail["unit"].ToString());
                            dataRow.Cells[3].AddParagraph(detail["quantity"].ToString());
                            dataRow.Cells[4].AddParagraph(detail["price"].ToString());
                            dataRow.Cells[5].AddParagraph(detail["total_price"].ToString());
                        }

                        // Add spacing after each bill
                        section.AddParagraph("").Format.SpaceAfter = 10;
                    }

                    // Render the document to PDF
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
                    renderer.Document = document;
                    renderer.RenderDocument();

                    // Save the PDF to the user-selected location
                    renderer.PdfDocument.Save(saveFileDialog.FileName);

                    MessageBox.Show($"Customer history PDF generated successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating customer history PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateCustomersPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"CustomersReport_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
                    saveFileDialog.Title = "Save Customers Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    // Create a new MigraDoc document
                    Document document = new Document();
                    document.Info.Title = "Customers Report";
                    document.Info.Author = "EscopeWindowsApp";

                    // Add a section to the document
                    Section section = document.AddSection();

                    // Add a title
                    string reportTitle = $"Customers Report ({dateFilterCusCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now.ToString("yyyy-MM-dd")}";
                    Paragraph title = section.AddParagraph(reportTitle);
                    title.Format.Font.Size = 14;
                    title.Format.Font.Bold = true;
                    title.Format.SpaceAfter = 10;

                    // Create a table
                    Table table = section.AddTable();
                    table.Borders.Width = 0.5;
                    table.Rows.Height = 10;

                    // Define columns (removed DUE)
                    table.AddColumn(Unit.FromCentimeter(4));  // Customer
                    table.AddColumn(Unit.FromCentimeter(3));  // Phone Number
                    table.AddColumn(Unit.FromCentimeter(3));  // Total Sales
                    table.AddColumn(Unit.FromCentimeter(3));  // Amount
                    table.AddColumn(Unit.FromCentimeter(3));  // Paid

                    // Add header row
                    Row headerRow = table.AddRow();
                    headerRow.HeadingFormat = true;
                    headerRow.Format.Font.Bold = true;
                    headerRow.Cells[0].AddParagraph("CUSTOMER");
                    headerRow.Cells[1].AddParagraph("PHONE NUMBER");
                    headerRow.Cells[2].AddParagraph("TOTAL SALES");
                    headerRow.Cells[3].AddParagraph("AMOUNT");
                    headerRow.Cells[4].AddParagraph("PAID");

                    // Add data rows
                    foreach (DataRow row in customersTable.Rows)
                    {
                        Row dataRow = table.AddRow();
                        dataRow.Cells[0].AddParagraph(row["customer_name"].ToString());
                        dataRow.Cells[1].AddParagraph(row["phone_number"].ToString());
                        dataRow.Cells[2].AddParagraph(row["total_sales"]?.ToString() ?? "0");
                        dataRow.Cells[3].AddParagraph($"€{Convert.ToDecimal(row["amount"] ?? 0).ToString("N2")}");
                        dataRow.Cells[4].AddParagraph($"€{Convert.ToDecimal(row["paid"] ?? 0).ToString("N2")}");
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

        private void generateCustomersExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"CustomersReport_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
                    saveFileDialog.Title = "Save Customers Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Customers Report");

                        // Add title
                        string reportTitle = $"Customers Report ({dateFilterCusCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now.ToString("yyyy-MM-dd")}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 5).Merge().Style.Font.Bold = true;

                        // Add headers (removed DUE)
                        worksheet.Cell(2, 1).Value = "CUSTOMER";
                        worksheet.Cell(2, 2).Value = "PHONE NUMBER";
                        worksheet.Cell(2, 3).Value = "TOTAL SALES";
                        worksheet.Cell(2, 4).Value = "AMOUNT";
                        worksheet.Cell(2, 5).Value = "PAID";
                        worksheet.Range(2, 1, 2, 5).Style.Font.Bold = true;

                        // Add data rows
                        for (int i = 0; i < customersTable.Rows.Count; i++)
                        {
                            DataRow row = customersTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["customer_name"].ToString();
                            worksheet.Cell(i + 3, 2).Value = row["phone_number"].ToString();
                            worksheet.Cell(i + 3, 3).Value = row["total_sales"]?.ToString() ?? "0";
                            worksheet.Cell(i + 3, 4).Value = Convert.ToDecimal(row["amount"] ?? 0);
                            worksheet.Cell(i + 3, 4).Style.NumberFormat.Format = "€#,##0.00";
                            worksheet.Cell(i + 3, 5).Value = Convert.ToDecimal(row["paid"] ?? 0);
                            worksheet.Cell(i + 3, 5).Style.NumberFormat.Format = "€#,##0.00";
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