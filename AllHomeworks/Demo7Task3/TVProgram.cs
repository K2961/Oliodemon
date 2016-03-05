using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7Task3
{
    [Serializable]
    class TVProgram
    {
        public string name { get; set; }
        public string channel { get; set; }
        public string pstart { get; set; }
        public string pend { get; set; }
        public string pinfo { get; set; }

        public override string ToString()
        {
            return "\nProgram: " + name + "\nChannel: " + channel + "\nStarts at: " + pstart + "  UTC+2 time." + " Ends at: " +  pend + "\nProgram description: " + pinfo;
        }
    }
}
