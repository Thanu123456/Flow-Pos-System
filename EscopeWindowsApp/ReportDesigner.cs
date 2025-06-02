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
        public Document document; // Changed to public
        public Section section;  // Changed to public

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
            // Default constructor
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
            AddReportTitle("Sales Report", dateFilter);
            AddSummaryTable(salesTable);
            AddSpacer();
            AddSalesTable(salesTable);
            AddFooter();

            return document;
        }

        public Document CreateExpensesReportDocument(DataTable expensesTable, string dateFilter)
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
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Expenses Report", dateFilter);
            AddExpensesSummaryTable(expensesTable);
            AddSpacer();
            AddExpensesTable(expensesTable);
            AddFooter();

            return document;
        }

        public Document CreateStockReportDocument(DataTable stockTable, string categoryFilter, bool zeroStockFilter)
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
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            string stockFilterText = zeroStockFilter ? "Zero Stock" : "Non-Zero Stock";
            AddReportTitle("Stock Report", $"{categoryFilter} ({stockFilterText})");
            AddStockTable(stockTable);
            AddFooter();

            return document;
        }

        public Document CreateCustomersReportDocument(DataTable customersTable, string dateFilter)
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
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Customers Report", dateFilter);
            AddCustomersTable(customersTable);
            AddFooter();

            return document;
        }

        public Document CreateSuppliersReportDocument(DataTable suppliersTable, string dateFilter)
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
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Suppliers Report", dateFilter);
            AddSuppliersTable(suppliersTable);
            AddFooter();

            return document;
        }

        public Document CreatePurchasesReportDocument(DataTable purchasesTable, string dateFilter)
        {
            document = new Document();
            document.Info.Title = "Purchases Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Purchases Report", dateFilter);
            AddPurchasesTable(purchasesTable);
            AddFooter();

            return document;
        }

        public Document CreateSuppliersCreditReportDocument(DataTable grnCreditTable, string dateFilter)
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
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Suppliers Credit Report", dateFilter);
            AddSuppliersCreditTable(grnCreditTable);
            AddFooter();

            return document;
        }

        public Document CreateGRNCreditDetailReportDocument(DataTable grnDetailsTable, string grnNo)
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
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle($"GRN Detail - GRN No: {grnNo}", "");
            AddGRNCreditDetailTable(grnDetailsTable);
            AddFooter();

            return document;
        }

        // New method for Sales Return Report
        public Document CreateSalesReturnReportDocument(DataTable salesReturnTable, string filterDescription)
        {
            document = new Document();
            document.Info.Title = "Sales Return Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Sales Return Report", filterDescription);
            AddSalesReturnSummaryTable(salesReturnTable);
            AddSpacer();
            AddSalesReturnTable(salesReturnTable);
            AddFooter();

            return document;
        }

        public void DefineStyles()
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

        private void AddReportTitle(string reportType, string dateFilter)
        {
            Paragraph title = section.AddParagraph($"{reportType} - {dateFilter} - {DateTime.Now:yyyy-MM-dd HH:mm}");
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

            summaryTable.Format.SpaceAfter = 0;
        }

        private void AddExpensesSummaryTable(DataTable expensesTable)
        {
            decimal totalExpenses = expensesTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["amount"]));

            Table summaryTable = section.AddTable();
            summaryTable.Borders.Width = 0.5;
            summaryTable.AddColumn(Unit.FromCentimeter(5));
            summaryTable.AddColumn(Unit.FromCentimeter(5));

            Row headerRow = summaryTable.AddRow();
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Total Expenses");
            headerRow.Cells[1].AddParagraph(totalExpenses.ToString("N2"));

            summaryTable.Format.SpaceAfter = 0;
        }

        // New method for Sales Return Summary Table
        private void AddSalesReturnSummaryTable(DataTable salesReturnTable)
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
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Total Returns");
            headerRow.Cells[1].AddParagraph("Total Return Amount");

            Row dataRow = summaryTable.AddRow();
            dataRow.Style = "SummaryTable";
            dataRow.Cells[0].AddParagraph(totalReturns.ToString());
            dataRow.Cells[1].AddParagraph(totalReturnAmount.ToString("N2"));

            summaryTable.Format.SpaceAfter = 0;
        }

        private void AddSpacer()
        {
            Paragraph spacer = section.AddParagraph();
            spacer.Format.SpaceBefore = Unit.FromCentimeter(0.5);
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

        private void AddExpensesTable(DataTable expensesTable)
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
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("ID");
            headerRow.Cells[1].AddParagraph("Date");
            headerRow.Cells[2].AddParagraph("Title");
            headerRow.Cells[3].AddParagraph("Warehouse Name");
            headerRow.Cells[4].AddParagraph("Category Name");
            headerRow.Cells[5].AddParagraph("Amount");
            headerRow.Cells[6].AddParagraph("Details");

            foreach (DataRow row in expensesTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                string expenseId = row["id"] is int id ? $"EXP{id:D3}" : "N/A";
                dataRow.Cells[0].AddParagraph(expenseId);
                dataRow.Cells[1].AddParagraph(row["expense_date"] is DateTime date && date != DateTime.MinValue
                    ? date.ToString("yyyy-MM-dd HH:mm:ss")
                    : "N/A");
                dataRow.Cells[2].AddParagraph(row["title"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["warehouse_name"]?.ToString() ?? "N/A");
                dataRow.Cells[4].AddParagraph(row["category_name"]?.ToString() ?? "N/A");
                dataRow.Cells[5].AddParagraph(row["amount"] is decimal amount ? amount.ToString("N2") : "N/A");

                Paragraph detailsPara = dataRow.Cells[6].AddParagraph(row["details"]?.ToString() ?? "N/A");
                detailsPara.Format.Alignment = ParagraphAlignment.Left;
                dataRow.Cells[6].Format.Alignment = ParagraphAlignment.Left;
                dataRow.Cells[6].Format.LeftIndent = 0;
                dataRow.Cells[6].Format.RightIndent = 0;
            }

            decimal totalAmount = expensesTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["amount"]));
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TableHeader";
            totalRow.Shading.Color = Colors.SkyBlue;
            totalRow.Cells[0].MergeRight = 4;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[5].AddParagraph(totalAmount.ToString("N2"));
            totalRow.Cells[6].AddParagraph("");
        }

        private void AddStockTable(DataTable stockTable)
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
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Product Name");
            headerRow.Cells[1].AddParagraph("Category");
            headerRow.Cells[2].AddParagraph("Brand Name");
            headerRow.Cells[3].AddParagraph("Variation Type");
            headerRow.Cells[4].AddParagraph("Unit Name");
            headerRow.Cells[5].AddParagraph("Stock");

            foreach (DataRow row in stockTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
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
            }
        }

        private void AddCustomersTable(DataTable customersTable)
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
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Customer Name");
            headerRow.Cells[1].AddParagraph("Phone Number");
            headerRow.Cells[2].AddParagraph("Total Sales");
            headerRow.Cells[3].AddParagraph("Amount");
            headerRow.Cells[4].AddParagraph("Paid");

            foreach (DataRow row in customersTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                dataRow.Cells[0].AddParagraph(row["customer_name"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["phone_number"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["total_sales"]?.ToString() ?? "0");
                decimal amount = row["amount"] != DBNull.Value ? Convert.ToDecimal(row["amount"]) : 0;
                dataRow.Cells[3].AddParagraph(amount.ToString("N2"));
                decimal paid = row["paid"] != DBNull.Value ? Convert.ToDecimal(row["paid"]) : 0;
                dataRow.Cells[4].AddParagraph(paid.ToString("N2"));
            }

            decimal totalAmount = customersTable.AsEnumerable().Sum(row => row["amount"] != DBNull.Value ? Convert.ToDecimal(row["amount"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TableHeader";
            totalRow.Shading.Color = Colors.SkyBlue;
            totalRow.Cells[0].MergeRight = 2;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[3].AddParagraph(totalAmount.ToString("N2"));
            totalRow.Cells[4].AddParagraph("");
        }

        private void AddSuppliersTable(DataTable suppliersTable)
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
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Supplier Name");
            headerRow.Cells[1].AddParagraph("Phone Number");
            headerRow.Cells[2].AddParagraph("Purchases");
            headerRow.Cells[3].AddParagraph("Total Amount");

            foreach (DataRow row in suppliersTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                dataRow.Cells[0].AddParagraph(row["supplier_name"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["phone_number"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["purchases"]?.ToString() ?? "0");
                decimal totalAmount = row["total_amount"] != DBNull.Value ? Convert.ToDecimal(row["total_amount"]) : 0;
                dataRow.Cells[3].AddParagraph(totalAmount.ToString("N2"));
            }

            decimal totalAmountSum = suppliersTable.AsEnumerable().Sum(row => row["total_amount"] != DBNull.Value ? Convert.ToDecimal(row["total_amount"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TableHeader";
            totalRow.Shading.Color = Colors.SkyBlue;
            totalRow.Cells[0].MergeRight = 2;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[3].AddParagraph(totalAmountSum.ToString("N2"));
        }

        private void AddPurchasesTable(DataTable purchasesTable)
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
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("GRN Number");
            headerRow.Cells[1].AddParagraph("Payment Method");
            headerRow.Cells[2].AddParagraph("Total Amount");
            headerRow.Cells[3].AddParagraph("Date");

            foreach (DataRow row in purchasesTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                dataRow.Cells[0].AddParagraph(row["grn_no"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["payment_method"]?.ToString() ?? "N/A");
                decimal totalAmount = row["total_amount"] != DBNull.Value ? Convert.ToDecimal(row["total_amount"]) : 0;
                dataRow.Cells[2].AddParagraph(totalAmount.ToString("N2"));
                dataRow.Cells[3].AddParagraph(row["date"] != DBNull.Value ? Convert.ToDateTime(row["date"]).ToString("yyyy-MM-dd") : "N/A");
            }

            decimal totalAmountSum = purchasesTable.AsEnumerable().Sum(row => row["total_amount"] != DBNull.Value ? Convert.ToDecimal(row["total_amount"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TableHeader";
            totalRow.Shading.Color = Colors.SkyBlue;
            totalRow.Cells[0].MergeRight = 2;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[3].AddParagraph(totalAmountSum.ToString("N2"));
        }

        private void AddSuppliersCreditTable(DataTable grnCreditTable)
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
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("GRN Number");
            headerRow.Cells[1].AddParagraph("Supplier Name");
            headerRow.Cells[2].AddParagraph("Credit Amount");
            headerRow.Cells[3].AddParagraph("Date");

            foreach (DataRow row in grnCreditTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                dataRow.Cells[0].AddParagraph(row["grn_no"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["supplier_name"]?.ToString() ?? "N/A");
                decimal creditAmount = row["credit_amount"] != DBNull.Value ? Convert.ToDecimal(row["credit_amount"]) : 0;
                dataRow.Cells[2].AddParagraph(creditAmount.ToString("N2"));
                dataRow.Cells[3].AddParagraph(row["date"] != DBNull.Value ? Convert.ToDateTime(row["date"]).ToString("yyyy-MM-dd HH:mm:ss") : "N/A");
            }

            decimal totalAmountSum = grnCreditTable.AsEnumerable().Sum(row => row["credit_amount"] != DBNull.Value ? Convert.ToDecimal(row["credit_amount"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TableHeader";
            totalRow.Shading.Color = Colors.SkyBlue;
            totalRow.Cells[0].MergeRight = 2;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[3].AddParagraph(totalAmountSum.ToString("N2"));
        }

        private void AddGRNCreditDetailTable(DataTable grnDetailsTable)
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
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Product Name");
            headerRow.Cells[1].AddParagraph("Variation Type");
            headerRow.Cells[2].AddParagraph("Unit");
            headerRow.Cells[3].AddParagraph("Quantity");
            headerRow.Cells[4].AddParagraph("Cost Price");
            headerRow.Cells[5].AddParagraph("Total Price");

            foreach (DataRow row in grnDetailsTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                dataRow.Cells[0].AddParagraph(row["product_name"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["variation_type"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["unit"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["quantity"]?.ToString() ?? "0");
                decimal costPrice = row["cost_price"] != DBNull.Value ? Convert.ToDecimal(row["cost_price"]) : 0;
                dataRow.Cells[4].AddParagraph(costPrice.ToString("N2"));
                decimal totalPrice = row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0;
                dataRow.Cells[5].AddParagraph(totalPrice.ToString("N2"));
            }

            decimal totalAmountSum = grnDetailsTable.AsEnumerable().Sum(row => row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TableHeader";
            totalRow.Shading.Color = Colors.SkyBlue;
            totalRow.Cells[0].MergeRight = 3;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[4].AddParagraph("");
            totalRow.Cells[5].AddParagraph(totalAmountSum.ToString("N2"));
        }

        // New method for Sales Return Table
        private void AddSalesReturnTable(DataTable salesReturnTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(2));   // Bill No
            table.AddColumn(Unit.FromCentimeter(3));   // Product Name
            table.AddColumn(Unit.FromCentimeter(2.5)); // Variation Type
            table.AddColumn(Unit.FromCentimeter(2));   // Unit
            table.AddColumn(Unit.FromCentimeter(2));   // Quantity
            table.AddColumn(Unit.FromCentimeter(2.5)); // Total Price
            table.AddColumn(Unit.FromCentimeter(3));   // Reason
            table.AddColumn(Unit.FromCentimeter(2.5)); // Date

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Bill No");
            headerRow.Cells[1].AddParagraph("Product Name");
            headerRow.Cells[2].AddParagraph("Variation Type");
            headerRow.Cells[3].AddParagraph("Unit");
            headerRow.Cells[4].AddParagraph("Quantity");
            headerRow.Cells[5].AddParagraph("Total Price");
            headerRow.Cells[6].AddParagraph("Reason");
            headerRow.Cells[7].AddParagraph("Date");

            foreach (DataRow row in salesReturnTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                dataRow.Cells[0].AddParagraph(row["bill_no"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["product_name"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["variation_type"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["unit"]?.ToString() ?? "N/A");
                decimal quantity = row["quantity"] != DBNull.Value ? Convert.ToDecimal(row["quantity"]) : 0;
                dataRow.Cells[4].AddParagraph(quantity.ToString("N2"));
                decimal totalPrice = row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0;
                dataRow.Cells[5].AddParagraph(totalPrice.ToString("N2"));
                dataRow.Cells[6].AddParagraph(row["reason"]?.ToString() ?? "N/A");
                dataRow.Cells[7].AddParagraph(row["refund_date"] != DBNull.Value ? Convert.ToDateTime(row["refund_date"]).ToString("yyyy-MM-dd") : "N/A");
            }

            decimal totalAmount = salesReturnTable.AsEnumerable().Sum(row => row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TableHeader";
            totalRow.Shading.Color = Colors.SkyBlue;
            totalRow.Cells[0].MergeRight = 4;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[5].AddParagraph(totalAmount.ToString("N2"));
            totalRow.Cells[6].AddParagraph("");
            totalRow.Cells[7].AddParagraph("");
        }

        public void AddCustomerHistoryTable(DataTable customerSales, DataTable customerDetails)
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

            foreach (DataRow sale in customerSales.Rows)
            {
                string billNo = sale["bill_no"]?.ToString() ?? "N/A";
                string saleDateStr = "N/A";
                try
                {
                    if (sale["sale_date"] != DBNull.Value)
                    {
                        saleDateStr = Convert.ToDateTime(sale["sale_date"]).ToString("yyyy-MM-dd");
                    }
                }
                catch
                {
                    saleDateStr = "Invalid Date";
                }

                Paragraph billTitle = section.AddParagraph($"Bill Number: {billNo} (Date: {saleDateStr})");
                billTitle.Format.Font.Size = 12;
                billTitle.Format.Font.Bold = true;
                billTitle.Format.SpaceAfter = 5;

                Paragraph saleSummary = section.AddParagraph(
                    $"Username: {(sale["user_name"]?.ToString() ?? "N/A")}, " +
                    $"Total Items: {(sale["quantity_of_items"]?.ToString() ?? "0")}, " +
                    $"Payment Method: {(sale["payment_method"]?.ToString() ?? "N/A")}, " +
                    $"Total Price: {(sale["total_price"] != DBNull.Value ? Convert.ToDecimal(sale["total_price"]).ToString("N2") : "0.00")}"
                );
                saleSummary.Format.SpaceAfter = 5;

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

                Row headerRow = table.AddRow();
                headerRow.HeadingFormat = true;
                headerRow.Height = Unit.FromCentimeter(0.8);
                headerRow.Style = "TableHeader";
                headerRow.Shading.Color = Colors.SkyBlue;
                headerRow.Cells[0].AddParagraph("Product Name");
                headerRow.Cells[1].AddParagraph("Variation Type");
                headerRow.Cells[2].AddParagraph("Unit");
                headerRow.Cells[3].AddParagraph("Quantity");
                headerRow.Cells[4].AddParagraph("Price");
                headerRow.Cells[5].AddParagraph("Total Price");

                DataRow[] detailsRows = customerDetails.Select($"bill_no = '{billNo}'");
                foreach (DataRow detail in detailsRows)
                {
                    Row dataRow = table.AddRow();
                    dataRow.Style = "TableCell";
                    dataRow.Cells[0].AddParagraph(detail["product_name"]?.ToString() ?? "N/A");
                    dataRow.Cells[1].AddParagraph(detail["variation_type"]?.ToString() ?? "N/A");
                    dataRow.Cells[2].AddParagraph(detail["unit"]?.ToString() ?? "N/A");
                    dataRow.Cells[3].AddParagraph(detail["quantity"]?.ToString() ?? "0");
                    decimal price = detail["price"] != DBNull.Value ? Convert.ToDecimal(detail["price"]) : 0;
                    dataRow.Cells[4].AddParagraph($"LKR {price.ToString("N2")}");
                    decimal totalPrice = detail["total_price"] != DBNull.Value ? Convert.ToDecimal(detail["total_price"]) : 0;
                    dataRow.Cells[5].AddParagraph($"LKR {totalPrice.ToString("N2")}");
                }

                decimal billTotal = detailsRows.Sum(row => row["total_price"] != DBNull.Value ? Convert.ToDecimal(row["total_price"]) : 0);
                Row totalRow = table.AddRow();
                totalRow.Height = Unit.FromCentimeter(0.8);
                totalRow.Style = "TableHeader";
                totalRow.Shading.Color = Colors.SkyBlue;
                totalRow.Cells[0].MergeRight = 3;
                totalRow.Cells[0].AddParagraph("Total");
                totalRow.Cells[4].AddParagraph("");
                totalRow.Cells[5].AddParagraph($"LKR {billTotal.ToString("N2")}");

                section.AddParagraph("").Format.SpaceAfter = 10;
            }
        }

        public void AddSupplierHistoryTable(DataTable supplierPurchases, DataTable purchaseDetails)
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

            foreach (DataRow purchase in supplierPurchases.Rows)
            {
                string grnId = purchase["grn_id"]?.ToString() ?? "N/A";

                Paragraph grnTitle = section.AddParagraph($"GRN ID: {grnId}");
                grnTitle.Format.Font.Size = 12;
                grnTitle.Format.Font.Bold = true;
                grnTitle.Format.SpaceAfter = 5;

                Paragraph purchaseSummary = section.AddParagraph(
                    $"Product: {(purchase["product_name"]?.ToString() ?? "N/A")}, " +
                    $"Quantity: {(purchase["quantity"]?.ToString() ?? "0")}, " +
                    $"Cost Price: LKR {(purchase["cost_price"] != DBNull.Value ? Convert.ToDecimal(purchase["cost_price"]).ToString("N2") : "0.00")}, " +
                    $"Net Price: LKR {(purchase["net_price"] != DBNull.Value ? Convert.ToDecimal(purchase["net_price"]).ToString("N2") : "0.00")}"
                );
                purchaseSummary.Format.SpaceAfter = 5;

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

                Row headerRow = table.AddRow();
                headerRow.HeadingFormat = true;
                headerRow.Height = Unit.FromCentimeter(0.8);
                headerRow.Style = "TableHeader";
                headerRow.Shading.Color = Colors.SkyBlue;
                headerRow.Cells[0].AddParagraph("Product Name");
                headerRow.Cells[1].AddParagraph("Variation Type");
                headerRow.Cells[2].AddParagraph("Unit");
                headerRow.Cells[3].AddParagraph("Quantity");
                headerRow.Cells[4].AddParagraph("Cost Price");
                headerRow.Cells[5].AddParagraph("Net Price");
                headerRow.Cells[6].AddParagraph("Expiry Date");
                headerRow.Cells[7].AddParagraph("Warranty");

                DataRow[] detailsRows = purchaseDetails.Select($"grn_id = '{grnId}'");
                foreach (DataRow detail in detailsRows)
                {
                    Row dataRow = table.AddRow();
                    dataRow.Style = "TableCell";
                    dataRow.Cells[0].AddParagraph(detail["product_name"]?.ToString() ?? "N/A");
                    dataRow.Cells[1].AddParagraph(detail["variation_type"]?.ToString() ?? "N/A");
                    dataRow.Cells[2].AddParagraph(detail["unit"]?.ToString() ?? "N/A");
                    dataRow.Cells[3].AddParagraph(detail["quantity"]?.ToString() ?? "0");
                    decimal costPrice = detail["cost_price"] != DBNull.Value ? Convert.ToDecimal(detail["cost_price"]) : 0;
                    dataRow.Cells[4].AddParagraph($"LKR {costPrice.ToString("N2")}");
                    decimal netPrice = detail["net_price"] != DBNull.Value ? Convert.ToDecimal(detail["net_price"]) : 0;
                    dataRow.Cells[5].AddParagraph($"LKR {netPrice.ToString("N2")}");
                    string expiryDate = detail["expiry_date"] != DBNull.Value ? Convert.ToDateTime(detail["expiry_date"]).ToString("yyyy-MM-dd") : "N/A";
                    dataRow.Cells[6].AddParagraph(expiryDate);
                    dataRow.Cells[7].AddParagraph(detail["warranty"]?.ToString() ?? "N/A");
                }

                decimal grnTotal = detailsRows.Sum(row => row["net_price"] != DBNull.Value ? Convert.ToDecimal(row["net_price"]) : 0);
                Row totalRow = table.AddRow();
                totalRow.Height = Unit.FromCentimeter(0.8);
                totalRow.Style = "TableHeader";
                totalRow.Shading.Color = Colors.SkyBlue;
                totalRow.Cells[0].MergeRight = 4;
                totalRow.Cells[0].AddParagraph("Total");
                totalRow.Cells[5].AddParagraph($"LKR {grnTotal.ToString("N2")}");
                totalRow.Cells[6].AddParagraph("");
                totalRow.Cells[7].AddParagraph("");

                section.AddParagraph("").Format.SpaceAfter = 10;
            }
        }

        public Document CreatePurchaseReturnReportDocument(DataTable purchaseReturnTable, string filterDescription)
        {
            document = new Document();
            document.Info.Title = "Purchase Return Report";
            document.Info.Author = "EscopeWindowsApp";

            DefineStyles();
            section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.TopMargin = Unit.FromCentimeter(4);
            section.PageSetup.LeftMargin = Unit.FromCentimeter(2);
            section.PageSetup.RightMargin = Unit.FromCentimeter(2);
            section.PageSetup.HeaderDistance = Unit.FromCentimeter(1);

            AddHeader();
            AddReportTitle("Purchase Return Report", filterDescription);
            AddPurchaseReturnSummaryTable(purchaseReturnTable);
            AddSpacer();
            AddPurchaseReturnTable(purchaseReturnTable);
            AddFooter();

            return document;
        }

        private void AddPurchaseReturnSummaryTable(DataTable purchaseReturnTable)
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
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Total Returned Items");
            headerRow.Cells[1].AddParagraph("Total Return Amount");

            Row dataRow = summaryTable.AddRow();
            dataRow.Style = "SummaryTable";
            dataRow.Cells[0].AddParagraph(totalReturnedItems.ToString());
            dataRow.Cells[1].AddParagraph(totalReturnAmount.ToString("N2"));

            summaryTable.Format.SpaceAfter = 0;
        }

        private void AddPurchaseReturnTable(DataTable purchaseReturnTable)
        {
            Table table = section.AddTable();
            table.Borders.Width = 0.5;
            table.Rows.Height = 10;
            table.KeepTogether = false;

            table.AddColumn(Unit.FromCentimeter(2));   // Return No
            table.AddColumn(Unit.FromCentimeter(2));   // GRN No
            table.AddColumn(Unit.FromCentimeter(3));   // Product Name
            table.AddColumn(Unit.FromCentimeter(2.5)); // Variation Type
            table.AddColumn(Unit.FromCentimeter(2));   // Unit
            table.AddColumn(Unit.FromCentimeter(2));   // Quantity
            table.AddColumn(Unit.FromCentimeter(2.5)); // Cost Price
            table.AddColumn(Unit.FromCentimeter(2.5)); // Net Price
            table.AddColumn(Unit.FromCentimeter(3));   // Reason
            table.AddColumn(Unit.FromCentimeter(2.5)); // Date

            Row headerRow = table.AddRow();
            headerRow.HeadingFormat = true;
            headerRow.Height = Unit.FromCentimeter(0.8);
            headerRow.Style = "TableHeader";
            headerRow.Shading.Color = Colors.SkyBlue;
            headerRow.Cells[0].AddParagraph("Return No");
            headerRow.Cells[1].AddParagraph("GRN No");
            headerRow.Cells[2].AddParagraph("Product Name");
            headerRow.Cells[3].AddParagraph("Variation Type");
            headerRow.Cells[4].AddParagraph("Unit");
            headerRow.Cells[5].AddParagraph("Quantity");
            headerRow.Cells[6].AddParagraph("Cost Price");
            headerRow.Cells[7].AddParagraph("Net Price");
            headerRow.Cells[8].AddParagraph("Reason");
            headerRow.Cells[9].AddParagraph("Date");

            foreach (DataRow row in purchaseReturnTable.Rows)
            {
                Row dataRow = table.AddRow();
                dataRow.Style = "TableCell";
                dataRow.Cells[0].AddParagraph(row["return_no"]?.ToString() ?? "N/A");
                dataRow.Cells[1].AddParagraph(row["grn_no"]?.ToString() ?? "N/A");
                dataRow.Cells[2].AddParagraph(row["product_name"]?.ToString() ?? "N/A");
                dataRow.Cells[3].AddParagraph(row["variation_type"]?.ToString() ?? "N/A");
                dataRow.Cells[4].AddParagraph(row["unit"]?.ToString() ?? "N/A");
                decimal quantity = row["quantity"] != DBNull.Value ? Convert.ToDecimal(row["quantity"]) : 0;
                dataRow.Cells[5].AddParagraph(quantity.ToString("N2"));
                decimal costPrice = row["cost_price"] != DBNull.Value ? Convert.ToDecimal(row["cost_price"]) : 0;
                dataRow.Cells[6].AddParagraph(costPrice.ToString("N2"));
                decimal netPrice = row["net_price"] != DBNull.Value ? Convert.ToDecimal(row["net_price"]) : 0;
                dataRow.Cells[7].AddParagraph(netPrice.ToString("N2"));
                dataRow.Cells[8].AddParagraph(row["reason"]?.ToString() ?? "N/A");
                dataRow.Cells[9].AddParagraph(row["created_at"] != DBNull.Value ? Convert.ToDateTime(row["created_at"]).ToString("yyyy-MM-dd") : "N/A");
            }

            decimal totalAmount = purchaseReturnTable.AsEnumerable().Sum(row => row["net_price"] != DBNull.Value ? Convert.ToDecimal(row["net_price"]) : 0);
            Row totalRow = table.AddRow();
            totalRow.Height = Unit.FromCentimeter(0.8);
            totalRow.Style = "TableHeader";
            totalRow.Shading.Color = Colors.SkyBlue;
            totalRow.Cells[0].MergeRight = 6;
            totalRow.Cells[0].AddParagraph("Total");
            totalRow.Cells[7].AddParagraph(totalAmount.ToString("N2"));
            totalRow.Cells[8].AddParagraph("");
            totalRow.Cells[9].AddParagraph("");
        }

        public void AddFooter()
        {
            Paragraph footer = section.Footers.Primary.AddParagraph();
            footer.Format.Font.Size = 8;
            footer.Format.Alignment = ParagraphAlignment.Center;
            footer.AddText($"Generated on {DateTime.Now:yyyy-MM-dd HH:mm} - Flow POS by E Scope International (Pvt) Ltd. " +
                $"© 2020 All rights reserved. | Contact Us: 075 - 7119340");
            footer.Format.SpaceBefore = 10;
            footer.Format.Borders.Top.Width = 0.5;

            footer.AddPageField();
            footer.AddText("/");
            footer.AddNumPagesField();
        }
    }
}