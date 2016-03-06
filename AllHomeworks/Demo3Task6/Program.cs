using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Task6
{
    /// <summary>
    /// Tehtävä 6 home Kotitehtävä
    ///Valitse jokin reaalimaailman asia ja suunnittele siitä luokkarakenne UML-editorilla.Tee uusi projekti.Ohjelmoi suunnittelema luokkasi sekä käytä tekemääsi luokkaa edellisten tehtävien mukaisesti.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SecureKeyPad pad = new SecureKeyPad();
            
            do
            {
                pad.KeyPadOn();
                Console.WriteLine("Welcome to use Securekeycodepad" + "\nPlease enter password code.");
                try {
                    pad.usercode = int.Parse(Console.ReadLine());
                    }
                catch
                {
                    Console.WriteLine("\nInput numbers only");
                }

                pad.CheckCode();

            } while (pad.keypadon == true);
            Console.WriteLine("Have a good day sir!");
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();   
        }
    }
}
