using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Wallet w = new Wallet();

            w.Add(50.50);
            w.Add(12.30);
            w.Add(8);

            //Card master = new Card("Mastercard", "Jani Immonen", "never");

            //w.Add(master);
            w.Add(new Card("Mastercard", "Jani Immonen", "never"));
            w.Add(new Card("Kirjastokortti", "Jani Immonen", "never"));
            w.Add(new Card("Firman kortti", "Jani Immonen", "12/19"));

            Console.WriteLine(w.ToString());

            //w.Take(master);
            w.Take("Mastercard");
            w.Take(14.10);

            Console.WriteLine(w.ToString());
            Console.ReadLine();
        }
    }
}
