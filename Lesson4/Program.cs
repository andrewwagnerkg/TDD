using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Calc = Calculator.Calculator;

namespace Lesson4
{
    [TestFixture]
    class Myclass
    {
        [Test]
        public void SameTest()
        {
            string a = "Hello";
            string b = "world";
            //a = b;
            //проверяет ссылается ли переменная на одну область памяти
            Assert.AreSame(a, b);
        }

        [Test]
        public void ContainsTest()
        {
            ArrayList names = new ArrayList()
            {
                "Alex",
                "John",
                "Bob",
                "Alice"
            };

            //Проверяет содержится ли элемент в множестве массива
            Assert.Contains("Alice", names);
        }

    }

    [TestFixture]
    class ComparerTests
    {
        private int a, b;

        [SetUp]
        public void Init()
        {
            a = 15;
            b = 14;
        }

        [Test]
        public void GreaterTest()
        {
            //a>b
            Assert.Greater(a, b);
            //a>=b
            Assert.GreaterOrEqual(a, b);
        }

        [Test]
        public void LessTest()
        {
            //a<b
            Assert.Less(a, b);
            //a<=b
            Assert.LessOrEqual(a, b);
        }
    }

    [TestFixture]
    class TypeTests
    {
        [Test]
        public void IsInstanceOfTest()
        {
            Assert.IsNotInstanceOf(typeof(string), 5);
            Assert.IsInstanceOf(typeof(object), "string");
        }
    }

    [TestFixture]
    class ConditionTests
    {
        private Calc _calculator;

        [SetUp]
        public void Init()
        {
            _calculator = new Calc();
        }

        [Test]
        public void IsTrue()
        {
            Assert.IsTrue(_calculator.Add(2, 2) == 4);
        }

        [Test]
        public void IsFalse()
        {
            Assert.IsFalse(_calculator.Minus(2, 3) == 1);
        }

        [Test]
        public void IsNan()
        {
            var d = double.NaN;

            Assert.IsNaN(d);
            Assert.IsNaN(12 / 0.0);
        }

        [Test]
        public void IsEmpty()
        {
            Assert.IsEmpty("");
            Assert.IsNotEmpty("Hello");

            Assert.IsEmpty(new List<string>());
            Assert.IsNotEmpty(new List<string>() { "Hello", "world" });
        }
    }

    [TestFixture]
    class UtilityTest
    {
        [Test]
        //[Ignore("ignore message")]
        public void IgnoreTest()
        {
            //throw new Exception("exception");

            Assert.Ignore("message of reason");
        }

        [Test]
        public void FailedTest()
        {
            Assert.Fail("message of fail");
        }
    }

    //Ограничения
    [TestFixture]
    class AssertConstraintsTests : AssertionHelper
    {
        [Test]
        public void AssertClassic()
        {
            Assert.AreEqual(typeof(string), "Hello".GetType());
            Assert.AreNotEqual(typeof(int), "Hello".GetType());
        }

        [Test]
        public void AssertHelper()
        {
            Assert.That("Hello", Is.TypeOf(typeof(string)));
            Assert.That("Hello", Is.Not.TypeOf(typeof(int)));
        }

        [Test]
        public void InheritTest()
        {
            //Depricated
            Expect("Hello", TypeOf(typeof(string)));
            Expect("Hello", Not.TypeOf(typeof(int)));
        }
    }

    //Содержание
    [TestFixture]
    class ContainsTests : AssertionHelper
    {

        private int[] iarray;
        private string[] sarray;

        [SetUp]
        public void Init()
        {
            iarray = new[] { 1, 3, 7, 9, 13 };
            sarray = new[] { "hello", "Alex", "from", "Alice", "and", "Bob" };
        }

        [Test]
        public void ClassicContains()
        {
            Assert.Contains(3, iarray);
            Assert.Contains("hello", sarray);
        }

        [Test]
        public void HelperContains()
        {
            Assert.That(iarray, Has.Member(3));
            Assert.That(sarray, Has.No.Member("world"));
        }

        [Test]
        public void DeprecatedContains()
        {
            Expect(iarray,Contains(3));
            Expect(sarray,No.Contains("world"));
            Expect(sarray,Contains("Bob"));
        }
    }
}
