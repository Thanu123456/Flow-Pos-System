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
    public partial class PurchasesReturnReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable purchaseReturnTable;

        public PurchasesReturnReport()
        {
            InitializeComponent();
            purchaseReturnTable = new DataTable();
        }

        private void PurchasesReturnReport_Load(object sender, EventArgs e)
        {
            resonsFilterPurRetCombo.Items.AddRange(new string[] { "All Reasons", "Product Damaged or Defective", "Product Not as Described or Expected", "Expired Products", "Other" });
            resonsFilterPurRetCombo.SelectedIndex = 0;

            dateFilterPurRetCombo.Items.AddRange(new string[] { "Daily", "This Week", "Last Week", "Last Month", "Yearly" });
            dateFilterPurRetCombo.SelectedIndex = 0;

            LoadPurchaseReturnData();
            UpdateTotalAmount();
            ConfigureDataGridView();
        }

        private void LoadPurchaseReturnData(string searchText = "", string reasonFilter = "All Reasons", string dateFilter = "Daily")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT pr.return_no, pr.grn_no, p.name AS product_name, COALESCE(prd.variation_type, 'N/A') AS variation_type, prd.unit, 
                               prd.quantity, prd.cost_price, prd.net_price, pr.reason, pr.created_at
                        FROM purchase_return_details prd
                        JOIN purchase_returns pr ON prd.return_id = pr.id
                        JOIN products p ON prd.product_id = p.id
                        WHERE 1=1";

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (pr.return_no LIKE @searchText OR pr.grn_no LIKE @searchText)";
                    }
                    if (reasonFilter != "All Reasons")
                    {
                        query += " AND pr.reason = @reasonFilter";
                    }

                    DateTime now = DateTime.Now;
                    DateTime startDate = DateTime.MinValue;
                    DateTime endDate = DateTime.MaxValue;

                    switch (dateFilter)
                    {
                        case "Daily":
                            startDate = now.Date;
                            endDate = startDate.AddDays(1);
                            break;
                        case "This Week":
                            startDate = now.Date.AddDays(-(int)now.DayOfWeek); // Sunday of this week
                            endDate = startDate.AddDays(7); // Sunday of next week
                            break;
                        case "Last Week":
                            startDate = now.Date.AddDays(-(int)now.DayOfWeek - 7); // Sunday of last week
                            endDate = startDate.AddDays(7); // Sunday of this week
                            break;
                        case "Last Month":
                            startDate = new DateTime(now.Year, now.Month, 1).AddMonths(-1); // First day of last month
                            endDate = new DateTime(now.Year, now.Month, 1); // First day of this month
                            break;
                        case "Yearly":
                            startDate = new DateTime(now.Year, 1, 1); // Start of current year
                            endDate = new DateTime(now.Year + 1, 1, 1); // Start of next year
                            break;
                    }

                    query += " AND pr.created_at >= @startDate AND pr.created_at < @endDate";

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

                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            purchaseReturnTable.Clear();
                            adapter.Fill(purchaseReturnTable);
                            purRetReportDataGrid.DataSource = purchaseReturnTable;
                        }
                    }
                }

                generatePurRetPdfBtn.Enabled = purchaseReturnTable.Rows.Count > 0;
                generatePurRetExcelBtn.Enabled = purchaseReturnTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading purchase returns: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generatePurRetPdfBtn.Enabled = false;
                generatePurRetExcelBtn.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            if (purRetReportDataGrid.Columns["return_no"] != null)
                purRetReportDataGrid.Columns["return_no"].HeaderText = "Return No";
            if (purRetReportDataGrid.Columns["grn_no"] != null)
                purRetReportDataGrid.Columns["grn_no"].HeaderText = "GRN No";
            if (purRetReportDataGrid.Columns["product_name"] != null)
                purRetReportDataGrid.Columns["product_name"].HeaderText = "Product Name";
            if (purRetReportDataGrid.Columns["variation_type"] != null)
                purRetReportDataGrid.Columns["variation_type"].HeaderText = "Variation Type";
            if (purRetReportDataGrid.Columns["unit"] != null)
                purRetReportDataGrid.Columns["unit"].HeaderText = "Unit";
            if (purRetReportDataGrid.Columns["quantity"] != null)
                purRetReportDataGrid.Columns["quantity"].HeaderText = "Quantity";
            if (purRetReportDataGrid.Columns["cost_price"] != null)
                purRetReportDataGrid.Columns["cost_price"].HeaderText = "Cost Price";
            if (purRetReportDataGrid.Columns["net_price"] != null)
                purRetReportDataGrid.Columns["net_price"].HeaderText = "Net Price";
            if (purRetReportDataGrid.Columns["reason"] != null)
                purRetReportDataGrid.Columns["reason"].HeaderText = "Reason";
            if (purRetReportDataGrid.Columns["created_at"] != null)
                purRetReportDataGrid.Columns["created_at"].HeaderText = "Date";

            purRetReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateTotalAmount()
        {
            try
            {
                decimal totalAmount = 0;
                foreach (DataRow row in purchaseReturnTable.Rows)
                {
                    if (row["net_price"] != DBNull.Value)
                    {
                        totalAmount += Convert.ToDecimal(row["net_price"]);
                    }
                }
                purRetTotAmontLabel.Text = totalAmount.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                purRetTotAmontLabel.Text = "0.00";
            }
        }

        private void retNoSearchText_TextChanged(object sender, EventArgs e)
        {
            LoadPurchaseReturnData(
                retNoSearchText.Text,
                resonsFilterPurRetCombo.SelectedItem?.ToString() ?? "All Reasons",
                dateFilterPurRetCombo.SelectedItem?.ToString() ?? "Daily"
            );
            UpdateTotalAmount();
        }

        private void resonsFilterPurRetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPurchaseReturnData(
                retNoSearchText.Text,
                resonsFilterPurRetCombo.SelectedItem?.ToString() ?? "All Reasons",
                dateFilterPurRetCombo.SelectedItem?.ToString() ?? "Daily"
            );
            UpdateTotalAmount();
        }

        private void dateFilterPurRetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPurchaseReturnData(
                retNoSearchText.Text,
                resonsFilterPurRetCombo.SelectedItem?.ToString() ?? "All Reasons",
                dateFilterPurRetCombo.SelectedItem?.ToString() ?? "Daily"
            );
            UpdateTotalAmount();
        }

        private void purRetReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = purRetReportDataGrid.Rows[e.RowIndex];
                string details = $@"Purchase Return Details:
Return No: {row.Cells["return_no"].Value}
GRN No: {row.Cells["grn_no"].Value}
Product Name: {row.Cells["product_name"].Value}
Variation Type: {row.Cells["variation_type"].Value}
Unit: {row.Cells["unit"].Value}
Quantity: {row.Cells["quantity"].Value}
Cost Price: {row.Cells["cost_price"].Value}
Net Price: {row.Cells["net_price"].Value}
Reason: {row.Cells["reason"].Value}
Date: {row.Cells["created_at"].Value}";
                MessageBox.Show(details, "Purchase Return Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void purRetTotAmontLabel_Click(object sender, EventArgs e)
        {
            // No action required for label click
        }

        private void generatePurRetPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"PurchaseReturnReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Purchase Return Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    ReportDesigner designer = new ReportDesigner();
                    string dateFilter = dateFilterPurRetCombo.SelectedItem?.ToString() ?? "Daily";
                    string reasonFilter = resonsFilterPurRetCombo.SelectedItem?.ToString() ?? "All Reasons";
                    string filterDescription = $"{dateFilter} - {reasonFilter}";
                    var document = designer.CreatePurchaseReturnReportDocument(purchaseReturnTable, filterDescription);

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

        private void generatePurRetExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"PurchaseReturnReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.Title = "Save Purchase Return Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Purchase Return Report");
                        string reportTitle = $"Purchase Return Report ({dateFilterPurRetCombo.SelectedItem?.ToString() ?? "Daily"} - {resonsFilterPurRetCombo.SelectedItem?.ToString() ?? "All Reasons"}) - {DateTime.Now:yyyy-MM-dd}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 10).Merge().Style.Font.Bold = true;

                        worksheet.Cell(2, 1).Value = "Return No";
                        worksheet.Cell(2, 2).Value = "GRN No";
                        worksheet.Cell(2, 3).Value = "Product Name";
                        worksheet.Cell(2, 4).Value = "Variation Type";
                        worksheet.Cell(2, 5).Value = "Unit";
                        worksheet.Cell(2, 6).Value = "Quantity";
                        worksheet.Cell(2, 7).Value = "Cost Price";
                        worksheet.Cell(2, 8).Value = "Net Price";
                        worksheet.Cell(2, 9).Value = "Reason";
                        worksheet.Cell(2, 10).Value = "Date";
                        worksheet.Range(2, 1, 2, 10).Style.Font.Bold = true;

                        for (int i = 0; i < purchaseReturnTable.Rows.Count; i++)
                        {
                            DataRow row = purchaseReturnTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["return_no"]?.ToString();
                            worksheet.Cell(i + 3, 2).Value = row["grn_no"]?.ToString();
                            worksheet.Cell(i + 3, 3).Value = row["product_name"]?.ToString();
                            worksheet.Cell(i + 3, 4).Value = row["variation_type"]?.ToString();
                            worksheet.Cell(i + 3, 5).Value = row["unit"]?.ToString();
                            worksheet.Cell(i + 3, 6).Value = Convert.ToDecimal(row["quantity"]).ToString("N2");
                            worksheet.Cell(i + 3, 7).Value = Convert.ToDecimal(row["cost_price"]).ToString("N2");
                            worksheet.Cell(i + 3, 8).Value = Convert.ToDecimal(row["net_price"]).ToString("N2");
                            worksheet.Cell(i + 3, 9).Value = row["reason"]?.ToString();
                            worksheet.Cell(i + 3, 10).Value = Convert.ToDateTime(row["created_at"]).ToString("yyyy-MM-dd");
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