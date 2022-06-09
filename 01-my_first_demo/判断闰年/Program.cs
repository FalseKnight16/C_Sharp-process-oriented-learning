using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number == 1)
            {
                Console.WriteLine("请输入年份：");
                string str = Console.ReadLine();
                try
                {
                    int year = Convert.ToInt32(str);
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        Console.WriteLine("{0}是闰年", year);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("{0}不是闰年", year);
                        Console.ReadKey();
                    }
                }
                catch
                {
                    Console.WriteLine("输入的字符不合格");
                }
                try
                {
                    Console.WriteLine("请输入数字，1表示继续，其他数字表示退出：");
                    string number1 = Console.ReadLine();
                    int number2 = Convert.ToInt32(number1);
                    number = number2;
                }
                catch
                {
                    Console.WriteLine("输入的非数字，请重新输入:");
                }
            }
        }
    }
}
