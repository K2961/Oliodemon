using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Task6
{
    /// <summary>
    /// This is a keypad used for doorlock opening and it's passcode is only visible for this class using private property.
    /// </summary>
    class SecureKeyPad
    {
        public int usercode {get; set;}
        private int passcode = 4521;
        public bool keypadon { get; set; }
        
        public int PassCode
        {
            get
            {
                return passcode;
            }
            set
            {
                if (usercode == passcode)
                {
                    Console.WriteLine("\nCorrect Code Dude, Welcome!");
                    Console.ReadLine();
                    KeyPadOff();
 
                }
                else
                {
                    Console.WriteLine("\nWrong Code, Try again!" + "\n");
                }
            }
        }
        public void KeyPadOn()
        {
            keypadon = true;
        }
        public void KeyPadOff()
        {
            keypadon = false;
        }
        public void CheckCode()
        {
            PassCode = usercode;
        }
    }
}
