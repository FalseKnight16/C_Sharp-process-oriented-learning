using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    public enum Gender
    {
        男=100,
        女
    }
    public enum Sesons
    {
        春=0,
        夏,
        秋,
        冬
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //变量类型 变量名=值
            //int n = 10;
            Gender gender = Gender.男;
            //Sesons s = Sesons.冬;
            //枚举类型可以和int类型互相转换，枚举类型和int类型是兼容的
            int n1 = (int)gender;
            int n2 = 100;
            Gender n3 = (Gender)n2;
            Console.WriteLine(n1);
            Console.ReadKey();
            Console.WriteLine(n3);
            Console.ReadKey();
            //所有类型都可以转换为string类型
            string s1 = gender.ToString();
            Console.WriteLine(s1);
            Console.ReadKey();
            //将字符串转换为枚举类型
            //Parse()方法将一个字符串转化为相应的枚举类型 
            string s2 = "0";
            Sesons s3=(Sesons)Enum.Parse(typeof(Sesons), s2);
            Console.WriteLine(s3);
            Console.ReadKey();
            #endregion
        }
    }
}
