using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1995,5,23,8,32,45);

            //string text = "Here is some text.";
            //File.WriteAllText("C:\\Users\\Tony\\logs\\log.txt", text);
            //string text = File.ReadAllText("C:\\Users\\Tony\\logs\\log.txt");
            //Console.WriteLine(text);
         
            Console.WriteLine(dateTime);

            Console.ReadLine();

        }
    }
}
