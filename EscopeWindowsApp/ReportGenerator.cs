using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using ClosedXML.Excel;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System;

// Class to hold company details
public class CompanyDetails
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public byte[] Logo { get; set; }
    public string Website { get; set; }
}

public class ReportGenerator
{
    private string connectionString;

    public ReportGenerator(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Fetch company details from the database
    private CompanyDetails GetCompanyDetails()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT id, name, email, phone_number, address, logo, website FROM company_details LIMIT 1";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new CompanyDetails
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Email = reader.GetString("email"),
                            PhoneNumber = reader.IsDBNull(reader.GetOrdinal("phone_number")) ? null : reader.GetString("phone_number"),
                            Address = reader.IsDBNull(reader.GetOrdinal("address")) ? null : reader.GetString("address"),
                            Logo = reader.IsDBNull(reader.GetOrdinal("logo")) ? null : (byte[])reader["logo"],
                            Website = reader.IsDBNull(reader.GetOrdinal("website")) ? null : reader.GetString("website")
                        };
                    }
                    else
                    {
                        throw new Exception("No company details found.");
                    }
                }
            }
        }
    }

    // Generate PDF report
    public void GenerateSalesPdf(DataTable salesData, string dateFilter, string filePath)
    {
        CompanyDetails company = GetCompanyDetails();
        Document document = new Document();
        document.Info.Title = "Sales Report";
        document.Info.Author = company.Name;

        Section section = document.AddSection();

        // Add company logo and details
        if (company.Logo != null)
        {
            string base64Logo = Convert.ToBase64String(company.Logo);
            string imageFilename = "base64:" + base64Logo;
            Paragraph logoPara = section.AddParagraph();
            logoPara.AddImage(imageFilename);
            logoPara.Format.Alignment = ParagraphAlignment.Left;
        }

        Paragraph companyPara = section.AddParagraph();
        companyPara.AddText(company.Name);
        companyPara.AddLineBreak();
        if (!string.IsNullOrEmpty(company.Address))
        {
            companyPara.AddText(company.Address);
            companyPara.AddLineBreak();
        }
        if (!string.IsNullOrEmpty(company.PhoneNumber))
        {
            companyPara.AddText($"Phone: {company.PhoneNumber}");
            companyPara.AddLineBreak();
        }
        if (!string.IsNullOrEmpty(company.Email))
        {
            companyPara.AddText($"Email: {company.Email}");
            companyPara.AddLineBreak();
        }
        if (!string.IsNullOrEmpty(company.Website))
        {
            companyPara.AddText($"Website: {company.Website}");
        }

        // Add report title
        string reportTitle = $"Sales Report ({dateFilter}) - {DateTime.Now:yyyy-MM-dd}";
        Paragraph titlePara = section.AddParagraph(reportTitle);
        titlePara.Format.Font.Size = 14;
        titlePara.Format.Font.Bold = true;
        titlePara.Format.SpaceAfter = 10;
        titlePara.Format.Alignment = ParagraphAlignment.Center;

        // Add table
        Table table = section.AddTable();
        table.Borders.Width = 0.5;
        table.Rows.Height = 10;

        // Define columns
        table.AddColumn(Unit.FromCentimeter(3));  // Bill Number
        table.AddColumn(Unit.FromCentimeter(3));  // Customer Name
        table.AddColumn(Unit.FromCentimeter(3));  // Username
        table.AddColumn(Unit.FromCentimeter(2));  // Quantity of Items
        table.AddColumn(Unit.FromCentimeter(2));  // Payment Method
        table.AddColumn(Unit.FromCentimeter(2));  // Total Price
        table.AddColumn(Unit.FromCentimeter(3));  // Sale Date

        // Add header row
        Row headerRow = table.AddRow();
        headerRow.HeadingFormat = true;
        headerRow.Format.Font.Bold = true;
        headerRow.Cells[0].AddParagraph("Bill Number");
        headerRow.Cells[1].AddParagraph("Customer Name");
        headerRow.Cells[2].AddParagraph("Username");
        headerRow.Cells[3].AddParagraph("Quantity of Items");
        headerRow.Cells[4].AddParagraph("Payment Method");
        headerRow.Cells[5].AddParagraph("Total Price");
        headerRow.Cells[6].AddParagraph("Sale Date");

        // Add data rows
        foreach (DataRow row in salesData.Rows)
        {
            Row dataRow = table.AddRow();
            dataRow.Cells[0].AddParagraph(row["bill_no"].ToString());
            dataRow.Cells[1].AddParagraph(row["customer"].ToString());
            dataRow.Cells[2].AddParagraph(row["user_name"].ToString());
            dataRow.Cells[3].AddParagraph(row["quantity_of_items"].ToString());
            dataRow.Cells[4].AddParagraph(row["payment_method"].ToString());
            dataRow.Cells[5].AddParagraph(row["total_price"].ToString());
            dataRow.Cells[6].AddParagraph(Convert.ToDateTime(row["sale_date"]).ToString("yyyy-MM-dd"));
        }

        // Render to PDF
        PdfDocumentRenderer renderer = new PdfDocumentRenderer(true);
        renderer.Document = document;
        renderer.RenderDocument();
        renderer.PdfDocument.Save(filePath);
    }

    // Generate Excel report
    public void GenerateSalesExcel(DataTable salesData, string dateFilter, string filePath)
    {
        CompanyDetails company = GetCompanyDetails();
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Sales Report");

            // Add company logo
            if (company.Logo != null)
            {
                using (MemoryStream ms = new MemoryStream(company.Logo))
                {
                    var picture = worksheet.AddPicture(ms)
                        .MoveTo(worksheet.Cell("A1"))
                        .WithSize(100, 100); // Adjust size as needed
                }
            }

            // Add company details
            int startRow = 1;
            if (company.Logo != null)
            {
                startRow = 3; // Adjust based on logo size
            }
            worksheet.Cell(startRow, 2).Value = company.Name;
            if (!string.IsNullOrEmpty(company.Address))
                worksheet.Cell(startRow + 1, 2).Value = company.Address;
            if (!string.IsNullOrEmpty(company.PhoneNumber))
                worksheet.Cell(startRow + 2, 2).Value = $"Phone: {company.PhoneNumber}";
            if (!string.IsNullOrEmpty(company.Email))
                worksheet.Cell(startRow + 3, 2).Value = $"Email: {company.Email}";
            if (!string.IsNullOrEmpty(company.Website))
                worksheet.Cell(startRow + 4, 2).Value = $"Website: {company.Website}";

            // Add report title
            int titleRow = startRow + 5;
            string reportTitle = $"Sales Report ({dateFilter}) - {DateTime.Now:yyyy-MM-dd}";
            worksheet.Cell(titleRow, 1).Value = reportTitle;
            worksheet.Range(titleRow, 1, titleRow, 7).Merge().Style.Font.Bold = true;

            // Add headers
            int headerRow = titleRow + 1;
            worksheet.Cell(headerRow, 1).Value = "Bill Number";
            worksheet.Cell(headerRow, 2).Value = "Customer Name";
            worksheet.Cell(headerRow, 3).Value = "Username";
            worksheet.Cell(headerRow, 4).Value = "Quantity of Items";
            worksheet.Cell(headerRow, 5).Value = "Payment Method";
            worksheet.Cell(headerRow, 6).Value = "Total Price";
            worksheet.Cell(headerRow, 7).Value = "Sale Date";
            worksheet.Range(headerRow, 1, headerRow, 7).Style.Font.Bold = true;

            // Add data rows
            for (int i = 0; i < salesData.Rows.Count; i++)
            {
                DataRow row = salesData.Rows[i];
                worksheet.Cell(headerRow + 1 + i, 1).Value = row["bill_no"].ToString();
                worksheet.Cell(headerRow + 1 + i, 2).Value = row["customer"].ToString();
                worksheet.Cell(headerRow + 1 + i, 3).Value = row["user_name"].ToString();
                worksheet.Cell(headerRow + 1 + i, 4).Value = row["quantity_of_items"].ToString();
                worksheet.Cell(headerRow + 1 + i, 5).Value = row["payment_method"].ToString();
                worksheet.Cell(headerRow + 1 + i, 6).Value = row["total_price"].ToString();
                worksheet.Cell(headerRow + 1 + i, 7).Value = row["sale_date"].ToString();
            }

            // Adjust column widths
            worksheet.Columns().AdjustToContents();

            // Save workbook
            workbook.SaveAs(filePath);
        }
    }
}