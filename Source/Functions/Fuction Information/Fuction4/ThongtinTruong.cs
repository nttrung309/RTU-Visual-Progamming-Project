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
        public string schoolname; /*= { "Đại học Bách Khoa TP.HCM", "Đại học Công nghệ Thông tin ĐHQG TP.HCM", "Trường Đại Học Kinh tế - Luật - ĐHQG TPHCM", "Trường Đại học Khoa học Tự nhiên, ĐHQG-HCM", "Trường Đại học Khoa học Xã hội và Nhân văn, ĐHQG TPHCM" };*/
        public string schoolcode;
        private void ThongtinTruong_Load(object sender, EventArgs e)
        {
            //label1.Text += schoolname;
            //label2.Text += schoolcode;
            //foreach(Code c in )
            //label3.Text = Properties.Resources.QSC_text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            label1.Text = "Tên trường: ";
            label2.Text = "Mã trường: ";
        }

        //private void ThongtinTruong_Enter(object sender, EventArgs e)
        //{
        //    label1.Text += schoolname;
        //    label2.Text += schoolcode;
        //}


        //public string schoolCode = { "QSB", "QSC", "QSK", "QST", "QSX" };
    }
}
