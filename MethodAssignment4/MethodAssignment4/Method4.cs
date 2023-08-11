using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment4
{
    class Method4
    {
        //create a menthod that takes two integer as parameter
        public void MathOperation4(int i, int j)
        {
            //perform one math operation with first parameter and display the second parameter
            Console.WriteLine("the second entering integer is: " + j);
            int result = i * 10;
            Console.WriteLine("the first entering integer multiple 10 equal to:" + result);
            Console.ReadLine();
        }
    }
}
