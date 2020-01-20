using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consolewhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, i = 0;
            Console.WriteLine(" =求 1 到 100 可以被 n 整除的整數=");
            Console.WriteLine();
            Console.Write(" 請輸入 1 到 100 的整數 n：");
            n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 100)
            {
                while (sum + n <= 100)
                {
                    sum += n;
                    Console.Write(" {0},", sum.ToString ());
                    i += 1;
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(); // 跳下一行
                    }
                }
                Console.WriteLine();
                Console.WriteLine(" 由 1 到 100 有 {0} 個整數可以被 {1} 整除 ! ", i, n.ToString ());
            }
            else  // 若 n 未介於1~100之間則執行下面敘述
            {
                Console.WriteLine("輸入的資料錯誤!@_@");
            }
            Console.ReadLine();
        }
    }
}
