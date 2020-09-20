using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKY.controls
{
    public partial class reboot_popup : Form
    {
        int quick = 1200;
       
        public reboot_popup()
        {
            InitializeComponent();
           
        }

        private void reboot_popup_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;

        }

        public void reboot() {

            
        }

        // ///////////////////// form shade code starts ///////////////////////////////////////



        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;


            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {


            var v = 2;
            DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
            MARGINS margins = new MARGINS()
            {
                bottomHeight = 1,
                leftWidth = 0,
                rightWidth = 0,
                topHeight = 0
            }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);


            base.WndProc(ref m);

        }

        // ///////////////////// form shade code end ///////////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();

        }

        private void closeLB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void ExecuteCommandSync(object command, string type = null)
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);


                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;

                procStartInfo.CreateNoWindow = true;
                procStartInfo.WorkingDirectory = @"C:\";
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();

                //string result = proc.StandardOutput.ReadToEnd();
                if (type == null)
                {
                    proc.WaitForExit();
                }
                //Console.WriteLine(result);
            }
            catch (Exception objException)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            quick--;
           
            if (quick != 0)
            {
                 counterLB.Text = (quick / 60).ToString();
                
            }
            if (quick == 0) {
                Properties.Settings.Default.AMD_Reboot_status = "no";
                Properties.Settings.Default.Save();
                object reboot_command = @"shutdown /r -t 5 ";
                ExecuteCommandSync(reboot_command);
            }
            
        }

        
    }
}
