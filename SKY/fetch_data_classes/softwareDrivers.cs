using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO.Compression;
using static System.Net.WebRequestMethods;
using SKY.controls;
using IWshRuntimeLibrary;
using System.Windows.Forms;
using System.Reflection;
using IWshRuntimeLibrary;
using System.Threading;

namespace SKY
{
    public class softwareDriver
    {
        Splash s = new Splash();
        public bool yes = false;
        internal static class AMDPatcher
        {
            const string _dllLocation = "AMD_Patcher.dll";
            [DllImport(_dllLocation)]
            public static extern int run();
        }
        private void ExecuteCommandSync(object command, string type = null)
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);


                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;

                procStartInfo.CreateNoWindow = true;
                procStartInfo.WorkingDirectory = @"C:\";
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                //string result = proc.StandardOutput.ReadToEnd();
                if (type == null)
                {
                    proc.WaitForExit();
                }
                //Console.WriteLine(result);
            }
            catch (Exception objException)
            {
            }
        }

        //private static void CreateShortcut()
        //{
        //    string link = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        //        + Path.DirectorySeparatorChar + Application.ProductName + ".lnk";
        //    var shell = new WshShell();
        //    var shortcut = shell.CreateShortcut(link) as IWshShortcut;
        //    shortcut.TargetPath = Application.ExecutablePath;
        //    shortcut.WorkingDirectory = Application.StartupPath;
        //    //shortcut...
        //    shortcut.Save();
        //}

        private int DriverCheckAndInstall(string method)
        {

            Properties.Settings.Default.Save();
            // System.Diagnostics.Process.Start("http://3.20.158.33/DTS-Optimizing-portal/DesktopLoginReturn.php?email=ubaidurrehman408@gmail.com&password=12345&approvedkey=9b41894a94d0d0100d88c63a5cab49137262b304");

            // //////////////// SkyNet Folder download ///////////////////
            if (!(System.IO.Directory.Exists(@"C:\SkyNet\SkyNet"))) //check if drivers file exists 
            {


                //download from web portal check starts
                using (WebClient webClient = new WebClient())
                {
                    Properties.Settings.Default.splash_LB = "Please Wait, System Download Required Files...";

                    // System.Diagnostics.Process.Start("http://3.20.158.33/DTS-Optimizing-portal/downloadfile.php?id=DesktopLogin");


                    //  webClient.DownloadFileAsync(new Uri("http://3.20.158.33/DTS-Optimizing-portal/DesktopLoginReturn.php?id=DesktopLogin"), "C:\\maskingPDF1.pdf");
                    webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/downloadfile.php?id=SkyNetZip", @"C:\SkyNet.zip");

                    string zipPath = @"C:\SkyNet.zip";
                    string extractPath = @"C:\SkyNet";
                    // System.IO.File.Delete(zipPath);

                    //   ZipFile.CreateFromDirectory(startPath, zipPath);

                    ZipFile.ExtractToDirectory(zipPath, extractPath);
                    System.IO.File.Delete(@"C:\SkyNet.zip");
                    //RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\run", true);
                    //reg.SetValue("SkyNet", Application.ExecutablePath.ToString());
                    Properties.Settings.Default.splash_perLB = "10%";



                }
            }
            // ////////////////////// SkyNet Folder download ///////////////////

            if (method == "AMD")
            {
                //Dashboard.splash.text_change("Please wait Application check AMD driver");
                // /////////// splash text change /////////////
                //if (!(System.IO.Directory.Exists(@"C:\SkyNet\SkyNet\Resources\AMD"))) //check if drivers file exists 
                //{
                //    ///Amd Folder download from web portal check starts
                //    using (WebClient webClient = new WebClient())
                //    {
                //        // /////////// splash text change /////////////
                //        Properties.Settings.Default.splash_LB = "Please Wait, Check AMD Driver is Available ...";

                //        webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/downloadfile.php?id=SkyNetZip_AMD", @"C:\SkyNet\SkyNet\Resources\AMD.zip");

                //        string zipPath = @"C:\SkyNet\SkyNet\Resources\AMD.zip";
                //        string extractPath = @"C:\SkyNet\SkyNet\Resources\";

                //        ZipFile.ExtractToDirectory(zipPath, extractPath);
                //        System.IO.File.Delete(@"C:\SkyNet\SkyNet\Resources\AMD.zip");
                //        Properties.Settings.Default.splash_perLB = "40%";

                //    }


                //}

                //Amd Folder download from web portal check ends 

                SelectQuery query = new SelectQuery("Win32_PnPSignedDriver");
                query.Condition = "DriverProviderName = 'Advanced Micro Devices, Inc.' AND Manufacturer = 'Advanced Micro Devices, Inc.' AND DeviceClass = 'DISPLAY'";
                ManagementObjectSearcher objSearcher = new ManagementObjectSearcher(query); //Select * from Win32_PnPSignedDriver
                ManagementObjectCollection objCollection = objSearcher.Get();
                string AMD_Blockchain_Driver_Version = "22.19.659.0";
                int AMD_GPU_Device = objCollection.Count;
                string AMD_Driver_Version = null;


                if (AMD_GPU_Device > 0)
                {

                    foreach (ManagementObject obj in objCollection)
                    {
                        AMD_Driver_Version = obj["DriverVersion"].ToString();
                        break;
                    }

                    Console.WriteLine(AMD_Driver_Version);
                    Console.WriteLine("AMD Device Found");
                    Console.WriteLine("Total No. of GPUs: {0} ", AMD_GPU_Device);
                    Console.WriteLine("Checking Driver Version...");
                    if (AMD_Driver_Version == AMD_Blockchain_Driver_Version)
                    {
                        Properties.Settings.Default.AMD_Reboot_status = "no";
                        Console.WriteLine("Blockchain DriverFound!!!!!!!...");
                        return 1;
                    }

                    else
                    {
                         string AMD_GPU_Name = Properties.Settings.Default.GPUName;

                        if (AMD_GPU_Name == "470" || AMD_GPU_Name == "570" || AMD_GPU_Name == "580" || AMD_GPU_Name == "Vega 56" || AMD_GPU_Name == "5700 XT" || AMD_GPU_Name == "Vega 64")                      
                         {

                            Properties.Settings.Default.splash_LB = "Please Wait, Check AMD Driver is Avaliable...";
                            Properties.Settings.Default.splash_perLB = "25%";

                            Console.WriteLine("AMD_GPU_Name = " + AMD_GPU_Name);
                            Properties.Settings.Default.AMD_found = "AMD Found";
                            Properties.Settings.Default.AMD_Reboot_status = "";
                            ///////  download amd driver from portal starts
                            if (!(System.IO.Directory.Exists(@"C:\SkyNet\SkyNet\Resources\AMD"))) //check if drivers file exists 
                            {
                                
                                ///Amd Folder download from web portal check starts
                                using (WebClient webClient = new WebClient())
                                {
                                    // /////////// splash text change /////////////
                                    Properties.Settings.Default.splash_perLB = "25%";
                                    Properties.Settings.Default.splash_LB = "Please Wait, the application downloading AMD driver ...";

                                    webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/downloadfile.php?id=SkyNetZip_AMD", @"C:\SkyNet\SkyNet\Resources\AMD.zip");

                                    string zipPath = @"C:\SkyNet\SkyNet\Resources\AMD.zip";
                                    string extractPath = @"C:\SkyNet\SkyNet\Resources\";

                                    ZipFile.ExtractToDirectory(zipPath, extractPath);
                                    System.IO.File.Delete(@"C:\SkyNet\SkyNet\Resources\AMD.zip");


                                }
                            }
                            // string chk_reboot_status = Properties.Settings.Default.AMD_Reboot_status;
                            ///////  download amd driver from portal ends
                            if (Properties.Settings.Default.AMD_Reboot_status == "")
                            {
                                Properties.Settings.Default.splash_perLB = "35%";
                                Properties.Settings.Default.splash_LB = "Please Wait, the application is installing AMD driver...";

                                Console.WriteLine("Blockchain Driver is not found!!!!!!!.....");
                                Console.WriteLine("Installing AMD Driver.....");
                                object unisntall_command = @"C:\SkyNet\SkyNet\Resources\AMD\Win10-64Bit-Crimson-ReLive-Beta-Blockchain-Workloads-Aug23\Bin64\Setup.exe -UNINSTALL ALL";
                                ExecuteCommandSync(unisntall_command);
                                object install_command = @"C:\SkyNet\SkyNet\Resources\AMD\Win10-64Bit-Crimson-ReLive-Beta-Blockchain-Workloads-Aug23\Bin64\Setup.exe -INSTALL";
                                ExecuteCommandSync(install_command);
                                int patcher_result = AMDPatcher.run();
                                if (patcher_result == 3)
                                {
                                    Console.WriteLine("Driver Restored from Backup.....");
                                    patcher_result = AMDPatcher.run();
                                }
                                if (patcher_result == 2)
                                {
                                    Console.WriteLine("Driver Successfully Installed and Patched.....");
                                }
                                Properties.Settings.Default.splash_LB = "The installation of the AMD driver is completed...";
                                Properties.Settings.Default.splash_perLB = "45%";
                                return 2;
                            }
                        }

                        else
                {
                    Properties.Settings.Default.AMD_found = "AMD Not Found";
                    Console.WriteLine("AMD GPU Not FOUND....");
                    return 0;
                }
               }
             }
                

            }

            if (method == "NVIDIA")
            {
                // /////////// splash text change /////////////


                //// //////////////////// Nvidia driver folder download ////////////
                //if (!(System.IO.Directory.Exists(@"C:\SkyNet\SkyNet\Resources\Nvidia"))) //check if drivers file exists 
                //{
                //    // /////////// splash text change /////////////

                //    //download from web portal check starts
                //    using (WebClient webClient = new WebClient())
                //    {
                //        webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/downloadfile.php?id=SkyNetZip_NVIDIA", @"C:\SkyNet\SkyNet\Resources\Nvidia.zip");

                //        string zipPath = @"C:\SkyNet\SkyNet\Resources\Nvidia.zip";
                //        string extractPath = @"C:\SkyNet\SkyNet\Resources\";

                //        ZipFile.ExtractToDirectory(zipPath, extractPath);
                //        System.IO.File.Delete(@"C:\SkyNet\SkyNet\Resources\Nvidia.zip");

                //        Properties.Settings.Default.splash_perLB = "60%";

                //    }
                //}
                ////Nvidia download from web portal check ends

                //// another zip folder of nvidia 
                //if (!(System.IO.Directory.Exists(@"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\Display.Driver"))) //check if drivers file exists 
                //{
                //    // /////////// splash text change /////////////

                //    //download from web portal check starts
                //    using (WebClient webClient1 = new WebClient())
                //    {
                //        webClient1.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/downloadfile.php?id=SkyNetZip_NVIDIA_Display", @"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\Display.Driver.zip");

                //        string zipPath1 = @"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\Display.Driver.zip";
                //        string extractPath1 = @"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\";

                //        ZipFile.ExtractToDirectory(zipPath1, extractPath1);
                //        System.IO.File.Delete(@"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\Display.Driver.zip");
                //        Properties.Settings.Default.splash_perLB = "70%";

                //    }
                //}



                SelectQuery query1 = new SelectQuery("Win32_PnPSignedDriver");
                query1.Condition = "DriverProviderName = 'NVIDIA' AND Manufacturer = 'NVIDIA' AND DeviceClass = 'DISPLAY' ";

                ManagementObjectSearcher objSearcher1 = new ManagementObjectSearcher(query1); //Select * from Win32_PnPSignedDriver

                ManagementObjectCollection objCollection1 = objSearcher1.Get();

                Console.WriteLine(objCollection1);

                Properties.Settings.Default.splash_LB = "Please Wait, the application Check Nvidia Driver is available...";
                Properties.Settings.Default.splash_perLB = "50 %";

                int Nvidia_GPU_Device = objCollection1.Count;
                if (Nvidia_GPU_Device > 0)
                {
                    Properties.Settings.Default.NVIDIA_Reboot_status = "";
                    Console.WriteLine("Nvidia Device Found");
                    Console.WriteLine("Total No. of GPUs: {0} ", Nvidia_GPU_Device);
                    string driverdate = null;
                    var latestdriverdate = new DateTime(2019, 12, 24, 12, 00, 00);
                    foreach (ManagementObject obj in objCollection1)
                    {
                        driverdate = obj["DriverDate"].ToString();
                        break;
                    }
                    DateTime dt = ManagementDateTimeConverter.ToDateTime(driverdate);
                    int datecompare = DateTime.Compare(dt.Date, latestdriverdate.Date);

                    // /////////////// Check required gpus are available or not /////////////////// 

                    string N_GPU_Name = Properties.Settings.Default.Nvidia_GPUName;
                    Console.WriteLine("Nvidia_GPUName = " + N_GPU_Name);

                    if (N_GPU_Name == "1080" || N_GPU_Name == "1080 Ti" || N_GPU_Name == "P104" || N_GPU_Name == "P106" || N_GPU_Name == "1050 Ti" || N_GPU_Name == "1050")
                    //if (N_GPU_Name == "1040" || N_GPU_Name == "1070 Ti" || N_GPU_Name == "1030")

                    {
                        
                        Properties.Settings.Default.Nvidia_found = "Nvidia Found";
                        if (datecompare < 0)
                        {
                            // //////////////////// Nvidia driver folder download ////////////
                            if (!(System.IO.Directory.Exists(@"C:\SkyNet\SkyNet\Resources\Nvidia"))) //check if drivers file exists 
                            {
                                // /////////// splash text change /////////////

                                //download from web portal check starts
                                using (WebClient webClient = new WebClient())
                                {
                                    Properties.Settings.Default.splash_LB = "Please wait, the application is downloading Nvidia driver...";
                                    Properties.Settings.Default.splash_perLB = "55%";

                                    webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/downloadfile.php?id=SkyNetZip_NVIDIA", @"C:\SkyNet\SkyNet\Resources\Nvidia.zip");

                                    string zipPath = @"C:\SkyNet\SkyNet\Resources\Nvidia.zip";
                                    string extractPath = @"C:\SkyNet\SkyNet\Resources\";

                                    ZipFile.ExtractToDirectory(zipPath, extractPath);
                                    System.IO.File.Delete(@"C:\SkyNet\SkyNet\Resources\Nvidia.zip");

                                    

                                }
                            }
                            //Nvidia download from web portal check ends

                            // another zip folder of nvidia 
                            if (!(System.IO.Directory.Exists(@"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\Display.Driver"))) //check if drivers file exists 
                            {
                                // /////////// splash text change /////////////

                                //download from web portal check starts
                                using (WebClient webClient1 = new WebClient())
                                {
                                    Properties.Settings.Default.splash_LB = "Please wait, the application is downloading Nvidia driver...";
                                    Properties.Settings.Default.splash_perLB = "65%";

                                    webClient1.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/downloadfile.php?id=SkyNetZip_NVIDIA_Display", @"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\Display.Driver.zip");

                                    string zipPath1 = @"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\Display.Driver.zip";
                                    string extractPath1 = @"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\";

                                    ZipFile.ExtractToDirectory(zipPath1, extractPath1);
                                    System.IO.File.Delete(@"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\Display.Driver.zip");
                                   

                                }
                            }
                            // //////////////////// Nvidia driver folder download ends////////////

                            if (Properties.Settings.Default.NVIDIA_Reboot_status == "")
                            {
                                Properties.Settings.Default.splash_LB = "Please wait, the application is installing Nvidia driver...";
                                Properties.Settings.Default.splash_perLB = "75%";
                                Console.WriteLine("Driver is OutDated");
                                Console.WriteLine("Installing Nvidia Driver.....");
                                object install_command = @"C:\SkyNet\SkyNet\Resources\Nvidia\441.87-desktop-win10-64bit-international-whql\setup.exe -s -n";
                                ExecuteCommandSync(install_command);
                                Console.WriteLine("Driver Successfully Installed.....");
                                Properties.Settings.Default.splash_LB = "The installation of the NVIDIA driver is completed....";
           
                                Properties.Settings.Default.splash_perLB = "85%";
                                return 2;
                            }
                        }
                        else if (datecompare >= 0)
                        {
                            Properties.Settings.Default.NVIDIA_Reboot_status = "no";
                            Console.WriteLine("Driver is Fine");
                            return 1;
                        }
                    }
                    
                }
                else
                {

                    Properties.Settings.Default.Nvidia_found = "Nvidia Not Found";
                    Console.WriteLine("Nvidia GPU Not FOUND....");
                    return 0;
                }
            }
            return 0;
        }

        public int run()
        {
            string chk_reboot_status;
            int AMDCheck = DriverCheckAndInstall("AMD");
            int NvidiaCheck = DriverCheckAndInstall("NVIDIA");

            chk_reboot_status = Properties.Settings.Default.AMD_Reboot_status;
            Console.WriteLine(chk_reboot_status);

            // 0: No Device Found
            // 1: Driver Already Installed
            // 2: Driver Installed Now

            if (AMDCheck == 2 || NvidiaCheck == 2)
            {

                yes = true;
                Properties.Settings.Default.CoinName = "Ethereum";
                Properties.Settings.Default.AMD_Reboot_status = "yes";
                Properties.Settings.Default.NVIDIA_Reboot_status = "yes";
                Console.WriteLine("Rebooting System......");
                //return 2;

                //CreateShortcut();

                // copying console application to the startup starts

                string fileName = "OpenAnotherProgam.exe";
                string sourcePath = @"C:\SkyNet\SkyNet\OpenAnotherProgam\OpenAnotherProgam\bin\Debug";
                string targetPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

                // Use Path class to manipulate file and directory paths.
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);

                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);

                    // Copy the files and overwrite destination files if they already exist.
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(targetPath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }

                // copying console application to the startup end


            }
            if (AMDCheck == 1 || NvidiaCheck == 1)

            {
                // /////////// splash text change /////////////

                yes = true;

                // return 1;
            }
            if (AMDCheck == 0 && NvidiaCheck == 0)
            {
                yes = false;
                return 0;


            }
            return 0;



        }
    }
}
