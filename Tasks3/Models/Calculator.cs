using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Calculator
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sqrt(double n)
        {
            return Math.Sqrt(n);
        }
    }
}
