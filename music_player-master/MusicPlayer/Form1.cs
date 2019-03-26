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
        int slot;
        public static AxWindowsMediaPlayer player;
        CommandInvoker cmdControl;

        public Form1()
        {
            InitializeComponent();
            songs = new ArrayList();
            currentSongPointer = -1;
            player = new AxWindowsMediaPlayer();        //initializing the player that will play our music
            player.CreateControl();     //allows us to control the player, like setting the URL
            cmdControl = new CommandInvoker();
            slot = 0;               //slot to be used when setting commands
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            cmdControl.playbtnPushed(currentSongPointer);
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
            //implement today
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //implement today
        }
    }
}
