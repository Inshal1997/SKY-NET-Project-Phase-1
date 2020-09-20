namespace SKY.controls
{
    partial class Miner_Setting_popup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_panel = new System.Windows.Forms.Panel();
            this.Setting_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NVIDIA_comboBox = new System.Windows.Forms.ComboBox();
            this.NVIDIA_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AMD_textbox = new System.Windows.Forms.TextBox();
            this.AMD_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AMD_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.button_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.AMD_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button_panel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.AMD_panel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 261);
            this.panel1.TabIndex = 0;
            // 
            // button_panel
            // 
            this.button_panel.Controls.Add(this.Setting_button);
            this.button_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_panel.Location = new System.Drawing.Point(0, 220);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(553, 41);
            this.button_panel.TabIndex = 4;
            // 
            // Setting_button
            // 
            this.Setting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_button.ForeColor = System.Drawing.Color.White;
            this.Setting_button.Location = new System.Drawing.Point(209, 9);
            this.Setting_button.Name = "Setting_button";
            this.Setting_button.Size = new System.Drawing.Size(149, 23);
            this.Setting_button.TabIndex = 0;
            this.Setting_button.Text = "SAVE CHANGES";
            this.Setting_button.UseVisualStyleBackColor = true;
            this.Setting_button.Click += new System.EventHandler(this.Setting_button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.NVIDIA_comboBox);
            this.panel3.Controls.Add(this.NVIDIA_textbox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 89);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "NVIDIA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Change Setting:";
            // 
            // NVIDIA_comboBox
            // 
            this.NVIDIA_comboBox.FormattingEnabled = true;
            this.NVIDIA_comboBox.Items.AddRange(new object[] {
            "Default",
            "setting A",
            "setting B",
            "setting C"});
            this.NVIDIA_comboBox.Location = new System.Drawing.Point(196, 59);
            this.NVIDIA_comboBox.Name = "NVIDIA_comboBox";
            this.NVIDIA_comboBox.Size = new System.Drawing.Size(311, 21);
            this.NVIDIA_comboBox.TabIndex = 3;
            this.NVIDIA_comboBox.SelectedIndexChanged += new System.EventHandler(this.NVIDIA_comboBox_SelectedIndexChanged);
            // 
            // NVIDIA_textbox
            // 
            this.NVIDIA_textbox.BackColor = System.Drawing.Color.White;
            this.NVIDIA_textbox.Location = new System.Drawing.Point(196, 34);
            this.NVIDIA_textbox.Name = "NVIDIA_textbox";
            this.NVIDIA_textbox.ReadOnly = true;
            this.NVIDIA_textbox.Size = new System.Drawing.Size(311, 20);
            this.NVIDIA_textbox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Current Setting:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 42);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(131, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHANGE MINER SETTING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Setting:";
            // 
            // AMD_textbox
            // 
            this.AMD_textbox.BackColor = System.Drawing.Color.White;
            this.AMD_textbox.Location = new System.Drawing.Point(196, 32);
            this.AMD_textbox.Name = "AMD_textbox";
            this.AMD_textbox.ReadOnly = true;
            this.AMD_textbox.Size = new System.Drawing.Size(311, 20);
            this.AMD_textbox.TabIndex = 2;
            // 
            // AMD_comboBox
            // 
            this.AMD_comboBox.FormattingEnabled = true;
            this.AMD_comboBox.Items.AddRange(new object[] {
            "Default",
            "setting A",
            "setting B",
            "setting C"});
            this.AMD_comboBox.Location = new System.Drawing.Point(196, 57);
            this.AMD_comboBox.Name = "AMD_comboBox";
            this.AMD_comboBox.Size = new System.Drawing.Size(311, 21);
            this.AMD_comboBox.TabIndex = 3;
            this.AMD_comboBox.SelectedIndexChanged += new System.EventHandler(this.AMD_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Change Setting:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "AMD:";
            // 
            // AMD_panel
            // 
            this.AMD_panel.Controls.Add(this.label4);
            this.AMD_panel.Controls.Add(this.label3);
            this.AMD_panel.Controls.Add(this.AMD_comboBox);
            this.AMD_panel.Controls.Add(this.AMD_textbox);
            this.AMD_panel.Controls.Add(this.label2);
            this.AMD_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AMD_panel.Location = new System.Drawing.Point(0, 42);
            this.AMD_panel.Name = "AMD_panel";
            this.AMD_panel.Size = new System.Drawing.Size(553, 89);
            this.AMD_panel.TabIndex = 2;
            // 
            // Miner_Setting_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Miner_Setting_popup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Miner_Setting_popup";
            this.Load += new System.EventHandler(this.Miner_Setting_popup_Load);
            this.panel1.ResumeLayout(false);
            this.button_panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.AMD_panel.ResumeLayout(false);
            this.AMD_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox NVIDIA_comboBox;
        private System.Windows.Forms.TextBox NVIDIA_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.Button Setting_button;
        private System.Windows.Forms.Panel AMD_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AMD_comboBox;
        private System.Windows.Forms.TextBox AMD_textbox;
        private System.Windows.Forms.Label label2;
    }
}