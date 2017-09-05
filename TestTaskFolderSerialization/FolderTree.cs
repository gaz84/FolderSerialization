using System;
using System.Collections.Generic;


namespace TestTaskFolderSerialization
{
    [Serializable]
    class FolderTree
    {
        public List<FileInFolder> files;
        public List<FolderTree> folders;
        public string FolderName { get; set; }

        public FolderTree()
        { }

    }
}
