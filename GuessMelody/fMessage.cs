using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessMelody
{
    public partial class fMessage : Form
    {
        int timeAnswer;

        public fMessage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeAnswer--;
            lblTimer.Text = timeAnswer.ToString();
            if(timeAnswer == 0)
            {
                SoundPlayer sp = new SoundPlayer(@"Resources\Stop_Tone.wav");
                timer1.Stop();
                sp.PlaySync();
            }
        }

        private void fMessage_Load(object sender, EventArgs e)
        {
            timeAnswer = Victorina.musicDuration;
            timer1.Start();
        }

        private void lblShowAnswer_Click(object sender, EventArgs e)
        {
            // var mp3file = TagLib.File.Create(Victorina.answer);

            // lblShowAnswer.Text = mp3file.Tag.FirstAlbumArtist + " - " + mp3file.Tag.Title;

            lblShowAnswer.Text = Victorina.answer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblShowAnswer.Text = "Show answer";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblShowAnswer.Text = "Show answer";
        }

        private void fMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
