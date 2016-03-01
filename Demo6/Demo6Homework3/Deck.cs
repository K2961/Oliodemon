using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6Homework3
{
    class Deck
    {
        public string Country { get; set; }
        public int Value { get; set; }
        public string Letter { get; set; }

        List<string> country;
        List<int> number;
        List<string> letter;
        
        /*public string Country = cardi.Add( "Pata", "Hertta", "Ruutu", "Risti" );
        public int NumberCards = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public int LetterCards = { "A", "J", "Q", "K" };
        int counter = 0;*/

        public Deck()
        {
            country.Add("Pata");
            country.Add("Hertta");
            country.Add("Ruutu");
            country.Add("Risti");

            number.Add(2);
            number.Add(3);
            number.Add(4);
            number.Add(5);
            number.Add(6);
            number.Add(7);
            number.Add(8);
            number.Add(9);
            number.Add(10);

            letter.Add("A");
            letter.Add("J");
            letter.Add("Q");
            letter.Add("K");
        }

        public override string ToString()
        {
            string data = "Deck:";
            data += "\nCountry: " + Country + "\nValue: " + Value;
            data += "\nLetter:" + Letter;
            return data;
        }
    }
}
