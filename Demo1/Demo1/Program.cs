﻿using System;
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
            Harjoitus15();

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
        /// <summary>
        ///  Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
        /// Algoritmi
        /// 4:llä jaolliset on, paitsi täydet vuosisadat.Kuitenkin 400:lla jaolliset vuosisadat ovat
        /// Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
        /// </summary>
        static void Harjoitus7()
        {
            Console.Write("Anna vuosi muodossa vvvv: ");

            int vuosi = int.Parse(Console.ReadLine());

            if ((vuosi % 4 == 0 && vuosi % 100 != 0) || vuosi % 400 == 0)
            {
                Console.Write("Vuosi on karkausvuosi.");
            }
            else Console.Write("Vuosi ei ole karkausvuosi!");
        }

        /// <summary>
        /// Tehtävä 8
        /// Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
        /// Esimerkkitoiminta:
        /// Anna Luku > 5 [Enter]
        /// Anna Luku > 15 [Enter]
        /// Anna Luku > 7 [Enter]
        /// Suurin luku on 15
        /// </summary>
        static void Harjoitus8()
        {
            int a;

            Console.Write("Tämä ohjelma vertaa kolmea lukua ja ilmoittaa suurimman luvun\n");

            Console.Write("Anna ensimmäinen luku: ");
            int Luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku: ");
            int Luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna kolmas luku: ");
            int Luku3 = int.Parse(Console.ReadLine());

            if ((Luku1 > Luku2) && (Luku1 > Luku3))
            {
                a = Luku1;
            }

            else if ((Luku2 > Luku1) && (Luku2 > Luku3))
            {
                a = Luku2;
            }
            else
            {
                a = Luku3;
            }

            Console.Write("Suurin luku on: " + a);
        }

        /// <summary>
        /// Tehtävä 9
        /// Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
        /// Esimerkkitoiminta:
        /// Anna Luku > 10 [Enter]
        /// Anna Luku > 20 [Enter]
        /// Anna Luku > 30 [Enter]
        /// Anna Luku > 0 [Enter]
        /// Lukujen summa on 60
        /// </summary>
        static void Harjoitus9()
        {
            int Toisto = 1;
            int Luku = 0;
            int Summa = 0;

            Console.Write("Lukujen yhteenlasku.\n");
            Console.Write("Jos haluat lopettaa anna numeroksi nolla '0'\n");

            while (Toisto != 0)
            {
                Console.Write("\nAnna luku: ");

                Luku = int.Parse(Console.ReadLine());

                if (Luku == 0)
                {
                    Toisto = 0;
                    Console.Write("\nHalusit poistua vai? Hyvästi!");
                }
                else
                {
                    Summa += Luku;

                    Console.Write("Lukujen summa on: " + Summa); 
                }
            }
        }

        /// <summary>
        /// Tehtävä 10
        /// Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1, 2, 33, 44, 55, 68, 77, 96, 100].
        /// Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
        /// </summary>
        static void Harjoitus10()
        {
            /* int[] arvot = { 1, 2, 33, 44, 55, 68, 77, 96, 100};
             foreach (int arvo in arvot)
             if (arvo % 2 == 0)
                 {
                     Console.Write(" HEP: " + arvo);
                 }
             */

            int[] arvot = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < 9; i++)
            {
                int arvo = arvot[i];
                if (arvo % 2 == 0)
                {
                    Console.Write(" HEP: " + arvo);
                }
            }
        }

        /// <summary>
        /// Tehtävä 1
        /// Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
        /// *
        /// **
        /// ***
        /// ****
        /// *****
        /// Käyttäjä antaa syötteenä tähtirivien lukumäärän.Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.
        /// Esimerkkitoiminta:
        /// Anna Luku > 3 [Enter]
        /// *
        /// **
        /// ***
        /// </summary>
        static void Harjoitus11()
        {
            Console.Write("Anna luku:  ");

            int maara;

            maara = int.Parse(Console.ReadLine());

            for (int ylos = 0; ylos < maara; ylos++)
            {
                for (int sivul = 0; sivul <= ylos; sivul++)
                
                    Console.Write("*");
                    Console.WriteLine();
                
            }

        }

        /// <summary>
        /// Tehtävä 12
        /// Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua.Luvut tulee sijoittaa taulukkoon.Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
        /// Esimerkkitoiminta:
        /// Anna Luku > 1 [Enter]
        /// Anna Luku > 2 [Enter]
        /// Luku > 3 [Enter]
        /// Anna Luku > 4 [Enter]
        /// Anna Luku > 5 [Enter]
        /// Luvut ovat 5,4,3,2,1
        /// </summary>
        static void Harjoitus12()
        {
            Console.Write("Anna 5 Lukua\n");

            string []luvut = new string[6];
            string []kysy = { "Anna luku1", "Anna luku2", "Anna luku3", "Anna luku4", "Anna luku5" };
            string kysymys;
            
            for (int i = 0; i < 5; i++)
            {
                kysymys = kysy[i];
                Console.WriteLine("\n" + kysymys);
                luvut[i] = Console.ReadLine();
            }

            Console.Write("\nLuvut ovat: ");

            for (int x = 5; x != -1; x--)
            {
                Console.Write(luvut[x] + " ");
            }
        }

        /// <summary>
        /// Tehtävä 13
        /// Mäkihypyssä käytetään viittä arvostelutuomaria.Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.
        /// Esimerkkitoiminta:
        /// Anna pisteet > 18 [Enter]
        /// Anna pisteet > 15 [Enter]
        /// Anna pisteet > 20 [Enter]
        /// Anna pisteet > 19 [Enter]
        /// Anna pisteet > 17 [Enter]
        /// Kokonaispisteet ovat 54
        /// </summary>
        static void Harjoitus13()
        {
            string[] kysy = { "Anna tyylipisteet 1: ", "Anna tyylipisteet 2: ", "Anna tyylipisteet 3: ", "Anna tyylipisteet 4: ", "Anna tyylipisteet 5: " };

            int[] tyylipisteet = new int[5];

            Console.Write("Olet arvostelutuomari mäkihypyssä.\n");

            Console.WriteLine("\nHyppy suoritettu! ");


            for (int i = 0; i < 5; i++)
            {
                string kysymys = kysy[i];
                Console.WriteLine("\n" + kysymys);
                tyylipisteet[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(tyylipisteet);

            int summa = tyylipisteet[1] + tyylipisteet[2] + tyylipisteet[3];
            Console.WriteLine("\n" + "Tyylipisteiden summa on: " + summa);
        }

        /// <summary>
        ///Tehtävä 14
        ///Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ///ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). Tulosta ///arvosanajakauma käyttäen tähtimerkkejä seuraavasti:
        ///Arvosanajakauma:
        ///0:
        ///1:****
        ///2:**
        ///3:******
        ///4:*****
        ///5:**
        ///Esimerkkitoiminta:
        ///Anna arvosana > 5 [Enter]
        ///Anna arvosana > 5 [Enter]
        ///Anna arvosana > 4 [Enter]
        ///Anna arvosana > 3 [Enter]
        ///Anna arvosana > 2 [Enter]
        ///Anna arvosana > 1 [Enter]
        ///Anna arvosana > 0 [Enter]
        ///Anna arvosana > 0 [Enter]
        ///Arvosanat:
        ///0:**
        ///1:*
        ///2:*
        ///3:*
        ///4:*
        ///5:**
        /// </summary>
        static void Harjoitus14()
        {
            Console.WriteLine("Anna arvosana 0-5 Ohjelmointi opintojaksosta");
            Console.WriteLine("Lopeta arvosanojen antaminen 'L' kirjaimella!");

            int[] arvosanat = new int[6];
            int numero;
            bool tulos;

            do
            {
                Console.WriteLine("Anna arvosana: ");
                string annettu = Console.ReadLine();
                tulos = Int32.TryParse(annettu, out numero);
                if (tulos)
                {
                    switch (numero)
                    {
                        case 0:
                            arvosanat[0]++;
                            break;
                        case 1:
                            arvosanat[1]++;
                            break;
                        case 2:
                            arvosanat[2]++;
                            break;
                        case 3:
                            arvosanat[3]++;
                            break;
                        case 4:
                            arvosanat[4]++;
                            break;
                        case 5:
                            arvosanat[5]++;
                            break;
                        case 'L':
                            break;
                    }
                }

            } while (tulos);
            Console.WriteLine("Arvosanat: ");

            for (int i = 0; i < arvosanat.Length; i++)
            {
                Console.Write(i + ":");
                for (int x = 0; x < arvosanat[i]; x++)
       
                    Console.Write("*");
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Tehtävä 15
        ///Tee ohjelma, joka tulostaa seuraavanlaisen kuvion.Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.
        ///Anna Luku > 7 [Enter]
        ///         *
        ///        ***
        ///       *****
        ///      *******
        ///     *********
        ///         *
        ///         *
        /// </summary>
        static void Harjoitus15()
        {
            int size;

            Console.WriteLine(" Welcome to the tree generator!");

            Console.WriteLine("\nGive the size of the tree as number: ");
            string given = Console.ReadLine();
            bool givenans = int.TryParse(given, out size);

            int tree = size - 2;
            int bottom = size - tree;

            if (givenans)
            {
                if (size < 4)
                {
                    Console.WriteLine("That is not healthy tree!" + "\nMust be bigger size");
                    Console.ReadLine();
                    return;
                }
                else if (size > 25)
                {
                    Console.WriteLine("Too Big number!");
                    Console.ReadLine();
                    return;
                }

                for (int i = 0; i < tree; i++)
                {
                    int emptyspacesLength = tree - i;
                    for (int emptyspace = 0; emptyspace <= emptyspacesLength; emptyspace++)
                        {
                            Console.Write(" ");
                        }

                for (int stars = 0; stars <= i * 2; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                }
                for (int i = 0; i < bottom; i++)
                {
                    for (int emptyspace = 0; emptyspace <= tree; emptyspace++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }
            else
            {
                Console.WriteLine("You don't give a number!");
            }
            Console.ReadLine();
        }

        /// <summary>
        ///Tehtävä 16
        ///Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Tämän jälkeen ///ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee ///antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. ///Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. ///Tulosta lopuksi arvausten määrä näytölle.
        ///Esimerkkitoiminta:
        ///Arvaa luku > 50 [Enter]
        ///Luku on suurempi
        ///Arvaa luku > 75 [Enter]
        ///Luku on pienempi
        ///Arvaa luku > 66 [Enter]
        ///Hienoa, arvasit luvun 3 kerralla.
        /// </summary>
        static void Harjoitus16()
        {

        }
    }
}
