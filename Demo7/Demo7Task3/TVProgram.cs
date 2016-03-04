using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7Task3
{
    class TVProgram
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string StartingTime { get; set; }
        public string EndingTime { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "Program name:" + Name + Channel + StartingTime + EndingTime + Description;
        }
    }
}
