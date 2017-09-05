using System;
using System.IO;

namespace TestTaskFolderSerialization
{   [Serializable]
    class FileInFolder
    {
        public string Name { get; set; }
        public byte[] FileData;
        public FileInFolder(string name)
        {
            this.Name = Path.GetFileName(name);
            this.FileData = File.ReadAllBytes(name);
        }
    }
}
