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
            Event.main = this;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            DB.testConnect();
         //   DB.GetRecords(TABLENAME.TEGG);
        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            Snake frmsnake = new Snake(this);
            frmsnake.Show();
            this.SetVisibleCore(false);
        }
        private void btnTank_Click(object sender, EventArgs e)
        {
            Guess frmguess = new Guess();
            frmguess.Show();
            this.SetVisibleCore(false);
        }
        private void btnBlocks_Click(object sender, EventArgs e)
        {
            Blocks frmblocks = new Blocks();
            frmblocks.Show();
            this.SetVisibleCore(false);
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            Ranking frmranking = new Ranking();
            frmranking.Show();
            this.SetVisibleCore(false);
        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            CarRace frmcar = new CarRace();
            frmcar.Show();
            this.SetVisibleCore(false);
        }
        public void BacktoMain()
        {
            this.SetVisibleCore(true);
        }

        private void btnBalloon_Click(object sender, EventArgs e)
        {
            ShootBalloon frmballoon = new ShootBalloon();
            frmballoon.Show();
            this.SetVisibleCore(false);
        }

        private void btnEgg_Click(object sender, EventArgs e)
        {
            Egg frmegg = new Egg();
            frmegg.Show();
            this.SetVisibleCore(false);
        }

        private void nameCheckB_Click(object sender, EventArgs e)
        {
           
            this.user_name = usertextbox.Text == "" ? "user" : usertextbox.Text;
            userHelloT.Text = $"{usertextbox.Text} 您好:";
        }
    }
}
