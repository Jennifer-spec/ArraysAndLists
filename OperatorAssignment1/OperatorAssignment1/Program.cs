using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Id = 002;
            employee1.FirstName = "Jesse";
            employee1.LastName = "Smith";
            employee2.Id = 002;
            employee1.FirstName = "Amos";
            employee1.LastName = "Steson";
            if (employee1 == employee2)
            {
                Console.WriteLine("There are two employees which has same Id.");
            }
            else 
            {
                Console.WriteLine("Two employees have different Id.");
            }
            Console.ReadLine();
        }
    }
}
