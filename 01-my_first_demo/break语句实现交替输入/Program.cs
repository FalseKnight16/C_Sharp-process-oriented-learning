using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break语句实现交替输入
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 1;
            while (i <= 10)
            {
                while (j <= 10)
                {
                    Console.WriteLine("我是里层的循环");
                    j++;
                    break;
                }
                Console.WriteLine("我是外层的循环");
                i++;

                Console.ReadKey();
            }
        }
    }
}
