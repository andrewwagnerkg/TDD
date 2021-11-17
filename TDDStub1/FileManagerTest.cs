using NUnit.Framework;

namespace TDDStub1
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest1()
        {
            FileManager mgr = new FileManager();
            Assert.IsTrue(mgr.FindLogFile("file2.log"));
        }
    }
}
