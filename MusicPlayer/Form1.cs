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
        ArrayList songNames;
        int currentSongPointer;
        public Form1()
        {
            InitializeComponent();
            songNames = new ArrayList();
            songNames.Add("I Love It");
            songNames.Add("Never Gonna Give You Up");
            songNames.Add("Despacito");
            currentSongPointer = 0;
        }

        


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            PlayCommand pc = new PlayCommand(songNames[currentSongPointer].ToString());
            pc.execute();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
