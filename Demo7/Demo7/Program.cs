using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7
{
    class Program
    {
        static void Main(string[] args)
        {


            
        Console.WriteLine("Welcome to the ultimate NUMBERS saving program!");
            SaveNumbers one = new SaveNumbers();
            one.Menu();
            one.GetNumbers();
            one.WorkingI();
            one.Working0();
            do
            {
                one.Menu();
                switch (one.Choice)
                {
                    case 1:
                        one.GetNumbers();
                        one.Menu();
                        break;
                    case 0:
                        one.Working0();
                        break;
                }

            } while (one.Working == true);
        }
    }
}
