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
            if (currentSongPointer <= 0)
            {
                //do nothing
            }
            else
            {
                currentSongPointer--;
                cmdControl.playbtnPushed(currentSongPointer);
            }

        }

        private void importBtn_Click(object sender, EventArgs e)    //importing song file path
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //opens file viewer
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.filePath.Text = openFileDialog1.FileName;
                //Make an array to collect all FileNames to set to add to songs

                String[] s = openFileDialog1.FileNames;

                for (int i = 0; i < s.Length; i++)
                {
                    player.URL = this.filePath.Text;
                    currentSongPointer++;
                    songs.Add(new Song(s[i]));
                    cmdControl.setCommand(slot, new PlayCommand((Song)songs[currentSongPointer]), new PauseCommand((Song)songs[currentSongPointer]));
                    slot++;
                }

                /*player.URL = this.filePath.Text;
                songs.Add(new Song(this.filePath.Text));
                currentSongPointer++;
                cmdControl.setCommand(slot, new PlayCommand((Song)songs[currentSongPointer]), new PauseCommand((Song)songs[currentSongPointer]));
                slot++;
                */
            }

        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            cmdControl.pausebtnPushed(currentSongPointer);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentSongPointer >= songs.Count)
            {
                //do nothing
            }
            else
            {
                currentSongPointer++;
                cmdControl.playbtnPushed(currentSongPointer);
            }

        }
    }
}
