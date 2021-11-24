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
    public partial class UI : Form
    {
        public static ThongtinTruong infSchoolForm = new ThongtinTruong();
        private List<Truong> listTruong = new List<Truong>();
        public static List<Code> codes = new List<Code>();
        public string[] schoolname = { "Đại học Bách Khoa TP.HCM", "Đại học Công nghệ Thông tin ĐHQG TP.HCM", "Trường Đại Học Kinh tế - Luật - ĐHQG TPHCM", "Đại Học Quốc Tế - ĐHQG TPHCM", "Trường Đại học Khoa học Tự nhiên, ĐHQG-HCM", "Trường Đại học Khoa học Xã hội và Nhân văn, ĐHQG TPHCM", "Khoa Y - Đại Học Quốc Gia TPHCM", "Đại Học Ngoại Ngữ - Đại Học Đà Nẵng", "Đại Học Bách Khoa - Đại Học Đà Nẵng", "Đại Học Kinh Tế - Đại Học Đà Nẵng","Đại Học Sư Phạm - Đại Học Đà Nẵng", "Khoa Y Dược - Đại Học Đà Nẵng,Khoa Y Dược - Đại Học Đà Nẵng", "Đại Học Sư Phạm Kỹ Thuật - Đại Học Đà Nẵng", "Đại Học Kinh Tế - Đại Học Quốc Gia Hà Nội", "Đại Học Ngoại Ngữ - Đại Học Quốc Gia Hà Nội", "Đại Học Công Nghệ - Đại Học Quốc Gia Hà Nội", "Đại Học Giáo Dục - Đại Học Quốc Gia Hà Nội", "Đại Học Khoa Học Tự Nhiên - Đại Học Quốc Gia Hà Nội", "Đại Học Khoa Học Xã Hội và Nhân Văn - Đại Học Quốc Gia Hà Nội", "Đại Học Y Dược - Đại Học Quốc Gia Hà Nội" };
        public string[] schoolCode = { "QSB", "QSC", "QSK","QSQ", "QST", "QSX","QSY","DDF","DDK","DDQ","DDS","DDY","DSK", "QHE", "QHF", "QHI", "QHS", "QHT", "QHX", "QHY" };
        public UI()
        {           
            infSchoolForm.Dock = DockStyle.Fill;
            Controls.Add(infSchoolForm);
            infSchoolForm.BringToFront();
            infSchoolForm.Hide();
            InitializeComponent();
        }

        private void DanhsachIcon()
        {
            for(int j = 0; j < schoolCode.Length; j++)
            {
                Truong Tr = new Truong();
                Code c = new Code();
                listTruong.Add(Tr);               
                    Tr.MaTruong = schoolCode[j];
                    c.MATRUONG = schoolCode[j];
                    codes.Add(c);
                    //Xóa dòng này sau
                    Tr.TuaDe = schoolname[j];
                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanel1.Controls.Add(listTruong[j]);
                        }                   
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DanhsachIcon();
        }

        private void flowLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            foreach(Truong tr in listTruong)
            {
                tr.BackColor = Color.White;
                tr.pictureBox1.BackColor = Color.White;
            }
        }
    }
}

