using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7
{
    /// <summary>
    /// Tehtävä 2 - luvut tiedostoihinhome Kotitehtävä
    /// Tee ohjelma, joka kysyy käyttäjältä lukuja(joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut eri tiedostoon kuin reaaliluvut.Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais- tai reaalilukua.Tarkista tiedostojen sisältö jollain tekstieditorilla.
    /// Esimerkkitulostus:
    /// Give a number (enter or not a number ends) : 1,0
    /// Give a number(enter or not a number ends) : 2,0
    /// Give a number(enter or not a number ends) : 3,0
    /// Give a number(enter or not a number ends) : 4
    /// Give a number(enter or not a number ends) : 5
    /// Give a number(enter or not a number ends) : 6
    /// Give a number(enter or not a number ends) :
    /// Contents of T2Integers.txt:
    /// 4
    /// 5
    /// 6
    /// Contents of T2Doubles.txt:
    /// 1,0
    /// 2,0
    /// 3,0
    /// /// </summary>
    /// 
    class SaveNumbers
    {
        public string UserInput{ get; set; }
        public bool Working { get; set; }
        public int Choice { get; set; }
        public float Line { get; set; }

        public void GetNumbers()
        {
            Console.WriteLine("Anna luku");
            try
            {
                float line = float.Parse(Console.ReadLine());
                Console.WriteLine("You gave number " + line);
                Line = line;
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't give a number!");
            }          
        }

        public void WorkingI()
        {
            Working = true;
        }

        public void Working0()
        {
            Working = false;
        }
    
    }
}
