using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentti1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kosti kosti = new Kosti();

            Console.WriteLine("Kosti is initialized");

            bool running = true;
            do
            {
                Console.WriteLine("Enter value(0 to reset, non-number to exit): ");
                int value = 0;
                running = int.TryParse(Console.ReadLine(), out value);
                if (running)
                {
                    if (value == 0)
                    {
                        kosti.Reset();
                        Console.WriteLine("Kosti is reset");

                    }
                    else
                    {
                        kosti.AddValue(value);
                        Console.WriteLine("value " + value + " added to Kosti");
                        Console.WriteLine("Kosti min=" + kosti.Min + " " + "Kosti max=" + kosti.Max + " " + "Kosti average=" + kosti.Avg);
                    }
                }
            } while (running);

            Console.WriteLine("No number entered, exiting...");
            Console.ReadLine();
        }
    }
}
