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
            if (ForSwitch.Controls != null)
            {
                ForSwitch.Controls.Clear();
            }
            try
            {
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                f.BringToFront();
                ForSwitch.Controls.Add(f);
                f.Show();
            }
            catch
            {
                KetQua kq = new KetQua();
                if(kq == null)
                {
                    MessageBox.Show(":)))");
                }
                kq.TopLevel = false;
                kq.FormBorderStyle = FormBorderStyle.None;
                kq.Dock = DockStyle.Fill;
                kq.BringToFront();
                ForSwitch.Controls.Add(kq);
                kq.Show();
            }
        }
        public static void AddForm(Form f)
        {
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            ForSwitch.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
        public static void PopForm()
        {
            ForSwitch.Controls.RemoveAt(0);
        }
    }
}
