using System;
using System.Reflection;
using Calc = Calculator.Calculator;

namespace TDDLesson1
{
    class CalculatorTest
    {
        private string passMessage = "Test passed";
        private string failedMessage = "Test failed";
        private Action<string> _showMessage;

        public CalculatorTest(Action<string> showMessageMethod) => _showMessage = showMessageMethod;

        public void TestOpertaions()
        {
            Calc calc = new Calc();

            if (2 == calc.Divide(4, 0)) _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {passMessage}");
            else _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {failedMessage}");

            if (3 == calc.Add(1, 2)) _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {passMessage}");
            else _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {failedMessage}");

            if (-1 == calc.Minus(1, 2)) _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {passMessage}");
            else _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {failedMessage}");

            if (2 == calc.Muliply(1, 2)) _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {passMessage}");
            else _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {failedMessage}");
        }
    }
}
