using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicApp_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = 20;
            var num2 = 30;

            if (num1 > num2)
            {
                Console.WriteLine("Largest Number: " + num1);
            }
            else {
                Console.WriteLine("Largest Number: " + num2);
            }
        }
    }
}
