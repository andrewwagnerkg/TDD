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
            Assert.AreEqual(4, calculator.Add(1, 3));
            Assert.AreEqual(-2,calculator.Minus(1, 3));
            Assert.AreEqual(3, calculator.Muliply(1, 3));
            Assert.AreEqual(3, calculator.Divide(3, 1));

            //Assert.AreNotEqual(9, calculator.Muliply(1,3));
        }
    }
}
