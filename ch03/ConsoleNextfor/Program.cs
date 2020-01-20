using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleNextfor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k;   // 宣告 i 為外層迴圈的初值，k 為內層迴圈的初值
            for (i = 1; i <= 5; i++)  // 外層迴圈
            {
                for (k = 1; k <= i; k++)  // 內層迴圈
                {
                    Console.Write("  {0}", k); // 游標停在同一列     
                }
                Console.WriteLine();		 // 強迫換列
            }
            Console.Read();
        }
    }
}
