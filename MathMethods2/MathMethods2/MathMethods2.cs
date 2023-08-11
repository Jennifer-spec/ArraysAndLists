using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods2
{
    class MathMethods2
    {
        //First method that takes an integer
        public int MathOp(int number)
        {
            return number + 7;
        }
        //second method that takes a decimal
        public int MathOp(decimal number)
        {
            //convert the decimal to an int to perform math operation
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }

        //Third MathOp method that takes a string
        public int MathOp(string number)
        {
            //Conver the string to an int to perform mth operation
            int newnum = Convert.ToInt32(number);
            return newnum % 3;
        }
    }
}
