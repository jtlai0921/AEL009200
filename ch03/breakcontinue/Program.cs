using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace breakcontinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, n = 0;
            Console.Write("請輸入1+2+...+n<=sum, sum值：");
            // 輸入上限值並轉成整數資料型別，接著再指定給input整數變數
            int input = int.Parse(Console.ReadLine());
            do
            {
                n += 1;
                if (sum <= input) //判斷sum是否小於等於輸入的上限值input
                {
                    sum += n;
                    continue;	        //跳到Loop While 處判斷n是否大於0
                }
                else
                {
                    sum -= n - 1;
                    break;	            //離開迴圈
                }
            } while (n > 0); // 若n>0則進入迴圈
            Console.WriteLine("1+2...+{0}等於{1}", n - 2, sum);
            Console.Read();
        }
    }
}
