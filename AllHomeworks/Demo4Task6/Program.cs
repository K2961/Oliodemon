using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add new CD-Discs
            CD Cd1 = new CD("Turmion Kätilöt: Technodiktator", "Osasto -A", "CD", "Osasto-A", "MediaPlayer", "CD-shelf");
            CD Cd2 = new CD("Moonspell: Darkness and Hope ", "Century-Media", "CD", "Hiili Hiilesmaa", "MediaPlayer", "CD-shelf");

            // Add new laptops
            Laptop lapt1 = new Laptop("Acer 5151", "Acer Incorporated", "Computer", "Acer Incorporated", "Windows 7", "Devices-shelf");



            Console.WriteLine("\nBookshelfs content:  ");
            Console.WriteLine(Cd1.ToString());
            Console.WriteLine(Cd2.ToString());
            Console.WriteLine(lapt1.ToString());
            Console.ReadLine();
        }
    }
}
