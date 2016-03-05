using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> cart = new List<Product>();

            cart.Add(new Product { name = "Milk", price = 1.4 });
            cart.Add(new Product { name = "Beer", price = 2.20 });
            cart.Add(new Product { name = "Butter", price = 3.20 });
            cart.Add(new Product { name = "Cheese", price = 4.20 });

            Console.WriteLine("All products in the cart: ");

            foreach (Product product in cart)
            {
                Console.WriteLine(product.ToString());
            }
            
           
            Console.WriteLine("Press enter key to continue...");
            Console.Read();
        }
    }
}
