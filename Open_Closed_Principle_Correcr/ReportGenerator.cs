using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle_Correct
{
    /// <summary>
    /// Class that uses the Open/Closed Principle
    /// </summary>
    public class ReportGenerator
    {
        private IReport report; //llamado inyeccion de dependencias

        public ReportGenerator(IReport report) => this.report = report;

        //public void Report()
        //{
        //    report.Generate();
        //}

        public void Report() => report.Generate();
    }
}
