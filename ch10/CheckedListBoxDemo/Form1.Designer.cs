﻿namespace CheckedListBoxDemo
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
            this.chkListLot = new System.Windows.Forms.CheckedListBox();
            this.btnCheckLot = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnCls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "大樂透-請選擇6個號碼";
            // 
            // chkListLot
            // 
            this.chkListLot.FormattingEnabled = true;
            this.chkListLot.Location = new System.Drawing.Point(21, 50);
            this.chkListLot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkListLot.Name = "chkListLot";
            this.chkListLot.Size = new System.Drawing.Size(197, 106);
            this.chkListLot.TabIndex = 1;
            // 
            // btnCheckLot
            // 
            this.btnCheckLot.Location = new System.Drawing.Point(21, 235);
            this.btnCheckLot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckLot.Name = "btnCheckLot";
            this.btnCheckLot.Size = new System.Drawing.Size(56, 25);
            this.btnCheckLot.TabIndex = 2;
            this.btnCheckLot.Text = "對獎";
            this.btnCheckLot.UseVisualStyleBackColor = true;
            this.btnCheckLot.Click += new System.EventHandler(this.btnCheckLot_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(160, 235);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(56, 25);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(21, 178);
            this.lblShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(196, 47);
            this.lblShow.TabIndex = 4;
            this.lblShow.Text = "lblShow";
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(92, 235);
            this.btnCls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(56, 25);
            this.btnCls.TabIndex = 5;
            this.btnCls.Text = "清除";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 271);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnCheckLot);
            this.Controls.Add(this.chkListLot);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListLot;
        private System.Windows.Forms.Button btnCheckLot;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnCls;
    }
}
