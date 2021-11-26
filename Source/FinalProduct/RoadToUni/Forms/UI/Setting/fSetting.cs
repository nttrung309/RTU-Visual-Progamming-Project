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

namespace RoadToUni.Forms.UI.Setting
{
    public partial class fSetting : Form
    {
        Button currentBtn;
        Point lastPos;
        int lastWidth;
        int lastHeight;

        Form childForm;

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

        public fSetting()
        {
            InitializeComponent();
            OnStartUp();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void OnStartUp()
        {
            btnGeneral_Click(btnGeneral, new EventArgs());

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            lastPos = new Point(this.Location.X, this.Location.Y);

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
                if (currentBtn.Name == "btnGeneral")
                {
                    currentBtn.BackColor = Color.DarkKhaki;
                }
                if (currentBtn.Name == "btnAccountManage")
                {
                    currentBtn.BackColor = Color.LightSalmon;
                }
                if (currentBtn.Name == "btnPomo")
                {
                    currentBtn.BackColor = Color.LightPink;
                }
                if (currentBtn.Name == "btnInfo")
                {
                    currentBtn.BackColor = Color.DarkSeaGreen;
                }
                if (currentBtn.Name == "btnReport")
                {
                    currentBtn.BackColor = Color.BurlyWood;
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
        private void btnGeneral_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if (childForm == null || childForm.Name != "fManageAccount")
            {
                SwitchForm(new Forms.UI.Setting.fManageAccount());
            }
        }
        private void btnPomo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if (childForm == null || childForm.Name != "fCountDown")
            {
                SwitchForm(new Forms.UI.Setting.fSettingInfo());
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            if (childForm == null || childForm.Name != "fRespond")
            {
                SwitchForm(new Forms.UI.Setting.fRespond());
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
        //Adjust when maximized by dragging
        private void fMain_SizeChanged(object sender, EventArgs e)
        {

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
