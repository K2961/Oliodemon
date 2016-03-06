using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Task7
{
    class Authoritative : Person
    {
        public string OfficerID { get; set; }

        public Authoritative()
        {

        }

        public Authoritative(string name, string lastname, string officerid)
            : base(name,lastname)
        {
            OfficerID = officerid;
        }

        public string ToString()
        {
            return base.ToString() + "\nArmy officer ID:  " + OfficerID + "\n";
        }
    }
}
