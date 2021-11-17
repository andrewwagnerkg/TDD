using NUnit.Framework;

namespace TDDStub3
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest3()
        {
            FileManager mgr = new FileManager();
            mgr.DataAccessObject = new StubFileDataObject();
            Assert.IsTrue(mgr.FindLogFile("file2.log"));
        }
    }
}
