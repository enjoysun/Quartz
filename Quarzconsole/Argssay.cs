using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarzconsole
{
    class Argssay:IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            JobDataMap data=context.JobDetail.JobDataMap;
            Console.WriteLine("job say: "+data.GetString("job"));
        }
    }
}
