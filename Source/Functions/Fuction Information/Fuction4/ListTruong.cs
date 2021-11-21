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
    public partial class Truong : UserControl
    {
        public Truong()
        {
            InitializeComponent();
        }

        public string TuaDe { get; set; }
        public Image Icon { get; set; }

        private void Truong_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Truong_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }

        private void TenTruong_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }

        private void Truong_Click(object sender, EventArgs e)
        {
            ThongtinTruong ch = new ThongtinTruong();
            ch.Show();
            this.Hide();
        }
    }
}
