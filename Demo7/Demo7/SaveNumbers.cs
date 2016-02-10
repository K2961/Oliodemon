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

        public void Menu()
        {
            Console.WriteLine("\n::::::::::::::::Menu::::::::::::::::::");
            Console.WriteLine("\nAnna numerot tallennettavaksi painamalla 1 ");
            Console.WriteLine("\nLopeta ohjelman käyttö painamalla 0 ");
            int Choice = int.Parse(Console.ReadLine());
        }

        public void GetNumbers()
        {
            Console.WriteLine("Anna luku");
            int line = int.Parse(Console.ReadLine());
            Console.WriteLine(line);
        }

        public void SaveDemNumbers()
        {

        }

        public void WorkingI()
        {
            Working = true;
        }

        public void Working0()
        {
            Working = false;

            Console.ReadLine();
        }
    
    }
}
