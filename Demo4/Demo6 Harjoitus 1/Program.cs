using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Demo6_Harjoitus_1
{
    class Program
    {
        static private Random rand = new Random();

        static string RandomString(int length)
        {
            string ret = "";
            for (int i = 0; i < length; i++)
            {
                ret += (char)rand.Next('A', 'Z');
            }
            return ret;
        }
        static void Main(string[] args)
        {
            // Harjoitus 1:

            /*List<Person> persons = new List<Person>();

            persons.Add(new Person("12345-553", "Pekka", "Pouta", 39, 78, 183));
            persons.Add(new Person("6465464-553", "Mari", "Seppänen", 22, 112, 163));
            persons.Add(new Person("878989-553", "Kalervo", "Hirvi", 45, 80, 190));
            persons.Add(new Person("343534-553", "Aapo", "Aurinko", 25, 45, 200));
            persons.Add(new Person("486468-553", "Seppo", "Salminen", 85, 36, 186));
            persons.Add(new Person("54445-553", "Kata", "Kekkilä", 36, 55, 170));
            persons.Add(new Person("75435-553", "Keijo", "Kivi", 32, 98, 162));
            persons.Add(new Person("365365-553", "Maikki", "Kanta", 31, 82, 164));

            persons.Sort((x, y) => x.Age.CompareTo(y.Age));

            foreach (Person somebody in persons)
            {
                Console.Write(somebody.ToString());
            }
            // Try to find person.. 

            string SSN = "6465464-553";
            Person found = persons.Find(x => x.SSN == SSN);

            if (found != null)
            {
                Console.WriteLine("\nPerson with SSN " + SSN + " FOUND!");
            }
            else
            {
                Console.WriteLine("\nPerson not found");
            }
            */

            // Harjoitus +4

            Random r = new Random();

            List<Person> persons = new List<Person>();

            const int personCount = 10;

            for (int i = 0; i < personCount; i++)
            {
                Person p = new Person(RandomString(12), RandomString(4), RandomString(8), rand.Next(1,100), rand.Next(30,140), rand.Next(100,220));
                persons.Add(p);
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();
            foreach(Person somebody in persons)
            {
                Console.Write(somebody.ToString());
            }

            watch.Stop();
            Console.WriteLine("\nAdding persons took " + watch.ElapsedMilliseconds + "ms");

            r.Next();

            for (int i = 0; i < 1000; i++)
            {
                string nameToFind = RandomString(4);
                Person p = persons.Find(x => x.FirstName == nameToFind);
                if (p != null)
                {
                    Console.WriteLine("Found person with firstname " + nameToFind + " : " + p.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
