using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;

namespace RoadToUni.Fonts
{
    class CustomFont
    {
        public static PrivateFontCollection pfc;
        public static void LoadFont()
        {
            pfc = new PrivateFontCollection();
            pfc.AddFontFile($@"{Application.StartupPath}\Data\Fonts\Anton-Regular.ttf");
            pfc.AddFontFile($@"{Application.StartupPath}\Data\Fonts\Lobster-Regular.ttf");
            pfc.AddFontFile($@"{Application.StartupPath}\Data\Fonts\Pacifico-Regular.ttf");
            pfc.AddFontFile($@"{Application.StartupPath}\Data\Fonts\RobotoCondensed-Regular.ttf");
            pfc.AddFontFile($@"{Application.StartupPath}\Data\Fonts\YanoneKaffeesatz-Regular.ttf");
        }
    }
}
