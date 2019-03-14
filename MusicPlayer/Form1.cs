using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MusicPlayer.Command;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        string currentSongName;
        ArrayList songs;
        int currentSongPointer;
        public Form1()
        {
            InitializeComponent();
            songs = new ArrayList();
            Song song1 = new Song("I Love It");
            Song song2 = new Song("I Love It");
            Song song3 = new Song("I Love It");
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            currentSongPointer = 0;
        }

        


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            PlayCommand pc = new PlayCommand((Song)songs[currentSongPointer]);  //creates a new PlayCommand object and passes current song to it
            pc.execute();       //calls the PlayCommand execute() function, which calls the Song play() function
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
