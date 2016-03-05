using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            Console.WriteLine("Sum = {0:F2}", ArrayCalcs.Sum(array));
            Console.WriteLine("Ave = {0:F2}", ArrayCalcs.Average(array));
            Console.WriteLine("Min = {0:F2}", ArrayCalcs.Min(array));
            Console.WriteLine("Max = {0:F2}", ArrayCalcs.Max(array));

            Console.WriteLine("Press enter key to continue...");
            Console.Read();
        }
    }
}
