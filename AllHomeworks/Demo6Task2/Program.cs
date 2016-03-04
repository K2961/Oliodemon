using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6Task2
{
    class Program
    {

        static void Main(string[] args)
        {

            CD cd = new CD();
            cd.Artist = "Nightwish";
            cd.Name = "Endless Forms Most Beautiful";
            cd.AddSong(new Song { Name = "Shudder Before the Beautiful", LengthInSeconds = 389 });
            cd.AddSong(new Song { Name = "Weak Fantasy", LengthInSeconds = 323 });
            cd.AddSong(new Song { Name = "Elan", LengthInSeconds = 285 });
            cd.AddSong(new Song { Name = "Yours Is an Empty Hope", LengthInSeconds = 334 });
            cd.AddSong(new Song { Name = "Our Decades in the Sun", LengthInSeconds = 397 });
            cd.AddSong(new Song { Name = "My Walden", LengthInSeconds = 278 });
            cd.AddSong(new Song { Name = "Endless Forms Most Beautiful", LengthInSeconds = 307 });
            cd.AddSong(new Song { Name = "Edema Ruh", LengthInSeconds = 315 });
            cd.AddSong(new Song { Name = "Alpenglow", LengthInSeconds = 285 });
            cd.AddSong(new Song { Name = "The Eyes of Sharbat Gula", LengthInSeconds = 363 });
            cd.AddSong(new Song { Name = "The Greatest Show on Earth", LengthInSeconds = 1440 });

            Console.WriteLine(cd.ToString());
            Console.WriteLine();

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
