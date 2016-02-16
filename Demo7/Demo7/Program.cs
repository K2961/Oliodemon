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
            one.WorkingI();

            do
            {
                Console.WriteLine("\n::::::::::::::::Menu::::::::::::::::::");
                Console.WriteLine("\nAnna numerot tallennettavaksi painamalla 1 ");
                Console.WriteLine("\nTallenna numero tiedostoon painamalla 2 ");
                Console.WriteLine("\nLopeta ohjelman käyttö painamalla 0 ");
                int Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {  
                    case 0:
                        one.Working0();
                        break;
                    case 1:
                        one.GetNumbers();
                        break;
                    case 2:
                        System.IO.StreamWriter outputFile = new System.IO.StreamWriter("test.txt");
                        outputFile.WriteLine(one.Line);
                        outputFile.Close();
                        break;
                }

            } while (one.Working == true);

            Console.WriteLine("Good Bye!");
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
