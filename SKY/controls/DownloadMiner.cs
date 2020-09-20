using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ATI.ADL;
using System.Runtime.InteropServices;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Data.SqlClient;
using System.IO.Compression;

namespace SKY.controls
{
    public partial class DownloadMiner : UserControl
    {
        int i;
        string gname;
        string AMD_GPU_Name;
        string Nvidia_GPU_Name;

        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=skysignuplogin;User Id=root;password=''");

        // ///////////////////////sql connection code///////////////////////

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True");
        // SqlCommand com, com1, com2, com3;
        //string query;

        // /////////////////////////////////////////////////////////////////


        public static string logged_username;
        public static string logged_userpassword;
        public static string logged_userHashkey;

        public static string userWalletAddress;

        public DownloadMiner()
        {
            InitializeComponent();
            Init_Data();
        }

        class JSONClass
        {
            public RX470 RX470 { get; set; }
            public Vega56 Vega56 { get; set; }
            public RX570 RX570 { get; set; }
            public RX570 RX580 { get; set; }
            public GTX1050 GTX1050 { get; set; }
            public GTX1050TI GTX1050TI { get; set; }
            public GTX1080 GTX1080 { get; set; }
            public GTX1080TI GTX1080TI { get; set; }
            public P104 P104 { get; set; }

        }

        class RX470
        {
            public List<string> CoinsList { get; set; }

        }
        class Vega56
        {
            public List<string> CoinsList { get; set; }

        }

        class RX570
        {
            public List<string> CoinsList { get; set; }

        }
        class RX580
        {
            public List<string> CoinsList { get; set; }

        }

        class GTX1080
        {
            public List<string> CoinsList { get; set; }

        }

        class GTX1080TI
        {
            public List<string> CoinsList { get; set; }

        }

        class GTX1050
        {
            public List<string> CoinsList { get; set; }

        }

        class GTX1050TI
        {
            public List<string> CoinsList { get; set; }

        }

        class P104
        {
            public List<string> CoinsList { get; set; }

        }

        private void Applybtn_MouseEnter(object sender, EventArgs e)
        {
            download.BackColor = Color.DeepSkyBlue;
            download.ForeColor = Color.White;
        }

        private void Applybtn_MouseLeave(object sender, EventArgs e)
        {
            download.BackColor = Color.White;
            download.ForeColor = Color.DeepSkyBlue;
        }


        public static string passing_userWalletAddress
        {
            get { return userWalletAddress; }
            set { userWalletAddress = value; }
        }

        private void DownloadMiner_Form_Paint(object sender, PaintEventArgs e)
        {
            //logged user identity getting from Login_Form  starts

            logged_username = Login_Form.passing_username;
            logged_userpassword = Login_Form.passing_userpassword;
            logged_userHashkey = Login_Form.passing_userHashkey;


            //logged user identity getting from Login_Form ends


            //logged user identity print  starts

            getting_username.Text = logged_username;
            // getting_userpassword.Text = logged_userpassword;
            getting_user_Hashkey.Text = logged_userHashkey;


            //logged user identity print  ends
        }
        //  string wallt = wallet_address_textbox.Text;


        private void download_Click(object sender, EventArgs e)
        {


            save_data();
            try
            {
                try
                {


                    i = 0;

                    //if (Properties.Settings.Default.CoinName != Miner_combo.Text)
                    //{

                        if (Properties.Settings.Default.AMD_found == "AMD Found")
                        {

                            System.IO.DirectoryInfo di = new DirectoryInfo(@"C:\SkyNet\SkyNet\DownloadedMiners\");

                            foreach (FileInfo file in di.GetFiles())
                            {
                                file.Delete();
                            }
                            foreach (DirectoryInfo dir in di.GetDirectories())
                            {
                                dir.Delete(true);
                            }

                            // Data1();



                            var item = this.Miner_combo.GetItemText(this.Miner_combo.SelectedItem);

                            //wallet address passingg from here...
                            passing_userWalletAddress = wallet_address_textbox.Text;

                            Console.WriteLine(item + "" + AMD_GPU_Name);
                            using (WebClient webClient = new WebClient())
                            {

                                webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/Desktopdownloadfile.php?id=" + item + "" + AMD_GPU_Name + " ", @"C:\SkyNet\SkyNet\DownloadedMiners\" + item + "" + AMD_GPU_Name + ".zip");

                            }
                            string zipPath = @"C:\SkyNet\SkyNet\DownloadedMiners\" + item + "" + AMD_GPU_Name + ".zip";
                            string extractPath = @"C:\SkyNet\SkyNet\DownloadedMiners\";

                            ZipFile.ExtractToDirectory(zipPath, extractPath);
                            System.IO.File.Delete(@"C:\SkyNet\SkyNet\DownloadedMiners\" + item + "" + AMD_GPU_Name + ".zip");

                        }
                        // /////////////// Nvidia miner download ////////////////
                        if (Properties.Settings.Default.Nvidia_found == "Nvidia Found")
                        {

                            System.IO.DirectoryInfo di = new DirectoryInfo(@"C:\SkyNet\SkyNet\Nvidia_miner\");

                            foreach (FileInfo file in di.GetFiles())
                            {
                                file.Delete();
                            }
                            foreach (DirectoryInfo dir in di.GetDirectories())
                            {
                                dir.Delete(true);
                            }

                            //  Data1();



                            var item = this.Miner_combo.GetItemText(this.Miner_combo.SelectedItem);

                            //wallet address passingg from here...
                            passing_userWalletAddress = wallet_address_textbox.Text;

                            Console.WriteLine(item + "" + Nvidia_GPU_Name);
                            using (WebClient webClient = new WebClient())
                            {

                                //System.Diagnostics.Process.Start("http://3.20.158.33/DTS-Optimizing-portal/Desktopdownloadfile.php?id=" + item + "" + AMD_GPU_Name + " ");
                                webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/Desktopdownloadfile.php?id=" + item + "" + Nvidia_GPU_Name + " ", @"C:\SkyNet\SkyNet\Nvidia_miner\" + item + "" + Nvidia_GPU_Name + ".zip");

                            }
                            /*Console.WriteLine("Selected Item");*/
                            Console.WriteLine(Nvidia_GPU_Name);
                            string zipPath = @"C:\SkyNet\SkyNet\Nvidia_miner\" + item + "" + Nvidia_GPU_Name + ".zip";
                            string extractPath = @"C:\SkyNet\SkyNet\Nvidia_miner\";
                            // System.IO.File.Delete(zipPath);

                            //   ZipFile.CreateFromDirectory(startPath, zipPath);

                            ZipFile.ExtractToDirectory(zipPath, extractPath);
                            System.IO.File.Delete(@"C:\SkyNet\SkyNet\Nvidia_miner\" + item + "" + Nvidia_GPU_Name + ".zip");

                        }


                        // /////////////////////// Delete data from all tables Coding, starts ////////////////////

                        try
                        {

                            connection.Open();

                            SqlCommand com = new SqlCommand();
                            com.Connection = connection;
                            com.CommandText = "DELETE FROM AMD_GpuData";

                            SqlCommand com1 = new SqlCommand();
                            com1.Connection = connection;
                            com1.CommandText = "DELETE FROM Stats_AMD_GPUsData";

                            SqlCommand com2 = new SqlCommand();
                            com2.Connection = connection;
                            com2.CommandText = "DELETE FROM Nvidia_GpuData";

                            SqlCommand com3 = new SqlCommand();
                            com3.Connection = connection;
                            com3.CommandText = "DELETE FROM Stats_Nvidia_GPUsData";

                            com.ExecuteNonQuery();
                            com1.ExecuteNonQuery();
                            com2.ExecuteNonQuery();
                            com3.ExecuteNonQuery();
                            connection.Close();


                        }
                        catch
                        {

                        }
                        // /////////////////////// Delete data from all tables Coding, end ////////////////////          
                        ChangeLB.Visible = true;
                    //}
                    //else {

                    //    String Cname = Properties.Settings.Default.CoinName;
                    //    MessageBox.Show(Cname+" is already applied.");

                    //}

                }
                catch
                {
                    MessageBox.Show("Kindly Stop Mining then change coin\n Thank You!");
                }

            }
            catch
            {
                MessageBox.Show("Kindly Check You Internet Connection!");

            }
        }


        public void Data1()
        {

            int ADLRet = -1;
            int NumberOfAdapters = 0;


            if (null != ADL.ADL_Main_Control_Create)
                // Second parameter is 1: Get only the present adapters
                ADLRet = ADL.ADL_Main_Control_Create(ADL.ADL_Main_Memory_Alloc, 1);

            if (ADL.ADL_SUCCESS == ADLRet)
            {
                if (null != ADL.ADL_Adapter_NumberOfAdapters_Get)
                {
                    ADL.ADL_Adapter_NumberOfAdapters_Get(ref NumberOfAdapters);
                }
                ///Console.WriteLine("Number Of Adapters: " + NumberOfAdapters.ToString() + "\n");

                if (0 < NumberOfAdapters)
                {
                    // Get OS adpater info from ADL
                    ADLAdapterInfoArray OSAdapterInfoData;
                    OSAdapterInfoData = new ADLAdapterInfoArray();

                    if (null != ADL.ADL_Adapter_AdapterInfo_Get)
                    {
                        IntPtr AdapterBuffer = IntPtr.Zero;
                        int size = Marshal.SizeOf(OSAdapterInfoData);
                        AdapterBuffer = Marshal.AllocCoTaskMem((int)size);
                        Marshal.StructureToPtr(OSAdapterInfoData, AdapterBuffer, false);



                        if (null != ADL.ADL_Adapter_AdapterInfo_Get)
                        {
                            ADLRet = ADL.ADL_Adapter_AdapterInfo_Get(AdapterBuffer, size);
                            if (ADL.ADL_SUCCESS == ADLRet)
                            {
                                OSAdapterInfoData = (ADLAdapterInfoArray)Marshal.PtrToStructure(AdapterBuffer, OSAdapterInfoData.GetType());
                                int IsActive = 0;
                                for (int i = 0; i < 1; i++)
                                {
                                    // int[] Pcislot = new int[NumberOfAdapters];

                                    // Check if the adapter is active
                                    if (null != ADL.ADL_Adapter_Active_Get)
                                        ADLRet = ADL.ADL_Adapter_Active_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, ref IsActive);

                                    if (ADL.ADL_SUCCESS == ADLRet)
                                    {
                                        gname = OSAdapterInfoData.ADLAdapterInfo[0].AdapterName;

                                        // Console.WriteLine("Adapter Name : " + name);

                                    }

                                }

                                if (null != ADL.ADL_Main_Control_Destroy)
                                    ADL.ADL_Main_Control_Destroy();

                                else
                                {
                                    Console.WriteLine("ADL_Main_Control_Create() returned error code " + ADLRet.ToString());
                                    Console.WriteLine("\nCheck if ADL is properly installed!\n");
                                }

                            }
                        }
                    }
                }
            }

        }

        private void DownloadMiner_Load_1(object sender, EventArgs e)
        {

            Nvidia_GPU_Name = Properties.Settings.Default.Nvidia_GPUName;
            AMD_GPU_Name = Properties.Settings.Default.GPUName;
            if (!(System.IO.File.Exists(@"C:\MinerSelect.json"))) //check if drivers file exists 
            {

                using (WebClient webClient = new WebClient())
                {
                    //System.Diagnostics.Process.Start("http://3.20.158.33/DTS-Optimizing-portal/Desktopdownloadfile.php?id=" + item + "" + AMD_GPU_Name + " ");
                    webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/Desktopdownloadfile.php?id=MinerSelectJson", @"C:\MinerSelect.json");

                }
            }
            else
            {
                System.IO.File.Delete(@"C:\MinerSelect.json");
                using (WebClient webClient = new WebClient())
                {
                    //System.Diagnostics.Process.Start("http://3.20.158.33/DTS-Optimizing-portal/Desktopdownloadfile.php?id=" + item + "" + AMD_GPU_Name + " ");
                    webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/Desktopdownloadfile.php?id=MinerSelectJson", @"C:\MinerSelect.json");

                }

            }

            String ResultJson = File.ReadAllText(@"C:\MinerSelect.json");
            JSONClass result = JsonConvert.DeserializeObject<JSONClass>(ResultJson);

            // ///////////////////////code for AMD GPUs check///////////////////////
            //Data1();
            List<string> AMD_List = new List<string>();
            List<string> NVIDIA_List = new List<string>();



            // if AMD is present but NVIDIA not starts ///////////////////

            if (Properties.Settings.Default.AMD_found == "AMD Found" && Properties.Settings.Default.Nvidia_found != "Nvidia Found")
            {
                if (AMD_GPU_Name == "470")
                {
                    Miner_combo.Items.Clear();
                    foreach (var t in result.RX470.CoinsList)
                    {

                        Miner_combo.Items.Add(t);

                    }
                }
                else if (AMD_GPU_Name == "570")
                {
                    Miner_combo.Items.Clear();
                    foreach (var t in result.RX570.CoinsList)
                    {
                        Miner_combo.Items.Add(t);
                    }
                }
                else if (AMD_GPU_Name == "580")
                {
                    Miner_combo.Items.Clear();
                    foreach (var t in result.RX580.CoinsList)
                    {
                        Miner_combo.Items.Add(t);
                    }
                }
            }

            // if AMD is present but NVIDIA not ends ///////////////////

            // if NVIDIA is present but AMD is not Starts ///////////////////

            else if (Properties.Settings.Default.AMD_found != "AMD Found" && Properties.Settings.Default.Nvidia_found == "Nvidia Found")
            {
                if (Nvidia_GPU_Name == "1080")
                {
                    Miner_combo.Items.Clear();
                    foreach (var t in result.GTX1080.CoinsList)
                    {
                        Miner_combo.Items.Add(t);
                    }
                }
                else if (Nvidia_GPU_Name == "1080 Ti")
                {
                    Miner_combo.Items.Clear();
                    foreach (var t in result.GTX1080TI.CoinsList)
                    {
                        Miner_combo.Items.Add(t);
                    }
                }
                else if (Nvidia_GPU_Name == "1050")
                {
                    Miner_combo.Items.Clear();
                    foreach (var t in result.GTX1050.CoinsList)
                    {
                        Miner_combo.Items.Add(t);
                    }
                }

                else if (Nvidia_GPU_Name == "1050 Ti")
                {
                    Miner_combo.Items.Clear();
                    foreach (var t in result.GTX1050TI.CoinsList)
                    {
                        Miner_combo.Items.Add(t);
                    }
                }

                else if (Nvidia_GPU_Name == "P104")
                {
                    Miner_combo.Items.Clear();
                    foreach (var t in result.P104.CoinsList)
                    {

                        Miner_combo.Items.Add(t);
                        //NVIDIA_List.Add(t);
                        // Console.WriteLine(t);
                    }
                }
            }


            // if NVIDIA is present but AMD is not ends ///////////////////


            // if NVIDIA and AMD both are present starts ///////////////////

            else if (Properties.Settings.Default.AMD_found == "AMD Found" && Properties.Settings.Default.Nvidia_found == "Nvidia Found")
            {
                //AMD
                if (AMD_GPU_Name == "470")
                {
                    // Miner_combo.Items.Clear();
                    foreach (var t in result.RX470.CoinsList)
                    {
                        AMD_List.Add(t);
                    }
                }
                else if (AMD_GPU_Name == "570")
                {
                    // Miner_combo.Items.Clear();
                    foreach (var t in result.RX570.CoinsList)
                    {
                        AMD_List.Add(t);
                    }
                }
                else if (AMD_GPU_Name == "580")
                {
                    // Miner_combo.Items.Clear();
                    foreach (var t in result.RX580.CoinsList)
                    {
                        AMD_List.Add(t);
                    }
                }
                // NVIDIA
                if (Nvidia_GPU_Name == "1080")
                {
                    // Miner_combo.Items.Clear();
                    foreach (var t in result.GTX1080.CoinsList)
                    {
                        NVIDIA_List.Add(t);
                    }
                }
                else if (Nvidia_GPU_Name == "1080 Ti")
                {
                    // Miner_combo.Items.Clear();
                    foreach (var t in result.GTX1080TI.CoinsList)
                    {
                        NVIDIA_List.Add(t);
                    }
                }
                else if (Nvidia_GPU_Name == "1050")
                {
                    // Miner_combo.Items.Clear();
                    foreach (var t in result.GTX1050.CoinsList)
                    {
                        NVIDIA_List.Add(t);
                    }
                }

                else if (Nvidia_GPU_Name == "1050 Ti")
                {
                    // Miner_combo.Items.Clear();
                    foreach (var t in result.GTX1050TI.CoinsList)
                    {
                        NVIDIA_List.Add(t);

                    }
                }

                else if (Nvidia_GPU_Name == "P104")
                {
                    // Miner_combo.Items.Clear();
                    foreach (var t in result.P104.CoinsList)
                    {

                        NVIDIA_List.Add(t);
                        // Console.WriteLine(t);
                    }
                }

                Miner_combo.Items.Clear();
                IEnumerable<string> res = AMD_List.AsQueryable().Intersect(NVIDIA_List);
                foreach (string i in res)
                {
                    Miner_combo.Items.Add(i);
                    Console.WriteLine(i);
                }


            }
            Miner_combo.SelectedIndex = 0;


            // if NVIDIA and AMD both are present ends ///////////////////

            // /////////////////////////////////////////////////////////////////////


            // /////////////////////////////////////////////////////////////////////



        }

        // ///////////////////////////////// Get data from prroperties Credentials coding starts ///////////////////////////
        private void Init_Data()
        {

            if (Properties.Settings.Default.UserName != String.Empty && Properties.Settings.Default.UserName != "User Name")
            {

                getting_username.Text = Properties.Settings.Default.UserName;
                getting_user_Hashkey.Text = Properties.Settings.Default.HashKey;
                wallet_address_textbox.Text = Properties.Settings.Default.WalletAdd;


            }
        }

        // ///////////////////////////////// Get data from prroperties Credentials coding ends ///////////////////////////

        // ///////////////////////////////// Save data from prroperties Credentials coding starts ///////////////////////////


        private void save_data()
        {

            Properties.Settings.Default.WalletAdd = wallet_address_textbox.Text;
            string CM = Miner_combo.SelectedItem.ToString();
            Console.WriteLine(CM);
            Properties.Settings.Default.CoinName = Miner_combo.SelectedItem.ToString();

            Properties.Settings.Default.Save();
        }

        // ///////////////////////////////// Save data from prroperties Credentials coding ends ///////////////////////////

    }
}
