using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GroupBoxDemo
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
            gbXBox360.Enabled = true;   // XBox 360 遊戲群組方塊不失效，可啟用
            gbPS3.Enabled = false;    //  PS 3遊戲群組方塊失效
        } 
        // 按 PS3 選項鈕執行
        private void rdbPS3_CheckedChanged(object sender, EventArgs e)
        {
            gbXBox360.Enabled = false ;
            gbPS3.Enabled = true ;
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
