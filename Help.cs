using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageShifter
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            string myText =
@"【Keyboard Shortcuts】
F1: Copy current image to location 1
F2: Copy current image to location 2
F3: Copy current image to location 3
F4: Skip current image to next

【Github source code】
";
            this.infomationLabel.Text = myText;

            //Link back to source code for reference
            githublink.Links.Add(0, 100, "https://www.github.com/adamliu84/ImageShifter");
            githublink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(delegate (object sender, LinkLabelLinkClickedEventArgs e)
            {
                string target = e.Link.LinkData as string;
                System.Diagnostics.Process.Start(target);
            });
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
