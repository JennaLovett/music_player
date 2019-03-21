using System;
using System.Windows.Forms;
using System.Collections;
using MusicPlayer.Command;
using AxWMPLib;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        ArrayList songs;
        int currentSongPointer;
        public static AxWindowsMediaPlayer player;

        public Form1()
        {
            InitializeComponent();
            songs = new ArrayList();
            currentSongPointer = 0;
            player = new AxWindowsMediaPlayer();
            player.CreateControl();     //allows us to control the player, like setting the URL
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

        private void importBtn_Click(object sender, EventArgs e)    //importing song file path
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //opens file viewer

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.filePath.Text = openFileDialog1.FileName;      //places file path in textbox
                player.URL = this.filePath.Text;                    //sets URL (file path) for the player
                songs.Add(new Song(this.filePath.Text));            //creates new song object from this file path and adds it to list of songs
            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            //player.Ctlcontrols.pause();
            PauseCommand pac = new PauseCommand((Song)songs[currentSongPointer]);  //creates a new PlayCommand object and passes current song to it
            pac.execute();       //calls the PlayCommand execute() function, which calls the Song play() function
        }
    }
}
