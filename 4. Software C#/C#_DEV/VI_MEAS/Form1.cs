using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Collections.Generic;

namespace OXYPLUS_Emulator
{
    public partial class Form1 : Form
    {


        public class map_variable
        {
            public string name;
            public string addr;
        }

        public class write_variable
        {
            public string name;
            public string addr;
        }


        //---------------------------------------------------------------------
        // Private Variables
        //---------------------------------------------------------------------
        byte[] RxBuffer = new byte[300];

        Queue<UInt16> VAR1 = new Queue<UInt16>();
        Queue<UInt16> VAR2 = new Queue<UInt16>();
        Queue<UInt16> VAR3 = new Queue<UInt16>();
        Queue<UInt16> VAR4 = new Queue<UInt16>();
        Queue<UInt16> VAR5 = new Queue<UInt16>();
        Queue<UInt16> VAR6 = new Queue<UInt16>();



        Form_Chart chart_form = new Form_Chart();
        private bool RecordEnabled = false;
        private double timestampoffset = 0;
        private byte ParameterInit = 0;


        public Form1()
        {
            InitializeComponent();
            debug.AppendText("STARTED! \n\n");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            for (byte n = 0; n < ports.Length; n++)
                cb_COM_names.Items.Add((object)ports[n]);

            cb_COM_names.Text = ports[ports.Length - 1];

            btn_COM_open.Enabled = true;
            btn_COM_close.Enabled = false;

            CheckForIllegalCrossThreadCalls = false;
        }


        //---------------------------------------------------------------------
        //   This function Opens a COM port
        //---------------------------------------------------------------------
        private void btn_COM_open_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen == false)
            {
                comPort.PortName = cb_COM_names.Text;
                try
                {
                    comPort.Open();
                    btn_COM_open.Enabled = false;
                    btn_COM_close.Enabled = true;
                    status.Text = "Port openned.";


                    tmrSerial.Enabled = true;
                }
                catch
                {
                    status.Text = "Couldn't open the port";
                }
            }
        }

        //---------------------------------------------------------------------
        //   This function Closes the selected COM port
        //---------------------------------------------------------------------
        private void btn_COM_close_Click(object sender, EventArgs e)
        {
            tmrSerial.Enabled = false;

            if (comPort.IsOpen)
            {
                try
                {
                    comPort.Close();
                    btn_COM_open.Enabled = true;
                    btn_COM_close.Enabled = false;
                    status.Text = "Port closed.";
                }
                catch
                {
                    status.Text = "Couldn't close the port";
                }
                finally
                {

                }
            }
        }
        //---------------------------------------------------------------------
        //   This function gets the COM ports list
        //---------------------------------------------------------------------
        private void btn_COM_refresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cb_COM_names.Items.Clear();
            for (byte n = 0; n < ports.Length; n++)
                cb_COM_names.Items.Add((object)ports[n]);

            status.Text = "Found " + ports.Length.ToString() + " available ports";
        }
        //---------------------------------------------------------------------
        //   This function updates the COM port name
        //---------------------------------------------------------------------
        private void cb_COM_names_TextChanged(object sender, EventArgs e)
        {
            if (cb_COM_names.Text != "")
            {
                comPort.PortName = cb_COM_names.Text;
                btn_COM_open.Enabled = true;
                btn_COM_close.Enabled = false;
            }
        }

        //---------------------------------------------------------------------
        //   This function handles incoming bytes from Serial Port
        //---------------------------------------------------------------------
        private void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read bytes
            DateTime dt2 = DateTime.Now;
            int ntr = comPort.BytesToRead, count = 0;

            while (ntr > 0)
            {
                // Read and buffer data received

                try
                {

                    byte[] array = new byte[30];

                    comPort.Read(array, 0, 14);
                    if (array[0] == ((byte)0x87))
                    {
                        //for (int it = 0; it < 6; it++) {
                        // VAR1.Enqueue((UInt16)(array[0] | array[1] << 7));
                        //VAR1.Enqueue((UInt16)((array[2] ) | ((array[1]) << 7)));
                        VAR1.Enqueue((UInt16)(array[1] << 7 | (array[2])));
                        VAR2.Enqueue((UInt16)(array[3] << 7 | (array[4])));
                        VAR3.Enqueue((UInt16)(array[5] << 7 | (array[6])));
                        VAR4.Enqueue((UInt16)(array[7] << 7 | (array[8])));
                        VAR5.Enqueue((UInt16)(array[9] << 7 | (array[10])));
                        VAR6.Enqueue((UInt16)(array[11] << 7 | (array[12])));              
                    }
                    else
                    {
                        comPort.DiscardInBuffer();
                    }

                    ntr = comPort.BytesToRead;

                   // debug.AppendText(System.Text.Encoding.ASCII.GetString(array) + "\n");
                    for (int it = 0; it < 14; it++)
                    {
                        debug.AppendText(((int)array[it]).ToString() + ";");
                    }
                    debug.AppendText("\n");

                    
                }
                catch
                {

                }
                finally
                {

                }
            }


        }


        private void button8_Click(object sender, EventArgs e)
        {
            debug.Clear();
        }


        private void WriteLineToFile(string path, string data, byte bid)
        {
            StreamWriter StreamW;

            if (!File.Exists(path))
            {
                using (StreamW = File.AppendText(path))
                {
                    StreamW.WriteLine("Record Date: " + DateTime.Now.ToShortDateString());
                    StreamW.WriteLine("----------------------------------------------------");

                    if (bid == 0)
                    {
                        StreamW.WriteLine("Time Stamp; Time; VAR1; VAR2; VAR3; VAR4; VAR5; VAR6");
                    }
                }
            }

            using (StreamW = File.AppendText(path))
            {
                StreamW.WriteLine(data);
            }
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChartShow_Click(object sender, EventArgs e)
        {
            chart_form.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrSerial.Enabled = false;

            if (comPort.IsOpen)
            {
                try
                {
                    comPort.Close();
                }
                catch
                {
                    status.Text = "Couldn't close the port";
                }
                finally
                {

                }
            }
        }

        private void btn_selectfile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            tb_savefilepath.Text = saveFileDialog1.FileNames[0];
        }

        private void btn_startrec_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            UInt16 FileIndex = 0;

            saveFileDialog1.FileName =
                "record" + "_" + dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + "_" + dt.Hour.ToString() + dt.Minute.ToString() + ".csv";

            while (File.Exists(saveFileDialog1.FileName))
            {
                FileIndex++;
                saveFileDialog1.FileName =
                "record" + "_" + dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + "_" + dt.Hour.ToString() + dt.Minute.ToString() + "(" + FileIndex.ToString() + ").csv";
            }

            saveFileDialog1.ShowDialog();
        }

        private void btn_stoprec_Click(object sender, EventArgs e)
        {
            RecordEnabled = false;

            btn_stoprec.Enabled = false;
            btn_startrec.Enabled = true;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tb_savefilepath.Text = saveFileDialog1.FileNames[0];

            timestampoffset = 0;

            RecordEnabled = true;

            btn_stoprec.Enabled = true;
            btn_startrec.Enabled = false;
        }

        private void timer_getdata_Tick(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void debug_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void writevariableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tb_savefilepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string ts = dt.Hour.ToString() + ":" + dt.Minute.ToString() + ":" + dt.Second.ToString() + " -- ";
            if (update_plot.Enabled)
            {
                update_plot.Enabled = false;
                but_status_timer.BackColor = Color.Red;
                //dashboard_debug_log.Clear();
                dashboard_debug_comand.AppendText(ts + "disable graph update\n");
            }
            else
            {
                update_plot.Enabled = true;
                but_status_timer.BackColor = Color.Green;
                //dashboard_debug_log.Clear();
                dashboard_debug_comand.AppendText(ts + "enable graph update\n");
            }

        }

        private void update_plot_Tick(object sender, EventArgs e)
        {
            //            DateTime dt = DateTime.Now;
            //            string ts = dt.Hour.ToString() + ":" + dt.Minute.ToString() + ":" + dt.Second.ToString() + " -- ";
            //            dashboard_debug_log.AppendText(ts + "size of list: " + VAR1.Count.ToString() + "\n");
            debug.Clear();
            float this_VAR1;
            float this_VAR2;
            float this_VAR3;
            float this_VAR4;
            float this_VAR5;
            float this_VAR6;

            graph.Series[0].Points.Clear();
            graph.Series[1].Points.Clear();
            graph.Series[2].Points.Clear();

            graph_v.Series[0].Points.Clear();
            graph_v.Series[1].Points.Clear();
            graph_v.Series[2].Points.Clear();

            while (VAR1.Count > 0)
            {
                //VAR1.Remove(VAR1.Count);
                this_VAR1 = VAR1.Dequeue() - 0x1FFF;
                graph.Series[0].Points.Add(this_VAR1);


                this_VAR3 = VAR3.Dequeue() - 0x1FFF;
                graph.Series[1].Points.Add(this_VAR3);

                this_VAR5 = VAR5.Dequeue() - 0x1FFF;
                graph.Series[2].Points.Add(this_VAR5);



                this_VAR2 = VAR2.Dequeue();
                graph_v.Series[0].Points.Add(this_VAR2);

                this_VAR4 = VAR4.Dequeue();
                graph_v.Series[1].Points.Add(this_VAR4);

                this_VAR6 = VAR6.Dequeue();
                graph_v.Series[2].Points.Add(this_VAR6);

                if (RecordEnabled)
                {
                    string recordline;
                    double timestamp;
                    DateTime dt2 = DateTime.Now;

                    if (timestampoffset == 0)
                    {
                        timestampoffset = dt2.Hour * 3600 + dt2.Minute * 60 + dt2.Second + (double)(dt2.Millisecond) / 1000;
                        timestamp = 0;
                    }
                    else
                    {
                        timestamp = dt2.Hour * 3600 + dt2.Minute * 60 + dt2.Second + (double)(dt2.Millisecond) / 1000;
                        timestamp -= timestampoffset;
                    }
                    recordline = timestamp.ToString("F3") + "; " +
                              dt2.Hour.ToString() + ":" +
                              dt2.Minute.ToString() + ":" +
                              dt2.Second.ToString() + " " +
                              dt2.Millisecond.ToString() + "ms; " +
                              this_VAR1.ToString() + ";" +
                              this_VAR3.ToString() + ";" +
                              this_VAR5.ToString() + ";" +
                              this_VAR2.ToString() + ";" +
                              this_VAR4.ToString() + ";" +
                              this_VAR6.ToString() + ";" +
                              "; ";
                    WriteLineToFile(tb_savefilepath.Text, recordline, 0);

                }
            }

            RecordEnabled = false;

            btn_stoprec.Enabled = false;
            btn_startrec.Enabled = true;

            VAR1.Clear();
            VAR2.Clear();
            VAR3.Clear();
            VAR4.Clear();
            VAR5.Clear();
            VAR6.Clear();

            if (comPort.IsOpen)
            {
                try
                {

                    byte[] buffer = new byte[2]; ;
                    buffer[0] = (byte)0x41;
                    //buffer[1] = (byte)0x40;

                    comPort.DiscardInBuffer();

                    comPort.Write(buffer, 0, 1);

                    status.Text = "sent data" + buffer;
                    dashboard_debug_comand.AppendText("sent data\n");
                }
                catch
                {
                    status.Text = "Couldn't close the port";
                }
                finally
                {

                }
            }
            else
            {
               
            }

            ////  "send data to plot graph"  

           
            //dashboard_debug_log.AppendText(ts + "timerRead\n");
        }


        private void clear_logs_Click(object sender, EventArgs e)
        {
            dashboard_debug_log.Clear();
        }

        private void clear_graph_Click(object sender, EventArgs e)
        {
            graph.Series[0].Points.Clear();
            graph.Series[1].Points.Clear();
            graph.Series[2].Points.Clear();

            graph_v.Series[0].Points.Clear();
            graph_v.Series[1].Points.Clear();
            graph_v.Series[2].Points.Clear();
        }


    }
}
