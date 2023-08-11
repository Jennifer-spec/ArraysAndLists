using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the mathMethods class
            MathMethods2 math1 = new MathMethods2();
            
            //Call the first method with an int paramer
            Console.WriteLine(math1.MathOp(7));
            Console.ReadLine();
            //call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(7.3m));
            Console.ReadLine();
            //call the third method with a string parameter
            Console.WriteLine(math1.MathOp("7"));
            Console.ReadLine();
        }
    }
}
