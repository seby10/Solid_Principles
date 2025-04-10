﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fisei.uta.edu.ec.utils.ISP;
using fisei.uta.edu.ec.utils.OCP;
using fisei.uta.edu.ec.utils.SRP;

namespace fisei.uta.edu.ec.utils.DIP
{
    public class ReportService
    {
        private readonly IFileServer _fileServer;
        private readonly IEmailServer _emailServer;

        public ReportService(IFileServer fileServer, IEmailServer emailServer   )
        {
            _fileServer = fileServer;
            _emailServer = emailServer;
        }

        public void ProcessReport(IReport report)
        {
            ReportGenerator generator = new ReportGenerator(report);
            generator.Report();
            _fileServer.SaveToFile();
            _emailServer.SendEmail();
        }
    }
}
