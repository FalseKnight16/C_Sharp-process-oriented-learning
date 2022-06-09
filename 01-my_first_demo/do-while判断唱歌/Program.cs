using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while判断唱歌
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("我唱的好吗?(y/n)");
                answer = Console.ReadLine();
            } while (answer == "n");
        }
    }
}
