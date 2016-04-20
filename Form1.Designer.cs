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
            this.pictureBoxPreview.Size = new System.Drawing.Size(516, 385);
            this.pictureBoxPreview.TabIndex = 2;
            this.pictureBoxPreview.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 466);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.buttonLoadDirImage);
            this.Controls.Add(this.textBoxLoadedDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLoadedDirectory;
        private System.Windows.Forms.Button buttonLoadDirImage;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
    }
}

