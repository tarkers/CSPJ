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
            TextBox textbox = null;
            List<Record> records = new List<Record>();
            string header = "\t編號\t姓名\t分數\t排名" + Environment.NewLine;
            header += "-------------------------------------------------------------" + Environment.NewLine;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    textbox = txtSnake;
                    records = DB.GetRecords(TABLENAME.TSNAKE);
                    break;
                case 1:
                    textbox = txtBlocks;
                    records = DB.GetRecords(TABLENAME.TTETRIS);
                    break;
                case 2:
                    textbox = txtGuess;
                    records = DB.GetRecords(TABLENAME.T1A2B);
                    break;
                case 3:
                    textbox = txtCar;
                    records = DB.GetRecords(TABLENAME.TCAR);
                    break;
                case 4:
                    textbox = txtBalloon;
                    records = DB.GetRecords(TABLENAME.TBALLOON);
                    break;
                case 5:
                    textbox = txtEgg;
                    records = DB.GetRecords(TABLENAME.TEGG);

                    break;
                case 6:
                    textbox = txtRank;
                    break;
                default:
                    break;
            }
           
            textbox.Text = header;
            int i = 0;
            foreach (Record re in records)
            {
                Console.WriteLine(i);
                i++;
                textbox.Text += $"\t{re.Id}\t{re.Name}\t{re.Score}\t{i}" + Environment.NewLine;
            }
        }


    }
}
