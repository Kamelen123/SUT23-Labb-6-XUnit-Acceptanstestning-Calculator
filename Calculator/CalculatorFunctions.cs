using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorFunctions
    {

        public static int Addition(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
            return a * b;
        }

        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
            Console.WriteLine($"{a} / {b} = {a / b}");
            return a / b;
        }
    }
}
