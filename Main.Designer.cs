namespace ImageShifter
{
    partial class Main
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
            this.textBoxLoadedDirectory = new System.Windows.Forms.TextBox();
            this.buttonLoadDirImage = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.listBoxImageListing = new System.Windows.Forms.ListBox();
            this.textBoxCopyDirectory1 = new System.Windows.Forms.TextBox();
            this.buttonCopy1 = new System.Windows.Forms.Button();
            this.textBoxCopyDirectory2 = new System.Windows.Forms.TextBox();
            this.buttonCopy2 = new System.Windows.Forms.Button();
            this.textBoxCopyDirectory3 = new System.Windows.Forms.TextBox();
            this.buttonCopy3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLoadedDirectory
            // 
            this.textBoxLoadedDirectory.Location = new System.Drawing.Point(12, 32);
            this.textBoxLoadedDirectory.Name = "textBoxLoadedDirectory";
            this.textBoxLoadedDirectory.ReadOnly = true;
            this.textBoxLoadedDirectory.Size = new System.Drawing.Size(516, 20);
            this.textBoxLoadedDirectory.TabIndex = 0;
            this.textBoxLoadedDirectory.Text = "P:\\\\ImageShifterSample";
            this.textBoxLoadedDirectory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxLoadedDirectory_MouseDown);
            // 
            // buttonLoadDirImage
            // 
            this.buttonLoadDirImage.Location = new System.Drawing.Point(544, 30);
            this.buttonLoadDirImage.Name = "buttonLoadDirImage";
            this.buttonLoadDirImage.Size = new System.Drawing.Size(145, 23);
            this.buttonLoadDirImage.TabIndex = 1;
            this.buttonLoadDirImage.Text = "Load Directory Image";
            this.buttonLoadDirImage.UseVisualStyleBackColor = true;
            this.buttonLoadDirImage.Click += new System.EventHandler(this.buttonLoadDirImage_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(12, 58);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(516, 394);
            this.pictureBoxPreview.TabIndex = 2;
            this.pictureBoxPreview.TabStop = false;
            // 
            // listBoxImageListing
            // 
            this.listBoxImageListing.FormattingEnabled = true;
            this.listBoxImageListing.Location = new System.Drawing.Point(544, 58);
            this.listBoxImageListing.Name = "listBoxImageListing";
            this.listBoxImageListing.Size = new System.Drawing.Size(145, 394);
            this.listBoxImageListing.TabIndex = 3;
            this.listBoxImageListing.SelectedIndexChanged += new System.EventHandler(this.listBoxImageListing_SelectedIndexChanged);
            // 
            // textBoxCopyDirectory1
            // 
            this.textBoxCopyDirectory1.Location = new System.Drawing.Point(12, 458);
            this.textBoxCopyDirectory1.Name = "textBoxCopyDirectory1";
            this.textBoxCopyDirectory1.ReadOnly = true;
            this.textBoxCopyDirectory1.Size = new System.Drawing.Size(516, 20);
            this.textBoxCopyDirectory1.TabIndex = 4;
            this.textBoxCopyDirectory1.Text = "P:\\\\ImageShifterDump1";
            this.textBoxCopyDirectory1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCopyDirectory1_MouseDown);
            // 
            // buttonCopy1
            // 
            this.buttonCopy1.Location = new System.Drawing.Point(544, 455);
            this.buttonCopy1.Name = "buttonCopy1";
            this.buttonCopy1.Size = new System.Drawing.Size(145, 23);
            this.buttonCopy1.TabIndex = 5;
            this.buttonCopy1.Text = "Copy to 1";
            this.buttonCopy1.UseVisualStyleBackColor = true;
            this.buttonCopy1.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxCopyDirectory2
            // 
            this.textBoxCopyDirectory2.Location = new System.Drawing.Point(12, 484);
            this.textBoxCopyDirectory2.Name = "textBoxCopyDirectory2";
            this.textBoxCopyDirectory2.ReadOnly = true;
            this.textBoxCopyDirectory2.Size = new System.Drawing.Size(516, 20);
            this.textBoxCopyDirectory2.TabIndex = 6;
            this.textBoxCopyDirectory2.Text = "P:\\\\ImageShifterDump2";
            this.textBoxCopyDirectory2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCopyDirectory2_MouseDown);
            // 
            // buttonCopy2
            // 
            this.buttonCopy2.Location = new System.Drawing.Point(544, 482);
            this.buttonCopy2.Name = "buttonCopy2";
            this.buttonCopy2.Size = new System.Drawing.Size(145, 23);
            this.buttonCopy2.TabIndex = 7;
            this.buttonCopy2.Text = "Copy to 2";
            this.buttonCopy2.UseVisualStyleBackColor = true;
            this.buttonCopy2.Click += new System.EventHandler(this.buttonCopy2_Click);
            // 
            // textBoxCopyDirectory3
            // 
            this.textBoxCopyDirectory3.Location = new System.Drawing.Point(12, 510);
            this.textBoxCopyDirectory3.Name = "textBoxCopyDirectory3";
            this.textBoxCopyDirectory3.ReadOnly = true;
            this.textBoxCopyDirectory3.Size = new System.Drawing.Size(516, 20);
            this.textBoxCopyDirectory3.TabIndex = 8;
            this.textBoxCopyDirectory3.Text = "P:\\\\ImageShifterDump3";
            this.textBoxCopyDirectory3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCopyDirectory3_MouseDown);
            // 
            // buttonCopy3
            // 
            this.buttonCopy3.Location = new System.Drawing.Point(544, 508);
            this.buttonCopy3.Name = "buttonCopy3";
            this.buttonCopy3.Size = new System.Drawing.Size(145, 23);
            this.buttonCopy3.TabIndex = 9;
            this.buttonCopy3.Text = "Copy to 3";
            this.buttonCopy3.UseVisualStyleBackColor = true;
            this.buttonCopy3.Click += new System.EventHandler(this.buttonCopy3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 545);
            this.Controls.Add(this.buttonCopy3);
            this.Controls.Add(this.textBoxCopyDirectory3);
            this.Controls.Add(this.buttonCopy2);
            this.Controls.Add(this.textBoxCopyDirectory2);
            this.Controls.Add(this.buttonCopy1);
            this.Controls.Add(this.textBoxCopyDirectory1);
            this.Controls.Add(this.listBoxImageListing);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.buttonLoadDirImage);
            this.Controls.Add(this.textBoxLoadedDirectory);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Image Shifter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLoadedDirectory;
        private System.Windows.Forms.Button buttonLoadDirImage;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.ListBox listBoxImageListing;
        private System.Windows.Forms.TextBox textBoxCopyDirectory1;
        private System.Windows.Forms.Button buttonCopy1;
        private System.Windows.Forms.TextBox textBoxCopyDirectory2;
        private System.Windows.Forms.Button buttonCopy2;
        private System.Windows.Forms.TextBox textBoxCopyDirectory3;
        private System.Windows.Forms.Button buttonCopy3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

