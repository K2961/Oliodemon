using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopyloop = true;

            Console.WriteLine("Welcome to Dice Throw App!");

            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("\nPress 1 to throw dice!");
                Console.WriteLine("\nPress 0 to exit!");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)

                {
                    case 1:
                        Console.Write("How many times you want to throw a dice :  ");
                        string line = Console.ReadLine();
                        int times = int.Parse(line);

                        double sum = 0;
                        int value;
                        int[] values = new int[7];
                        for (int i = 1; i <= times; i++)
                        {
                            value = Dice.Throw();
                            sum += value;
                            values[value]++;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Dice is now thrown {0} times", times);
                        Console.WriteLine("- average is {0}", sum / times);
                        for (int i = 1; i <= 6; i++)
                        {
                            Console.WriteLine("- {0} count is {1}", i, values[i]);
                        }
                        Console.WriteLine("Press Enter to go back to Menu.");
                        Console.ReadLine();
                        break;
                    case 0:
                        loopyloop = false;
                        break;

                }
            } while (loopyloop == true);
        }
    }
}
