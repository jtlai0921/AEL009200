namespace RadioButtonCheckBoxDemo
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
            this.rdbXBox360 = new System.Windows.Forms.RadioButton();
            this.rdbPS3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkXBox360_1 = new System.Windows.Forms.CheckBox();
            this.chkXBox360_2 = new System.Windows.Forms.CheckBox();
            this.chkXBox360_3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPS3_1 = new System.Windows.Forms.CheckBox();
            this.chkPS3_2 = new System.Windows.Forms.CheckBox();
            this.chkPS3_3 = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbXBox360
            // 
            this.rdbXBox360.AutoSize = true;
            this.rdbXBox360.Location = new System.Drawing.Point(39, 44);
            this.rdbXBox360.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbXBox360.Name = "rdbXBox360";
            this.rdbXBox360.Size = new System.Drawing.Size(72, 16);
            this.rdbXBox360.TabIndex = 0;
            this.rdbXBox360.TabStop = true;
            this.rdbXBox360.Text = "XBox 360";
            this.rdbXBox360.UseVisualStyleBackColor = true;
            this.rdbXBox360.CheckedChanged += new System.EventHandler(this.rdbXBox360_CheckedChanged);
            // 
            // rdbPS3
            // 
            this.rdbPS3.AutoSize = true;
            this.rdbPS3.Location = new System.Drawing.Point(122, 44);
            this.rdbPS3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbPS3.Name = "rdbPS3";
            this.rdbPS3.Size = new System.Drawing.Size(44, 16);
            this.rdbPS3.TabIndex = 1;
            this.rdbPS3.TabStop = true;
            this.rdbPS3.Text = "PS 3";
            this.rdbPS3.UseVisualStyleBackColor = true;
            this.rdbPS3.CheckedChanged += new System.EventHandler(this.rdbPS3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "遊戲主機";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "XBox 360遊戲";
            // 
            // chkXBox360_1
            // 
            this.chkXBox360_1.AutoSize = true;
            this.chkXBox360_1.Location = new System.Drawing.Point(39, 113);
            this.chkXBox360_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkXBox360_1.Name = "chkXBox360_1";
            this.chkXBox360_1.Size = new System.Drawing.Size(72, 16);
            this.chkXBox360_1.TabIndex = 4;
            this.chkXBox360_1.Text = "忍者外傳";
            this.chkXBox360_1.UseVisualStyleBackColor = true;
            // 
            // chkXBox360_2
            // 
            this.chkXBox360_2.AutoSize = true;
            this.chkXBox360_2.Location = new System.Drawing.Point(122, 113);
            this.chkXBox360_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkXBox360_2.Name = "chkXBox360_2";
            this.chkXBox360_2.Size = new System.Drawing.Size(72, 16);
            this.chkXBox360_2.TabIndex = 4;
            this.chkXBox360_2.Text = "生死格鬥";
            this.chkXBox360_2.UseVisualStyleBackColor = true;
            // 
            // chkXBox360_3
            // 
            this.chkXBox360_3.AutoSize = true;
            this.chkXBox360_3.Location = new System.Drawing.Point(201, 113);
            this.chkXBox360_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkXBox360_3.Name = "chkXBox360_3";
            this.chkXBox360_3.Size = new System.Drawing.Size(60, 16);
            this.chkXBox360_3.TabIndex = 4;
            this.chkXBox360_3.Text = "大聯盟";
            this.chkXBox360_3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "PS 3遊戲";
            // 
            // chkPS3_1
            // 
            this.chkPS3_1.AutoSize = true;
            this.chkPS3_1.Location = new System.Drawing.Point(39, 178);
            this.chkPS3_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPS3_1.Name = "chkPS3_1";
            this.chkPS3_1.Size = new System.Drawing.Size(72, 16);
            this.chkPS3_1.TabIndex = 4;
            this.chkPS3_1.Text = "火影忍者";
            this.chkPS3_1.UseVisualStyleBackColor = true;
            // 
            // chkPS3_2
            // 
            this.chkPS3_2.AutoSize = true;
            this.chkPS3_2.Location = new System.Drawing.Point(122, 178);
            this.chkPS3_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPS3_2.Name = "chkPS3_2";
            this.chkPS3_2.Size = new System.Drawing.Size(60, 16);
            this.chkPS3_2.TabIndex = 4;
            this.chkPS3_2.Text = "航海王";
            this.chkPS3_2.UseVisualStyleBackColor = true;
            // 
            // chkPS3_3
            // 
            this.chkPS3_3.AutoSize = true;
            this.chkPS3_3.Location = new System.Drawing.Point(201, 178);
            this.chkPS3_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPS3_3.Name = "chkPS3_3";
            this.chkPS3_3.Size = new System.Drawing.Size(84, 16);
            this.chkPS3_3.TabIndex = 4;
            this.chkPS3_3.Text = "瑪麗毆賽車";
            this.chkPS3_3.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(223, 218);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 30);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 259);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkPS3_3);
            this.Controls.Add(this.chkPS3_2);
            this.Controls.Add(this.chkXBox360_3);
            this.Controls.Add(this.chkPS3_1);
            this.Controls.Add(this.chkXBox360_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkXBox360_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbPS3);
            this.Controls.Add(this.rdbXBox360);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbXBox360;
        private System.Windows.Forms.RadioButton rdbPS3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkXBox360_1;
        private System.Windows.Forms.CheckBox chkXBox360_2;
        private System.Windows.Forms.CheckBox chkXBox360_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPS3_1;
        private System.Windows.Forms.CheckBox chkPS3_2;
        private System.Windows.Forms.CheckBox chkPS3_3;
        private System.Windows.Forms.Button btnOk;

    }
}

