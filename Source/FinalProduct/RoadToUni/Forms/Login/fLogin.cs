using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RoadToUni.Forms.Login
{
    public partial class fLogin : Form
    {
        public static string loginedUser = "";
        public fLogin()
        {
            InitializeComponent();
            rbtn1.Checked = true;                      
        }
        
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int ImageNumber = 1;

        private void LoadNextImage()
        {
            timer1.Start();
            ImageNumber++;
            if (ImageNumber > 5)
            {
                ImageNumber = 1;
            }
            pbxSlide.Image = new Bitmap(Application.StartupPath + "\\Images\\"+ ImageNumber+".jpg");        

        }
        private void LoadPreviousImage()
        {
            timer1.Start();
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 5;
            }
            pbxSlide.Image = new Bitmap(Application.StartupPath + "\\Images\\" + ImageNumber + ".jpg");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
            LoadPosition();
        }

        private void btnLeftArrow_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPreviousImage();
            LoadPosition();
        }

        private void btnRightArrow_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImage();
            LoadPosition();
        }
        private void LoadPosition()
        {
            switch (ImageNumber)
            {
                case 1:
                    rbtn1.Checked = true;
                    break;
                case 2:
                    rbtn2.Checked = true;
                    break;
                case 3:
                    rbtn3.Checked = true;
                    break;
                case 4:
                    rbtn4.Checked = true;
                    break;
                case 5:
                    rbtn5.Checked = true;
                    break;
             
            }
        }
        private void LoadPositionAfterCheck()
        {
            timer1.Start();
            if (rbtn1.Checked == true) ImageNumber = 1;
            else if (rbtn2.Checked == true) ImageNumber = 2;
            else if (rbtn3.Checked == true) ImageNumber = 3;
            else if (rbtn4.Checked == true) ImageNumber = 4;
            else if (rbtn5.Checked == true) ImageNumber = 5;
            pbxSlide.Image = new Bitmap(Application.StartupPath + "\\Images\\" + ImageNumber + ".jpg");

        }
        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPositionAfterCheck();
        }
        //form main here
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-281DQ5C3\SQLEXPRESS;Initial Catalog=QuanLyDiemChuanDHQG;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            con.Open();
            string login = "SELECT * FROM ACCOUNT WHERE USERNAME= '" + txtUsername.Text + "' and PASSWORD = '" + txtPassword.Text + "'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                loginedUser = txtUsername.Text;
                this.Hide();
                new RoadToUni.Forms.UI.fUI().ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new RoadToUni.Forms.Login.fRegister();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
    }
}
