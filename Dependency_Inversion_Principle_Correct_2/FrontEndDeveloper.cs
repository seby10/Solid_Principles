using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Correct_2;

public class FrontEndDeveloper : IDeveloper
{
    public void Develop()
    {
        Console.WriteLine("The Front-End developer is currently working in React");
    }
}
