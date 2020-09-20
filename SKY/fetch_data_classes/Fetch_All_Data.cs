using ATI.ADL;
using MSI.Afterburner;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Management;
using SKY.controls;
using System.Linq.Expressions;

namespace SKY
{
    public class DataSet
    {
        public int Gpus { get; set; }
        public int[] Pcislot { get; set; }
        public string[] Device_Name { get; set; }
        // public string[] Memory_Size { get; set; }
        public double[] GPU_Utlization { get; set; }
        public double[] Temperature { get; set; }
        public double[] Fanspeed { get; set; }
        public double[] Mem_Utilzation { get; set; }
        public double[] hashrate { get; set; }
        public double[] sensors { get; set; }
        public Devices_Info_Detail_info_Response[] devices { get; set; }
        [JsonProperty("host")]
        public Hardware_Info_Devices_Info_Detail_info_Response hardware { get; set; }
        [JsonProperty("mining")]
        public Mining_Info_Devices_Info_Detail_info_Response mining { get; set; }
    }

    public class fetch_data
    {
        double result;
        int num;
        int gpu_count = 0;
        int[] Pcislots = new int[20];
        string[] name = new string[20];
        // string[] mem_size = new string[20];
        double[] gpu_util = new double[20];
        double[] temp_miner = new double[20];
        double[] fan_speed = new double[20];
        double[] mem_util = new double[20];
        double[] power = new double[20];
        double[] hashrate_arr = new double[20];
        // private SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True");
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SKY1.mdf;Integrated Security=True");

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public void AMD_GPU_Data()
        {
            Thread.Sleep(60000);
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
                Console.WriteLine("Number Of Adapters: " + NumberOfAdapters.ToString() + "\n");

                if (0 < NumberOfAdapters)
                {
                    // Get OS adpater info from ADL
                    ADLAdapterInfoArray OSAdapterInfoData;
                    OSAdapterInfoData = new ADLAdapterInfoArray();

                    ADLPMActivity activity;
                    activity = new ADLPMActivity();
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
                                String pre_busnumber = "0";
                                // int[] Pcislot = new int[NumberOfAdapters];


                                //GPU memory starts
                                double[] total_GPU_memory = new double[20];
                                double[] round_total_GPU_memory = new double[20];
                                double a;
                                int inc = 0;
                                double memory;
                                int m = 0;// memory variable

                                ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
                                foreach (ManagementObject obj in myVideoObject.Get())
                                {

                                    a = double.Parse(obj["AdapterRAM"].ToString());
                                    total_GPU_memory[inc] = ((a / 1024) / 1024) / 1024;
                                    round_total_GPU_memory[inc] = Math.Round(total_GPU_memory[0], MidpointRounding.AwayFromZero);
                                    Console.WriteLine("AdapterRAM GB -  " + ((a / 1024) / 1024) / 1024 + "GB");//1073741824
                                                                                                               //Console.WriteLine("AdapterRAM  -  " + obj["AdapterRAM"]/1024);
                                    memory = round_total_GPU_memory[inc];
                                    Console.WriteLine(round_total_GPU_memory[inc]);
                                    Console.WriteLine("Name  -  " + obj["Name"]);
                                    inc++;
                                }

                                Console.WriteLine("********************************");
                                Console.WriteLine(round_total_GPU_memory[0]);
                                Console.WriteLine(round_total_GPU_memory[1]);
                                Console.WriteLine(round_total_GPU_memory[2]);
                                Console.WriteLine("********************************");
                                Console.WriteLine(round_total_GPU_memory[2]);

                                //GPU memory ends

                                while (true)
                                {

                                    pre_busnumber = "0";

                                    for (int i = 0; i < NumberOfAdapters; i++)
                                    {
                                        // Check if the adapter is active
                                        if (null != ADL.ADL_Adapter_Active_Get)
                                            ADLRet = ADL.ADL_Adapter_Active_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, ref IsActive);

                                        if (ADL.ADL_SUCCESS == ADLRet)
                                        {
                                            String bus__id = OSAdapterInfoData.ADLAdapterInfo[i].BusNumber.ToString();
                                            int bus_id_int = Convert.ToInt32(bus__id);


                                            if (bus_id_int >= 1)
                                            {


                                                if (OSAdapterInfoData.ADLAdapterInfo[i].BusNumber.ToString() != pre_busnumber)
                                                {

                                                    // Obtain information about displays


                                                    IntPtr DisplayBuffer = IntPtr.Zero;
                                                    IntPtr pwr = IntPtr.Zero;
                                                    ADLFanSpeedValue adLFan = new ADLFanSpeedValue();
                                                    ADLTemperature adltemp = new ADLTemperature();
                                                    adLFan.iSpeedType = 1;

                                                    // Force the display detection and get the Display Info. Use 0 as last parameter to NOT force detection
                                                    //ADLRet = ADL.ADL_Display_DisplayInfo_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, ref NumberOfDisplays, out DisplayBuffer, 1);
                                                    if (ADL.ADL_SUCCESS == ADLRet)
                                                    {
                                                        List<ADLDisplayInfo> DisplayInfoData = new List<ADLDisplayInfo>();


                                                        ADLRet = ADL.ADL_Power_Info_Get(ADL.context, OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out pwr);
                                                        if (ADL.ADL_SUCCESS == ADLRet)
                                                        {

                                                        }

                                                        ADLRet = ADL.ADL_FanSpeed_Info_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out adLFan);
                                                        if (ADL.ADL_SUCCESS == ADLRet)
                                                        {


                                                        }

                                                        ADLRet = ADL.ADL_Temp_TempInfo_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out adltemp);
                                                        if (ADL.ADL_SUCCESS == ADLRet)
                                                        {

                                                        }

                                                        IntPtr ADLPMActivity = IntPtr.Zero;
                                                        activity.iSize = Marshal.SizeOf(ADLPMActivity);
                                                        ADLRet = ADL.ADL_Info_CurrentActivity_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, out activity);
                                                        if (ADL.ADL_SUCCESS == ADLRet)
                                                        {

                                                        }




                                                        Detail_Info_Response response = null;
                                                        Ethminer_Api_communication eth = new Ethminer_Api_communication();


                                                        response = (Detail_Info_Response)eth.initialize_data();
                                                        for (num = 0; num < response.result.devices.Length; num++)
                                                        {
                                                            //Break Hash Rate value and convert into int coding
                                                            int decValue = Convert.ToInt32(response.result.devices[num].mining.hashrate, 16);
                                                            result = Convert.ToDouble(decValue) / 1000000;
                                                            Char delimiter = ':';
                                                            String[] substrings = response.result.devices[num].hardware.pci.Split(delimiter);


                                                            ///////////////////////////////////////////////////////////////////////////////////////////////
                                                            ///
                                                            Console.WriteLine("i = " + i + "  Bus Id = " + bus_id_int + "                " + "PCI Slot = " + Convert.ToInt32(substrings[0], 16));
                                                            if (bus_id_int != Convert.ToInt32(substrings[0], 16))
                                                            {
                                                                continue;
                                                            }
                                                            ///////////////////////////////////////////////////////////////////////////////////////////////
                                                            //Break Hash Rate value and convert into int coding end

                                                            Pcislots[num] = Convert.ToInt32(substrings[0], 16);

                                                            gpu_util[num] = activity.iActivityPercent;

                                                            name[num] = OSAdapterInfoData.ADLAdapterInfo[i].AdapterName;
                                                            temp_miner[num] = adltemp.iTemperature / 1000;
                                                            fan_speed[num] = adLFan.iFanSpeed;
                                                            mem_util[num] = 0.0;
                                                            power[num] = pwr.ToInt32() * 3.90625 / 1000;
                                                            hashrate_arr[num] = result;
                                                            Console.WriteLine(result);
                                                            




                                                            //Break Hash Rate value and convert into int coding



                                                            if (Pcislots[num] == bus_id_int)
                                                            {
                                                                // Console.WriteLine("Bus no" + bus__id + "      pci slot" + Pcislots[num] );

                                                                //Insert GPUs data for DashBoard AMD GridView Class  
                                                                try
                                                                {

                                                                    using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True"))
                                                                    {

                                                                        connection.Open();
                                                                        //Insert Data into AMD Stats GPU Database Table

                                                                        String query1 = "INSERT INTO AMD_GpuData (PCISlot,Hashrate,name,GPUutil,tempminer,fanspeed,memutil,power,time) VALUES (@pcislt,@hashrt,@Dname,@gpuUtl,@tempUtl,@fanSpd,@memUtl,@pwr,@time)";

                                                                        using (SqlCommand command = new SqlCommand(query1, connection))
                                                                        {
                                                                            command.Parameters.AddWithValue("@pcislt", Pcislots[num]);
                                                                            command.Parameters.AddWithValue("@Dname", name[num]);
                                                                            command.Parameters.AddWithValue("@gpuUtl", gpu_util[num]);
                                                                            command.Parameters.AddWithValue("@tempUtl", temp_miner[num]);
                                                                            command.Parameters.AddWithValue("@fanSpd", fan_speed[num]);
                                                                            command.Parameters.AddWithValue("@memUtl", round_total_GPU_memory[m]);
                                                                            //command.Parameters.AddWithValue("@memUtl", memory);
                                                                            command.Parameters.AddWithValue("@pwr", power[num]);
                                                                            command.Parameters.AddWithValue("@hashrt", hashrate_arr[num]);
                                                                            Console.WriteLine(hashrate_arr[num]);
                                                                            command.Parameters.AddWithValue("@time", DateTime.Now);

                                                                            command.ExecuteNonQuery();
                                                                        }

                                                                        m++;
                                                                    }
                                                                }
                                                                catch (Exception e)
                                                                {
                                                                    Console.WriteLine("Error inserting data into Database! " + e.Message.ToString());
                                                                }

                                                                connection.Close();

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Pcislot not found");
                                                            }


                                                            pre_busnumber = OSAdapterInfoData.ADLAdapterInfo[i].BusNumber.ToString();
                                                            //tryyy

                                                        }

                                                    }
                                                    else
                                                    {

                                                    }
                                                }
                                            }
                                        }
                                    }
                                    m = 0;// memory variable after 30 sec memory int will be zero 
                                    Thread.Sleep(30000);
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
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Error inserting data into Database! " + e.Message.ToString());
                                    }

                                    connection.Close();
                                }
                            }

                            else
                            {
                                Console.WriteLine("ADL_Adapter_AdapterInfo_Get() returned error code " + ADLRet.ToString());
                            }
                        }
                        // Release the memory for the AdapterInfo structure
                        if (IntPtr.Zero != AdapterBuffer)
                            Marshal.FreeCoTaskMem(AdapterBuffer);
                    }
                }
                if (null != ADL.ADL_Main_Control_Destroy)
                    ADL.ADL_Main_Control_Destroy();
            }
            else
            {
                Console.WriteLine("ADL_Main_Control_Create() returned error code " + ADLRet.ToString());
                Console.WriteLine("\nCheck if ADL is properly installed!\n");
            }

            Console.WriteLine("Press ENTER to EXIT");
            Console.ReadLine();



            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*

                ADLRet = -1;
                NumberOfAdapters = 0;
                ADL_CONTEXT_HANDLE context = null;
                if (null != ADL.ADL2_Main_Control_Create)
                    // Second parameter is 1: Get only the present adapters
                    ADLRet = ADL.ADL2_Main_Control_Create(ADL.ADL_Main_Memory_Alloc, 1, out context);


                if (ADL.ADL_SUCCESS == ADLRet)
                {
                    if (null != ADL.ADL_Adapter_NumberOfAdapters_Get)
                    {
                        ADL.ADL_Adapter_NumberOfAdapters_Get(ref NumberOfAdapters);
                    }
                    Console.WriteLine("Number Of Adapters: " + NumberOfAdapters.ToString() + "\n");

                    if (0 < NumberOfAdapters)
                    {
                        // Get OS adpater info from ADL
                        ADLAdapterInfoArray OSAdapterInfoData;
                        OSAdapterInfoData = new ADLAdapterInfoArray();

                        ADLPMActivity activity;
                        activity = new ADLPMActivity();
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

                                    for (int i = 0; i < NumberOfAdapters; i++)
                                    {
                                        // Check if the adapter is active
                                        if (null != ADL.ADL_Adapter_Active_Get)
                                            ADLRet = ADL.ADL_Adapter_Active_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, ref IsActive);

                                        if (ADL.ADL_SUCCESS == ADLRet)
                                        {
                                            Console.WriteLine("Adapter Index: " + OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex.ToString());
                                            Console.WriteLine("Adapter UDID : " + OSAdapterInfoData.ADLAdapterInfo[i].UDID);
                                            Console.WriteLine("Bus Number: " + OSAdapterInfoData.ADLAdapterInfo[i].BusNumber.ToString());
                                            Console.WriteLine("Display Name : " + OSAdapterInfoData.ADLAdapterInfo[i].DisplayName.ToString());
                                            Console.WriteLine("Adapter Name : " + OSAdapterInfoData.ADLAdapterInfo[i].AdapterName);

                                            // Obtain information about displays
                                            // ADLDisplayInfo oneDisplayInfo = new ADLDisplayInfo();


                                            IntPtr DisplayBuffer = IntPtr.Zero;
                                            IntPtr power = IntPtr.Zero;
                                            ADLFanSpeedValue adLFan = new ADLFanSpeedValue();
                                            ADLTemperature adltemp = new ADLTemperature();
                                            adLFan.iSpeedType = 1;
                                            // ADLTemperature* adltemp1 = &adltemp;



                                            if (ADL.ADL_SUCCESS == ADLRet)
                                            {

                                                ADLRet = ADL.ADL_Power_Info_Get(ADL.context, OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out power);
                                                if (ADL.ADL_SUCCESS == ADLRet)
                                                {
                                                    Console.WriteLine("Power : " + power.ToInt32() * 3.90625 / 1000);
                                                }

                                                ADLRet = ADL.ADL_FanSpeed_Info_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out adLFan);
                                                if (ADL.ADL_SUCCESS == ADLRet)
                                                {

                                                    Console.WriteLine("fan Speed : " + adLFan.iFanSpeed);
                                                }

                                                ADLRet = ADL.ADL_Temp_TempInfo_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out adltemp);
                                                if (ADL.ADL_SUCCESS == ADLRet)
                                                {

                                                    // float t = temp.ToInt32();
                                                    Console.WriteLine("temp : " + adltemp.iTemperature / 1000);
                                                }

                                                IntPtr ADLPMActivity = IntPtr.Zero;
                                                activity.iSize = Marshal.SizeOf(ADLPMActivity);
                                                ADLRet = ADL.ADL_Info_CurrentActivity_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, out activity);
                                                if (ADL.ADL_SUCCESS == ADLRet)
                                                {
                                                    Console.WriteLine("Memory CLock : " + activity.iMemoryClock / 1000);
                                                    Console.WriteLine("Engine CLock : " + activity.iEngineClock / 1000);
                                                }

                                                // Release the memory for the DisplayInfo structure
                                                if (IntPtr.Zero != DisplayBuffer)
                                                    Marshal.FreeCoTaskMem(DisplayBuffer);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ADL_Adapter_AdapterInfo_Get() returned error code " + ADLRet.ToString());
                                }
                            }
                            // Release the memory for the AdapterInfo structure
                            if (IntPtr.Zero != AdapterBuffer)
                                Marshal.FreeCoTaskMem(AdapterBuffer);
                        }
                    }
                    if (null != ADL.ADL2_Main_Control_Destroy)
                        ADL.ADL2_Main_Control_Destroy();
                }
                else
                {
                    Console.WriteLine("ADL2_Main_Control_Create() returned error code " + ADLRet.ToString());
                    Console.WriteLine("\nCheck if ADL is properly installed!\n");
                }

                Console.WriteLine("Press ENTER to EXIT");
                Console.ReadLine();*/

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AMD_GPU_Stats_Data()
        {

            Thread.Sleep(70000);
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
                Console.WriteLine("Number Of Adapters: " + NumberOfAdapters.ToString() + "\n");

                if (0 < NumberOfAdapters)
                {
                    // Get OS adpater info from ADL
                    ADLAdapterInfoArray OSAdapterInfoData;
                    OSAdapterInfoData = new ADLAdapterInfoArray();

                    ADLPMActivity activity;
                    activity = new ADLPMActivity();
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
                                String pre_busnumber = "0";
                                // int[] Pcislot = new int[NumberOfAdapters];
                               
                                while (true)
                                {

                                    pre_busnumber = "0";
                                    for (int i = 0; i < NumberOfAdapters; i++)
                                    {
                                        // Check if the adapter is active
                                        if (null != ADL.ADL_Adapter_Active_Get)
                                            ADLRet = ADL.ADL_Adapter_Active_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, ref IsActive);

                                        if (ADL.ADL_SUCCESS == ADLRet)
                                        {
                                            String bus__id = OSAdapterInfoData.ADLAdapterInfo[i].BusNumber.ToString();
                                            int bus_id_int = Convert.ToInt32(bus__id);


                                            if (bus_id_int >= 1)
                                            {


                                                if (OSAdapterInfoData.ADLAdapterInfo[i].BusNumber.ToString() != pre_busnumber)
                                                {

                                                    // Obtain information about displays


                                                    IntPtr DisplayBuffer = IntPtr.Zero;
                                                    IntPtr pwr = IntPtr.Zero;
                                                    ADLFanSpeedValue adLFan = new ADLFanSpeedValue();
                                                    ADLTemperature adltemp = new ADLTemperature();
                                                    adLFan.iSpeedType = 1;

                                                    // Force the display detection and get the Display Info. Use 0 as last parameter to NOT force detection
                                                    //ADLRet = ADL.ADL_Display_DisplayInfo_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, ref NumberOfDisplays, out DisplayBuffer, 1);
                                                    if (ADL.ADL_SUCCESS == ADLRet)
                                                    {
                                                        List<ADLDisplayInfo> DisplayInfoData = new List<ADLDisplayInfo>();


                                                        ADLRet = ADL.ADL_Power_Info_Get(ADL.context, OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out pwr);
                                                        if (ADL.ADL_SUCCESS == ADLRet)
                                                        {

                                                        }

                                                        ADLRet = ADL.ADL_FanSpeed_Info_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out adLFan);
                                                        if (ADL.ADL_SUCCESS == ADLRet)
                                                        {


                                                        }

                                                        ADLRet = ADL.ADL_Temp_TempInfo_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out adltemp);
                                                        if (ADL.ADL_SUCCESS == ADLRet)
                                                        {

                                                        }

                                                        IntPtr ADLPMActivity = IntPtr.Zero;
                                                        activity.iSize = Marshal.SizeOf(ADLPMActivity);
                                                        ADLRet = ADL.ADL_Info_CurrentActivity_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, out activity);
                                                        if (ADL.ADL_SUCCESS == ADLRet)
                                                        {

                                                        }




                                                        Detail_Info_Response response = null;
                                                        Ethminer_Api_communication eth = new Ethminer_Api_communication();


                                                        response = (Detail_Info_Response)eth.initialize_data();
                                                        for (num = 0; num < response.result.devices.Length; num++)
                                                        {
                                                            //Break Hash Rate value and convert into int coding
                                                            int decValue = Convert.ToInt32(response.result.devices[num].mining.hashrate, 16);
                                                            result = Convert.ToDouble(decValue) / 1000000;
                                                            Char delimiter = ':';
                                                            String[] substrings = response.result.devices[num].hardware.pci.Split(delimiter);


                                                            ///////////////////////////////////////////////////////////////////////////////////////////////
                                                            ///
                                                            if (bus_id_int != Convert.ToInt32(substrings[0], 16))
                                                            {
                                                                continue;
                                                            }
                                                            ///////////////////////////////////////////////////////////////////////////////////////////////
                                                            //Break Hash Rate value and convert into int coding end



                                                            Pcislots[num] = Convert.ToInt32(substrings[0], 16);

                                                            gpu_util[num] = activity.iActivityPercent;

                                                            name[num] = OSAdapterInfoData.ADLAdapterInfo[i].AdapterName;
                                                            temp_miner[num] = adltemp.iTemperature / 1000;
                                                            fan_speed[num] = adLFan.iFanSpeed;
                                                            mem_util[num] = 0.0;
                                                            power[num] = pwr.ToInt32() * 3.90625 / 1000;
                                                            hashrate_arr[num] = result;

                                                            Console.WriteLine(Pcislots[num]);
                                                            Console.WriteLine(name[num]);
                                                            Console.WriteLine(gpu_util[num]);
                                                            Console.WriteLine(temp_miner[num]);
                                                            Console.WriteLine(fan_speed[num]);
                                                            Console.WriteLine(1.0);
                                                            Console.WriteLine(power[num]);
                                                            Console.WriteLine(hashrate_arr[num]);
                                                            Console.WriteLine("Num value");
                                                            Console.WriteLine(result);
                                                            Console.WriteLine("i value");
                                                            Console.WriteLine(i);
                                                            //Break Hash Rate value and convert into int coding



                                                            if (Pcislots[num] == bus_id_int)
                                                            {
                                                                // Console.WriteLine("Bus no" + bus__id + "      pci slot" + Pcislots[num] );

                                                                //Insert GPUs data for DashBoard AMD GridView Class  
                                                                try
                                                                {
                                                                    using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True"))
                                                                    {
                                                                        connection.Open();


                                                                        SqlCommand com = new SqlCommand();
                                                                        com.Connection = connection;
                                                                        com.CommandText = "DELETE FROM Stats_AMD_GPUsData where time < DATEADD(dd,-7,GETDATE())";
                                                                        com.ExecuteNonQuery();

                                                                        connection.Close();
                                                                    }
                                                                }
                                                                catch
                                                                {
                                                                    Console.WriteLine("Data not delete");
                                                                }


                                                                try
                                                                {
                                                                    using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True"))
                                                                    {

                                                                        connection.Open();

                                                                        //Insert Data into AMD Stats GPU Database Table

                                                                        String query1 = "INSERT INTO Stats_AMD_GPUsData (PCISlot,Hashrate,name,GPUutil,tempminer,fanspeed,memutil,power,time) VALUES (@pcislt,@hashrt,@Dname,@gpuUtl,@tempUtl,@fanSpd,@memUtl,@pwr,@time)";

                                                                        using (SqlCommand command = new SqlCommand(query1, connection))
                                                                        {
                                                                            command.Parameters.AddWithValue("@pcislt", Pcislots[num]);
                                                                            command.Parameters.AddWithValue("@Dname", name[num]);
                                                                            command.Parameters.AddWithValue("@gpuUtl", gpu_util[num]);
                                                                            command.Parameters.AddWithValue("@tempUtl", temp_miner[num]);
                                                                            command.Parameters.AddWithValue("@fanSpd", fan_speed[num]);
                                                                            command.Parameters.AddWithValue("@memUtl", mem_util[num]);
                                                                            command.Parameters.AddWithValue("@pwr", power[num]);
                                                                            command.Parameters.AddWithValue("@hashrt", hashrate_arr[num]);
                                                                            Console.WriteLine(hashrate_arr[num]);
                                                                            command.Parameters.AddWithValue("@time", DateTime.Now);

                                                                            command.ExecuteNonQuery();
                                                                            // da.Fill(dt);


                                                                        }
                                                                    }

                                                                }

                                                                catch (Exception e)
                                                                {
                                                                    Console.WriteLine("Error inserting data into Database! " + e.Message.ToString());
                                                                }
                                                                connection.Close();

                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Pcislot not found");
                                                            }


                                                            pre_busnumber = OSAdapterInfoData.ADLAdapterInfo[i].BusNumber.ToString();
                                                            //tryyy

                                                        }

                                                    }
                                                    else
                                                    {

                                                    }
                                                }
                                            }
                                        }
                                    }
                                    Thread.Sleep(1800000);

                                }
                            }

                            else
                            {
                                Console.WriteLine("ADL_Adapter_AdapterInfo_Get() returned error code " + ADLRet.ToString());
                            }
                        }
                        // Release the memory for the AdapterInfo structure
                        if (IntPtr.Zero != AdapterBuffer)
                            Marshal.FreeCoTaskMem(AdapterBuffer);
                    }
                }
                if (null != ADL.ADL_Main_Control_Destroy)
                    ADL.ADL_Main_Control_Destroy();
            }
            else
            {
                Console.WriteLine("ADL_Main_Control_Create() returned error code " + ADLRet.ToString());
                Console.WriteLine("\nCheck if ADL is properly installed!\n");
            }

            Console.WriteLine("Press ENTER to EXIT");
            Console.ReadLine();






            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*

                ADLRet = -1;
                NumberOfAdapters = 0;
                ADL_CONTEXT_HANDLE context = null;
                if (null != ADL.ADL2_Main_Control_Create)
                    // Second parameter is 1: Get only the present adapters
                    ADLRet = ADL.ADL2_Main_Control_Create(ADL.ADL_Main_Memory_Alloc, 1, out context);


                if (ADL.ADL_SUCCESS == ADLRet)
                {
                    if (null != ADL.ADL_Adapter_NumberOfAdapters_Get)
                    {
                        ADL.ADL_Adapter_NumberOfAdapters_Get(ref NumberOfAdapters);
                    }
                    Console.WriteLine("Number Of Adapters: " + NumberOfAdapters.ToString() + "\n");

                    if (0 < NumberOfAdapters)
                    {
                        // Get OS adpater info from ADL
                        ADLAdapterInfoArray OSAdapterInfoData;
                        OSAdapterInfoData = new ADLAdapterInfoArray();

                        ADLPMActivity activity;
                        activity = new ADLPMActivity();
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

                                    for (int i = 0; i < NumberOfAdapters; i++)
                                    {
                                        // Check if the adapter is active
                                        if (null != ADL.ADL_Adapter_Active_Get)
                                            ADLRet = ADL.ADL_Adapter_Active_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, ref IsActive);

                                        if (ADL.ADL_SUCCESS == ADLRet)
                                        {
                                            Console.WriteLine("Adapter Index: " + OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex.ToString());
                                            Console.WriteLine("Adapter UDID : " + OSAdapterInfoData.ADLAdapterInfo[i].UDID);
                                            Console.WriteLine("Bus Number: " + OSAdapterInfoData.ADLAdapterInfo[i].BusNumber.ToString());
                                            Console.WriteLine("Display Name : " + OSAdapterInfoData.ADLAdapterInfo[i].DisplayName.ToString());
                                            Console.WriteLine("Adapter Name : " + OSAdapterInfoData.ADLAdapterInfo[i].AdapterName);

                                            // Obtain information about displays
                                            // ADLDisplayInfo oneDisplayInfo = new ADLDisplayInfo();


                                            IntPtr DisplayBuffer = IntPtr.Zero;
                                            IntPtr power = IntPtr.Zero;
                                            ADLFanSpeedValue adLFan = new ADLFanSpeedValue();
                                            ADLTemperature adltemp = new ADLTemperature();
                                            adLFan.iSpeedType = 1;
                                            // ADLTemperature* adltemp1 = &adltemp;



                                            if (ADL.ADL_SUCCESS == ADLRet)
                                            {

                                                ADLRet = ADL.ADL_Power_Info_Get(ADL.context, OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out power);
                                                if (ADL.ADL_SUCCESS == ADLRet)
                                                {
                                                    Console.WriteLine("Power : " + power.ToInt32() * 3.90625 / 1000);
                                                }

                                                ADLRet = ADL.ADL_FanSpeed_Info_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out adLFan);
                                                if (ADL.ADL_SUCCESS == ADLRet)
                                                {

                                                    Console.WriteLine("fan Speed : " + adLFan.iFanSpeed);
                                                }

                                                ADLRet = ADL.ADL_Temp_TempInfo_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, 0, out adltemp);
                                                if (ADL.ADL_SUCCESS == ADLRet)
                                                {

                                                    // float t = temp.ToInt32();
                                                    Console.WriteLine("temp : " + adltemp.iTemperature / 1000);
                                                }

                                                IntPtr ADLPMActivity = IntPtr.Zero;
                                                activity.iSize = Marshal.SizeOf(ADLPMActivity);
                                                ADLRet = ADL.ADL_Info_CurrentActivity_Get(OSAdapterInfoData.ADLAdapterInfo[i].AdapterIndex, out activity);
                                                if (ADL.ADL_SUCCESS == ADLRet)
                                                {
                                                    Console.WriteLine("Memory CLock : " + activity.iMemoryClock / 1000);
                                                    Console.WriteLine("Engine CLock : " + activity.iEngineClock / 1000);
                                                }

                                                // Release the memory for the DisplayInfo structure
                                                if (IntPtr.Zero != DisplayBuffer)
                                                    Marshal.FreeCoTaskMem(DisplayBuffer);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ADL_Adapter_AdapterInfo_Get() returned error code " + ADLRet.ToString());
                                }
                            }
                            // Release the memory for the AdapterInfo structure
                            if (IntPtr.Zero != AdapterBuffer)
                                Marshal.FreeCoTaskMem(AdapterBuffer);
                        }
                    }
                    if (null != ADL.ADL2_Main_Control_Destroy)
                        ADL.ADL2_Main_Control_Destroy();
                }
                else
                {
                    Console.WriteLine("ADL2_Main_Control_Create() returned error code " + ADLRet.ToString());
                    Console.WriteLine("\nCheck if ADL is properly installed!\n");
                }

                Console.WriteLine("Press ENTER to EXIT");
                Console.ReadLine();*/

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}





