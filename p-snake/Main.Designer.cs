
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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.center_panel = new System.Windows.Forms.Panel();
            this.center_panel.SuspendLayout();
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
            this.btnTank.Location = new System.Drawing.Point(337, 206);
            this.btnTank.Margin = new System.Windows.Forms.Padding(2);
            this.btnTank.Name = "btnTank";
            this.btnTank.Size = new System.Drawing.Size(133, 40);
            this.btnTank.TabIndex = 3;
            this.btnTank.Text = "1A2B猜數字";
            this.btnTank.UseVisualStyleBackColor = true;
            this.btnTank.Click += new System.EventHandler(this.btnClick);
            this.btnTank.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // btnBlocks
            // 
            this.btnBlocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlocks.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBlocks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlocks.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnBlocks.Location = new System.Drawing.Point(548, 206);
            this.btnBlocks.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlocks.Name = "btnBlocks";
            this.btnBlocks.Size = new System.Drawing.Size(133, 40);
            this.btnBlocks.TabIndex = 4;
            this.btnBlocks.Text = "俄羅斯方塊";
            this.btnBlocks.UseVisualStyleBackColor = true;
            this.btnBlocks.Click += new System.EventHandler(this.btnClick);
            this.btnBlocks.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(201, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "輸入玩家名稱";
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRanking.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRanking.Location = new System.Drawing.Point(337, 402);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(2);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(133, 40);
            this.btnRanking.TabIndex = 6;
            this.btnRanking.Text = "排行榜";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnClick);
            this.btnRanking.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // btnCar
            // 
            this.btnCar.AllowDrop = true;
            this.btnCar.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCar.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnCar.Location = new System.Drawing.Point(118, 304);
            this.btnCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(133, 40);
            this.btnCar.TabIndex = 7;
            this.btnCar.Text = "賽車遊戲";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnClick);
            this.btnCar.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // btnBalloon
            // 
            this.btnBalloon.AllowDrop = true;
            this.btnBalloon.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBalloon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBalloon.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnBalloon.Location = new System.Drawing.Point(337, 304);
            this.btnBalloon.Margin = new System.Windows.Forms.Padding(2);
            this.btnBalloon.Name = "btnBalloon";
            this.btnBalloon.Size = new System.Drawing.Size(133, 40);
            this.btnBalloon.TabIndex = 8;
            this.btnBalloon.Text = "射氣球";
            this.btnBalloon.UseVisualStyleBackColor = true;
            this.btnBalloon.Click += new System.EventHandler(this.btnClick);
            this.btnBalloon.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // btnEgg
            // 
            this.btnEgg.AllowDrop = true;
            this.btnEgg.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEgg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEgg.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnEgg.Location = new System.Drawing.Point(548, 304);
            this.btnEgg.Margin = new System.Windows.Forms.Padding(2);
            this.btnEgg.Name = "btnEgg";
            this.btnEgg.Size = new System.Drawing.Size(133, 40);
            this.btnEgg.TabIndex = 9;
            this.btnEgg.Text = "接蛋遊戲";
            this.btnEgg.UseVisualStyleBackColor = true;
            this.btnEgg.Click += new System.EventHandler(this.btnClick);
            this.btnEgg.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // btnSnake
            // 
            this.btnSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSnake.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSnake.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSnake.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.btnSnake.Location = new System.Drawing.Point(118, 206);
            this.btnSnake.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(133, 40);
            this.btnSnake.TabIndex = 2;
            this.btnSnake.Text = "貪食蛇";
            this.btnSnake.UseVisualStyleBackColor = true;
            this.btnSnake.Click += new System.EventHandler(this.btnClick);
            this.btnSnake.MouseEnter += new System.EventHandler(this.mouseEnter);
            // 
            // usertextbox
            // 
            this.usertextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.usertextbox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.usertextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.usertextbox.Location = new System.Drawing.Point(346, 38);
            this.usertextbox.Name = "usertextbox";
            this.usertextbox.Size = new System.Drawing.Size(195, 39);
            this.usertextbox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(276, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "您好:請選擇想遊玩的遊戲";
            // 
            // userHelloT
            // 
            this.userHelloT.AutoSize = true;
            this.userHelloT.BackColor = System.Drawing.Color.Transparent;
            this.userHelloT.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userHelloT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userHelloT.Location = new System.Drawing.Point(216, 107);
            this.userHelloT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userHelloT.Name = "userHelloT";
            this.userHelloT.Size = new System.Drawing.Size(58, 28);
            this.userHelloT.TabIndex = 12;
            this.userHelloT.Text = "user";
            // 
            // nameCheckB
            // 
            this.nameCheckB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nameCheckB.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameCheckB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameCheckB.Image = global::p_snake.Properties.Resources.buttons_PNG167;
            this.nameCheckB.Location = new System.Drawing.Point(553, 38);
            this.nameCheckB.Margin = new System.Windows.Forms.Padding(2);
            this.nameCheckB.Name = "nameCheckB";
            this.nameCheckB.Size = new System.Drawing.Size(69, 40);
            this.nameCheckB.TabIndex = 13;
            this.nameCheckB.Text = "確認";
            this.nameCheckB.UseVisualStyleBackColor = true;
            this.nameCheckB.Click += new System.EventHandler(this.nameCheckB_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // center_panel
            // 
            this.center_panel.BackColor = System.Drawing.Color.Transparent;
            this.center_panel.Controls.Add(this.btnSnake);
            this.center_panel.Controls.Add(this.btnBlocks);
            this.center_panel.Controls.Add(this.nameCheckB);
            this.center_panel.Controls.Add(this.btnCar);
            this.center_panel.Controls.Add(this.usertextbox);
            this.center_panel.Controls.Add(this.userHelloT);
            this.center_panel.Controls.Add(this.label1);
            this.center_panel.Controls.Add(this.btnBalloon);
            this.center_panel.Controls.Add(this.label2);
            this.center_panel.Controls.Add(this.btnEgg);
            this.center_panel.Controls.Add(this.btnTank);
            this.center_panel.Controls.Add(this.btnRanking);
            this.center_panel.Location = new System.Drawing.Point(218, 55);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(809, 476);
            this.center_panel.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::p_snake.Properties.Resources._1082070_21041011203217;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1161, 675);
            this.Controls.Add(this.center_panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "遊戲工坊";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.center_panel.ResumeLayout(false);
            this.center_panel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel center_panel;
    }
}