using ATI.ADL;
using SKY.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using Timer = System.Windows.Forms.Timer;
using Microsoft.Win32;
using System.Media;

namespace SKY
{
    public partial class Dashboard : Form
    {
        //public static Splash splash { get; set; }
        int days, hours, mins, secs, millisec;
        public int b;
        public static string logged_username;
        //DateTime start;
        Boolean m_btn = false;
        Thread amd_Data;
        Thread amd_stats_Data;
        Thread nvidia_Data;
        Thread nvidia_stats_Data; 
        Thread nvidiadata;
        Thread miner_stop;
        //  Thread Nvidia_Start_Miner;
        Thread N_miner_stop;
        string gname;
        static string GPU_Name;
        static string N_GPU_Name;
        int AR = 0; // AR stand for Already RUn

        // ///////////////// Database Connection Codev starts //////////////////////////////////// 

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True");
        SqlCommand command;
        string query;

        // ///////////////// Database Connection Codev ends //////////////////////////////////// 



        Ethminer_Api_communication eth = new Ethminer_Api_communication();
        Nvidia_Ethminer_Api_communication N_eth = new Nvidia_Ethminer_Api_communication();
        Nvidiasmi nvidia_data = new Nvidiasmi();

        fetch_data fetchdata = new fetch_data();


        public Dashboard()
        {
            Splash s = new Splash();
            this.ShowInTaskbar = true;
            Thread t = new Thread(new ThreadStart(Splash));



            t.Start();
            InitializeComponent();
            softwareDriver sd = new softwareDriver();
            controls.reboot_popup rp = new reboot_popup();
            // Dashboard D = new Dashboard();
            sd.run();
            //Properties.Settings.Default.AMD_Reboot_status = "yes";
            if (sd.yes == true)
            {
                Properties.Settings.Default.splash_LB = "Please wait while system configure application...";
                Properties.Settings.Default.splash_perLB = "100%";

                Thread.Sleep(5000);
                t.Abort();
                string AMD_chk_rebot_status = Properties.Settings.Default.AMD_Reboot_status;
                string NVIDIA_chk_rebot_status = Properties.Settings.Default.NVIDIA_Reboot_status;

                Console.WriteLine("AMD = "+AMD_chk_rebot_status + " , Nvidia = "+ NVIDIA_chk_rebot_status);

                if (AMD_chk_rebot_status == "yes" || NVIDIA_chk_rebot_status == "yes") // yes means driver is install
                {

                    Properties.Settings.Default.CoinName = "Ethereum";
                    rp.Show();
                    rp.BringToFront();
                }

                else { }
                

            }


            else if (sd.yes == false)
            {
                // //////////// delete sky folder is driver are not found code starts////////////

                //System.IO.Directory.Delete(@"C:\SkyNet");

                //////////// deketesky folder is driver are not found code end ////////////

                DialogResult res = MessageBox.Show("No GPU Found", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                if (res == DialogResult.OK)
                {
                    Application.Exit();


                }



            }
            else
            {
                t.Join();
            }

            days = hours = mins = secs = 0;
            timer1.Stop();



        }

        public async void WaitSomeTime()
        {
            await Task.Delay(5000);
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }
        public void Splash()
        {
            // splash = new Splash();           
            try
            {
                Application.Run(new Splash());
            }
            catch
            {
            }

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // //////// Check all DLL

            Console.WriteLine("#########################################################################");

            System.Reflection.Assembly[] ar = AppDomain.CurrentDomain.GetAssemblies();

            foreach (System.Reflection.Assembly a in ar)
            {
                Console.WriteLine("{0}", a.FullName);
            }

            Console.WriteLine("#########################################################################");

            //RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\run", true);
            //reg.SetValue("SKY", Application.ExecutablePath.ToString());
            GetComponent("Win32_VideoController ", "Name");
            save_data();
            Nvidia_coin.Text = Properties.Settings.Default.CoinName;
            AMD_coin.Text = Properties.Settings.Default.CoinName;

            // //////////// fetch coin name and change image code start/////////////

            Nvidia_coin.Text = Properties.Settings.Default.CoinName;
            AMD_coin.Text = Properties.Settings.Default.CoinName;
            if (AMD_coin.Text == "Pirl")
            {
                AMD_coin_iconPB.Image = Properties.Resources.pearl;
            }
            if (Nvidia_coin.Text == "Pirl")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.pearl;
            }
            if (AMD_coin.Text == "Ethereum")
            {
                AMD_coin_iconPB.Image = Properties.Resources.ethereum;
            }
            if (Nvidia_coin.Text == "Ethereum")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.ethereum;
            }
            if (AMD_coin.Text == "Ethereum Classic")
            {
                AMD_coin_iconPB.Image = Properties.Resources.ethereum_classic;
            }
            if (Nvidia_coin.Text == "Ethereum Classic")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.ethereum_classic;
            }
            if (AMD_coin.Text == "Joy")
            {
                AMD_coin_iconPB.Image = Properties.Resources.joy;
            }
            if (Nvidia_coin.Text == "Joy")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.joy;
            }
            if (AMD_coin.Text == "Nilu")
            {
                AMD_coin_iconPB.Image = Properties.Resources.nilu;
            }
            if (Nvidia_coin.Text == "Nilu")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.nilu;
            }

            // //////////// fetch coin name and change image code end/////////////


            //dashboard_coinname.Text = Properties.Settings.Default.CoinName;
            dashboard_coinname.Text = Properties.Settings.Default.CoinName;
            Nvidia_coin.Text = Properties.Settings.Default.CoinName;
            AMD_coin.Text = Properties.Settings.Default.CoinName;

            /////////////////////////////////////////////////

            // //////////////////////// Code for user name Started /////////////////////
            string UserName = Properties.Settings.Default.UserName;

            Char deli = '@';
            String[] UName = UserName.Split(deli);
            Console.WriteLine(UName[0]);

            dashboard_username.Text = UName[0];

            // //////////////////////// Code for user name end /////////////////////

            //dashboard username starts

            //   logged_username = Login_Form.passing_username;
            //  dashboard_username.Text = logged_username;

            //dashboard  username ends
            // ////////////////////////fetch Nvidia database table data//////////
            try
            {
                connection.Open();
                query = "select name,memutil,GPUutil,tempminer,fanspeed,power,Hashrate from Nvidia_GpuData";
                command = new SqlCommand(query, connection);


                SqlDataReader dr = command.ExecuteReader();
                GC1minerdata.Rows.Clear();


                while (dr.Read())
                {
                    GC1minerdata.Rows.Add(dr[0], dr[1] + " GB", dr[2] + " %", dr[3] + " C", dr[4] + " %", dr[5] + " W", dr[6] + " MH/s");
                }
                connection.Close();


            }
            catch
            {
            }

            // ////////////////////////////////////////////////////////////////

            // ////////////////////////fetch AMD database table data//////////

            try
            {
                connection.Open();
                query = "select name,memutil,GPUutil,tempminer,fanspeed,power,Hashrate from AMD_GpuData";
                command = new SqlCommand(query, connection);


                SqlDataReader dr = command.ExecuteReader();
                GC2minerdata.Rows.Clear();


                while (dr.Read())
                {
                    GC2minerdata.Rows.Add(dr[0], dr[1] + " GB", dr[2] + " %", dr[3] + " C", dr[4] + " %", dr[5] + " W", dr[6] + " MH/s");
                }
                connection.Close();


            }
            catch
            {
            }

            // ////////////////////////////////////////////////////////////////


            //Power and Hash Rate code

            double GC1HR_sum = 0;//Nvidia GPU Hash Rate sum variable
            double GC1P_sum = 0;//Nvidia GPU Power sum variable
            double GC2HR_sum = 0;//AMD GPU Hash Rate sum variable
            double GC2P_sum = 0;//AMD Power sum variable

            //Calculate Total Nvidia GPUs power and Hash Rate
            for (int i = 0; i < GC1minerdata.Rows.Count; ++i)
            {
                try
                {
                    string P = Convert.ToString(GC1minerdata.Rows[i].Cells[5].Value);
                    string HR = Convert.ToString(GC1minerdata.Rows[i].Cells[6].Value);

                    Char delimiter = ' ';
                    String[] substrings1 = P.Split(delimiter);
                    string P_AB = substrings1[0];// Power after break
                    double P_ABN = Convert.ToDouble(P_AB);
                    GC1P_sum += P_ABN;


                    String[] substrings = HR.Split(delimiter);
                    string HR_AB = substrings[0];// hash rate after break
                    double HR_ABN = Convert.ToDouble(HR_AB);
                    GC1HR_sum += HR_ABN;
                }
                catch { }
            }

            //Calculate Total AMD GPUs power and Hash Rate
            for (int i = 0; i < GC2minerdata.Rows.Count; ++i)
            {
                try
                {
                    string P = Convert.ToString(GC2minerdata.Rows[i].Cells[5].Value);
                    string HR = Convert.ToString(GC2minerdata.Rows[i].Cells[6].Value);

                    Char delimiter = ' ';
                    String[] substrings1 = P.Split(delimiter);
                    string P_AB = substrings1[0];// Power after break
                    double P_ABN = Convert.ToDouble(P_AB);
                    GC2P_sum += P_ABN;


                    String[] substrings = HR.Split(delimiter);
                    string HR_AB = substrings[0];// hash rate after break
                    double HR_ABN = Convert.ToDouble(HR_AB);
                    GC2HR_sum += HR_ABN;
                }
                catch { }
            }


            Nvidia_GPU_Total_Hashrate.Text = GC1HR_sum.ToString();
            double Nvidia_TP = GC1P_sum;//Total  Nvidia GPUS Power  

            AMD_GPU_Total_Hashrate.Text = GC2HR_sum.ToString();
            double AMD_TP = GC2P_sum; //Total  AMD GPUS Power

            double THR_sum = GC1HR_sum + GC2HR_sum;
            double Total_power = Nvidia_TP + AMD_TP;

            lbtotalpower.Text = Total_power.ToString() + " W";
            lbtotalhashrate.Text = THR_sum.ToString() + " MH/S";

            //Power and Hash Rate code end

            this.ShowInTaskbar = true;

            InitTimer();

            if (Properties.Settings.Default.AMD_found == "AMD Found")
            {
                AMD_panel.Visible = true;
                AmdStatsTabPanel.Visible = true;
            }
            else
            {
                AMD_panel.Visible = false;
                AmdStatsTabPanel.Visible = false;

            }

            if (Properties.Settings.Default.Nvidia_found == "Nvidia Found")
            {

                Nvidia_panel.Visible = true;
                NvidiaStatsTabPanel.Visible = true;
            }
            else
            {
                Nvidia_panel.Visible = false;
                NvidiaStatsTabPanel.Visible = false;

            }

        }


        public void InitTimer()
        {

            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer2_Tick);
            timer1.Interval = 31000; // in miliseconds
            timer1.Start();

            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer1_Tick);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Nvidia data fetch
            // ////////////////////////fetch Nvidia database table data//////////
            try
            {
                connection.Open();
                query = "select name,memutil,GPUutil,tempminer,fanspeed,power,Hashrate from Nvidia_GpuData";
                command = new SqlCommand(query, connection);


                SqlDataReader dr = command.ExecuteReader();
                GC1minerdata.Rows.Clear();


                while (dr.Read())
                {
                    GC1minerdata.Rows.Add(dr[0], dr[1] + " GB", dr[2] + " %", dr[3] + " C", dr[4] + " %", dr[5] + " W", dr[6] + " MH/s");
                }
                connection.Close();


            }
            catch
            {
            }

            //AMD data fetch
            try
            {

                query = "select name,memutil,GPUutil,tempminer,fanspeed,power,Hashrate from AMD_GpuData";
                command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                GC2minerdata.Rows.Clear();


                while (dr.Read())
                {

                    GC2minerdata.Rows.Add(dr[0], dr[1] + " GB", dr[2] + " %", dr[3] + " C", dr[4] + " %", dr[5] + " W", dr[6] + " MH/s");
                }
                connection.Close();


            }
            catch
            {
            }

            //Power and Hash Rate code

            double GC1HR_sum = 0;//Nvidia GPU Hash Rate sum variable
            double GC1P_sum = 0;//Nvidia GPU Power sum variable
            double GC2HR_sum = 0;//AMD GPU Hash Rate sum variable
            double GC2P_sum = 0;//AMD Power sum variable


            //Calculate Total Nvidia GPUs power and Hash Rate
            for (int i = 0; i < GC1minerdata.Rows.Count; ++i)
            {
                try
                {
                    string P = Convert.ToString(GC1minerdata.Rows[i].Cells[5].Value);
                    string HR = Convert.ToString(GC1minerdata.Rows[i].Cells[6].Value);

                    Char delimiter = ' ';
                    String[] substrings1 = P.Split(delimiter);
                    string P_AB = substrings1[0];// Power after break
                    double P_ABN = Convert.ToDouble(P_AB);
                    GC1P_sum += P_ABN;


                    String[] substrings = HR.Split(delimiter);
                    string HR_AB = substrings[0];// hash rate after break
                    double HR_ABN = Convert.ToDouble(HR_AB);
                    GC1HR_sum += HR_ABN;
                }
                catch { }
            }

            //Calculate Total AMD GPUs power and Hash Rate
            for (int i = 0; i < GC2minerdata.Rows.Count; ++i)
            {

                try
                {
                    string P = Convert.ToString(GC2minerdata.Rows[i].Cells[5].Value);
                    string HR = Convert.ToString(GC2minerdata.Rows[i].Cells[6].Value);

                    Char delimiter = ' ';
                    String[] substrings1 = P.Split(delimiter);
                    string P_AB = substrings1[0];// Power after break
                    double P_ABN = Convert.ToDouble(P_AB);
                    GC2P_sum += P_ABN;


                    String[] substrings = HR.Split(delimiter);
                    string HR_AB = substrings[0];// hash rate after break
                    double HR_ABN = Convert.ToDouble(HR_AB);
                    GC2HR_sum += HR_ABN;
                }
                catch
                {
                    // nothing
                }
            }


            Nvidia_GPU_Total_Hashrate.Text = GC1HR_sum.ToString();
            double Nvidia_TP = GC1P_sum;//Total  Nvidia GPUS Power  

            AMD_GPU_Total_Hashrate.Text = GC2HR_sum.ToString();
            double AMD_TP = GC2P_sum; //Total  AMD GPUS Power

            double THR_sum = GC1HR_sum + GC2HR_sum;
            double Total_power = Nvidia_TP + AMD_TP;

            lbtotalpower.Text = Total_power.ToString() + " W";
            lbtotalhashrate.Text = THR_sum.ToString() + " MH/S";

            //Power and Hash Rate code end

            // ///////////beep sound code starts/////////////////

            //SoundPlayer sp = new SoundPlayer(@"C:\SkyNet\SkyNet\beep-06.wav");
            //sp.Play();

            // ///////////beep sound code ends/////////////////

        }




        private void Btnstates(object sender, EventArgs e)
        {
            Nvidia_Stats_Controls control = new Nvidia_Stats_Controls();
            ShowControl(control);
        }


        private void Btnsetting(object sender, EventArgs e)
        {

            Setting_control control = new Setting_control();

            ShowControl(control);
        }


        public void ShowControl(Control control)
        {
            ControlsPanel.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            ControlsPanel.Controls.Add(control);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Nvidia_coin.Text = Properties.Settings.Default.CoinName;
            AMD_coin.Text = Properties.Settings.Default.CoinName;
            Console.WriteLine(Nvidia_coin.Text+"&&"+ AMD_coin.Text);

            if (AMD_coin.Text == "Pirl")
            {
                AMD_coin_iconPB.Image = Properties.Resources.pearl;
            }
            if (Nvidia_coin.Text == "Pirl")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.pearl;
            }
            if (AMD_coin.Text == "Ethereum")
            {
                AMD_coin_iconPB.Image = Properties.Resources.ethereum;
            }
            if (Nvidia_coin.Text == "Ethereum")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.ethereum;
            }
            if (AMD_coin.Text == "Ethereum Classic")
            {
                AMD_coin_iconPB.Image = Properties.Resources.ethereum_classic;
            }
            if (Nvidia_coin.Text == "Ethereum Classic")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.ethereum_classic;
            }
            if (AMD_coin.Text == "Joy")
            {
                AMD_coin_iconPB.Image = Properties.Resources.joy;
            }
            if (Nvidia_coin.Text == "Joy")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.joy;
            }
            if (AMD_coin.Text == "Nilu")
            {
                AMD_coin_iconPB.Image = Properties.Resources.nilu;
            }
            if (Nvidia_coin.Text == "Nilu")
            {
                Nvidia_coin_iconPB.Image = Properties.Resources.nilu;
            }

            this.Refresh();
            ShowControl(Dashboardpanel);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Support_Control control = new Support_Control();
            ShowControl(control);
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Aboutbtn_Click(object sender, EventArgs e)
        {
            About_Control control = new About_Control();
            ShowControl(control);
        }

        private void Download_Miner_Click(object sender, EventArgs e)
        {
            DownloadMiner control = new DownloadMiner();
            ShowControl(control);
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
                                    // Check if the adapter is active
                                    if (null != ADL.ADL_Adapter_Active_Get)
                                        ADLRet = ADL.ADL_Adapter_Active_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, ref IsActive);

                                    if (ADL.ADL_SUCCESS == ADLRet)
                                    {
                                        gname = OSAdapterInfoData.ADLAdapterInfo[0].AdapterName;

                                    }

                                }

                                if (null != ADL.ADL_Main_Control_Destroy)
                                    ADL.ADL_Main_Control_Destroy();

                                else
                                {
                                }

                            }
                        }
                    }
                }
            }

        }


        string msg;
        private void Mining_start_stop_btn_Click(object sender, EventArgs e)
        {

            if (m_btn == false)
            {

                string amd_set = Properties.Settings.Default.amd_miner_setting;
                string nvidia_set = Properties.Settings.Default.Nvidia_miner_setting;

                if (Properties.Settings.Default.AMD_found != "AMD Found")
                {
                    amd_set = "amd not found";
                }
                if (Properties.Settings.Default.Nvidia_found != "Nvidia Found")
                {
                    nvidia_set = "nvidia not found";
                }

                if (amd_set != "" || nvidia_set != "")
                {

                    if (Properties.Settings.Default.AMD_found == "AMD Found" && Properties.Settings.Default.Nvidia_found == "Nvidia Found")
                    {
                        msg = "\tAre you sure to start miner wth this setting\t\n\t NVIDIA Miner: " + nvidia_set + "\t\n\t AMD Miner: " + amd_set + "\t\n\n\t Do you Cancel, to change Setting";
                    }
                    else if (Properties.Settings.Default.AMD_found == "AMD Found")
                    {
                        msg = "\tAre you sure to start miner wth this setting\t\n\t AMD Miner: " + amd_set + "\t\n\n\t Do you Cancel, to change Setting";
                    }
                    else if (Properties.Settings.Default.Nvidia_found == "Nvidia Found")
                    {
                        msg = "\tAre you sure to start miner wth this setting\t\n\t NVIDIA Miner: " + nvidia_set + "\t\n\n'\n\t Do you Cancel, to change Setting";
                    }


                    DialogResult res = MessageBox.Show(msg, "Miner Setting Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

                    if (res == DialogResult.OK)
                    {
                        //Some task…

                        GPU_Name = Properties.Settings.Default.GPUName;
                        N_GPU_Name = Properties.Settings.Default.Nvidia_GPUName;
                        Data1();

                        if (GPU_Name == "470" || GPU_Name == "570" || GPU_Name == "580" || GPU_Name == "Vega 56" || GPU_Name == "5700 XT" || GPU_Name == "Vega 54")
                        {

                            //fetch AMD data coding start
                            Mining_start_stop_btn.Text = "Loading...";
                            Mining_start_stop_btn.Enabled = false;

                            eth.Start_Miner();

                            Mining_start_stop_btn.Text = "Stop Mining";
                            Mining_start_stop_btn.Enabled = true;

                            try
                            {
                         

                                using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True"))
                                {

                                    connection.Open();

                                    // //////////////////////////////////Delete previous data////////////////////////////////// 
                                    SqlCommand com = new SqlCommand();
                                    com.Connection = connection;
                                    com.CommandText = "DELETE FROM AMD_GpuData";
                                    com.ExecuteNonQuery();



                                }
                            }
                            catch (Exception e1)
                            {
                                Console.WriteLine("Error inserting data into Database! " + e1.Message.ToString());
                            }

                            connection.Close();

                            //AMD Miner Data Fetch
                            amd_Data = new Thread(() => fetchdata.AMD_GPU_Data());//Insert data into AMD_data table for dash board grid view
                            amd_stats_Data = new Thread(() => fetchdata.AMD_GPU_Stats_Data());//Insert data into AMD_stas_data table for graphs                                                                                                     



                            // get_amd_data.Start();
                            amd_Data.Start();
                            amd_stats_Data.Start();




                            AMD_GPUStart_Stop_Lbl.Text = "Started";
                            //GCStatus.Text = "Starting";

                            AMD_Statuspng.Visible = true;
                            AMD_Statuspng.Image = Properties.Resources.GCStoppedpng;


                        }



                        if (N_GPU_Name == "1080" || N_GPU_Name == "1080 Ti" || N_GPU_Name == "P104" || N_GPU_Name == "P106" || N_GPU_Name == "1050 Ti" || N_GPU_Name == "1050")
                        {



                            Mining_start_stop_btn.Text = "Loading...";
                            Mining_start_stop_btn.Enabled = false;

                            // ////////Nvidia Miner Starts//////////////

                            N_eth.Nvidia_Start_Miner();

                            Mining_start_stop_btn.Text = "Stop Mining";
                            Mining_start_stop_btn.Enabled = true;

                            try
                            {

                                using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True"))
                                {

                                    connection.Open();

                                    // //////////////////////////////////Delete previous data////////////////////////////////// 
                                    SqlCommand com = new SqlCommand();
                                    com.Connection = connection;
                                    com.CommandText = "DELETE FROM Nvidia_GpuData";
                                    com.ExecuteNonQuery();



                                }
                            }
                            catch (Exception e1)
                            {
                                Console.WriteLine("Error inserting data into Database! " + e1.Message.ToString());
                            }

                            connection.Close();



                            nvidia_Data = new Thread(() => nvidia_data.Nvidia_GPUs_data());//Insert data into nvidia_data table for dash board grid view
                            nvidia_stats_Data = new Thread(() => nvidia_data.Nvidia_GPU_Stats_Data());//Insert data into Nvidia_GPU_Stats_Data table for graphs                                                                                                     


                            nvidia_Data.Start();
                            nvidia_stats_Data.Start();


                            Nvidia_GPUStart_Stop_Lbl.Text = "Started";
                            Nvidia_Statuspng.Image = Properties.Resources.GCStoppedpng;
                        }

                        timer2.Start();

                        m_btn = true;
                        Mining_start_stop_btn.BackColor = Color.DeepSkyBlue;
                        Mining_start_stop_btn.ForeColor = Color.White;
                        Mining_start_stop_btn.Text = "Stop Mining";


                    }
                    if (res == DialogResult.Cancel)
                    {
                        MessageBox.Show("Go to the Setting for changes");
                        //Some task…  
                    }
                }
                else
                {
                    MessageBox.Show("Go to setting and apply miner setting");

                }
            }

            else
            {

                if (Properties.Settings.Default.AMD_found == "AMD Found")
                {
                    miner_stop = new Thread(eth.Stop_Miner);
                    //amd miner stop coding
                    if (timer2.Enabled)
                    {

                        amd_Data.Abort();
                        amd_stats_Data.Abort();
                        miner_stop.Start();

                    }
                }

                if (Properties.Settings.Default.Nvidia_found == "Nvidia Found")
                {
                    N_miner_stop = new Thread(N_eth.Nvidia_Stop_Miner);
                    //  ///////// Nvidia miner stop//////////////
                    if (timer2.Enabled)
                    {
                        N_miner_stop.Start();
                        nvidia_Data.Abort();
                        nvidia_stats_Data.Abort();
                    }
                }


                timer2.Stop();
                Mining_start_stop_btn.Text = "Start Mining";
                Mining_start_stop_btn.BackColor = Color.White;
                Mining_start_stop_btn.ForeColor = Color.Black;
                AMD_GPUStart_Stop_Lbl.Text = "Stopped";
                //  GCStatus.Text = "Stopped";
                Nvidia_GPUStart_Stop_Lbl.Text = "Stopped";
                AMD_Statuspng.Image = Properties.Resources.GCStartingpng;
                Nvidia_Statuspng.Image = Properties.Resources.GCStartingpng;
                m_btn = false;




            }



        }




        public void save_data()
        {

            // ///////////////// Nvidia GPU Name code starts //////////////////////////
            Run_Process run = new Run_Process();

            object path = "\"C:\\Program Files\\NVIDIA Corporation\\NVSMI\\nvidia-smi.exe\" --query-gpu=name --format=csv,nounits,noheader";
            string result = run.ExecuteCommandSync(path, null, "output");

            // ///////////////// Nvidia GPU Name code end //////////////////////////



            Data1();

            //// /////////////////for AMD GPUs///////////////////

            //string gpu1 = "470";
            //string gpu2 = "570";
            //string gpu3 = "580";
            //string gpu4 = "Vega 56";
            //string gpu5 = "5700 XT"; 

            //// /////////////////for NVIDIA GPUs///////////////////

            //string gpu6 = "1080";
            //string gpu7 = "1080 Ti";
            //string gpu8 = "P104";
            //string gpu9 = "1050";
            //string gpu10 = "1050 Ti";

            //bool b1 = gname.Contains(gpu1);
            //bool b2 = gname.Contains(gpu2);
            //bool b3 = gname.Contains(gpu3);
            //bool b4 = gname.Contains(gpu4);
            //bool b5 = gname.Contains(gpu5);
            //bool b6 = result.Contains(gpu6);
            //bool b7 = result.Contains(gpu7);
            //bool b8 = result.Contains(gpu8);
            //bool b9 = result.Contains(gpu9);
            //bool b10 = result.Contains(gpu10);


            //if (b1 == true)
            //{
            //    GPU_Name = gpu1;
            //}
            //else if (b2 == true)
            //{
            //    GPU_Name = gpu2;
            //}
            //else if (b3 == true)
            //{
            //    GPU_Name = gpu3;
            //}
            //else if (b4 == true)
            //{
            //    GPU_Name = gpu4;
            //}
            //else if (b5 == true)
            //{
            //    GPU_Name = gpu5;
            //}
            //if (b6 == true)
            //{
            //    N_GPU_Name = gpu6;
            //}
            //else if (b7 == true)
            //{
            //    N_GPU_Name = gpu7;
            //}
            //else if (b8 == true)
            //{
            //    N_GPU_Name = gpu8;
            //}
            //else if (b9 == true)
            //{
            //    N_GPU_Name = gpu9;
            //}
            //else if (b10 == true)
            //{
            //    N_GPU_Name = gpu10;
            //}

            //Console.WriteLine(N_GPU_Name);
            //Properties.Settings.Default.GPUName = GPU_Name;
            //Properties.Settings.Default.Nvidia_GPUName = N_GPU_Name;


            //Properties.Settings.Default.Save();



        }

        private void about_support_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.AMD_found == "AMD Found")
            {
                miner_stop = new Thread(eth.Stop_Miner);
                //amd miner stop coding
                if (timer2.Enabled)
                {

                    amd_Data.Abort();
                    amd_stats_Data.Abort();
                    miner_stop.Start();

                }
            }

            if (Properties.Settings.Default.Nvidia_found == "Nvidia Found")
            {
                N_miner_stop = new Thread(N_eth.Nvidia_Stop_Miner);
                //  ///////// Nvidia miner stop//////////////
                if (timer2.Enabled)
                {
                    N_miner_stop.Start();
                    nvidia_Data.Abort();
                    nvidia_stats_Data.Abort();
                }
            }


        }

        private void exitbtn_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.AMD_found == "AMD Found")
            {
                miner_stop = new Thread(eth.Stop_Miner);
                //amd miner stop coding
                if (timer2.Enabled)
                {

                    amd_Data.Abort();
                    amd_stats_Data.Abort();
                    miner_stop.Start();

                }
            }

            if (Properties.Settings.Default.AMD_found == "Nvidia Found")
            {
                N_miner_stop = new Thread(N_eth.Nvidia_Stop_Miner);
                //  ///////// Nvidia miner stop//////////////
                if (timer2.Enabled)
                {
                    N_miner_stop.Start();
                    nvidia_Data.Abort();
                    nvidia_stats_Data.Abort();
                }
            }
            this.Close();

        }

        private void Btn_AMD_Stats_Click(object sender, EventArgs e)
        {
            AMD_Stats_Controls control = new AMD_Stats_Controls();
            ShowControl(control);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            millisec++;
            // TimeSpan duration = DateTime.Now - start;
            // metroLabel1.Text = duration.ToString(" ");
            if (millisec > 8)
            {
                secs++;
                millisec = 0;
            }
            if (secs > 59)
            {
                mins++;
                secs = 0;
            }
            if (mins > 59)
            {
                hours++;
                mins = 0;
            }
            if (hours > 23)
            {
                days++;
                hours = 0;
            }
            lbdays.Text = days.ToString();
            lbhours.Text = hours.ToString();
            lbmins.Text = mins.ToString();
            lbsecs.Text = secs.ToString();
        }

        private static void GetComponent(string hwclass, string syntax)
        {


            // /////////////////find GPUs Name code starts ///////////////////

            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);

            // /////////////////find GPUs Name code end ///////////////////


            foreach (ManagementObject mj in mos.Get())
            {

                //Console.WriteLine(Convert.ToString(mj["Name"]));
                // /////////////////for AMD GPUs///////////////////

                string gpu1 = "470";
                string gpu2 = "5700 XT";
                string gpu3 = "580";
                string gpu4 = "Vega 56";
                string gpu5 = "570";
                string gpu6 = "Vega 64";

                // /////////////////for NVIDIA GPUs///////////////////

                string gpu7 = "1080 Ti";
                string gpu8 = "1080";
                string gpu9 = "P104";
                string gpu10 = "P106";
                string gpu11 = "1050 Ti";
                string gpu12 = "1050";

                bool b1 = Convert.ToString(mj["Name"]).Contains(gpu1);
                bool b2 = Convert.ToString(mj["Name"]).Contains(gpu2);
                bool b3 = Convert.ToString(mj["Name"]).Contains(gpu3);
                bool b4 = Convert.ToString(mj["Name"]).Contains(gpu4);
                bool b5 = Convert.ToString(mj["Name"]).Contains(gpu5);
                bool b6 = Convert.ToString(mj["Name"]).Contains(gpu6);
                bool b7 = Convert.ToString(mj["Name"]).Contains(gpu7);
                bool b8 = Convert.ToString(mj["Name"]).Contains(gpu8);
                bool b9 = Convert.ToString(mj["Name"]).Contains(gpu9);
                bool b10 = Convert.ToString(mj["Name"]).Contains(gpu10);
                bool b11 = Convert.ToString(mj["Name"]).Contains(gpu11);
                bool b12 = Convert.ToString(mj["Name"]).Contains(gpu12);


                if (b1 == true)
                {
                    GPU_Name = gpu1;
                }
                else if (b2 == true)
                {
                    GPU_Name = gpu2;
                }
                else if (b3 == true)
                {
                    GPU_Name = gpu3;
                }
                else if (b4 == true)
                {
                    GPU_Name = gpu4;
                }
                else if (b5 == true)
                {
                    GPU_Name = gpu5;
                }
                else if (b6 == true)
                {
                    GPU_Name = gpu6;
                }
                if (b7 == true)
                {
                    N_GPU_Name = gpu7;
                }
                else if (b8 == true)
                {
                    N_GPU_Name = gpu8;
                }
                else if (b9 == true)
                {
                    N_GPU_Name = gpu9;
                }
                else if (b10 == true)
                {
                    N_GPU_Name = gpu10;
                }
                else if (b11 == true)
                {
                    N_GPU_Name = gpu11;
                }
                else if (b12 == true)
                {
                    N_GPU_Name = gpu12;
                }



                //Console.WriteLine(Convert.ToString(mj[syntax]));

            }
            Properties.Settings.Default.GPUName = GPU_Name;
            Properties.Settings.Default.Nvidia_GPUName = N_GPU_Name;
            Properties.Settings.Default.Save();
            //Console.WriteLine(N_GPU_Name);
            //Console.WriteLine(GPU_Name);

        }

    }

}


