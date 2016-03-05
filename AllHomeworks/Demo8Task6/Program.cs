using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Receipt receipt = new Receipt();

           
            receipt.customer = "Mad Max";
            receipt.Items.Add(new Product("Milk", 2.35, "Valio milk", 1));
            receipt.Items.Add(new Product("Beer", 1.99, "Koff", 1));
            receipt.Items.Add(new Product("Butter", 1.98, "Flora normal salt", 2));

            
            receipt.PrintReceipt();

           
            Console.ReadLine();
        }
    }
}
