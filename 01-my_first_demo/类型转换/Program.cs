using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.下面两种转换成功就成功了,转换失败会抛出异常
            int number = int.Parse("123");
            int numberone = Convert.ToInt32("123");
            //2.TryParse,如果转换成功了就给numbertwo赋值,给a赋值为true.转换失败了numbertwo保留原有值,给a赋值为false
            //TryParse是一个方法,把字符串转换为了int类型
            int numbertwo = 0;
            bool a = int.TryParse("123abc", out numbertwo);
            Console.WriteLine(a);
            Console.WriteLine(numbertwo);
            Console.ReadKey();

        }
    }
}
