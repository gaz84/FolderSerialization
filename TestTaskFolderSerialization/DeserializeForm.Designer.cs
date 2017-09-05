namespace TestTaskFolderSerialization
{
    partial class DeserializeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSerializedFiles = new System.Windows.Forms.ListBox();
            this.buttonContinueDeserialization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // listBoxSerializedFiles
            // 
            this.listBoxSerializedFiles.FormattingEnabled = true;
            this.listBoxSerializedFiles.ItemHeight = 20;
            this.listBoxSerializedFiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxSerializedFiles.Name = "listBoxSerializedFiles";
            this.listBoxSerializedFiles.Size = new System.Drawing.Size(265, 264);
            this.listBoxSerializedFiles.TabIndex = 1;
            // 
            // buttonContinueDeserialization
            // 
            this.buttonContinueDeserialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinueDeserialization.Location = new System.Drawing.Point(320, 127);
            this.buttonContinueDeserialization.Name = "buttonContinueDeserialization";
            this.buttonContinueDeserialization.Size = new System.Drawing.Size(181, 77);
            this.buttonContinueDeserialization.TabIndex = 2;
            this.buttonContinueDeserialization.Text = "Continue";
            this.buttonContinueDeserialization.UseVisualStyleBackColor = true;
            this.buttonContinueDeserialization.Click += new System.EventHandler(this.buttonContinueDeserialization_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "select file from the list ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "and push the button";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DeserializeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonContinueDeserialization);
            this.Controls.Add(this.listBoxSerializedFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeserializeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeserializeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSerializedFiles;
        private System.Windows.Forms.Button buttonContinueDeserialization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}