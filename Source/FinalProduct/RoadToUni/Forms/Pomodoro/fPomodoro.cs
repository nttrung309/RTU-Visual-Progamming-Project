using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RoadToUni.Forms.Pomodoro
{
    public partial class fPomodoro : Form
    {
        private int timeLeft;
        public fPomodoro()
        {
            InitializeComponent();
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, lbClock.Width + 1, lbClock.Height + 1);
            this.lbClock.Region = new Region(path);
            btnStart1.Enabled = false;
            btnStop1.Enabled = false;
        }

        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            btnStart1.Enabled = true;
            btnStop1.Enabled = true;
            lbClock.BackColor = Color.LightCoral;
            this.timeLeft = 25 * 60;
            int minutes = timeLeft / 60;
            int second = timeLeft % 60;
            lbClock.Text = string.Format("{0} : {1}", minutes.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Your time is up!", "Thông báo");
            }
            else
            {
                timeLeft--;
                int minutes = timeLeft / 60;
                int second = timeLeft % 60;
                lbClock.Text = string.Format("{0} : {1}", minutes.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));

            } 
                
        }
        private void btnShortBreak_Click(object sender, EventArgs e)
        {
            btnStart1.Enabled = true;
            btnStop1.Enabled = true;
            lbClock.BackColor = Color.DarkSeaGreen;
            this.timeLeft = 5 * 60;
            int minutes = timeLeft / 60;
            int second = timeLeft % 60;
            lbClock.Text = string.Format("{0} : {1}", minutes.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
            timer1.Stop();
            
        }

        private void btnLongBreak_Click(object sender, EventArgs e)
        {
            btnStart1.Enabled = true;
            btnStop1.Enabled = true;
            lbClock.BackColor = Color.CadetBlue;
            this.timeLeft = 15 * 60;
            int minutes = timeLeft / 60;
            int second = timeLeft % 60;
            lbClock.Text = string.Format("{0} : {1}", minutes.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));
            timer1.Stop();
            
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            btnStart1.Enabled = false;
            timer1.Start();
            btnStop1.Enabled = true;
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            btnStop1.Enabled = false;
            this.timer1.Stop();
            btnStart1.Enabled = true;
        }

        private void fPomodoro_Load(object sender, EventArgs e)
        {
            btnPomodoro_Click(new object(), new EventArgs());
        }
    }
}
