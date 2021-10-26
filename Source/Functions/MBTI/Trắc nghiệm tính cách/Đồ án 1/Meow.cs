using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_1
{
    public partial class Meow : Form
    {
        public static Form childForm;
        public static Panel ForSwitch;
        public Meow()
        {
            InitializeComponent();
        }
        private void _Load(object sender, EventArgs e)
        {
            ForSwitch = new Panel();
            this.Controls.Add(ForSwitch);
            ForSwitch.Dock = DockStyle.Fill;
            SwitchForm(new FormUI());
        }
        public static void SwitchForm(Form f)
        {
            if (childForm != null)
            {
                childForm.Close();
            }
            childForm = f;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            ForSwitch.Controls.Add(f);
            childForm.Show();
        }
    }
}
