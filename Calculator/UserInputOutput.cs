using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserInputOutput
    {
        public static int a = 0;
        public static int b = 0;
        public static int c = 0;
        public static string operator1 = "+";
        public static string operator2 = "-";
        public static string operator3 = "*";
        public static string operator4 = "/";
        public static int Input()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            return x;
        }
        public static int MenuOption() 
        {
            Console.WriteLine("Select an Opition (1-6)");
            return Input();
        }
        public static int EnterNumber()
        {
            Console.WriteLine("Enter a number");
            return Input();
        } 
        public static void Menu()
        {
            bool running = true;
            Menutext();
            
            while (running)
            {
                switch (MenuOption())
                {
                    case 1:
                        a = EnterNumber();
                        b = EnterNumber();
                        c = CalculatorFunctions.Addition(a, b);
                        History.Log(a, operator1, b, c);

                        break;
                    case 2:
                        a = EnterNumber();
                        b = EnterNumber();
                        c = CalculatorFunctions.Subtraction(a, b);
                        History.Log(a, operator2, b, c);
                        break;
                    case 3:
                        a = EnterNumber();
                        b = EnterNumber();
                        c = CalculatorFunctions.Multiplication(a, b);
                        History.Log(a, operator3, b, c);
                        break;
                    case 4:
                        a = EnterNumber();
                        b = EnterNumber();
                        c = CalculatorFunctions.Division(a, b);
                        History.Log(a, operator4, b, c);
                        break;
                    case 5:
                        History.PrintLogs();
                        break;
                    case 6:
                        Console.Clear();
                        Menutext();
                        break;
                    case 7:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Enter a valid number 1-7");
                        break;
                }
            }
            
        }
        public static void Menutext()
        {
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraction");
            Console.WriteLine("[3] Multiplication");
            Console.WriteLine("[4] Division");
            Console.WriteLine("[5] Hsitory");
            Console.WriteLine("[6] Clear Window");
            Console.WriteLine("[7] Exit");
        }
    }
}
