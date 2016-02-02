using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5_Harjoitus3
{
    class Human : IMammal
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Name { get; set;}

        public override void Move(int amount)
        {
            Console.WriteLine("Human is moving " + amount + " steps");
        }

        public void GetOlder()
        {
            age++;
            Console.WriteLine("Human is " + age + " years old");
        }
    }
}
