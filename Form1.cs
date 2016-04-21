using System;
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
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPreview.Image = null;
            pictureBoxPreview.Invalidate();
            pictureBoxPreview.Image = Image.FromFile(aszImageFiles[listBoxImageListing.SelectedIndex]);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            String szSourceFile = aszImageFiles[listBoxImageListing.SelectedIndex];
            String szDestFile = textBoxCopyDirectory.Text + "\\" + Path.GetFileName(szSourceFile);
            File.Copy(szSourceFile, szDestFile, true);
        }
    }
}
