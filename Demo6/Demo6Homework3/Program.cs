using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6Homework3
{
    class Program
    {
       /* class PlayingCards
        {
            public int[] NumberCards = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            public string[] LetterCards = { "A","J", "Q", "K" };
            public string[] Country = { "Pata", "Hertta", "Ruutu", "Risti" };

            public override string ToString()
            {
                return NumberCards + " " + LetterCards + " " + Country + " ";
            }
            
        }*/
        static void Main(string[] args)
        {
            string[] Country = { "Pata", "Hertta", "Ruutu", "Risti" };
            int[] NumberCards = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] LetterCards = { "A", "J", "Q", "K" };
            int counter = 0;

            for (int i = 0;i < 13; i++)
            {
                if (i == 0)
                {
                    Console.Write("\n" + LetterCards[0] + " " + Country[0]);
                    Console.Write("\n" + LetterCards[0] + " " + Country[1]);
                    Console.Write("\n" + LetterCards[0] + " " + Country[2]);
                    Console.Write("\n" + LetterCards[0] + " " + Country[3]);
                    Console.WriteLine("\n");
                    counter += 4;
                }
                if (i == 1 && i < 9)
                {
                    for (int y = 0; y < 9;y++)
                    {
                        Console.Write("\n" + NumberCards[y] + " " + Country[0]);
                        Console.Write("\n" + NumberCards[y] + " " + Country[1]);
                        Console.Write("\n" + NumberCards[y] + " " + Country[2]);
                        Console.Write("\n" + NumberCards[y] + " " + Country[3]);
                        Console.WriteLine("\n");
                        counter += 4;
                    }
                            
                }
                if (i == 8 && i < 11)
                {
                    for (int y = 1; y < 4; y++)
                    {
                        Console.Write("\n" + LetterCards[y] + " " + Country[0]);
                        Console.Write("\n" + LetterCards[y] + " " + Country[1]);
                        Console.Write("\n" + LetterCards[y] + " " + Country[2]);
                        Console.Write("\n" + LetterCards[y] + " " + Country[3]);
                        Console.WriteLine("\n");
                        counter += 4;
                    }

                }

            }

            Console.WriteLine("\nThere are: " + counter + " cards on the deck.");
            Console.ReadLine();
        }
    }
}
