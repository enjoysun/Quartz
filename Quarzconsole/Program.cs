using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using System.Threading;
using System.Reflection;

namespace Quarzconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 不包含传参直接设置触发事件（不关于Cron）

            /*
            //获取一个调度器实例化
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            //开启调度器
            scheduler.Start();
            //创建作业
            IJobDetail job1 = JobBuilder.Create<HelloJob>()
                .WithIdentity("任务执行实例", "hello组")
                .Build();
            //创建触发器
            ITrigger trigger1 = TriggerBuilder.Create()
                .StartNow()//现在开始
                .WithIdentity("触发器名", "触发器组")
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(5)//设置触发时间
                    .RepeatForever())//不间断重复执行
                .Build();
            //将作业和触发器加入调度器
            scheduler.ScheduleJob(job1, trigger1);
            Console.ReadLine();
            */
            #endregion

            #region 包含参数使用Cron
            //IScheduler sc=StdSchedulerFactory.GetDefaultScheduler();
            //sc.Start();
            //IJobDetail job=JobBuilder.Create<Argssay>()
            //    .UsingJobData("job", "helloword")//设置job参数
            //    .Build();
            //ITrigger trig=TriggerBuilder.Create()
            //    .StartNow()
            //    .WithCronSchedule("/5 * * ? * *")
            //    .Build();
            //sc.ScheduleJob(job, trig);
            //Console.ReadLine();
            #endregion

            //Quartzhelper quart = new Quartzhelper();
            //IDictionary<string, object> map = new Dictionary<string, object>();
            //map.Add("job", "helloword");
            //map.Add("marry", "byebye");
            //JobDataMap datamap = new JobDataMap(map);
            //quart.Excutejob<Argssay>("*/5 * * * * ?", "job1", "group1", datamap);
            //Console.WriteLine("job1");
            //quart.Excutejob<Marryjob>("*/5 * * * * ?", "job2", "group1", datamap);
            //Console.WriteLine("job2");
            //Task<int> t = Task<string>.Run(() =>
            //{
            //    Console.WriteLine("当前线程" + Thread.CurrentThread.ManagedThreadId);
            //    return Thread.CurrentThread.ManagedThreadId;
            //});
            //t.GetAwaiter().OnCompleted(() => { });
            //Console.WriteLine(t.Result);
            //Console.WriteLine("主线程开始");
            //Task<int> task = Getwithasync();
            //Console.WriteLine("主线程继续");
            //Console.WriteLine("返回值" + task.Result);
            //Console.WriteLine("主线程结束");
            //Console.WriteLine("---------------------------------------");
            //Task<int> t=Task<int>.Run(() => {
            //    return 1;
            //});
            //Console.WriteLine(t.Result);
            //对字符串进行随机排列
            string s = "asdfgh";
            char[] a= s.OrderBy(c => Guid.NewGuid()).ToArray();
            Console.WriteLine(a);
            Console.ReadLine();

            //反射
            //Assembly ass=Assembly.Load("ClassLibrary1");//动态加载dll
            //Type t=ass.GetType("ClassLibrary1.Class1");//获取类
            //PropertyInfo pro= t.GetProperty("name");//获取属性
            //object obj=Activator.CreateInstance(t);//创建类的实例
            //pro.SetValue(obj, "GG", null);
            //object mess=t.GetMethod("sayhello").Invoke(obj, null);
            //Console.WriteLine(mess);
            //Console.ReadLine();
        }
        public static async Task<int> Getwithasync()
        {
            Console.WriteLine("异步线程开始");
            int task = await GetThreadid();
            Console.WriteLine("异步线程结束");
            return task;
        }
        public static Task<int> GetThreadid()
        {
            return Task<int>.Run(() =>
            {
                //Console.WriteLine("当前线程ID" + Thread.CurrentThread.ManagedThreadId);
                int i = Thread.CurrentThread.ManagedThreadId;
                return Thread.CurrentThread.ManagedThreadId;
            });
        }
    }
}
