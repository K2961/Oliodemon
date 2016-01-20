using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Kiuas
    {
        public Kiuas(string Virtakytkin)
        {
            this.Virtakytkin = Virtakytkin;

        }
        public string OnVOff
        {
            get { return Virtakytkin; }
        }
        public string Virtakytkin;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas Suomi = new Kiuas();
            Console.WriteLine("Kiuas on: " + Suomi.Virtakytkin);
            Console.ReadLine();
        }
    }
}
