using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
namespace Demo7Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter integerFile = new StreamWriter(mydocpath + @"\TestIntegers.txt"))
            {
                using (StreamWriter doubleFile = new StreamWriter(mydocpath + @"\TestDoubles.txt"))
                {
                    do
                    {
                        Console.Write("Give a number (enter or not a number ends) : ");
                        line = Console.ReadLine();
                        if (line.Length != 0)
                        {
                            try
                            {
                                int number = int.Parse(line);
                                integerFile.WriteLine(line);
                            }
                            catch (FormatException)
                            {
                                try
                                {
                                    double number = double.Parse(line);
                                    doubleFile.WriteLine(line);
                                }
                                catch (FormatException)
                                {
                                    break;
                                }
                            }
                        }
                    } while (line.Length != 0);
                }
            }
            
            try
            {
                string text1 = File.ReadAllText(mydocpath + @"\TestIntegers.txt");
                Console.WriteLine("Contents of TestIntegers.txt:\n" + text1);
                string text2 = File.ReadAllText(mydocpath + @"\TestDoubles.txt");
                Console.WriteLine("Contents of TestDoubles.txt:\n" + text2);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
