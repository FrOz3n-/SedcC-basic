using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rectangle
    {
        public int a { get; set; }
        public int b { get; set; }

        public int CalculateArea()
        {
            return a * b;
        }

        public int CalculatePerimeter()
        {
            return 2 * (a + b);
        }

        public double CalcualteDiagonal()
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public int LongerSide()
        {
            return a > b ? a : b;
        }
    }
}
