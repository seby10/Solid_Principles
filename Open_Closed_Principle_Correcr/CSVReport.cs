using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle_Correct
{
    public class CSVReport : IReport
    {
        //public void Generate()
        //{
        //    Console.WriteLine("Generating the Report in CSV...");
        //}

        public void Generate() => Console.WriteLine("Generating the Report in CSV...");
    }
}
