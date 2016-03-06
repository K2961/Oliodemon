using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> apartments = new List<Building>();
            apartments.Add(new Building("Aholaita kerrostalo"));

            List<Apartment> Apart = new List<Apartment>();
            Apart.Add(new Apartment("54","Mikko Ahomaa", "49", "2"));

            Console.ReadLine();
        }
    }
}
