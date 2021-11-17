using System.Collections.Generic;

namespace TDDStub2
{
    class FileManager
    {
        IDataAccessObject dataAccessObject;

        public FileManager()
        {
            this.dataAccessObject = new FileDataObject();
        }

        public FileManager(IDataAccessObject dataAccessObject)
        {
            this.dataAccessObject = dataAccessObject;
        }

        public bool FindLogFile(string fileName)
        {
            List<string> files = dataAccessObject.GetFiles();

            foreach (var file in files)
            {
                if (file.Contains(fileName))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
