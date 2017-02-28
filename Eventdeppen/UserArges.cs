using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdeppen
{
    public class UserArges
    {
        public double Money { get; set; }
        public string Emial { get; set; }
        public string Phone { get; set; }
        public UserArges(double money, string email, string phone)
        {
            Money = money;
            Emial = email;
            Phone = phone;
        }
    }
}
