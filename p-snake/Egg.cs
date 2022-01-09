using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_snake
{
    public partial class Egg : Form
    {

        bool goLeft, goRight;

        int speed = 8;
        int score = 0;
        int missed = 0;

        Random randX = new Random();
        Random randY = new Random();

        PictureBox splash = new PictureBox();



        public Egg()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Saved: " + score;
            txtMiss.Text = "Missed: " + missed;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= 12;
                player.Image = Properties.Resources.chicken_normal2;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 12;
                player.Image = Properties.Resources.chicken_normal;
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "eggs")
                {

                    x.Top += speed;
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randY.Next(80, 500) * -1;
                        x.Left = randX.Next(15, this.ClientSize.Width - x.Width);
                        score += 1;
                    }else if (x.Top + x.Height > this.ClientSize.Height)
                    {

                        splash.Image = Properties.Resources.splash;
                        splash.Location = x.Location;
                        splash.Height = 60;
                        splash.Width = 60;
                        splash.BackColor = Color.Transparent;

                        this.Controls.Add(splash);

                        x.Top = randY.Next(80, 500) * -1;
                        x.Left = randX.Next(15, this.ClientSize.Width - x.Width);
                        missed += 1;
                        player.Image = Properties.Resources.chicken_hurt;

                    }         
                }
            }

            if (score > 10)
            {
                speed = 12;
            }
            
            if (missed >= 5)
            {
                GameTimer.Stop();
                txtMiss.Text = "Missed: " + missed;
                if (Event.FormClosingCheck("Game Over!" + Environment.NewLine + "We've lost good Eggs!" + Environment.NewLine + "Click ok to back to menu"
                    + Environment.NewLine + "Click cancel to restart"))
                {
                    this.Close();
                    //儲存資料至DB Function
                    Event.SaveScoreToDB(score, 0, TABLENAME.TEGG);
                    Event.FormClosed();
                   
                }
                else
                {
                    RestartGame();
                }
                
            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                goRight = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                goLeft = false;
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void Egg_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Event.FormClosingCheck(sender, e);
        }

        private void Egg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Event.FormClosed();
        }

        private void RestartGame()
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top = randY.Next(80, 500) * -1;
                    x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            player.Left = this.ClientSize.Width / 2 + player.Width/2;
            player.Image = Properties.Resources.chicken_normal;

            score = 0;
            missed = 0;
            speed = 8;

            goLeft = false;
            goRight = false;

            GameTimer.Start();



        }
    }
}
