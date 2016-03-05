using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task2
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }


        public override string ToString()
        {
            return name + " " + price;
        }
    }
}
