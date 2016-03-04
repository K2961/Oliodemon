using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6Task3
{
    class Card
    {
        public string country { get; set; }
        public int value { get; set; }

        public override string ToString()
        {

            return " Country: " + country + " Value: " + value;
        }

    }
}
