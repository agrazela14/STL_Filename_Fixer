using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void SetRoot_Click(object sender, EventArgs e)
        {
            // Set the root folder to do the Renaming on
            RootDialog.ShowDialog();


        }

        private void FixFilenames_Click(object sender, EventArgs e)
        {
            // Rename all the STL files recursively checking through the root folder
        }
    }
}
