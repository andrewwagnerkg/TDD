using NUnit.Framework;
using Calc = Calculator.Calculator;

namespace TDDLesson3
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public static void TestOpertaions()
        {
            Calc calculator = new Calc();
            Assert.AreEqual(calculator.Add(1, 3), 4);
            Assert.AreEqual(calculator.Minus(1, 3), -2);
            Assert.AreEqual(calculator.Muliply(1, 3), 3);
            Assert.AreEqual(calculator.Divide(3, 1), 3);
        }
    }
}
