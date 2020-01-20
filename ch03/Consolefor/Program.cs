using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consolefor
{
    class Program
    {
        static void Main(string[] args)
        {
            string pwd = ""; // 宣告pwd密碼變數為字串型別
            int count = 0;     // 宣告count變數為整數型別，用來記錄輸入密碼次數
            // for 迴圈初值count=1, 每次執行迴圈主體後count會加1
            // 若count 大於等於3時，即會離開for迴圈，因此下列for 會執行3次
            for (count = 1; count <= 3; count++)
            {
                Console.Write("請輸入密碼(四個字元):");
                // 使用者由鍵盤輸入密碼後，將密碼指定給pwd變數
                pwd = Console.ReadLine();
                if (pwd == "ymca")  // 判斷pwd密碼是否等於 "ymca"
                {
                    break;       // 離開 for 迴圈
                }
                else         // 若pwd密碼不等於 "pwd" 則執行下列敘述
                {
                    Console.WriteLine("密碼錯誤 , 無法進入!");
                }
                Console.WriteLine();
            }
            if (pwd == "ymca")    // 判斷pwd密碼是否等於 "ymac"
            {
                // 密碼正確執行此敘述
                Console.WriteLine("登入成功 , 歡迎進入本系統….");
            }
            else
            {
                // 密碼不正確執行此敘述
                Console.WriteLine("非法進入....!");
            }
            Console.Read();
        }
    }
}