using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task6
{
    class Receipt
    {
        public string customer { get; set; }
        public double total => CountTotal();
        public int totalitems => CountTotalItems();
        public List<Product> Items { get; set; } = new List<Product>();

        private double CountTotal()
        {
            double total = 0;
            foreach (Product item in Items)
            {
                total += item.total;
            }
            return total;
        }
        private int CountTotalItems()
        {
            return Items.Count;
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Customer {0}'s Receipt:", customer);
            Console.WriteLine("=================================");
            foreach (Product item in Items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("=================================");
            Console.Write("Total : " + total + " euros");
        }
    }
}
