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

            string downloadURL = "https://roadtouni.000webhostapp.com/RoadToUni/RoadToUni.zip";

            try
            {
                Thread.Sleep(5000);
                client.DownloadFile(downloadURL,@"RoadToUni.zip");
                File.Delete(@".\RoadToUni.exe");
                string zipPath = @".\RoadToUni.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\RoadToUni.zip");
                Process.Start(@".\RoadToUni.exe");
            }
            catch
            {

            }
            
        }
    }
}
