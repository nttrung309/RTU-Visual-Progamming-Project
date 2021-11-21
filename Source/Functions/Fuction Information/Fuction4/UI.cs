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
        public string[] schoolname = { "Đại học Bách Khoa TP.HCM", "Đại học Công nghệ Thông tin ĐHQG TP.HCM", "Trường Đại Học Kinh tế - Luật - ĐHQG TPHCM", "Trường Đại học Khoa học Tự nhiên, ĐHQG-HCM", "Trường Đại học Khoa học Xã hội và Nhân văn, ĐHQG TPHCM" };
        public string[] schoolCode = { "QSB", "QSC", "QSK", "QST", "QSX" };
        public UI()
        {
            InitializeComponent();
            infSchoolForm.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Add(infSchoolForm);
            infSchoolForm.Hide();
        }

        private void DanhsachIcon()
        {
            Truong[] listTruong = new Truong[5];
            for(int i = 0; i < listTruong.Length; i++)
            {
                //for (int j = 0; j < 5; j++)
                {
                    listTruong[i] = new Truong();
                    listTruong[i].TenTruong.Text = schoolname[i];
                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                    {

                        flowLayoutPanel1.Controls.Add(listTruong[i]);
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DanhsachIcon();
        }
    }
}
