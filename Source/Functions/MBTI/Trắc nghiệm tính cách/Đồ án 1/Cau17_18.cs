﻿using System;
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
    public partial class Cau17_18 : Form
    {
        public Cau17_18()
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
                    Cau01_02.a++;
                }
                if (radioButton2.Checked == true)
                {
                    Cau01_02.b++;
                }
                if (radioButton3.Checked == true)
                {
                    Cau01_02.c++;
                }
                if (radioButton4.Checked == true)
                {
                    Cau01_02.d++;
                }
                this.Hide();
                Form frm3 = new Cau19_20();
                frm3.Show();
            }
        }
    }
}
