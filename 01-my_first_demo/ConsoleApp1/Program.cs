using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您的姓名:");
            string name = Console.ReadLine();
            Console.WriteLine("您的姓名是{0}", name);
            Console.ReadKey();
            int number = 10;
            int result = 10 + ++number;
            Console.WriteLine("number={0}\nresult={1}", number, result);
            Console.ReadKey();
            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;
            Console.WriteLine("a={0},b={1}", a, b);
            Console.ReadKey();
        }
    }
}
