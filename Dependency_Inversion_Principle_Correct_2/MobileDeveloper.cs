using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Correct_2
{
    internal class MobileDeveloper : IDeveloper
    {
        public void Develop()
        {
            Console.WriteLine("The Mobile Developer is currently working on Flutter");
        }
    }
}
