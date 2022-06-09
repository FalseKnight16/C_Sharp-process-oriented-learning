using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int[] nums1 = { 1, 2, 3, 4, 5, 6 };
            int[] nums2 = new int[3] { 1, 2, 3 };
            for(int i = 0; i <= 9; i++)
            {
                nums[i] = i;
                Console.WriteLine(nums[i]);
                Console.ReadKey();
            }
        }
    }
}
