using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SKY.Properties
{
    partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();

        public Service1()
        {
           // InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
        }

        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
        private void InitializeComponent()
        {
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
        }
        public static void Logwritter(string message)
        {
            String filename = DateTime.Now.ToString("yyyy_MM_dd");
        }
    }
    
}
