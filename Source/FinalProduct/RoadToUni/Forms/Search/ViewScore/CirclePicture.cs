using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace RoadToUni.Forms.Search.ViewScore
{
    class CirclePicture: PictureBox
    {
      
            protected override void OnPaint(PaintEventArgs pevent)
            {
                GraphicsPath grPath = new GraphicsPath();
                grPath.AddEllipse(0, 0, ClientSize.Width - 3, ClientSize.Height - 3);
                this.Region = new System.Drawing.Region(grPath);
                base.OnPaint(pevent);
           
        }
    }
}
