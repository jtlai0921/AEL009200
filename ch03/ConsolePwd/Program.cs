using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsolePwd
{
    class Program
    {
        static void Main(string[] args)
        {
            // 宣告Pwd密碼及Uid帳號字串變數
            string Pwd, Uid;
            Console.Write("請輸入帳號 :");
            Uid = Console.ReadLine();        // 輸入的資料指定給Uid變數
            Console.Write("請輸入密碼 :");
            Pwd = Console.ReadLine();   // 輸入的資料指定給Pwd變數
            Console.WriteLine();
            // 判斷Uid是否等於 "gotop" 且 Pwd是否等於 "5168"
            if (Uid == "gotop" && Pwd == "5168")
            {
                Console.WriteLine("Pass...");  // 帳號密碼正確執行此敘述
            }
            else
            {
                Console.WriteLine("Fail..."); // 帳號密碼錯誤執行此敘述
            }
            Console.Read();  // 等待由鍵盤輸入資料，以方便觀看執行結果
        }
    }
}
