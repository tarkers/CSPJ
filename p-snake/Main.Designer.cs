
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
            this.btnTank.Location = new System.Drawing.Point(310, 182);
            this.btnTank.Name = "btnTank";
            this.btnTank.Size = new System.Drawing.Size(200, 60);
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
            this.btnBlocks.Location = new System.Drawing.Point(516, 182);
            this.btnBlocks.Name = "btnBlocks";
            this.btnBlocks.Size = new System.Drawing.Size(200, 60);
            this.btnBlocks.TabIndex = 4;
            this.btnBlocks.Text = "俄羅斯方塊";
            this.btnBlocks.UseVisualStyleBackColor = true;
            this.btnBlocks.Click += new System.EventHandler(this.btnBlocks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(98, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "請選擇想遊玩的遊戲";
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRanking.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRanking.Location = new System.Drawing.Point(310, 384);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(200, 60);
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
            this.btnCar.Location = new System.Drawing.Point(104, 271);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(200, 60);
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
            this.btnBalloon.Location = new System.Drawing.Point(310, 271);
            this.btnBalloon.Name = "btnBalloon";
            this.btnBalloon.Size = new System.Drawing.Size(200, 60);
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
            this.btnEgg.Location = new System.Drawing.Point(516, 271);
            this.btnEgg.Name = "btnEgg";
            this.btnEgg.Size = new System.Drawing.Size(200, 60);
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
            this.btnSnake.Location = new System.Drawing.Point(104, 182);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(200, 60);
            this.btnSnake.TabIndex = 2;
            this.btnSnake.Text = "貪食蛇";
            this.btnSnake.UseVisualStyleBackColor = true;
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnEgg);
            this.Controls.Add(this.btnBalloon);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBlocks);
            this.Controls.Add(this.btnTank);
            this.Controls.Add(this.btnSnake);
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
    }
}