using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Filename_Fixer
{
    public partial class Form1 : Form
    {
        private string root_directory;
        public Form1()
        {
            InitializeComponent();
            this.root_directory = "";
        }

        private void SetRoot_Click(object sender, EventArgs e)
        {
            // Set the root folder to do the Renaming on
            RootDialog.ShowDialog();
            this.root_directory = RootDialog.SelectedPath;
            this.Root_TextBox.Text = this.root_directory;

        }

        private void FixFilenames_Click(object sender, EventArgs e)
        {
            // Rename all the STL files recursively checking through the root folder
            System.IO.File.Move($"{this.root_directory}\\Meme.txt", $"{this.root_directory}\\Nomeme.txt");
            //Console.WriteLine($"{this.root_directory}");
            rename_STLs(this.root_directory);
        }

        private void rename_STLs(string dir)
        {
            // For each directory, call rename_STLs
            foreach (string nested_dir in Directory.GetDirectories(dir))
            {
                rename_STLs(nested_dir);
            }
            // For each file, do the rename operation
            foreach (string filename in Directory.GetFiles(dir))
            {
                // Renaming Logic
            }
        }
        private void Root_TextBox_TextChanged(object sender, EventArgs e)
        {
            this.root_directory = this.Root_TextBox.Text;
        }
    }
}
