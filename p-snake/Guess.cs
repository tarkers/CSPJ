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
    public partial class Guess : Form
    {
        private int[] ans = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };//正確答案
        private String[] gnum = new string[10];//猜的答案數字
        private int tmp, r;
        private int score = 0;
        private Random ran = new Random();
        public Guess()
        {
            InitializeComponent();
            random_Num();
        }
        private void Guess_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = "";
            int a = 0, b = 0;
            if (textBox1.TextLength != 4)
            {
                MessageBox.Show("請輸入4個不一樣的數字");
            }
            else
            {
                for (int j = 1; j <= 4; j++)
                {
                    gnum[j] = textBox1.Text.Substring(j - 1, 1);
                    num += gnum[j];
                }
                if ((gnum[1] == gnum[2] || gnum[1] == gnum[3] ||
                gnum[1] == gnum[4] || gnum[2] == gnum[3] ||
                gnum[2] == gnum[4] || gnum[3] == gnum[4]))
                {
                    MessageBox.Show("不能輸入重複的數字哦");
                }
                else
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        Console.WriteLine(ans[k]);
                        for (int l = 1; l <= 4; l++)
                        {
                            if (gnum[k] == ans[l].ToString())
                            {
                                if (k == l)
                                {
                                    a++;
                                }
                                else if (k != l)
                                {
                                    b++;
                                }
                            }
                        }
                    }
                    textBox2.Text += num + "-----" + a.ToString() + "A" + b.ToString() + "B" + "\r\n";
                    label3.Text = "第" + (textBox2.Lines.Length - 1) + "猜";
                    score = 0 - (textBox2.Lines.Length - 1);
                    Console.WriteLine(score);
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
                if (a == 4 && b == 0)
                {
                    MessageBox.Show("恭喜你猜對了");
                    button1.Enabled = false;
                }
                else if (textBox2.Lines.Length == 11)
                {
                    MessageBox.Show("你要再加油了");
                    button1.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Ans = "";
            for (int i = 1; i <= 4; i++)
            {
                Ans += ans[i];
                
            }
            MessageBox.Show("答案是:"+Ans);
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Enabled = false;
            //gmae_init();
            //timer1.Enabled = true;
            if (Event.FormClosingCheck("確定返回?" + Environment.NewLine + "Click ok to back to menu"
                   + Environment.NewLine + "Click cancel to restart"))
            {
                this.Close();
                if(button1.Enabled == false)
                {
                    //儲存資料至DB Function
                    Console.WriteLine(score);
                    Event.SaveScoreToDB(score, 0, TABLENAME.T1A2B);
                    Event.FormClosed();
                    
                }
             

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Enabled = true;
            random_Num();
            for (int j = 1; j <= 4; j++)
            {
                gnum[j] = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Guess_FormClosed(object sender, FormClosedEventArgs e)
        {
            Event.FormClosed();
        }

        private void random_Num()
        {
            for (int i = 0; i < 10; i++)
            {
                r = ran.Next(0, 10 - i);
                tmp = ans[r];
                ans[r] = ans[9 - i];
                ans[9 - i] = tmp;
               
            }
        }

        
    }
}
