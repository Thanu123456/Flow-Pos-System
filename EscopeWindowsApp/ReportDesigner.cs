using System;
using System.IO;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Linq;

namespace EscopeWindowsApp
{
    public class ReportDesigner
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        private Document document;
        private Section section;

        public class CompanyDetails
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public byte[] Logo { get; set; }
            public string Website { get; set; }
        }

        private CompanyDetails GetCompanyDetails()
        {
            CompanyDetails details = new CompanyDetails();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name, email, phone_number, address, logo, website FROM company_details LIMIT 1";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                details.Name = reader["name"].ToString();
                                details.Email = reader["email"].ToString();
                                details.PhoneNumber = reader["phone_number"].ToString();
                                details.Address = reader["address"].ToString();
                                details.Website = reader["website"].ToString();
                                if (!reader.IsDBNull(reader.GetOrdinal("logo")))
                                {
                                    details.Logo = (byte[])reader["logo"];
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                details.Name = "Your Company Name";
                details.Email = "email@company.com";
                details.PhoneNumber = "Not available";
                details.Address = "Not available";
                details.Website = "Not available";
            }
            return details;
        }

        public Document CreateSalesReportDocument(DataTable salesTable, string dateFilter)
        {
            document = new Document();
            document.Info.Title = "Sales Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle(dateFilter);
            AddSummaryTable(salesTable);
            AddSpacer(); // Add explicit 1cm gap
            AddSalesTable(salesTable);
            AddFooter();

            return document;
        }

        private void DefineStyles()
        {
            Style style = document.Styles["Normal"];
            style.Font.Name = "Arial";
            style.Font.Size = 10;

            Style headerStyle = document.Styles.AddStyle("Header", "Normal");
            headerStyle.Font.Size = 12;
            headerStyle.Font.Bold = true;

            Style tableHeaderStyle = document.Styles.AddStyle("TableHeader", "Normal");
            tableHeaderStyle.Font.Bold = true;
            tableHeaderStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            tableHeaderStyle.ParagraphFormat.SpaceAfter = 5;

            Style tableCellStyle = document.Styles.AddStyle("TableCell", "Normal");
            tableCellStyle.ParagraphFormat.SpaceAfter = 2;
            tableCellStyle.ParagraphFormat.SpaceBefore = 2;

            Style summaryTableStyle = document.Styles.AddStyle("SummaryTable", "Normal");
            summaryTableStyle.Font.Size = 10;
            summaryTableStyle.ParagraphFormat.Alignment = ParagraphAlignment.Left;
        }

        private void AddHeader()
        {
            CompanyDetails details = GetCompanyDetails();
            Table headerTable = section.Headers.Primary.AddTable();
            headerTable.AddColumn(Unit.FromCentimeter(4));
            headerTable.AddColumn(Unit.FromCentimeter(12));

            Row row = headerTable.AddRow();
            row.Format.Alignment = ParagraphAlignment.Left;

            if (details.Logo != null && details.Logo.Length > 0)
            {
                try
                {
                    string tempPath = Path.Combine(Path.GetTempPath(), "company_logo.png");
                    File.WriteAllBytes(tempPath, details.Logo);
                    Image image = row.Cells[0].AddImage(tempPath);
                    image.Width = Unit.FromCentimeter(4.5);
                    image.LockAspectRatio = true;
                    image.RelativeVertical = RelativeVertical.Line;
                    image.RelativeHorizontal = RelativeHorizontal.Margin;
                    image.Left = ShapePosition.Left;
                }
                catch
                {
                    Paragraph placeholder = row.Cells[0].AddParagraph("Company Logo");
                    placeholder.Format.Font.Size = 8;
                    placeholder.Format.Alignment = ParagraphAlignment.Center;
                }
            }

            Paragraph companyInfo = row.Cells[1].AddParagraph();
            companyInfo.Style = "Header";
            companyInfo.AddFormattedText(details.Name, TextFormat.Bold);
            companyInfo.AddLineBreak();
            companyInfo.AddText(details.Address);
            companyInfo.AddLineBreak();
            companyInfo.AddText(details.Email);
            companyInfo.AddLineBreak();
            companyInfo.AddText(details.PhoneNumber);
            companyInfo.AddLineBreak();
            companyInfo.AddText(details.Website);
            companyInfo.Format.Alignment = ParagraphAlignment.Right;
            companyInfo.Format.SpaceAfter = 10;

            Paragraph line = section.Headers.Primary.AddParagraph();
            line.Format.Borders.Bottom.Width = 0.5;
            line.Format.SpaceAfter = 10;
        }

        private void AddReportTitle(string dateFilter)
        {
            Paragraph title = section.AddParagraph($"Sales Report ({dateFilter}) - {DateTime.Now:yyyy-MM-dd}");
            title.Format.Font.Size = 14;
            title.Format.Font.Bold = true;
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.SpaceBefore = 20;
            title.Format.SpaceAfter = 10;
        }

        private void AddSummaryTable(DataTable salesTable)
        {
            int totalTransactions = salesTable.Rows.Count;
            decimal totalSalesAmount = salesTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["total_price"]));
            decimal averageSalePrice = totalTransactions > 0 ? totalSalesAmount / totalTransactions : 0;

            Table summaryTable = section.AddTable();
            summaryTable.Borders.Width = 0.5;
            summaryTable.AddColumn(Unit.FromCentimeter(5));
            summaryTable.AddColumn(Unit.FromCentimeter(5));
            summaryTable.AddColumn(Unit.FromCentimeter(5));

            Row headerRow = summaryTable.AddRow();
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Total Transactions");
            headerRow.Cells[1].AddParagraph("Total Sales Amount");
            headerRow.Cells[2].AddParagraph("Average Sale Price");

            Row dataRow = summaryTable.AddRow();
            dataRow.Style = "SummaryTable";
            dataRow.Cells[0].AddParagraph(totalTransactions.ToString());
            dataRow.Cells[1].AddParagraph(totalSalesAmount.ToString("N2"));
            dataRow.Cells[2].AddParagraph(averageSalePrice.ToString("N2"));

            summaryTable.Format.SpaceAfter = 0; // Reset to 0 since spacer handles gap
        }

        private void AddSpacer()
        {
            Paragraph spacer = section.AddParagraph();
            spacer.Format.SpaceBefore = Unit.FromCentimeter(0.5); // Explicit 0.5cm gap
        }

        private void AddSalesTable(DataTable salesTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(2));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Bill Number");
            headerRow.Cells[1].AddParagraph("Customer Name");
            headerRow.Cells[2].AddParagraph("Username");
            headerRow.Cells[3].AddParagraph("Quantity");
            headerRow.Cells[4].AddParagraph("Payment");
            headerRow.Cells[5].AddParagraph("Total");
            headerRow.Cells[6].AddParagraph("Date");

            foreach (DataRow row in salesTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                string billNo = row["bill_no"].ToString().Replace("BILL_", "");
                dataRow.Cells[0].AddParagraph(billNo);
                dataRow.Cells[1].AddParagraph(row["customer"].ToString());
                dataRow.Cells[2].AddParagraph(row["user_name"].ToString());
                dataRow.Cells[3].AddParagraph(row["quantity_of_items"].ToString());
                dataRow.Cells[4].AddParagraph(row["payment_method"].ToString());
                dataRow.Cells[5].AddParagraph(Convert.ToDecimal(row["total_price"]).ToString("N2"));
                dataRow.Cells[6].AddParagraph(Convert.ToDateTime(row["sale_date"]).ToString("yyyy-MM-dd"));
            }

            decimal totalAmount = salesTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["total_price"]));
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TableHeader";
            totalRow.Shading.Color = Colors.SkyBlue;
            totalRow.Cells[0].MergeRight = 4;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[5].AddParagraph(totalAmount.ToString("N2"));
            totalRow.Cells[6].AddParagraph("");
        }

        private void AddFooter()
        {
            Paragraph footer = section.Footers.Primary.AddParagraph();
            footer.Format.Font.Size = 8;
            footer.Format.Alignment = ParagraphAlignment.Center;
            footer.AddText($"Generated on {DateTime.Now:yyyy-MM-dd HH:mm} - Flow POS by E Scope International (Pvt) Ltd. " +
                $"© 2020 All rights reserved. | Contact Us: 075 - 7119340");
            footer.Format.SpaceBefore = 10;
            footer.Format.Borders.Top.Width = 0.5;
        }
    }
}