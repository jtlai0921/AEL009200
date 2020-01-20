namespace PictureBoxDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPhotoName = new System.Windows.Forms.ComboBox();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "圖片名稱";
            // 
            // cboPhotoName
            // 
            this.cboPhotoName.FormattingEnabled = true;
            this.cboPhotoName.Location = new System.Drawing.Point(99, 21);
            this.cboPhotoName.Name = "cboPhotoName";
            this.cboPhotoName.Size = new System.Drawing.Size(139, 23);
            this.cboPhotoName.TabIndex = 1;
            this.cboPhotoName.SelectedIndexChanged += new System.EventHandler(this.cboPhotoName_SelectedIndexChanged);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(29, 65);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(209, 152);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 246);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.cboPhotoName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPhotoName;
        private System.Windows.Forms.PictureBox pic;
    }
}

