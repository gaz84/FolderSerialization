using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TestTaskFolderSerialization
{
    public partial class DeserializeForm : Form
    {
        public DeserializeForm()
        {
            InitializeComponent();
            FillListBox();
        }

        private void FillListBox()
        {
            var serializedFiles = Directory.GetFiles(Directory.GetCurrentDirectory()).Where(f => Path.GetExtension(f) == ".dat").Select(f => Path.GetFileName(f));

            foreach (var file in serializedFiles)
            {
                listBoxSerializedFiles.Items.Add(file);
            }
            listBoxSerializedFiles.SelectedIndex = 0;

        }
        private bool CreateFilesAndFoldersFromTree(FolderTree tree, string path)
        {
            path += "\\" + tree.FolderName;
            Directory.CreateDirectory(path);

            var filesInFolder = tree.files;
            if (filesInFolder != null)
            {

                foreach (var f in filesInFolder)
                {
                    File.WriteAllBytes(path + "\\" + f.Name, f.FileData);
                }


                var subFolders = tree.folders;
                if (subFolders != null)
                {

                    foreach (var dir in subFolders)
                    {
                        CreateFilesAndFoldersFromTree(dir, path);

                    }
                }
                return true;
            }

            else return false;


        }

        private void buttonContinueDeserialization_Click(object sender, EventArgs e)
        {
            string selectedFile = listBoxSerializedFiles.SelectedItem.ToString();
            if (selectedFile.Length < 1 || selectedFile == null)
            {
                MessageBox.Show("Plese select some file from list");
            }
            else
            {
                using (var fbDialog = new FolderBrowserDialog())
                {
                    fbDialog.Description = "Please choose the folder to deserialize file";
                    //fbDialog.SelectedPath = @"C:\";
                    DialogResult result = fbDialog.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbDialog.SelectedPath))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();

                        using (FileStream fs = new FileStream(selectedFile, FileMode.OpenOrCreate))
                        {

                            FolderTree deselializedTree = (FolderTree)formatter.Deserialize(fs);
                            string path = fbDialog.SelectedPath;
                            if (deselializedTree != null && deselializedTree.FolderName.Length > 0)
                            {
                                if (CreateFilesAndFoldersFromTree(deselializedTree, path))
                                    MessageBox.Show("Deserialization was completed successfully");

                                else
                                    MessageBox.Show("Error occurred. Please try again.");

                                this.Close();
                            }

                        }
                    }
                }
            }
        }
    }
}
