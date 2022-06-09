using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算两个值的最大值
            Console.WriteLine("请输入第一个数字:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字:");
            int n2 = int.Parse(Console.ReadLine());
            int max = n1 > n2 ? n1 : n2;
            Console.WriteLine("max={0}", max);
            Console.ReadKey();
        }
    }
}
