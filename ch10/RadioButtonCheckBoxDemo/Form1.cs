using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioButtonCheckBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbXBox360.Checked = true;  // 預設XBox 360選項鈕被選取
        }
        // 按 XBox 360 選項鈕執行
        private void rdbXBox360_CheckedChanged(object sender, EventArgs e)
        {
            chkXBox360_1.Enabled = true;  // 忍者外傳核取方塊不失效
            chkXBox360_2.Enabled = true; // 生死格鬥核取方塊不失效
            chkXBox360_3.Enabled = true;// 大聯盟核取方塊不失效
            chkPS3_1.Enabled = false;// 火影忍者核取方塊失效
            chkPS3_2.Enabled = false;// 航海王核取方塊失效
            chkPS3_3.Enabled = false;// 瑪麗歐賽車核取方塊失效
        }
        // 按 PS3 選項鈕執行
        private void rdbPS3_CheckedChanged(object sender, EventArgs e)
        {
            chkXBox360_1.Enabled = false;
            chkXBox360_2.Enabled = false;
            chkXBox360_3.Enabled = false;
            chkPS3_1.Enabled = true;
            chkPS3_2.Enabled = true;
            chkPS3_3.Enabled = true;
        }
        // 按 [確定] 鈕執行
        private void btnOk_Click(object sender, EventArgs e)
        {
            string str = "謝謝您購買" ;
            if (rdbXBox360.Checked)   // 判斷XBox 360是否被選取
            {
                str += rdbXBox360.Text + "\n";
                if (chkXBox360_1.Checked)  // 判斷忍者外傳是否被勾選
                {
                    str += chkXBox360_1.Text + ", ";
                }
                if (chkXBox360_2.Checked)   // 判斷生死格鬥是否被勾選
                {
                    str += chkXBox360_2.Text + ", ";
                }
                if (chkXBox360_3.Checked)   // 判斷大聯盟是否被勾選
                {
                    str += chkXBox360_3.Text + ", ";
                }
            }
            else if (rdbPS3.Checked)  // 判斷PS 3 是否被選取
            {
                str += rdbPS3.Text + "\n";
                if (chkPS3_1.Checked)   // 判斷火影忍者是否被勾選
                {
                    str += chkPS3_1.Text + ", ";
                }
                if (chkPS3_2.Checked)   // 判斷航海王是否被勾選
                {
                    str += chkPS3_2.Text + ", ";
                }
                if (chkPS3_3.Checked)   //  判斷瑪麗歐賽車是否被勾選
                {
                    str += chkPS3_3.Text + ", ";
                }
            }
            // 出現對話方塊顯示使用者所選購的主機及遊戲
            MessageBox.Show(str);  
        }
    }
}
