using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Task6
{
    class SecureKeyPad
    {
        public int usercode = 0;

        private int passcode = 4521;
        
        public int PassCode
        {
            get
            {
                return passcode;
            }
            set
            {
                if (value == passcode)
                {
                    passcode = value;
                    Console.WriteLine("Correct Code, Welcome!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong Code, Try again!");
                }
            }
        }
    }
}
