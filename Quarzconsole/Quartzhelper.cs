using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarzconsole
{
    public class Quartzhelper
    {
        /// <summary>
        /// 时间间隔执行job
        /// </summary>
        /// <typeparam name="T">任务名</typeparam>
        /// <param name="second">时间间隔</param>
        /// <param name="jobname"></param>
        /// <param name="jobgroup"></param>
        /// <param name="job">是否需要传入执行参数</param>
        /// <returns></returns>
        public IScheduler Excutejob<T>(int second, string jobname = null, string jobgroup = null, JobDataMap job = null) where T : IJob
        {
            //获取调度器实例
            IScheduler sc = StdSchedulerFactory.GetDefaultScheduler();
            sc.Start();
            //构建执行任务
            IJobDetail jobdetail = JobBuilder.Create<T>()
                .WithIdentity(jobname, jobgroup)
                .UsingJobData(job)
                .Build();
            //构建触发器
            ITrigger trigger = TriggerBuilder.Create()
                .StartNow()
                .WithSimpleSchedule(c => c.WithIntervalInSeconds(second).RepeatForever())
                .Build();
            sc.ScheduleJob(jobdetail, trigger);
            return sc;
        }
        /// <summary>
        /// 指定时间执行任务job
        /// </summary>
        /// <typeparam name="T">任务名</typeparam>
        /// <param name="second">cron表达式</param>
        /// <param name="jobname"></param>
        /// <param name="jobgroup"></param>
        /// <param name="job">是否需要传入执行参数</param>
        /// <returns></returns>
        public IScheduler Excutejob<T>(string Cron, string jobname = null, string jobgroup = null, JobDataMap job = null) where T : IJob
        {
            //获取调度器实例
            IScheduler sc = StdSchedulerFactory.GetDefaultScheduler();
            sc.Start();
            //构建执行任务
            IJobDetail jobdetail = JobBuilder.Create<T>()
                .WithIdentity(jobname, jobgroup)
                .UsingJobData(job)
                .Build();
            //构建触发器
            ITrigger trigger = TriggerBuilder.Create()
                .StartNow()
                .WithCronSchedule(Cron)
                .Build();
            sc.ScheduleJob(jobdetail, trigger);
            return sc;
        }
        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sc"></param>
        public void stopjob(IScheduler sc)
        {
            sc.Shutdown();
        }
    }
}
