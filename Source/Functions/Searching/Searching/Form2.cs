﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Searching
{
    public partial class Form2 : Form
    {
        public Form2()
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
