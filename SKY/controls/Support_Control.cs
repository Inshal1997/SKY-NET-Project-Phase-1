using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKY.controls
{
    public partial class Support_Control : UserControl
    {
        public Support_Control()
        {
            InitializeComponent();
        }

        private void Support_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void website_linkLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://3.20.158.33/DTS-Optimizing-portal/");
        }
    }
}
