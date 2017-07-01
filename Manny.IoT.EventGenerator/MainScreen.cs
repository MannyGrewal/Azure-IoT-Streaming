//*********************************************************
//
//    Author : Manny Grewal - 2017
//    This code is provided under Open Source License
//    It has not been tested and is not suited for *Production* use  
//    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
//    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
//    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
//    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using Manny.IoT.DeviceSimulator;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manny.IoT.EventGenerator
{
    public partial class MainScreen : MetroFramework.Forms.MetroForm
    {
        private int totalTicks = 0, countLastObserved=0, countNowObserved=0;
        private SelectedConfig selectedConfig;
        public MainScreen()
        {
            InitializeComponent();           
            selectedConfig = SelectedConfig.Instance;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            BindConfigureTabControls();
        }

        private void BindConfigureTabControls()
        {
            var dataSource = ConfigFactory.Instance.AllConfig.Where(c => c.Type == ConfigurationType.EventDelay).ToList();
            cbDelay.DisplayMember = "Name";
            cbDelay.ValueMember = "Value";
            cbDelay.DataSource = dataSource;
            //Default to 5 seconds
            cbDelay.SelectedItem = dataSource.FirstOrDefault(c => c.Value == "5000");

            dataSource = ConfigFactory.Instance.AllConfig.Where(c => c.Type == ConfigurationType.NumberOfSensors).ToList();
            cbNumSensors.DisplayMember = "Name";
            cbNumSensors.ValueMember = "Value";
            cbNumSensors.DataSource = dataSource;
            //Default to 4
            cbNumSensors.SelectedItem = dataSource.FirstOrDefault(c => c.Value == "4");

            dataSource = ConfigFactory.Instance.AllConfig.Where(c => c.Type == ConfigurationType.SensorType).ToList();
            cbSensorType.DisplayMember = "Name";
            cbSensorType.ValueMember = "Value";
            cbSensorType.DataSource = dataSource;
            //Default to 4
            cbSensorType.SelectedItem = dataSource.FirstOrDefault(c => c.Value == "Environment");

        }

        #region SelectedIndexChanged / OnChange events
        private void cbDelay_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedConfig.DelayInEvents = (Configuration) cbDelay.SelectedItem;
        }

        private void cbNumSensors_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedConfig.NumSensors = (Configuration)cbNumSensors.SelectedItem;
        }

        private void cbSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedConfig.SensorType = (Configuration)cbSensorType.SelectedItem;
        }


        private void lstMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMessages.SelectedItems.Count > 0)
            {
                txtMsgDetails.ResetText();
                txtMsgDetails.AppendText((string)lstMessages.SelectedItems[0].Tag);
            }
        }

        private void chkRandomise_CheckedChanged(object sender, EventArgs e)
        {
            selectedConfig.RandomiseMessageEmissionTime = chkRandomise.Checked;
        }


        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMain.SelectedTab == tbpMessageDetails)
            {
                lstMessages.Items.Clear();
                var messagesList = RollingWindow.Instance.Messages;
                //var list = new BindingList<TelemetryMessage>(messagesList.Cast<TelemetryMessage>().ToList());
                var list = messagesList.Cast<TelemetryMessage>().ToList();
                list.ForEach(i =>
                {
                    var item = new ListViewItem(i.ToString());
                    item.Tag = i.JSONSerialisedMessage();
                    lstMessages.Items.Add(item);
                });
            }
        }

        #endregion

        #region Click events
        private void lnkStream_Click(object sender, EventArgs e)
        {
            EnableStreaming();
        }

        private void lnkStop_Click(object sender, EventArgs e)
        {
            DisableStreaming();
        }
        #endregion

        #region Timers Tick events
        private void tmrCheckSimulator_Tick(object sender, EventArgs e)
        {
            countNowObserved = RollingWindow.Instance.Messages.TotalMessages;
            lblCounter.Text = countNowObserved.ToString();

        }
        private void tmrLogConsole_Tick(object sender, EventArgs e)
        {
            var messagesList = RollingWindow.Instance.Messages;
            var length = messagesList.Count;

            //Only change the display when a new message is recieved
            if (length > 0 && countNowObserved > countLastObserved)
            {
                //Retrieve the topmost message from the list
                var latestMessage = ((TelemetryMessage)messagesList[--length]).ToString();
                //Clear console after 25 messages
                if (++totalTicks % 25 == 0)
                    txtMessageLog.ResetText();
                txtMessageLog.AppendText(latestMessage + System.Environment.NewLine);
                countLastObserved = countNowObserved;
            }
        }
        #endregion
       

        private void EnableStreaming()
        {
            if (!selectedConfig.IsCurrentlyStreaming)
            {
                //Enable the events linked to streaming
                tmrCheckSimulator.Enabled = tmrLogConsole.Enabled = true;
                selectedConfig.CancelStreamingToken?.Dispose();
                selectedConfig.CancelStreamingToken = new CancellationTokenSource();
                selectedConfig.IsCurrentlyStreaming = true;
                lblStatus.Text = "Streaming....";

                //Call the streaming logic
                Bootstrap.Main();
            }
        }

        private void DisableStreaming()
        {
            if (selectedConfig.IsCurrentlyStreaming)
            {
                //Disable the events linked to streaming
                tmrCheckSimulator.Enabled = tmrLogConsole.Enabled = false;
                selectedConfig.CancelStreamingToken.Cancel();
                selectedConfig.IsCurrentlyStreaming = false;
                lblStatus.Text = "Ready";
            }
        }
    }
}
