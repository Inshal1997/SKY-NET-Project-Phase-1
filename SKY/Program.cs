using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKY
{
    static class Program
    {

        class JSONClass
        {
            public float Updation { get; set; }
        }
        // /////////////For startup Code starts/////////////////
        //public static bool IsAdministrator()
        //{
        //    WindowsIdentity identity = WindowsIdentity.GetCurrent();
        //    WindowsPrincipal principal = new WindowsPrincipal(identity);
        //    return principal.IsInRole(WindowsBuiltInRole.Administrator);
        //}
        // /////////////For startup Code ends ///////////////////


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            float currentVersion = 1;

            using (WebClient webClient = new WebClient())
            {
               webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/Desktopdownloadfile.php?id=DesktopUpdateJson", @"C:\DesktopUpdateJson.json");
            }

            
            String ResultJson = File.ReadAllText(@"C:\DesktopUpdateJson.json");
            JSONClass result = JsonConvert.DeserializeObject<JSONClass>(ResultJson);


            if (currentVersion == result.Updation)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //  Application.Run(new Dashboard());
                 Application.Run(new controls.Login_Form());
               // Application.Run(new controls.reboot_popup());
            }
            else if(currentVersion < result.Updation || currentVersion > result.Updation)
            {
                MessageBox.Show("You need to Update your SOFTWARE before RUN");
            }

            System.IO.File.Delete(@"C:\DesktopUpdateJson.json");
        }
    }
}
