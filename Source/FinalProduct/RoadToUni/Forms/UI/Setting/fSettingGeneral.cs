using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RoadToUni.Forms.UI.Setting
{
    public partial class fSettingGeneral : Form
    {
        string appConfigPath = $@"{Application.StartupPath}\Data\Database\AppConfig.txt";
        Image backGround = null;
        public fSettingGeneral()
        {
            InitializeComponent();
        }

        private void fSettingGeneral_Load(object sender, EventArgs e)
        {
            this.picCountDown.BackgroundImage = RoadToUni.Forms.Login.fLogin.backGround;
            this.picCountDown.BackgroundImageLayout = ImageLayout.Stretch;
            this.lbUserName.Text = RoadToUni.Forms.Login.fLogin.loginedUser.ToUpper();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            pnlChangeName.Visible = true;
        }

        private void btnAcceptName_Click(object sender, EventArgs e)
        {
            RoadToUni.Forms.Login.fLogin.loginedUser = this.txbChangeName.Texts.ToUpper();
            this.lbUserName.Text = this.txbChangeName.Texts;
            LoadAppConfig();
            pnlChangeName.Visible = false;
        }
        private void LoadAppConfig()
        {
            if (!File.Exists(appConfigPath))
            {
                using (FileStream fs = File.Create(appConfigPath))
                {

                }
            }

            string dataToWrite = "Username:" + this.txbChangeName.Texts.ToUpper() + "\nBackground:";
            File.WriteAllText(appConfigPath, dataToWrite);
        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            RoadToUni.Forms.Login.fLogin.backGround = new Bitmap($@"{Application.StartupPath}\Data\Images\Countdown_Background\defaultBackGround.jpg");
            this.picCountDown.BackgroundImage = new Bitmap($@"{Application.StartupPath}\Data\Images\Countdown_Background\defaultBackGround.jpg");
            RoadToUni.Forms.CountDown.fCountDown.topBackGround.BackgroundImage = this.picCountDown.BackgroundImage;
            RoadToUni.Forms.CountDown.fCountDown.topBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void btnChangeBackGround_Click(object sender, EventArgs e)
        {
            OpenFileDialog dg = new OpenFileDialog();
            dg.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if(dg.ShowDialog() == DialogResult.OK)
            {
                if (dg.FileName != null)
                {
                    int pos = 0;
                    backGround = new Bitmap(dg.FileName);
                    try
                    {
                        File.Copy(dg.FileName, $@"{Application.StartupPath}\Data\Images\Countdown_Background\customBackGround" + Path.GetExtension(dg.FileName), true);
                    }
                    catch
                    {
                        File.Copy(dg.FileName, $@"{Application.StartupPath}\Data\Images\Countdown_Background\customBackGround1" + Path.GetExtension(dg.FileName), true);
                        pos = 1;
                    }
                    string data = File.ReadAllText(appConfigPath);
                    string[] config = data.Split('\n');
                    File.WriteAllText(appConfigPath, config[0] + "\nBackground:" + Path.GetExtension(dg.FileName) +"\nPos:" + pos.ToString());
                    this.picCountDown.BackgroundImage = backGround;
                    CountDown.fCountDown.topBackGround.BackgroundImage = backGround;
                    Login.fLogin.backGround = backGround;
                }
            }
        }
    }
}
