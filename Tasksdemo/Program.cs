using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasksdemo
{
    class Program:IDisposable
    {
        static void Main(string[] args)
        {
            var task=new Task[10];
            CancellationToken  token= new CancellationToken();
            for (int i = 0; i < 10; i++)
            {
                int p = i;
                task[i]=Task.Run(() =>
                {
                    Console.WriteLine("线程{0},执行{1}", Thread.CurrentThread.ManagedThreadId,p);//lambda延迟问题需要加个临时变量
                },token);
            }
            Task.WhenAll(task).ContinueWith(c => {
                Console.WriteLine("执行完毕");
                Console.WriteLine(token.IsCancellationRequested);
            });
            Console.ReadLine();

        }

        public void Dispose()
        {
            new Program().Dispose();
        }
    }
}
