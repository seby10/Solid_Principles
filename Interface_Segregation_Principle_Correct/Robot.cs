using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_Correct
{
    internal class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robots work...!");
        }
    }
}
