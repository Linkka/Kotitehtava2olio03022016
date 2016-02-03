using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava2olio03022016
{
    class Product
    {
        // properties
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return "Product: " + Name + " " + Price + "e";
        }

        // destructor
        ~Product()
        {
            Console.WriteLine("Product object destroyed.");
        }
    }

}