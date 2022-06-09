using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_函数_
{
    class Program
    {
        public static int _number = 10;//全局变量

        static void Main(string[] args)
        {
           int max=Program.GetMax(5, 4);
            Console.WriteLine("max={0}", max);
            Console.WriteLine("_number={0}", _number);
            Console.ReadKey();

        }
        //方法：获取最大值
        public static int GetMax(int n1,int n2)
        {
            Console.WriteLine("_number={0}", _number);
            return n1 > n2 ? n1 : n2;
        }
    }
}
