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
    public partial class Tank : Form
    {
        public Tank()
        {
            InitializeComponent();
        }

        int locX, locY;

        private void Tank_Load(object sender, EventArgs e)
        {
            locX = picTank.Location.X;
            locY = picTank.Location.Y;
            //lblX.Text = $"X座標:{picTank.Location.X}";
            //lblY.Text = $"Y座標:{picTank.Location.Y}";
            lblMsg.Text = "請按上下左右鍵控制坦克";

            picTank.SizeMode = PictureBoxSizeMode.AutoSize;
            picTank.Image = picTankU.Image;
            picTankU.Visible = false;
            picTankD.Visible = false;
            picTankL.Visible = false;
            picTankR.Visible = false;

            picTank2.SizeMode = PictureBoxSizeMode.AutoSize;
            picTank2.Image = picTank2_U.Image;
            picTank2_U.Visible = false;
            picTank2_D.Visible = false;
            picTank2_L.Visible = false;
            picTank2_R.Visible = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    picTank2.Image = picTank2_U.Image;
                    if ((picTank2.Top + picTank2.Height) <= 0)
                    {
                        picTank2.Top = this.Height;
                    }
                    else
                    {
                        picTank2.Top -= 10;
                    }
                    break;
                case Keys.Down:
                    picTank2.Image = picTank2_D.Image;
                    if (picTank2.Top >= this.Height)
                    {
                        picTank2.Top = 0 - picTank2.Height;
                    }
                    else
                    {
                        picTank2.Top += 10;
                    }
                    break;

                case Keys.Left:
                    picTank2.Image = picTank2_L.Image;
                    if (picTank2.Width + picTank2.Left <= 0)
                    {
                        picTank.Left = this.Width;
                    }
                    else
                    {
                        picTank2.Left -= 10;
                    }
                    break;

                case Keys.Right:
                    picTank2.Image = picTank2_R.Image;
                    if (picTank2.Left >= this.Width)
                    {
                        picTank2.Left = 0 - picTank2.Width;
                    }
                    else
                    {
                        picTank2.Left += 10;
                    }
                    break;


            }
            /*
            switch (e.KeyCode)
            {
                case Keys.W:
                    picTank.Image = picTankU.Image;
                    if ((picTank.Top + picTank.Height) <= 0)
                    {
                        picTank.Top = this.Height;
                    }
                    else
                    {
                        picTank.Top -= 10;
                    }
                    break;
                case Keys.S:
                    picTank.Image = picTankD.Image;
                    if (picTank.Top >= this.Height)
                    {
                        picTank.Top = 0 - picTank.Height;
                    }
                    else
                    {
                        picTank.Top += 10;
                    }
                    break;

                case Keys.A:
                    picTank.Image = picTankL.Image;
                    if (picTank.Width + picTank.Left <= 0)
                    {
                        picTank.Left = this.Width;
                    }
                    else
                    {
                        picTank.Left -= 10;
                    }
                    break;

                case Keys.D:
                    picTank.Image = picTankR.Image;
                    if (picTank.Left >= this.Width)
                    {
                        picTank.Left = 0 - picTank.Width;
                    }
                    else
                    {
                        picTank.Left += 10;
                    }
                    break;
            }
            */
            //lblX.Text = $"X座標:{picTank.Location.X}";
            //lblY.Text = $"Y座標:{picTank.Location.Y}";
            lblMsg.Text = $"現在按下{e.KeyCode}鍵!!";
        }
        private void Form1_KeyDown_2(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    picTank.Image = picTankU.Image;
                    if ((picTank.Top + picTank.Height) <= 0)
                    {
                        picTank.Top = this.Height;
                    }
                    else
                    {
                        picTank.Top -= 10;
                    }
                    break;
                case Keys.S:
                    picTank.Image = picTankD.Image;
                    if (picTank.Top >= this.Height)
                    {
                        picTank.Top = 0 - picTank.Height;
                    }
                    else
                    {
                        picTank.Top += 10;
                    }
                    break;

                case Keys.A:
                    picTank.Image = picTankL.Image;
                    if (picTank.Width + picTank.Left <= 0)
                    {
                        picTank.Left = this.Width;
                    }
                    else
                    {
                        picTank.Left -= 10;
                    }
                    break;

                case Keys.D:
                    picTank.Image = picTankR.Image;
                    if (picTank.Left >= this.Width)
                    {
                        picTank.Left = 0 - picTank.Width;
                    }
                    else
                    {
                        picTank.Left += 10;
                    }
                    break;
            }
        }
            private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //lblX.Text = $"X座標:{picTank.Location.X}";
            //lblY.Text = $"Y座標:{picTank.Location.Y}";
            lblMsg.Text = "請按上下左右鍵控制坦克";
        }
    }
}
