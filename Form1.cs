﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageShifter
{
    public partial class Form1 : Form
    {
        //private IEnumerable<String> aszImageFiles;
        private IList<String> aszImageFiles = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadDirImage_Click(object sender, EventArgs e)
        {
            //Primitive of searching image files of given directory 
            String szPath = textBoxLoadedDirectory.Text;
            String[] aszFiles = Directory.GetFiles(@szPath);
            String[] aszImageFileExt = { "jpg", "exe", "gif" };
            //aszImageFiles.Clear();            
            aszImageFiles = aszFiles.Where(f => aszImageFileExt.Contains((f.Split('.')[1]).ToLower())).ToList<String>();
            loadImageListing();

        }

        private void loadImageListing()
        {
            listBoxImageListing.ClearSelected();
            listBoxImageListing.DataSource = PathFormatter.listFilename(aszImageFiles);
        }

        private void listBoxImageListing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 > listBoxImageListing.Items.Count || -1 == listBoxImageListing.SelectedIndex)
            {
                return;
            }            
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.Image = null;
            pictureBoxPreview.Invalidate();
            pictureBoxPreview.Image = Image.FromFile(aszImageFiles[listBoxImageListing.SelectedIndex]);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            copyInc(1);
        }

        private void buttonCopy2_Click(object sender, EventArgs e)
        {
            copyInc(2);
        }

        private void buttonCopy3_Click(object sender, EventArgs e)
        {
            copyInc(3);
        }

        private void copyInc(int nIndex)
        {
            if (0 > listBoxImageListing.Items.Count || -1 == listBoxImageListing.SelectedIndex)
            {
                return;
            }
            //Copy source to dest
            String szSourceFile = aszImageFiles[listBoxImageListing.SelectedIndex];
            TextBox cTargetTextBox = this.Controls["textBoxCopyDirectory" + nIndex] as TextBox;
            String szDestFile = cTargetTextBox.Text + "\\" + Path.GetFileName(szSourceFile);
            File.Copy(szSourceFile, szDestFile, true);
            //Increment in the listbox to the next picture (Stop at last index)
            if (0 < listBoxImageListing.Items.Count && (listBoxImageListing.SelectedIndex + 1) < listBoxImageListing.Items.Count)
            {
                listBoxImageListing.SelectedIndex++;
            }
        }

        private void textBoxLoadedDirectory_Enter(object sender, EventArgs e)
        {
            this.updatePathViaFolderDialog("textBoxLoadedDirectory");
        }

        private void textBoxCopyDirectory1_Enter(object sender, EventArgs e)
        {
            this.updatePathViaFolderDialog("textBoxCopyDirectory1");
        }

        private void textBoxCopyDirectory2_Enter(object sender, EventArgs e)
        {
            this.updatePathViaFolderDialog("textBoxCopyDirectory2");
        }

        private void textBoxCopyDirectory3_Enter(object sender, EventArgs e)
        {
            this.updatePathViaFolderDialog("textBoxCopyDirectory3");
        }

        private void updatePathViaFolderDialog(String szTargetBox)
        {
            //Open folder dialog for folder selection
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TextBox cTargetTextBox = this.Controls[szTargetBox] as TextBox;
                cTargetTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
