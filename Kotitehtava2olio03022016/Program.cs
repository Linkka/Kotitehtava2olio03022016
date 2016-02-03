using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava2olio03022016
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Name = "Milk", Price = 0.79 });
            products.Add(new Product { Name = "Beer", Price = 1.5});
            products.Add(new Product { Name = "Bread", Price = 0.89});
            products.Add(new Product { Name = "Ice-Cream", Price = 1.49});


            Console.WriteLine("Products in collection:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
            Console.ReadLine();
        }
        
}
}
