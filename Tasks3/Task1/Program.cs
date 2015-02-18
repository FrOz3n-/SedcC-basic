using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape("Square");
            Console.WriteLine(shape.GetShapeName());

            Console.WriteLine("Addition 2+2={0}", Calculator.Sum(2, 2));
            Console.WriteLine("Square root of 4 = {0}", Calculator.Sqrt(3));
            

        }
    }
}
