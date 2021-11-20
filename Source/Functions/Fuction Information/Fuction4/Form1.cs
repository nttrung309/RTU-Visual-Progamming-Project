using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuction4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DanhsachIcon()
        {
            Truong[] listTruong = new Truong[30];
            for(int i = 0; i < listTruong.Length; i++)
            {
                listTruong[i] = new Truong();
                listTruong[i].TuaDe = "";
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(listTruong[i]);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DanhsachIcon();
        }
    }
}
