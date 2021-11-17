using System;
using NUnit.Framework;
using Calc= Calculator.Calculator;

namespace TDDLesson6
{
    [TestFixture]
    public class TDDCalculatorTest
    {
        private Calc _calculator;

        [SetUp]
        public void Init()
        {
            _calculator = new Calc();
        }

        //[Test]
        //public void PowTest()
        //{
        //    ///
        //    /// Написать метод который будет возводить число в указаную степень
        //    ///

        //}

        //[Test]
        //public void PowNegativeDigitTest()
        //{
        //    ///
        //    /// Написать метод который будет возводить отрицательное число в указаную степень
        //    ///

        //}

        //[Test]
        //public void DivideByZeroTest()
        //{
        //    Assert.Throws<ArgumentException>(() => _calculator.Divide(24, 0));
        //}

        //[Test]
        //public void SqrtTest()
        //{

        //}

        //[Test]
        //public void SqrtExceptionTest()
        //{

        //}

        [TearDown]
        public void AfterTest()
        {
            _calculator = null;
        }
        
    }
}
