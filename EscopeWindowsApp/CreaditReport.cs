﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using ClosedXML.Excel;
using System.Configuration;
using System.IO;

namespace EscopeWindowsApp
{
    public partial class CreaditReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private DataTable grnCreditTable;

        public CreaditReport()
        {
            InitializeComponent();
            // Hook up CellFormatting event
            supCreaditsReportDataGrid.CellFormatting += SupCreaditsReportDataGrid_CellFormatting;
        }

        private void CreaditReport_Load(object sender, EventArgs e)
        {
            grnCreditTable = new DataTable();
            dateFilterSupCombo.Items.AddRange(new string[] { "Daily", "Weekly", "Monthly", "Yearly" });
            dateFilterSupCombo.SelectedIndex = 0; // Default to Daily
            LoadGRNCreditData();
            UpdateTotalCreditAmount();
        }

        private void ConfigureDataGridView()
        {
            supCreaditsReportDataGrid.AutoGenerateColumns = false;
            supCreaditsReportDataGrid.Columns.Clear();

            supCreaditsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "grn_no",
                DataPropertyName = "grn_no",
                HeaderText = "GRN NO"
            });
            supCreaditsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "supplier_name",
                DataPropertyName = "supplier_name",
                HeaderText = "SUPPLIER NAME"
            });
            supCreaditsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "credit_amount",
                DataPropertyName = "credit_amount",
                HeaderText = "CREDIT AMOUNT",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } // Format as numeric with 2 decimal places
            });
            supCreaditsReportDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "date",
                DataPropertyName = "date",
                HeaderText = "DATE",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm:ss" } // Format matching Sales table
            });
            supCreaditsReportDataGrid.Columns.Add(new DataGridViewImageColumn
            {
                Name = "Action",
                HeaderText = "ACTION",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Image = Properties.Resources.export_pdf
            });

            supCreaditsReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SupCreaditsReportDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (supCreaditsReportDataGrid.Columns[e.ColumnIndex].Name == "date")
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
            else if (supCreaditsReportDataGrid.Columns[e.ColumnIndex].Name == "credit_amount")
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

        private void LoadGRNCreditData(string searchText = "", string dateFilter = "Daily")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        g.grn_no,
                        (
                            SELECT s.name
                            FROM grn_items gi
                            JOIN products p ON gi.product_id = p.id
                            JOIN suppliers s ON p.supplier_id = s.id
                            WHERE gi.grn_id = g.id
                            ORDER BY gi.id
                            LIMIT 1
                        ) AS supplier_name,
                        g.total_amount AS credit_amount,
                        g.date
                    FROM grn g
                    WHERE g.payment_method = 'Credit'";

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (EXISTS (SELECT 1 FROM grn_items gi JOIN products p ON gi.product_id = p.id JOIN suppliers s ON p.supplier_id = s.id WHERE gi.grn_id = g.id AND (s.name LIKE @searchText OR s.id = @searchText)))";
                    }

                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND DATE(g.date) = @today";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND g.date >= @weekStart AND g.date <= @weekEnd";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND MONTH(g.date) = @month AND YEAR(g.date) = @year";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND YEAR(g.date) = @year";
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
                            grnCreditTable.Clear();
                            adapter.Fill(grnCreditTable);
                            supCreaditsReportDataGrid.DataSource = grnCreditTable;
                        }
                    }
                }

                ConfigureDataGridView();
                generateSupCreaditPdfBtn.Enabled = grnCreditTable.Rows.Count > 0;
                generateSupCreaditExcelBtn.Enabled = grnCreditTable.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading GRN credit data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generateSupCreaditPdfBtn.Enabled = false;
                generateSupCreaditExcelBtn.Enabled = false;
            }
        }

        private void UpdateTotalCreditAmount()
        {
            try
            {
                decimal totalAmount = 0m;
                string dateFilter = dateFilterSupCombo.SelectedItem?.ToString() ?? "Daily";
                string searchText = supplierSearchText.Text;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT SUM(g.total_amount)
                    FROM grn g
                    WHERE g.payment_method = 'Credit'";

                    if (!string.IsNullOrEmpty(searchText))
                    {
                        query += " AND (EXISTS (SELECT 1 FROM grn_items gi JOIN products p ON gi.product_id = p.id JOIN suppliers s ON p.supplier_id = s.id WHERE gi.grn_id = g.id AND (s.name LIKE @searchText OR s.id = @searchText)))";
                    }

                    DateTime now = DateTime.Now;
                    if (dateFilter == "Daily")
                    {
                        query += " AND DATE(g.date) = @today";
                    }
                    else if (dateFilter == "Weekly")
                    {
                        query += " AND g.date >= @weekStart AND g.date <= @weekEnd";
                    }
                    else if (dateFilter == "Monthly")
                    {
                        query += " AND MONTH(g.date) = @month AND YEAR(g.date) = @year";
                    }
                    else if (dateFilter == "Yearly")
                    {
                        query += " AND YEAR(g.date) = @year";
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

                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalAmount = Convert.ToDecimal(result);
                        }
                    }
                }

                creditTotAmontLabel.Text = totalAmount.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total credit amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                creditTotAmontLabel.Text = "0.00";
            }
        }

        private void creditTotAmontLabel_Click(object sender, EventArgs e)
        {
            UpdateTotalCreditAmount();
        }

        private void supplierSearchText_TextChanged(object sender, EventArgs e)
        {
            string searchText = supplierSearchText.Text;
            string dateFilter = dateFilterSupCombo.SelectedItem?.ToString() ?? "Daily";
            LoadGRNCreditData(searchText, dateFilter);
            UpdateTotalCreditAmount();
        }

        private void dateFilterSupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchText = supplierSearchText.Text;
            string dateFilter = dateFilterSupCombo.SelectedItem?.ToString() ?? "Daily";
            LoadGRNCreditData(searchText, dateFilter);
            UpdateTotalCreditAmount();
        }

        private void supCreaditsReportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && supCreaditsReportDataGrid.Columns[e.ColumnIndex].Name == "Action")
            {
                string grnNo = supCreaditsReportDataGrid.Rows[e.RowIndex].Cells["grn_no"].Value.ToString();
                GenerateGRNCreditDetailPdf(grnNo);
            }
        }

        private void GenerateGRNCreditDetailPdf(string grnNo)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"GRNDetail_{grnNo}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save GRN Detail PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    DataTable grnDetails = new DataTable();
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"
                        SELECT 
                            gi.product_id, p.name AS product_name, gi.variation_type, gi.unit, 
                            gi.quantity, gi.cost_price, (gi.quantity * gi.cost_price) AS total_price
                        FROM grn_items gi
                        JOIN products p ON gi.product_id = p.id
                        WHERE gi.grn_id = (SELECT id FROM grn WHERE grn_no = @grnNo)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@grnNo", grnNo);
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(grnDetails);
                            }
                        }
                    }

                    // Use ReportDesigner to generate the PDF
                    ReportDesigner reportDesigner = new ReportDesigner();
                    Document document = reportDesigner.CreateGRNCreditDetailReportDocument(grnDetails, grnNo);

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
                MessageBox.Show($"Error generating GRN detail PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateSupCreaditPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"SuppliersCreditReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    saveFileDialog.Title = "Save Suppliers Credit Report PDF";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    // Use ReportDesigner to generate the PDF
                    ReportDesigner reportDesigner = new ReportDesigner();
                    string dateFilter = dateFilterSupCombo.SelectedItem?.ToString() ?? "Daily";
                    Document document = reportDesigner.CreateSuppliersCreditReportDocument(grnCreditTable, dateFilter);

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

        private void generateSupCreaditExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"SuppliersCreditReport_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                    saveFileDialog.Title = "Save Suppliers Credit Report Excel";

                    if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Suppliers Credit Report");
                        string reportTitle = $"Suppliers Credit Report ({dateFilterSupCombo.SelectedItem?.ToString() ?? "Daily"}) - {DateTime.Now:yyyy-MM-dd}";
                        worksheet.Cell(1, 1).Value = reportTitle;
                        worksheet.Range(1, 1, 1, 4).Merge().Style.Font.Bold = true;

                        worksheet.Cell(2, 1).Value = "GRN NO";
                        worksheet.Cell(2, 2).Value = "SUPPLIER NAME";
                        worksheet.Cell(2, 3).Value = "CREDIT AMOUNT";
                        worksheet.Cell(2, 4).Value = "DATE";
                        worksheet.Range(2, 1, 2, 4).Style.Font.Bold = true;

                        for (int i = 0; i < grnCreditTable.Rows.Count; i++)
                        {
                            DataRow row = grnCreditTable.Rows[i];
                            worksheet.Cell(i + 3, 1).Value = row["grn_no"].ToString();
                            worksheet.Cell(i + 3, 2).Value = row["supplier_name"]?.ToString() ?? "N/A";
                            worksheet.Cell(i + 3, 3).Value = row["credit_amount"] is decimal amount ? amount.ToString("N2") : "N/A";
                            worksheet.Cell(i + 3, 4).Value = row["date"] is DateTime date && date != DateTime.MinValue
                                ? date.ToString("yyyy-MM-dd HH:mm:ss")
                                : "N/A";
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

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder for header panel painting if needed
        }
    }
}