using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1.求1-100的所有整数的和
/// 2.求1-100的所有偶数的和
/// </summary>
namespace 循环的习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //题目1
            #region
            int i = 1;
            int sum = 0;
            while (i <= 100)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("sum={0}", sum);
            Console.ReadKey();
            #endregion
            //题目2
            #region
            int n = 1;
            int sum_1 = 0;
            while (n <= 100)
            {
                if (n%2==0)
                sum_1 += n;
                n++;
            }
            Console.WriteLine("sum_1={0}", sum_1);
            Console.ReadKey();
            #endregion
            //求奇数
            #region
            int n1 = 1;
            int sum_2 = 0;
            while (n1 <= 100)
            {
                if (n1 % 2 != 0)
                    sum_2 += n1;
                n1++;
            }
            Console.WriteLine("sum_2={0}", sum_2);
            Console.ReadKey();
            #endregion
        }
    }
}
