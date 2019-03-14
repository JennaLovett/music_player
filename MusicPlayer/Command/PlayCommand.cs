using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Command
{
    class PlayCommand : Command
    {
        string song;

        public PlayCommand(string current) 
        {
            song = current;
        }

        public void execute()
        {
            Console.WriteLine("Playing " + song);
        }
    }
}
