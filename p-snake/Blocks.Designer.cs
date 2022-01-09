
namespace p_snake
{
    partial class Blocks
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_info = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label213 = new System.Windows.Forms.Label();
            this.label_block_count = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_info.ForeColor = System.Drawing.Color.Red;
            this.label_info.Location = new System.Drawing.Point(350, 500);
            this.label_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(0, 50);
            this.label_info.TabIndex = 200;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(778, 750);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 60);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Again";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label213
            // 
            this.label213.AutoSize = true;
            this.label213.BackColor = System.Drawing.Color.Transparent;
            this.label213.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label213.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label213.Location = new System.Drawing.Point(771, 50);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(90, 40);
            this.label213.TabIndex = 1;
            this.label213.Text = "Next";
            // 
            // label_block_count
            // 
            this.label_block_count.AutoSize = true;
            this.label_block_count.BackColor = System.Drawing.Color.Transparent;
            this.label_block_count.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_block_count.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_block_count.Location = new System.Drawing.Point(771, 291);
            this.label_block_count.Name = "label_block_count";
            this.label_block_count.Size = new System.Drawing.Size(149, 40);
            this.label_block_count.TabIndex = 4;
            this.label_block_count.Text = "Blocks :  ";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_score.Location = new System.Drawing.Point(771, 357);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(136, 40);
            this.label_score.TabIndex = 3;
            this.label_score.Text = "Score :  ";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.BackColor = System.Drawing.Color.Transparent;
            this.label_level.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_level.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_level.Location = new System.Drawing.Point(771, 419);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(128, 40);
            this.label_level.TabIndex = 2;
            this.label_level.Text = "Level :  ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(778, 850);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 60);
            this.btnExit.TabIndex = 201;
            this.btnExit.Text = "Menu";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(771, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 80);
            this.label1.TabIndex = 202;
            this.label1.Text = "遊戲規則\n上為轉換方向，左右控制落下位置，\n下控制落下速度，空白鍵快速降落";
            // 
            // Blocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::p_snake.Properties.Resources.pngtree_space_game_interstellar_exploration_cosmic_background_image_9043171;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1414, 899);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label_level);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_block_count);
            this.Controls.Add(this.label213);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Blocks";
            this.Text = "俄羅斯方塊";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Blocks_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Blocks_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label213;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_block_count;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}