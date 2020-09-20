using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using LinqToDB;
using LiveCharts;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;

namespace SKY.controls
{
    public partial class Nvidia_Stats_Controls : UserControl
    {
        List<String> timeValues_hashrate = new List<String>();
        List<String> timeValues_temp = new List<String>();
        List<String> timeValues_power = new List<String>();

        // SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True");
        SqlCommand command;
        string query;

        public Nvidia_Stats_Controls()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitTimer();

            try
            {
                connection.Open();
                query = "select PCISlot,name from Nvidia_GpuData";
                command = new SqlCommand(query, connection);


                SqlDataReader dr = command.ExecuteReader();
                statsGPUdata.Rows.Clear();


                while (dr.Read())
                {
                    statsGPUdata.Rows.Add(dr[0], dr[1]);
                }
                connection.Close();


            }
            catch
            {
            }

        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10000; // in miliseconds
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            //AMD data fetch
          /*  nvidia_GPU_Stats_DataSet.Clear();
            this.nvidia_GpuDataTableAdapter.Fill(this.nvidia_GPU_Stats_DataSet.Nvidia_GpuData);
         */   //Power and Hash Rate code end

        }

        private void statsGPUdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nvidia_Stats_Controls s = new Nvidia_Stats_Controls();
            s.Form1_Load(s, e);



            Hashratecharts.Visible = true;
            temp_chart.Visible = true;
            power_chart.Visible = true;



            //graph starts
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\SkyNet\SkyNet\Database mdf files\SKY1.mdf;Integrated Security = True");

            // SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();

            List<double> allValues = new List<double>();
            List<double> allValues_temp = new List<double>();
            List<double> allValues_power = new List<double>();
            //List<double> t = new List<double>();
            //List<double> h = new List<double>();
            //List<string> HR = new List<string>();

            // List<DateTime> timeValues = new List<DateTime>();

            try
            {
                string ind = statsGPUdata.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine(ind);
                // con.ConnectionString = ConfigurationManager.ConnectionStrings["conDB"].ConnectionString;
                con.Open();
                cmd = new SqlCommand("select time,Hashrate from Stats_Nvidia_GPUsData where PCISlot = @PCI_Index", con);
                cmd.Parameters.AddWithValue("@PCI_Index", ind);
                SqlDataReader RDR = cmd.ExecuteReader();
                while (RDR.Read())
                {

                    allValues.Add(Convert.ToDouble(RDR["Hashrate"]));
                    //  h.Add(Convert.ToDouble(RDR["Hashrate"]));
                    timeValues_hashrate.Add(Convert.ToString(RDR["time"]));

                }

                int count_time_hashrate = timeValues_hashrate.Count;
                for (int i = 1; i < count_time_hashrate - 1; i++)
                {

                    DateTime previous_time_hashrate = DateTime.Parse(timeValues_hashrate[i - 1]);
                    DateTime current_time_hashrate = DateTime.Parse(timeValues_hashrate[i]);

                    TimeSpan time_difference = current_time_hashrate - previous_time_hashrate;

                    if (time_difference.TotalMinutes < 1440)
                    {


                    }
                    else
                    {

                        timeValues_hashrate.Insert(i, null);
                        allValues.Insert(i, double.NaN);
                        Console.WriteLine("else");
                        Console.WriteLine(allValues[i]);
                        //allValues.Insert(i, 0);
                        i++;
                        //  count_time_hashrate++;
                    }
                }




                //IncomeSeries.RemoveAt(0);
                Hashratecharts.AxisX.Clear();
                Hashratecharts.AxisY.Clear();
                Hashratecharts.Series.Clear();
                Hashratecharts.Series = new SeriesCollection
            {

                new LineSeries
                {

                    Title = "Hash Rate",

                  Values = new ChartValues<double>(allValues),


                    PointGeometry = DefaultGeometries.Circle,
                    PointForeground = Brushes.Yellow,
                    PointGeometrySize = 12
                }
            };


                Hashratecharts.AxisX.Add(new Axis
                {
                    Title = "Time",
                    //  Labels = new List<string>(timeValues)
                    Labels = new List<string>(timeValues_hashrate)

                    //LabelFormatter = value => t.
                });

                Hashratecharts.AxisY.Add(new Axis
                {
                    Title = "Hash Rate",

                    LabelFormatter = value => (value).ToString()

                });

                Hashratecharts.LegendLocation = LegendLocation.Right;
                //Hashratecharts.Series.RemoveAt(0);
               // Hashratecharts.DataClick += CartesianChart1OnDataClick;
                con.Close();

                // con.ConnectionString = ConfigurationManager.ConnectionStrings["conDB"].ConnectionString;
                con.Open();
                cmd = new SqlCommand("select time,tempminer from Stats_Nvidia_GPUsData where PCISlot = @PCI_Index", con);
                cmd.Parameters.AddWithValue("@PCI_Index", ind);
                SqlDataReader RDR1 = cmd.ExecuteReader();
                while (RDR1.Read())
                {
                    allValues_temp.Add(Convert.ToDouble(RDR1["tempminer"]));

                    timeValues_temp.Add(Convert.ToString(RDR1["time"]));

                }


                int count_time_temp = timeValues_temp.Count;
                for (int i = 1; i < count_time_temp - 1; i++)
                {
                    DateTime previous_time_hashrate = DateTime.Parse(timeValues_temp[i - 1]);
                    DateTime current_time_hashrate = DateTime.Parse(timeValues_temp[i]);

                    TimeSpan time_difference = current_time_hashrate - previous_time_hashrate;

                    if (time_difference.TotalMinutes < 1440)
                    {

                    }
                    else
                    {
                        timeValues_temp.Insert(i, null);
                        allValues_temp.Insert(i, double.NaN);
                        i++;
                    }
                }


                //IncomeSeries.RemoveAt(0);
                temp_chart.AxisX.Clear();
                temp_chart.AxisY.Clear();
                temp_chart.Series.Clear();
                temp_chart.Series = new SeriesCollection
            {

                new LineSeries
                {

                    Title = "Temperature",

                   Values = new ChartValues<double>(allValues_temp),


                    PointGeometry = DefaultGeometries.Circle,
                    PointForeground = Brushes.LightGreen,
                    PointGeometrySize = 12
                }
            };


                temp_chart.AxisX.Add(new Axis
                {
                    Title = "Time",

                    Labels = new List<string>(timeValues_temp)

                    //LabelFormatter = value => t.
                });

                temp_chart.AxisY.Add(new Axis
                {
                    Title = "Temperature",

                    LabelFormatter = value => (value).ToString()

                });

                temp_chart.LegendLocation = LegendLocation.Right;
                //Hashratecharts.Series.RemoveAt(0);
                //temp_chart.DataClick += CartesianChart1OnDataClick;
                con.Close();


                con.Open();
                cmd = new SqlCommand("select time,power from Stats_Nvidia_GPUsData where PCISlot = @PCI_Index", con);
                cmd.Parameters.AddWithValue("@PCI_Index", ind);
                SqlDataReader RDR2 = cmd.ExecuteReader();
                while (RDR2.Read())
                {


                    allValues_power.Add(Convert.ToDouble(RDR2["power"]));

                    timeValues_power.Add(Convert.ToString(RDR2["time"]));

                }

                int count_time_power = timeValues_power.Count;
                for (int i = 1; i < count_time_power - 1; i++)
                {
                    DateTime previous_time_hashrate = DateTime.Parse(timeValues_power[i - 1]);
                    DateTime current_time_hashrate = DateTime.Parse(timeValues_power[i]);

                    TimeSpan time_difference = current_time_hashrate - previous_time_hashrate;

                    if (time_difference.TotalMinutes < 1440)
                    {

                    }
                    else
                    {
                        timeValues_power.Insert(i, null);
                        allValues_power.Insert(i, double.NaN);
                        i++;
                    }
                }



                //IncomeSeries.RemoveAt(0);
                power_chart.AxisX.Clear();
                power_chart.AxisY.Clear();
                power_chart.Series.Clear();
                power_chart.Series = new SeriesCollection
            {

                new LineSeries
                {

                    Title = "Power",

                   Values = new ChartValues<double>(allValues_power),


                    PointGeometry = DefaultGeometries.Circle,
                    PointForeground = Brushes.Orange,
                    PointGeometrySize = 12
                }
            };


                power_chart.AxisX.Add(new Axis
                {
                    Title = "Time",
                    Labels = new List<string>(timeValues_power)

                    //LabelFormatter = value => t.
                });

                power_chart.AxisY.Add(new Axis
                {
                    Title = "power",

                    LabelFormatter = value => (value).ToString()

                });

                power_chart.LegendLocation = LegendLocation.Right;
                //Hashratecharts.Series.RemoveAt(0);
                //power_chart.DataClick += CartesianChart1OnDataClick;
                con.Close();

                //graph ends
            }
            catch (Exception)
            {
            }
        }

        private void Nvidia_Stats_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
