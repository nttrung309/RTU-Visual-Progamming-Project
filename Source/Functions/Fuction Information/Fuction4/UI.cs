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
        public string[] schoolname = { "Đại học Bách Khoa TP.HCM", "Đại học Công nghệ Thông tin ĐHQG TP.HCM", "Trường Đại Học Kinh tế - Luật - ĐHQG TPHCM", "Trường Đại học Khoa học Tự nhiên, ĐHQG-HCM", "Trường Đại học Khoa học Xã hội và Nhân văn, ĐHQG TPHCM" };
        public string[] schoolCode = { "QSB", "QSC", "QSK", "QST", "QSX" };
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
                listTruong.Add(Tr);
                //Truong[] listTruong = new Truong[5];
                //for (int i = 0; i < listTruong.Length; i++)
                //{
                //for (int i = 0; i < 5; i++)
                {
                        //listTruong[i] = new Truong();
                        Tr.MaTruong = schoolCode[j];
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
            }
        }
    }
}

