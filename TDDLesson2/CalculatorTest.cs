using System;
using System.Reflection;
using Calc = Calculator.Calculator;

namespace TDDLesson2
{
    class CalculatorTest
    {
        private string passMessage = "Test passed";
        private string failedMessage = "Test failed";
        private Action<string> _showMessage;

        public CalculatorTest(Action<string> showMessageMethod) => _showMessage = showMessageMethod;

        Calc calc = new Calc();

        public void TestOpertaions()
        {
            CalcDivideByZero();
            CalcAddTest();
            CalcMinusTest();
            CalcDivideTest();
            CalcMultiplyTest();
        }

        private void CalcDivideByZero()
        {
            try
            {
                if (2 == calc.Divide(4, 0)) _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {passMessage}");
                else _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {failedMessage}");
            }
            catch (Exception e)
            {
                _showMessage(e.Message);
            }
        }

        private void CalcAddTest()
        {
            try
            {
                if (3 == calc.Add(1, 2)) _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {passMessage}");
                else _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {failedMessage}");
            }
            catch (Exception ex)
            {
                _showMessage(ex.Message);
            }
        }

        private void CalcMinusTest()
        {
            try
            {
                if (-1 == calc.Minus(1, 2)) _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {passMessage}");
                else _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {failedMessage}");
            }
            catch (Exception e)
            {
                _showMessage(e.Message);
            }
        }

        private void CalcDivideTest()
        {
            try
            {
                if (2 == calc.Divide(4, 2)) _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {passMessage}");
                else _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {failedMessage}");
            }
            catch (Exception e)
            {
                _showMessage(e.Message);
            }
        }

        private void CalcMultiplyTest()
        {
            try
            {
                if (2 == calc.Muliply(1, 2)) _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {passMessage}");
                else _showMessage?.Invoke($"{MethodBase.GetCurrentMethod()?.Name} - {failedMessage}");
            }
            catch (Exception e)
            {
                _showMessage(e.Message);
            }
        }
    }
}
