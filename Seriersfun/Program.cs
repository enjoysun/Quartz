using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seriersfun
{
    class Program
    {
        static void Main(string[] args)
        {
            //串联构造函数this，最终执行参数最多的构造函数，覆盖实例化所传的参数
            Person p1 = new Person();
            int? i = p1.Age;
            string str = p1.Name;
            Person p2 = new Person(15);
            int? i1 = p2.Age;
            string str1 = p2.Name;
            Person p3 = new Person("幽香");
            int? i2= p3.Age;
            string str2 = p3.Name;
            Person p4 = new Person(12,"小孩");
            int? i3 = p4.Age;
            string str3 = p4.Name;
            Console.ReadKey();

        }
    }
}
