using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using p_snake.Resources;

namespace p_snake
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }
        //連線Azure雲端資料庫
        csfinalEntities csdb = new csfinalEntities();
        //string getTop5 = @"SELECT TOP5 編號,姓名,分數 FROM 貪吃蛇 ORDER BY 分數 DESC";
        //cn.ConnectionString=@"Data Source =()";
        //SqlDataAdapter daSnake = new SqlDataAdapter("SELECT TOP5 編號,姓名,分數 FROM 貪吃蛇 ORDER BY 分數 DESC",cn);
        private void Ranking_Load(object sender, EventArgs e)
        {
            //txtSnake.Dock = DockStyle.Fill;
        }

        private void Ranking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Event.FormClosed();
        }

        private void Ranking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Event.FormClosingCheck(sender, e);
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                txtSnake.Text = "\t編號\t姓名\t分數\t排名"+Environment.NewLine;
                txtSnake.Text += "--------------------------------------------------------------" + Environment.NewLine;
                //txtSnake.Text += csdb.貪吃蛇.ToList();
                //txtSnake.Text += csdb.();


            }
            else if (tabControl1.SelectedIndex == 1)
            {
                txtGuess.Text = "\t編號\t姓名\t分數\t排名" + Environment.NewLine;
                txtGuess.Text += "--------------------------------------------------------------" + Environment.NewLine;
            }
            else if(tabControl1.SelectedIndex == 2)
            {
                txtBlocks.Text = "\t編號\t姓名\t分數\t排名" + Environment.NewLine;
                txtBlocks.Text += "--------------------------------------------------------------" + Environment.NewLine;
            }
            else if(tabControl1.SelectedIndex == 3)
            {
                txtCar.Text = "\t編號\t姓名\t分數\t排名" + Environment.NewLine;
                txtCar.Text += "--------------------------------------------------------------" + Environment.NewLine;
            }
            else if(tabControl1.SelectedIndex == 4)
            {
                txtBalloon.Text = "\t編號\t姓名\t分數\t排名" + Environment.NewLine;
                txtBalloon.Text += "--------------------------------------------------------------" + Environment.NewLine;
            }
            else if(tabControl1.SelectedIndex == 5)
            {
                txtEgg.Text = "\t編號\t姓名\t分數\t排名" + Environment.NewLine;
                txtEgg.Text += "--------------------------------------------------------------" + Environment.NewLine;
            }
            else if(tabControl1.SelectedIndex == 6)
            {
                txtRank.Text = "\t編號\t姓名\t分數\t排名" + Environment.NewLine;
                txtRank.Text += "--------------------------------------------------------------" + Environment.NewLine;
            }
        }

        
    }
}
