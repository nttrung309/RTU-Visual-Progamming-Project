using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RoadToUni.Forms.Login
{
    public partial class fRegister : Form
    {
        public fRegister()
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

        

        private int ImageNumber = 1;

        private void LoadNextImage()
        {
            timer1.Start();
            ImageNumber++;
            if (ImageNumber > 5)
            {
                ImageNumber = 1;
            }
            pBoxSlide.Image = new Bitmap(Application.StartupPath + "\\Images\\" + ImageNumber + ".jpg");

        }
        private void LoadPreviousImage()
        {
            timer1.Start();
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 5;
            }
            pBoxSlide.Image = new Bitmap(Application.StartupPath + "\\Images\\" + ImageNumber + ".jpg");

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
            pBoxSlide.Image = new Bitmap(Application.StartupPath + "\\Images\\" + ImageNumber + ".jpg");

        }
        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPositionAfterCheck();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=TRUNGNGUYEN\SQLEXPRESS;Initial Catalog=databaseDiemChuan;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            if (txtUsernameReg.Text == "" || txtPasswordReg.Text == "")
            {
                MessageBox.Show("Please fill out all the fields", "Registation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPasswordReg.Text == txtConfirmPassword.Text)
            {
                con.Open();
                string login = "SELECT * FROM ACCOUNT WHERE USERNAME= '" + txtUsernameReg.Text + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    MessageBox.Show("Username has existed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    string register = "INSERT INTO ACCOUNT VALUES ('" + txtUsernameReg.Text + "','" + txtPasswordReg.Text + "')";
                    cmd = new SqlCommand(register, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblBackLogin_Click(new object(), new EventArgs());
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                txtPasswordReg.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordReg.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblBackLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new fLogin();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.ShowDialog();
            this.Close();
        }
    }
}
