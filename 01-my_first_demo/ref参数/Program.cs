using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //利用方法来交换两个int类型的变量
            int n1 = 2;
            int n2 = 3;
            Text(ref n1, ref n2);
            Console.WriteLine("n1={0},n2={1}", n1, n2);
            Console.ReadKey();
        }
        public static  void Text(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
