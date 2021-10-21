using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadToUni
{
    public partial class fMain : Form
    {
        Button currentBtn;
        public fMain()
        {
            InitializeComponent();
            StartUp();
        }
        private void StartUp()
        {
            btnHome_Click(btnHome, new EventArgs());
            btnMenu_Click(new object(), new EventArgs());
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

                if (pnlMenu.Width == 60)
                {
                    btnMenu_Click(new object(), new EventArgs());
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
    }
}
