using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKY.controls
{
    public partial class Splash : Form
    {
        
        public Splash()
        {

            InitializeComponent();
            timer1.Enabled = true;
            perLB.BringToFront();
            Properties.Settings.Default.splash_LB = "Please wait while system check configure...";
            Properties.Settings.Default.splash_perLB = "0%";
        }
        private void Splash_Load(object sender, EventArgs e)
        {
           
            InitTimer();
        }

        public void InitTimer()
        {

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            perLB.Text = Properties.Settings.Default.splash_perLB;
            changeLB.Text = Properties.Settings.Default.splash_LB;
        }

       
    }
       
    }

