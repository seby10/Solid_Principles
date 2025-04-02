using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle_Correct
{
    public class PDFReport:IReport
    {
        //En caso de implementacion miltiple, se debe especificar la interfaz ej: IReport.Generate()
        //public void Generate()
        //{
        //    Console.WriteLine("Generating the Report in PDF...");
        //}
        public void Generate() => Console.WriteLine("Generating the Report in PDF...");

    }
}
