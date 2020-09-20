using System.Windows.Forms;

namespace SKY
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnsetting = new System.Windows.Forms.Button();
            this.Btn_Nvidia_States = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.about_support_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Aboutbtn = new System.Windows.Forms.Button();
            this.Supportbtn = new System.Windows.Forms.Button();
            this.logoutpanel = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ChangeMinerdashboardTabPanel = new System.Windows.Forms.Panel();
            this.Download_Miner = new System.Windows.Forms.Button();
            this.AmdStatsTabPanel = new System.Windows.Forms.Panel();
            this.Btn_AMD_Stats = new System.Windows.Forms.Button();
            this.NvidiaStatsTabPanel = new System.Windows.Forms.Panel();
            this.dashboardTabPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dashboard_username = new System.Windows.Forms.Label();
            this.dashboard_coinname = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbtotalhashrate = new System.Windows.Forms.Label();
            this.lbtotalpower = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TopTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.lbdays = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbhours = new System.Windows.Forms.Label();
            this.lbmins = new System.Windows.Forms.Label();
            this.lbsecs = new System.Windows.Forms.Label();
            this.Mining_start_stop_btn = new MetroFramework.Controls.MetroButton();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashRateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilizationDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashRateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.dashboardUC = new MetroFramework.Controls.MetroUserControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GCtable1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.GC1 = new System.Windows.Forms.Label();
            this.AMD_panel = new System.Windows.Forms.Panel();
            this.GPUtable = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.GPUStatus = new System.Windows.Forms.Label();
            this.GPUMining_Coin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbAMD_GPU_Total_Hashrate = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.AMD_GPUStart_Stop_Lbl = new System.Windows.Forms.Label();
            this.AMD_coin = new System.Windows.Forms.Label();
            this.AMD_Miner_Name = new System.Windows.Forms.Label();
            this.AMD_GPU_Total_Hashrate = new System.Windows.Forms.Label();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.GC2minerdata = new MetroFramework.Controls.MetroGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dashboardpanel = new System.Windows.Forms.Panel();
            this.Nvidia_panel = new System.Windows.Forms.Panel();
            this.GCtable2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label41 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.GC1minerdata = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.GC2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lbNvidia_GPU_Total_Hashrate = new System.Windows.Forms.Label();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.Nvidia_GPUStart_Stop_Lbl = new System.Windows.Forms.Label();
            this.Nvidia_coin = new System.Windows.Forms.Label();
            this.Nvidia_Miner_Name = new System.Windows.Forms.Label();
            this.Nvidia_GPU_Total_Hashrate = new System.Windows.Forms.Label();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.AMD_Statuspng = new System.Windows.Forms.PictureBox();
            this.AMD_coin_iconPB = new System.Windows.Forms.PictureBox();
            this.Nvidia_Statuspng = new System.Windows.Forms.PictureBox();
            this.Nvidia_coin_iconPB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.about_support_panel.SuspendLayout();
            this.logoutpanel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.ChangeMinerdashboardTabPanel.SuspendLayout();
            this.AmdStatsTabPanel.SuspendLayout();
            this.NvidiaStatsTabPanel.SuspendLayout();
            this.dashboardTabPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.TopTable.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.GCtable1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.AMD_panel.SuspendLayout();
            this.GPUtable.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC2minerdata)).BeginInit();
            this.Dashboardpanel.SuspendLayout();
            this.Nvidia_panel.SuspendLayout();
            this.GCtable2.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC1minerdata)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.ControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AMD_Statuspng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMD_coin_iconPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nvidia_Statuspng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nvidia_coin_iconPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsetting
            // 
            this.btnsetting.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsetting.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnsetting.Location = new System.Drawing.Point(75, 10);
            this.btnsetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(125, 40);
            this.btnsetting.TabIndex = 7;
            this.btnsetting.Text = "Settings";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.UseVisualStyleBackColor = false;
            this.btnsetting.Click += new System.EventHandler(this.Btnsetting);
            // 
            // Btn_Nvidia_States
            // 
            this.Btn_Nvidia_States.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Nvidia_States.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Nvidia_States.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Nvidia_States.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Nvidia_States.FlatAppearance.BorderSize = 0;
            this.Btn_Nvidia_States.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nvidia_States.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nvidia_States.ForeColor = System.Drawing.Color.FloralWhite;
            this.Btn_Nvidia_States.Location = new System.Drawing.Point(72, 10);
            this.Btn_Nvidia_States.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Nvidia_States.Name = "Btn_Nvidia_States";
            this.Btn_Nvidia_States.Size = new System.Drawing.Size(128, 40);
            this.Btn_Nvidia_States.TabIndex = 3;
            this.Btn_Nvidia_States.Text = "Nvidia Stats";
            this.Btn_Nvidia_States.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nvidia_States.UseVisualStyleBackColor = false;
            this.Btn_Nvidia_States.Click += new System.EventHandler(this.Btnstates);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.about_support_panel);
            this.panel1.Controls.Add(this.logoutpanel);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.ChangeMinerdashboardTabPanel);
            this.panel1.Controls.Add(this.AmdStatsTabPanel);
            this.panel1.Controls.Add(this.NvidiaStatsTabPanel);
            this.panel1.Controls.Add(this.dashboardTabPanel);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 875);
            this.panel1.TabIndex = 15;
            // 
            // about_support_panel
            // 
            this.about_support_panel.Controls.Add(this.panel3);
            this.about_support_panel.Controls.Add(this.Aboutbtn);
            this.about_support_panel.Controls.Add(this.Supportbtn);
            this.about_support_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.about_support_panel.Location = new System.Drawing.Point(0, 525);
            this.about_support_panel.Name = "about_support_panel";
            this.about_support_panel.Padding = new System.Windows.Forms.Padding(0, 40, 0, 10);
            this.about_support_panel.Size = new System.Drawing.Size(200, 142);
            this.about_support_panel.TabIndex = 28;
            this.about_support_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.about_support_panel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 4);
            this.panel3.TabIndex = 8;
            // 
            // Aboutbtn
            // 
            this.Aboutbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Aboutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Aboutbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Aboutbtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Aboutbtn.FlatAppearance.BorderSize = 0;
            this.Aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aboutbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aboutbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.Aboutbtn.Location = new System.Drawing.Point(0, 60);
            this.Aboutbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Aboutbtn.Name = "Aboutbtn";
            this.Aboutbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Aboutbtn.Size = new System.Drawing.Size(200, 36);
            this.Aboutbtn.TabIndex = 9;
            this.Aboutbtn.Text = "About";
            this.Aboutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aboutbtn.UseVisualStyleBackColor = false;
            this.Aboutbtn.Click += new System.EventHandler(this.Aboutbtn_Click);
            // 
            // Supportbtn
            // 
            this.Supportbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Supportbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Supportbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Supportbtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Supportbtn.FlatAppearance.BorderSize = 0;
            this.Supportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supportbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supportbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.Supportbtn.Location = new System.Drawing.Point(0, 96);
            this.Supportbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Supportbtn.Name = "Supportbtn";
            this.Supportbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Supportbtn.Size = new System.Drawing.Size(200, 36);
            this.Supportbtn.TabIndex = 10;
            this.Supportbtn.Text = "Support";
            this.Supportbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Supportbtn.UseVisualStyleBackColor = false;
            this.Supportbtn.Click += new System.EventHandler(this.button9_Click);
            // 
            // logoutpanel
            // 
            this.logoutpanel.Controls.Add(this.pictureBox10);
            this.logoutpanel.Controls.Add(this.exitbtn);
            this.logoutpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutpanel.Location = new System.Drawing.Point(0, 465);
            this.logoutpanel.Name = "logoutpanel";
            this.logoutpanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.logoutpanel.Size = new System.Drawing.Size(200, 60);
            this.logoutpanel.TabIndex = 27;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.exitbtn.Location = new System.Drawing.Point(69, 10);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(131, 40);
            this.exitbtn.TabIndex = 10;
            this.exitbtn.Text = "Exit";
            this.exitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pictureBox9);
            this.panel10.Controls.Add(this.btnsetting);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 405);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel10.Size = new System.Drawing.Size(200, 60);
            this.panel10.TabIndex = 24;
            // 
            // ChangeMinerdashboardTabPanel
            // 
            this.ChangeMinerdashboardTabPanel.Controls.Add(this.pictureBox8);
            this.ChangeMinerdashboardTabPanel.Controls.Add(this.Download_Miner);
            this.ChangeMinerdashboardTabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeMinerdashboardTabPanel.Location = new System.Drawing.Point(0, 345);
            this.ChangeMinerdashboardTabPanel.Name = "ChangeMinerdashboardTabPanel";
            this.ChangeMinerdashboardTabPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.ChangeMinerdashboardTabPanel.Size = new System.Drawing.Size(200, 60);
            this.ChangeMinerdashboardTabPanel.TabIndex = 24;
            // 
            // Download_Miner
            // 
            this.Download_Miner.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Download_Miner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Download_Miner.Dock = System.Windows.Forms.DockStyle.Right;
            this.Download_Miner.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Download_Miner.FlatAppearance.BorderSize = 0;
            this.Download_Miner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Download_Miner.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Download_Miner.ForeColor = System.Drawing.Color.FloralWhite;
            this.Download_Miner.Location = new System.Drawing.Point(72, 10);
            this.Download_Miner.Margin = new System.Windows.Forms.Padding(0);
            this.Download_Miner.Name = "Download_Miner";
            this.Download_Miner.Size = new System.Drawing.Size(128, 40);
            this.Download_Miner.TabIndex = 15;
            this.Download_Miner.Text = "Change Coin";
            this.Download_Miner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Download_Miner.UseVisualStyleBackColor = false;
            this.Download_Miner.Click += new System.EventHandler(this.Download_Miner_Click);
            // 
            // AmdStatsTabPanel
            // 
            this.AmdStatsTabPanel.Controls.Add(this.Btn_AMD_Stats);
            this.AmdStatsTabPanel.Controls.Add(this.pictureBox2);
            this.AmdStatsTabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AmdStatsTabPanel.Location = new System.Drawing.Point(0, 285);
            this.AmdStatsTabPanel.Name = "AmdStatsTabPanel";
            this.AmdStatsTabPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.AmdStatsTabPanel.Size = new System.Drawing.Size(200, 60);
            this.AmdStatsTabPanel.TabIndex = 24;
            // 
            // Btn_AMD_Stats
            // 
            this.Btn_AMD_Stats.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_AMD_Stats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_AMD_Stats.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_AMD_Stats.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_AMD_Stats.FlatAppearance.BorderSize = 0;
            this.Btn_AMD_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AMD_Stats.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AMD_Stats.ForeColor = System.Drawing.Color.FloralWhite;
            this.Btn_AMD_Stats.Location = new System.Drawing.Point(72, 10);
            this.Btn_AMD_Stats.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_AMD_Stats.Name = "Btn_AMD_Stats";
            this.Btn_AMD_Stats.Size = new System.Drawing.Size(128, 40);
            this.Btn_AMD_Stats.TabIndex = 13;
            this.Btn_AMD_Stats.Text = "AMD Stats";
            this.Btn_AMD_Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AMD_Stats.UseVisualStyleBackColor = false;
            this.Btn_AMD_Stats.Click += new System.EventHandler(this.Btn_AMD_Stats_Click);
            // 
            // NvidiaStatsTabPanel
            // 
            this.NvidiaStatsTabPanel.Controls.Add(this.pictureBox5);
            this.NvidiaStatsTabPanel.Controls.Add(this.Btn_Nvidia_States);
            this.NvidiaStatsTabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NvidiaStatsTabPanel.Location = new System.Drawing.Point(0, 225);
            this.NvidiaStatsTabPanel.Name = "NvidiaStatsTabPanel";
            this.NvidiaStatsTabPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.NvidiaStatsTabPanel.Size = new System.Drawing.Size(200, 60);
            this.NvidiaStatsTabPanel.TabIndex = 24;
            // 
            // dashboardTabPanel
            // 
            this.dashboardTabPanel.Controls.Add(this.pictureBox3);
            this.dashboardTabPanel.Controls.Add(this.button3);
            this.dashboardTabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardTabPanel.Location = new System.Drawing.Point(0, 165);
            this.dashboardTabPanel.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.dashboardTabPanel.Name = "dashboardTabPanel";
            this.dashboardTabPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dashboardTabPanel.Size = new System.Drawing.Size(200, 60);
            this.dashboardTabPanel.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FloralWhite;
            this.button3.Location = new System.Drawing.Point(69, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Dashboard";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel1);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 115);
            this.panel7.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dashboard_username, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dashboard_coinname, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.23376F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.76624F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 97);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // dashboard_username
            // 
            this.dashboard_username.AutoSize = true;
            this.dashboard_username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard_username.Location = new System.Drawing.Point(3, 0);
            this.dashboard_username.Name = "dashboard_username";
            this.dashboard_username.Size = new System.Drawing.Size(194, 64);
            this.dashboard_username.TabIndex = 19;
            this.dashboard_username.Text = "UserName";
            this.dashboard_username.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dashboard_coinname
            // 
            this.dashboard_coinname.AutoSize = true;
            this.dashboard_coinname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_coinname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_coinname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard_coinname.Location = new System.Drawing.Point(3, 64);
            this.dashboard_coinname.Name = "dashboard_coinname";
            this.dashboard_coinname.Size = new System.Drawing.Size(194, 33);
            this.dashboard_coinname.TabIndex = 20;
            this.dashboard_coinname.Text = "DTS Portal Account";
            this.dashboard_coinname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Azure;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 111);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 4);
            this.panel6.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(293, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "ELASPED TIME";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(510, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "TOTAL HASH RATE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(727, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "TOTAL POWER USAGE";
            // 
            // lbtotalhashrate
            // 
            this.lbtotalhashrate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtotalhashrate.AutoSize = true;
            this.lbtotalhashrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbtotalhashrate.Location = new System.Drawing.Point(567, 96);
            this.lbtotalhashrate.Name = "lbtotalhashrate";
            this.lbtotalhashrate.Size = new System.Drawing.Size(0, 22);
            this.lbtotalhashrate.TabIndex = 26;
            // 
            // lbtotalpower
            // 
            this.lbtotalpower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbtotalpower.AutoSize = true;
            this.lbtotalpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbtotalpower.Location = new System.Drawing.Point(774, 96);
            this.lbtotalpower.Name = "lbtotalpower";
            this.lbtotalpower.Size = new System.Drawing.Size(42, 22);
            this.lbtotalpower.TabIndex = 27;
            this.lbtotalpower.Text = "0 W";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // TopTable
            // 
            this.TopTable.AutoSize = true;
            this.TopTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TopTable.ColumnCount = 4;
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TopTable.Controls.Add(this.label1, 1, 1);
            this.TopTable.Controls.Add(this.label2, 2, 1);
            this.TopTable.Controls.Add(this.label3, 3, 1);
            this.TopTable.Controls.Add(this.lbtotalhashrate, 2, 2);
            this.TopTable.Controls.Add(this.lbtotalpower, 3, 2);
            this.TopTable.Controls.Add(this.pictureBox1, 0, 0);
            this.TopTable.Controls.Add(this.pictureBox4, 2, 0);
            this.TopTable.Controls.Add(this.pictureBox7, 3, 0);
            this.TopTable.Controls.Add(this.pictureBox6, 1, 0);
            this.TopTable.Controls.Add(this.tableLayoutPanel13, 1, 2);
            this.TopTable.Controls.Add(this.Mining_start_stop_btn, 0, 2);
            this.TopTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTable.Location = new System.Drawing.Point(0, 0);
            this.TopTable.Name = "TopTable";
            this.TopTable.RowCount = 3;
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TopTable.Size = new System.Drawing.Size(910, 127);
            this.TopTable.TabIndex = 71;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 4;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel13.Controls.Add(this.lbdays, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label14, 3, 1);
            this.tableLayoutPanel13.Controls.Add(this.label13, 2, 1);
            this.tableLayoutPanel13.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.label12, 1, 1);
            this.tableLayoutPanel13.Controls.Add(this.lbhours, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.lbmins, 2, 0);
            this.tableLayoutPanel13.Controls.Add(this.lbsecs, 3, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(237, 91);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.57576F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.42424F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(207, 33);
            this.tableLayoutPanel13.TabIndex = 28;
            // 
            // lbdays
            // 
            this.lbdays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(11, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(29, 19);
            this.lbdays.TabIndex = 4;
            this.lbdays.Text = "00";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(162, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Secs";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(111, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mins";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Days";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(56, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Hours";
            // 
            // lbhours
            // 
            this.lbhours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbhours.AutoSize = true;
            this.lbhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhours.Location = new System.Drawing.Point(62, 0);
            this.lbhours.Name = "lbhours";
            this.lbhours.Size = new System.Drawing.Size(29, 19);
            this.lbhours.TabIndex = 5;
            this.lbhours.Text = "00";
            // 
            // lbmins
            // 
            this.lbmins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbmins.AutoSize = true;
            this.lbmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmins.Location = new System.Drawing.Point(113, 0);
            this.lbmins.Name = "lbmins";
            this.lbmins.Size = new System.Drawing.Size(29, 19);
            this.lbmins.TabIndex = 6;
            this.lbmins.Text = "00";
            // 
            // lbsecs
            // 
            this.lbsecs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsecs.AutoSize = true;
            this.lbsecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsecs.Location = new System.Drawing.Point(165, 0);
            this.lbsecs.Name = "lbsecs";
            this.lbsecs.Size = new System.Drawing.Size(29, 19);
            this.lbsecs.TabIndex = 7;
            this.lbsecs.Text = "00";
            // 
            // Mining_start_stop_btn
            // 
            this.Mining_start_stop_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator;
            this.Mining_start_stop_btn.BackColor = System.Drawing.Color.Red;
            this.Mining_start_stop_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mining_start_stop_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Mining_start_stop_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mining_start_stop_btn.Location = new System.Drawing.Point(10, 88);
            this.Mining_start_stop_btn.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Mining_start_stop_btn.Name = "Mining_start_stop_btn";
            this.Mining_start_stop_btn.Size = new System.Drawing.Size(207, 29);
            this.Mining_start_stop_btn.TabIndex = 29;
            this.Mining_start_stop_btn.Text = "Start Mining ";
            this.Mining_start_stop_btn.UseSelectable = true;
            this.Mining_start_stop_btn.Click += new System.EventHandler(this.Mining_start_stop_btn_Click);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 109;
            // 
            // memoryDataGridViewTextBoxColumn1
            // 
            this.memoryDataGridViewTextBoxColumn1.DataPropertyName = "Memory";
            this.memoryDataGridViewTextBoxColumn1.HeaderText = "Memory";
            this.memoryDataGridViewTextBoxColumn1.Name = "memoryDataGridViewTextBoxColumn1";
            this.memoryDataGridViewTextBoxColumn1.Width = 109;
            // 
            // utilizationDataGridViewTextBoxColumn1
            // 
            this.utilizationDataGridViewTextBoxColumn1.DataPropertyName = "Utilization";
            this.utilizationDataGridViewTextBoxColumn1.HeaderText = "Utilization";
            this.utilizationDataGridViewTextBoxColumn1.Name = "utilizationDataGridViewTextBoxColumn1";
            this.utilizationDataGridViewTextBoxColumn1.Width = 109;
            // 
            // temperatureDataGridViewTextBoxColumn1
            // 
            this.temperatureDataGridViewTextBoxColumn1.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn1.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn1.Name = "temperatureDataGridViewTextBoxColumn1";
            this.temperatureDataGridViewTextBoxColumn1.Width = 108;
            // 
            // fanDataGridViewTextBoxColumn1
            // 
            this.fanDataGridViewTextBoxColumn1.DataPropertyName = "Fan";
            this.fanDataGridViewTextBoxColumn1.HeaderText = "Fan";
            this.fanDataGridViewTextBoxColumn1.Name = "fanDataGridViewTextBoxColumn1";
            this.fanDataGridViewTextBoxColumn1.Width = 109;
            // 
            // powerDataGridViewTextBoxColumn1
            // 
            this.powerDataGridViewTextBoxColumn1.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn1.HeaderText = "Power";
            this.powerDataGridViewTextBoxColumn1.Name = "powerDataGridViewTextBoxColumn1";
            this.powerDataGridViewTextBoxColumn1.Width = 109;
            // 
            // hashRateDataGridViewTextBoxColumn1
            // 
            this.hashRateDataGridViewTextBoxColumn1.DataPropertyName = "Hash Rate";
            this.hashRateDataGridViewTextBoxColumn1.HeaderText = "Hash Rate";
            this.hashRateDataGridViewTextBoxColumn1.Name = "hashRateDataGridViewTextBoxColumn1";
            this.hashRateDataGridViewTextBoxColumn1.Width = 109;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Width = 115;
            // 
            // memoryDataGridViewTextBoxColumn2
            // 
            this.memoryDataGridViewTextBoxColumn2.DataPropertyName = "Memory";
            this.memoryDataGridViewTextBoxColumn2.HeaderText = "Memory";
            this.memoryDataGridViewTextBoxColumn2.Name = "memoryDataGridViewTextBoxColumn2";
            this.memoryDataGridViewTextBoxColumn2.Width = 114;
            // 
            // utilizationDataGridViewTextBoxColumn2
            // 
            this.utilizationDataGridViewTextBoxColumn2.DataPropertyName = "Utilization";
            this.utilizationDataGridViewTextBoxColumn2.HeaderText = "Utilization";
            this.utilizationDataGridViewTextBoxColumn2.Name = "utilizationDataGridViewTextBoxColumn2";
            this.utilizationDataGridViewTextBoxColumn2.Width = 115;
            // 
            // temperatureDataGridViewTextBoxColumn2
            // 
            this.temperatureDataGridViewTextBoxColumn2.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn2.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn2.Name = "temperatureDataGridViewTextBoxColumn2";
            this.temperatureDataGridViewTextBoxColumn2.Width = 115;
            // 
            // fanDataGridViewTextBoxColumn2
            // 
            this.fanDataGridViewTextBoxColumn2.DataPropertyName = "Fan";
            this.fanDataGridViewTextBoxColumn2.HeaderText = "Fan";
            this.fanDataGridViewTextBoxColumn2.Name = "fanDataGridViewTextBoxColumn2";
            this.fanDataGridViewTextBoxColumn2.Width = 115;
            // 
            // powerDataGridViewTextBoxColumn2
            // 
            this.powerDataGridViewTextBoxColumn2.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn2.HeaderText = "Power";
            this.powerDataGridViewTextBoxColumn2.Name = "powerDataGridViewTextBoxColumn2";
            this.powerDataGridViewTextBoxColumn2.Width = 114;
            // 
            // hashRateDataGridViewTextBoxColumn2
            // 
            this.hashRateDataGridViewTextBoxColumn2.DataPropertyName = "Hash Rate";
            this.hashRateDataGridViewTextBoxColumn2.HeaderText = "Hash Rate";
            this.hashRateDataGridViewTextBoxColumn2.Name = "hashRateDataGridViewTextBoxColumn2";
            this.hashRateDataGridViewTextBoxColumn2.Width = 115;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.TopTable);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(910, 127);
            this.TopPanel.TabIndex = 91;
            // 
            // dashboardUC
            // 
            this.dashboardUC.Location = new System.Drawing.Point(16, 0);
            this.dashboardUC.Name = "dashboardUC";
            this.dashboardUC.Size = new System.Drawing.Size(1094, 875);
            this.dashboardUC.TabIndex = 13;
            this.dashboardUC.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tag = "";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GCtable1
            // 
            this.GCtable1.AutoSize = true;
            this.GCtable1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GCtable1.ColumnCount = 1;
            this.GCtable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GCtable1.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.GCtable1.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.GCtable1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GCtable1.Location = new System.Drawing.Point(0, 0);
            this.GCtable1.Name = "GCtable1";
            this.GCtable1.RowCount = 2;
            this.GCtable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.84233F));
            this.GCtable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.15767F));
            this.GCtable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GCtable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GCtable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GCtable1.Size = new System.Drawing.Size(910, 61);
            this.GCtable1.TabIndex = 88;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(904, 15);
            this.tableLayoutPanel7.TabIndex = 77;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(898, 9);
            this.panel5.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.GC1, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(839, 32);
            this.tableLayoutPanel6.TabIndex = 76;
            // 
            // GC1
            // 
            this.GC1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GC1.AutoSize = true;
            this.GC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.GC1.Location = new System.Drawing.Point(3, 5);
            this.GC1.Name = "GC1";
            this.GC1.Size = new System.Drawing.Size(49, 22);
            this.GC1.TabIndex = 47;
            this.GC1.Text = "GPU";
            // 
            // AMD_panel
            // 
            this.AMD_panel.Controls.Add(this.GPUtable);
            this.AMD_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AMD_panel.Location = new System.Drawing.Point(0, 390);
            this.AMD_panel.Name = "AMD_panel";
            this.AMD_panel.Size = new System.Drawing.Size(910, 344);
            this.AMD_panel.TabIndex = 90;
            // 
            // GPUtable
            // 
            this.GPUtable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GPUtable.ColumnCount = 1;
            this.GPUtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GPUtable.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.GPUtable.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.GPUtable.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.GPUtable.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.GPUtable.Controls.Add(this.tableLayoutPanel21, 0, 4);
            this.GPUtable.Dock = System.Windows.Forms.DockStyle.Top;
            this.GPUtable.Location = new System.Drawing.Point(0, 0);
            this.GPUtable.Name = "GPUtable";
            this.GPUtable.RowCount = 5;
            this.GPUtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.22715F));
            this.GPUtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.613577F));
            this.GPUtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.22715F));
            this.GPUtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.22715F));
            this.GPUtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.70496F));
            this.GPUtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GPUtable.Size = new System.Drawing.Size(910, 344);
            this.GPUtable.TabIndex = 90;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(904, 24);
            this.tableLayoutPanel2.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "AMD";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(904, 8);
            this.tableLayoutPanel3.TabIndex = 73;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(898, 2);
            this.panel4.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.GPUStatus, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.GPUMining_Coin, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbAMD_GPU_Total_Hashrate, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(904, 20);
            this.tableLayoutPanel4.TabIndex = 74;
            // 
            // GPUStatus
            // 
            this.GPUStatus.AutoSize = true;
            this.GPUStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GPUStatus.Location = new System.Drawing.Point(3, 0);
            this.GPUStatus.Name = "GPUStatus";
            this.GPUStatus.Size = new System.Drawing.Size(56, 20);
            this.GPUStatus.TabIndex = 30;
            this.GPUStatus.Text = "Status";
            // 
            // GPUMining_Coin
            // 
            this.GPUMining_Coin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GPUMining_Coin.AutoSize = true;
            this.GPUMining_Coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GPUMining_Coin.Location = new System.Drawing.Point(229, 0);
            this.GPUMining_Coin.Name = "GPUMining_Coin";
            this.GPUMining_Coin.Size = new System.Drawing.Size(95, 20);
            this.GPUMining_Coin.TabIndex = 31;
            this.GPUMining_Coin.Text = " Mining Coin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(455, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Miner";
            // 
            // lbAMD_GPU_Total_Hashrate
            // 
            this.lbAMD_GPU_Total_Hashrate.AutoSize = true;
            this.lbAMD_GPU_Total_Hashrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAMD_GPU_Total_Hashrate.Location = new System.Drawing.Point(681, 0);
            this.lbAMD_GPU_Total_Hashrate.Name = "lbAMD_GPU_Total_Hashrate";
            this.lbAMD_GPU_Total_Hashrate.Size = new System.Drawing.Size(79, 20);
            this.lbAMD_GPU_Total_Hashrate.TabIndex = 33;
            this.lbAMD_GPU_Total_Hashrate.Text = "Hash rate";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 8;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.AMD_GPUStart_Stop_Lbl, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.AMD_coin, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.AMD_Statuspng, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.AMD_Miner_Name, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.AMD_GPU_Total_Hashrate, 7, 0);
            this.tableLayoutPanel5.Controls.Add(this.AMD_coin_iconPB, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 98);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(904, 24);
            this.tableLayoutPanel5.TabIndex = 75;
            // 
            // AMD_GPUStart_Stop_Lbl
            // 
            this.AMD_GPUStart_Stop_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AMD_GPUStart_Stop_Lbl.AutoSize = true;
            this.AMD_GPUStart_Stop_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AMD_GPUStart_Stop_Lbl.Location = new System.Drawing.Point(48, 2);
            this.AMD_GPUStart_Stop_Lbl.Name = "AMD_GPUStart_Stop_Lbl";
            this.AMD_GPUStart_Stop_Lbl.Size = new System.Drawing.Size(70, 20);
            this.AMD_GPUStart_Stop_Lbl.TabIndex = 43;
            this.AMD_GPUStart_Stop_Lbl.Text = "Stopped";
            // 
            // AMD_coin
            // 
            this.AMD_coin.AutoSize = true;
            this.AMD_coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AMD_coin.Location = new System.Drawing.Point(273, 0);
            this.AMD_coin.Name = "AMD_coin";
            this.AMD_coin.Size = new System.Drawing.Size(63, 20);
            this.AMD_coin.TabIndex = 44;
            this.AMD_coin.Text = "Monero";
            // 
            // AMD_Miner_Name
            // 
            this.AMD_Miner_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AMD_Miner_Name.AutoSize = true;
            this.AMD_Miner_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AMD_Miner_Name.Location = new System.Drawing.Point(498, 2);
            this.AMD_Miner_Name.Name = "AMD_Miner_Name";
            this.AMD_Miner_Name.Size = new System.Drawing.Size(75, 20);
            this.AMD_Miner_Name.TabIndex = 45;
            this.AMD_Miner_Name.Text = "DTS RIG";
            // 
            // AMD_GPU_Total_Hashrate
            // 
            this.AMD_GPU_Total_Hashrate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AMD_GPU_Total_Hashrate.AutoSize = true;
            this.AMD_GPU_Total_Hashrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AMD_GPU_Total_Hashrate.Location = new System.Drawing.Point(723, 2);
            this.AMD_GPU_Total_Hashrate.Name = "AMD_GPU_Total_Hashrate";
            this.AMD_GPU_Total_Hashrate.Size = new System.Drawing.Size(18, 20);
            this.AMD_GPU_Total_Hashrate.TabIndex = 46;
            this.AMD_GPU_Total_Hashrate.Text = "0";
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 1;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Controls.Add(this.GC2minerdata, 0, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 136);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(904, 205);
            this.tableLayoutPanel21.TabIndex = 95;
            // 
            // GC2minerdata
            // 
            this.GC2minerdata.AllowUserToAddRows = false;
            this.GC2minerdata.AllowUserToDeleteRows = false;
            this.GC2minerdata.AllowUserToResizeColumns = false;
            this.GC2minerdata.AllowUserToResizeRows = false;
            this.GC2minerdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GC2minerdata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GC2minerdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GC2minerdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GC2minerdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GC2minerdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GC2minerdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GC2minerdata.ColumnHeadersHeight = 25;
            this.GC2minerdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GC2minerdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.GC2minerdata.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GC2minerdata.DefaultCellStyle = dataGridViewCellStyle3;
            this.GC2minerdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GC2minerdata.EnableHeadersVisualStyles = false;
            this.GC2minerdata.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GC2minerdata.GridColor = System.Drawing.Color.White;
            this.GC2minerdata.Location = new System.Drawing.Point(9, 3);
            this.GC2minerdata.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.GC2minerdata.Name = "GC2minerdata";
            this.GC2minerdata.ReadOnly = true;
            this.GC2minerdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GC2minerdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GC2minerdata.RowHeadersVisible = false;
            this.GC2minerdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GC2minerdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GC2minerdata.Size = new System.Drawing.Size(886, 199);
            this.GC2minerdata.TabIndex = 92;
            this.GC2minerdata.UseCustomBackColor = true;
            this.GC2minerdata.UseCustomForeColor = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Memory Card";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Utilization";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Temperature";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fan Speed";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Power";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Hash Rate";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Dashboardpanel
            // 
            this.Dashboardpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboardpanel.Controls.Add(this.AMD_panel);
            this.Dashboardpanel.Controls.Add(this.Nvidia_panel);
            this.Dashboardpanel.Controls.Add(this.GCtable1);
            this.Dashboardpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboardpanel.Location = new System.Drawing.Point(0, 0);
            this.Dashboardpanel.Name = "Dashboardpanel";
            this.Dashboardpanel.Size = new System.Drawing.Size(910, 748);
            this.Dashboardpanel.TabIndex = 93;
            // 
            // Nvidia_panel
            // 
            this.Nvidia_panel.Controls.Add(this.GCtable2);
            this.Nvidia_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nvidia_panel.Location = new System.Drawing.Point(0, 61);
            this.Nvidia_panel.Name = "Nvidia_panel";
            this.Nvidia_panel.Size = new System.Drawing.Size(910, 329);
            this.Nvidia_panel.TabIndex = 89;
            // 
            // GCtable2
            // 
            this.GCtable2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GCtable2.ColumnCount = 1;
            this.GCtable2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GCtable2.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.GCtable2.Controls.Add(this.tableLayoutPanel11, 0, 5);
            this.GCtable2.Controls.Add(this.tableLayoutPanel12, 0, 5);
            this.GCtable2.Controls.Add(this.tableLayoutPanel14, 0, 2);
            this.GCtable2.Controls.Add(this.tableLayoutPanel15, 0, 3);
            this.GCtable2.Controls.Add(this.tableLayoutPanel19, 0, 1);
            this.GCtable2.Dock = System.Windows.Forms.DockStyle.Top;
            this.GCtable2.Location = new System.Drawing.Point(0, 0);
            this.GCtable2.Name = "GCtable2";
            this.GCtable2.RowCount = 6;
            this.GCtable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.3068F));
            this.GCtable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.496959F));
            this.GCtable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.987288F));
            this.GCtable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33748F));
            this.GCtable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.GCtable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.GCtable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.87148F));
            this.GCtable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GCtable2.Size = new System.Drawing.Size(910, 329);
            this.GCtable2.TabIndex = 89;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.label41, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(904, 22);
            this.tableLayoutPanel10.TabIndex = 92;
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label41.Location = new System.Drawing.Point(3, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(68, 22);
            this.label41.TabIndex = 47;
            this.label41.Text = "NVIDIA";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.GC1minerdata, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(904, 203);
            this.tableLayoutPanel11.TabIndex = 90;
            // 
            // GC1minerdata
            // 
            this.GC1minerdata.AllowUserToAddRows = false;
            this.GC1minerdata.AllowUserToDeleteRows = false;
            this.GC1minerdata.AllowUserToResizeColumns = false;
            this.GC1minerdata.AllowUserToResizeRows = false;
            this.GC1minerdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GC1minerdata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GC1minerdata.BackgroundColor = System.Drawing.Color.White;
            this.GC1minerdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GC1minerdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GC1minerdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GC1minerdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GC1minerdata.ColumnHeadersHeight = 25;
            this.GC1minerdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.GC1minerdata.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GC1minerdata.DefaultCellStyle = dataGridViewCellStyle6;
            this.GC1minerdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GC1minerdata.EnableHeadersVisualStyles = false;
            this.GC1minerdata.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GC1minerdata.GridColor = System.Drawing.Color.White;
            this.GC1minerdata.Location = new System.Drawing.Point(9, 3);
            this.GC1minerdata.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.GC1minerdata.MultiSelect = false;
            this.GC1minerdata.Name = "GC1minerdata";
            this.GC1minerdata.ReadOnly = true;
            this.GC1minerdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GC1minerdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GC1minerdata.RowHeadersVisible = false;
            this.GC1minerdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GC1minerdata.RowTemplate.Height = 30;
            this.GC1minerdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GC1minerdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GC1minerdata.ShowRowErrors = false;
            this.GC1minerdata.Size = new System.Drawing.Size(886, 197);
            this.GC1minerdata.TabIndex = 93;
            this.GC1minerdata.UseCustomBackColor = true;
            this.GC1minerdata.UseCustomForeColor = true;
            this.GC1minerdata.UseStyleColors = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Memory Card";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Utilization";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Temperature";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Fan Speed";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Power";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Hash Rate";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.GC2, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(904, 1);
            this.tableLayoutPanel12.TabIndex = 82;
            // 
            // GC2
            // 
            this.GC2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GC2.AutoSize = true;
            this.GC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.GC2.Location = new System.Drawing.Point(3, 0);
            this.GC2.Name = "GC2";
            this.GC2.Size = new System.Drawing.Size(49, 1);
            this.GC2.TabIndex = 47;
            this.GC2.Text = "AMD";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(743, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 1);
            this.button1.TabIndex = 49;
            this.button1.Text = "ADVANCE SETTINGS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel14.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.label25, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.label28, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.lbNvidia_GPU_Total_Hashrate, 3, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(904, 26);
            this.tableLayoutPanel14.TabIndex = 84;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Left;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 26);
            this.label19.TabIndex = 30;
            this.label19.Text = "Status";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label25.Location = new System.Drawing.Point(455, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 20);
            this.label25.TabIndex = 32;
            this.label25.Text = "Miner";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label28.Location = new System.Drawing.Point(229, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 20);
            this.label28.TabIndex = 31;
            this.label28.Text = " Mining Coin";
            // 
            // lbNvidia_GPU_Total_Hashrate
            // 
            this.lbNvidia_GPU_Total_Hashrate.AutoSize = true;
            this.lbNvidia_GPU_Total_Hashrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNvidia_GPU_Total_Hashrate.Location = new System.Drawing.Point(681, 0);
            this.lbNvidia_GPU_Total_Hashrate.Name = "lbNvidia_GPU_Total_Hashrate";
            this.lbNvidia_GPU_Total_Hashrate.Size = new System.Drawing.Size(79, 20);
            this.lbNvidia_GPU_Total_Hashrate.TabIndex = 33;
            this.lbNvidia_GPU_Total_Hashrate.Text = "Hash rate";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 8;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel15.Controls.Add(this.Nvidia_GPUStart_Stop_Lbl, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.Nvidia_coin, 3, 0);
            this.tableLayoutPanel15.Controls.Add(this.Nvidia_Statuspng, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.Nvidia_Miner_Name, 5, 0);
            this.tableLayoutPanel15.Controls.Add(this.Nvidia_GPU_Total_Hashrate, 7, 0);
            this.tableLayoutPanel15.Controls.Add(this.Nvidia_coin_iconPB, 2, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 86);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(904, 24);
            this.tableLayoutPanel15.TabIndex = 85;
            // 
            // Nvidia_GPUStart_Stop_Lbl
            // 
            this.Nvidia_GPUStart_Stop_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Nvidia_GPUStart_Stop_Lbl.AutoSize = true;
            this.Nvidia_GPUStart_Stop_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Nvidia_GPUStart_Stop_Lbl.Location = new System.Drawing.Point(48, 2);
            this.Nvidia_GPUStart_Stop_Lbl.Name = "Nvidia_GPUStart_Stop_Lbl";
            this.Nvidia_GPUStart_Stop_Lbl.Size = new System.Drawing.Size(70, 20);
            this.Nvidia_GPUStart_Stop_Lbl.TabIndex = 43;
            this.Nvidia_GPUStart_Stop_Lbl.Text = "Stopped";
            // 
            // Nvidia_coin
            // 
            this.Nvidia_coin.AutoSize = true;
            this.Nvidia_coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Nvidia_coin.Location = new System.Drawing.Point(273, 0);
            this.Nvidia_coin.Name = "Nvidia_coin";
            this.Nvidia_coin.Size = new System.Drawing.Size(63, 20);
            this.Nvidia_coin.TabIndex = 44;
            this.Nvidia_coin.Text = "Monero";
            // 
            // Nvidia_Miner_Name
            // 
            this.Nvidia_Miner_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Nvidia_Miner_Name.AutoSize = true;
            this.Nvidia_Miner_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Nvidia_Miner_Name.Location = new System.Drawing.Point(498, 2);
            this.Nvidia_Miner_Name.Name = "Nvidia_Miner_Name";
            this.Nvidia_Miner_Name.Size = new System.Drawing.Size(75, 20);
            this.Nvidia_Miner_Name.TabIndex = 45;
            this.Nvidia_Miner_Name.Text = "DTS RIG";
            // 
            // Nvidia_GPU_Total_Hashrate
            // 
            this.Nvidia_GPU_Total_Hashrate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Nvidia_GPU_Total_Hashrate.AutoSize = true;
            this.Nvidia_GPU_Total_Hashrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Nvidia_GPU_Total_Hashrate.Location = new System.Drawing.Point(723, 2);
            this.Nvidia_GPU_Total_Hashrate.Name = "Nvidia_GPU_Total_Hashrate";
            this.Nvidia_GPU_Total_Hashrate.Size = new System.Drawing.Size(18, 20);
            this.Nvidia_GPU_Total_Hashrate.TabIndex = 46;
            this.Nvidia_GPU_Total_Hashrate.Text = "0";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(904, 9);
            this.tableLayoutPanel19.TabIndex = 88;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(898, 3);
            this.panel9.TabIndex = 9;
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ControlsPanel.Controls.Add(this.Dashboardpanel);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsPanel.Location = new System.Drawing.Point(200, 127);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(910, 748);
            this.ControlsPanel.TabIndex = 94;
            // 
            // AMD_Statuspng
            // 
            this.AMD_Statuspng.Cursor = System.Windows.Forms.Cursors.Default;
            this.AMD_Statuspng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AMD_Statuspng.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AMD_Statuspng.ErrorImage")));
            this.AMD_Statuspng.Image = ((System.Drawing.Image)(resources.GetObject("AMD_Statuspng.Image")));
            this.AMD_Statuspng.InitialImage = ((System.Drawing.Image)(resources.GetObject("AMD_Statuspng.InitialImage")));
            this.AMD_Statuspng.Location = new System.Drawing.Point(3, 3);
            this.AMD_Statuspng.Name = "AMD_Statuspng";
            this.AMD_Statuspng.Size = new System.Drawing.Size(39, 18);
            this.AMD_Statuspng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AMD_Statuspng.TabIndex = 68;
            this.AMD_Statuspng.TabStop = false;
            // 
            // AMD_coin_iconPB
            // 
            this.AMD_coin_iconPB.Location = new System.Drawing.Point(225, 0);
            this.AMD_coin_iconPB.Margin = new System.Windows.Forms.Padding(0);
            this.AMD_coin_iconPB.Name = "AMD_coin_iconPB";
            this.AMD_coin_iconPB.Size = new System.Drawing.Size(39, 18);
            this.AMD_coin_iconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AMD_coin_iconPB.TabIndex = 69;
            this.AMD_coin_iconPB.TabStop = false;
            // 
            // Nvidia_Statuspng
            // 
            this.Nvidia_Statuspng.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nvidia_Statuspng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nvidia_Statuspng.Image = ((System.Drawing.Image)(resources.GetObject("Nvidia_Statuspng.Image")));
            this.Nvidia_Statuspng.Location = new System.Drawing.Point(3, 3);
            this.Nvidia_Statuspng.Name = "Nvidia_Statuspng";
            this.Nvidia_Statuspng.Size = new System.Drawing.Size(39, 18);
            this.Nvidia_Statuspng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nvidia_Statuspng.TabIndex = 68;
            this.Nvidia_Statuspng.TabStop = false;
            // 
            // Nvidia_coin_iconPB
            // 
            this.Nvidia_coin_iconPB.Location = new System.Drawing.Point(225, 0);
            this.Nvidia_coin_iconPB.Margin = new System.Windows.Forms.Padding(0);
            this.Nvidia_coin_iconPB.Name = "Nvidia_coin_iconPB";
            this.Nvidia_coin_iconPB.Size = new System.Drawing.Size(39, 18);
            this.Nvidia_coin_iconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nvidia_coin_iconPB.TabIndex = 69;
            this.Nvidia_coin_iconPB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::SKY.Properties.Resources._78_512;
            this.pictureBox4.Location = new System.Drawing.Point(528, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(78, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(763, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Image = global::SKY.Properties.Resources.clock_9_65964;
            this.pictureBox6.Location = new System.Drawing.Point(308, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(34, 10);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(38, 10);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(37, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(35, 10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(35, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BackgroundImage = global::SKY.Properties.Resources.main_logo_top;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(262, -1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(433, 394);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboardUC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.ShowInTaskbar = false;
            this.Text = "Sky Net";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.about_support_panel.ResumeLayout(false);
            this.logoutpanel.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ChangeMinerdashboardTabPanel.ResumeLayout(false);
            this.AmdStatsTabPanel.ResumeLayout(false);
            this.NvidiaStatsTabPanel.ResumeLayout(false);
            this.dashboardTabPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.TopTable.ResumeLayout(false);
            this.TopTable.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.GCtable1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.AMD_panel.ResumeLayout(false);
            this.GPUtable.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC2minerdata)).EndInit();
            this.Dashboardpanel.ResumeLayout(false);
            this.Dashboardpanel.PerformLayout();
            this.Nvidia_panel.ResumeLayout(false);
            this.GCtable2.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC1minerdata)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.ControlsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AMD_Statuspng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMD_coin_iconPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nvidia_Statuspng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nvidia_coin_iconPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button Btn_Nvidia_States;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbtotalhashrate;
        private System.Windows.Forms.Label lbtotalpower;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TableLayoutPanel TopTable;
    
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashRateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizationDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fanDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hashRateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel TopPanel;
        private MetroFramework.Controls.MetroUserControl dashboardUC;
      
        private Timer timer1;
        private TableLayoutPanel tableLayoutPanel13;
        private Label lbsecs;
        private Label lbmins;
        private Label lbhours;
        private Label lbdays;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label6;
       
        private Panel Dashboardpanel;
        private Panel AMD_panel;
        private TableLayoutPanel GPUtable;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label GPUStatus;
        private Label label10;
        private Label lbAMD_GPU_Total_Hashrate;
        private TableLayoutPanel tableLayoutPanel5;
        private Label AMD_GPUStart_Stop_Lbl;
        private PictureBox AMD_Statuspng;
        private Label GPUMining_Coin;
        private Label AMD_Miner_Name;
        private Label AMD_GPU_Total_Hashrate;
        private TableLayoutPanel tableLayoutPanel21;
        private MetroFramework.Controls.MetroGrid GC2minerdata;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn memutilDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn gPUutilDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tempminerDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fanspeedDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn hashrateDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memutilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gPUutilDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tempminerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fanspeedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hashrateDataGridViewTextBoxColumn;
        private TableLayoutPanel GCtable1;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label GC1;
        private Panel ControlsPanel; 
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
         private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private PictureBox pictureBox2;
        private Button Btn_AMD_Stats;
         private Timer timer2;
        private PictureBox pictureBox8;
        private Button Download_Miner;
        private Panel panel6;
        private Label dashboard_username;
        private MetroFramework.Controls.MetroButton Mining_start_stop_btn;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Panel Nvidia_panel;
        private TableLayoutPanel GCtable2;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label41;
        private TableLayoutPanel tableLayoutPanel11;
        private MetroFramework.Controls.MetroGrid GC1minerdata;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private TableLayoutPanel tableLayoutPanel12;
        private Label GC2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label19;
        private Label label25;
        private Label label28;
        private Label lbNvidia_GPU_Total_Hashrate;
        private TableLayoutPanel tableLayoutPanel15;
        private Label Nvidia_GPUStart_Stop_Lbl;
        private PictureBox Nvidia_Statuspng;
        private Label Nvidia_Miner_Name;
        private Label Nvidia_GPU_Total_Hashrate;
        private TableLayoutPanel tableLayoutPanel19;
        private Panel panel9;
        private Panel panel7;
        private Panel ChangeMinerdashboardTabPanel;
        private Panel AmdStatsTabPanel;
        private Panel NvidiaStatsTabPanel;
        private Panel dashboardTabPanel;
        private Panel panel10;
        private Panel logoutpanel;
        private Button exitbtn;
        private PictureBox pictureBox10;
        private Panel about_support_panel;
        private Panel panel3;
        private Button Aboutbtn;
        private Button Supportbtn;
        public Label dashboard_coinname;
        public Label Nvidia_coin;
        public Label AMD_coin;
        private PictureBox AMD_coin_iconPB;
        private PictureBox Nvidia_coin_iconPB;
    }
}

