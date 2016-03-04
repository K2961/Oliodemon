using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6Task2
{
    class Song
    {
        public string Name { get; set; }
        public int LengthInSeconds { get; set; }
        public override string ToString()
        {
            int min = LengthInSeconds / 60;
            int sec = LengthInSeconds % 60;
            string duration = min.ToString("00") + ":" + sec.ToString("00");
            return "- Name: " + Name + " - " + duration;
        }
    }
}
