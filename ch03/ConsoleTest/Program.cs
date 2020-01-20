﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("試問Visual Studio可開發下列哪種應用程式\n");
            Console.WriteLine("1.視窗程式   2.Web程式   3.裝置應用程式   4. 以上皆可\n");
            Console.Write("請作答：");
            // 宣告Ans字串變數用來存放使用者由鍵盤輸入的答案
            string Ans = Console.ReadLine();
            // 判斷Ans是否為1, 2, 3其中之一
            if (Ans == "1" || Ans == "2" || Ans == "3")
            {
                Console.WriteLine("答錯了, 正確答案是4");
            }
            else if (Ans == "4")        // 判斷Ans是否等於4
            {
                Console.WriteLine("答對了, 真不愧是 .NET 達人");
            }
            else               // 當Ans不等於1 ,2 ,3 4時執行下列敘述
            {
                Console.WriteLine("無此選項....");
            }
            Console.Read();
        }
    }
}