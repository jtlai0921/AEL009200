using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadOnlyProperty
{
    class Car       // 定義Car類別
    {
        private int _angle = 10; // 私有_angle變數初值為10
        public int Angle    	// 定義Angle唯讀屬性
        {
            get
            {
                return _angle;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Benz = new Car();
            Console.WriteLine(Benz.Angle);  // Angle只能讀不能寫
            Console.Read();
        }
    }
}

