using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Command
{
    class Song
    {
        private string songName;

        public Song(string name)
        {
            this.songName = name;
        }

        public string play()
        {
            return songName;
        }
    }
}
