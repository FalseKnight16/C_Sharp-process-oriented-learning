using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//水仙花数为 百位的立方+十位的立方+各位的立方==这个百位数字
//水仙花数是指一个 3 位数，它的每个位上的数字的 3次幂之和等于它本身。例如：1^3 + 5^3+ 3^3 = 153。
//题目找出所有水仙花数
//153为例
//个位为153%10
//十位为153%100/10
//百位为153/100
namespace 找水仙花数
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100; i <= 999; i++)
            {
                double GeWei = Math.Pow(i%10, 3);
                double ShiWei = Math.Pow(i % 100 / 10, 3);
                double BaiWei = Math.Pow(i / 100, 3);//Math.Pow,求次方
                if (GeWei+ShiWei+BaiWei==i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
