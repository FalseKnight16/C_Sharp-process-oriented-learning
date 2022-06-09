using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引用命名空间 
namespace _01_my_first_demo //项目名称
{
    /// <summary>
    /// 这是一个类
    /// </summary>
    class Program//类
    {
        static void Main(string[] args)//方法或者函数，main函数是程序的主入口
        {
            #region
            Console.WriteLine("hello world");
            Console.WriteLine("this is my first program");
            Console.ReadKey();
            #endregion
            #region
            int w1 = 1;
            int w2 = 2;
            int w3 = 3;
            Console.WriteLine("第一个数字为{0}，第二个数字为{1}，第三个数字为{2}",w1,w2,w3);//占位符，挖几个坑就填几个坑
            Console.ReadKey();
            #endregion
            #region
            int t1 = 2;
            int t2 = 3;
            t1 = t1 - t2;
            t2 = t1 + t2;
            t1 = t2 - t1;
            Console.WriteLine("交换后，t1的值为{0}，t2的值为{1}", t1, t2);
            Console.ReadKey();
            #endregion
        }
    }
}
