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

        }

        private void FixFilenames_Click(object sender, EventArgs e)
        {
            // Rename all the STL files recursively checking through the root folder
            System.IO.File.Move($"{this.root_directory}\\Meme.txt", $"{this.root_directory}\\Nomeme.txt");
            //Console.WriteLine($"{this.root_directory}");
        }
    }
}
