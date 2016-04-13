using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random number test
            int randomnumber;

            Random rand = new Random();

            do
            {
                randomnumber = rand.Next(10);
                Console.WriteLine("Next random number is: " + randomnumber);

            } while (randomnumber != 9);

            Console.WriteLine("The show is over." + "\nPress enter to exit..");
            Console.ReadLine();
        }
    }
}
