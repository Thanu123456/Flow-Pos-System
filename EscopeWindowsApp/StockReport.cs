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
    public partial class StockReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable stockTable;

        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            // Initialize DataTable for stock
            stockTable = new DataTable();

            // Populate category filter combo box
            LoadCategories();

            // Load all stock initially
            LoadStockData();

            // Wire up CellFormatting event for red color on low stock
            stockReportDataGrid.CellFormatting += stockReportDataGrid_CellFormatting;
        }

        private void LoadCategories()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name FROM categories ORDER BY name";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            caterotyFilterCombo.Items.Add("All Categories");
                            while (reader.Read())
                            {
                                caterotyFilterCombo.Items.Add(reader["name"].ToString());
                            }
                        }
                    }
                }
                caterotyFilterCombo.SelectedIndex = 0; // Default to "All Categories"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStockData(string searchText = "", bool zeroStockFilter = false, string categoryFilter = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            p.name AS product_name,
                            u.unit_name,
                            b.name AS brand_name,
                            COALESCE(pr.variation_type, 'N/A') AS variation_type,
                            COALESCE(c.name, 'N/A') AS category_name,
                            SUM(COALESCE(s.stock, 0)) AS stock
                        FROM products p
                        LEFT JOIN units u ON p.unit_id = u.id
                        LEFT JOIN brands b ON p.brand_id = b.id
                        LEFT JOIN variations v ON p.variation_type_id = v.id
                        LEFT JOIN pricing pr ON p.id = pr.product_id
                        LEFT JOIN stock s ON p.id = s.product_id AND 
                            (pr.variation_type IS NULL OR pr.variation_type = s.variation_type)
                        LEFT JOIN categories c ON p.category_id = c.id
                        WHERE 1=1";

                    // Add search filter if provided
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (p.name LIKE @searchText OR b.name LIKE @searchText OR pr.variation_type LIKE @searchText)";
                    }

                    // Add category filter if provided
                    if (!string.IsNullOrEmpty(categoryFilter) && categoryFilter != "All Categories")
                    {
                        query += " AND c.name = @categoryFilter";
                    }

                    query += " GROUP BY p.id, p.name, u.unit_name, b.name, pr.variation_type, c.name";

                    // Add zero stock filter using HAVING clause
                    query += zeroStockFilter ? " HAVING SUM(COALESCE(s.stock, 0)) = 0" : " HAVING SUM(COALESCE(s.stock, 0)) > 0";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters for search
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }

                        // Add parameter for category filter
                        if (!string.IsNullOrEmpty(categoryFilter) && categoryFilter != "All Categories")
                        {
                            command.Parameters.AddWithValue("@categoryFilter", categoryFilter);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            stockTable.Clear();
                            adapter.Fill(stockTable);
                            stockReportDataGrid.DataSource = stockTable;
                        }
                    }
                }

                // Configure DataGridView columns
                ConfigureDataGridView();

                // Enable or disable PDF and Excel buttons based on data
                generateStockPdfBtn.Enabled = stockTable.Rows.Count > 0;
                generateStockExcelBtn.Enabled = stockTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Disable buttons in case of error
                generateStockPdfBtn.Enabled = false;
                generateStockExcelBtn.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            // Ensure columns are correctly formatted and in the desired order
            if (stockReportDataGrid.Columns["product_name"] != null)
            {
                stockReportDataGrid.Columns["product_name"].HeaderText = "PRODUCT NAME";
                stockReportDataGrid.Columns["product_name"].DisplayIndex = 0;
            }
            if (stockReportDataGrid.Columns["category_name"] != null)
            {
                stockReportDataGrid.Columns["category_name"].HeaderText = "CATEGORY";
                stockReportDataGrid.Columns["category_name"].DisplayIndex = 1;
            }
            if (stockReportDataGrid.Columns["brand_name"] != null)
            {
                stockReportDataGrid.Columns["brand_name"].HeaderText = "BRAND";
                stockReportDataGrid.Columns["brand_name"].DisplayIndex = 2;
            }
            if (stockReportDataGrid.Columns["variation_type"] != null)
            {
                stockReportDataGrid.Columns["variation_type"].HeaderText = "VARIATION TYPE";
                stockReportDataGrid.Columns["variation_type"].DisplayIndex = 3;
            }
            if (stockReportDataGrid.Columns["unit_name"] != null)
            {
                stockReportDataGrid.Columns["unit_name"].HeaderText = "UNIT";
                stockReportDataGrid.Columns["unit_name"].DisplayIndex = 4;
            }
            if (stockReportDataGrid.Columns["stock"] != null)
            {
                stockReportDataGrid.Columns["stock"].HeaderText = "STOCK";
                stockReportDataGrid.Columns["stock"].DisplayIndex = 5;
            }

            // Adjust column widths
            stockReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void stockSearchText_TextChanged(object sender, EventArgs e)
        {
            LoadStockData(
                stockSearchText.Text,
                checkZeroStocks.Checked,
                caterotyFilterCombo.SelectedItem?.ToString() ?? "All Categories"
            );
        }

        private void checkZeroStocks_CheckedChanged(object sender, EventArgs e)
        {
            LoadStockData(
                stockSearchText.Text,
                checkZeroStocks.Checked,
                caterotyFilterCombo.SelectedItem?.ToString() ?? "All Categories"
            );
        }

        private void caterotyFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStockData(
                stockSearchText.Text,
                checkZeroStocks.Checked,
                caterotyFilterCombo.SelectedItem?.ToString() ?? "All Categories"
            );
        }

        private void stockReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display details in a message box
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = stockReportDataGrid.Rows[e.RowIndex];
                string details = $@"Stock Details:
                    Product Name: {row.Cells["product_name"].Value}
                    Category: {row.Cells["category_name"].Value ?? "N/A"}
                    Brand Name: {row.Cells["brand_name"].Value ?? "N/A"}
                    Variation Type: {row.Cells["variation_type"].Value ?? "N/A"}
                    Unit Name: {row.Cells["unit_name"].Value ?? "N/A"}
                    Stock: {row.Cells["stock"].Value}";
                MessageBox.Show(details, "Stock Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void stockReportDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the cell is in the stock column
            if (stockReportDataGrid.Columns[e.ColumnIndex].Name == "stock" && e.RowIndex >= 0)
            {
                // Get the stock value and unit name
                if (stockReportDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    decimal stockValue = Convert.ToDecimal(stockReportDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    string unitName = stockReportDataGrid.Rows[e.RowIndex].Cells["unit_name"].Value?.ToString()?.ToLower() ?? "";

                    // Set red color for stock less than 5
                    if (stockValue < 5)
                    {
                        e.CellStyle.ForeColor = System.Drawing.Color.Red;
                    }

                    // Format stock as integer if unit is "pieces", else use two decimal places
                    if (unitName == "pieces")
                    {
                        e.Value = ((int)stockValue).ToString();
                    }
                    else
                    {
                        e.Value = stockValue.ToString("F2");
                    }
                }
            }
        }

        private void generateStockPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"StockReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Stock Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    // Create an instance of ReportDesigner and generate the document
                    ReportDesigner reportDesigner = new ReportDesigner();
                    string category = caterotyFilterCombo.SelectedItem?.ToString() ?? "All Categories";
                    bool zeroStock = checkZeroStocks.Checked;
                    Document document = reportDesigner.CreateStockReportDocument(stockTable, category, zeroStock);

                    // Replace the obsolete constructor with the parameterless constructor
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

        private void generateStockExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show SaveFileDialog to let the user choose the save location
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"StockReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.Title = "Save Stock Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled the dialog
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Stock Report");

                        // Add title
                        string category = caterotyFilterCombo.SelectedItem?.ToString() ?? "All Categories";
                        string stockFilter = checkZeroStocks.Checked ? "Zero Stock" : "Non-Zero Stock";
                        string reportTitle = $"Stock Report - {category} ({stockFilter}) - {DateTime.Now:yyyy-MM-dd}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 6).Merge().Style.Font.Bold = true;

                        // Add headers
                        worksheet.Cell(2, 1).Value = "Product Name";
                        worksheet.Cell(2, 2).Value = "Category";
                        worksheet.Cell(2, 3).Value = "Brand Name";
                        worksheet.Cell(2, 4).Value = "Variation Type";
                        worksheet.Cell(2, 5).Value = "Unit Name";
                        worksheet.Cell(2, 6).Value = "Stock";
                        worksheet.Range(2, 1, 2, 6).Style.Font.Bold = true;

                        // Add data rows
                        for (int i = 0; i < stockTable.Rows.Count; i++)
                        {
                            DataRow row = stockTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["product_name"].ToString();
                            worksheet.Cell(i + 3, 2).Value = row["category_name"]?.ToString() ?? "N/A";
                            worksheet.Cell(i + 3, 3).Value = row["brand_name"]?.ToString() ?? "N/A";
                            worksheet.Cell(i + 3, 4).Value = row["variation_type"]?.ToString() ?? "N/A";
                            worksheet.Cell(i + 3, 5).Value = row["unit_name"]?.ToString() ?? "N/A";
                            decimal stockValue = Convert.ToDecimal(row["stock"]);
                            string unitName = row["unit_name"]?.ToString()?.ToLower() ?? "";
                            worksheet.Cell(i + 3, 6).Value = unitName == "pieces" ? ((int)stockValue).ToString() : stockValue.ToString("F2");
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