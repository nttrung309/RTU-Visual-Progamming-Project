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
    public partial class Cau03_04 : Form
    {
        public Cau03_04()
        {
            InitializeComponent();
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            if (((radioButton1.Checked == false) && (radioButton2.Checked == false)) || ((radioButton3.Checked == false) && (radioButton4.Checked == false)))
            {
                MessageBox.Show("Có câu hỏi chưa được chọn");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    Cau01_02.e++;
                }
                if (radioButton2.Checked == true)
                {
                    Cau01_02.f++;
                }
                if (radioButton3.Checked == true)
                {
                    Cau01_02.g++;
                }
                if (radioButton4.Checked == true)
                {
                    Cau01_02.h++;
                }
                this.Hide();
                Cau05_06 frm3 = new Cau05_06();
                frm3.Show();
            }
        }
    }
}
