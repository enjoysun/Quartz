using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatedemo
{
    //声明委托委托是一个类，它定义了方法的类型，使得可以将方法当作另一个方法的参数来进行传递，这种将方法动态地赋给参数的做法，可以避免在程序中大量使用If-Else(Switch)语句，同时使得程序具有更好的可扩展性。
    public delegate void Saydelegate(string word);
    class Program
    {
        public void Englishsay(string word)
        {
            Console.WriteLine("英国" + word);
        }
        public void Chinesesay(string word)
        {
            Console.WriteLine("中国" + word);
        }
        public void Everysay(string word, Saydelegate method)
        {
            method(word);
        }
        static void Main(string[] args)
        {
            //new Program().Everysay("hello", new Program().Englishsay);
            //new Program().Everysay("你好", new Program().Chinesesay);

            ////委托多个方法
            //Saydelegate s1 = new Saydelegate(new Program().Englishsay);
            //s1 += new Program().Chinesesay;//+=增加方法绑定-=取消方法的绑定
            //s1("好");
            Saydelegate s2 = new Saydelegate(c => Console.Write("haha" + c));
            s2 += new Saydelegate(c => Console.WriteLine("哈哈" + c));
            s2("嘻嘻");
            Console.ReadLine();
        }
    }
}
