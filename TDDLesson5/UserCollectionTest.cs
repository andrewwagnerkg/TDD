using System;
using NUnit.Framework;

namespace TDDLesson5
{
    [TestFixture]
    class UserCollectionTest
    {
        private UserCollection<string> collection; // = new new UserCollection<string>(); // тест Remove проходить не будет

        //Выполнится до начала каждого теста
        [SetUp]
        public void Init()
        {
            collection = new UserCollection<string>();
        }

        [Test]
        public void TestAdd()
        {
            collection.Add("first");
            collection.Add("second");
            collection.Add("third");

            Assert.AreEqual(3, collection.Count);
        }

        [Test]
        public void TestRemove()
        {

            collection.Add("first");
            collection.Add("second");
            collection.Add("third");

            collection.Remove("first");

            Assert.AreEqual(2, collection.Count);
        }

        [Test]
        //[ExceptedException] - deleted
        public void GetByIdExceptionTest()
        {
            collection.Add("first");
            collection.Add("second");
            collection.Add("third");

            Assert.Throws<ArgumentOutOfRangeException>(() => collection.GetById(3));
        }

        [Test]
        //[ExceptedException] - deleted
        public void GetByIdExceptionTestAlternative()
        {
            collection.Add("first");
            collection.Add("second");
            collection.Add("third");

            try
            {
                collection.GetById(3);
            }
            catch (ArgumentOutOfRangeException e)
            {
                return;
            }
            Assert.Fail("Exception was no thrown.");
        }

        //Выполнится после каждого теста
        [TearDown]
        public void AfterTest()
        {
            collection = null;
        }
    }
}
