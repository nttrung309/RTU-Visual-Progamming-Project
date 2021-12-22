using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadToUni.Forms.Search
{
    public partial class fChoice : Form
    {
        public fChoice()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (RoadToUni.Forms.UI.fUI.childForm == null || RoadToUni.Forms.UI.fUI.childForm.Name != "fFindSchool")
            {
                //RoadToUni.Forms.UI.fUI.SwitchForm(new Forms.Search.FindSchool.fFindSchool());
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (RoadToUni.Forms.UI.fUI.childForm == null || RoadToUni.Forms.UI.fUI.childForm.Name != "fViewScore")
            {
                //RoadToUni.Forms.UI.fUI.SwitchForm(new Forms.Search.ViewScore.fViewScore());
            }
        }
    }
}
