namespace SKY
{
    partial class stats_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statspanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.statsGPUdata = new MetroFramework.Controls.MetroGrid();
            this.GPUDeatailspanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tempchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Hashratechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.powerchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statspanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsGPUdata)).BeginInit();
            this.GPUDeatailspanel.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hashratechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // statspanel
            // 
            this.statspanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statspanel.Controls.Add(this.tableLayoutPanel8);
            this.statspanel.Controls.Add(this.panel7);
            this.statspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statspanel.Location = new System.Drawing.Point(0, 0);
            this.statspanel.Name = "statspanel";
            this.statspanel.Size = new System.Drawing.Size(910, 773);
            this.statspanel.TabIndex = 94;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.metroLabel1);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(910, 62);
            this.panel7.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(436, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 50);
            this.label9.TabIndex = 0;
            this.label9.Text = "Statistics";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.028369F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.85107F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.12057F));
            this.tableLayoutPanel8.Controls.Add(this.statsGPUdata, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.GPUDeatailspanel, 1, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.96679F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.0332F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(910, 752);
            this.tableLayoutPanel8.TabIndex = 3;
            this.tableLayoutPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel8_Paint);
            // 
            // statsGPUdata
            // 
            this.statsGPUdata.AllowUserToResizeRows = false;
            this.statsGPUdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statsGPUdata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statsGPUdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statsGPUdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.statsGPUdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statsGPUdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.statsGPUdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statsGPUdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.statsGPUdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsGPUdata.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.statsGPUdata.EnableHeadersVisualStyles = false;
            this.statsGPUdata.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statsGPUdata.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statsGPUdata.Location = new System.Drawing.Point(55, 3);
            this.statsGPUdata.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.statsGPUdata.Name = "statsGPUdata";
            this.statsGPUdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statsGPUdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.statsGPUdata.RowHeadersVisible = false;
            this.statsGPUdata.RowHeadersWidth = 40;
            this.statsGPUdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.statsGPUdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statsGPUdata.Size = new System.Drawing.Size(733, 159);
            this.statsGPUdata.TabIndex = 1;
            this.statsGPUdata.MouseClick += new System.Windows.Forms.MouseEventHandler(this.statsGPUdata_MouseClick);
            // 
            // GPUDeatailspanel
            // 
            this.GPUDeatailspanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GPUDeatailspanel.Controls.Add(this.tableLayoutPanel9);
            this.GPUDeatailspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPUDeatailspanel.Location = new System.Drawing.Point(57, 168);
            this.GPUDeatailspanel.Name = "GPUDeatailspanel";
            this.GPUDeatailspanel.Size = new System.Drawing.Size(729, 581);
            this.GPUDeatailspanel.TabIndex = 2;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tempchart, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.Hashratechart, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.powerchart, 0, 2);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(729, 581);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // tempchart
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.tempchart.ChartAreas.Add(chartArea1);
            this.tempchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.tempchart.Legends.Add(legend1);
            this.tempchart.Location = new System.Drawing.Point(3, 3);
            this.tempchart.Name = "tempchart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Temperatue";
            this.tempchart.Series.Add(series1);
            this.tempchart.Size = new System.Drawing.Size(723, 181);
            this.tempchart.TabIndex = 0;
            this.tempchart.Text = "chart1";
            // 
            // Hashratechart
            // 
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.Hashratechart.ChartAreas.Add(chartArea2);
            this.Hashratechart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.Hashratechart.Legends.Add(legend2);
            this.Hashratechart.Location = new System.Drawing.Point(3, 190);
            this.Hashratechart.Name = "Hashratechart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Hash Rate";
            this.Hashratechart.Series.Add(series2);
            this.Hashratechart.Size = new System.Drawing.Size(723, 181);
            this.Hashratechart.TabIndex = 1;
            this.Hashratechart.Text = "chart1";
            // 
            // powerchart
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.BorderColor = System.Drawing.Color.Blue;
            chartArea3.BorderWidth = 2;
            chartArea3.Name = "ChartArea1";
            this.powerchart.ChartAreas.Add(chartArea3);
            this.powerchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.powerchart.Legends.Add(legend3);
            this.powerchart.Location = new System.Drawing.Point(3, 377);
            this.powerchart.Name = "powerchart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Power";
            this.powerchart.Series.Add(series3);
            this.powerchart.Size = new System.Drawing.Size(723, 181);
            this.powerchart.TabIndex = 2;
            this.powerchart.Text = "chart1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::SKY.Properties.Resources.graph_512;
            this.pictureBox2.Location = new System.Drawing.Point(746, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // stats_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statspanel);
            this.Name = "stats_control";
            this.Size = new System.Drawing.Size(910, 773);
            this.statspanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statsGPUdata)).EndInit();
            this.GPUDeatailspanel.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tempchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hashratechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statspanel;
        private System.Windows.Forms.Panel panel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private MetroFramework.Controls.MetroGrid statsGPUdata;
        private System.Windows.Forms.Panel GPUDeatailspanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DataVisualization.Charting.Chart tempchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Hashratechart;
        private System.Windows.Forms.DataVisualization.Charting.Chart powerchart;
    }
}
