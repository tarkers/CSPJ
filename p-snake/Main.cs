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
    public partial class Main : Form
    {
        public string user_name = "user";
        public Main()
        {
            InitializeComponent();

            Sound.Set_Background();
            Event.main = this;
        }
  
        private void Main_Load(object sender, EventArgs e)
        {
            center_panel.BackColor = Color.FromArgb(150,0, 0, 0);
            center_panel.Left = (this.Width - center_panel.Width) / 2 ;
            center_panel.Top = (this.Height - center_panel.Height) / 2;
        }
        public void BacktoMain()
        {
            this.SetVisibleCore(true);
        }



        private void nameCheckB_Click(object sender, EventArgs e)
        {
           
            this.user_name = usertextbox.Text == "" ? "user" : usertextbox.Text;
            userHelloT.Text = $"{usertextbox.Text} ";
        }

      

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Sound.PressButton();
            Console.WriteLine(btn.Name);
            switch (btn.Name)
            {
                case "btnEgg":               
                    Egg frmegg = new Egg();
                    frmegg.Show();             
                    break;
                case "btnBalloon":
                    ShootBalloon frmballoon = new ShootBalloon();
                    frmballoon.Show();
                    break;
                case "btnCar":
                    CarRace frmcar = new CarRace();
                    frmcar.Show();
                    break;
                case "btnBlocks":
                    Blocks frmblocks = new Blocks();
                    frmblocks.Show();
                    break;
                case "btnTank":
                    Guess frmguess = new Guess();
                    frmguess.Show();
                    break;
                case "btnSnake":
                    Snake frmsnake = new Snake();
                    frmsnake.Show();
                    break;
                case "btnRanking":
                    Ranking frmranking = new Ranking();
                    frmranking.Show();
                    break;
            }
            Sound.SetBackgroundVolume(35);
            this.SetVisibleCore(false);
        }
        private void mouseEnter(object sender, EventArgs e)
        {
            Sound.PlayMouseOver();
        }
    }
}
