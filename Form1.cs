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
        private IList<String> aszImageFiles;

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
            aszImageFiles = aszFiles.Where(f => aszImageFileExt.Contains(f.Split('.')[1])).ToList<String>();
            loadImageListing();

        }
        
        private void loadImageListing()
        {
            listBoxImageListing.DataSource = PathFormatter.listFilename(aszImageFiles);
        }

        private void listBoxImageListing_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPreview.Image = Image.FromFile(aszImageFiles[listBoxImageListing.SelectedIndex]);
        }
    }
}
