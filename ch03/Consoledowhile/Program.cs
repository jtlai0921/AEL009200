using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consoledowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // 宣告yes字串變數用來存放使用者輸入的資料
            string yes = "";
            // 宣告count整數變數，用來記錄進入迴圈的次數
            int count = 0;
            do
            {
                count += 1;   // count加1
                Console.WriteLine("第 {0} 次進入迴圈", count);
                Console.Write("是否繼續 (Y/N) ?");
                // 將使用者由鍵盤輸入的資料放入yes變數
                yes = Console.ReadLine();
                Console.WriteLine();
            }
            // 若yes變數等於"y"或"Y"則進入迴圈
            while (yes == "y" || yes == "Y");
            Console.WriteLine("已離開迴圈 ! ");
            Console.Read();
        }
    }
}
