using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace HMI
{
    public partial class Form1 : Form
    {
        TcAdsClient client;
        int hPowerOn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPowerOn.Enabled = true;
            btnPowerOff.Enabled = false;
            client = new TcAdsClient();
            client.Connect(851);
            try
            {
              hPowerOn =  client.CreateVariableHandle("GVL_General.bPowerOn");
            }
            catch (Exception err)
            {
                MessageBox.Show("Form1_Load " + err.Message);                
            }

        }

        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hPowerOn, true);
                btnPowerOn.Enabled = false;
                btnPowerOff.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("btnPowerOn_Click " + err.Message);
                //throw;
            }           

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Dispose();
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hPowerOn, false);
                btnPowerOn.Enabled = true;
                btnPowerOff.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("btnPowerOn_Click " + err.Message);
                //throw;
            }
        }
    }
}
