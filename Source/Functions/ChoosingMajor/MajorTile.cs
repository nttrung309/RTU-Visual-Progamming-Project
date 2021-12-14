using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoosingMajor
{
    public partial class MajorTile : UserControl
    {
        public MajorTile()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label1.Location);
            pos = pbxImage.PointToClient(pos);
            label1.Parent = pbxImage;
            label1.Location = pos;
        }

        private string majortext;
        private Image icon;

        [Category("Custom")]
        public string Major
        {
            get { return majortext; }
            set { majortext = value; label1.Text = value; }
        }

        [Category("Custom")]
        public Image Icon
        {
            get { return icon; }
            set { icon = value; pbxImage.Image = value; }
        }
        private void pbxImage_MouseEnter(object sender, EventArgs e)
        {
            pbxImage.Width = 280;
            pbxImage.Height = 140;
            pbxImage.Location = new Point(10, 5);
        }

        private void pbxImage_MouseLeave(object sender, EventArgs e)
        {
            pbxImage.Width = 300;
            pbxImage.Height = 150;
            pbxImage.Location = new Point(0, 0);
        }

        private void MajorTile_Click(object sender, EventArgs e)
        {
            string name = string.Empty;
            bool found = false;
            int i = 0;
            foreach (string item in FirstUI.major)
            {
                if (this.Name == item)
                {
                    found = true;
                    break;
                }
                i++;
            }
            if (found)
            {
                name = this.Name;
            }
            SecondUI sUI = new SecondUI(name);
            sUI.ShowDialog();
            
        }
    }
}
