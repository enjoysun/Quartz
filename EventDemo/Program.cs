using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    //public delegate string Getmsg(string word);
    class Program
    {
        static void Main(string[] args)
        {
            //委托回忆
            //string str = null;
            //Getmsg g = new Getmsg(c =>
            //{
            //    return c;
            //});
            //str = g("a");
            //g += new Getmsg(c =>
            //{
            //    return c + "哈哈";
            //});
            //str = str + g("嘻嘻");
            //Console.WriteLine(str);



            //事件加深
            Filewatch w = new Filewatch();
            w.filewatchenevt += new FilewatchEnvetHandle(Xiaoming.Recive);
            w.monitorfile("订阅了zzz");
            Console.ReadKey();
        }

    }
    public class Xiaoming
    {
        public static void Recive(object sender, PubEventArg e)
        {
            Console.WriteLine("感兴趣的订阅：" + e.Bookname);
        }
    }
}
