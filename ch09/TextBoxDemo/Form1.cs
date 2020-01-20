using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxDemo
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
            string[] address = new string[] { "台北市南港路三段52號7樓 7F", "台北市南港路二段12號7樓 7F", "台北市忠孝東路一段12號" };
            AutoCompleteStringCollection myAdd = new AutoCompleteStringCollection();
            myAdd.AddRange(address);
            txtAdd.AutoCompleteCustomSource = myAdd;
            txtAdd.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAdd.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPage.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPage.AutoCompleteSource = AutoCompleteSource.HistoryList;
        }
        // 按下 [確定] 時執行
        private void btnOk_Click(object sender, EventArgs e)
        {
           // MessageBox .Show ()方法可用來顯示對話方塊
           MessageBox.Show("公司：" + txtCompany.Text + "\n住址：" + txtAdd.Text + "\n網站：" + txtPage.Text) ;   
        }
    }
}
