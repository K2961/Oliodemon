using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6Homework3new
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Card> cards = new List<Card>();
            
            string[] countries = { "Hertta", "Ruutu", "Pata", "Risti" };
            foreach (string Country in countries)
            {
                for (int i = 1; i <= 13; i++)
                {
                    cards.Add(new Card { country = Country, value = i });
                }
            }
            Console.WriteLine("Added cards: ");
           
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
