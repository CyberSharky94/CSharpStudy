using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicApp_InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            double output = 0; // for testing numeric value

            Console.Write("Please enter a Number: ");
            var num = Console.ReadLine();
            var isNumeric = double.TryParse(num, out output);

            Console.WriteLine("Input Type Is Number: " + isNumeric);
            if (isNumeric)
            {
                Console.WriteLine(num + '\n');
            }
        }
    }
}
