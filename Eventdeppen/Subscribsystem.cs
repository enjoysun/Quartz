using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdeppen
{
    public class Subscribsystem
    {
        public Subscribsystem(Userwatchcontrol usercontrol, UserArges e)
        {
            usercontrol.BankAccount += new BankAccountEventHandler(Email.ShowEmail);
            usercontrol.BankAccount += new BankAccountEventHandler(Phone.ShowPhone);
            usercontrol.Issue(e);
        }

    }
}
