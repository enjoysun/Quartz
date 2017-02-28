using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdeppen
{
    public class Email
    {
        public static void ShowEmail(object sender,UserArges e)
        {
            Console.WriteLine("监控邮件为："+e.Emial);
        }
    }
}
