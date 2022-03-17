using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Music
{
    class Album
    {
        public string Name { get; set; }
        public List<Song> Songs {get;}
        public Album(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }
    }
}
