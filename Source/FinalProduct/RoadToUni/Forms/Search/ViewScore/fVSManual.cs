using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadToUni.Forms.Search.ViewScore
{
    public partial class fVSManual : Form
    {
        public fVSManual()
        {
            InitializeComponent();
            pictureBox2.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            pictureBox1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            pictureBox1.Hide();
            pictureBox2.Show();
        }
    }
}
