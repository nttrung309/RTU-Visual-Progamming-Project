using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadToUni.Forms.Search.Major.ChoosingMajor
{
    public partial class MajorUI : Form
    {
        public static Panel mainPanel;
        public MajorUI()
        {
            InitStaticPanel();
            InitializeComponent();
        }
        private void MajorUI_Load(object sender, EventArgs e)
        {
            FirstUI s1 = new FirstUI();
            s1.TopLevel = false;
            s1.Dock = DockStyle.Fill;
            s1.BringToFront();
            mainPanel.Controls.Add(s1);
            s1.Show();
        }
        private void InitStaticPanel()
        {
            mainPanel = new Panel();
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(1108, 611);
            mainPanel.TabIndex = 0;
            this.Controls.Add(mainPanel);
        }
        public static void AddForm(Form f)
        {
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
        public static void PopForm()
        {
            mainPanel.Controls.RemoveAt(0);
        }
    }
}
