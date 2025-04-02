using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_Correct;

public class Human : IWorkable, IEatable
{
    public void Eat()
    {
        Console.WriteLine("Humans eat...!");
    }

    public void Work()
    {
        Console.WriteLine("Humans work...!");
    }
}
