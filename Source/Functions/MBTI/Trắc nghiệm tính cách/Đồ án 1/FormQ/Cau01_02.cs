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
    public partial class Cau01_02 : Form
    {
        static public int a { get; set; }
        static public int b { get; set; }
        static public int c { get; set; }
        static public int d { get; set; }
        static public int e { get; set; }
        static public int f { get; set; }
        static public int g { get; set; }
        static public int h { get; set; }

        public Cau01_02()
        {
            InitializeComponent();

        }
        private void Next1_Click(object sender, EventArgs e)
        {
            if (((radioButton1.Checked == false) && (radioButton2.Checked == false)) || ((radioButton3.Checked == false) && (radioButton4.Checked == false)))
            {
                MessageBox.Show("Có câu hỏi chưa được chọn","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            { 
                if (radioButton1.Checked == true)
                {
                    a++;
                }
                if (radioButton2.Checked == true)
                {
                    b++;
                }
                if (radioButton3.Checked == true)
                {
                    c++;
                }
                if (radioButton4.Checked == true)
                {
                    d++;
                }
                Meow.SwitchForm(new Cau03_04());
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
