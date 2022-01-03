
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
            this.btnTank = new System.Windows.Forms.Button();
            this.btnBlocks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.btnBalloon = new System.Windows.Forms.Button();
            this.btnEgg = new System.Windows.Forms.Button();
            this.btnSnake = new System.Windows.Forms.Button();
            this.usertextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userHelloT = new System.Windows.Forms.Label();
            this.nameCheckB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnTank
            // 
            this.btnTank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTank.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTank.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnTank.Location = new System.Drawing.Point(200, 161);
            this.btnTank.Margin = new System.Windows.Forms.Padding(2);
            this.btnTank.Name = "btnTank";
            this.btnTank.Size = new System.Drawing.Size(133, 40);
            this.btnTank.TabIndex = 3;
            this.btnTank.Text = "1A2B猜數字";
            this.btnTank.UseVisualStyleBackColor = true;
            this.btnTank.Click += new System.EventHandler(this.btnTank_Click);
            // 
            // btnBlocks
            // 
            this.btnBlocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlocks.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBlocks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlocks.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnBlocks.Location = new System.Drawing.Point(337, 161);
            this.btnBlocks.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlocks.Name = "btnBlocks";
            this.btnBlocks.Size = new System.Drawing.Size(133, 40);
            this.btnBlocks.TabIndex = 4;
            this.btnBlocks.Text = "俄羅斯方塊";
            this.btnBlocks.UseVisualStyleBackColor = true;
            this.btnBlocks.Click += new System.EventHandler(this.btnBlocks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "輸入玩家名稱";
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRanking.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRanking.Location = new System.Drawing.Point(189, 287);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(2);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(133, 40);
            this.btnRanking.TabIndex = 6;
            this.btnRanking.Text = "排行榜";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnCar
            // 
            this.btnCar.AllowDrop = true;
            this.btnCar.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCar.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnCar.Location = new System.Drawing.Point(62, 221);
            this.btnCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(133, 40);
            this.btnCar.TabIndex = 7;
            this.btnCar.Text = "賽車遊戲";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnBalloon
            // 
            this.btnBalloon.AllowDrop = true;
            this.btnBalloon.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBalloon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBalloon.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnBalloon.Location = new System.Drawing.Point(200, 221);
            this.btnBalloon.Margin = new System.Windows.Forms.Padding(2);
            this.btnBalloon.Name = "btnBalloon";
            this.btnBalloon.Size = new System.Drawing.Size(133, 40);
            this.btnBalloon.TabIndex = 8;
            this.btnBalloon.Text = "射氣球";
            this.btnBalloon.UseVisualStyleBackColor = true;
            this.btnBalloon.Click += new System.EventHandler(this.btnBalloon_Click);
            // 
            // btnEgg
            // 
            this.btnEgg.AllowDrop = true;
            this.btnEgg.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEgg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEgg.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnEgg.Location = new System.Drawing.Point(337, 221);
            this.btnEgg.Margin = new System.Windows.Forms.Padding(2);
            this.btnEgg.Name = "btnEgg";
            this.btnEgg.Size = new System.Drawing.Size(133, 40);
            this.btnEgg.TabIndex = 9;
            this.btnEgg.Text = "接蛋遊戲";
            this.btnEgg.UseVisualStyleBackColor = true;
            this.btnEgg.Click += new System.EventHandler(this.btnEgg_Click);
            // 
            // btnSnake
            // 
            this.btnSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSnake.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSnake.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSnake.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnSnake.Location = new System.Drawing.Point(62, 161);
            this.btnSnake.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(133, 40);
            this.btnSnake.TabIndex = 2;
            this.btnSnake.Text = "貪食蛇";
            this.btnSnake.UseVisualStyleBackColor = true;
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            // 
            // usertextbox
            // 
            this.usertextbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usertextbox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usertextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.usertextbox.Location = new System.Drawing.Point(201, 48);
            this.usertextbox.Name = "usertextbox";
            this.usertextbox.Size = new System.Drawing.Size(195, 39);
            this.usertextbox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(166, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "請選擇想遊玩的遊戲";
            // 
            // userHelloT
            // 
            this.userHelloT.AutoSize = true;
            this.userHelloT.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.userHelloT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userHelloT.Location = new System.Drawing.Point(64, 121);
            this.userHelloT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userHelloT.Name = "userHelloT";
            this.userHelloT.Size = new System.Drawing.Size(98, 25);
            this.userHelloT.TabIndex = 12;
            this.userHelloT.Text = "user您好:";
            // 
            // nameCheckB
            // 
            this.nameCheckB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nameCheckB.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameCheckB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameCheckB.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.nameCheckB.Location = new System.Drawing.Point(401, 48);
            this.nameCheckB.Margin = new System.Windows.Forms.Padding(2);
            this.nameCheckB.Name = "nameCheckB";
            this.nameCheckB.Size = new System.Drawing.Size(69, 40);
            this.nameCheckB.TabIndex = 13;
            this.nameCheckB.Text = "確認";
            this.nameCheckB.UseVisualStyleBackColor = true;
            this.nameCheckB.Click += new System.EventHandler(this.nameCheckB_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 347);
            this.Controls.Add(this.nameCheckB);
            this.Controls.Add(this.userHelloT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usertextbox);
            this.Controls.Add(this.btnEgg);
            this.Controls.Add(this.btnBalloon);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBlocks);
            this.Controls.Add(this.btnTank);
            this.Controls.Add(this.btnSnake);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "遊戲工坊";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSnake;
        private System.Windows.Forms.Button btnTank;
        private System.Windows.Forms.Button btnBlocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnBalloon;
        private System.Windows.Forms.Button btnEgg;
        private System.Windows.Forms.TextBox usertextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userHelloT;
        private System.Windows.Forms.Button nameCheckB;
    }
}