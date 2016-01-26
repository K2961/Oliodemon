using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kirsi = new Employee("Kirsi Kernel", "Teacher", 4200.50f);
            Boss jussi = new Boss("Jussi Jurkka", "Head of institute", 9000.0f, "Audi", 5000.0f);

            kirsi.Salary += 1000.0f;
            jussi.Salary -= 2000.0f;
            jussi.Bonus = 1000.0f;
            //kirsi.Bonus = nocando
        }
    }
}
