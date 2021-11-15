using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Net;

namespace RoadToUni.Forms.UI
{
    public partial class fUI : Form
    {
        Button currentBtn;
        Point lastPos;
        bool maximizedByClick;
        int lastWidth;
        int lastHeight;
        public static bool isMaximized = false;

        public static Form childForm;
        public static Panel pnlDesktop;

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
        
        public fUI()
        {
            OnStartUp();
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void OnStartUp()
        {
            pnlDesktop = new Panel();
            pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDesktop.Location = new System.Drawing.Point(187, 26);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.TabIndex = 2;
            Controls.Add(pnlDesktop);

        }
        private void ActiveButton(Object btnSender)
        {
            if (currentBtn != (CustomControls.RJControls.RJButton)btnSender)
            {
                DeactiveButton();
                currentBtn = (CustomControls.RJControls.RJButton)btnSender;
                //Move menubar
                //pnlMenuBar.Location = new Point(0, currentBtn.Location.Y + 2);
                //pnlMenuBar.Visible = true;
                //Change btn's color when chosen 
                if (currentBtn.Name == "btnHome")
                {
                    currentBtn.BackColor = Color.DarkKhaki;
                }
                if (currentBtn.Name == "btnSearch")
                {
                    currentBtn.BackColor = Color.LightSalmon;
                }
                if (currentBtn.Name == "btnPomo")
                {
                    currentBtn.BackColor = Color.LightPink;
                }
                if (currentBtn.Name == "btnChoice")
                {
                    currentBtn.BackColor = Color.DarkSeaGreen;
                }
                if (currentBtn.Name == "btnLogout")
                {
                    currentBtn.BackColor = Color.IndianRed;
                }
                if (currentBtn.Name == "btnSetting")
                {
                    currentBtn.BackColor = Color.LightBlue;
                }
            }
            if (pnlMenu.Width == 61)
            {
                btnMenu_Click(new object(), new EventArgs());
            }
        }
        private void DeactiveButton()
        {
            foreach (Control btn in pnlMenu.Controls)
            {
                if (btn.GetType() == typeof(Button) || btn.GetType() == typeof(CustomControls.RJControls.RJButton))
                {
                    btn.BackColor = Color.CornflowerBlue;
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if(childForm == null || childForm.Name != "fCountDown")
            {
                SwitchForm(new Forms.CountDown.fCountDown());
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if (childForm == null || childForm.Name != "fChoice")
            {
                SwitchForm(new Forms.Search.fChoice());
            }
        }
        private void btnPomo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if (childForm == null || childForm.Name != "fPomodoro")
            {
                SwitchForm(new Forms.Pomodoro.fPomodoro());
            }
        }
        private void btnChoice_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if (childForm == null || childForm.Name != "fMBTIMain")
            {
                SwitchForm(new Forms.MBTI.fMBTIMain());
            }
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            Form f = new Forms.UI.Setting.fSetting();
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point((this.Location.X + ((this.Width - f.Width) / 2)), this.Location.Y + 40);
            f.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            DialogResult dg = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width != 61)
            {
                pnlMenu.Width = 61;
                btnMenu.Location = new Point(1, btnMenu.Location.Y);


                foreach (Control cnt in pnlMenu.Controls)
                {
                    if (cnt.GetType() == typeof(Button) || cnt.GetType() == typeof(CustomControls.RJControls.RJButton))
                    {
                        cnt.Text = "";
                        cnt.Width = 58;
                    }
                    else
                    {
                        if (cnt.GetType() != typeof(Panel))
                        {
                            cnt.Visible = false;
                        }
                    }
                }
            }
            else
            {
                pnlMenu.Width = 187;
                btnMenu.Location = new Point(127, btnMenu.Location.Y);

                foreach (Control cnt in pnlMenu.Controls)
                {
                    if (cnt.GetType() == typeof(Button) || cnt.GetType() == typeof(CustomControls.RJControls.RJButton))
                    {
                        if (cnt.Tag != null)
                        {
                            cnt.Text = cnt.Tag.ToString();
                            cnt.Width = 184;
                            cnt.Height = 60;
                        }
                    }
                    else
                    {
                        cnt.Visible = true;
                    }
                }
                pnlMenuBar.Visible = false;
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = new Point(this.Location.X, this.Location.Y);
            lastWidth = this.Width;
            lastHeight = this.Height;
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Close Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Maximize Button
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                isMaximized = true;
                maximizedByClick = true;
                lastWidth = this.Width;
                lastHeight = this.Height;
                Region = null;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                isMaximized = false;
                if (!maximizedByClick)
                {
                    this.Location = lastPos;
                }
                this.WindowState = FormWindowState.Normal;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                this.Width = lastWidth;
                this.Height = lastHeight;
                maximizedByClick = false;
            }
            
        }
        //Adjust when minimized by dragging
        private void fMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                isMaximized = false;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public static void SwitchForm(Form f)
        {
            if (childForm != null)
            {
                childForm.Close();
                pnlDesktop.Controls.Clear();
            }
            childForm = f;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            pnlDesktop.Controls.Add(childForm);
            childForm.Show();
        }

        //Creating the extern function...  
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        //Creating a function that uses the API function...  
        public static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        private void fUI_Load(object sender, EventArgs e)
        {


            btnHome_Click(btnHome, new EventArgs());
            btnMenu_Click(new object(), new EventArgs());

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            lastPos = new Point(this.Location.X, this.Location.Y);
            maximizedByClick = false;

            this.lbUser.Text += RoadToUni.Forms.Login.fLogin.loginedUser;
            lbUser.Location = new Point((187 - lbUser.Width) / 2, ptBUser.Location.Y + 55);

            this.pnlMenuBar.BringToFront();
        }
    }
}
