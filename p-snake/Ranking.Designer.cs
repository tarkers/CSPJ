
namespace p_snake
{
    partial class Ranking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSnake = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBlocks = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.txtBalloon = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.txtEgg = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(43690, 43690);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtSnake);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(43682, 43656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "貪食蛇";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBackMain);
            // 
            // txtSnake
            // 
            this.txtSnake.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSnake.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSnake.Location = new System.Drawing.Point(61, 25);
            this.txtSnake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSnake.Multiline = true;
            this.txtSnake.Name = "txtSnake";
            this.txtSnake.Size = new System.Drawing.Size(387, 457);
            this.txtSnake.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtBlocks);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(43682, 43656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "俄羅斯方塊";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GoBackMain);
            // 
            // txtBlocks
            // 
            this.txtBlocks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBlocks.Location = new System.Drawing.Point(61, 25);
            this.txtBlocks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBlocks.Multiline = true;
            this.txtBlocks.Name = "txtBlocks";
            this.txtBlocks.Size = new System.Drawing.Size(387, 457);
            this.txtBlocks.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.txtGuess);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(43682, 43656);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "1A2B猜數字";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GoBackMain);
            // 
            // txtGuess
            // 
            this.txtGuess.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtGuess.Location = new System.Drawing.Point(61, 25);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGuess.Multiline = true;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(387, 457);
            this.txtGuess.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.txtCar);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(43682, 43656);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "賽車遊戲";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(473, 25);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 29);
            this.button4.TabIndex = 1;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GoBackMain);
            // 
            // txtCar
            // 
            this.txtCar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCar.Location = new System.Drawing.Point(61, 25);
            this.txtCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCar.Multiline = true;
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(387, 457);
            this.txtCar.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Controls.Add(this.txtBalloon);
            this.tabPage6.Location = new System.Drawing.Point(4, 30);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(43682, 43656);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "射氣球";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(473, 25);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "Menu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.GoBackMain);
            // 
            // txtBalloon
            // 
            this.txtBalloon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBalloon.Location = new System.Drawing.Point(61, 25);
            this.txtBalloon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBalloon.Multiline = true;
            this.txtBalloon.Name = "txtBalloon";
            this.txtBalloon.Size = new System.Drawing.Size(387, 457);
            this.txtBalloon.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage7.Controls.Add(this.button6);
            this.tabPage7.Controls.Add(this.txtEgg);
            this.tabPage7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage7.Location = new System.Drawing.Point(4, 30);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(43682, 43656);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "接蛋遊戲";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(473, 25);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 29);
            this.button6.TabIndex = 1;
            this.button6.Text = "Menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.GoBackMain);
            // 
            // txtEgg
            // 
            this.txtEgg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEgg.Location = new System.Drawing.Point(61, 25);
            this.txtEgg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEgg.Multiline = true;
            this.txtEgg.Name = "txtEgg";
            this.txtEgg.Size = new System.Drawing.Size(387, 457);
            this.txtEgg.TabIndex = 0;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 700);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ranking";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "排行榜";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ranking_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ranking_FormClosed);
            this.Load += new System.EventHandler(this.Ranking_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtSnake;
        private System.Windows.Forms.TextBox txtBlocks;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.TextBox txtBalloon;
        private System.Windows.Forms.TextBox txtEgg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}