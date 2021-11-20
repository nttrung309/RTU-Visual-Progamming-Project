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

        private void Truong_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void Truong_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
