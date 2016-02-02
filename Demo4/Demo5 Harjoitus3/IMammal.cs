using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5_Harjoitus3
{
    abstract class IMammal
    {
        public int age { get; set; }

        abstract public void Move(int amount);
        
    }
}

