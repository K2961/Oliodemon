using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_Task5
{
    class Program
    {

        static void Main(string[] args)
        {
            Student stud = new Student("Kake", "Kallonen", "Q011253-999", "QQ321", "12.5.1989");
            /*
            stud.Nimi = "Kake";
            stud.Snimi = "Kallonen";
            stud.Htun = "Q011253-999";
            stud.Optun = "QQ321";
            stud.StartDate = "12.5.1989";
            */

            Student stud1 = new Student("Malla", "Kekkonen", "P121092-666", "LA999", "6.6.2006");

            Student stud2 = new Student("Mikko", "Mallikas", "K154656-546", "L4654", "6.6.2002");
            Student stud3 = new Student("Mekko", "Nalli", "Y454655-456", "IP646", "6.6.2008");
            Student stud4 = new Student("Ikko", "Ralli", "U365464-546", "SA466", "6.6.2001");

            stud.PrintData();
            stud1.PrintData();
            stud2.PrintData();
            stud3.PrintData();
            stud4.PrintData();

            Console.ReadLine();
        }
    }
}
