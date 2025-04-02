namespace Open_Closed_Principle_Correct;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Open-Closed Principle!\n");
        Console.WriteLine("Enter a report type: ");

        string type = Console.ReadLine();

        IReport report;

        switch (type.ToUpper())
        {
            case "PDF":
                report = new PDFReport();
                break;
            case "EXCEL":
                report = new ExcelReport();
                break;
            case "CSV":
                report = new CSVReport();
                break;
            default:
                throw new NotSupportedException("Report not generated");
        }

        ReportGenerator generator = new ReportGenerator(report);
        generator.Report();
    }
}
