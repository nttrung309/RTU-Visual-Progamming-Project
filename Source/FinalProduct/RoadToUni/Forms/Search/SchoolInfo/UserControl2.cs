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

namespace Fuction4
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel2.Text);
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            LoadFont();
            label2.BringToFront();
            label4.BringToFront();
            label6.BringToFront();
        }

        private void LoadFont()
        {
            label7.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[0], 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[0], 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            label8.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label11.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label12.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label13.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label10.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            label4.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[4], 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[4], 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkLabel2.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[4], 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DiachiEmail.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[4], 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[4], 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            label3.Font = new System.Drawing.Font(RoadToUni.Fonts.CustomFont.pfc.Families[3], 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
