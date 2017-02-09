using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarzconsole
{
    public class Marryjob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            JobDataMap map = context.JobDetail.JobDataMap;
            string str = map.GetString("marry");
            Console.WriteLine("marry say " + str);
        }
    }
}
