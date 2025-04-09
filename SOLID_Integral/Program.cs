using fisei.uta.edu.ec.utils;
using fisei.uta.edu.ec.utils.DIP;
using fisei.uta.edu.ec.utils.ISP;
using fisei.uta.edu.ec.utils.LSP;
using fisei.uta.edu.ec.utils.SRP;
using fisei.uta.edu.ec.utils.Test;

namespace SOLID_Integral;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SOLID PRINCIPLES ===\n");
        IReport report2 = new PDFReport();
        IReport report1 = new ExcelReport();
        IReport report3 = new WordReport();

        IFileServer fileServer = new FileServer();
        IEmailServer emailServer = new EmailSender();

        ReportService reportService = new(fileServer, emailServer);
        reportService.ProcessReport(report3);

        Console.WriteLine("\n=== Usage Example of the class Mathematics as a DLL===\n");
        Mathematics math = new Mathematics();
        Console.WriteLine($"Subtraction: {math.Subtract(10, 5)}");
        Console.WriteLine($"Addition: {math.Add(10, 5)}");
        Console.WriteLine($"Potentiation: {Mathematics.Power(10, 3)}");
        Console.WriteLine($"Potentiation: {Mathematics.Power(exponent: 2, _base: 17)}");

        Test test = new Test();

        Console.ReadLine();
    }
}
