using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fisei.uta.edu.ec.utils.ISP;

namespace fisei.uta.edu.ec.utils.LSP
{
    public class EmailSender : IEmailServer
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending report via email...");
        }
    }
}
