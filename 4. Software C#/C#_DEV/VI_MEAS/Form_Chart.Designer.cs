namespace OXYPLUS_Emulator
{
    partial class Form_Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nud_zoom = new System.Windows.Forms.NumericUpDown();
            this.btn_zoomplus = new System.Windows.Forms.Button();
            this.btn_zoomless = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.ch_Fuzzy3 = new System.Windows.Forms.CheckBox();
            this.ch_LOG_DeltaSetPoint = new System.Windows.Forms.CheckBox();
            this.ch_LOG_SetPoint = new System.Windows.Forms.CheckBox();
            this.ch_LOG_Tair = new System.Windows.Forms.CheckBox();
            this.ch_LOG_Tbot = new System.Windows.Forms.CheckBox();
            this.LOG_Ttop = new System.Windows.Forms.CheckBox();
            this.ch_Fuzzy8 = new System.Windows.Forms.CheckBox();
            this.ch_Fuzzy7 = new System.Windows.Forms.CheckBox();
            this.ch_Fuzzy6 = new System.Windows.Forms.CheckBox();
            this.ch_Fuzzy5 = new System.Windows.Forms.CheckBox();
            this.ch_Fuzzy4 = new System.Windows.Forms.CheckBox();
            this.ch_Fuzzy2 = new System.Windows.Forms.CheckBox();
            this.ch_Fuzzy1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ch_Fuzzy9 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_zoom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.nud_zoom);
            this.panel1.Controls.Add(this.btn_zoomplus);
            this.panel1.Controls.Add(this.btn_zoomless);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.ch_Fuzzy3);
            this.panel1.Controls.Add(this.ch_LOG_DeltaSetPoint);
            this.panel1.Controls.Add(this.ch_LOG_SetPoint);
            this.panel1.Controls.Add(this.ch_LOG_Tair);
            this.panel1.Controls.Add(this.ch_LOG_Tbot);
            this.panel1.Controls.Add(this.LOG_Ttop);
            this.panel1.Controls.Add(this.ch_Fuzzy9);
            this.panel1.Controls.Add(this.ch_Fuzzy8);
            this.panel1.Controls.Add(this.ch_Fuzzy7);
            this.panel1.Controls.Add(this.ch_Fuzzy6);
            this.panel1.Controls.Add(this.ch_Fuzzy5);
            this.panel1.Controls.Add(this.ch_Fuzzy4);
            this.panel1.Controls.Add(this.ch_Fuzzy2);
            this.panel1.Controls.Add(this.ch_Fuzzy1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(727, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 664);
            this.panel1.TabIndex = 0;
            // 
            // nud_zoom
            // 
            this.nud_zoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_zoom.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_zoom.Location = new System.Drawing.Point(10, 357);
            this.nud_zoom.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_zoom.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_zoom.Name = "nud_zoom";
            this.nud_zoom.Size = new System.Drawing.Size(120, 29);
            this.nud_zoom.TabIndex = 17;
            this.nud_zoom.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_zoom.ValueChanged += new System.EventHandler(this.nud_zoom_ValueChanged_1);
            // 
            // btn_zoomplus
            // 
            this.btn_zoomplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zoomplus.ForeColor = System.Drawing.Color.Black;
            this.btn_zoomplus.Location = new System.Drawing.Point(5, 392);
            this.btn_zoomplus.Name = "btn_zoomplus";
            this.btn_zoomplus.Size = new System.Drawing.Size(132, 60);
            this.btn_zoomplus.TabIndex = 16;
            this.btn_zoomplus.Text = "Zoom +";
            this.btn_zoomplus.UseVisualStyleBackColor = true;
            this.btn_zoomplus.Click += new System.EventHandler(this.btn_zoomplus_Click);
            // 
            // btn_zoomless
            // 
            this.btn_zoomless.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zoomless.ForeColor = System.Drawing.Color.Black;
            this.btn_zoomless.Location = new System.Drawing.Point(5, 458);
            this.btn_zoomless.Name = "btn_zoomless";
            this.btn_zoomless.Size = new System.Drawing.Size(132, 60);
            this.btn_zoomless.TabIndex = 16;
            this.btn_zoomless.Text = "Zoom -";
            this.btn_zoomless.UseVisualStyleBackColor = true;
            this.btn_zoomless.Click += new System.EventHandler(this.btn_zoomless_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(5, 597);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(132, 60);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ch_Fuzzy3
            // 
            this.ch_Fuzzy3.AutoSize = true;
            this.ch_Fuzzy3.Checked = true;
            this.ch_Fuzzy3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Fuzzy3.Location = new System.Drawing.Point(5, 57);
            this.ch_Fuzzy3.Name = "ch_Fuzzy3";
            this.ch_Fuzzy3.Size = new System.Drawing.Size(77, 17);
            this.ch_Fuzzy3.TabIndex = 0;
            this.ch_Fuzzy3.Text = "ch_Fuzzy3";
            this.ch_Fuzzy3.UseVisualStyleBackColor = true;
            this.ch_Fuzzy3.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_LOG_DeltaSetPoint
            // 
            this.ch_LOG_DeltaSetPoint.AutoSize = true;
            this.ch_LOG_DeltaSetPoint.Checked = true;
            this.ch_LOG_DeltaSetPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_LOG_DeltaSetPoint.Location = new System.Drawing.Point(5, 309);
            this.ch_LOG_DeltaSetPoint.Name = "ch_LOG_DeltaSetPoint";
            this.ch_LOG_DeltaSetPoint.Size = new System.Drawing.Size(137, 17);
            this.ch_LOG_DeltaSetPoint.TabIndex = 0;
            this.ch_LOG_DeltaSetPoint.Text = "ch_LOG_DeltaSetPoint";
            this.ch_LOG_DeltaSetPoint.UseVisualStyleBackColor = true;
            this.ch_LOG_DeltaSetPoint.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_LOG_SetPoint
            // 
            this.ch_LOG_SetPoint.AutoSize = true;
            this.ch_LOG_SetPoint.Checked = true;
            this.ch_LOG_SetPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_LOG_SetPoint.Location = new System.Drawing.Point(5, 286);
            this.ch_LOG_SetPoint.Name = "ch_LOG_SetPoint";
            this.ch_LOG_SetPoint.Size = new System.Drawing.Size(112, 17);
            this.ch_LOG_SetPoint.TabIndex = 0;
            this.ch_LOG_SetPoint.Text = "ch_LOG_SetPoint";
            this.ch_LOG_SetPoint.UseVisualStyleBackColor = true;
            this.ch_LOG_SetPoint.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_LOG_Tair
            // 
            this.ch_LOG_Tair.AutoSize = true;
            this.ch_LOG_Tair.Checked = true;
            this.ch_LOG_Tair.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_LOG_Tair.Location = new System.Drawing.Point(5, 263);
            this.ch_LOG_Tair.Name = "ch_LOG_Tair";
            this.ch_LOG_Tair.Size = new System.Drawing.Size(90, 17);
            this.ch_LOG_Tair.TabIndex = 0;
            this.ch_LOG_Tair.Text = "ch_LOG_Tair";
            this.ch_LOG_Tair.UseVisualStyleBackColor = true;
            this.ch_LOG_Tair.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_LOG_Tbot
            // 
            this.ch_LOG_Tbot.AutoSize = true;
            this.ch_LOG_Tbot.Checked = true;
            this.ch_LOG_Tbot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_LOG_Tbot.Location = new System.Drawing.Point(5, 240);
            this.ch_LOG_Tbot.Name = "ch_LOG_Tbot";
            this.ch_LOG_Tbot.Size = new System.Drawing.Size(94, 17);
            this.ch_LOG_Tbot.TabIndex = 0;
            this.ch_LOG_Tbot.Text = "ch_LOG_Tbot";
            this.ch_LOG_Tbot.UseVisualStyleBackColor = true;
            this.ch_LOG_Tbot.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // LOG_Ttop
            // 
            this.LOG_Ttop.AutoSize = true;
            this.LOG_Ttop.Checked = true;
            this.LOG_Ttop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LOG_Ttop.Location = new System.Drawing.Point(4, 217);
            this.LOG_Ttop.Name = "LOG_Ttop";
            this.LOG_Ttop.Size = new System.Drawing.Size(94, 17);
            this.LOG_Ttop.TabIndex = 0;
            this.LOG_Ttop.Text = "ch_LOG_Ttop";
            this.LOG_Ttop.UseVisualStyleBackColor = true;
            this.LOG_Ttop.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_Fuzzy8
            // 
            this.ch_Fuzzy8.AutoSize = true;
            this.ch_Fuzzy8.Checked = true;
            this.ch_Fuzzy8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Fuzzy8.Location = new System.Drawing.Point(4, 172);
            this.ch_Fuzzy8.Name = "ch_Fuzzy8";
            this.ch_Fuzzy8.Size = new System.Drawing.Size(77, 17);
            this.ch_Fuzzy8.TabIndex = 0;
            this.ch_Fuzzy8.Text = "ch_Fuzzy8";
            this.ch_Fuzzy8.UseVisualStyleBackColor = true;
            this.ch_Fuzzy8.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_Fuzzy7
            // 
            this.ch_Fuzzy7.AutoSize = true;
            this.ch_Fuzzy7.Checked = true;
            this.ch_Fuzzy7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Fuzzy7.Location = new System.Drawing.Point(3, 149);
            this.ch_Fuzzy7.Name = "ch_Fuzzy7";
            this.ch_Fuzzy7.Size = new System.Drawing.Size(77, 17);
            this.ch_Fuzzy7.TabIndex = 0;
            this.ch_Fuzzy7.Text = "ch_Fuzzy7";
            this.ch_Fuzzy7.UseVisualStyleBackColor = true;
            this.ch_Fuzzy7.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_Fuzzy6
            // 
            this.ch_Fuzzy6.AutoSize = true;
            this.ch_Fuzzy6.Checked = true;
            this.ch_Fuzzy6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Fuzzy6.Location = new System.Drawing.Point(3, 126);
            this.ch_Fuzzy6.Name = "ch_Fuzzy6";
            this.ch_Fuzzy6.Size = new System.Drawing.Size(77, 17);
            this.ch_Fuzzy6.TabIndex = 0;
            this.ch_Fuzzy6.Text = "ch_Fuzzy6";
            this.ch_Fuzzy6.UseVisualStyleBackColor = true;
            this.ch_Fuzzy6.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_Fuzzy5
            // 
            this.ch_Fuzzy5.AutoSize = true;
            this.ch_Fuzzy5.Checked = true;
            this.ch_Fuzzy5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Fuzzy5.Location = new System.Drawing.Point(5, 103);
            this.ch_Fuzzy5.Name = "ch_Fuzzy5";
            this.ch_Fuzzy5.Size = new System.Drawing.Size(77, 17);
            this.ch_Fuzzy5.TabIndex = 0;
            this.ch_Fuzzy5.Text = "ch_Fuzzy5";
            this.ch_Fuzzy5.UseVisualStyleBackColor = true;
            this.ch_Fuzzy5.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_Fuzzy4
            // 
            this.ch_Fuzzy4.AutoSize = true;
            this.ch_Fuzzy4.Checked = true;
            this.ch_Fuzzy4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Fuzzy4.Location = new System.Drawing.Point(5, 80);
            this.ch_Fuzzy4.Name = "ch_Fuzzy4";
            this.ch_Fuzzy4.Size = new System.Drawing.Size(77, 17);
            this.ch_Fuzzy4.TabIndex = 0;
            this.ch_Fuzzy4.Text = "ch_Fuzzy4";
            this.ch_Fuzzy4.UseVisualStyleBackColor = true;
            this.ch_Fuzzy4.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_Fuzzy2
            // 
            this.ch_Fuzzy2.AutoSize = true;
            this.ch_Fuzzy2.Checked = true;
            this.ch_Fuzzy2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Fuzzy2.Location = new System.Drawing.Point(5, 34);
            this.ch_Fuzzy2.Name = "ch_Fuzzy2";
            this.ch_Fuzzy2.Size = new System.Drawing.Size(77, 17);
            this.ch_Fuzzy2.TabIndex = 0;
            this.ch_Fuzzy2.Text = "ch_Fuzzy2";
            this.ch_Fuzzy2.UseVisualStyleBackColor = true;
            this.ch_Fuzzy2.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // ch_Fuzzy1
            // 
            this.ch_Fuzzy1.AutoSize = true;
            this.ch_Fuzzy1.Checked = true;
            this.ch_Fuzzy1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Fuzzy1.Location = new System.Drawing.Point(5, 11);
            this.ch_Fuzzy1.Name = "ch_Fuzzy1";
            this.ch_Fuzzy1.Size = new System.Drawing.Size(77, 17);
            this.ch_Fuzzy1.TabIndex = 0;
            this.ch_Fuzzy1.Text = "ch_Fuzzy1";
            this.ch_Fuzzy1.UseVisualStyleBackColor = true;
            this.ch_Fuzzy1.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 664);
            this.panel2.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisY.Title = "ºC / W / l/min";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea2.AxisY2.Title = "mA / % Power";
            chartArea2.AxisY2.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.Black;
            series15.Legend = "Legend1";
            series15.Name = "ch_Fuzzy1";
            series15.YValuesPerPoint = 4;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Color = System.Drawing.Color.Blue;
            series16.Legend = "Legend1";
            series16.Name = "ch_Fuzzy2";
            series16.YValuesPerPoint = 4;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Color = System.Drawing.Color.Red;
            series17.Legend = "Legend1";
            series17.Name = "ch_Fuzzy3";
            series17.YValuesPerPoint = 4;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.Green;
            series18.Legend = "Legend1";
            series18.Name = "ch_Fuzzy4";
            series18.YValuesPerPoint = 4;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series19.Legend = "Legend1";
            series19.Name = "ch_Fuzzy5";
            series19.YValuesPerPoint = 4;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Color = System.Drawing.Color.Gray;
            series20.Legend = "Legend1";
            series20.Name = "ch_Fuzzy6";
            series20.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series20.YValuesPerPoint = 4;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "ch_Fuzzy7";
            series21.YValuesPerPoint = 4;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.Name = "ch_Fuzzy8";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "ch_Fuzzy9";
            series23.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "ch_LOG_Ttop";
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series25.Legend = "Legend1";
            series25.Name = "ch_LOG_Tbot";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series26.Legend = "Legend1";
            series26.Name = "ch_LOG_Tair";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Legend = "Legend1";
            series27.Name = "ch_LOG_SetPoint";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Legend = "Legend1";
            series28.Name = "ch_LOG_DeltaSetPoint";
            series28.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Series.Add(series25);
            this.chart1.Series.Add(series26);
            this.chart1.Series.Add(series27);
            this.chart1.Series.Add(series28);
            this.chart1.Size = new System.Drawing.Size(727, 664);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // ch_Fuzzy9
            // 
            this.ch_Fuzzy9.AutoSize = true;
            this.ch_Fuzzy9.Checked = true;
            this.ch_Fuzzy9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_Fuzzy9.Location = new System.Drawing.Point(3, 194);
            this.ch_Fuzzy9.Name = "ch_Fuzzy9";
            this.ch_Fuzzy9.Size = new System.Drawing.Size(77, 17);
            this.ch_Fuzzy9.TabIndex = 0;
            this.ch_Fuzzy9.Text = "ch_Fuzzy9";
            this.ch_Fuzzy9.UseVisualStyleBackColor = true;
            this.ch_Fuzzy9.CheckedChanged += new System.EventHandler(this.cb_Setpoint_CheckedChanged);
            // 
            // Form_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Chart";
            this.Text = "Chart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_zoom)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox ch_Fuzzy1;
        private System.Windows.Forms.CheckBox ch_Fuzzy3;
        private System.Windows.Forms.CheckBox ch_Fuzzy4;
        private System.Windows.Forms.CheckBox ch_Fuzzy2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.CheckBox ch_LOG_DeltaSetPoint;
        private System.Windows.Forms.CheckBox ch_LOG_SetPoint;
        private System.Windows.Forms.CheckBox ch_LOG_Tair;
        private System.Windows.Forms.CheckBox ch_LOG_Tbot;
        private System.Windows.Forms.CheckBox LOG_Ttop;
        private System.Windows.Forms.CheckBox ch_Fuzzy8;
        private System.Windows.Forms.CheckBox ch_Fuzzy7;
        private System.Windows.Forms.CheckBox ch_Fuzzy6;
        private System.Windows.Forms.CheckBox ch_Fuzzy5;
        private System.Windows.Forms.Button btn_zoomplus;
        private System.Windows.Forms.Button btn_zoomless;
        private System.Windows.Forms.NumericUpDown nud_zoom;
        private System.Windows.Forms.CheckBox ch_Fuzzy9;
    }
}