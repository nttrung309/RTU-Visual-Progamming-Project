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

namespace RoadToUni.Forms.UI.Setting
{
    public partial class fSettingInfo : Form
    {
        public fSettingInfo()
        {
            InitializeComponent();
        }

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            if(CheckUpdate() == 0)
            {
                MessageBox.Show("Đây là phiên bản mới nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static int CheckUpdate()
        {
            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("https://pastebin.com/raw/v7pwQcEj").Contains("1.0"))
                {
                    DialogResult dg = MessageBox.Show("Đã có phiên bản mới, bạn có muốn cập nhật không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if(dg == DialogResult.Yes)
                    {
                        Process.Start("Updater.exe");
                        Application.Exit();
                    }
                    return 1;
                }
            }
            catch
            {

            }
            return 0;
        }
    }
}
