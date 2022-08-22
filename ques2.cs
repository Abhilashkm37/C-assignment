using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abhilash
{
    internal class ques2
    {
        static void Main(string[] args)
        {
            Console.Write("Input a first number(<10): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number(>20): ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((n < 10 && n > 20));
        }
    }
}
