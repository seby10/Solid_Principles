using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fisei.uta.edu.ec.utils.SRP;

namespace fisei.uta.edu.ec.utils.OCP
{
    public class ReportGenerator
    {
        /// <summary>
        /// 2. Aplicamos el principio OCP
        /// Ahora podemos agregar mas formatos para los repostes sin modificar el codigo existente
        /// </summary>
        private readonly IReport report;

        public ReportGenerator(IReport report) => this.report = report;

        public void Report()
        {
            report.GenerateReport();
        }

    }
}
