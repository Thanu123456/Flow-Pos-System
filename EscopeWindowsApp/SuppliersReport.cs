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
    public partial class SuppliersReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable suppliersTable;

        public SuppliersReport()
        {
            InitializeComponent();
        }

        private void SuppliersReport_Load(object sender, EventArgs e)
        {
            // Initialize DataTable for suppliers
            suppliersTable = new DataTable();

            // Set up the Action column in the DataGridView before loading data
            SetupActionColumn();

            // Load all suppliers initially
            LoadSuppliersData();
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
            suppliersReportDataGrid.Columns.Add(actionColumn);
        }

        private void LoadSuppliersData(string searchText = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to aggregate supplier data by joining suppliers, products, and grn_items tables
                    string query = @"
                        SELECT 
                            s.name AS supplier_name, 
                            s.phone AS phone_number, 
                            COUNT(DISTINCT gi.grn_id) AS purchases, 
                            SUM(gi.net_price) AS total_amount
                        FROM suppliers s
                        LEFT JOIN products p ON s.id = p.supplier_id
                        LEFT JOIN grn_items gi ON p.id = gi.product_id
                        WHERE 1=1";

                    // Add search filter if provided
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (s.name LIKE @searchText OR s.phone LIKE @searchText)";
                    }

                    query += " GROUP BY s.name, s.phone";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters for search
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            suppliersTable.Clear();
                            adapter.Fill(suppliersTable);
                            // Set AutoGenerateColumns to false to prevent overwriting the Action column
                            suppliersReportDataGrid.AutoGenerateColumns = false;
                            // Define the columns manually to match the DataTable
                            if (suppliersReportDataGrid.Columns.Count == 1) // Only Action column exists initially
                            {
                                suppliersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "supplier_name", DataPropertyName = "supplier_name", HeaderText = "SUPPLIER NAME" });
                                suppliersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "phone_number", DataPropertyName = "phone_number", HeaderText = "PHONE NUMBER" });
                                suppliersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "purchases", DataPropertyName = "purchases", HeaderText = "PURCHASES" });
                                suppliersReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "total_amount", DataPropertyName = "total_amount", HeaderText = "TOTAL AMOUNT" });

                                // Set the display order: supplier_name, phone_number, purchases, total_amount, Action
                                suppliersReportDataGrid.Columns["supplier_name"].DisplayIndex = 0;
                                suppliersReportDataGrid.Columns["phone_number"].DisplayIndex = 1;
                                suppliersReportDataGrid.Columns["purchases"].DisplayIndex = 2;
                                suppliersReportDataGrid.Columns["total_amount"].DisplayIndex = 3;
                                suppliersReportDataGrid.Columns["Action"].DisplayIndex = 4;
                            }
                            suppliersReportDataGrid.DataSource = suppliersTable;
                        }
                    }
                }

                // Configure DataGridView columns
                ConfigureDataGridView();

                // Enable or disable PDF and Excel buttons based on data
                generateSuppliersPdfBtn.Enabled = suppliersTable.Rows.Count > 0;
                generateSuppliersExcelBtn.Enabled = suppliersTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Disable buttons in case of error
                generateSuppliersPdfBtn.Enabled = false;
                generateSuppliersExcelBtn.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            // Format total_amount column with currency symbol
            if (suppliersReportDataGrid.Columns["total_amount"] != null)
            {
                suppliersReportDataGrid.Columns["total_amount"].DefaultCellStyle.Format = "LKR #,##0.00";
                suppliersReportDataGrid.Columns["total_amount"].DefaultCellStyle.NullValue = "LKR 0.00";
            }

            // Adjust column widths
            suppliersReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void supplierSearchText_TextChanged(object sender, EventArgs e)
        {
            LoadSuppliersData(supplierSearchText.Text);
        }

        private void suppliersReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && suppliersReportDataGrid.Columns[e.ColumnIndex].Name == "Action")
            {
                // Handle Action column click (export-pdf icon)
                string supplierName = suppliersReportDataGrid.Rows[e.RowIndex].Cells["supplier_name"].Value.ToString();
                GenerateSupplierHistoryPdf(supplierName);
            }
        }

        private void GenerateSupplierHistoryPdf(string supplierName)
        {
            try
            {
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"SupplierHistory_{supplierName}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Supplier History PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    // Fetch the supplier's full purchase history
                    DataTable supplierPurchases = new DataTable();
                    DataTable purchaseDetails = new DataTable();
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Fetch GRN data for the supplier
                        string purchasesQuery = @"
                            SELECT 
                                gi.grn_id, 
                                p.name AS product_name, 
                                gi.quantity, 
                                gi.cost_price, 
                                gi.net_price
                            FROM suppliers s
                            JOIN products p ON s.id = p.supplier_id
                            JOIN grn_items gi ON p.id = gi.product_id
                            WHERE s.name = @supplierName";
                        using (MySqlCommand command = new MySqlCommand(purchasesQuery, connection))
                        {
                            command.Parameters.AddWithValue("@supplierName", supplierName);
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(supplierPurchases);
                            }
                        }

                        // Fetch additional details for each GRN item
                        string detailsQuery = @"
                            SELECT 
                                gi.grn_id, 
                                p.name AS product_name, 
                                gi.variation_type, 
                                gi.unit, 
                                gi.quantity, 
                                gi.cost_price, 
                                gi.net_price, 
                                gi.expiry_date, 
                                gi.warranty
                            FROM suppliers s
                            JOIN products p ON s.id = p.supplier_id
                            JOIN grn_items gi ON p.id = gi.product_id
                            WHERE s.name = @supplierName";
                        using (MySqlCommand command = new MySqlCommand(detailsQuery, connection))
                        {
                            command.Parameters.AddWithValue("@supplierName", supplierName);
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(purchaseDetails);
                            }
                        }
                    }

                    // Create a new MigraDoc document
                    Document document = new Document();
                    document.Info.Title = $"Supplier History - {supplierName}";
                    document.Info.Author = "EscopeWindowsApp";

                    // Add a section to the document
                    Section section = document.AddSection();
                    section.PageSetup = document.DefaultPageSetup.Clone();
                    section.PageSetup.TopMargin = Unit.FromCentimeter(4);
                    section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
                    section.PageSetup.RightMargin = Unit.FromCentimeter(2);
                    section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

                    // Use ReportDesigner to build the document
                    ReportDesigner reportDesigner = new ReportDesigner(document, section);
                    reportDesigner.DefineStyles();
                    reportDesigner.AddHeader();

                    // Add a title
                    Paragraph title = section.AddParagraph($"Supplier Purchase History: {supplierName}");
                    title.Format.Font.Size = 14;
                    title.Format.Font.Bold = true;
                    title.Format.Alignment = ParagraphAlignment.Center;
                    title.Format.SpaceBefore = 20;
                    title.Format.SpaceAfter = 10;

                    // Add supplier history table
                    reportDesigner.AddSupplierHistoryTable(supplierPurchases, purchaseDetails);

                    // Add footer
                    reportDesigner.AddFooter();

                    // Render the document to PDF
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer();
                    renderer.Document = document;
                    renderer.RenderDocument();

                    // Save the PDF to the user-selected location
                    renderer.PdfDocument.Save(saveFileDialog.FileName);

                    MessageBox.Show($"Supplier history PDF generated successfully at {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Error generating supplier history PDF: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateSuppliersPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"SuppliersReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Suppliers Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    // Use ReportDesigner to generate the PDF
                    ReportDesigner reportDesigner = new ReportDesigner();
                    Document document = reportDesigner.CreateSuppliersReportDocument(suppliersTable, "All Time");

                    // Render the document to PDF
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer();
                    renderer.Document = document;
                    renderer.RenderDocument();

                    // Save the PDF to the user-selected location
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

        private void generateSuppliersExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"SuppliersReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.Title = "Save Suppliers Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Suppliers Report");

                        // Add title
                        string reportTitle = $"Suppliers Report - {DateTime.Now:yyyy-MM-dd}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 4).Merge().Style.Font.Bold = true;

                        // Add headers
                        worksheet.Cell(2, 1).Value = "SUPPLIER NAME";
                        worksheet.Cell(2, 2).Value = "PHONE NUMBER";
                        worksheet.Cell(2, 3).Value = "PURCHASES";
                        worksheet.Cell(2, 4).Value = "TOTAL AMOUNT";
                        worksheet.Range(2, 1, 2, 4).Style.Font.Bold = true;

                        // Add data rows
                        for (int i = 0; i < suppliersTable.Rows.Count; i++)
                        {
                            DataRow row = suppliersTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["supplier_name"].ToString();
                            worksheet.Cell(i + 3, 2).Value = row["phone_number"].ToString();
                            worksheet.Cell(i + 3, 3).Value = row["purchases"]?.ToString() ?? "0";
                            worksheet.Cell(i + 3, 4).Value = Convert.ToDecimal(row["total_amount"] ?? 0);
                            worksheet.Cell(i + 3, 4).Style.NumberFormat.Format = "LKR #,##0.00";
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