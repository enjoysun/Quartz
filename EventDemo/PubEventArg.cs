using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class PubEventArg : EventArgs
    {
        public string Bookname { get; set; }
        public PubEventArg(string book = "未订阅")
        {
            Bookname = book;
        }
    }
}
