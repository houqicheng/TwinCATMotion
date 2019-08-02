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
using System.Threading;

namespace HMI
{
    public partial class Form1 : Form
    {
        TcAdsClient client;
        int hPowerOn;
        int hPowerMonitor;
        int hStop;
        bool bPowerOn;

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
                hPowerOn =  client.CreateVariableHandle("GVL_General.hmiPowerOn");
                hPowerMonitor = client.CreateVariableHandle("GVL_General.bPowrOn");
                hStop = client.CreateVariableHandle("GVL_General.hmiStop");

                client.AddDeviceNotificationEx("GVL_General.bPowrOn", AdsTransMode.OnChange, 100, 0, BtnPowerStatus, typeof(Boolean));

                client.AdsNotificationEx += Client_AdsNotificationEx;
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Form1_Load " + err.Message);                
            }
        }

        private void Client_AdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            if (e.Value.GetType() == typeof(Boolean))
            {
                bPowerOn = (Boolean)e.Value;
            }
            AxisPowerIndicatior();
        } 
        private void AxisPowerIndicatior()
        {
            if (bPowerOn)
            {
                BtnPowerStatus.BackColor = Color.Green;
                BtnPowerStatus.Text = "PowerOn";
            }
            else
            {
                BtnPowerStatus.BackColor = Color.Gray;
                BtnPowerStatus.Text = "PowerOff";

            }
        }
        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hStop, false);

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

        private void BtnStop_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hStop, true);
                //Thread.Sleep(1000);
                //client.WriteAny(hStop, false);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnStop_Click " + err.Message);
            }

        }
    }
}
