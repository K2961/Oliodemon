using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4_kotitehtävä
{
    class Radio
    {
        private int volume;
        private int power;

        public int Power
        {
            get { return power; }
            set { }
        }
        public int Volume
        {
            get { return volume; }
            set {
                    if (value < 0)
                    {
                        volume = 0;
                    }
                    else if (value > 9)
                    {
                        volume = 9;
                    }
                    else volume = value;
                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
