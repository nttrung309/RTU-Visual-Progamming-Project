using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadToUni.Forms.MBTI.UI
{
    public partial class fOpen : Form
    {

        public fOpen()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            fMBTIMain.SwitchForm(new RoadToUni.Forms.MBTI.Questions.Cau01_02());
        }
    }
}
