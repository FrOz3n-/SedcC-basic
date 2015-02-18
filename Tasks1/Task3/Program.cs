using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle { b = 2, a = 3 };
            Console.WriteLine("Area: {0}\nPerimeter: {1}\nDiagonal: {2}",
                                rec.CalculateArea(), rec.CalculatePerimeter(), rec.CalcualteDiagonal());
            PrintArea(rec, 3);
            Square sq = new Square { side = 4 };
            Console.WriteLine("Bigger perimeter: {0}", BiggerPerimeter(rec, sq));

        }

        static void PrintArea(Rectangle rec, int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine("PrintArea: {0}", rec.CalculateArea());
        }

        static int BiggerPerimeter(Rectangle rec, Square sq)
        {
            return rec.CalculatePerimeter() > sq.CalculatePerimeter() ? rec.CalculatePerimeter() : sq.CalculatePerimeter();
        }
    }
}
