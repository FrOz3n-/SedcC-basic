using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square()
            {
                side = 4
            };

            Console.WriteLine("Area: {0}\nPerimeter: {1}", square.CalculateArea(), square.CalculatePerimeter());

            
        }
    }
}
