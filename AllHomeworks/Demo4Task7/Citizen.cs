using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Task7
{
    class Citizen : Person
    {
        public string PersonalID { get; set; }

        public Citizen()
        {

        }

        public Citizen(string name, string lastname, string personalid)
            : base(name,lastname)
        {
            PersonalID = personalid;
        }

        public string ToString()
        {
            return base.ToString() + "\nPersonal identification number: " + PersonalID + "\n";
        }
    }
}
