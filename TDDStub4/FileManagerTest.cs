using NUnit.Framework;

namespace TDDStub4
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest4()
        {
            FileManager mgr = new FileManager();
            Assert.IsTrue(mgr.FindLogFile("file2.log", new StubFileDataObject()));
        }
    }
}
