using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Security.Principal;

namespace SKY.controls
{
    public partial class Login_Form : Form
    {
       
        int TogMove;
        int MValX;
        int MValY;
        int i;

        // ///////////////////databas connection code starts /////////////////////

        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=skysignuplogin;User Id=root;password=''");

        // ///////////////////databas connection code starts /////////////////////

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }


        public Login_Form()
        {

            InitializeComponent();
            Init_Data();

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

        public static string username;
        public static string userpassword;
        public static string userHashkey;

        public static string passing_username
        {
            get { return username; }
            set { username = value; }
        }

        public static string passing_userpassword
        {
            get { return userpassword; }
            set { userpassword = value; }
        }

        public static string passing_userHashkey
        {
            get { return userHashkey; }
            set { userHashkey = value; }
        }


        private void login_btn_Click_1(object sender, EventArgs e)
        {

            if (name_textbox.Text == "" || password_textbox.Text == "" || hashkey_box.Text == "" || wallet_add_tb.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");

            }
            else
            {
                passing_username = name_textbox.Text;
                passing_userpassword = password_textbox.Text;
                passing_userHashkey = hashkey_box.Text;

                try {
                    //login check from portal site starts
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile("http://3.20.158.33/DTS-Optimizing-portal/DesktopLoginReturn.php?email=" + passing_username + "&password=" + passing_userpassword + "&approvedkey=" + passing_userHashkey + "&id=DesktopLogin", @"C:\TextFile.txt");
                    }
                    //login check from portal site ends

                    //read text file starts
                    string authUser = File.ReadAllText(@"C:\TextFile.txt");
                    Console.WriteLine(authUser);

                    //read text file ends


                    //if it is logged in it will work because we can get a file as a response and can use it further

                    string chk_reboot_status = Properties.Settings.Default.AMD_Reboot_status;
                    if (authUser == "AuthUser")
                    {
                        save_data();
                        this.Hide();

                        if (chk_reboot_status == "yes")
                        {
                            Dashboard dashboard = new Dashboard();
                            dashboard.Hide();
                        }
                        if (chk_reboot_status == "no")
                        {
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                        }
                        else
                        {
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                        }
                    }
                    else
                    {
                        invalid.Visible = true;
                    }
                    // }
                    System.IO.File.Delete(@"C:\TextFile.txt");

                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kindly check your Internet Connection");

                }
            }
        }

        // ////////////////////// login form panel move coding start ////////////////////

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        // //////////////////////// login form panel move coding end ////////////

        // //////////////////////// Remember me option code starts //////////////

        private void Init_Data()
        {

            if (Properties.Settings.Default.UserName != String.Empty && Properties.Settings.Default.UserName != "User Name")
            {
                
                    name_textbox.Text = Properties.Settings.Default.UserName;
                    password_textbox.Text = Properties.Settings.Default.Password;
                    hashkey_box.Text = Properties.Settings.Default.HashKey;
                    wallet_add_tb.Text = Properties.Settings.Default.WalletAdd;
                    checkRememer.Checked = true;

            }
        }


        private void save_data()
        {
            if (checkRememer.Checked == true)
            {

                Properties.Settings.Default.UserName = name_textbox.Text;
                Properties.Settings.Default.Password = password_textbox.Text;
                Properties.Settings.Default.HashKey = hashkey_box.Text;
                Properties.Settings.Default.WalletAdd = wallet_add_tb.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();

            }

            else
            {

                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.HashKey = "";
                Properties.Settings.Default.WalletAdd = "";
                Properties.Settings.Default.Remme = "No";
                Properties.Settings.Default.Save();

            }
        }

        // //////////////////////// Remember me option code end /////////////////////////

        // ////////////////////// textbox validation coding starts //////////////////////

        private void name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            invalid.Visible = false;
        }

        private void password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            invalid.Visible = false;
        }

        private void hashkey_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            invalid.Visible = false;
        }

        private void wallet_add_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            invalid.Visible = false;
        }

        // ////////////////////// textbox validation coding, end //////////////////////    


        // ////////////////////// button hover coding starts //////////////////////    

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            Close_btn.ForeColor = System.Drawing.Color.Red;
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            Close_btn.ForeColor = System.Drawing.Color.Gray;
        }   

        private void login_btn_MouseEnter(object sender, EventArgs e)
        {
            login_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void login_btn_MouseHover(object sender, EventArgs e)
        {
            login_btn.BackColor = System.Drawing.Color.DimGray;
        }

        // ////////////////////// button hover coding ends //////////////////////    

        // ////////////////////// close button coding starts //////////////////////    

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form log = new Login_Form();
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form log = new Login_Form();
            log.Show();
        }

        // ////////////////////// close button coding ends //////////////////////    

        private void Login_Form_Shown(object sender, EventArgs e)
        {

            //this.Cursor = Cursors.WaitCursor;
            //this.Run1();
            //this.Cursor = Cursors.Default;
        }

        private void SignUp_linkLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://3.20.158.33/DTS-Optimizing-portal/SignUpPage/SignUp_index.html");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void Run1()
        //{
        //    if (!Program.IsAdministrator())
        //    {
        //        // Restart and run as admin
        //        var SKY = Process.GetCurrentProcess().MainModule.FileName;
        //        ProcessStartInfo startInfo = new ProcessStartInfo(SKY);
        //        startInfo.Verb = "runas";
        //        startInfo.Arguments = "restart";
        //        Process.Start(startInfo);
        //        Application.Exit();
        //    }
        //}



    }

}
