using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment1
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //give it the method SayName()
        public abstract void SayName();
    }
}
