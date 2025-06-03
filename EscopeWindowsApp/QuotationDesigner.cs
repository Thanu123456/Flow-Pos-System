using System;
using System.IO;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace EscopeWindowsApp
{
    public class QuotationDesigner
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

        public class QuotationItem
        {
            public int ItemNumber { get; set; }
            public string ProductName { get; set; }
            public string VariationType { get; set; }
            public string Unit { get; set; }
            public decimal Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal TotalPrice { get; set; }
        }

        public QuotationDesigner()
        {
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

        public Document CreateQuotationDocument(string quotationNo, string customerName, DateTime quotationDate, string shippingAddress, string notes, List<QuotationItem> items, decimal subtotal, decimal discount, decimal shipping, decimal total)
        {
            document = new Document();
            document.Info.Title = "Quotation";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            // Replace this line:
            // AddReportTitle($"{quotationNo}", DateTime.Now.ToString("yyyy-MM-dd"));

            // With this block:
            Table titleTable = section.AddTable();
            titleTable.Borders.Width = 0;
            titleTable.AddColumn(Unit.FromCentimeter(8));
            titleTable.AddColumn(Unit.FromCentimeter(8));

            Row titleRow = titleTable.AddRow();
            titleRow.Cells[0].AddParagraph($"No - {quotationNo}");
            titleRow.Cells[0].Format.Alignment = ParagraphAlignment.Left;
            titleRow.Cells[0].Format.Font.Size = 14;
            titleRow.Cells[0].Format.Font.Bold = true;
            titleRow.Cells[0].Format.Font.Color = Color.FromRgb(0, 51, 102);

            titleRow.Cells[1].AddParagraph($"Date -{DateTime.Now.ToString("yyyy-MM-dd")}");
            titleRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;
            titleRow.Cells[1].Format.Font.Size = 14;
            titleRow.Cells[1].Format.Font.Bold = true;
            titleRow.Cells[1].Format.Font.Color = Color.FromRgb(0, 51, 102);

            titleRow.BottomPadding = 10;

            // Add customer and shipping details
            Paragraph customerInfo = section.AddParagraph($"To: {customerName}");
            customerInfo.Format.Font.Size = 10;
            customerInfo.Format.SpaceAfter = 5;

            Paragraph shippingInfo = section.AddParagraph($"Shipping Address: {shippingAddress ?? "N/A"}");
            shippingInfo.Format.Font.Size = 10;
            shippingInfo.Format.SpaceAfter = 10;

            // Add "Valid Until" line using the quotationDate parameter
            Paragraph validUntilInfo = section.AddParagraph($"Valid Until: {quotationDate:yyyy-MM-dd}");
            validUntilInfo.Format.Font.Size = 10;
            validUntilInfo.Format.SpaceAfter = 10;

            // Add items table
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(1.5));
            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(2.5));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("No");
            headerRow.Cells[1].AddParagraph("Product Name");
            headerRow.Cells[2].AddParagraph("Variation Type");
            headerRow.Cells[3].AddParagraph("Unit");
            headerRow.Cells[4].AddParagraph("Quantity");
            headerRow.Cells[5].AddParagraph("Price (LKR)");
            headerRow.Cells[6].AddParagraph("Total Price (LKR)");

            headerRow.Cells[5].Format.Alignment = ParagraphAlignment.Right;
            headerRow.Cells[6].Format.Alignment = ParagraphAlignment.Right;

            int rowIndex = 0;
            foreach (var item in items)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(item.ItemNumber.ToString());
                dataRow.Cells[1].AddParagraph(item.ProductName);
                dataRow.Cells[2].AddParagraph(item.VariationType ?? "N/A");
                dataRow.Cells[3].AddParagraph(item.Unit);
                dataRow.Cells[4].AddParagraph(item.Quantity.ToString(item.Unit == "Pieces" ? "F0" : "F2"));
                dataRow.Cells[5].AddParagraph(item.Price.ToString("N2"));
                dataRow.Cells[6].AddParagraph(item.TotalPrice.ToString("N2"));

                dataRow.Cells[5].Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[6].Format.Alignment = ParagraphAlignment.Right;

                rowIndex++;
            }

            // Add a 3cm gap after the product table
            Paragraph gap = section.AddParagraph();
            gap.Format.SpaceAfter = Unit.FromCentimeter(1);

            // Add summary table
            Table summaryTable = section.AddTable();
            summaryTable.Borders.Width = 0.5;
            summaryTable.AddColumn(Unit.FromCentimeter(10));
            summaryTable.AddColumn(Unit.FromCentimeter(5));

            Row sumRow = summaryTable.AddRow();
            sumRow.Style = "SummaryTable";
            sumRow.Cells[0].AddParagraph("Subtotal (LKR)");
            sumRow.Cells[1].AddParagraph(subtotal.ToString("N2"));
            sumRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;

            sumRow = summaryTable.AddRow();
            sumRow.Style = "SummaryTable";
            sumRow.Cells[0].AddParagraph("Discount Amount (LKR)");
            sumRow.Cells[1].AddParagraph(discount.ToString("N2"));
            sumRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;

            sumRow = summaryTable.AddRow();
            sumRow.Style = "SummaryTable";
            sumRow.Cells[0].AddParagraph("Shipping Charge (LKR)");
            sumRow.Cells[1].AddParagraph(shipping.ToString("N2"));
            sumRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;

            sumRow = summaryTable.AddRow();
            sumRow.Height = Unit.FromCentimeter(0.8);
            sumRow.Style = "TotalRow";
            sumRow.Shading.Color = Color.FromRgb(173, 216, 230);
            sumRow.Cells[0].AddParagraph("Total Amount (LKR)");
            sumRow.Cells[1].AddParagraph(total.ToString("N2"));
            sumRow.Cells[1].Format.Alignment = ParagraphAlignment.Right;

            // Add notes if present
            if (!string.IsNullOrEmpty(notes))
            {
                Paragraph spacer = section.AddParagraph();
                spacer.Format.SpaceBefore = Unit.FromCentimeter(0.5);
                spacer.Format.Borders.Bottom.Width = 0.5;
                spacer.Format.Borders.Bottom.Color = Colors.Gray;

                Paragraph notesTitle = section.AddParagraph("Notes:");
                notesTitle.Format.Font.Bold = true;
                notesTitle.Format.SpaceBefore = 10;
                notesTitle.Format.SpaceAfter = 5;

                Paragraph notesPara = section.AddParagraph(notes);
                notesPara.Format.SpaceAfter = 10;
            }

            AddFooter();

            return document;
        }

        private void DefineStyles()
        {
            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 10;

            Style headerStyle = document.Styles.AddStyle("Header", "Normal");
            headerStyle.Font.Size = 12;
            headerStyle.Font.Bold = true;

            Style tableHeaderStyle = document.Styles.AddStyle("TableHeader", "Normal");
            tableHeaderStyle.Font.Bold = true;
            tableHeaderStyle.Font.Color = Colors.White;
            tableHeaderStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            tableHeaderStyle.ParagraphFormat.SpaceAfter = 5;

            Style tableCellStyle = document.Styles.AddStyle("TableCell", "Normal");
            tableCellStyle.ParagraphFormat.SpaceAfter = 2;
            tableCellStyle.ParagraphFormat.SpaceBefore = 2;
            tableCellStyle.ParagraphFormat.LeftIndent = Unit.FromMillimeter(2);
            tableCellStyle.ParagraphFormat.RightIndent = Unit.FromMillimeter(2);

            Style summaryTableStyle = document.Styles.AddStyle("SummaryTable", "Normal");
            summaryTableStyle.Font.Size = 10;
            summaryTableStyle.ParagraphFormat.Alignment = ParagraphAlignment.Left;
            summaryTableStyle.Font.Bold = true;

            Style totalRowStyle = document.Styles.AddStyle("TotalRow", "Normal");
            totalRowStyle.Font.Bold = true;
            totalRowStyle.Font.Color = Colors.Black;
            totalRowStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            totalRowStyle.ParagraphFormat.SpaceAfter = 5;
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

            Paragraph namePara = row.Cells[1].AddParagraph(details.Name);
            namePara.Format.Font.Size = 14;
            namePara.Format.Font.Bold = true;
            namePara.Format.Alignment = ParagraphAlignment.Right;

            Paragraph addressPara = row.Cells[1].AddParagraph(details.Address);
            addressPara.Format.Font.Size = 10;
            addressPara.Format.Alignment = ParagraphAlignment.Right;

            Paragraph emailPara = row.Cells[1].AddParagraph(details.Email);
            emailPara.Format.Font.Size = 10;
            emailPara.Format.Alignment = ParagraphAlignment.Right;

            Paragraph phonePara = row.Cells[1].AddParagraph(details.PhoneNumber);
            phonePara.Format.Font.Size = 10;
            phonePara.Format.Alignment = ParagraphAlignment.Right;

            Paragraph websitePara = row.Cells[1].AddParagraph(details.Website);
            websitePara.Format.Font.Size = 10;
            websitePara.Format.Alignment = ParagraphAlignment.Right;

            Paragraph line = section.Headers.Primary.AddParagraph();
            line.Format.Borders.Bottom.Width = 0.5;
            line.Format.Borders.Bottom.Color = Color.FromRgb(0, 51, 102);
            line.Format.SpaceAfter = 10;
        }

        private void AddReportTitle(string title, string dateFilter)
        {
            Paragraph titlePara = section.AddParagraph($"{title} - {dateFilter}");
            titlePara.Format.Font.Size = 14;
            titlePara.Format.Font.Bold = true;
            titlePara.Format.Font.Color = Color.FromRgb(0, 51, 102);
            titlePara.Format.Alignment = ParagraphAlignment.Center;
            titlePara.Format.SpaceBefore = 20;
            titlePara.Format.SpaceAfter = 10;
        }

        private void AddFooter()
        {
            Paragraph footer = section.Footers.Primary.AddParagraph();
            footer.Format.Font.Name = "Times New Roman";
            footer.Format.Font.Size = 8;
            footer.Format.Alignment = ParagraphAlignment.Center;
            footer.AddText($"Generated on {DateTime.Now:yyyy-MM-dd HH:mm} - Flow POS by E Scope International (Pvt) Ltd. " +
                $"© 2020 All rights reserved. | Contact Us: 075 - 7119340");
            footer.Format.SpaceBefore = 10;
            footer.Format.Borders.Top.Width = 0.5;
            footer.Format.Borders.Top.Color = Color.FromRgb(0, 51, 102);

            Paragraph pageNumber = section.Footers.Primary.AddParagraph();
            pageNumber.Format.Font.Name = "Times New Roman";
            pageNumber.Format.Font.Size = 8;
            pageNumber.Format.Alignment = ParagraphAlignment.Center;
            pageNumber.AddText("Page ");
            pageNumber.AddPageField();
            pageNumber.AddText(" of ");
            pageNumber.AddNumPagesField();
            pageNumber.Format.SpaceBefore = 5;
        }
    }
}