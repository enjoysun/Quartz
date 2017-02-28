using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdeppen
{
    public class Phone
    {
        public static void ShowPhone(object sender, UserArges e)
        {
            Console.WriteLine("监控电话为:" + e.Phone);
        }
    }
}
