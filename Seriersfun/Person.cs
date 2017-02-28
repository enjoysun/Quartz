using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seriersfun
{
    public class Person
    {
        public int? Age { get; set; }
        public string Name { get; set; }
        public Person(int? age, string name)
        {
            Age = age;
            Name = name;
        }
        public Person(int? age)
            : this(22, "小红")
        { }
        public Person(string name)
            : this(23, "小明")
        { }
        public Person()
            : this(21, "小白")
        { }
    }
}
