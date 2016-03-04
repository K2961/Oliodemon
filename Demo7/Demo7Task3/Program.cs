using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Tehtävä 3 - oliot levyllehome Kotitehtävä
/// Tee ohjelma, jossa voidaan käsitellä TV-ohjelmia.TV-ohjelman tietoina tulee käsitellä: ohjelman nimi, kanava (jolta ohjelma tulee), alku- ja loppuaika sekä pienimuotoinen infoteksti ohjelmasta.Luo pääohjelmassa muutamia TV-ohjelmaolioita (tiedot voit alustaa suoraan koodista, ei tarvitse kysyä käyttäjältä) ja tallenna ne levylle.Mieti käytätkö jotain tietorakennetta apunasi. Toteuta ohjelmaan myös tiedostonlukeminen ja tulosta TV-oliot näkyville. 
/// 
/// </summary>
namespace Demo7Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TVProgram prog1 = new TVProgram();

            prog1.Name = "Dancing with devils.";
            prog1.Channel = "Channel 4";
            prog1.StartingTime = "21:00";
            prog1.EndingTime = "0:00";
            prog1.Description = "This Anime movie is telling about young girl's life in middle of schooldrama";

            prog1.ToString();
            Console.ReadLine();
        }
    }
}
