namespace Open_Closed_Principle;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Open-Closed Principle!\n");

        ReportGenerator reportGenerator = new ReportGenerator();
        reportGenerator.GenerateReport("PDF");
    }

    public class ReportGenerator
    {
        public void GenerateReport(string type)
        {
            switch (type)
            {
                case "PDF":
                    Console.WriteLine("Generating the Report in PDF...");
                    break;
                case "Excel":
                    Console.WriteLine("Generating the Report in Excel...");
                    break;
                default:
                    throw new Exception("Format not supported");

            }
        }
    }
}
