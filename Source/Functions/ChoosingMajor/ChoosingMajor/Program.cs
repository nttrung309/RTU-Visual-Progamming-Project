using ChoosingMajor.GUID;
using log4net.Config;
using System;
using System.IO;
using System.Windows.Forms;

namespace ChoosingMajor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Application.StartupPath + "/config/logging.config"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrapper.InitializeContainer();
            Application.Run(new FirstUI());
        }
    }
}
