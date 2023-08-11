using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment1
{
    class Program
    {//this program is not complete.sorry
        static void Main(string[] args)
        {
            //In the Main() method, instantiate the class
            MathMethods math = new MathMethods();
            //call the method
            Console.WriteLine("Input a number");
            int Healnum = Convert.ToInt32(Console.ReadLine());
            int Healreturn = math.Heal(Healnum);

        }
    }
}
