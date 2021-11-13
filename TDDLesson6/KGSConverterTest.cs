using System;
using NUnit.Framework;

namespace TDDLesson6
{
    [TestFixture]
    class KGSConverterTest
    {
        [Test]
        public void TestNormal()
        {
            KGSConverter converter = new KGSConverter(90, 80, 1.2m);
            converter.OutputCurrency = Currency.USD;
            converter.Value = 8000;
            Assert.AreEqual(100,converter.Value);
        }

        [Test]
        public void ErrorInParameters()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                KGSConverter converter = new KGSConverter(-90, 80, 1.2m);
                converter.OutputCurrency = Currency.USD;
                converter.Value = 8000;
            });
        }

        [Test]
        public void ErrorInCtorParameters()
        {
            try
            {
                KGSConverter converter = new KGSConverter(-90, 80, 1.2m);
                converter.OutputCurrency = Currency.USD;
                converter.Value = 8000;
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains("ctor", e.Message);
                return;
            }
            Assert.Fail("Exception was thrown from no ctor");
        }

        [Test]
        public void ErrorInValueParameters()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                KGSConverter converter = new KGSConverter(-90, 80, 1.2m);
                converter.OutputCurrency = Currency.USD;
                converter.Value = -8000;
            });
        }

        [Test]
        public void ErrorInCtorParametersAlt()
        {

            try
            {
                KGSConverter converter = new KGSConverter(-90, 80, 1.2m);
                converter.OutputCurrency = Currency.USD;
                converter.Value = 8000;
            }
            catch (ArgumentException)
            {
                return;
            }
            Assert.Fail("Was no thrown exception");
        }
    }
}
