using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Command
{
    class PlayCommand : Command
    {
        Song song;
        string songName;

        public PlayCommand(Song song) 
        {
            this.song = song;
        }

        public void execute()
        {
            songName = song.play();     //call's the song play() method, which returns the name of the song
            Console.WriteLine(songName);
        }
    }
}
