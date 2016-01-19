using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Harjoitus4();

            Console.ReadLine();
        }
        //Tehtävä 1 alkaa!
        static void Harjoitus1()
        {
            Console.Write("Anna luku 1, 2 tai 3 ");

            int luku = int.Parse(Console.ReadLine());

            switch (luku)
            {
                case 1:
                    Console.Write("Annoit luvun: Yksi");
                    break;
                case 2:
                    Console.Write("Annoit luvun: Kaksi");
                    break;
                case 3:
                    Console.Write("Annoit luvun: Kolme");
                    break;
                default:
                    Console.Write("joku muu luku");
                    break;
            }
        }

        // Tehtävä 2 alkaa!

        static void Harjoitus2()
        {
            int numero;

            Console.Write("Anna pistemäärä: ");
            int pisteet = int.Parse(Console.ReadLine());
            

            switch (pisteet)
            {
                case 0:
                case 1:
                    numero = 0;
                    Console.Write("Koulunumero on: " + numero);
                    break;

                case 2:
                case 3:
                    numero = 1;
                    Console.Write("Koulunumero on: " + numero);
                    break;

                case 4:
                case 5:
                    numero = 2;
                    Console.Write("Koulunumero on: " + numero);
                    break;

                case 6:
                case 7:
                    numero = 3;
                    Console.Write("Koulunumero on: " + numero);
                    break;

                case 8:
                case 9:
                    numero = 4;
                    Console.Write("Koulunumero on: " + numero);
                    break;

                case 10:
                case 11:
                case 12:
                    numero = 5;
                    Console.Write("Koulunumero on: " + numero);
                    break;
            }
        }

        // Tehtävä 3 alkaa !

        static void Harjoitus3()
        {
            Console.Write("Anna kolme lukua: ");

            Console.Write("Anna Ensimmainen luku: ");
            int luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna Toinen luku: ");
            int luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna Kolmas luku: ");
            int luku3 = int.Parse(Console.ReadLine());

            Console.Write("Lukujen summa on:  " + ( luku1 + luku2 + luku3));

        }
        // Harjoitus 4 alkaa
        static void Harjoitus4()
        {
            Console.Write("Anna ikäsi: ");
            int ika = int.Parse(Console.ReadLine());

            if (ika > 65)
            {
                Console.Write("Seniori");
            }
            else if (ika > 18)
            {
                Console.Write("Aikuinen");
            }
            else if 
            (ika < 18)
            {
                Console.Write("Alaikäinen");
            }
        }
    }
}
