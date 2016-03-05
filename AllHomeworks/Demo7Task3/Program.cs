using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Demo7Task3
{
    class Program
    {
        //private static object formatter;

        static void Main(string[] args)
        {
            List<TVProgram> programs = new List<TVProgram>();

            programs.Add(new TVProgram { name = "Thorin chosen people.", channel = "Nelonen", pstart = "21:00", pend = "01.15", pinfo = " Document about life of Vikings. The victorious battle medhods trought the history." });
            programs.Add(new TVProgram { name = "Car fever.", channel = "MTV3 MAX", pstart = "18:00", pend = "20:00", pinfo = "This program gives you answers for everything about cars." });

            IFormatter formatter = new BinaryFormatter();
            // create a file for persons
            Stream writeMultipleStream = new FileStream("AllTVPrograms.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            // write persons array to disk, note: uses formatter in previous code
            formatter.Serialize(writeMultipleStream, programs);
            // close file
            writeMultipleStream.Close();

            // create stream for reading persons
            Stream openStream = new FileStream("AllTVPrograms.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            // create a list and read persons into it from disk
            List<TVProgram> readPrograms = (List<TVProgram>)formatter.Deserialize(openStream);
            // close stream
            openStream.Close();

            foreach (TVProgram program in programs)
            {
                Console.WriteLine(program.ToString());
            }
            Console.ReadLine();
        }
    }
}
