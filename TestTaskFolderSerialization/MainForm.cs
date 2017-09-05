using System;
using System.Windows.Forms;



namespace TestTaskFolderSerialization
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            using (var fbDialog = new FolderBrowserDialog())
            {
                fbDialog.Description = "Please choose the folder to serialize";
                //fbDialog.SelectedPath = @"C:\";
                DialogResult result = fbDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbDialog.SelectedPath))
                {
                    SerializeFileNameForm sForm = new SerializeFileNameForm(fbDialog.SelectedPath);
                    sForm.ShowDialog();
                }
            }

        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            DeserializeForm dForm = new DeserializeForm();
            dForm.ShowDialog();
        }

    }

}
