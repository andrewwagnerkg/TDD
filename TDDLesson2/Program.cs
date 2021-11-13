using System;

namespace TDDLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorTest ct = new CalculatorTest(ShowConsole);
            try
            {
                ct.TestOpertaions();
            }
            catch (Exception ex)
            {
                ShowConsole(ex.Message);
            }
            Console.ReadKey();
        }

        private static void ShowConsole(string message) => Console.WriteLine(message);
    }
}
