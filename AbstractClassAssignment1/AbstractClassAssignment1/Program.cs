using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main method, instantiate an Employee object
            Employee sam = new Employee() { firstName = "Sample", lastName = "Student"};
            //call the SayName method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
