using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKY.controls
{
    public partial class Miner_Setting_popup : Form
    {

        public static bool save_changes;

        public static bool save_changes_button
        {
            get { return save_changes; }
            set { save_changes = value; }
        }

        public Miner_Setting_popup()
        {
            InitializeComponent();
        }

        private void Miner_Setting_popup_Load(object sender, EventArgs e)
        {
            AMD_textbox.Text = Properties.Settings.Default.amd_miner_setting ;
            NVIDIA_textbox.Text = Properties.Settings.Default.Nvidia_miner_setting;

            //AMD_comboBox.Text = "Default";
            //NVIDIA_comboBox.Text = "Default";
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

        // ///////////////////// get value from combobox and print on textbox coding starts ///////////////////////////////////////

        private void AMD_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AMD_textbox.Text = AMD_comboBox.SelectedItem.ToString();
        }

        private void NVIDIA_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NVIDIA_textbox.Text = NVIDIA_comboBox.SelectedItem.ToString();
        }

        // ///////////////////// get value from combobox and print on textbox coding end ///////////////////////////////////////


        private void Setting_button_Click(object sender, EventArgs e)
        {

          

         
           
            save_changes_button = true;
            this.Hide();
           


        }
    }
}
