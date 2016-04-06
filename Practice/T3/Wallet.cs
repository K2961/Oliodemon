using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Wallet
    {
        private double money = 0.0;
        private Dictionary<string, Card> cards = new Dictionary<string, Card>();

        public void Add(double amount)
        {
            if (amount > 0.0)
            {
                money += amount;
            }
            
        }
        public void Add(Card card)
        {
            cards.Add(card.Name, card);
        }

        public double Take(double amount)
        {
            if (amount > money || amount < 0.0)
            {
                amount = 0;
            }
            else
            {
                money -= amount;
            }
            return amount;
        }

        public void Take(string cardName)
        {
            cards.Remove(cardName);
        }

        public override string ToString()
        {
            return money + "Eur in wallet\n" + cards.Count + " cards in wallet\n";
        }

       
    }
}
