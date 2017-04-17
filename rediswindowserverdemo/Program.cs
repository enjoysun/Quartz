using RedisHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rediswindowserverdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var redishelper = new RedisHelper(1);
            bool b = redishelper.StringSet("name", "jack", DateTime.Now.AddMinutes(1) - DateTime.Now);
            if (b)
            {
                Console.WriteLine("ok,value={0}", redishelper.StringGet("name"));
            }
        }
    }
}
