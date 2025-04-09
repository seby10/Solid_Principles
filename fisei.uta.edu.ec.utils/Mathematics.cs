using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fisei.uta.edu.ec.utils
{
    public class Mathematics
    {
        /// <summary>
        /// This method adds two integers and returns the result as a long.
        /// </summary>
        /// <param name="a">First Integer</param>
        /// <param name="b">Second Integer</param>
        /// <returns>Return the sum of both Integers</returns>
        public long Add(int a, int b)
        {
            return a + b;
        }
        public long Subtract(int a, int b)
        {
            return a - b;
        }

        public static long Power(int _base, int exponent)
        {
            long result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= _base;
            }
            return result;
        }
    }
}
