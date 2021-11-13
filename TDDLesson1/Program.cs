using System;

namespace TDDLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorTest ct = new CalculatorTest(ShowConsole);
            ct.TestOpertaions();
            Console.ReadKey();
        }

        private static void ShowConsole(string message) => Console.WriteLine(message);
    }
}
