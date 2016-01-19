using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Harjoitus1();

            Console.ReadLine();
        }
        /// <summary>
        /// Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). 
        /// Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 
        /// </summary>
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

        /// <summary>
        /// Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron): 
        /// </summary>
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

        /// <summary>
        /// Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon. 
        /// </summary>

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
        /// <summary>
        /// Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", 
        /// jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori". 
        /// </summary>
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

        /// <summary>
        /// Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
        /// </summary>
        static void Harjoitus5()
        {
            Console.Write("Anna sekunnit: ");

            int sekunnit = int.Parse(Console.ReadLine());

            int tun = sekunnit / 3600;
            int min =  sekunnit / 60 % 60;
            int sek = sekunnit % 60;

            Console.Write("Antamasi sekunttiaika voidaan ilmaista muodossa: " + tun + "  Tuntia  " + min + "  Minuuttia  " + sek + "  Sekunttia." + "\nHienommin merkattuna:  " + tun + ":" + min + ":" + sek);
        }

        /// <summary>
        /// Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
        /// Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän. 
        /// </summary>

        static void Harjoitus6()
        {
            Console.Write("Anna matka:  ");
            double matka = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Alustaa matkan ja lukee käyttäjän antaman tiedon sekä ottaa pilkun käyttöön desimaaleissa.

            double litrat = matka / 100 * 7.02;
            double kustannus = litrat * 1.595;


            Console.Write("Bensaa kuluu " + Math.Round(litrat, 2) + " litraa, kustannus " + Math.Round(kustannus, 2) + " euroa.");

        }
    }
}
