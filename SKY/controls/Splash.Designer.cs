namespace SKY.controls
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.splash_panel = new System.Windows.Forms.Panel();
            this.changeLB = new System.Windows.Forms.Label();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.perLB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splash_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splash_panel
            // 
            this.splash_panel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.splash_panel.Controls.Add(this.perLB);
            this.splash_panel.Controls.Add(this.changeLB);
            this.splash_panel.Controls.Add(this.metroProgressBar1);
            this.splash_panel.Controls.Add(this.pictureBox1);
            this.splash_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splash_panel.Location = new System.Drawing.Point(0, 0);
            this.splash_panel.Name = "splash_panel";
            this.splash_panel.Size = new System.Drawing.Size(952, 721);
            this.splash_panel.TabIndex = 1;
            // 
            // changeLB
            // 
            this.changeLB.AutoSize = true;
            this.changeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeLB.Location = new System.Drawing.Point(339, 467);
            this.changeLB.Name = "changeLB";
            this.changeLB.Size = new System.Drawing.Size(325, 20);
            this.changeLB.TabIndex = 2;
            this.changeLB.Text = "Please wait while your Drivers are Installing....";
            this.changeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(272, 430);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(431, 14);
            this.metroProgressBar1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SKY.Properties.Resources.main_logo_top;
            this.pictureBox1.Location = new System.Drawing.Point(272, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // perLB
            // 
            this.perLB.AutoSize = true;
            this.perLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.perLB.Location = new System.Drawing.Point(712, 427);
            this.perLB.Name = "perLB";
            this.perLB.Size = new System.Drawing.Size(32, 20);
            this.perLB.TabIndex = 3;
            this.perLB.Text = "0%";
            this.perLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 721);
            this.Controls.Add(this.splash_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.splash_panel.ResumeLayout(false);
            this.splash_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel splash_panel;
        private System.Windows.Forms.Label changeLB;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label perLB;
        private System.Windows.Forms.Timer timer1;
    }
}