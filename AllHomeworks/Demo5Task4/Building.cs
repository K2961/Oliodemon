using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5Task4
{
    class Building
    {
        public string Apartments { get; set; }

        public Building(string apartments)
        {
           Apartments = apartments;
        }

             public override string ToString()
        {
            return Apartments ;
        }
    }
}
