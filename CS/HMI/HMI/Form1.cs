﻿using System;
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
        int hMoveVelo;
        bool bPowerOn;
        int hMoveRelative;
        int hSetPosition;
        int hManualJog;
        int hJogFor;
        int hJogBack;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            btnPowerOn.Enabled = true;
            btnPowerOff.Enabled = false;
            client = new TcAdsClient();
            client.Connect(851);
            try
            {
                hPowerOn =  client.CreateVariableHandle("GVL_General.hmiPowerOn");
                hPowerMonitor = client.CreateVariableHandle("GVL_General.bPowrOn");
                hStop = client.CreateVariableHandle("GVL_General.hmiStop");
                hMoveVelo = client.CreateVariableHandle("GVL_General.hmiMoveVelo");
                hSetPosition = client.CreateVariableHandle("GVL_General.hmiSetPosition");
                hMoveRelative = client.CreateVariableHandle("GVL_General.hmiMoveRelative");
                hManualJog = client.CreateVariableHandle("GVL_General.hmiManualJog");
                hJogBack = client.CreateVariableHandle("GVL_General.hmiJogBack");
                hJogFor = client.CreateVariableHandle("GVL_General.hmiJogFor");

                client.AddDeviceNotificationEx("GVL_General.bPowrOn", AdsTransMode.OnChange, 100, 0, BtnPowerStatus, typeof(Boolean));
                client.AddDeviceNotificationEx("GVL_General.hmiLActPos", AdsTransMode.OnChange, 100, 0, txtActPos, typeof(double));
                client.AdsNotificationEx += Client_AdsNotificationEx;
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Form1_Load " + err.Message);                
            }
            BtnJogBack.Enabled = false;
            BtnJogFor.Enabled = false;
            BtnStop.Enabled = false;
            BtnMoveRelative.Enabled = false;
            BtnSetPosition.Enabled = false;
            BtnMoveVelo.Enabled = false;
            BtnManual.Enabled = false;

        }

        private void Client_AdsNotificationEx(object sender, AdsNotificationExEventArgs e)
        {
            if (e.Value.GetType() == typeof(Boolean))
            {
                bPowerOn = (Boolean)e.Value;
            }
            else if (e.Value.GetType() == typeof(double))
            {
                ((TextBox)e.UserData).Text = e.Value.ToString();
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
                BtnStop.Enabled = true;
                BtnMoveRelative.Enabled = true;
                BtnSetPosition.Enabled = true;
                BtnMoveVelo.Enabled = true;
                BtnManual.Enabled = true;
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
                client.WriteAny(hManualJog, false);

                btnPowerOn.Enabled = true;
                btnPowerOff.Enabled = false;
                BtnManual.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hMoveVelo, true);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnMoveVelo " + err.Message);
            }
        }

        private void BtnSetPosition_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hSetPosition, true);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnSetPosition " + err.Message);
            }
        }

        private void BtnJogFor_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                client.WriteAny(hJogFor, true);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnJogFor " + err.Message);
            }

        }

        private void BtnJogBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnMoveRelative_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hMoveRelative, true);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnMoveRelative " + err.Message);
            }
        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hManualJog, true);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnBtnManual " + err.Message);
            }
            BtnJogBack.Enabled = true;
            BtnJogFor.Enabled = true;
        }

        private void BtnJogBack_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                client.WriteAny(hJogBack, true);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnJogBack " + err.Message);
            }
        }

        private void BtnJogBack_MouseLeave(object sender, EventArgs e)
        {
            //try
            //{
            //    client.WriteAny(hJogBack, false);
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("BtnJogBack " + err.Message);
            //}
        }

        private void BtnJogFor_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                client.WriteAny(hJogFor, false);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnJogFor " + err.Message);
            }
        }

        private void BtnJogFor_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                client.WriteAny(hJogFor, false);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnJogFor_MouseUp " + err.Message);
            }
        }

        private void BtnJogBack_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                client.WriteAny(hJogBack, false);
            }
            catch (Exception err)
            {
                MessageBox.Show("BtnJogBack " + err.Message);
            }
        }
    }
}
