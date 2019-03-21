using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Command
{
    class Song
    {
        private string filePath;
        private static AxWindowsMediaPlayer player1;

        public Song(string file)
        {
            this.filePath = file;
        }

        public void play()
        {
            Form1.player.URL = this.filePath;
            Form1.player.Ctlcontrols.play();
        }

        public void pause()
        {
            Form1.player.Ctlcontrols.pause();
        }

        public string getFilePath ()
        {
            return this.filePath;
        }
    }
}
