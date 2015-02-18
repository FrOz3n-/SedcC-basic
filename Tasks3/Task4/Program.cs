using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Baker baker = new Baker { Name = "Nekoj", LastName = "Nekojoski" };
            Seller seller = new Seller { Name = "Prodavach", LastName = "Prodaval " };

            Customer cus1 = new Customer { Name = "Customer 1", LastName = "Customer1" };
            Customer cus2 = new Customer { Name = "Customer 2", LastName = "Customer2" };

            Pizza prod1 = new Pizza() { ProductName = "Pica" };
            Burek prod2 = new Burek() { ProductName = "Burek" };

            Sell(baker.Name + baker.LastName, cus1.Name + cus1.LastName, prod1.ProductName);
            Sell(baker.Name + baker.LastName, cus2.Name + cus2.LastName, prod2.ProductName);
        }
        public static void Sell(string Seller, string Customer, string Product)
        {
            Console.WriteLine(Seller + " is selling " + Product + " to " + Customer);
        }
    }
}
