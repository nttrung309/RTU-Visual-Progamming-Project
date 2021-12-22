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


namespace Đồ_án_1
{
    public partial class UserControl2 : UserControl
    {
        private int boderSize = 0;
        private int boderRadius = 40;
        private Color boderColor = Color.DeepSkyBlue;
        public UserControl2()
        {
            
            InitializeComponent();
        }

        private GraphicsPath graphicD(Rectangle rect, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            graphicsPath.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -boderSize, -boderSize);
            int smoothSize = 2;
            if (boderSize > 0)
                smoothSize = boderSize;
            if (boderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = graphicD(rectSurface, boderRadius))
                using (GraphicsPath pathBorder = graphicD(rectBorder, boderRadius - boderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(boderColor, boderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (boderSize >= 1)
                        //Draw control border
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (boderSize >= 1)
                {
                    using (Pen penBorder = new Pen(boderColor, boderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoadToUni.Forms.MBTI.Link.SecondUI sUI = new RoadToUni.Forms.MBTI.Link.SecondUI(linkLabel1.Tag.ToString());
            Meow.AddForm(sUI);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoadToUni.Forms.MBTI.Link.SecondUI sUI = new RoadToUni.Forms.MBTI.Link.SecondUI(linkLabel2.Tag.ToString());
            Meow.AddForm(sUI);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoadToUni.Forms.MBTI.Link.SecondUI sUI = new RoadToUni.Forms.MBTI.Link.SecondUI(linkLabel3.Tag.ToString());
            Meow.AddForm(sUI);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RoadToUni.Forms.MBTI.Link.SecondUI sUI = new RoadToUni.Forms.MBTI.Link.SecondUI(linkLabel4.Tag.ToString());
            Meow.AddForm(sUI);
        }
    }
}
