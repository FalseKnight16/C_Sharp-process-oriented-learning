using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public struct Person
{
    public string _name;//字段
    public int _age;
    public char _gender;
}
namespace 结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //字段可以存多个值，变量只能存一个值，在字段前加_进行区分
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 21;
            zsPerson._gender = '男';
        }
    }
}
