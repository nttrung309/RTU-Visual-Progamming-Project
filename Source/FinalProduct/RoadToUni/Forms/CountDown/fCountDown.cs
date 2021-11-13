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

        public static string loadDate = "";
        public fCountDown()
        {
            InitializeComponent();
        }
        private void fCountDown_Load(object sender, EventArgs e)
        {
            if(loadDate == "")
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
            UpdateTime();
            tmCountDown.Start();
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
        protected override CreateParams CreateParams //Fix flick when resize
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
