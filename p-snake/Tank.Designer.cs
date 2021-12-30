
namespace p_snake
{
    partial class Tank
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.picTank2_R = new System.Windows.Forms.PictureBox();
            this.picTank2_L = new System.Windows.Forms.PictureBox();
            this.picTank2_D = new System.Windows.Forms.PictureBox();
            this.picTank2_U = new System.Windows.Forms.PictureBox();
            this.picTank2 = new System.Windows.Forms.PictureBox();
            this.picTankR = new System.Windows.Forms.PictureBox();
            this.picTankL = new System.Windows.Forms.PictureBox();
            this.picTank = new System.Windows.Forms.PictureBox();
            this.picTankD = new System.Windows.Forms.PictureBox();
            this.picTankU = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTank2_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank2_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank2_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank2_U)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(59, 32);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(50, 18);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "label1";
            // 
            // picTank2_R
            // 
            this.picTank2_R.Image = global::p_snake.Properties.Resources.tankR_R;
            this.picTank2_R.Location = new System.Drawing.Point(531, 600);
            this.picTank2_R.Name = "picTank2_R";
            this.picTank2_R.Size = new System.Drawing.Size(100, 50);
            this.picTank2_R.TabIndex = 10;
            this.picTank2_R.TabStop = false;
            this.picTank2_R.WaitOnLoad = true;
            // 
            // picTank2_L
            // 
            this.picTank2_L.Image = global::p_snake.Properties.Resources.tankL_R;
            this.picTank2_L.Location = new System.Drawing.Point(127, 600);
            this.picTank2_L.Name = "picTank2_L";
            this.picTank2_L.Size = new System.Drawing.Size(100, 50);
            this.picTank2_L.TabIndex = 9;
            this.picTank2_L.TabStop = false;
            // 
            // picTank2_D
            // 
            this.picTank2_D.Image = global::p_snake.Properties.Resources.tankD_R;
            this.picTank2_D.Location = new System.Drawing.Point(531, 453);
            this.picTank2_D.Name = "picTank2_D";
            this.picTank2_D.Size = new System.Drawing.Size(100, 50);
            this.picTank2_D.TabIndex = 8;
            this.picTank2_D.TabStop = false;
            // 
            // picTank2_U
            // 
            this.picTank2_U.Image = global::p_snake.Properties.Resources.tankU_R;
            this.picTank2_U.Location = new System.Drawing.Point(127, 444);
            this.picTank2_U.Name = "picTank2_U";
            this.picTank2_U.Size = new System.Drawing.Size(100, 50);
            this.picTank2_U.TabIndex = 7;
            this.picTank2_U.TabStop = false;
            // 
            // picTank2
            // 
            this.picTank2.Location = new System.Drawing.Point(323, 517);
            this.picTank2.Name = "picTank2";
            this.picTank2.Size = new System.Drawing.Size(100, 50);
            this.picTank2.TabIndex = 6;
            this.picTank2.TabStop = false;
            // 
            // picTankR
            // 
            this.picTankR.ErrorImage = null;
            this.picTankR.Image = global::p_snake.Properties.Resources.tankR;
            this.picTankR.Location = new System.Drawing.Point(531, 265);
            this.picTankR.Name = "picTankR";
            this.picTankR.Size = new System.Drawing.Size(76, 74);
            this.picTankR.TabIndex = 4;
            this.picTankR.TabStop = false;
            // 
            // picTankL
            // 
            this.picTankL.ErrorImage = null;
            this.picTankL.Image = global::p_snake.Properties.Resources.tankL;
            this.picTankL.Location = new System.Drawing.Point(111, 265);
            this.picTankL.Name = "picTankL";
            this.picTankL.Size = new System.Drawing.Size(80, 74);
            this.picTankL.TabIndex = 3;
            this.picTankL.TabStop = false;
            // 
            // picTank
            // 
            this.picTank.Location = new System.Drawing.Point(323, 184);
            this.picTank.Name = "picTank";
            this.picTank.Size = new System.Drawing.Size(100, 50);
            this.picTank.TabIndex = 2;
            this.picTank.TabStop = false;
            // 
            // picTankD
            // 
            this.picTankD.ErrorImage = null;
            this.picTankD.Image = global::p_snake.Properties.Resources.tankD;
            this.picTankD.Location = new System.Drawing.Point(531, 99);
            this.picTankD.Name = "picTankD";
            this.picTankD.Size = new System.Drawing.Size(67, 80);
            this.picTankD.TabIndex = 1;
            this.picTankD.TabStop = false;
            // 
            // picTankU
            // 
            this.picTankU.ErrorImage = global::p_snake.Properties.Resources.tankU;
            this.picTankU.Image = global::p_snake.Properties.Resources.tankU;
            this.picTankU.Location = new System.Drawing.Point(111, 99);
            this.picTankU.Name = "picTankU";
            this.picTankU.Size = new System.Drawing.Size(71, 80);
            this.picTankU.TabIndex = 0;
            this.picTankU.TabStop = false;
            // 
            // Tank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 828);
            this.Controls.Add(this.picTank2_R);
            this.Controls.Add(this.picTank2_L);
            this.Controls.Add(this.picTank2_D);
            this.Controls.Add(this.picTank2_U);
            this.Controls.Add(this.picTank2);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picTankR);
            this.Controls.Add(this.picTankL);
            this.Controls.Add(this.picTank);
            this.Controls.Add(this.picTankD);
            this.Controls.Add(this.picTankU);
            this.Name = "Tank";
            this.Text = "Tank";
            this.Load += new System.EventHandler(this.Tank_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_2);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTank2_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank2_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank2_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank2_U)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTankU;
        private System.Windows.Forms.PictureBox picTankD;
        private System.Windows.Forms.PictureBox picTank;
        private System.Windows.Forms.PictureBox picTankL;
        private System.Windows.Forms.PictureBox picTankR;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picTank2;
        private System.Windows.Forms.PictureBox picTank2_U;
        private System.Windows.Forms.PictureBox picTank2_D;
        private System.Windows.Forms.PictureBox picTank2_L;
        private System.Windows.Forms.PictureBox picTank2_R;
    }
}