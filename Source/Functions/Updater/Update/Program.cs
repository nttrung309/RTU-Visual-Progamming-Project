using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Diagnostics;

namespace Update
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            string downloadURL = "https://download1321.mediafire.com/m3kpwa4pocjg/vr4m3f8xvf32my7/RoadToUni.exe";

            try
            {
                Thread.Sleep(5000);
                File.Delete(@".\RoadToUni.exe");
                client.DownloadFile(downloadURL,@"RoadToUni.exe");
                Process.Start("RoadToUni.exe");
            }
            catch
            {

            }
            
        }
    }
}
