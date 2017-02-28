using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdeppen
{
    class Program
    {
        static void Main(string[] args)
        {
            UserArges user = new UserArges(12.5, "123456@.163", "18567442380");
            new Subscribsystem(new Userwatchcontrol(), user);
            Console.ReadKey();
        }
    }
}
