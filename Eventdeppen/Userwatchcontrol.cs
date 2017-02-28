using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdeppen
{
    public delegate void BankAccountEventHandler(object sender, UserArges e);
    public class Userwatchcontrol
    {
        public event BankAccountEventHandler BankAccount;
        protected void OnProcess(UserArges e)
        {
            if (BankAccount != null)
            {
                BankAccount(this, e);
            }
        }
        public void Issue(UserArges e)
        {
            OnProcess(e);
        }
    }
}
