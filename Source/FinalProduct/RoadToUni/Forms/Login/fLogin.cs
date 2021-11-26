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
using System.Runtime.InteropServices;
using System.IO;


namespace RoadToUni.Forms.Login
{
    public partial class fLogin : Form
    {
        string appConfigPath = $@"{Application.StartupPath}\Data\Database\AppConfig.txt";
        public static string loginedUser = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
        );

        public fLogin()
        {
            InitializeComponent();
            rbtn1.Checked = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            pbxSlide.Image = new Bitmap(Application.StartupPath + "\\Data\\Images\\Login_Images\\" + ImageNumber+".jpg");        

        }
        private void LoadPreviousImage()
        {
            timer1.Start();
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 5;
            }
            pbxSlide.Image = new Bitmap(Application.StartupPath + "\\Data\\Images\\Login_Images\\" + ImageNumber + ".jpg");

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
            pbxSlide.Image = new Bitmap(Application.StartupPath + "\\Data\\Images\\Login_Images\\" + ImageNumber + ".jpg");

        }
        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPositionAfterCheck();
        }
        //form main here
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Texts != "")
            {
                LoadAppConfig();
                OpenLoadingUI(txtUsername.Texts);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadAppConfig()
        {
            if (!File.Exists(appConfigPath))
            {
                using (FileStream fs = File.Create(appConfigPath))
                {

                }
            }

            string dataToWrite = "Username:" + txtUsername.Texts + "\nBackground:";
            File.WriteAllText(appConfigPath, dataToWrite);
        }

        private void txtUsername__TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Texts.Length > 8)
            {
                
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            CheckSystemRequire();
            CheckNewUser();
        }
        private void CheckSystemRequire()
        {
            string netFramwork = @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2";
            string sqlCompact = @"C:\Program Files\Microsoft SQL Server Compact Edition\v4.0";
            if (!Directory.Exists(netFramwork))
            {
                MessageBox.Show("Ứng dụng này yêu cầu .NETFramework Runtime v4.7.2 hoặc cao hơn!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                System.Diagnostics.Process.Start("https://dotnet.microsoft.com/download/dotnet-framework/net472");
                Application.Exit();
            }
            if (!Directory.Exists(sqlCompact))
            {
                MessageBox.Show("Ứng dụng này yêu cầu SQL Compact Runtime 4.0 hoặc cao hơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Diagnostics.Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=30709");
                Application.Exit();
            }
        }
        private void OpenLoadingUI(string userName)
        {
            loginedUser = userName;
            this.Hide();
            new Forms.UI.fLoading().ShowDialog();
            new Forms.UI.fUI().ShowDialog();
            Forms.UI.fUI.childForm = null;
            try
            {
                this.Show();
            }
            catch
            {

            }
        }
        private void CheckNewUser()
        {
            string data = File.ReadAllText(appConfigPath);
            string[] config = data.Split('\n');
            string userName = config[0].Substring(9,config[0].Length - 9);
            if(userName != "")
            {
                OpenLoadingUI(userName);
            }
        }
    }
}
