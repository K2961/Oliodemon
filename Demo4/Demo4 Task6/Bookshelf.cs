using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_Task6
{
    class Bookshelf
    {
        public string Name { get; set; }
        public string Publisher
        {get; set;}
        public string Format { get; set; }
        public string Manufacturer { get; set; }
        public string OperationSystem { get; set; }

        public Bookshelf(string name, string publisher, string format, string manufacturer, string operationSystem)
        {
            Name = name;
            Publisher = publisher;
            Format = format;
            Manufacturer = manufacturer;
            OperationSystem = operationSystem;
        }

        public override string ToString()
        {
            return "\nNimi: " + Name + "\nJulkaisija: " + " " + Publisher + " " + "\nFormaatti: " + Format + " " + "\nValmistaja: " + Manufacturer + " ";
        }
    }
   
}
