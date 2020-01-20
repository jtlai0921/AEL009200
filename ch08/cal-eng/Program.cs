using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 using System.IO ;

namespace cal_eng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個檔案路徑：");
            string fname = Console.ReadLine();
            FileInfo f = new FileInfo(fname);
            StreamReader sr;
            try
            {
                sr = f.OpenText();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
            int[] letter = new int[26];
            int k;
            char ch;
            while (sr.Peek() >= 0)
            {
                ch = (char)sr.Read();
                if (ch >= 'A' && ch <= 'Z')
                {
                    k = (int)ch - 65;
                    letter[k]++;
                }
                else if (ch >= 'a' && ch <= 'z')
                {
                    k = (int)ch - 97;
                    letter[k]++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("該檔英文字母出現的字數如下...");
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("{0}, {1}, {2}個",
                (char)(65 + i), (char)(97 + i), letter[i]);
            }
            sr.Close();
            Console.ReadLine();
        }
    }
}
