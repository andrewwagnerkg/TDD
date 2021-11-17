using NUnit.Framework;

namespace TDDStub2
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest2()
        {
            FileManager mgr = new FileManager(new StubFileDataObject());
            Assert.IsTrue(mgr.FindLogFile("file2.log"));
        }
    }
}
