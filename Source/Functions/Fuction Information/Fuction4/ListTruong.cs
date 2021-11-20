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

    }
}
