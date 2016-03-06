using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Task7
{
    /// <summary>
    /// Tehtävä 7 home Kotitehtävä
    ///Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Jyvaskyla city";
            person.LastName = "Hallitus";
            person.Address = "torikatu 1";
            //person.Age = "30";
            Console.WriteLine(person.ToString());

            Authoritative authoritative = new Authoritative();
            authoritative.Name = "Teppo";
            authoritative.LastName = "Oja";
            authoritative.Address = "piippukatu 2";
            authoritative.Age = "40";
            authoritative.OfficerID = "X345";

            Console.WriteLine(authoritative.ToString());

            Citizen citizen = new Citizen();
            citizen.Name = "Teppo";
            citizen.LastName = "Kapuli";
            citizen.Address = "Jokivarsi 4";
            citizen.Age = "25";
            citizen.PersonalID = "011188-178C";
            Console.WriteLine(citizen.ToString());

            Console.ReadLine();
        }
    }
}
