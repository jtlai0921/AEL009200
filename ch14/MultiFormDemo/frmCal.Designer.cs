namespace MultiFormDemo
{
    partial class frmCal
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
            this.rdbYear = new System.Windows.Forms.RadioButton();
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdbYear
            // 
            this.rdbYear.AutoSize = true;
            this.rdbYear.Checked = true;
            this.rdbYear.Location = new System.Drawing.Point(68, 34);
            this.rdbYear.Name = "rdbYear";
            this.rdbYear.Size = new System.Drawing.Size(88, 19);
            this.rdbYear.TabIndex = 0;
            this.rdbYear.TabStop = true;
            this.rdbYear.Text = "每年計息";
            this.rdbYear.UseVisualStyleBackColor = true;
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.rdbMonth.Location = new System.Drawing.Point(68, 78);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(88, 19);
            this.rdbMonth.TabIndex = 1;
            this.rdbMonth.TabStop = true;
            this.rdbMonth.Text = "每月計息";
            this.rdbMonth.UseVisualStyleBackColor = true;
            // 
            // frmCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 136);
            this.Controls.Add(this.rdbMonth);
            this.Controls.Add(this.rdbYear);
            this.Name = "frmCal";
            this.Text = "選擇計息方式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbYear;
        private System.Windows.Forms.RadioButton rdbMonth;
    }
}

