using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinDemo
{
    class Program
    {
        //owin是server和web之间的解耦
        /// <summary>
        /// 启动owin实现操作：1.新建owin stratup类
        ///                   2.注册使用的中间件
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup1>("http://localhost:12345"))//执行地址
            {
                Console.ReadLine();
            }
        }
    }
}
