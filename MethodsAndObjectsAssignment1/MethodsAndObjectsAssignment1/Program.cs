using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //inside of the Main method, instantiate and initialize an Employee object with 
            //the first name "Sample" and the last name "Student"
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //call the superclass method SayName on the Employee object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
