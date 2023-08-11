using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate MathOperation4 class
            Method4 mathOp = new Method4();

            try
            {
                //ask the user to provide the first integer
                Console.WriteLine("Please enter the first integer:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                //ask the user to provide the second integer
                Console.WriteLine("Please enter the second integer:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                mathOp.MathOperation4(num1, num2);


            }
            catch
            {
                Console.WriteLine("please enter two correct integer");
                Console.ReadLine();
            }

        }
    }
}
