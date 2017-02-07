using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarzconsole
{
    public class HelloJob:IJob
    {

        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("任务执行!");
        }
    }
}
