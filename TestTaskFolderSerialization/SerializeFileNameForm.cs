using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TestTaskFolderSerialization
{
    public partial class SerializeFileNameForm : Form
    {
        private string fileName;
        private string selectedFolder;
        public SerializeFileNameForm(string path)
        {
            InitializeComponent();
            this.selectedFolder = path;
        }

        private void buttonContinueSerialization_Click(object sender, EventArgs e)
        {
            fileName = textBoxFileName.Text;
            if (fileName.Length < 1)
            {
                MessageBox.Show("Please enter a file name");
            }
            else
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\" + fileName + ".dat"))
                {
                    MessageBox.Show("File with such name already exists, please choose another");
                }
                else
                {
                    FolderTree tree = new FolderTree();
                    if (SaveFilesAndFoldersToTree(tree, selectedFolder))
                    {
                        if (SerializeFolder(tree))
                            MessageBox.Show("Serialization was completed successfully");


                        else
                            MessageBox.Show("Error occurred. Please try again.");

                        this.Close();
                    }
                }
            }

        }
        private bool SaveFilesAndFoldersToTree(FolderTree tree, string rootFolder)
        {
            tree.FolderName = Path.GetFileName(rootFolder);
            var filesInFolder = Directory.GetFiles(rootFolder);
            if (filesInFolder != null)
            {
                tree.files = new List<FileInFolder>();
                foreach (var f in filesInFolder)
                {
                    tree.files.Add(new FileInFolder(f));
                }


                var subFolders = Directory.GetDirectories(rootFolder);
                if (subFolders != null)
                {
                    tree.folders = new List<FolderTree>();
                    foreach (var dir in subFolders)
                    {
                        FolderTree subDirectory = new FolderTree();
                        tree.folders.Add(subDirectory);
                        SaveFilesAndFoldersToTree(subDirectory, dir);

                    }
                }
                return true;
            }

            else return false;


        }

        private bool SerializeFolder(FolderTree folder)

        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName + ".dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, folder);
            }
            return true;
        }

    }
}
