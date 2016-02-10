using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Task6
{
    class Laptop : Bookshelf
    {
        public string Computer { get; set; }

        public Laptop(string name, string publisher, string format, string manufacturer, string operationSystem, string computer) : base(name, publisher, format, manufacturer, operationSystem)
        {
            Computer = computer;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSijainti: " + " " + Computer;
        }
    }
}
