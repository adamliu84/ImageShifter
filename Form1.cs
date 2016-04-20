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
            IEnumerable<String> aszImageFiles = aszFiles.Where(f => aszImageFileExt.Contains(f.Split('.')[1]));
            foreach (String szCurFile in aszImageFiles)
            {
                Console.WriteLine(szCurFile);             
            }

            //Testing loading of 1 image //ignore failure for now
            pictureBoxPreview.Image = Image.FromFile(aszImageFiles.First());
        }
    }
}
