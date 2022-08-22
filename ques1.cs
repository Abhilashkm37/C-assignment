using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abhilash
{
    internal class ques1
    {
     public static void Main()
        {
            int firstno;
            int secondno;
            int thirdno;
            int multiply;
            Console.WriteLine("Enter first number");
            firstno = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter second number");
            secondno = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter third number");
            thirdno = int.Parse (Console.ReadLine());
            multiply = firstno * secondno * thirdno;    
            Console.WriteLine("The multiplication of three numbers are" + multiply);
         }
    }
}
