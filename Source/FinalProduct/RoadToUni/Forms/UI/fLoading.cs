using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Net;
using System.Threading;

namespace RoadToUni.Forms.UI
{
    public partial class fLoading : Form
    {
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

        

        public fLoading()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void fLoading_Load(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(Loading);
            Thread td = new Thread(ts);
            td.Start();
            picLoad.Location = new Point((this.Width - picLoad.Width) / 2, picLoad.Location.Y);
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

        private void Loading()
        {
            Thread.Sleep(2000);
            //Check update
            RoadToUni.Forms.UI.Setting.fSettingInfo.CheckUpdate();

            WebClient webClient = new WebClient();

            try
            {
                if (IsConnectedToInternet())
                {
                    RoadToUni.Forms.CountDown.fCountDown.loadDate = webClient.DownloadString("https://pastebin.com/raw/M2yDB6tT");
                }
                else
                {
                    RoadToUni.Forms.CountDown.fCountDown.loadDate = "";
                }
            }
            catch
            {

            }

            this.Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void fLoading_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
