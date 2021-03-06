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
    public partial class ShootBalloon : Form
    {

        int speed;
        int score;
        Random rand = new Random();
        bool gameOver;
        DialogResult Result;

        public ShootBalloon()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;

            if (gameOver == true)
            {
                gameTimer.Stop();
                //txtScore.Text = "Score: " + score + " Game over, press enter to restart!\n Press esc to go back to main page";
                Result=MessageBox.Show(" Game over, press enter to restart!\n Press esc to go back to main page");
                /*if (Result == DialogResult.OK)
                {
                    RestartGame();
                }*/
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox)
                {
                    x.Top -= speed;

                    if (x.Top < -100)
                    {
                        x.Top = rand.Next(700, 1000);
                        x.Left = rand.Next(5, 500);
                    }

                    if ((string)x.Tag == "balloon")
                    {

                        if (x.Top < -50)
                        {
                            gameOver = true;
                        }

                        if (bomb.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = rand.Next(700, 1000);
                            x.Left = rand.Next(5, 500);
                        }
                    }
                }

            }


            if (score > 10)
            {
                speed = 8;
            }

            if (score > 15 && score < 25)
            {
                speed = 12;
            }



        }
        private void Speed_mode()
        {
            speed = (int)Math.Log10(Math.Pow(2, score / 3))+4;
            Console.WriteLine(speed);
        }
        private void PopBalloon(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                Sound.ShootBalloon(true);
                var balloon = (PictureBox)sender;

                balloon.Top = rand.Next(750, 1000);
                balloon.Left = rand.Next(5, 500);

                score += 1;

            }


        }

        private void GoBoom(object sender, EventArgs e)
        {
            if (gameOver == false)
            {
                Sound.ShootBalloon(false);
                bomb.Image = Properties.Resources.boom;
                gameOver = true;
            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (  gameOver == true)
            {
                if (e.KeyCode == Keys.Enter )
                {
                    RestartGame();
                }
                
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                    //儲存資料至DB Function
                    Event.SaveScoreToDB(score, 0, TABLENAME.TBALLOON);
                    Event.FormClosed();
                }

            }
         
        }

        private void RestartGame()
        {
            speed = 5;
            score = 0;
            gameOver = false;

            bomb.Image = Properties.Resources.bomb;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Top = rand.Next(750, 1000);
                    x.Left = rand.Next(5, 500);
                }
            }

            gameTimer.Start();
        }

        private void ShootBalloon_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  Event.FormClosingCheck(sender, e);
        }

        private void ShootBalloon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Event.FormClosed();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
