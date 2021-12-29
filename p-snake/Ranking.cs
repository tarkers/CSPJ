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
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Event.FormClosed();
        }

        private void Ranking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Event.FormClosingCheck(sender, e);
           
        }
    }
}
