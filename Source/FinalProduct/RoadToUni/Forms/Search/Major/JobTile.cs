using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadToUni.Forms.Search.Major.ChoosingMajor
{
    public partial class JobTile : UserControl
    {
        public JobTile()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            
        }
        private string job;

        [Category("Custom")]
        public string Job
        {
            get { return job; }
            set { job = value; label1.Text = value; }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.Fill;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Dock = DockStyle.None;
        }

        private void JobTile_Click(object sender, EventArgs e)
        {  
            ThirdUI tUI = new ThirdUI(SecondUI.Nhomnganh, this.Name );
            RoadToUni.Forms.Search.Major.ChoosingMajor.MajorUI.AddForm(tUI);
        }
    }
}
