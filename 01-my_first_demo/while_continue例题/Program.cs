using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//计算1-100除了能被7整除的数的和
//找出100所有的素数
namespace while_continue例题
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.计算1-100除了能被7整除的数的和
            //int i = 1;
            //int sum = 0;
            //while (i <= 100) {
            //    if (i % 7 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("sum={0}", sum);
            //Console.ReadKey();
            //2.找出100所有的素数
            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    //除尽了说明不是质数 也就没有再往下继续取余的必要了
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
