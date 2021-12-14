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
        Timer timer1 = new Timer();
        public static bool checkVi;
        public ThongtinTruong()
        {
            InitializeComponent();
            timer1.Interval = 7000;
            timer1.Tick += Timer1_Tick;
        }

        

        public string schoolname;
        public string schoolcode;
        public string schoolLink;
        private void ThongtinTruong_Load(object sender, EventArgs e)
        {
            userControl31.Hide();
            pictureBox1.SendToBack();
        }

        public void ChangeCheck()
        {
            checkVi = true;
        }

        int ImageNumber = 0;
        private void LoadNextImage()
        {
            
            timer1.Start();                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            checkVi = false;
            this.Hide();
            userControl31.x = 0;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            ImageNumber++;
            if (ImageNumber > 3)
            {
                ImageNumber = 1;
            }
            userControl21.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\" + schoolcode + ImageNumber + ".jpg");            
        }

        private void ThongtinTruong_VisibleChanged(object sender, EventArgs e)
        {
            userControl21.label2.Text = "Mã trường:  " + schoolcode;
            userControl21.linkLabel2.Text = schoolLink;
            if (checkVi == true)
            {
                ImageNumber = 1;
                userControl21.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Images\\" + schoolcode + ImageNumber + ".jpg");
                LoadNextImage();
            }
            else
            {
                timer1.Stop();
            }    
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(schoolLink);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (userControl31.y == 0)
            {
                userControl31.y = 1;
                userControl31.x = 1;
            }
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.Black;
            userControl31.Code = schoolcode;
            userControl31.Show();
            userControl31.BringToFront();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            userControl31.y = 0;
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
            label3.ForeColor = Color.White;
            label2.ForeColor = Color.Black;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            userControl31.y = 0;
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
            label3.ForeColor = Color.White;
            label2.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (userControl31.y == 0)
            {
                userControl31.y = 1;
                userControl31.x = 1;
            }
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.Black;
            userControl31.Code = schoolcode;
            userControl31.Show();
            userControl31.BringToFront();
        }
    }
}
