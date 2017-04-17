using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Task.Run(() =>
            {
                for (int i = 5; i < 10; i++)
                {
                        sendmail("haha", i.ToString(), "1319622897@qq.com");
                        //Console.WriteLine(i);
                }
            });
            Console.ReadKey();
        }
        public static async void sendmail(string subject, string content, string recive)
        {
            await Task.Run(() =>
            {
                mailhelper.SendMail(subject, content, recive);
            });
        }
    }
}
