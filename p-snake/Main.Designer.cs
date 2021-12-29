
namespace p_snake
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Snake = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRanking = new System.Windows.Forms.Button();
            this.car_button = new System.Windows.Forms.Button();
            this.balloonBtn = new System.Windows.Forms.Button();
            this.catchEggBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Snake
            // 
            this.Snake.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Snake.Location = new System.Drawing.Point(96, 97);
            this.Snake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Snake.Name = "Snake";
            this.Snake.Size = new System.Drawing.Size(88, 39);
            this.Snake.TabIndex = 2;
            this.Snake.Text = "貪食蛇";
            this.Snake.UseVisualStyleBackColor = true;
            this.Snake.Click += new System.EventHandler(this.Snake_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(194, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "戰車";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(292, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "俄羅斯方塊";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "請選擇想遊玩的遊戲";
            // 
            // btnRanking
            // 
            this.btnRanking.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRanking.Location = new System.Drawing.Point(194, 213);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(96, 29);
            this.btnRanking.TabIndex = 6;
            this.btnRanking.Text = "排行榜";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // car_button
            // 
            this.car_button.AllowDrop = true;
            this.car_button.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.car_button.Location = new System.Drawing.Point(96, 158);
            this.car_button.Margin = new System.Windows.Forms.Padding(2);
            this.car_button.Name = "car_button";
            this.car_button.Size = new System.Drawing.Size(118, 39);
            this.car_button.TabIndex = 7;
            this.car_button.Text = "賽車遊戲";
            this.car_button.UseVisualStyleBackColor = true;
            this.car_button.Click += new System.EventHandler(this.car_button_Click);
            // 
            // balloonBtn
            // 
            this.balloonBtn.AllowDrop = true;
            this.balloonBtn.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.balloonBtn.Location = new System.Drawing.Point(218, 158);
            this.balloonBtn.Margin = new System.Windows.Forms.Padding(2);
            this.balloonBtn.Name = "balloonBtn";
            this.balloonBtn.Size = new System.Drawing.Size(118, 39);
            this.balloonBtn.TabIndex = 8;
            this.balloonBtn.Text = "射氣球";
            this.balloonBtn.UseVisualStyleBackColor = true;
            this.balloonBtn.Click += new System.EventHandler(this.balloonBtn_Click);
            // 
            // catchEggBtn
            // 
            this.catchEggBtn.AllowDrop = true;
            this.catchEggBtn.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.catchEggBtn.Location = new System.Drawing.Point(340, 158);
            this.catchEggBtn.Margin = new System.Windows.Forms.Padding(2);
            this.catchEggBtn.Name = "catchEggBtn";
            this.catchEggBtn.Size = new System.Drawing.Size(118, 39);
            this.catchEggBtn.TabIndex = 9;
            this.catchEggBtn.Text = "接蛋遊戲";
            this.catchEggBtn.UseVisualStyleBackColor = true;
            this.catchEggBtn.Click += new System.EventHandler(this.catchEggBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 347);
            this.Controls.Add(this.catchEggBtn);
            this.Controls.Add(this.balloonBtn);
            this.Controls.Add(this.car_button);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Snake);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "遊戲工坊";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Snake;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button car_button;
        private System.Windows.Forms.Button balloonBtn;
        private System.Windows.Forms.Button catchEggBtn;
    }
}