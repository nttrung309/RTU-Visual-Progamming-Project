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
using System.Runtime.InteropServices;

namespace RoadToUni
{
    public partial class fMain : Form
    {
        Button currentBtn;
        public fMain()
        {
            InitializeComponent();
            OnStartUp();
        }
        private void OnStartUp()
        {
            btnHome_Click(btnHome, new EventArgs());
            btnMenu_Click(new object(), new EventArgs());

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void ActiveButton(Object btnSender)
        {
            if(currentBtn != (Button)btnSender)
            {
                DeactiveButton();
                currentBtn = (Button)btnSender;
                //Move menubar
                pnlMenuBar.Location = new Point(0, currentBtn.Location.Y);
                pnlMenuBar.Visible = true;
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
            if (pnlMenu.Width == 60)
            {
                btnMenu_Click(new object(), new EventArgs());
            }
        }
        private void DeactiveButton()
        {
            foreach (Control btn in pnlMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.CornflowerBlue;
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void btnPomo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void btnChoice_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnlMenu.Width != 60)
            {
                pnlMenu.Width = 60;
                btnMenu.Location = new Point(0, btnMenu.Location.Y);

                
                foreach (Control cnt in pnlMenu.Controls)
                {
                    if (cnt.GetType() == typeof(Button))
                    {
                        cnt.Text = "";
                    }
                    else
                    {
                        if(cnt.GetType() != typeof(Panel))
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
                    if (cnt.GetType() == typeof(Button))
                    {
                        if(cnt.Tag != null)
                        {
                            cnt.Text = cnt.Tag.ToString();
                        }
                    }
                    else
                    {
                        cnt.Visible = true;
                    }
                }
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }
        //Adjust when maximized by dragging
        private void fMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
