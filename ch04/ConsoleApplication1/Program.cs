using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private void MyMethod(string str)
        {
            string name = "蔡小龍";	//區域變數name
            name += str;			//區域變數str
            int k;					//區域變數k
            for (int i = 1; i <= 6; i++)//區塊變數i
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(i) ;
        }

        static void Main(string[] args)
        {

        }
    }
}
