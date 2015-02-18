using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human() { FirstName = "Petre", LastName = "Petreski" };
            Console.WriteLine(human.GetFullName());
        }
    }
}
