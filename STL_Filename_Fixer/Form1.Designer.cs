namespace STL_Filename_Fixer
{
    partial class Form1
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
            this.SetRoot = new System.Windows.Forms.Button();
            this.FixFilenames = new System.Windows.Forms.Button();
            this.Name_Banner = new System.Windows.Forms.Label();
            this.RootDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Root_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SetRoot
            // 
            this.SetRoot.Location = new System.Drawing.Point(155, 128);
            this.SetRoot.Name = "SetRoot";
            this.SetRoot.Size = new System.Drawing.Size(98, 23);
            this.SetRoot.TabIndex = 0;
            this.SetRoot.Text = "Set Root";
            this.SetRoot.UseVisualStyleBackColor = true;
            this.SetRoot.Click += new System.EventHandler(this.SetRoot_Click);
            // 
            // FixFilenames
            // 
            this.FixFilenames.Location = new System.Drawing.Point(155, 178);
            this.FixFilenames.Name = "FixFilenames";
            this.FixFilenames.Size = new System.Drawing.Size(98, 23);
            this.FixFilenames.TabIndex = 1;
            this.FixFilenames.Text = "Fix Filenames";
            this.FixFilenames.UseVisualStyleBackColor = true;
            this.FixFilenames.Click += new System.EventHandler(this.FixFilenames_Click);
            // 
            // Name_Banner
            // 
            this.Name_Banner.AutoSize = true;
            this.Name_Banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Banner.Location = new System.Drawing.Point(54, 9);
            this.Name_Banner.Name = "Name_Banner";
            this.Name_Banner.Size = new System.Drawing.Size(295, 37);
            this.Name_Banner.TabIndex = 2;
            this.Name_Banner.Text = "STL Filename Fixer";
            // 
            // Root_TextBox
            // 
            this.Root_TextBox.Location = new System.Drawing.Point(61, 102);
            this.Root_TextBox.Name = "Root_TextBox";
            this.Root_TextBox.Size = new System.Drawing.Size(288, 20);
            this.Root_TextBox.TabIndex = 3;
            this.Root_TextBox.TextChanged += new System.EventHandler(this.Root_TextBox_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(392, 240);
            this.Controls.Add(this.Root_TextBox);
            this.Controls.Add(this.Name_Banner);
            this.Controls.Add(this.FixFilenames);
            this.Controls.Add(this.SetRoot);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button SetRoot;
        private System.Windows.Forms.Button FixFilenames;
        private System.Windows.Forms.Label Name_Banner;
        private System.Windows.Forms.FolderBrowserDialog RootDialog;
        private System.Windows.Forms.TextBox Root_TextBox;
    }
}

