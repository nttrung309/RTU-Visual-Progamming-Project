﻿using System;
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

namespace RoadToUni.Forms.UI
{
    public partial class fSetting : Form
    {
        Button currentBtn;
        Point lastPos;
        bool maximizedByClick;
        int lastWidth;
        int lastHeight;

        Form childForm;
        public fSetting()
        {
            InitializeComponent();
            OnStartUp();
        }
        private void OnStartUp()
        {
            btnHome_Click(btnHome, new EventArgs());

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            lastPos = new Point(this.Location.X, this.Location.Y);
            maximizedByClick = false;

        }
        private void ActiveButton(Object btnSender)
        {
            if (currentBtn != (Button)btnSender)
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
                if (currentBtn.Name == "btnReport")
                {
                    currentBtn.BackColor = Color.IndianRed;
                }
                if (currentBtn.Name == "btnSetting")
                {
                    currentBtn.BackColor = Color.LightBlue;
                }
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
            if (childForm == null)
            {
                
            }
            else
            {
                if (childForm.Name != "fCountDown")
                {
                    SwitchForm(new Forms.CountDown.fCountDown());
                }
            }
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
            Application.Exit();
        }

        //Maximize Button
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                maximizedByClick = true;
                lastWidth = this.Width;
                lastHeight = this.Height;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                if (!maximizedByClick)
                {
                    this.Location = lastPos;
                }
                this.WindowState = FormWindowState.Normal;
                this.Width = lastWidth;
                this.Height = lastHeight;
                maximizedByClick = false;
            }

        }
        //Adjust when maximized by dragging
        private void fMain_SizeChanged(object sender, EventArgs e)
        {

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void SwitchForm(Form f)
        {
            if (childForm != null)
            {
                childForm.Close();
                this.pnlDesktop.Controls.Clear();
            }
            childForm = f;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            this.pnlDesktop.Controls.Add(childForm);
            childForm.Show();
        }
    }
}
