namespace OXYPLUS_Emulator
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comPort = new System.IO.Ports.SerialPort(this.components);
            this.tmrSerial = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DashBoard = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.clear_graph = new System.Windows.Forms.Button();
            this.clear_logs = new System.Windows.Forms.Button();
            this.graph_v = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard_debug_log = new System.Windows.Forms.RichTextBox();
            this.dashboard_debug_comand = new System.Windows.Forms.RichTextBox();
            this.but_status_timer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tb_savefilepath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_startrec = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.btn_stoprec = new System.Windows.Forms.Button();
            this.ComLog = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.debug = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.PowerFlow = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_COM_open = new System.Windows.Forms.ToolStripButton();
            this.btn_COM_close = new System.Windows.Forms.ToolStripButton();
            this.cb_COM_names = new System.Windows.Forms.ToolStripComboBox();
            this.btn_COM_refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_ChartShow = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer_getdata = new System.Windows.Forms.Timer(this.components);
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.timerTestOn = new System.Windows.Forms.Timer(this.components);
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.writevariableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.update_plot = new System.Windows.Forms.Timer(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.ComLog.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writevariableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comPort
            // 
            this.comPort.BaudRate = 230400;
            this.comPort.PortName = "COM13";
            this.comPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.comPort_DataReceived);
            // 
            // tmrSerial
            // 
            //this.tmrSerial.Tick += new System.EventHandler(this.tmrSerial_Tick);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(992, 824);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(992, 849);
            this.toolStripContainer1.TabIndex = 18;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 802);
            this.panel2.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DashBoard);
            this.tabControl1.Controls.Add(this.ComLog);
            this.tabControl1.Controls.Add(this.PowerFlow);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 802);
            this.tabControl1.TabIndex = 16;
            // 
            // DashBoard
            // 
            this.DashBoard.Controls.Add(this.label4);
            this.DashBoard.Controls.Add(this.clear_graph);
            this.DashBoard.Controls.Add(this.clear_logs);
            this.DashBoard.Controls.Add(this.graph_v);
            this.DashBoard.Controls.Add(this.graph);
            this.DashBoard.Controls.Add(this.label3);
            this.DashBoard.Controls.Add(this.label2);
            this.DashBoard.Controls.Add(this.label1);
            this.DashBoard.Controls.Add(this.dashboard_debug_log);
            this.DashBoard.Controls.Add(this.dashboard_debug_comand);
            this.DashBoard.Controls.Add(this.but_status_timer);
            this.DashBoard.Controls.Add(this.button2);
            this.DashBoard.Controls.Add(this.btn_Exit);
            this.DashBoard.Controls.Add(this.tb_savefilepath);
            this.DashBoard.Controls.Add(this.button1);
            this.DashBoard.Controls.Add(this.button5);
            this.DashBoard.Controls.Add(this.btn_startrec);
            this.DashBoard.Controls.Add(this.label54);
            this.DashBoard.Controls.Add(this.btn_stoprec);
            this.DashBoard.Location = new System.Drawing.Point(4, 22);
            this.DashBoard.Name = "DashBoard";
            this.DashBoard.Padding = new System.Windows.Forms.Padding(3);
            this.DashBoard.Size = new System.Drawing.Size(984, 776);
            this.DashBoard.TabIndex = 3;
            this.DashBoard.Text = "DashBoard";
            this.DashBoard.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "VOLTAGES";
            // 
            // clear_graph
            // 
            this.clear_graph.Location = new System.Drawing.Point(884, 234);
            this.clear_graph.Name = "clear_graph";
            this.clear_graph.Size = new System.Drawing.Size(75, 23);
            this.clear_graph.TabIndex = 36;
            this.clear_graph.Text = "clear graph";
            this.clear_graph.UseVisualStyleBackColor = true;
            this.clear_graph.Click += new System.EventHandler(this.clear_graph_Click);
            // 
            // clear_logs
            // 
            this.clear_logs.Location = new System.Drawing.Point(793, 339);
            this.clear_logs.Name = "clear_logs";
            this.clear_logs.Size = new System.Drawing.Size(75, 23);
            this.clear_logs.TabIndex = 35;
            this.clear_logs.Text = "clear_logs";
            this.clear_logs.UseVisualStyleBackColor = true;
            this.clear_logs.Click += new System.EventHandler(this.clear_logs_Click);
            // 
            // graph_v
            // 
            chartArea1.Name = "ChartArea1";
            this.graph_v.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graph_v.Legends.Add(legend1);
            this.graph_v.Location = new System.Drawing.Point(8, 465);
            this.graph_v.Name = "graph_v";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            this.graph_v.Series.Add(series1);
            this.graph_v.Series.Add(series2);
            this.graph_v.Series.Add(series3);
            this.graph_v.Size = new System.Drawing.Size(672, 305);
            this.graph_v.TabIndex = 34;
            this.graph_v.Text = "chart1";
            // 
            // graph
            // 
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(-4, 143);
            this.graph.Name = "graph";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series3";
            this.graph.Series.Add(series4);
            this.graph.Series.Add(series5);
            this.graph.Series.Add(series6);
            this.graph.Size = new System.Drawing.Size(684, 305);
            this.graph.TabIndex = 34;
            this.graph.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Currents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "LOG HISTORY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "COMMAND HISTORY";
            // 
            // dashboard_debug_log
            // 
            this.dashboard_debug_log.Location = new System.Drawing.Point(686, 365);
            this.dashboard_debug_log.Name = "dashboard_debug_log";
            this.dashboard_debug_log.Size = new System.Drawing.Size(182, 158);
            this.dashboard_debug_log.TabIndex = 32;
            this.dashboard_debug_log.Text = "";
            // 
            // dashboard_debug_comand
            // 
            this.dashboard_debug_comand.Location = new System.Drawing.Point(686, 164);
            this.dashboard_debug_comand.Name = "dashboard_debug_comand";
            this.dashboard_debug_comand.Size = new System.Drawing.Size(182, 158);
            this.dashboard_debug_comand.TabIndex = 31;
            this.dashboard_debug_comand.Text = "";
            // 
            // but_status_timer
            // 
            this.but_status_timer.BackColor = System.Drawing.Color.Red;
            this.but_status_timer.Location = new System.Drawing.Point(884, 270);
            this.but_status_timer.Name = "but_status_timer";
            this.but_status_timer.Size = new System.Drawing.Size(22, 23);
            this.but_status_timer.TabIndex = 30;
            this.but_status_timer.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(884, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "en/dis timer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(858, 30);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(101, 60);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tb_savefilepath
            // 
            this.tb_savefilepath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_savefilepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_savefilepath.Location = new System.Drawing.Point(622, 99);
            this.tb_savefilepath.Multiline = true;
            this.tb_savefilepath.Name = "tb_savefilepath";
            this.tb_savefilepath.ReadOnly = true;
            this.tb_savefilepath.Size = new System.Drawing.Size(337, 26);
            this.tb_savefilepath.TabIndex = 27;
            this.tb_savefilepath.TextChanged += new System.EventHandler(this.tb_savefilepath_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(884, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(740, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 60);
            this.button5.TabIndex = 15;
            this.button5.Text = "Chart";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_ChartShow_Click);
            // 
            // btn_startrec
            // 
            this.btn_startrec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_startrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startrec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_startrec.Location = new System.Drawing.Point(504, 30);
            this.btn_startrec.Name = "btn_startrec";
            this.btn_startrec.Size = new System.Drawing.Size(112, 60);
            this.btn_startrec.TabIndex = 15;
            this.btn_startrec.Text = "Start Recording";
            this.btn_startrec.UseVisualStyleBackColor = true;
            this.btn_startrec.Click += new System.EventHandler(this.btn_startrec_Click);
            // 
            // label54
            // 
            this.label54.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(535, 109);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(81, 16);
            this.label54.TabIndex = 26;
            this.label54.Text = "Record File:";
            this.label54.Click += new System.EventHandler(this.label54_Click);
            // 
            // btn_stoprec
            // 
            this.btn_stoprec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stoprec.Enabled = false;
            this.btn_stoprec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stoprec.ForeColor = System.Drawing.Color.Red;
            this.btn_stoprec.Location = new System.Drawing.Point(622, 30);
            this.btn_stoprec.Name = "btn_stoprec";
            this.btn_stoprec.Size = new System.Drawing.Size(112, 60);
            this.btn_stoprec.TabIndex = 15;
            this.btn_stoprec.Text = "Stop Recording";
            this.btn_stoprec.UseVisualStyleBackColor = true;
            this.btn_stoprec.Click += new System.EventHandler(this.btn_stoprec_Click);
            // 
            // ComLog
            // 
            this.ComLog.Controls.Add(this.panel4);
            this.ComLog.Controls.Add(this.panel3);
            this.ComLog.Location = new System.Drawing.Point(4, 22);
            this.ComLog.Name = "ComLog";
            this.ComLog.Padding = new System.Windows.Forms.Padding(3);
            this.ComLog.Size = new System.Drawing.Size(984, 776);
            this.ComLog.TabIndex = 1;
            this.ComLog.Text = "Communication Log";
            this.ComLog.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.debug);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(978, 740);
            this.panel4.TabIndex = 18;
            // 
            // debug
            // 
            this.debug.BackColor = System.Drawing.Color.Black;
            this.debug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.debug.Location = new System.Drawing.Point(0, 0);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(978, 740);
            this.debug.TabIndex = 0;
            this.debug.Text = "";
            this.debug.TextChanged += new System.EventHandler(this.debug_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 30);
            this.panel3.TabIndex = 17;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(8, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Clear Log";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // PowerFlow
            // 
            this.PowerFlow.Location = new System.Drawing.Point(4, 22);
            this.PowerFlow.Name = "PowerFlow";
            this.PowerFlow.Padding = new System.Windows.Forms.Padding(3);
            this.PowerFlow.Size = new System.Drawing.Size(984, 776);
            this.PowerFlow.TabIndex = 4;
            this.PowerFlow.Text = "PowerFlow";
            this.PowerFlow.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 802);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(992, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 17);
            this.status.Text = "Welcome!";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_COM_open,
            this.btn_COM_close,
            this.cb_COM_names,
            this.btn_COM_refresh,
            this.btn_ChartShow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "ts_Toolbar";
            // 
            // btn_COM_open
            // 
            this.btn_COM_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_COM_open.Enabled = false;
            this.btn_COM_open.Image = ((System.Drawing.Image)(resources.GetObject("btn_COM_open.Image")));
            this.btn_COM_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_COM_open.Name = "btn_COM_open";
            this.btn_COM_open.Size = new System.Drawing.Size(105, 22);
            this.btn_COM_open.Text = "Open Connection";
            this.btn_COM_open.ToolTipText = "Open Port";
            this.btn_COM_open.Click += new System.EventHandler(this.btn_COM_open_Click);
            // 
            // btn_COM_close
            // 
            this.btn_COM_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_COM_close.Enabled = false;
            this.btn_COM_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_COM_close.Image")));
            this.btn_COM_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_COM_close.Name = "btn_COM_close";
            this.btn_COM_close.Size = new System.Drawing.Size(105, 22);
            this.btn_COM_close.Text = "Close Connection";
            this.btn_COM_close.ToolTipText = "Close Port";
            this.btn_COM_close.Click += new System.EventHandler(this.btn_COM_close_Click);
            // 
            // cb_COM_names
            // 
            this.cb_COM_names.Name = "cb_COM_names";
            this.cb_COM_names.Size = new System.Drawing.Size(121, 25);
            this.cb_COM_names.TextChanged += new System.EventHandler(this.cb_COM_names_TextChanged);
            // 
            // btn_COM_refresh
            // 
            this.btn_COM_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_COM_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_COM_refresh.Image")));
            this.btn_COM_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_COM_refresh.Name = "btn_COM_refresh";
            this.btn_COM_refresh.Size = new System.Drawing.Size(100, 22);
            this.btn_COM_refresh.Text = "Refresh Com List";
            this.btn_COM_refresh.ToolTipText = "Get Available Ports";
            this.btn_COM_refresh.Click += new System.EventHandler(this.btn_COM_refresh_Click);
            // 
            // btn_ChartShow
            // 
            this.btn_ChartShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_ChartShow.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChartShow.Image")));
            this.btn_ChartShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ChartShow.Name = "btn_ChartShow";
            this.btn_ChartShow.Size = new System.Drawing.Size(72, 22);
            this.btn_ChartShow.Text = "Show Chart";
            this.btn_ChartShow.Click += new System.EventHandler(this.btn_ChartShow_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "record.csv";
            this.saveFileDialog1.InitialDirectory = ".\\";
            this.saveFileDialog1.Title = "Select file";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // timer_getdata
            // 
            this.timer_getdata.Interval = 1;
            this.timer_getdata.Tick += new System.EventHandler(this.timer_getdata_Tick);
            // 
            // timerRead
            // 
            this.timerRead.Interval = 1000;
            //this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // open_file
            // 
            this.open_file.FileName = "FP_USA_Main";
            // 
            // writevariableBindingSource
            // 
            this.writevariableBindingSource.DataSource = typeof(OXYPLUS_Emulator.Form1.write_variable);
            this.writevariableBindingSource.CurrentChanged += new System.EventHandler(this.writevariableBindingSource_CurrentChanged);
            // 
            // update_plot
            // 
            this.update_plot.Interval = 1000;
            this.update_plot.Tick += new System.EventHandler(this.update_plot_Tick);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(OXYPLUS_Emulator.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 849);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = ".: VI_MEAS :. ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.DashBoard.ResumeLayout(false);
            this.DashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ComLog.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.writevariableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort comPort;
        private System.Windows.Forms.Timer tmrSerial;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_COM_open;
        private System.Windows.Forms.ToolStripButton btn_COM_close;
        private System.Windows.Forms.ToolStripComboBox cb_COM_names;
        private System.Windows.Forms.ToolStripButton btn_COM_refresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton btn_ChartShow;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer_getdata;
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.Timer timerTestOn;
        private System.Windows.Forms.OpenFileDialog open_file;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource writevariableBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ComLog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox debug;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage DashBoard;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox tb_savefilepath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_startrec;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button btn_stoprec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button but_status_timer;
        private System.Windows.Forms.RichTextBox dashboard_debug_comand;
        private System.Windows.Forms.RichTextBox dashboard_debug_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Timer update_plot;
        private System.Windows.Forms.Button clear_logs;
        private System.Windows.Forms.Button clear_graph;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph_v;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage PowerFlow;
    }
}

