using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Integral
{
    public class EmailSender : IEmailServer
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending report via email...");
        }
    }
}
