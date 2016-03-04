using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6Task2
{
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public List<Song> Songs;


        public CD()
        {
            Songs = new List<Song>();
        }
        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public override string ToString()
        {
            string data = "CD DATA:";
            data += "\n-Artist: " + Artist + "\n-Name: " + Name;
            data += "\nSongs:";

            foreach (Song song in Songs)
            {
                if (song != null) data += "\n--" + song.ToString();
            }
            return data;
        }
    }
}
