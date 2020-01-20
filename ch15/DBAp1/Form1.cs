using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBAp1
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
             // TODO: 這行程式碼會將資料載入 'ch15DBDataSet.產品資料' 資料表。
             // 您可以視需要進行移動或移除。
             this.產品資料TableAdapter.Fill(this.ch15DBDataSet.產品資料);
         }
         // 按下 [更新資料庫] 鈕執行
         private void btnUpdate_Click(object sender, EventArgs e)
         {
             // 將ch15DBDataSet.產品資料 記憶體修改後的內容一次寫回資料庫
             this.產品資料TableAdapter.Update(this.ch15DBDataSet.產品資料);
         }
         // 按下 [結束] 鈕執行 
         private void btnEnd_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }
    }
}
