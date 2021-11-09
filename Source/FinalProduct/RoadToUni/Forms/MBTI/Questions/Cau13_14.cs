using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadToUni.Forms.MBTI.Questions
{
    public partial class Cau13_14 : Form
    {
        public Cau13_14()
        {
            InitializeComponent();
        }
        private void Next1_Click(object sender, EventArgs e)
        {
            if (((radioButton1.Checked == false) && (radioButton2.Checked == false)) || ((radioButton3.Checked == false) && (radioButton4.Checked == false)))
            {
                MessageBox.Show("Có câu hỏi chưa được chọn", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                fMBTIMain.SwitchForm(new RoadToUni.Forms.MBTI.Questions.Cau15_16());
            }
    }
}
}
