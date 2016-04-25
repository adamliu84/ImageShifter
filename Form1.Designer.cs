namespace ImageShifter
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLoadedDirectory
            // 
            this.textBoxLoadedDirectory.Location = new System.Drawing.Point(7, 8);
            this.textBoxLoadedDirectory.Name = "textBoxLoadedDirectory";
            this.textBoxLoadedDirectory.Size = new System.Drawing.Size(516, 20);
            this.textBoxLoadedDirectory.TabIndex = 0;
            this.textBoxLoadedDirectory.Text = "P:\\\\ImageShifterSample";
            // 
            // buttonLoadDirImage
            // 
            this.buttonLoadDirImage.Location = new System.Drawing.Point(539, 6);
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
            this.pictureBoxPreview.Location = new System.Drawing.Point(7, 34);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(516, 394);
            this.pictureBoxPreview.TabIndex = 2;
            this.pictureBoxPreview.TabStop = false;
            // 
            // listBoxImageListing
            // 
            this.listBoxImageListing.FormattingEnabled = true;
            this.listBoxImageListing.Location = new System.Drawing.Point(539, 34);
            this.listBoxImageListing.Name = "listBoxImageListing";
            this.listBoxImageListing.Size = new System.Drawing.Size(145, 394);
            this.listBoxImageListing.TabIndex = 3;
            this.listBoxImageListing.SelectedIndexChanged += new System.EventHandler(this.listBoxImageListing_SelectedIndexChanged);
            // 
            // textBoxCopyDirectory1
            // 
            this.textBoxCopyDirectory1.Location = new System.Drawing.Point(7, 434);
            this.textBoxCopyDirectory1.Name = "textBoxCopyDirectory1";
            this.textBoxCopyDirectory1.Size = new System.Drawing.Size(516, 20);
            this.textBoxCopyDirectory1.TabIndex = 4;
            this.textBoxCopyDirectory1.Text = "P:\\\\ImageShifterDump1";
            // 
            // buttonCopy1
            // 
            this.buttonCopy1.Location = new System.Drawing.Point(539, 431);
            this.buttonCopy1.Name = "buttonCopy1";
            this.buttonCopy1.Size = new System.Drawing.Size(145, 23);
            this.buttonCopy1.TabIndex = 5;
            this.buttonCopy1.Text = "Copy to 1";
            this.buttonCopy1.UseVisualStyleBackColor = true;
            this.buttonCopy1.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // textBoxCopyDirectory2
            // 
            this.textBoxCopyDirectory2.Location = new System.Drawing.Point(7, 460);
            this.textBoxCopyDirectory2.Name = "textBoxCopyDirectory2";
            this.textBoxCopyDirectory2.Size = new System.Drawing.Size(516, 20);
            this.textBoxCopyDirectory2.TabIndex = 6;
            this.textBoxCopyDirectory2.Text = "P:\\\\ImageShifterDump2";
            // 
            // buttonCopy2
            // 
            this.buttonCopy2.Location = new System.Drawing.Point(539, 458);
            this.buttonCopy2.Name = "buttonCopy2";
            this.buttonCopy2.Size = new System.Drawing.Size(145, 23);
            this.buttonCopy2.TabIndex = 7;
            this.buttonCopy2.Text = "Copy to 2";
            this.buttonCopy2.UseVisualStyleBackColor = true;
            this.buttonCopy2.Click += new System.EventHandler(this.buttonCopy2_Click);
            // 
            // textBoxCopyDirectory3
            // 
            this.textBoxCopyDirectory3.Location = new System.Drawing.Point(7, 486);
            this.textBoxCopyDirectory3.Name = "textBoxCopyDirectory3";
            this.textBoxCopyDirectory3.Size = new System.Drawing.Size(516, 20);
            this.textBoxCopyDirectory3.TabIndex = 8;
            this.textBoxCopyDirectory3.Text = "P:\\\\ImageShifterDump3";
            // 
            // buttonCopy3
            // 
            this.buttonCopy3.Location = new System.Drawing.Point(539, 484);
            this.buttonCopy3.Name = "buttonCopy3";
            this.buttonCopy3.Size = new System.Drawing.Size(145, 23);
            this.buttonCopy3.TabIndex = 9;
            this.buttonCopy3.Text = "Copy to 3";
            this.buttonCopy3.UseVisualStyleBackColor = true;
            this.buttonCopy3.Click += new System.EventHandler(this.buttonCopy3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 528);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Image Shifter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
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
    }
}

