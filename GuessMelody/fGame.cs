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
    public partial class fGame : Form
    {
        Random rnd = new Random();
        fMessage fm = new fMessage();
        fWin fw = new fWin();
        int musicDuration = Victorina.musicDuration;

        public fGame()
        {
            InitializeComponent();
        }

        void MakeMusic()
        {
            if (Victorina.list.Count == 0) EndGame();
            else
            {
                musicDuration = Victorina.musicDuration;
                int n = rnd.Next(0, Victorina.list.Count);
                WMP.URL = Victorina.list[n];
                Victorina.answer = System.IO.Path.GetFileNameWithoutExtension(WMP.URL);
                // WMP.Ctlcontrols.play();
                Victorina.list.RemoveAt(n);
                lblMelodyCounter.Text = Victorina.list.Count.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MakeMusic();
        }

        private void fGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            lblMelodyCounter.Text = Victorina.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Victorina.gameDuration;
            lblMusicDuration.Text = musicDuration.ToString();
        }

        void EndGame()
        {
            timer1.Stop();
            WMP.Ctlcontrols.stop();
            if (int.Parse(lblCounter1.Text) > int.Parse(lblCounter2.Text))
            {
                fw.lblWinnersName.Text = "Player 1 win";
                fw.lblWinnersCounter.Text = "Points -> " + lblCounter1.Text;
            }else if (int.Parse(lblCounter1.Text) < int.Parse(lblCounter2.Text))
            {
                fw.lblWinnersName.Text = "Player 2 win";
                fw.lblWinnersCounter.Text = "Points -> " + lblCounter2.Text;
            }
            else
            {
                fw.lblWinnersName.Text = "No one win";
                fw.lblWinnersCounter.Text = "Points -> " + lblCounter1.Text + " - " + lblCounter2.Text;
            }
            fw.ShowDialog();
            this.Close();
            lblCounter1.Text = "0";
            lblCounter2.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            musicDuration--;
            lblMusicDuration.Text = musicDuration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (musicDuration == 0) MakeMusic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GamePause();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GameContinue();
        }

        void GamePause()
        {
            timer1.Stop();
            WMP.Ctlcontrols.pause();
        }

        void GameContinue()
        {
            timer1.Start();
            WMP.Ctlcontrols.play();
        }

        private void fGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                GamePause();
                fm.lblMessage.Text = "Player 1";
                SoundPlayer sp = new SoundPlayer(@"Resources\Stop_Tone.wav");
                sp.PlaySync();
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter1.Text = Convert.ToString(Convert.ToInt32(lblCounter1.Text) + 1);
                    MakeMusic();
                }
                GameContinue();
            }

            if (e.KeyData == Keys.L)
            {
                GamePause();
                fm.lblMessage.Text = "Player 2";
                SoundPlayer sp = new SoundPlayer(@"Resources\Stop_Tone.wav");
                sp.PlaySync();
                if (fm.ShowDialog() == DialogResult.Yes)
                {
                    lblCounter2.Text = Convert.ToString(Convert.ToInt32(lblCounter2.Text) + 1);
                    MakeMusic();
                }
                GameContinue();
            }
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Victorina.randomStart)
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = rnd.Next(0, (int)WMP.currentMedia.duration / 2);
        }

        private void lblCounter1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) + 1);
            if (e.Button == MouseButtons.Right)
                (sender as Label).Text = Convert.ToString(Convert.ToInt32((sender as Label).Text) - 1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
