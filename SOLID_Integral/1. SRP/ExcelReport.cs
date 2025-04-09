﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Integral
{
    public class ExcelReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating the Excel Report...");
        }
    }
}
