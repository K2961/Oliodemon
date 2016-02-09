using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_Task5
{
    /// <summary>
    /// Tehtävä 5 home Kotitehtävä
    ///Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja.Tee uusi projekti.Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon(esim. 5 opiskelijaa). Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta.
    /// </summary>
    class Student
    {
        public string Htun { get; set; }
        public string Optun { get; set; }
        public string Nimi { get; set; }
        public string Snimi { get; set; }
        public string StartDate { get; set; }

        public void PrintData()
        {
            Console.WriteLine("\n*********************************");
            Console.WriteLine("\n* Nimi : " + Nimi + " " + Snimi);
            Console.WriteLine("\n- Henkilötunnus: " + Htun);
            Console.WriteLine("\n- Oppiskelijatunnus: " + Optun);
            Console.WriteLine("\n- Opinnot alkoivat: " + StartDate);
            Console.WriteLine("\n*********************************");
        }

        public Student(string nimi, string snimi, string htun, string optun, string startdate)
        {
            this.Nimi = nimi;
            this.Snimi = snimi;
            this.Htun = htun;
            this.Optun = optun;
            this.StartDate = startdate;

        }
    }
}
