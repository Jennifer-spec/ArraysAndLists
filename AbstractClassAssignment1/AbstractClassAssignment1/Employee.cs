using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment1
{
    public class Employee : Person
    {
        public int Id { get; set; }
        //Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
    }
}
