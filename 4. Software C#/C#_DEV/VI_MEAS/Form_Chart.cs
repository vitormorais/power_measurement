using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OXYPLUS_Emulator
{
    public partial class Form_Chart : Form
    {
        public int x_zoomfactor = 20;

        public Form_Chart()
        {
            InitializeComponent();
        }

        private void cb_Setpoint_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[((CheckBox)sender).Text].Enabled = ((CheckBox)sender).Checked;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_zoomplus_Click(object sender, EventArgs e)
        {
            if (x_zoomfactor > (int)nud_zoom.Minimum)
            {
                x_zoomfactor -= (int)nud_zoom.Increment;
            }
            nud_zoom.Value = x_zoomfactor;
        }

        private void btn_zoomless_Click(object sender, EventArgs e)
        {
            if (x_zoomfactor < (int)nud_zoom.Maximum)
            {
                x_zoomfactor += (int)nud_zoom.Increment;
            }
            nud_zoom.Value = x_zoomfactor;
        }

        private void nud_zoom_ValueChanged_1(object sender, EventArgs e)
        {
            x_zoomfactor = (int)nud_zoom.Value;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
