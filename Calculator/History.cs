using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class History
    {
        public static List<(int, string, int, int)> logs = new List<(int, string, int, int)>();

        public static void Log(int a, string x, int b, int c)
        {
            logs.Add((a, x, b, c));
        }

        public static void PrintLogs()
        {
            Console.WriteLine("Logs:");
            foreach (var log in logs)
            {
                Console.WriteLine($"{log.Item1} {log.Item2} {log.Item3} = {log.Item4}");
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}
