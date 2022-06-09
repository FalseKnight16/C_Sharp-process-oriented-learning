using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工资评定
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            Console.WriteLine("请输入XX的年终奖评定结果(A/B/C/D/E)：");
            string level = Console.ReadLine();
            switch (level)
            {
                case "A":salary += 500;
                    break;
                case "B":salary += 200;
                    break;
                case "C":salary -= 200;
                    break;
                case "D":salary -= 500;
                    break;
                default:Console.WriteLine("输入错误，程序退出");
                    break;
            }
            Console.WriteLine("XXX的第二年的工资为{0}", salary);
            Console.ReadLine();
        }
    }
}
