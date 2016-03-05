using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Task1
{
    class Dice
    {
        public int dicethrow { get; set; }
        private static readonly Random staticRand = new Random();

        public static int Throw()
        {
            return staticRand.Next(6) + 1;
        }
    }
}
