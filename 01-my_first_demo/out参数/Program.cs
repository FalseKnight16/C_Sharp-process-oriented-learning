using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 1.写个方法，求一个数组中的最大值，最小值，总和，平均值
/// </summary>
namespace out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] result=Program.GetMaxMinSumAvg(nums);
            //Console.WriteLine("最大值={0}\n最小值={1}\n总和={2}n平均数={3}", result[0], result[1], result[2], result[3]);
            int max = 0;
            int min = 0;
            int sum = 0;
            int avg = 0;
            Test(nums,out max,out min,out sum,out avg);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadKey();
        }




        //public static int[] GetMaxMinSumAvg(int [] nums)
        //{
        //    int[] res = new int[4];
        //    //res[0]为最大值，res[1]为最小值，res[2]为总和，res[3]为平均值
        //    res[0] = nums[0];
        //    res[1] = nums[0];
        //    res[2] = 0;
        //          for(int i = 0; i<nums.Length; i++)
        //            {
        //                if (nums[i] > res[0])
        //                {
        //                    //循环找到最大值
        //                    res[0] = nums[i];
        //                }
        //                if (nums[i] < res[1])
        //                { 
        //                    //循环找到最小值
        //                    res[1] = nums[i];
        //                }
        //res[2] += nums[i];//求和
        //            }
        //    res[3] = res[2] / nums.Length;//求平均值
        //    return res;
        //}


        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg)
        {
            //out参数必须要求在方法的内部为其赋值
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    //循环找到最大值
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    //循环找到最小值
                    min = nums[i];
                }
                sum += nums[i];//求和
            }
            avg = sum / nums.Length;//求平均数
        }
    }
}
