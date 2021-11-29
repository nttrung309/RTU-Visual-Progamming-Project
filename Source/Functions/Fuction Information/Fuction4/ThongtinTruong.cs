using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuction4
{
    public partial class ThongtinTruong : UserControl
    {

        public ThongtinTruong()
        {
            InitializeComponent();            
        }
        public string schoolname;
        public string schoolcode;
        public string schoolLink;
        private void ThongtinTruong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ThongtinTruong_VisibleChanged(object sender, EventArgs e)
        {
            label2.Text = "Mã trường:  " + schoolcode;
            linkLabel2.Text = schoolLink;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThongtinNganh thongtinNganh = new ThongtinNganh();
            thongtinNganh.Code = schoolcode;
            thongtinNganh.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(schoolLink);
        }
    }
}
