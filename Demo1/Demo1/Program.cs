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
            Harjoitus1();

            Console.ReadLine();
        }
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
    }
}
