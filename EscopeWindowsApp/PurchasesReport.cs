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
using System.Configuration; // Add this for ConfigurationManager

namespace EscopeWindowsApp
{
    public partial class PurchasesReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable purchasesTable;

        public PurchasesReport()
        {
            InitializeComponent();
        }

        private void PurchasesReport_Load(object sender, EventArgs e)
        {
            purchasesTable = new DataTable();
            dateFilterPurCombo.Items.AddRange(new string[] { "Daily", "Weekly", "Monthly", "Yearly" });
            dateFilterPurCombo.SelectedIndex = 0;
            LoadPurchasesData();
            UpdateTotalAmount();
        }

        private void LoadPurchasesData(string searchText = "", string dateFilter = "Daily")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT grn_no, payment_method, total_amount, date
                        FROM grn
                        WHERE 1=1";
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND grn_no LIKE @searchText";
                    }
                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND DATE(date) = @today";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND date >= @weekStart AND date <= @weekEnd";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND MONTH(date) = @month AND YEAR(date) = @year";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND YEAR(date) = @year";
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
                            purchasesTable.Clear();
                            adapter.Fill(purchasesTable);
                            purReportDataGrid.DataSource = purchasesTable;
                        }
                    }
                }
                ConfigureDataGridView();
                generatePurchasesPdfBtn.Enabled = purchasesTable.Rows.Count > 0;
                generatePurchasesExcelBtn.Enabled = purchasesTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading purchases: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generatePurchasesPdfBtn.Enabled = false;
                generatePurchasesExcelBtn.Enabled = false;
            }
        }

        private void ConfigureDataGridView()
        {
            if (purReportDataGrid.Columns["grn_no"] != null)
                purReportDataGrid.Columns["grn_no"].HeaderText = "GRN Number";
            if (purReportDataGrid.Columns["payment_method"] != null)
                purReportDataGrid.Columns["payment_method"].HeaderText = "PAYMENT METHOD";
            if (purReportDataGrid.Columns["total_amount"] != null)
                purReportDataGrid.Columns["total_amount"].HeaderText = "TOTAL AMOUNT";
            if (purReportDataGrid.Columns["date"] != null)
            {
                purReportDataGrid.Columns["date"].HeaderText = "DATE";
                purReportDataGrid.Columns["date"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            purReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void purSearchText_TextChanged(object sender, EventArgs e)
        {
            LoadPurchasesData(purSearchText.Text, dateFilterPurCombo.SelectedItem?.ToString() ?? "Daily");
            UpdateTotalAmount();
        }

        private void dateFilterPurCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPurchasesData(purSearchText.Text, dateFilterPurCombo.SelectedItem?.ToString() ?? "Daily");
            UpdateTotalAmount();
        }

        private void purReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = purReportDataGrid.Rows[e.RowIndex];
                string details = $@"Purchase Details:
                    GRN Number: {row.Cells["grn_no"].Value}
                    Payment Method: {row.Cells["payment_method"].Value}
                    Total Amount: {Convert.ToDecimal(row.Cells["total_amount"].Value):#,##0.00}
                    Date: {Convert.ToDateTime(row.Cells["date"].Value):yyyy-MM-dd}";
                MessageBox.Show(details, "Purchase Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void purTotAmontLabel_Click(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            try
            {
                decimal totalAmount = 0m;
                string dateFilter = dateFilterPurCombo.SelectedItem?.ToString() ?? "Daily";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT SUM(total_amount)
                        FROM grn
                        WHERE 1=1";
                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND DATE(date) = @today";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND date >= @weekStart AND date <= @weekEnd";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND MONTH(date) = @month AND YEAR(date) = @year";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND YEAR(date) = @year";
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
                purTotAmontLabel.Text = totalAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                purTotAmontLabel.Text = "0.00";
            }
        }

        private void generatePurchasesPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"PurchasesReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Purchases Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    // Use ReportDesigner to generate the PDF
                    ReportDesigner reportDesigner = new ReportDesigner();
                    string dateFilter = dateFilterPurCombo.SelectedItem?.ToString() ?? "Daily";
                    Document document = reportDesigner.CreatePurchasesReportDocument(purchasesTable, dateFilter);

                    // Render the document to PDF
                    PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
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

        private void generatePurchasesExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"PurchasesReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.Title = "Save Purchases Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Purchases Report");
                        string reportTitle = $"Purchases Report ({dateFilterPurCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now:yyyy-MM-dd}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 4).Merge().Style.Font.Bold = true;
                        worksheet.Cell(2, 1).Value = "GRN Number";
                        worksheet.Cell(2, 2).Value = "Payment Method";
                        worksheet.Cell(2, 3).Value = "Total Amount";
                        worksheet.Cell(2, 4).Value = "Date";
                        worksheet.Range(2, 1, 2, 4).Style.Font.Bold = true;
                        for (int i = 0; i < purchasesTable.Rows.Count; i++)
                        {
                            DataRow row = purchasesTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["grn_no"].ToString();
                            worksheet.Cell(i + 3, 2).Value = row["payment_method"].ToString();
                            worksheet.Cell(i + 3, 3).Value = Convert.ToDecimal(row["total_amount"]).ToString("F2");
                            worksheet.Cell(i + 3, 4).Value = Convert.ToDateTime(row["date"]).ToString("yyyy-MM-dd");
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