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
            Human human = new Human() { FirstName = "Trajko", LastName = "Prokopiev" };
            Console.WriteLine("Human");
            Console.WriteLine(human.WelcomeMessage("Hello "));
            Console.WriteLine(human.WelcomeMessage("Hello ", "there"));

            Console.WriteLine(human.IsFullNameLongerThanMaxLength(5));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Human human1 = new Human("Krste", "Misirkov");
            Console.WriteLine("Human1");
            Console.WriteLine(human1.WelcomeMessage("Hello "));
            Console.WriteLine(human1.WelcomeMessage("Hello ", "there"));

            Console.WriteLine(human1.IsFullNameLongerThanMaxLength(5));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Human human2 = new Human("Krste", "Petkov", "Misirkov");
            Console.WriteLine("Human2");
            Console.WriteLine(human2.WelcomeMessage("Hello "));
            Console.WriteLine(human2.WelcomeMessage("Hello ", "there"));

        }
    }
}
