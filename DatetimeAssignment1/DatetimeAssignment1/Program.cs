using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is : " + DateTime.Now);
            Console.WriteLine("\nEnter a number to see what the time will be in that many hours");
            float answer = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} hours = {2}", DateTime.Now, answer, DateTime.Now.AddHours(answer));
            Console.ReadLine();
        }
    }
}
