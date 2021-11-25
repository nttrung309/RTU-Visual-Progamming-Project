using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JobSearch
{
    public partial class Job : UserControl
    {
        public Job()
        {
            InitializeComponent();
        }
        #region CustomProp
        
        private string _jText;
        private Image _img;

        [Category("Custom Props")]
        public Image Img
        {
            get { return _img; }
            set { _img = value; pboxJobs.Image = value; }
        }

        [Category("Custom Props")]
        public string PlaceholderText
        {
            get { return _jText; }
            set { _jText = value; lblJob.Text = value; }
        }
        #endregion
    }
}
