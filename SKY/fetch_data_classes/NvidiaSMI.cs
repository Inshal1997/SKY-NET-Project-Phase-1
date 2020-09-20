using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Data.SqlClient;

namespace SKY

{
    public class NvidiaSMI_DataSet
    {
        public int[] Index { get; set; }
        public int GPUs { get; set; }
        public string[] PCI_BusID { get; set; }
        public string[] GPU_Name { get; set; }
        public float[] GPU_Power { get; set; }
        public int[] GPU_MemSize { get; set; }
        public float[] Driver_Version { get; set; }
        public float[] GPU_Utilization { get; set; }
        public float[] Mem_Utilization { get; set; }
        public float[] GPU_FanSpeed { get; set; }
        public float[] GPU_Temperature { get; set; }
        public float[] Cclock_Utilization { get; set; }
        public float[] Mclock_Utilization { get; set; }
    }
    public class Nvidiasmi
    {

        // //////////////// Connection for mdf database code starts ////////////////////

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True");
        SqlDataAdapter da = new SqlDataAdapter();

        // //////////////// Connection for mdf database code end ////////////////////


        // /////////// variables for different Nvidia GPU //////////////////////
        int[] N_Pcislots = new int[20];
        string[] N_name = new string[20];
        double[] N_gpu_util = new double[20];
        double[] N_temp_miner = new double[20];
        double[] N_fan_speed = new double[20];
        double[] N_mem = new double[20];
        double[] N_power = new double[20];
        double[] N_hashrate_arr = new double[20];
        string line = "0, 0x03, 1, GeForce GTX 1050 Ti, 53.92, 4096, 441.87, 100, 100, 53, 71, 1746, 3504 \n0, 0x03, 1, GeForce GTX 1050 Ti, 53.92, 4096, 441.87, 100, 100, 53, 71, 1746, 3504";

        // /////////// variables for save different Nvidia GPU data //////////////////////

        int[] Pcislots = new int[20];
        string[] name = new string[20];
        // string[] mem_size = new string[20];
        double[] gpu_util = new double[20];
        double[] temp_miner = new double[20];
        double[] fan_speed = new double[20];
        double[] mem_util = new double[20];
        double[] power = new double[20];
        double[] hashrate_arr = new double[20];

        double N_hashrate;

        public void get_data()
        {

            string[] lines = line.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            Run_Process run = new Run_Process();

            String[] N_GPU_data = new String[20];

            object path = "\"C:\\Program Files\\NVIDIA Corporation\\NVSMI\\nvidia-smi.exe\" --query-gpu=pci.bus,name,power.draw,memory.total,utilization.gpu,fan.speed,temperature.gpu --format=csv,nounits,noheader";
            string result = run.ExecuteCommandSync(path, null, "output");
            // Console.WriteLine(result);
            string[] lines1 = result.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines1.Length; i++)
            {
                if (lines1[i] != null)
                {
                    N_GPU_data[i] = lines1[i];
                    Console.WriteLine(N_GPU_data[i]);
                }
                else
                {
                    break;
                }
            }


            for (int a = 0; a < lines1.Length; a++)
            {
                char delim = ',';
                String[] substrings = N_GPU_data[a].Split(delim);
                N_Pcislots[a] = Convert.ToInt32(substrings[0], 16);
                N_name[a] = substrings[1];
                N_power[a] = Convert.ToDouble(substrings[2]);
                Console.WriteLine(N_Pcislots[a]);
                Console.WriteLine(N_name[a]);
                Console.WriteLine(N_power[a]);
                Console.WriteLine(N_mem[a]);
                double memory = Convert.ToDouble(substrings[3]);
                N_mem[a] = (memory / 1024);
                N_gpu_util[a] = Convert.ToDouble(substrings[4]);
                N_temp_miner[a] = Convert.ToDouble(substrings[5]);
                N_fan_speed[a] = Convert.ToDouble(substrings[6]);

                /* Console.WriteLine(N_Pcislots[a]);
                 Console.WriteLine(N_name[a]);
                 Console.WriteLine(N_power[a]);
                 Console.WriteLine(N_mem[a]);
                 Console.WriteLine(N_gpu_util[a]);
                 Console.WriteLine(N_temp_miner[a]);
                 Console.WriteLine(N_fan_speed[a]);
 */

            }
        }

        // ////////////// Nvidia GPUs Data table code starts///////////////////////
        public void Nvidia_GPUs_data()
        {
            Thread.Sleep(60000);
            get_data();
         
            while (true){
                Detail_Info_Response response = null;
                Nvidia_Ethminer_Api_communication N_eth = new Nvidia_Ethminer_Api_communication();

                response = (Detail_Info_Response)N_eth.Nvidia_initialize_data();
                for (int num = 0; num < response.result.devices.Length; num++)
                {
                    //Break Hash Rate value and convert into int coding
                    int decValue = Convert.ToInt32(response.result.devices[num].mining.hashrate, 16);
                    Console.WriteLine(decValue);
                    Console.WriteLine("PCI Slot" + response.result.devices[num].hardware.pci);
                    N_hashrate = Convert.ToDouble(decValue) / 1000000;
                    Char delimiter = ':';

                    String[] NPCI_substring = response.result.devices[0].hardware.pci.Split(delimiter);
                    Console.WriteLine(N_hashrate);
                    Console.WriteLine(Convert.ToInt32(NPCI_substring[0], 16));
                    Console.WriteLine(N_Pcislots[num]);
                    if (N_Pcislots[num] != Convert.ToInt32(NPCI_substring[0], 16))
                    {
                        continue;
                    }

                    Pcislots[num] = N_Pcislots[num];
                    gpu_util[num] = N_gpu_util[num];
                    name[num] = N_name[num];
                    temp_miner[num] = N_temp_miner[num];
                    fan_speed[num] = N_fan_speed[num];
                    mem_util[num] = N_mem[num];
                    power[num] = N_power[num];
                    hashrate_arr[num] = N_hashrate;
                     Console.WriteLine(N_hashrate);

                    if (Pcislots[num] == Convert.ToInt32(NPCI_substring[0], 16))
                    {
                        // Console.WriteLine("Bus no" + bus__id + "      pci slot" + Pcislots[num] );

                        //Insert GPUs data for DashBoard AMD GridView Class  
                        try
                        {

                            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True"))
                            {

                                connection.Open();


                                //Insert Data into  Nvidia GPU Database Table

                                String query1 = "INSERT INTO Nvidia_GpuData (PCISlot,Hashrate,name,GPUutil,tempminer,fanspeed,memutil,power,time) VALUES (@pcislt,@hashrt,@Dname,@gpuUtl,@tempUtl,@fanSpd,@memUtl,@pwr,@time)";

                                using (SqlCommand command = new SqlCommand(query1, connection))
                                {
                                    command.Parameters.AddWithValue("@pcislt", N_Pcislots[num]);
                                    command.Parameters.AddWithValue("@Dname", N_name[num]);
                                    command.Parameters.AddWithValue("@gpuUtl", N_gpu_util[num]);
                                    command.Parameters.AddWithValue("@tempUtl", N_temp_miner[num]);
                                    command.Parameters.AddWithValue("@fanSpd", N_fan_speed[num]);
                                    command.Parameters.AddWithValue("@memUtl", N_mem[num]);
                                    command.Parameters.AddWithValue("@pwr", N_power[num]);
                                    command.Parameters.AddWithValue("@hashrt", hashrate_arr[num]);
                                   
                                    command.Parameters.AddWithValue("@time", DateTime.Now);

                                    command.ExecuteNonQuery();
                                    connection.Close();
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

                }
                Thread.Sleep(30000);
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
                catch (Exception e)
                {
                    Console.WriteLine("Error inserting data into Database! " + e.Message.ToString());
                }

                connection.Close();
            }
        }







        // ////////////// Nvidia GPUs Data table code end///////////////////////

        // ////////////// Nvidia GPUs stats Data table  code starts///////////////////////

        public void Nvidia_GPU_Stats_Data()
        {
            get_data();
            Thread.Sleep(60000);
           
            while (true)
            {
                Detail_Info_Response response = null;
                Nvidia_Ethminer_Api_communication N_eth = new Nvidia_Ethminer_Api_communication();

                response = (Detail_Info_Response)N_eth.Nvidia_initialize_data();
                for (int num = 0; num < response.result.devices.Length; num++)
                {
                    //Break Hash Rate value and convert into int coding
                    int decValue = Convert.ToInt32(response.result.devices[num].mining.hashrate, 16);
                    N_hashrate = Convert.ToDouble(decValue) / 1000000;
                    Char delimiter = ':';
                    String[] NPCI_substring = response.result.devices[num].hardware.pci.Split(delimiter);
                    Console.WriteLine(N_hashrate);
                    Console.WriteLine(Convert.ToInt32(NPCI_substring[0], 16));
                    if (N_Pcislots[num] != Convert.ToInt32(NPCI_substring[0], 16))
                    {
                        continue;
                    }

                    Pcislots[num] = N_Pcislots[num];
                    gpu_util[num] = N_gpu_util[num];
                    name[num] = N_name[num];
                    temp_miner[num] = N_temp_miner[num];
                    fan_speed[num] = N_fan_speed[num];
                    mem_util[num] = N_mem[num];
                    power[num] = N_power[num];
                    hashrate_arr[num] = N_hashrate;


                    if (Pcislots[num] == Convert.ToInt32(NPCI_substring[0], 16))
                    {
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True"))
                            {
                                connection.Open();


                                SqlCommand com = new SqlCommand();
                                com.Connection = connection;
                                com.CommandText = "DELETE FROM Stats_Nvidia_GPUsData where time < DATEADD(dd,-7,GETDATE())";
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


                                //Insert Data into  Nvidia GPU Database Table

                                String query1 = "INSERT INTO Stats_Nvidia_GPUsData (PCISlot,Hashrate,name,GPUutil,tempminer,fanspeed,memutil,power,time) VALUES (@pcislt,@hashrt,@Dname,@gpuUtl,@tempUtl,@fanSpd,@memUtl,@pwr,@time)";

                                using (SqlCommand command = new SqlCommand(query1, connection))
                                {
                                    command.Parameters.AddWithValue("@pcislt", N_Pcislots[num]);
                                    command.Parameters.AddWithValue("@Dname", N_name[num]);
                                    command.Parameters.AddWithValue("@gpuUtl", N_gpu_util[num]);
                                    command.Parameters.AddWithValue("@tempUtl", N_temp_miner[num]);
                                    command.Parameters.AddWithValue("@fanSpd", N_fan_speed[num]);
                                    command.Parameters.AddWithValue("@memUtl", N_mem[num]);
                                    command.Parameters.AddWithValue("@pwr", N_power[num]);
                                    command.Parameters.AddWithValue("@hashrt", hashrate_arr[num]);
                                   // Console.WriteLine(hashrate_arr[num]);
                                    command.Parameters.AddWithValue("@time", DateTime.Now);

                                    command.ExecuteNonQuery();
                                    connection.Close();
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

                }
                Thread.Sleep(1800000);
            }

           

        }

        // ////////////// Nvidia GPUs stats Data table  code end///////////////////////

    }
}

