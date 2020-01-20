namespace KeyDownKeyUpDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.picTankR = new System.Windows.Forms.PictureBox();
            this.picTankL = new System.Windows.Forms.PictureBox();
            this.picTankD = new System.Windows.Forms.PictureBox();
            this.picTankU = new System.Windows.Forms.PictureBox();
            this.picTank = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(37, 215);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(41, 15);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "label1";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(37, 243);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(41, 15);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "label2";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(37, 273);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(41, 15);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "label3";
            // 
            // picTankR
            // 
            this.picTankR.Image = global::KeyDownKeyUpDemo.Properties.Resources.tankR;
            this.picTankR.Location = new System.Drawing.Point(265, 106);
            this.picTankR.Name = "picTankR";
            this.picTankR.Size = new System.Drawing.Size(71, 67);
            this.picTankR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankR.TabIndex = 6;
            this.picTankR.TabStop = false;
            // 
            // picTankL
            // 
            this.picTankL.Image = global::KeyDownKeyUpDemo.Properties.Resources.tankL;
            this.picTankL.Location = new System.Drawing.Point(260, 21);
            this.picTankL.Name = "picTankL";
            this.picTankL.Size = new System.Drawing.Size(76, 64);
            this.picTankL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankL.TabIndex = 5;
            this.picTankL.TabStop = false;
            // 
            // picTankD
            // 
            this.picTankD.Image = global::KeyDownKeyUpDemo.Properties.Resources.tankD;
            this.picTankD.Location = new System.Drawing.Point(13, 106);
            this.picTankD.Name = "picTankD";
            this.picTankD.Size = new System.Drawing.Size(65, 71);
            this.picTankD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankD.TabIndex = 4;
            this.picTankD.TabStop = false;
            // 
            // picTankU
            // 
            this.picTankU.Image = global::KeyDownKeyUpDemo.Properties.Resources.tankU;
            this.picTankU.Location = new System.Drawing.Point(12, 12);
            this.picTankU.Name = "picTankU";
            this.picTankU.Size = new System.Drawing.Size(66, 73);
            this.picTankU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTankU.TabIndex = 3;
            this.picTankU.TabStop = false;
            // 
            // picTank
            // 
            this.picTank.Location = new System.Drawing.Point(236, 226);
            this.picTank.Name = "picTank";
            this.picTank.Size = new System.Drawing.Size(100, 50);
            this.picTank.TabIndex = 7;
            this.picTank.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 318);
            this.Controls.Add(this.picTank);
            this.Controls.Add(this.picTankR);
            this.Controls.Add(this.picTankL);
            this.Controls.Add(this.picTankD);
            this.Controls.Add(this.picTankU);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picTankU;
        private System.Windows.Forms.PictureBox picTankD;
        private System.Windows.Forms.PictureBox picTankL;
        private System.Windows.Forms.PictureBox picTankR;
        private System.Windows.Forms.PictureBox picTank;
    }
}

