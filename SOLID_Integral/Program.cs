namespace SOLID_Integral;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SOLID PRINCIPLES\n");
        IReport report2 = new PDFReport();
        IReport report1 = new ExcelReport();
        IReport report3 = new WordReport();

        IFileServer fileServer = new FileServer();
        IEmailServer emailServer = new EmailSender();

        ReportService reportService = new(fileServer, emailServer);
        reportService.ProcessReport(report3);
        Console.ReadLine();
    }
}
