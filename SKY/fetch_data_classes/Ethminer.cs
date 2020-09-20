using MSI.Afterburner;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SKY
{

    public class Ping_miner
    {
        public int id = 1;
        public string jsonrpc = "2.0";
        public string method = "miner_ping";
    }
    public class Detail_info
    {
        public int id = 1;
        public string jsonrpc = "2.0";
        public string method = "miner_getstatdetail";
    }
    public class Stats_info
    {
        public int id = 1;
        public string jsonrpc = "2.0";
        public string method = "miner_getstat1";
    }
    public class Miner_Restart
    {
        public int id = 1;
        public string jsonrpc = "2.0";
        public string method = "miner_restart";
    }
    public class Miner_Reboot
    {
        public int id = 1;
        public string jsonrpc = "2.0";
        public string method = "miner_reboot";
    }
    public class pool_connect_info
    {
        public int id = 1;
        public string jsonrpc = "2.0";
        public string method = "miner_getconnections";
    }
    public class connection_index
    {
        public int id { get; set; }
        public string jsonrpc { get; set; }
        public string method { get; set; }

        [JsonProperty("params")]
        public params_index_connection params_index_connection { get; set; }
    }
    public class params_index_connection
    {
        public int index { get; set; }
    }
    public class connection_url
    {
        public int id { get; set; }
        public string jsonrpc { get; set; }
        public string method { get; set; }

        [JsonProperty("params")]
        public params_url_connection params_url_connection { get; set; }
    }
    public class params_url_connection
    {
        public string uri { get; set; }
    }

    public class pause_resume_GPU
    {
        public int id { get; set; }
        public string jsonrpc { get; set; }
        public string method { get; set; }

        [JsonProperty("params")]
        public pause_resume_status pause_resume_status { get; set; }
    }
    public class pause_resume_status
    {
        public int index { get; set; }
        public bool pause { get; set; }

    }

    public class Nested_JSON_Data
    {
        public object Getjson_with_index(string method, string value = null)
        {
            if (method == "miner_setactiveconnection_index")
            {
                int index = Int32.Parse(value);
                connection_index command = new connection_index
                {
                    id = 1,
                    jsonrpc = "2.0",
                    method = "miner_setactiveconnection",
                    params_index_connection = new params_index_connection
                    {
                        index = index
                    }
                };
                return command;
            }
            else if (method == "miner_setactiveconnection_url")       // Currently Not Working
            {

                connection_url command = new connection_url
                {
                    id = 1,
                    jsonrpc = "2.0",
                    method = "miner_setactiveconnection",
                    params_url_connection = new params_url_connection
                    {
                        uri = value
                    }
                };
                return command;
            } ///////////////////////////////////////////////
            else if (method == "miner_addconnection_url")
            {

                connection_url command = new connection_url
                {
                    id = 1,
                    jsonrpc = "2.0",
                    method = "miner_addconnection",
                    params_url_connection = new params_url_connection
                    {
                        uri = value
                    }
                };
                return command;
            }
            else if (method == "miner_removeconnection_index")
            {
                int index = Int32.Parse(value);
                connection_index command = new connection_index
                {
                    id = 1,
                    jsonrpc = "2.0",
                    method = "miner_removeconnection",
                    params_index_connection = new params_index_connection
                    {
                        index = index
                    }
                };
                return command;
            }
            else if (method == "miner_pausegpu")
            {
                int index = Int32.Parse(value);
                pause_resume_GPU command = new pause_resume_GPU
                {
                    id = 1,
                    jsonrpc = "2.0",
                    method = "miner_pausegpu",
                    pause_resume_status = new pause_resume_status
                    {
                        index = index,
                        pause = true
                    }
                };
                return command;
            }
            else if (method == "miner_resumegpu")
            {
                int index = Int32.Parse(value);
                pause_resume_GPU command = new pause_resume_GPU
                {
                    id = 1,
                    jsonrpc = "2.0",
                    method = "miner_pausegpu",
                    pause_resume_status = new pause_resume_status
                    {
                        index = index,
                        pause = false
                    }
                };
                return command;
            }
            else if (method == "miner_ping")
            {
                Ping_miner command = new Ping_miner { };
                return command;
            }
            else if (method == "miner_Detail_info")
            {
                Detail_info command = new Detail_info { };
                return command;
            }
            else if (method == "miner_Stats_info")
            {
                Stats_info command = new Stats_info { };
                return command;
            }
            else if (method == "miner_Restart")
            {
                Miner_Restart command = new Miner_Restart { };
                return command;
            }
            else if (method == "miner_Reboot")
            {
                Miner_Reboot command = new Miner_Reboot { };
                return command;
            }
            else if (method == "miner_connect_info")
            {
                pool_connect_info command = new pool_connect_info { };
                return command;
            }
            else
            {
                return null;
            }

        }
    }

    /// <summary>
    /// ////////////////////////////////////////// Response JSON//////////////////////////////////////////////////
    /// </summary>

    /// ////////////////////////////////////Ping_Miner_Response_start/////////////////////////////////////////////////

    public class Ping_Miner_Response
    {
        public int id { get; set; }
        public string jsonrpc { get; set; }
        public string result { get; set; }
    }
    /// ////////////////////////////////////Ping_Miner_Response_End/////////////////////////////////////////////////

    /// ////////////////////////////////////Detail_info_Response_start/////////////////////////////////////////////////
    public class Detail_Info_Response
    {
        public int id { get; set; }
        public string jsonrpc { get; set; }
        [JsonProperty("result")]
        public Detail_Info_Response_Result result { get; set; }
        public float[] Temperature { get; set; }
    }
    public class Detail_Info_Response_Result
    {
        [JsonProperty("connection")]
        public Connection_Info_Detail_info_Response connection { get; set; }
        [JsonProperty("devices")]
        public Devices_Info_Detail_info_Response[] devices { get; set; }
        [JsonProperty("host")]
        public Host_Info_Detail_info_Response host { get; set; }
        [JsonProperty("mining")]
        public Mining_Info_Detail_info_Response mining { get; set; }
        public string monitors { get; set; }
    }
    public class Connection_Info_Detail_info_Response
    {
        public bool connected { get; set; }
        public int switches { get; set; }
        public string uri { get; set; }
    }
    public class Devices_Info_Detail_info_Response
    {
        public int _index { get; set; }
        public string _mode { get; set; }
        [JsonProperty("hardware")]
        public Hardware_Info_Devices_Info_Detail_info_Response hardware { get; set; }
        [JsonProperty("mining")]
        public Mining_Info_Devices_Info_Detail_info_Response mining { get; set; }

    }
    public class Hardware_Info_Devices_Info_Detail_info_Response
    {
        public string name { get; set; }
        public string pci { get; set; }
        public double[] sensors { get; set; }
        public string type { get; set; }
    }
    public class Mining_Info_Devices_Info_Detail_info_Response
    {
        public string hashrate { get; set; }
        public string pause_reason { get; set; }
        public bool paused { get; set; }
        public string[] segment { get; set; }
        public int[] shares { get; set; }
    }
    public class Host_Info_Detail_info_Response
    {
        public string name { get; set; }
        public int runtime { get; set; }
        public string version { get; set; }
    }
    public class Mining_Info_Detail_info_Response
    {
        public string difficulty { get; set; }
        public int epoch { get; set; }
        public string epoch_changes { get; set; }
        public string hashrate { get; set; }
        public int[] shares { get; set; }
    }

    /// ////////////////////////////////////Detail_info_Response_End/////////////////////////////////////////////////
    /// ////////////////////////////////////Stats_info_Response_start/////////////////////////////////////////////////
    public class Stat_Info_Response
    {
        public int id { get; set; }
        public string jsonrpc { get; set; }
        public string[] result { get; set; }
    }

    /// ////////////////////////////////////Stats_info_Response_End/////////////////////////////////////////////////
    /// ////////////////////////////////////Miner_Restart_Response_start/////////////////////////////////////////////////
    public class Common_Response
    {
        public int id { get; set; }
        public string jsonrpc { get; set; }
        public bool result { get; set; }
    }

    /// ////////////////////////////////////Miner_Restart_Response_End/////////////////////////////////////////////////
    /// ////////////////////////////////////Miner_A_Response_start/////////////////////////////////////////////////
    public class Miner_GetConnection_Response
    {
        public int id { get; set; }
        public string jsonrpc { get; set; }
        [JsonProperty("result")]
        public Miner_GetConnection_Response_Result[] result { get; set; }
    }
    public class Miner_GetConnection_Response_Result
    {
        public bool active { get; set; }
        public int index { get; set; }
        public string uri { get; set; }
    }
    /// ////////////////////////////////////Miner_Restart_Response_End/////////////////////////////////////////////////

    public class Ethminer_Api_communication
    {
        string user_walletAddress;


        // \n{\"id\":1,\"jsonrpc\":\"2.0\",\"method\":\"miner_getstatdetail\"}\n
        private string ShowResponse(string method, string value = null)
        {
            Nested_JSON_Data set_cn_index = new Nested_JSON_Data();
            string Jsonsend = JsonConvert.SerializeObject(set_cn_index.Getjson_with_index(method, value));
            //  string Jsonsend = Get_Ethminer_API_Result(method, value);
            TCP_Communication send = new TCP_Communication();
            string JsonResult = send.sendMessage(Encoding.Default.GetBytes("\n" + Jsonsend + "\n"), 4444);
            return JsonResult;
        }
        string amd_miner_set_f;

        public void Start_Miner()
        {

            string GpuName = Properties.Settings.Default.GPUName;
            string user_Wallet = Properties.Settings.Default.WalletAdd;
            // controls.DownloadMiner DM = new controls.DownloadMiner();

            // user_walletAddress = SKY.controls.DownloadMiner.passing_userWalletAddress;   
            //// Console.WriteLine(user_walletAddress);

            //Console.WriteLine(GpuName);

            // /////////////////Remove space in GPU name using if else////////////////////////

            string g_name = "";

            if (GpuName == "470")
            {
                g_name = "RX470";
            }
            else if (GpuName == "570")
            {
                g_name = "RX570";
            }
            else if (GpuName == "580")
            {
                g_name = "RX580";
            }
            else if (GpuName == "5700")
            {
                g_name = "RX5700XT";
            }
            else if (GpuName == "Vega 56")
            {
                g_name = "RXVega56";
            }
            else if (GpuName == "1080")
            {
                g_name = "GTX1080";
            }
            else if (GpuName == "1080TI")
            {
                g_name = "GTX1080TI";
            }
            else if (GpuName == "1050")
            {
                g_name = "GTX1050";
            }
            else if (GpuName == "1050TI")
            {
                g_name = "GTX1050TI";
            }
            else if (GpuName == "P104")
            {
                g_name = "P104";
            }

            Console.WriteLine("GPU name without space " + g_name);

            // /////////////// get miner setting string code starts /////////////////////////

            // for AMD
            string amd_miner_set = Properties.Settings.Default.amd_miner_setting;

            Console.WriteLine(amd_miner_set);
            if (amd_miner_set == "Default")
            {

                amd_miner_set_f = "";
            }

            else if (amd_miner_set == "DTS Optimize Setting A")
            {

                amd_miner_set_f = "--autosettings --setting A";
            }

            else if (amd_miner_set == "DTS Optimize Setting B")
            {

                amd_miner_set_f = "--autosettings --setting B";

            }
            else if (amd_miner_set == "DTS Optimize Setting C")
            {

                amd_miner_set_f = "--autosettings --setting C";

            }

            // ///////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////// Check-Miner-Firewall-Status/////////////////////////////////////////////
            Firewall_Check start = new Firewall_Check();
            //  start.run_firewall("ethminer", @"C:\SkyNet\Resources\Miners\Ethminer\ethminer.exe");
            //  start.run_firewall("ethminer", @"C:\SkyNet\Resources\Miners\Ethminer\Ethminer-AMD-Latest\ethminer.exe");
            start.run_firewall("ethminer", @"C:\SkyNet\SkyNet\DownloadedMiners\Release\ethminer.exe");

            Console.WriteLine("Wallet address :" + user_Wallet);
            Run_Process run = new Run_Process();
            //object start_command = @"C:\SkyNet\SkyNet\DownloadedMiners\Release\ethminer.exe -G -W " + user_Wallet+".RX570 --HWMON 2 -R --gpu "+g_name+" --api-port 4444 --autosettings --setting B";
            //object start_command = @"C:\SkyNet\DownloadedMiners\ethminer.exe -G -W 0x1aC3FF5297F5261ec0A18af87441CD1811c1Ab82.RX570 --HWMON 2 -R --gpu RX570 --api-port 4444 --autosettings --setting B";
            Console.WriteLine(amd_miner_set_f);
            object start_command = @"C:\SkyNet\SkyNet\DownloadedMiners\Release\ethminer.exe -G -W " + user_Wallet + ".RX570 --HWMON 2 -R --gpu " + g_name + " --api-port 4444 " + amd_miner_set_f + "";


            //object start_command = @"C:\SkyNet\Resources\Miners\Ethminer\ethminer.exe -G -P stratum1+tcp://'"+user_walletAddress+"'.RX570@etp-kor1.topmining.co.kr:8008 --HWMON 2 -R --genExcel 0 --api-port 4444";
            run.ExecuteCommandSync(start_command, "Miner_Started");
            Thread.Sleep(15000);
        }

        public void Stop_Miner()
        {
            Run_Process stop = new Run_Process();
            object stop_command = @"taskkill /F /IM ethminer.exe";
            stop.ExecuteCommandSync(stop_command, "Miner_Stopped");
        }

        private object Get_Miner_Data()
        {
            Detail_Info_Response detail_response = JsonConvert.DeserializeObject<Detail_Info_Response>(ShowResponse("miner_Detail_info"));
            return detail_response;
        }


        public void run_fetch_data()
        {
            Detail_Info_Response response = null;
            while (true)
            {

                response = (Detail_Info_Response)Get_Miner_Data();

                int decValue = Convert.ToInt32(response.result.devices[0].mining.hashrate, 16);
                double result = Convert.ToDouble(decValue) / 1000000;


                Char delimiter = ':';
                String[] substrings = response.result.devices[0].hardware.pci.Split(delimiter);

                int Pcislot = Convert.ToInt32(substrings[0], 16);

                Thread.Sleep(10000);

            }

        }
        public object initialize_data()
        {
            Detail_Info_Response response = null;
            response = (Detail_Info_Response)Get_Miner_Data();
            return response;
        }
    }

    // ////////////////// Nvidia Ethminer class code starts /////////////////////

    public class Nvidia_Ethminer_Api_communication
    {
        string user_walletAddress;


        // \n{\"id\":1,\"jsonrpc\":\"2.0\",\"method\":\"miner_getstatdetail\"}\n
        private string Nvidia_ShowResponse(string method, string value = null)
        {
            Nested_JSON_Data set_cn_index = new Nested_JSON_Data();
            string Jsonsend = JsonConvert.SerializeObject(set_cn_index.Getjson_with_index(method, value));
            //  string Jsonsend = Get_Ethminer_API_Result(method, value);
            TCP_Communication send = new TCP_Communication();
            string JsonResult = send.sendMessage(Encoding.Default.GetBytes("\n" + Jsonsend + "\n"), 3333);
            return JsonResult;
        }

        string nvidia_miner_set_f;
        public void Nvidia_Start_Miner()
        {
            string N_GpuName = Properties.Settings.Default.GPUName;
            string user_Wallet = Properties.Settings.Default.WalletAdd;
            // controls.DownloadMiner DM = new controls.DownloadMiner();

            // user_walletAddress = SKY.controls.DownloadMiner.passing_userWalletAddress;   
            //// Console.WriteLine(user_walletAddress);

            //Console.WriteLine(GpuName);


            // /////////////// get miner setting string code starts /////////////////////////

            //For Nvidia
            string nvidia_miner_set = Properties.Settings.Default.Nvidia_miner_setting;
            Console.WriteLine(nvidia_miner_set);


            if (nvidia_miner_set == "Default")
            {

                nvidia_miner_set_f = "";
            }

            else if (nvidia_miner_set == "DTS Optimize Setting A")
            {

                nvidia_miner_set_f = "--autosettings --setting A";
            }

            else if (nvidia_miner_set == "DTS Optimize Setting B")
            {

                nvidia_miner_set_f = "--autosettings --setting B";

            }
            else if (nvidia_miner_set == "DTS Optimize Setting C")
            {

                nvidia_miner_set_f = "--autosettings --setting C";

            }

            // /////////////// get miner setting string code end /////////////////////////

            // ///////////////////////////////////////////////////////////////////////////////


            // ///////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////// Check-Miner-Firewall-Status/////////////////////////////////////////////
            Firewall_Check start = new Firewall_Check();
            //  start.run_firewall("ethminer", @"C:\SkyNet\Resources\Miners\Ethminer\ethminer.exe");
            //  start.run_firewall("ethminer", @"C:\SkyNet\Resources\Miners\Ethminer\Ethminer-AMD-Latest\ethminer.exe");
            start.run_firewall("N_ethminer", @"C:\SkyNet\SkyNet\Nvidia_miner\Release\N_ethminer.exe");

            Console.WriteLine("Check nvidai setting" + nvidia_miner_set_f);
            Run_Process run = new Run_Process();
            object start_command = @"C:\SkyNet\SkyNet\Nvidia_miner\Release\N_ethminer.exe -U -W " + user_Wallet + ".1080TI --HWMON 1 -R --gpu 1080TI --api-port 3333 " + nvidia_miner_set_f + "";
            //object start_command = @"C:\SkyNet\DownloadedMiners\ethminer.exe -G -W 0x1aC3FF5297F5261ec0A18af87441CD1811c1Ab82.RX570 --HWMON 2 -R --gpu RX570 --api-port 4444 --autosettings --setting B";


            //object start_command = @"C:\SkyNet\Resources\Miners\Ethminer\ethminer.exe -G -P stratum1+tcp://'"+user_walletAddress+"'.RX570@etp-kor1.topmining.co.kr:8008 --HWMON 2 -R --genExcel 0 --api-port 4444";
            run.ExecuteCommandSync(start_command, "Nvidia_Miner_Started");
            Thread.Sleep(15000);
        }

        public void Nvidia_Stop_Miner()
        {
            Run_Process stop = new Run_Process();
            object stop_command = @"taskkill /F /IM N_ethminer.exe";
            stop.ExecuteCommandSync(stop_command, "Nvidia_Miner_Stopped");
        }

        private object Nvidia_Get_Miner_Data()
        {
            Detail_Info_Response detail_response = JsonConvert.DeserializeObject<Detail_Info_Response>(Nvidia_ShowResponse("miner_Detail_info"));
            return detail_response;
        }


        public void Nvidia_run_fetch_data()
        {
            Detail_Info_Response response = null;
            while (true)
            {

                response = (Detail_Info_Response)Nvidia_Get_Miner_Data();

                int decValue = Convert.ToInt32(response.result.devices[0].mining.hashrate, 16);
                double result = Convert.ToDouble(decValue) / 1000000;


                Char delimiter = ':';
                String[] substrings = response.result.devices[0].hardware.pci.Split(delimiter);

                int Pcislot = Convert.ToInt32(substrings[0], 16);

                Thread.Sleep(10000);

            }

        }
        public object Nvidia_initialize_data()
        {
            Detail_Info_Response response = null;
            response = (Detail_Info_Response)Nvidia_Get_Miner_Data();
            return response;
        }
    }

    // ////////////////// Nvidia Ethminer class code end /////////////////////


}

