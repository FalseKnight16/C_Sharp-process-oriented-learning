using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//账号:admin
//密码:8888888
//判断登录
namespace 循环体判断登录
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            string userPwd = "";
            int i = 1;
            while((userName !="admin" || userPwd != "8888888")&& i<=3)
            {
                Console.WriteLine("请输入用户名:");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码:");
                userPwd = Console.ReadLine();          
                    if (userName != "admin" || userPwd != "8888888")
                    {
                        Console.WriteLine("登录失败");
                    }
                i++;
            }
            if (i >=4 && (userName != "admin" || userPwd != "8888888"))
            {
                Console.WriteLine("失败超过三次,锁定账号");
            }
            else if (i <= 4 && (userName == "admin" || userPwd == "8888888"))
            {
                Console.WriteLine("登录成功");
            }
         
            Console.ReadKey();
        }
    }
}
