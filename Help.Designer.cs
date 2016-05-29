namespace ImageShifter
{
    partial class Help
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.infomationLabel = new System.Windows.Forms.Label();
            this.githublink = new System.Windows.Forms.LinkLabel();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infomationLabel
            // 
            this.infomationLabel.AutoSize = true;
            this.infomationLabel.Location = new System.Drawing.Point(12, 9);
            this.infomationLabel.Name = "infomationLabel";
            this.infomationLabel.Size = new System.Drawing.Size(35, 13);
            this.infomationLabel.TabIndex = 1;
            this.infomationLabel.Text = "label1";
            // 
            // githublink
            // 
            this.githublink.AutoSize = true;
            this.githublink.Location = new System.Drawing.Point(12, 103);
            this.githublink.Name = "githublink";
            this.githublink.Size = new System.Drawing.Size(119, 13);
            this.githublink.TabIndex = 2;
            this.githublink.TabStop = true;
            this.githublink.Text = "adamliu84/ImageShifter";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(89, 137);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.githublink);
            this.Controls.Add(this.infomationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label infomationLabel;
        private System.Windows.Forms.LinkLabel githublink;
        private System.Windows.Forms.Button closeButton;
    }
}