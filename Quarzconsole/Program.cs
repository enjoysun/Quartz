using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

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
            IScheduler sc=StdSchedulerFactory.GetDefaultScheduler();
            sc.Start();
            IJobDetail job=JobBuilder.Create<Argssay>()
                .UsingJobData("job", "helloword")//设置job参数
                .Build();
            ITrigger trig=TriggerBuilder.Create()
                .StartNow()
                .WithCronSchedule("/5 * * ? * *")
                .Build();
            sc.ScheduleJob(job, trig);
            Console.ReadLine();
            #endregion
        }
    }
}
