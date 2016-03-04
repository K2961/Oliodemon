using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Task6
{
    class CD : Bookshelf
    {
        public string CDDiscs { get; set; }

        public CD(string name, string publisher, string format, string manufacturer, string operationSystem, string cddiscs) : base(name, publisher, format, manufacturer, operationSystem)
        {
            CDDiscs = cddiscs;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSijainti: " + " " + CDDiscs;
        }
    }
}
