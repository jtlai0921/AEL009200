using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inherits_1
{
    class Employee   // 定義Employee員工類別
    {
        private int _salary;   	// Employee員工類別有Salary薪水屬性
        public int Salary       	// 薪水介於20000~40000之間
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 20000) 		// 薪水最少20000
                    _salary = 20000;
                else if (value > 40000)	// 薪水最多40000
                    _salary = 40000;
                else
                    _salary = value;
            }
        }
    }
    //Manager經理類別繼承自Employee員工類別
    class Manager : Employee
    {

        public int Bonus { get; set; }     	// 加入Bonus獎金屬性
        public void ShowTotal()   	// 加入顯示實領獎金方法
        {
            Console.WriteLine("實領薪水：{0}", Bonus + Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Employee();// 建立Employee員工類別的tom物件
            tom.Salary = 50000;      	        // 設定薪水
            Console.WriteLine("tom員工薪水{0}", tom.Salary); // 顯示薪水
            Console.WriteLine("================");
            Console.WriteLine();
            Manager peter = new Manager(); // 建立Manager經理類別peter物件
            peter.Salary = 50000;    	 // 設定薪水
            Console.WriteLine("peter經理薪水{0}", peter.Salary);// 顯示薪水
            peter.Bonus = 30000;  	      // 設定peter的獎金30000
            Console.WriteLine("peter經理獎金{0}", peter.Bonus);// 顯示獎金
            peter.ShowTotal();      	      // 顯示peter實領薪水
            Console.Read();
        }
    }
}
