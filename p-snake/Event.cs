using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_snake
{
    static class Event
    {
        public static Main main;

        public static void FormClosingCheck(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("結束嗎?", "結束", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {

                e.Cancel = true;

            }
        }
        public static bool FormClosingCheck(string text = "結束嗎?")
        {
            return MessageBox.Show(text, "結束", MessageBoxButtons.OKCancel) == DialogResult.Cancel ? false : true;
        }
        public static void FormClosed()
        {
            main.BacktoMain();
        }
        public static void SaveScoreToDB(int score,int mode, string table)
        {
            Record record = new Record(score, mode);
            record.Name = main.user_name;
            DB.InsertScore(record, table);
        }
    }
}
