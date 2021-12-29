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
        public Main()
        {
            InitializeComponent();
            Event.main = this;
        }

        private void Snake_Click(object sender, EventArgs e)
        {
            Snake s = new Snake(this);
            s.Show();
            this.SetVisibleCore(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Blocks b = new Blocks();
            b.Show();
            this.SetVisibleCore(false);
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            Ranking r = new Ranking();
            r.Show();
            this.SetVisibleCore(false);
        }
        private void car_button_Click(object sender, EventArgs e)
        {
            CarRace carForm = new CarRace();
            carForm.Show();
            this.SetVisibleCore(false);
        }
        public  void BacktoMain()
        {
            this.SetVisibleCore(true);
        }

        private void balloonBtn_Click(object sender, EventArgs e)
        {
            ShootBalloon r = new ShootBalloon();
            r.Show();
            this.SetVisibleCore(false);
        }

        private void catchEggBtn_Click(object sender, EventArgs e)
        {
            Egg egg = new Egg();
            egg.Show();
            this.SetVisibleCore(false);
        }
    }
}
