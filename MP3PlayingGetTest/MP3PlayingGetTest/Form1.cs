using System;
using System.Diagnostics;
using System.Windows.Forms;

using Shell32;

namespace MP3PlayingGetTest
{
    public partial class Form1 : Form
    {
        private MP3Info mp3;

        public Form1()
        {
            InitializeComponent();
            mp3 = new MP3Info();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (mp3.GetMP3Info() == true)
            {
                Track.Text = mp3.trackName;
                ArtistName.Text = mp3.Artist;
                AlbumName.Text = mp3.Album;
                TimeText.Text = mp3.time;

                Console.WriteLine("Open Success.");
            }
            else
            {
                Track.Text      = null;
                ArtistName.Text = null;
                AlbumName.Text  = null;
                TimeText.Text   = null;

                Console.WriteLine("Open Failure.");
            }
        }
    }
}
