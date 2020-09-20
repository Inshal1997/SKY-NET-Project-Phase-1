using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKY
{
    public partial class stats_control : UserControl
    {
        public stats_control()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statsGPUdata_MouseClick(object sender, MouseEventArgs e)
        {
            /*tempchart.Series[0].Points.Clear();
            Hashratechart.Series[0].Points.Clear();
            powerchart.Series[0].Points.Clear();

            String tab = statsGPUdata.SelectedRows[0].Cells[1].Value.ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-0A9F74D\SQLEXPRESS;Initial Catalog=dts;User ID=sa;Password=dtsinc123";
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select  time , temperature  from RAT5 WHERE name= '" + tab + "'";
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            con.Open();
            da.Fill(ds);
            this.tempchart.DataSource = ds.Tables[0];

            //Mapping a field with x-value of chart
            this.tempchart.Series[0].XValueMember = "time";

            //Mapping a field with y-value of Chart
            this.tempchart.Series[0].YValueMembers = "temperature";

            //Bind the DataTable with Chart
            this.tempchart.DataBind();

            con.Close();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "select  time , hashrate  from RAT5 WHERE name= '" + tab + "'";
            da.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();

            con.Open();
            da.Fill(ds1);
            this.Hashratechart.DataSource = ds1.Tables[0];

            //Mapping a field with x-value of chart
            this.Hashratechart.Series[0].XValueMember = "time";

            //Mapping a field with y-value of Chart
            this.Hashratechart.Series[0].YValueMembers = "hashrate";

            //Bind the DataTable with Chart
            this.Hashratechart.DataBind();

            con.Close();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandText = "select  time , power  from RAT5 WHERE name= '" + tab + "'";
            da.SelectCommand = cmd2;
            DataSet ds2 = new DataSet();

            con.Open();
            da.Fill(ds2);
            this.powerchart.DataSource = ds2.Tables[0];

            //Mapping a field with x-value of chart
            this.powerchart.Series[0].XValueMember = "time";

            //Mapping a field with y-value of Chart
            this.powerchart.Series[0].YValueMembers = "power";

            //Bind the DataTable with Chart
            this.powerchart.DataBind();

            con.Close();

            GPUDeatailspanel.Visible = true;*/
        }
    }
}
