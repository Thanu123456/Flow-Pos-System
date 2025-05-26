using ClosedXML.Excel;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class SalesReturnReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable salesReturnTable;

        public SalesReturnReport()
        {
            InitializeComponent();
            salesReturnTable = new DataTable();
        }

        private void SalesReturnReport_Load(object sender, EventArgs e)
        {
            resonsFilterSaleRetCombo.Items.AddRange(new string[] { "All Reasons", "Wrong Product", "Damaged Product", "Poor Quality Product", "Other" });
            resonsFilterSaleRetCombo.SelectedIndex = 0;

            dateFilterSaleRetCombo.Items.AddRange(new string[] { "Daily", "Weekly", "Monthly", "Yearly" });
            dateFilterSaleRetCombo.SelectedIndex = 0;

            LoadSalesReturnData();
            UpdateTotalAmount();
            ConfigureDataGridView();
        }

        private void LoadSalesReturnData(string searchText = "", string reasonFilter = "All Reasons", string dateFilter = "Daily")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT bill_no, product_name, COALESCE(variation_type, 'N/A') AS variation_type, 
                               unit, quantity, total_price, reason, refund_date
                        FROM refunds
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND bill_no LIKE @searchText";
                    }
                    if (reasonFilter != "All Reasons")
                    {
                        query += " AND reason = @reasonFilter";
                    }

                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND DATE(refund_date) = @today";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND refund_date >= @weekStart AND refund_date <= @weekEnd";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND MONTH(refund_date) = @month AND YEAR(refund_date) = @year";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND YEAR(refund_date) = @year";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        }
                        if (reasonFilter != "All Reasons")
                        {
                            command.Parameters.AddWithValue("@reasonFilter", reasonFilter);
                        }

                        if (dateFilter == "Daily")
                        {
                            command.Parameters.AddWithValue("@today", now.Date);
                        }
                        else if (dateFilter == "Weekly")
                        {
                            DateTime weekStart = now.Date.AddDays(-(int)now.DayOfWeek);
                            DateTime weekEnd = weekStart.AddDays(6).AddHours(23).AddMinutes(59).AddSeconds(59);
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
                            salesReturnTable.Clear();
                            adapter.Fill(salesReturnTable);
                            salesRetReportDataGrid.DataSource = salesReturnTable;
                        }
                    }
                }

                generateSalesRetPdfBtn.Enabled = salesReturnTable.Rows.Count > 0;
                generateSalesRetExcelBtn.Enabled = salesReturnTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales returns: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generateSalesRetPdfBtn.Enabled = false;
                generateSalesRetExcelBtn.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            if (salesRetReportDataGrid.Columns["bill_no"] != null)
                salesRetReportDataGrid.Columns["bill_no"].HeaderText = "Bill No";
            if (salesRetReportDataGrid.Columns["product_name"] != null)
                salesRetReportDataGrid.Columns["product_name"].HeaderText = "Product Name";
            if (salesRetReportDataGrid.Columns["variation_type"] != null)
                salesRetReportDataGrid.Columns["variation_type"].HeaderText = "Variation Type";
            if (salesRetReportDataGrid.Columns["unit"] != null)
                salesRetReportDataGrid.Columns["unit"].HeaderText = "Unit";
            if (salesRetReportDataGrid.Columns["quantity"] != null)
                salesRetReportDataGrid.Columns["quantity"].HeaderText = "Quantity";
            if (salesRetReportDataGrid.Columns["total_price"] != null)
                salesRetReportDataGrid.Columns["total_price"].HeaderText = "Total Price";
            if (salesRetReportDataGrid.Columns["reason"] != null)
                salesRetReportDataGrid.Columns["reason"].HeaderText = "Reason";
            if (salesRetReportDataGrid.Columns["refund_date"] != null)
                salesRetReportDataGrid.Columns["refund_date"].HeaderText = "Date";

            salesRetReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateTotalAmount()
        {
            try
            {
                decimal totalAmount = salesReturnTable.AsEnumerable()
                    .Sum(row => Convert.ToDecimal(row["total_price"]));
                salesRetTotAmontLabel.Text = totalAmount.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                salesRetTotAmontLabel.Text = "0.00";
            }
        }

        private void billNoSearchText_TextChanged(object sender, EventArgs e)
        {
            LoadSalesReturnData(
                billNoSearchText.Text,
                resonsFilterSaleRetCombo.SelectedItem?.ToString() ?? "All Reasons",
                dateFilterSaleRetCombo.SelectedItem?.ToString() ?? "Daily"
            );
            UpdateTotalAmount();
        }

        private void resonsFilterSaleRetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSalesReturnData(
                billNoSearchText.Text,
                resonsFilterSaleRetCombo.SelectedItem?.ToString() ?? "All Reasons",
                dateFilterSaleRetCombo.SelectedItem?.ToString() ?? "Daily"
            );
            UpdateTotalAmount();
        }

        private void dateFilterSaleRetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSalesReturnData(
                billNoSearchText.Text,
                resonsFilterSaleRetCombo.SelectedItem?.ToString() ?? "All Reasons",
                dateFilterSaleRetCombo.SelectedItem?.ToString() ?? "Daily"
            );
            UpdateTotalAmount();
        }

        private void salesRetReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = salesRetReportDataGrid.Rows[e.RowIndex];
                string details = $@"Sales Return Details:
                    Bill No: {row.Cells["bill_no"].Value}
                    Product Name: {row.Cells["product_name"].Value}
                    Variation Type: {row.Cells["variation_type"].Value}
                    Unit: {row.Cells["unit"].Value}
                    Quantity: {row.Cells["quantity"].Value}
                    Total Price: {row.Cells["total_price"].Value}
                    Reason: {row.Cells["reason"].Value}
                    Date: {row.Cells["refund_date"].Value}";
                MessageBox.Show(details, "Sales Return Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salesRetTotAmontLabel_Click(object sender, EventArgs e)
        {
            // This is the event handler for the salesRetTotAmontLabel Label.
        }

        private void generateSalesRetPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"SalesReturnReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Sales Return Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    ReportDesigner designer = new ReportDesigner();
                    string dateFilter = dateFilterSaleRetCombo.SelectedItem?.ToString() ?? "Daily";
                    string reasonFilter = resonsFilterSaleRetCombo.SelectedItem?.ToString() ?? "All Reasons";
                    // Combine dateFilter and reasonFilter into a single filterDescription
                    string filterDescription = $"{dateFilter} - {reasonFilter}";
                    var document = designer.CreateSalesReturnReportDocument(salesReturnTable, filterDescription);

                    PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
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

        private void generateSalesRetExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"SalesReturnReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.Title = "Save Sales Return Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Sales Return Report");

                        string reportTitle = $"Sales Return Report ({dateFilterSaleRetCombo.SelectedItem?.ToString() ?? "Daily"} - {resonsFilterSaleRetCombo.SelectedItem?.ToString() ?? "All Reasons"}) - {DateTime.Now:yyyy-MM-dd}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 8).Merge().Style.Font.Bold = true;

                        worksheet.Cell(2, 1).Value = "Bill No";
                        worksheet.Cell(2, 2).Value = "Product Name";
                        worksheet.Cell(2, 3).Value = "Variation Type";
                        worksheet.Cell(2, 4).Value = "Unit";
                        worksheet.Cell(2, 5).Value = "Quantity";
                        worksheet.Cell(2, 6).Value = "Total Price";
                        worksheet.Cell(2, 7).Value = "Reason";
                        worksheet.Cell(2, 8).Value = "Date";
                        worksheet.Range(2, 1, 2, 8).Style.Font.Bold = true;

                        for (int i = 0; i < salesReturnTable.Rows.Count; i++)
                        {
                            DataRow row = salesReturnTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["bill_no"].ToString();
                            worksheet.Cell(i + 3, 2).Value = row["product_name"].ToString();
                            worksheet.Cell(i + 3, 3).Value = row["variation_type"].ToString();
                            worksheet.Cell(i + 3, 4).Value = row["unit"].ToString();
                            worksheet.Cell(i + 3, 5).Value = Convert.ToDecimal(row["quantity"]).ToString("N2");
                            worksheet.Cell(i + 3, 6).Value = Convert.ToDecimal(row["total_price"]).ToString("N2");
                            worksheet.Cell(i + 3, 7).Value = row["reason"].ToString();
                            worksheet.Cell(i + 3, 8).Value = Convert.ToDateTime(row["refund_date"]).ToString("yyyy-MM-dd");
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