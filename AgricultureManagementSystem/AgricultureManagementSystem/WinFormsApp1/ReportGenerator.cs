using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


public class ReportGenerator
{
    private string _reportName;
    private string _query;
    private string _connectionString;

    public ReportGenerator(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void GenerateReport(string reportName, string query, string outputPath)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(reportName))
                throw new ArgumentException("Report name cannot be empty");

            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Query cannot be empty");

            if (string.IsNullOrWhiteSpace(outputPath))
                throw new ArgumentException("Output path cannot be empty");

            _reportName = reportName;
            _query = query;

            DataTable data = ExecuteQuery();
            GeneratePdf(data, outputPath);
        }
        catch (Exception ex)
        {
            // Log the error (you could replace this with your logging mechanism)
            string errorMessage = $"Error generating report '{reportName}': {ex.Message}";
            File.WriteAllText(Path.Combine(Path.GetDirectoryName(outputPath), "ReportError.log"), errorMessage);
            throw new Exception(errorMessage, ex);
        }
    }

    private DataTable ExecuteQuery()
    {
        using (var connection = new MySqlConnection(_connectionString))
        {
            using (var command = new MySqlCommand(_query, connection))
            {
                connection.Open();
                using (var adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    private void GeneratePdf(DataTable data, string outputPath)
    {
        // Create document
        Document document = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

        document.Open();

        // Add title
        iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
        Paragraph title = new Paragraph(_reportName, titleFont);
        title.Alignment = Element.ALIGN_CENTER;
        title.SpacingAfter = 20f;
        document.Add(title);

        // Add date
        iTextSharp.text.Font dateFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
        Paragraph date = new Paragraph($"Generated on: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}", dateFont);
        date.Alignment = Element.ALIGN_RIGHT;
        date.SpacingAfter = 15f;
        document.Add(date);

        // Create table
        PdfPTable table = new PdfPTable(data.Columns.Count);
        table.WidthPercentage = 100;

        // Calculate column widths based on content
        float[] columnWidths = CalculateColumnWidths(data);
        table.SetWidths(columnWidths);

        // Add headers
        iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.WHITE);
        foreach (DataColumn column in data.Columns)
        {
            PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, headerFont));
            cell.BackgroundColor = new BaseColor(70, 130, 180); // Steel blue
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Padding = 5;
            table.AddCell(cell);
        }

        // Add data rows
        iTextSharp.text.Font dataFont = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.BLACK);
        foreach (DataRow row in data.Rows)
        {
            foreach (DataColumn column in data.Columns)
            {
                string cellValue = row[column]?.ToString() ?? string.Empty;
                PdfPCell cell = new PdfPCell(new Phrase(cellValue, dataFont));
                cell.Padding = 4;

                // Right align numeric columns
                if (IsNumericType(column.DataType))
                {
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                }

                table.AddCell(cell);
            }
        }

        document.Add(table);
        document.Close();
    }

    private float[] CalculateColumnWidths(DataTable data)
    {
        // Create a dictionary to store maximum widths for each column
        Dictionary<int, float> maxWidths = new Dictionary<int, float>();

        // Initialize with column header widths
        iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
        for (int i = 0; i < data.Columns.Count; i++)
        {
            float width = headerFont.GetCalculatedBaseFont(false).GetWidthPoint(
                data.Columns[i].ColumnName, headerFont.CalculatedSize);
            maxWidths[i] = width + 10; // Add padding
        }

        // Check data row widths
        iTextSharp.text.Font dataFont = FontFactory.GetFont(FontFactory.HELVETICA, 9);
        foreach (DataRow row in data.Rows)
        {
            for (int i = 0; i < data.Columns.Count; i++)
            {
                string cellValue = row[i]?.ToString() ?? string.Empty;
                float width = dataFont.GetCalculatedBaseFont(false).GetWidthPoint(
                    cellValue, dataFont.CalculatedSize);

                if (width > maxWidths[i])
                {
                    maxWidths[i] = width + 10; // Add padding
                }
            }
        }

        // Calculate total width
        float totalWidth = maxWidths.Sum(x => x.Value);

        // Normalize to 100% width
        float[] relativeWidths = new float[data.Columns.Count];
        for (int i = 0; i < data.Columns.Count; i++)
        {
            relativeWidths[i] = (maxWidths[i] / totalWidth) * 100f;
        }

        return relativeWidths;
    }

    private bool IsNumericType(Type type)
    {
        if (type == null) return false;

        switch (Type.GetTypeCode(type))
        {
            case TypeCode.Byte:
            case TypeCode.SByte:
            case TypeCode.UInt16:
            case TypeCode.UInt32:
            case TypeCode.UInt64:
            case TypeCode.Int16:
            case TypeCode.Int32:
            case TypeCode.Int64:
            case TypeCode.Decimal:
            case TypeCode.Double:
            case TypeCode.Single:
                return true;
            default:
                return false;
        }
    }
}