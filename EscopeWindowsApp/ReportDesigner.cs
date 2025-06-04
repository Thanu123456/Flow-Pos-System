using System;
using System.IO;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;

namespace EscopeWindowsApp
{
    public class ReportDesigner
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PosSystemConnection"].ConnectionString;
        public Document document;
        public Section section;

        public class CompanyDetails
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public byte[] Logo { get; set; }
            public string Website { get; set; }
        }

        public ReportDesigner()
        {
        }

        public ReportDesigner(Document doc, Section sec)
        {
            document = doc;
            section = sec;
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

        public Document CreateSalesReportDocument(System.Data.DataTable salesTable, string dateFilter)
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
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Sales Report", dateFilter);
            AddSummaryTable(salesTable);
            AddSpacer();
            AddSalesTable(salesTable);
            AddFooter();

            return document;
        }

        public Document CreateExpensesReportDocument(System.Data.DataTable expensesTable, string dateFilter)
        {
            document = new Document();
            document.Info.Title = "Expenses Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Expenses Report", dateFilter);
            AddExpensesSummaryTable(expensesTable);
            AddSpacer();
            AddExpensesTable(expensesTable);
            AddFooter();

            return document;
        }

        public Document CreateStockReportDocument(System.Data.DataTable stockTable, string categoryFilter, bool zeroStockFilter)
        {
            document = new Document();
            document.Info.Title = "Stock Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            string stockFilterText = zeroStockFilter ? "Zero Stock" : "Non-Zero Stock";
            AddReportTitle("Stock Report", $"{categoryFilter} ({stockFilterText})");
            AddStockTable(stockTable);
            AddFooter();

            return document;
        }

        public Document CreateCustomersReportDocument(System.Data.DataTable customersTable, string dateFilter)
        {
            document = new Document();
            document.Info.Title = "Customers Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Customers Report", dateFilter);
            AddCustomersTable(customersTable);
            AddFooter();

            return document;
        }

        public Document CreateSuppliersReportDocument(System.Data.DataTable suppliersTable, string dateFilter)
        {
            document = new Document();
            document.Info.Title = "Suppliers Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Suppliers Report", dateFilter);
            AddSuppliersTable(suppliersTable);
            AddFooter();

            return document;
        }

        public Document CreatePurchasesReportDocument(System.Data.DataTable purchasesTable, string dateFilter)
        {
            document = new Document();
            document.Info.Title = "Purchases Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.Orientation = Orientation.Landscape;
            section.PageSetup.TopMargin = Unit.FromCentimeter(2);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Purchases Report", dateFilter);
            AddPurchasesTable(purchasesTable);
            AddFooter();

            return document;
        }

        public Document CreateSuppliersCreditReportDocument(System.Data.DataTable grnCreditTable, string dateFilter)
        {
            document = new Document();
            document.Info.Title = "Suppliers Credit Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Suppliers Credit Report", dateFilter);
            AddSuppliersCreditTable(grnCreditTable);
            AddFooter();

            return document;
        }

        public Document CreateGRNCreditDetailReportDocument(System.Data.DataTable grnDetailsTable, string grnNo)
        {
            document = new Document();
            document.Info.Title = $"GRN Detail - GRN No: {grnNo}";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle($"GRN Detail - GRN No: {grnNo}", "");
            AddGRNCreditDetailTable(grnDetailsTable);
            AddFooter();

            return document;
        }

        public Document CreateSalesReturnReportDocument(System.Data.DataTable salesReturnTable, string filterDescription)
        {
            document = new Document();
            document.Info.Title = "Sales Return Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.Orientation = Orientation.Landscape;
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(1.5);
            section.PageSetup.RightMargin = Unit.FromCentimeter(1.5);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5); // Changed from 1.5 to 2.5
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);
            section.PageSetup.FooterDistance = Unit.FromCentimeter(1); // Added to ensure 1 cm gap

            AddHeaderLandscape();
            AddReportTitle("Sales Return Report", filterDescription);
            AddSalesReturnSummaryTable(salesReturnTable);
            AddSpacer();
            AddSalesReturnTableLandscape(salesReturnTable);
            AddFooterLandscape();

            return document;
        }

        public Document CreatePurchaseReturnReportDocument(System.Data.DataTable purchaseReturnTable, string filterDescription)
        {
            document = new Document();
            document.Info.Title = "Purchase Return Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.Orientation = Orientation.Landscape;
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(1.5);
            section.PageSetup.RightMargin = Unit.FromCentimeter(1.5);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5); // Changed from 1.5 to 2.5
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);
            section.PageSetup.FooterDistance = Unit.FromCentimeter(1); // Added to ensure 1 cm gap

            AddHeaderLandscape();
            AddReportTitle("Purchase Return Report", filterDescription);
            AddPurchaseReturnSummaryTable(purchaseReturnTable);
            AddSpacer();
            AddPurchaseReturnTableLandscape(purchaseReturnTable);
            AddFooterLandscape();

            return document;
        }

        public void DefineStyles()
        {
            MigraDoc.DocumentObjectModel.Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 10;

            MigraDoc.DocumentObjectModel.Style headerStyle = document.Styles.AddStyle("Header", "Normal");
            headerStyle.Font.Size = 12;
            headerStyle.Font.Bold = true;

            MigraDoc.DocumentObjectModel.Style tableHeaderStyle = document.Styles.AddStyle("TableHeader", "Normal");
            tableHeaderStyle.Font.Bold = true;
            tableHeaderStyle.Font.Color = Colors.White;
            tableHeaderStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            tableHeaderStyle.ParagraphFormat.SpaceAfter = 5;

            MigraDoc.DocumentObjectModel.Style tableCellStyle = document.Styles.AddStyle("TableCell", "Normal");
            tableCellStyle.ParagraphFormat.SpaceAfter = 2;
            tableCellStyle.ParagraphFormat.SpaceBefore = 2;
            tableCellStyle.ParagraphFormat.LeftIndent = Unit.FromMillimeter(2);
            tableCellStyle.ParagraphFormat.RightIndent = Unit.FromMillimeter(2);
            tableCellStyle.ParagraphFormat.Alignment = ParagraphAlignment.Left;

            MigraDoc.DocumentObjectModel.Style summaryTableStyle = document.Styles.AddStyle("SummaryTable", "Normal");
            summaryTableStyle.Font.Size = 10;
            summaryTableStyle.ParagraphFormat.Alignment = ParagraphAlignment.Left;
            summaryTableStyle.Font.Bold = true;

            MigraDoc.DocumentObjectModel.Style totalRowStyle = document.Styles.AddStyle("TotalRow", "Normal");
            totalRowStyle.Font.Bold = true;
            totalRowStyle.Font.Color = Colors.Black;
            totalRowStyle.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            totalRowStyle.ParagraphFormat.SpaceAfter = 5;
        }

        private void AddWatermark()
        {
            // Watermark functionality removed as per request
        }

        public void AddHeader()
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

        private void AddHeaderLandscape()
        {
            CompanyDetails details = GetCompanyDetails();
            Table headerTable = section.Headers.Primary.AddTable();
            headerTable.AddColumn(Unit.FromCentimeter(5));
            headerTable.AddColumn(Unit.FromCentimeter(20));

            Row row = headerTable.AddRow();
            row.Format.Alignment = ParagraphAlignment.Left;

            if (details.Logo != null && details.Logo.Length > 0)
            {
                try
                {
                    string tempPath = Path.Combine(Path.GetTempPath(), "company_logo.png");
                    File.WriteAllBytes(tempPath, details.Logo);
                    Image image = row.Cells[0].AddImage(tempPath);
                    image.Width = Unit.FromCentimeter(5);
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
            namePara.Format.Font.Size = 16;
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

        private void AddReportTitle(string reportType, string dateFilter)
        {
            Paragraph title = section.AddParagraph($"{reportType} - {dateFilter} - {DateTime.Now:yyyy-MM-dd HH:mm}");
            title.Format.Font.Size = 14;
            title.Format.Font.Bold = true;
            title.Format.Font.Color = Color.FromRgb(0, 51, 102);
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.SpaceBefore = 20;
            title.Format.SpaceAfter = 10;
        }

        private void AddSummaryTable(System.Data.DataTable salesTable)
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
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Total Transactions");
            headerRow.Cells[1].AddParagraph("Total Sales Amount (LKR)");
            headerRow.Cells[2].AddParagraph("Average Sale Price (LKR)");

            Row dataRow = summaryTable.AddRow();
            dataRow.Style = "SummaryTable";
            dataRow.Cells[0].AddParagraph(totalTransactions.ToString());
            dataRow.Cells[1].AddParagraph(totalSalesAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            dataRow.Cells[2].AddParagraph(averageSalePrice.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;

            summaryTable.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddExpensesSummaryTable(System.Data.DataTable expensesTable)
        {
            decimal totalExpenses = expensesTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["amount"]));

            Table summaryTable = section.AddTable();
            summaryTable.Borders.Width = 0.5;
            summaryTable.AddColumn(Unit.FromCentimeter(5));
            summaryTable.AddColumn(Unit.FromCentimeter(5));

            Row headerRow = summaryTable.AddRow();
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Total Expenses (LKR)");
            headerRow.Cells[1].AddParagraph(totalExpenses.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;

            summaryTable.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddSalesReturnSummaryTable(System.Data.DataTable salesReturnTable)
        {
            int totalReturns = salesReturnTable.Rows.Count;
            decimal totalReturnAmount = salesReturnTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["total_price"]));

            Table summaryTable = section.AddTable();
            summaryTable.Borders.Width = 0.5;
            summaryTable.AddColumn(Unit.FromCentimeter(5));
            summaryTable.AddColumn(Unit.FromCentimeter(5));

            Row headerRow = summaryTable.AddRow();
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Total Returns");
            headerRow.Cells[1].AddParagraph("Total Return Amount (LKR)");

            Row dataRow = summaryTable.AddRow();
            dataRow.Style = "SummaryTable";
            dataRow.Cells[0].AddParagraph(totalReturns.ToString());
            dataRow.Cells[1].AddParagraph(totalReturnAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;

            summaryTable.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddPurchaseReturnSummaryTable(System.Data.DataTable purchaseReturnTable)
        {
            int totalReturnedItems = purchaseReturnTable.Rows.Count;
            decimal totalReturnAmount = purchaseReturnTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["net_price"]));

            Table summaryTable = section.AddTable();
            summaryTable.Borders.Width = 0.5;
            summaryTable.AddColumn(Unit.FromCentimeter(5));
            summaryTable.AddColumn(Unit.FromCentimeter(5));

            Row headerRow = summaryTable.AddRow();
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Total Returned Items");
            headerRow.Cells[1].AddParagraph("Total Return Amount (LKR)");

            Row dataRow = summaryTable.AddRow();
            dataRow.Style = "SummaryTable";
            dataRow.Cells[0].AddParagraph(totalReturnedItems.ToString());
            dataRow.Cells[1].AddParagraph(totalReturnAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;

            summaryTable.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddSpacer()
        {
            Paragraph spacer = section.AddParagraph();
            spacer.Format.SpaceBefore = Unit.FromCentimeter(0.5);
            spacer.Format.Borders.Bottom.Width = 0.5;
            spacer.Format.Borders.Bottom.Color = Colors.Gray;
        }

        private void AddSalesTable(System.Data.DataTable salesTable)
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
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Bill Number");
            headerRow.Cells[1].AddParagraph("Customer Name");
            headerRow.Cells[2].AddParagraph("Username");
            headerRow.Cells[3].AddParagraph("Quantity");
            headerRow.Cells[4].AddParagraph("Payment");
            headerRow.Cells[5].AddParagraph("Total (LKR)");
            headerRow.Cells[6].AddParagraph("Date");

            int rowIndex = 0;
            foreach (DataRow row in salesTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                string billNo = row["bill_no"].ToString().Replace("BILL_", "");
                dataRow.Cells[0].AddParagraph(billNo);
                dataRow.Cells[1].AddParagraph(row["customer"].ToString());
                dataRow.Cells[2].AddParagraph(row["user_name"].ToString());
                dataRow.Cells[3].AddParagraph(row["quantity_of_items"].ToString());
                dataRow.Cells[4].AddParagraph(row["payment_method"].ToString());
                dataRow.Cells[5].AddParagraph(Convert.ToDecimal(row["total_price"]).ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[6].AddParagraph(Convert.ToDateTime(row["sale_date"]).ToString("yyyy-MM-dd HH:mm"));
                rowIndex++;
            }

            decimal totalAmount = salesTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["total_price"]));
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 4;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[5].AddParagraph(totalAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            totalRow.Cells[6].AddParagraph("");
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddExpensesTable(System.Data.DataTable expensesTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(1.5));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(6.5));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("ID");
            headerRow.Cells[1].AddParagraph("Date");
            headerRow.Cells[2].AddParagraph("Title");
            headerRow.Cells[3].AddParagraph("Warehouse Name");
            headerRow.Cells[4].AddParagraph("Category Name");
            headerRow.Cells[5].AddParagraph("Amount (LKR)");
            headerRow.Cells[6].AddParagraph("Details");

            int rowIndex = 0;
            foreach (DataRow row in expensesTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                string expenseId = row["id"] is int id ? $"EXP{id:D3}" : "N/A";
                dataRow.Cells[0].AddParagraph(expenseId);
                dataRow.Cells[1].AddParagraph(row["expense_date"] is DateTime date && date != DateTime.MinValue
                    ? date.ToString("yyyy-MM-dd HH:mm")
                    : "N/A");
                dataRow.Cells[2].AddParagraph(row["title"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["warehouse_name"]?.ToString() ?? "N/A");
                dataRow.Cells[4].AddParagraph(row["category_name"]?.ToString() ?? "N/A");
                dataRow.Cells[5].AddParagraph(row["amount"] is decimal amount ? amount.ToString("N2") : "N/A").Format.Alignment = ParagraphAlignment.Right;

                Paragraph detailsPara = dataRow.Cells[6].AddParagraph(row["details"]?.ToString() ?? "N/A");
                detailsPara.Format.Alignment = ParagraphAlignment.Left;
                dataRow.Cells[6].Format.Alignment = ParagraphAlignment.Left;
                dataRow.Cells[6].Format.LeftIndent = 0;
                dataRow.Cells[6].Format.RightIndent = 0;
                rowIndex++;
            }

            decimal totalAmount = expensesTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["amount"]));
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 4;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[5].AddParagraph(totalAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            totalRow.Cells[6].AddParagraph("");
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddStockTable(System.Data.DataTable stockTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(2));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Product Name");
            headerRow.Cells[1].AddParagraph("Category");
            headerRow.Cells[2].AddParagraph("Brand Name");
            headerRow.Cells[3].AddParagraph("Variation Type");
            headerRow.Cells[4].AddParagraph("Unit Name");
            headerRow.Cells[5].AddParagraph("Stock");

            int rowIndex = 0;
            foreach (DataRow row in stockTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(row["product_name"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["category_name"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["brand_name"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["variation_type"]?.ToString() ?? "N/A");
                dataRow.Cells[4].AddParagraph(row["unit_name"]?.ToString() ?? "N/A");
                decimal stockValue = Convert.ToDecimal(row["stock"]);
                string unitName = row["unit_name"]?.ToString()?.ToLower() ?? "";
                dataRow.Cells[5].AddParagraph(unitName == "pieces" ? ((int)stockValue).ToString() : stockValue.ToString("F2"));
                if (stockValue < 5)
                {
                    dataRow.Cells[5].Shading.Color = Colors.Red;
                    dataRow.Cells[5].Format.Font.Color = Colors.White;
                }
                rowIndex++;
            }
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddCustomersTable(System.Data.DataTable customersTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(3.5));
            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(3));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Customer Name");
            headerRow.Cells[1].AddParagraph("Phone Number");
            headerRow.Cells[2].AddParagraph("Total Sales");
            headerRow.Cells[3].AddParagraph("Amount (LKR)");
            headerRow.Cells[4].AddParagraph("Paid (LKR)");

            int rowIndex = 0;
            foreach (DataRow row in customersTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(row["customer_name"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["phone_number"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["total_sales"]?.ToString() ?? "0");
                decimal amount = row["amount"] != DBNull.Value ? Convert.ToDecimal(row["amount"]) : 0;
                dataRow.Cells[3].AddParagraph(amount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                decimal paid = row["paid"] != DBNull.Value ? Convert.ToDecimal(row["paid"]) : 0;
                dataRow.Cells[4].AddParagraph(paid.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                rowIndex++;
            }

            decimal totalAmount = customersTable.AsEnumerable().Sum(row => row["amount"] != DBNull.Value ? Convert.ToDecimal(row["amount"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 2;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[3].AddParagraph(totalAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            totalRow.Cells[4].AddParagraph("");
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddSuppliersTable(System.Data.DataTable suppliersTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(4.5));
            table.AddColumn(Unit.FromCentimeter(4.5));
            table.AddColumn(Unit.FromCentimeter(4.5));
            table.AddColumn(Unit.FromCentimeter(4));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Supplier Name");
            headerRow.Cells[1].AddParagraph("Phone Number");
            headerRow.Cells[2].AddParagraph("Purchases");
            headerRow.Cells[3].AddParagraph("Total Amount (LKR)");

            int rowIndex = 0;
            foreach (DataRow row in suppliersTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(row["supplier_name"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["phone_number"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["purchases"]?.ToString() ?? "0");
                decimal totalAmount = row["total_amount"] != DBNull.Value ? Convert.ToDecimal(row["total_amount"]) : 0;
                dataRow.Cells[3].AddParagraph(totalAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                rowIndex++;
            }

            decimal totalAmountSum = suppliersTable.AsEnumerable().Sum(row => row["total_amount"] != DBNull.Value ? Convert.ToDecimal(row["total_amount"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 2;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[3].AddParagraph(totalAmountSum.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddPurchasesTable(System.Data.DataTable purchasesTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(4.5));
            table.AddColumn(Unit.FromCentimeter(4.5));
            table.AddColumn(Unit.FromCentimeter(4.5));
            table.AddColumn(Unit.FromCentimeter(4));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("GRN Number");
            headerRow.Cells[1].AddParagraph("Payment Method");
            headerRow.Cells[2].AddParagraph("Total Amount (LKR)");
            headerRow.Cells[3].AddParagraph("Date");

            int rowIndex = 0;
            foreach (DataRow row in purchasesTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(row["grn_no"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["payment_method"]?.ToString() ?? "N/A");
                decimal totalAmount = row["total_amount"] != DBNull.Value ? Convert.ToDecimal(row["total_amount"]) : 0;
                dataRow.Cells[2].AddParagraph(totalAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[3].AddParagraph(row["date"] != DBNull.Value ? Convert.ToDateTime(row["date"]).ToString("yyyy-MM-dd HH:mm") : "N/A");
                rowIndex++;
            }

            decimal totalAmountSum = purchasesTable.AsEnumerable()
                .Sum(row => row["total_amount"] != DBNull.Value ? Convert.ToDecimal(row["total_amount"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 2;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[3].AddParagraph(totalAmountSum.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddSuppliersCreditTable(System.Data.DataTable grnCreditTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(4.5));
            table.AddColumn(Unit.FromCentimeter(4.5));
            table.AddColumn(Unit.FromCentimeter(4.5));
            table.AddColumn(Unit.FromCentimeter(4));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("GRN Number");
            headerRow.Cells[1].AddParagraph("Supplier Name");
            headerRow.Cells[2].AddParagraph("Credit Amount (LKR)");
            headerRow.Cells[3].AddParagraph("Date");

            int rowIndex = 0;
            foreach (DataRow row in grnCreditTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(row["grn_no"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["supplier_name"]?.ToString() ?? "N/A");
                decimal creditAmount = row["credit_amount"] != DBNull.Value ? Convert.ToDecimal(row["credit_amount"]) : 0;
                dataRow.Cells[2].AddParagraph(creditAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[3].AddParagraph(row["date"] != DBNull.Value ? Convert.ToDateTime(row["date"]).ToString("yyyy-MM-dd HH:mm") : "N/A").Format.Alignment = ParagraphAlignment.Right;
                rowIndex++;
            }

            decimal totalAmountSum = grnCreditTable.AsEnumerable()
                .Sum(row => row["credit_amount"] != DBNull.Value ? Convert.ToDecimal(row["credit_amount"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 2;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[3].AddParagraph(totalAmountSum.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddGRNCreditDetailTable(System.Data.DataTable grnDetailsTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(3));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Product Name");
            headerRow.Cells[1].AddParagraph("Variation Type");
            headerRow.Cells[2].AddParagraph("Unit");
            headerRow.Cells[3].AddParagraph("Quantity");
            headerRow.Cells[4].AddParagraph("Cost Price (LKR)");
            headerRow.Cells[5].AddParagraph("Total Price (LKR)");

            int rowIndex = 0;
            foreach (DataRow row in grnDetailsTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(row["product_name"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["variation_type"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["unit"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["quantity"]?.ToString() ?? "0");
                decimal costPrice = row["cost_price"] != DBNull.Value ? Convert.ToDecimal(row["cost_price"]) : 0;
                dataRow.Cells[4].AddParagraph(costPrice.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                decimal totalPrice = row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0;
                dataRow.Cells[5].AddParagraph(totalPrice.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                rowIndex++;
            }

            decimal totalAmountSum = grnDetailsTable.AsEnumerable().Sum(row => row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 3;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[4].AddParagraph("");
            totalRow.Cells[5].AddParagraph(totalAmountSum.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddSalesReturnTable(System.Data.DataTable salesReturnTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(3.0));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(2.0));
            table.AddColumn(Unit.FromCentimeter(2.0));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(3.0));
            table.AddColumn(Unit.FromCentimeter(2.5));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Bill No");
            headerRow.Cells[1].AddParagraph("Product Name");
            headerRow.Cells[2].AddParagraph("Variation Type");
            headerRow.Cells[3].AddParagraph("Unit");
            headerRow.Cells[4].AddParagraph("Quantity");
            headerRow.Cells[5].AddParagraph("Total Price (LKR)");
            headerRow.Cells[6].AddParagraph("Reason");
            headerRow.Cells[7].AddParagraph("Date");

            int rowIndex = 0;
            foreach (DataRow row in salesReturnTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(row["bill_no"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["product_name"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["variation_type"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["unit"]?.ToString() ?? "N/A");
                decimal quantity = row["quantity"] != DBNull.Value ? Convert.ToDecimal(row["quantity"]) : 0;
                dataRow.Cells[4].AddParagraph(quantity.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                decimal totalPrice = row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0;
                dataRow.Cells[5].AddParagraph(totalPrice.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[6].AddParagraph(row["reason"]?.ToString() ?? "N/A");
                dataRow.Cells[7].AddParagraph(row["refund_date"] != DBNull.Value ? Convert.ToDateTime(row["refund_date"]).ToString("yyyy-MM-dd HH:mm") : "N/A").Format.Alignment = ParagraphAlignment.Right;
                rowIndex++;
            }

            decimal totalAmount = salesReturnTable.AsEnumerable().Sum(row => row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 4;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[5].AddParagraph(totalAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            totalRow.Cells[6].AddParagraph("");
            totalRow.Cells[7].AddParagraph("");
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddSalesReturnTableLandscape(System.Data.DataTable salesReturnTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(5));
            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(1.5));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(4));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Bill No");
            headerRow.Cells[1].AddParagraph("Product Name");
            headerRow.Cells[2].AddParagraph("Variation Type");
            headerRow.Cells[3].AddParagraph("Unit");
            headerRow.Cells[4].AddParagraph("Quantity");
            headerRow.Cells[5].AddParagraph("Total Price (LKR)");
            headerRow.Cells[6].AddParagraph("Reason");
            headerRow.Cells[7].AddParagraph("Date");

            int rowIndex = 0;
            foreach (DataRow row in salesReturnTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(row["bill_no"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["product_name"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["variation_type"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["unit"]?.ToString() ?? "N/A");
                decimal quantity = row["quantity"] != DBNull.Value ? Convert.ToDecimal(row["quantity"]) : 0;
                dataRow.Cells[4].AddParagraph(quantity.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                decimal totalPrice = row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0;
                dataRow.Cells[5].AddParagraph(totalPrice.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[6].AddParagraph(row["reason"]?.ToString() ?? "N/A");
                dataRow.Cells[7].AddParagraph(row["refund_date"] != DBNull.Value ? Convert.ToDateTime(row["refund_date"]).ToString("yyyy-MM-dd HH:mm") : "N/A").Format.Alignment = ParagraphAlignment.Right;
                rowIndex++;
            }

            decimal totalAmount = salesReturnTable.AsEnumerable().Sum(row => row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 4;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[5].AddParagraph(totalAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            totalRow.Cells[6].AddParagraph("");
            totalRow.Cells[7].AddParagraph("");
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        private void AddPurchaseReturnTableLandscape(System.Data.DataTable purchaseReturnTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(5));
            table.AddColumn(Unit.FromCentimeter(2));
            table.AddColumn(Unit.FromCentimeter(2.5));
            table.AddColumn(Unit.FromCentimeter(3));
            table.AddColumn(Unit.FromCentimeter(4));
            table.AddColumn(Unit.FromCentimeter(3));

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
            headerRow.Cells[0].AddParagraph("Return No");
            headerRow.Cells[1].AddParagraph("GRN No");
            headerRow.Cells[2].AddParagraph("Product Name");
            headerRow.Cells[3].AddParagraph("Variation Type");
            headerRow.Cells[4].AddParagraph("Quantity");
            headerRow.Cells[5].AddParagraph("Net Price (LKR)");
            headerRow.Cells[6].AddParagraph("Reason");
            headerRow.Cells[7].AddParagraph("Date");

            int rowIndex = 0;
            foreach (DataRow row in purchaseReturnTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                if (rowIndex % 2 == 0)
                {
                    dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                }
                dataRow.Cells[0].AddParagraph(row["return_no"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["grn_no"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["product_name"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["variation_type"]?.ToString() ?? "N/A");
                decimal quantity = row["quantity"] != DBNull.Value ? Convert.ToDecimal(row["quantity"]) : 0;
                dataRow.Cells[4].AddParagraph(quantity.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                decimal netPrice = row["net_price"] != DBNull.Value ? Convert.ToDecimal(row["net_price"]) : 0;
                dataRow.Cells[5].AddParagraph(netPrice.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                dataRow.Cells[6].AddParagraph(row["reason"]?.ToString() ?? "N/A");
                dataRow.Cells[7].AddParagraph(row["created_at"] != DBNull.Value ? Convert.ToDateTime(row["created_at"]).ToString("yyyy-MM-dd HH:mm") : "N/A").Format.Alignment = ParagraphAlignment.Right;
                rowIndex++;
            }

            decimal totalAmount = purchaseReturnTable.AsEnumerable().Sum(row => row["net_price"] != DBNull.Value ? Convert.ToDecimal(row["net_price"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TotalRow";
            totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
            totalRow.Cells[0].MergeRight = 4;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[5].AddParagraph(totalAmount.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
            totalRow.Cells[6].AddParagraph("");
            totalRow.Cells[7].AddParagraph("");
            table.Format.SpaceAfter = Unit.FromCentimeter(1);
        }

        public void AddCustomerHistoryTable(System.Data.DataTable customerSales, System.Data.DataTable customerDetails)
        {
            if (customerSales == null || customerDetails == null)
            {
                throw new ArgumentNullException("customerSales or customerDetails cannot be null");
            }

            string[] requiredSalesColumns = { "bill_no", "user_name", "quantity_of_items", "payment_method", "total_price", "sale_date" };
            foreach (var column in requiredSalesColumns)
            {
                if (!customerSales.Columns.Contains(column))
                {
                    throw new ArgumentException($"Missing required column '{column}' in customerSales DataTable");
                }
            }

            string[] requiredDetailsColumns = { "bill_no", "product_name", "variation_type", "unit", "quantity", "price", "total_price" };
            foreach (var column in requiredDetailsColumns)
            {
                if (!customerDetails.Columns.Contains(column))
                {
                    throw new ArgumentException($"Missing required column '{column}' in customerDetails DataTable");
                }
            }

            var billGroups = customerSales.AsEnumerable()
                .GroupBy(row => row["bill_no"]?.ToString())
                .Where(g => g.Key != null);

            foreach (var billGroup in billGroups)
            {
                string billNo = billGroup.Key ?? "N/A";
                var sale = billGroup.First();

                string saleDateStr = "N/A";
                try
                {
                    if (sale["sale_date"] != DBNull.Value)
                    {
                        saleDateStr = Convert.ToDateTime(sale["sale_date"]).ToString("yyyy-MM-dd HH:mm");
                    }
                }
                catch
                {
                    saleDateStr = "Invalid Date";
                }

                Table table = section.AddTable();
                table.Borders.Width = 0.5;
                table.Rows.Height = 10;
                table.KeepTogether = false;

                table.AddColumn(Unit.FromCentimeter(3));
                table.AddColumn(Unit.FromCentimeter(3));
                table.AddColumn(Unit.FromCentimeter(3));
                table.AddColumn(Unit.FromCentimeter(2));
                table.AddColumn(Unit.FromCentimeter(2.5));
                table.AddColumn(Unit.FromCentimeter(2));

                Row idRow = table.AddRow();
                idRow.HeadingFormat = true;
                idRow.Height = Unit.FromCentimeter(0.8);
                idRow.Style = "TableHeader";
                idRow.Shading.Color = Color.FromRgb(0, 51, 102);
                idRow.Cells[0].MergeRight = 5;
                idRow.Cells[0].AddParagraph($"Bill Number: {billNo} (Date: {saleDateStr})");

                DataRow[] detailsRows = customerDetails.Select($"bill_no = '{billNo}'");
                StringBuilder productsSummary = new StringBuilder("Products: ");
                foreach (DataRow detail in detailsRows)
                {
                    string productName = detail["product_name"]?.ToString() ?? "N/A";
                    string variation = detail["variation_type"]?.ToString() ?? "N/A";
                    productsSummary.Append($"{productName} ({variation}), ");
                }
                if (productsSummary.Length > 2)
                {
                    productsSummary.Length -= 2;
                }

                decimal totalPrice = detailsRows.Sum(row => row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0);

                Row summaryRow = table.AddRow();
                summaryRow.Style = "TableCell";
                summaryRow.Cells[0].MergeRight = 5;
                summaryRow.Cells[0].AddParagraph(productsSummary.ToString());

                Row netPriceRow = table.AddRow();
                netPriceRow.Style = "TableCell";
                netPriceRow.Cells[0].MergeRight = 5;
                netPriceRow.Cells[0].AddParagraph($"Total Net Price: {totalPrice.ToString("N2")} LKR, " +
                    $"Username: {(sale["user_name"]?.ToString() ?? "N/A")}, " +
                    $"Payment Method: {(sale["payment_method"]?.ToString() ?? "N/A")}");

                Row headerRow = table.AddRow();
                headerRow.HeadingFormat = true;
                headerRow.Height = Unit.FromCentimeter(0.8);
                headerRow.Style = "TableHeader";
                headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
                headerRow.Cells[0].AddParagraph("Product Name");
                headerRow.Cells[1].AddParagraph("Variation Type");
                headerRow.Cells[2].AddParagraph("Unit");
                headerRow.Cells[3].AddParagraph("Quantity");
                headerRow.Cells[4].AddParagraph("Price (LKR)");
                headerRow.Cells[5].AddParagraph("Total Price (LKR)");

                int rowIndex = 0;
                foreach (DataRow detail in detailsRows)
                {
                    Row dataRow = table.AddRow();
                    dataRow.Style = "TableCell";
                    if (rowIndex % 2 == 0)
                    {
                        dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                    }
                    dataRow.Cells[0].AddParagraph(detail["product_name"]?.ToString() ?? "N/A");
                    dataRow.Cells[1].AddParagraph(detail["variation_type"]?.ToString() ?? "N/A");
                    dataRow.Cells[2].AddParagraph(detail["unit"]?.ToString() ?? "N/A");
                    dataRow.Cells[3].AddParagraph(detail["quantity"]?.ToString() ?? "0");
                    decimal price = detail["price"] != DBNull.Value ? Convert.ToDecimal(detail["price"]) : 0;
                    dataRow.Cells[4].AddParagraph(price.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                    decimal totalPriceRow = detail["total_price"] != DBNull.Value ? Convert.ToDecimal(detail["total_price"]) : 0;
                    dataRow.Cells[5].AddParagraph(totalPriceRow.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                    rowIndex++;
                }

                decimal billTotal = detailsRows.Sum(row => row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0);
                Row totalRow = table.AddRow();
                totalRow.Height = Unit.FromCentimeter(0.8);
                totalRow.Style = "TotalRow";
                totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
                totalRow.Cells[0].MergeRight = 3;
                totalRow.Cells[0].AddParagraph("Total");
                totalRow.Cells[4].AddParagraph("");
                totalRow.Cells[5].AddParagraph(billTotal.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                table.Format.SpaceAfter = Unit.FromCentimeter(0.5);
            }
        }

        public void AddSupplierHistoryTable(System.Data.DataTable supplierPurchases, System.Data.DataTable purchaseDetails)
        {
            if (supplierPurchases == null || purchaseDetails == null)
            {
                throw new ArgumentNullException("supplierPurchases or purchaseDetails cannot be null");
            }

            string[] requiredPurchasesColumns = { "grn_id", "product_name", "quantity", "cost_price", "net_price" };
            foreach (var column in requiredPurchasesColumns)
            {
                if (!supplierPurchases.Columns.Contains(column))
                {
                    throw new ArgumentException($"Missing required column '{column}' in supplierPurchases DataTable");
                }
            }

            string[] requiredDetailsColumns = { "grn_id", "product_name", "variation_type", "unit", "quantity", "cost_price", "net_price", "expiry_date", "warranty" };
            foreach (var column in requiredDetailsColumns)
            {
                if (!purchaseDetails.Columns.Contains(column))
                {
                    throw new ArgumentException($"Missing required column '{column}' in purchaseDetails DataTable");
                }
            }

            var grnGroups = supplierPurchases.AsEnumerable()
                .GroupBy(row => row["grn_id"]?.ToString())
                .Where(g => g.Key != null);

            foreach (var grnGroup in grnGroups)
            {
                string grnId = grnGroup.Key ?? "N/A";

                Table table = section.AddTable();
                table.Borders.Width = 0.5;
                table.Rows.Height = 10;
                table.KeepTogether = false;

                table.AddColumn(Unit.FromCentimeter(3));
                table.AddColumn(Unit.FromCentimeter(2.5));
                table.AddColumn(Unit.FromCentimeter(2));
                table.AddColumn(Unit.FromCentimeter(2));
                table.AddColumn(Unit.FromCentimeter(2.5));
                table.AddColumn(Unit.FromCentimeter(2.5));
                table.AddColumn(Unit.FromCentimeter(1.5));
                table.AddColumn(Unit.FromCentimeter(1.5));

                Row idRow = table.AddRow();
                idRow.HeadingFormat = true;
                idRow.Height = Unit.FromCentimeter(0.8);
                idRow.Style = "TableHeader";
                idRow.Shading.Color = Color.FromRgb(255, 255, 255);
                idRow.Cells[0].Format.Font.Color = Color.FromRgb(0, 0, 0);

                idRow.Cells[0].MergeRight = 7;
                idRow.Cells[0].AddParagraph($"GRN ID: {grnId}");

                DataRow[] detailsRows = purchaseDetails.Select($"grn_id = '{grnId}'");
                StringBuilder productsSummary = new StringBuilder("Products: ");
                foreach (DataRow detail in detailsRows)
                {
                    string productName = detail["product_name"]?.ToString() ?? "N/A";
                    string variation = detail["variation_type"]?.ToString() ?? "N/A";
                    productsSummary.Append($"{productName} ({variation}), ");
                }
                if (productsSummary.Length > 2)
                {
                    productsSummary.Length -= 2;
                }

                decimal totalNetPrice = detailsRows.Sum(row => row["net_price"] != DBNull.Value ? Convert.ToDecimal(row["net_price"]) : 0);

                Row summaryRow = table.AddRow();
                summaryRow.Style = "TableCell";
                summaryRow.Cells[0].MergeRight = 7;
                summaryRow.Cells[0].AddParagraph(productsSummary.ToString());

                Row netPriceRow = table.AddRow();
                netPriceRow.Style = "TableCell";
                netPriceRow.Cells[0].MergeRight = 7;
                netPriceRow.Cells[0].AddParagraph($"Total Net Price: {totalNetPrice.ToString("N2")} LKR");

                Row headerRow = table.AddRow();
                headerRow.HeadingFormat = true;
                headerRow.Height = Unit.FromCentimeter(0.8);
                headerRow.Style = "TableHeader";
                headerRow.Shading.Color = Color.FromRgb(0, 51, 102);
                headerRow.Cells[0].AddParagraph("Product Name");
                headerRow.Cells[1].AddParagraph("Variation Type");
                headerRow.Cells[2].AddParagraph("Unit");
                headerRow.Cells[3].AddParagraph("Quantity");
                headerRow.Cells[4].AddParagraph("Cost Price (LKR)");
                headerRow.Cells[5].AddParagraph("Net Price (LKR)");
                headerRow.Cells[6].AddParagraph("Expiry Date");
                headerRow.Cells[7].AddParagraph("Warranty");

                int rowIndex = 0;
                foreach (DataRow detail in detailsRows)
                {
                    Row dataRow = table.AddRow();
                    dataRow.Style = "TableCell";
                    if (rowIndex % 2 == 0)
                    {
                        dataRow.Shading.Color = Color.FromRgb(240, 240, 240);
                    }
                    dataRow.Cells[0].AddParagraph(detail["product_name"]?.ToString() ?? "N/A");
                    dataRow.Cells[1].AddParagraph(detail["variation_type"]?.ToString() ?? "N/A");
                    dataRow.Cells[2].AddParagraph(detail["unit"]?.ToString() ?? "N/A");
                    dataRow.Cells[3].AddParagraph(detail["quantity"]?.ToString() ?? "0");
                    decimal costPrice = detail["cost_price"] != DBNull.Value ? Convert.ToDecimal(detail["cost_price"]) : 0;
                    dataRow.Cells[4].AddParagraph(costPrice.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                    decimal netPrice = detail["net_price"] != DBNull.Value ? Convert.ToDecimal(detail["net_price"]) : 0;
                    dataRow.Cells[5].AddParagraph(netPrice.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                    string expiryDate = detail["expiry_date"] != DBNull.Value ? Convert.ToDateTime(detail["expiry_date"]).ToString("yyyy-MM-dd HH:mm") : "N/A";
                    dataRow.Cells[6].AddParagraph(expiryDate);
                    string warranty = detail["warranty"]?.ToString() ?? "No";
                    dataRow.Cells[7].AddParagraph(warranty == "No Warranty" ? "No" : warranty);
                    rowIndex++;
                }

                decimal grnTotalNetPrice = detailsRows.Sum(row => row["net_price"] != DBNull.Value ? Convert.ToDecimal(row["net_price"]) : 0);
                Row totalRow = table.AddRow();
                totalRow.Height = Unit.FromCentimeter(0.8);
                totalRow.Style = "TotalRow";
                totalRow.Shading.Color = Color.FromRgb(173, 216, 230);
                totalRow.Cells[0].MergeRight = 4;
                totalRow.Cells[0].AddParagraph("Total");
                totalRow.Cells[5].AddParagraph(grnTotalNetPrice.ToString("N2")).Format.Alignment = ParagraphAlignment.Right;
                totalRow.Cells[6].AddParagraph("");
                totalRow.Cells[7].AddParagraph("");
                table.Format.SpaceAfter = Unit.FromCentimeter(0.5);
            }
        }

        public void AddFooter()
        {
            Paragraph footer = section.Footers.Primary.AddParagraph();
            footer.Format.Font.Name = "Times New Roman";
            footer.Format.Font.Size = 8;
            footer.Format.Alignment = ParagraphAlignment.Center;
            footer.AddText($"Generated on {DateTime.Now:yyyy-MM-dd HH:mm} - Flow POS by E Scope International (Pvt) Ltd. " +
                $"© 2020 All rights reserved. | Contact Us: 075 - 7119340");
            footer.Format.SpaceBefore = 0.5;
            footer.Format.Borders.Top.Width = 0.5;
            footer.Format.Borders.Top.Color = Color.FromRgb(0, 51, 102);

            Paragraph pageNumber = section.Footers.Primary.AddParagraph();
            pageNumber.Format.Font.Name = "Times New Roman";
            pageNumber.Format.Font.Size = 9;
            pageNumber.Format.Alignment = ParagraphAlignment.Center;
            pageNumber.AddText("Page No: ");
            pageNumber.AddPageField();
            pageNumber.AddText(" / ");
            pageNumber.AddNumPagesField();
            pageNumber.Format.SpaceBefore = 5;
        }

        private void AddFooterLandscape()
        {
            Paragraph footer = section.Footers.Primary.AddParagraph();
            footer.Format.Font.Name = "Times New Roman";
            footer.Format.Font.Size = 9;
            footer.Format.Alignment = ParagraphAlignment.Center;
            footer.AddText($"Generated on {DateTime.Now:yyyy-MM-dd HH:mm} - Flow POS by E Scope International (Pvt) Ltd. " +
                $"© 2020 All rights reserved. | Contact Us: 075 - 7119340");
            footer.Format.SpaceBefore = 0.5;
            footer.Format.Borders.Top.Width = 0.5;
            footer.Format.Borders.Top.Color = Color.FromRgb(0, 51, 102);

            Paragraph pageNumber = section.Footers.Primary.AddParagraph();
            pageNumber.Format.Font.Name = "Times New Roman";
            pageNumber.Format.Font.Size = 10;
            pageNumber.Format.Alignment = ParagraphAlignment.Center;
            pageNumber.AddText("Page No: ");
            pageNumber.AddPageField();
            pageNumber.AddText(" / ");
            pageNumber.AddNumPagesField();
            pageNumber.Format.SpaceBefore = 5;
        }
    }
}