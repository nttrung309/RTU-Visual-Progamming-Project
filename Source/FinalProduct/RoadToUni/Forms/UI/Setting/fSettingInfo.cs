using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Runtime;
using System.Runtime.InteropServices;
using System.IO;

namespace RoadToUni.Forms.UI.Setting
{
    public partial class fSettingInfo : Form
    {
        public fSettingInfo()
        {
            InitializeComponent();
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

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            if (IsConnectedToInternet())
            {
                if (CheckUpdate() == 0)
                {
                    MessageBox.Show("Đây là phiên bản mới nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại sau khi kết nối Internet!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static int CheckUpdate()
        {
            WebClient webClient = new WebClient();

            try
            {
                if (IsConnectedToInternet())
                {
                    if (!webClient.DownloadString("https://pastebin.com/raw/7NMPnLU2").Contains("1.0"))
                    {
                        DialogResult dg = MessageBox.Show("Đã có phiên bản mới, bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dg == DialogResult.Yes)
                        {
                            File.Copy(@".\Data\Updater\Updater.exe", @".\Updater.exe",true);
                            Process.Start(@".\Updater.exe");
                            Application.Exit();
                        }
                        return 1;
                    }
                }
            }
            catch
            {

            }
            return 0;
        }
        private void SetPosition()
        {
            this.lbTitle.Location = new Point((this.Width-lbTitle.Width)/2,this.lbTitle.Location.Y);
        }

        private void fSettingInfo_Load(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[4], 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[0], 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
