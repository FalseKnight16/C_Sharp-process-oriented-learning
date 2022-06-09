using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 产生随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 3);//产生1-2的随机数
            //while (true)
            //{
            //    //产生随机数
            //    //1.创建能够产生随机数的对象
            //    //2.让产生随机数的这个对象调用方法来产生随机数
            //    int rNumber = r.Next(1, 11);//产生1-10的随机数
            //    Console.WriteLine(rNumber);
            //    Console.ReadKey();
            //}
            Console.WriteLine("请输入名字:");
            string name = Console.ReadLine();
            switch (rNumber)
            {
                case 1: Console.WriteLine("{0}能考上研究生", name);
                    break;
                case 2: Console.WriteLine("{0}不能考上研究生", name);
                    break;
            }
            Console.ReadKey();
        }
    }
}
