namespace WinForms_Filename_Fixer
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
            this.label2 = new System.Windows.Forms.Label();
            this.RootDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // SetRoot
            // 
            this.SetRoot.Location = new System.Drawing.Point(251, 207);
            this.SetRoot.Name = "SetRoot";
            this.SetRoot.Size = new System.Drawing.Size(98, 23);
            this.SetRoot.TabIndex = 0;
            this.SetRoot.Text = "Set Root";
            this.SetRoot.UseVisualStyleBackColor = true;
            this.SetRoot.Click += new System.EventHandler(this.SetRoot_Click);
            // 
            // FixFilenames
            // 
            this.FixFilenames.Location = new System.Drawing.Point(251, 265);
            this.FixFilenames.Name = "FixFilenames";
            this.FixFilenames.Size = new System.Drawing.Size(98, 23);
            this.FixFilenames.TabIndex = 1;
            this.FixFilenames.Text = "Fix Filenames";
            this.FixFilenames.UseVisualStyleBackColor = true;
            this.FixFilenames.Click += new System.EventHandler(this.FixFilenames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "STL Filename Fixer";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(629, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FixFilenames);
            this.Controls.Add(this.SetRoot);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SetRoot;
        private System.Windows.Forms.Button FixFilenames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog RootDialog;
    }
}

