using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlymorphismAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sam = new Employee() { FirstName = "sample", LastName = "Student"};
            sam.SayName();
            sam.Quit();
        }
    }
}
