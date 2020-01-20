using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxComboBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 定義Member類別，此類別建立的物件可用來存放會員資料
        class Member
        {
            public string Name { get; set; }                // 姓名屬性
            public DateTime BirthdDay { get; set; }  // 生日屬性
            public string Sex { get; set; }                   // 性別屬性
            public string Job { get; set; }                   // 職業屬性
        }

        // 宣告Member類別的物件陣列m
        // 物件陣列元素為m[0]~m[99]，用來存放100位會員;
        Member[] m = new Member[100];
        int n = 0;  // n用來表示目前是第幾位會員, 0表示第1位會員
 
        // 表單載入時執行
        private void Form1_Load(object sender, EventArgs e)
        {
            // 年下拉式清單預設值100年前
            cboYear.Text = (DateTime.Now.Year - 100).ToString();
            cboMonth.Text = "1"; // 月下拉式清單預設值1
            cboDay.Text = "1";      // 日下拉式清單預設值 1
            // 年下拉式清單的範圍100年前~今年
            for (int i = DateTime.Now.Year - 100; i <= DateTime.Now.Year; i++)
            {
                cboYear.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++) // 月下拉式清單的範圍是1-12
            {
                cboMonth.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 31; i++) // 日下拉式清單的範圍是1-31
            {
                cboDay.Items.Add(i.ToString());
            }
            rdbM.Checked = true;  // 男選項鈕預設被選取
            // 建立Job字串陣列用來存放職業
            String[] Job = new String[] { "學生", "公教", "服務", "製造", "家管", "其它" };
            lstJob.Items.AddRange(Job); // lstJob清單放入Job陣列內容
            lstJob.SelectedIndex = 0;       // lstJob清單預設第1個選項被選取
        }
        // 按新增鈕執行
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboName.Text == "")  // 檢查姓名是否為空字串
            {
                MessageBox.Show("請輸入姓名");
                return;   // 離開此事件處理函式
            }
            // 宣告find布林變數，若此變數為true，表示m會員物件陣列內有該位會員
            bool find = false;     // 預設為false，表示m會員物件陣列沒有該位會員
            // 使用循序搜尋法查詢目前姓名下式清單中的值是否在m會員物件陣列內
            for (int i = 0; i < n; i++)
            {
                if (m[i].Name == cboName.Text)
                {
                    find = true;  // 如果有找到，則find設為true;
                    break;
                }
            }
            if (find)
            {
                MessageBox.Show("資料已存在!");
                return; // 離開此事件處理函式
            }
            else
            {
                // 建立日期物件用來存放會員的生日
                DateTime myBirthDay = new DateTime();  
                try   // 使用例外處理補捉輸入生日可能會發生的例外
                {
                    myBirthDay = DateTime.Parse(cboYear.Text + "/" + cboMonth.Text + "/" + cboDay.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("生日有誤");
                    return;  // 如果生日有誤即離開此事件處理函式
                }
                // 將姓名下拉式清單所輸入的值放入下拉式清單的選項內
                cboName.Items.Add(cboName.Text);
                m[n] = new Member();  // 建立第 n 位會員，即m[n]陣列元素
                // 逐一設定第n位會員的姓名, 生日, 性別, 職業
                m[n].Name = cboName.Text;
                m[n].BirthdDay = myBirthDay ;
                m[n].Sex = rdbM.Checked ? "男" : "女";
                m[n].Job = lstJob.SelectedItem.ToString();
                n++; // 移到下一筆
                MessageBox.Show("會員新增成功");
            }
        }
        // 姓名下拉式清單被選取時執行
        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 取得姓名下拉式清單的索引值，該索引值即代表m陣列中的某筆會員
            int index = cboName.SelectedIndex;  
            // 透過取得的索引值，將該筆會員相關資料顯示在表單的各控制項上
            cboYear.Text = m[index].BirthdDay .Year .ToString ();
            cboMonth.Text = m[index].BirthdDay.Month.ToString();
            cboDay.Text = m[index].BirthdDay.Day.ToString();
            if (m[index].Sex == "男")
            {
                rdbM.Checked = true;
            }
            else
            {
                rdbF.Checked = true;
            }
            int JobIndex = lstJob.FindString(m[index].Job);
            lstJob.SelectedIndex = JobIndex;
        }
        // 按結束鈕執行
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
