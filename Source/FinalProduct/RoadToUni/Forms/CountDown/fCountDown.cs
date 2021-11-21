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

namespace RoadToUni.Forms.CountDown
{
    public partial class fCountDown : Form
    {
        private TimeSpan daysLeft;
        string days;
        string hours;
        string mins;
        string secs;
        private Random random = new Random();
        private int currentQuote = new Random().Next(0, Quotes.quotes.Count);

        public static string loadDate = "";

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

        public fCountDown()
        {
            InitializeComponent();
        }
        private void fCountDown_Load(object sender, EventArgs e)
        {
            topBackGround.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, topBackGround.Width, topBackGround.Height, 20, 20));
            ToFront();

            lbTitle.Location = new Point((this.Width - lbTitle.Width) / 2, lbTitle.Location.Y);

            NextQuote();

            if (loadDate == "")
            {
                int year;
                if(DateTime.Now >= new DateTime(DateTime.Now.Year, 6, 7))
                {
                    year = DateTime.Now.Year + 1;
                }
                else
                {
                    year = DateTime.Now.Year;
                }
                daysLeft = -DateTime.Now.Subtract(new DateTime(year, 6, 7));
                lbSubTitle.Text = "Kỳ thi THPT Quốc Gia " + year.ToString();
            }
            else
            {
                string[] date = loadDate.Split('/');
                daysLeft = -DateTime.Now.Subtract(new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2])));
                lbSubTitle.Text = "Kỳ thi THPT Quốc Gia " + date[0];
            }
            lbSubTitle.Location = new Point((this.Width - lbSubTitle.Width) / 2, lbSubTitle.Location.Y);
            UpdateTime();
            tmCountDown.Start();
            timerNextQuote.Start();
        }
        private void ToFront()
        {
            picRoundedRec1.BringToFront();
            picRoundedRec2.BringToFront();
            picRoundedRec3.BringToFront();
            picRoundedRec4.BringToFront();

            lbDays.BringToFront();
            lbHours.BringToFront();
            lbMins.BringToFront();
            lbSec.BringToFront();

            label1.BringToFront();
            label2.BringToFront();
            label3.BringToFront();
            label4.BringToFront();

            lbQuote.BringToFront();
            lbAuthor.BringToFront();

            lbTitle.BringToFront();
            lbSubTitle.BringToFront();

            lbDays.Parent = topBackGround;
            lbHours.Parent = topBackGround;
            lbMins.Parent = topBackGround;
            lbSec.Parent = topBackGround;

            label1.Parent = topBackGround;
            label2.Parent = topBackGround;
            label3.Parent = topBackGround;
            label4.Parent = topBackGround;

            picRoundedRec1.Parent = topBackGround;
            picRoundedRec2.Parent = topBackGround;
            picRoundedRec3.Parent = topBackGround;
            picRoundedRec4.Parent = topBackGround;

            lbTitle.Parent = topBackGround;
            lbSubTitle.Parent = topBackGround;

            lbQuote.Parent = topBackGround;
            lbAuthor.Parent = topBackGround;

            lbQuote.BackColor = Color.FromArgb(50, 0, 0, 0);
            lbAuthor.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            daysLeft = daysLeft.Subtract(new TimeSpan(0,0,1));
            UpdateTime();
        }
        private void UpdateTime()
        {
            if (daysLeft.Days < 10)
            {
                days = "  " + daysLeft.Days.ToString();
            }
            else if(daysLeft.Days < 100)
            {
                days = " " + daysLeft.Days.ToString();
            }
            else
            {
                days = daysLeft.Days.ToString();
            }

            if (daysLeft.Hours < 10)
            {
                hours = " " + daysLeft.Hours.ToString();
            }
            else
            {
                hours = daysLeft.Hours.ToString();
            }

            if (daysLeft.Minutes < 10)
            {
                mins = " " + daysLeft.Minutes.ToString();
            }
            else
            {
                mins = daysLeft.Minutes.ToString();
            }

            if (daysLeft.Seconds < 10)
            {
                secs = " " + daysLeft.Seconds.ToString();
            }
            else
            {
                secs = daysLeft.Seconds.ToString();
            }

            lbDays.Text = days;
            lbHours.Text = hours;
            lbMins.Text = mins;
            lbSec.Text = secs;
        }


        private void fCountDown_SizeChanged(object sender, EventArgs e)
        {
            if (RoadToUni.Forms.UI.fUI.isMaximized)
            {
                topBackGround.Region = null;
            }
            else
            {
                topBackGround.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, topBackGround.Width, topBackGround.Height, 20, 20));
            }
        }

        private void btnPomo_Click(object sender, EventArgs e)
        {
            RoadToUni.Forms.UI.fUI.SwitchForm(new RoadToUni.Forms.Pomodoro.fPomodoro());
        }

        private void btnMBTI_Click(object sender, EventArgs e)
        {
            RoadToUni.Forms.UI.fUI.SwitchForm(new RoadToUni.Forms.MBTI.fMBTIMain());
        }

        private void NextQuote()
        {
            int nextQuote;
            do
            {
                nextQuote = random.Next(0, Quotes.quotes.Count);
            }
            while (nextQuote == currentQuote);

            currentQuote = nextQuote;
            this.lbQuote.Text = Quotes.quotes[currentQuote];
            if(currentQuote < Quotes.authors.Count)
            {
                this.lbAuthor.Text = Quotes.authors[currentQuote];
            }
            else
            {
                this.lbAuthor.Text = "";
            }
            AdjustPos();
        }

        private void AdjustPos()
        {
            lbQuote.Location = new Point((this.Width - lbQuote.Width) / 2, lbQuote.Location.Y);
            lbAuthor.Location = new Point(lbQuote.Location.X + lbQuote.Width - (80), lbQuote.Location.Y + lbQuote.Height + 2);
        }

        private void lbQuote_Click(object sender, EventArgs e)
        {
            NextQuote();
        }

        private void lbAuthor_Click(object sender, EventArgs e)
        {
            NextQuote();
        }

        private void timerNextQuote_Tick(object sender, EventArgs e)
        {
            NextQuote();
        }
    }
}
