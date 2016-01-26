using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somebody = new Person("John", "Unknown");
            somebody.PersonMethod();
            Console.WriteLine();
        }
    }
}
