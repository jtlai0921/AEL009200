using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabControlDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 定義Employee員工類別
        class Employee
        {
            public string EmpID { get; set; }        // 編號屬性
            public string EmpName { get; set; } // 姓名屬性
            public string EmpSex { get; set; }     // 性別屬性
            public bool EmpIsMarry { get; set; }  // 婚姻屬性
        }

        int n;  // 宣告n用來記錄目前新增第幾位員工 
        Employee[] emp = new Employee[100];// 宣告 emp[0]~emp[99]共100位員工

        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            txtShow.Dock = DockStyle.Fill;      // txtShow文字方塊填滿整個標籤頁
            // txtShow 字型大小11
            txtShow.Font = new Font(txtShow.Font.FontFamily, 11, FontStyle.Regular);
            txtShow.ReadOnly = true;
            txtShow.Multiline = true;
            rdbF.Checked = true;    // 女預設選取
            n = 0;  // n 預設為0，0表示第1位員工
        }
        // 按新增鈕執行
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                emp[n] = new Employee();        // 建立第 n 位員工
                emp[n].EmpID = txtEmpId.Text;   // 指定第 n 位員工的編號
                emp[n].EmpName = txtName.Text;  // 指定第 n 位員工的姓名
                // 判斷男選項鈕是否被選取, 並指定第 n 位員工的性別
                if (rdbM.Checked)   
                {
                    emp[n].EmpSex = "先生";
                }
                else
                {
                    emp[n].EmpSex = "小姐";
                }
                emp[n].EmpIsMarry = chkIsMarry.Checked; // 指定第 n 位員工的婚姻
                n++;        // 移到下一筆
                MessageBox.Show("員工新增成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("員工新增失敗");
            }
            finally
            {
                // 還原預設值
                txtEmpId.Text = "";
                txtName.Text = "";
                rdbF.Checked = true;
                chkIsMarry.Checked = false;
            }
        }
        // 切換標籤頁時執行
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) // 判斷是否切換到「會員列表」標籤頁
            {
                // 在txtShow文字方塊內顯示已新增的員工資料
                txtShow.Text = "編號\t姓名\t性別\t是否已婚" +Environment.NewLine;
                txtShow.Text += "============================" + Environment.NewLine;
                for (int i = 0; i < n; i++)
                {
                    txtShow.Text += emp[i].EmpID + "\t" + emp[i].EmpName + " \t" + emp[i].EmpSex + "\t" + emp[i].EmpIsMarry.ToString() + Environment.NewLine;
                }
            }
        }
    }
}
