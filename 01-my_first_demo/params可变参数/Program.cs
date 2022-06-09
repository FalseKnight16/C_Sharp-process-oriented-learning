using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //求任意整数类型的数组的和
            int s1=Program.GetSum(1, 2, 3, 4, 5, 6, 7);
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int s2 = Program.GetSum(nums);
            Console.WriteLine("s1={0}\ns2={1}", s1, s2);
            Console.ReadKey();
            
        }
        public static int GetSum(params int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
