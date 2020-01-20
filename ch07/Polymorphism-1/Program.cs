﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism_1
{
    class Employee  // 定義Employee員工類別
    {
        // _salary宣告為保護層級,此欄位可以在子類別中使用
        protected int _salary;
        // 宣告Salary薪水屬性為virtual，因此該屬性在子類別可被覆寫
        public virtual int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if ((value >= 20000) && (value <= 40000))
                {
                    _salary = value;
                }
                else
                {
                    _salary = 20000;
                }
            }
        }
    }
    class Manager : Employee  // Manager經理類別繼承自Employee員工類別
    {
        // 增加Bounds獎金屬性
        public int Bonus { get; set; }
        // Manager經理子類別覆寫Employee員工父類別Salary屬性
        public override int Salary
        {
            get
            {
                return _salary;   // 使用父類別的_salary
            }
            set
            {
                if ((value >= 30000) && (value <= 60000))
                {
                    _salary = value;
                }
                else
                {
                    _salary = 30000;
                }
            }
        }
        public void ShowTotal()
        {
            Console.WriteLine("實領薪水：{0}", Bonus + Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager peter = new Manager();
            peter.Salary = 70000;
            Console.WriteLine("peter經理薪水{0}", peter.Salary);
            peter.Bonus = 30000;
            Console.WriteLine("peter經理獎金{0}", peter.Bonus);
            peter.ShowTotal();
            Console.Read();
        }
    }
}
