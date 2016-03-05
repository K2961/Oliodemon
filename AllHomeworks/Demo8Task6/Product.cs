using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task6
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }

        public double total => price * quantity;

        public Product(string Name, double Price, string Description, int Quantity)
        {
            name = Name;
            price = Price;
            description = Description;
            quantity = Quantity;
        }

        public override string ToString()
        {
            return name + " " + price + " euros " + quantity + " pieces " + total + " euros total";
        }

    }
}
