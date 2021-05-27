using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace TemperatureApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String outTempC, inTempC, humidity;
        int maxTemp = 30;
        private async void receivingData()
        {
            while (myPort.IsOpen == true)
            {
                await Task.Run(() => { System.Threading.Thread.Sleep(1000); });

                try
                { // convert raw data into correct format
                    string line = myPort.ReadLine();
                    char[] trimmer = { ',', '\n' };
                    string[] data = line.Split(trimmer[0], trimmer[1]);
                    outTempC = data[0];
                    inTempC = data[1];
                    humidity = data[2];

                    textBoxOutsideTemp.Text = outTempC;
                    textBoxInsideTemp.Text = inTempC;
                    textBoxHumidity.Text = humidity;
                    try
                    {
                        //progress bar shows the value
                        progressBarOutTemp.Value = (int)double.Parse(outTempC);
                        progressBarInTemp.Value = (int)double.Parse(inTempC);
                        progressBarHumidity.Value = (int)double.Parse(humidity);
                        progressBarOutTemp.BackColor = Color.Red;
                    
                    }
                catch (InvalidOperationException)
                {
                    statusStrip.Items.Clear();
                    statusStrip.Items.Add("You are not Connected to the Arduino");
                }
            }
                catch (TimeoutException)
                {
                    statusStrip.Items.Clear();
                    statusStrip.Items.Add("Time Error Occurred Again");

                }

                catch (FormatException)
                {
                    statusStrip.Items.Clear();
                    statusStrip.Items.Add("Format Error while loading the Data last Temps inside: " + inTempC +
                        " Outside: " + outTempC + " Humidity " + humidity);
                }
                catch (IndexOutOfRangeException)
                {
                    statusStrip.Items.Clear();
                    statusStrip.Items.Add("Out of Range Error while loading the Data last Temps inside: " + inTempC +
                        " Outside: " + outTempC + " Humidity " + humidity);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You are disconnected from Arduino");
                    statusStrip.Items.Clear();
                    statusStrip.Items.Add("Reconnect to read the data");

                    textBoxOutsideTemp.Text = null;
                    textBoxInsideTemp.Text = null;
                    textBoxHumidity.Text = null;
                    progressBarOutTemp.Value = 0;
                    progressBarInTemp.Value = 0;
                    progressBarHumidity.Value = 0;

                }
                if (maxTemp < progressBarInTemp.Value)
                {
                    myPort.WriteLine(comboBoxMaxTemp.SelectedItem.ToString());
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPort.SelectedItem == null)
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add("Please Select a Port");
            }
            else
            {
                if (myPort.IsOpen == false)
                {
                    myPort.BaudRate = 9600;
                    myPort.PortName = comboBoxPort.SelectedItem.ToString();
                    myPort.ReadTimeout = 1000;
                    try
                    {
                        myPort.Open();
                        myPort.RtsEnable = true;
                        receivingData();
                        statusStrip.Items.Clear();
                        statusStrip.Items.Add("Connected to Arduino");

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not connected");
                        statusStrip.Items.Clear();
                        statusStrip.Items.Add("Connection to Arduino is Failed");
                    }
                }
            }
        }

        private async void buttonMaxTemp_Click(object sender, EventArgs e)
        {
            try {
                maxTemp = (int)double.Parse(comboBoxMaxTemp.SelectedItem.ToString());
                
            statusStrip.Items.Clear();
            statusStrip.Items.Add("Max Temperature set to " + comboBoxMaxTemp.SelectedItem.ToString() + "°");
        } catch(InvalidOperationException)
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add("You are not Connected to the Arduino");
            }
            catch (Exception)
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add("Arduino is reset it, Please reconnect");

            }
        }

        bool redlightON = false;
        private void buttonLED_Click(object sender, EventArgs e)
        {
            try { 
            if (redlightON == false)
            {
                myPort.WriteLine("120");
                redlightON = true;
                

            }
            else if (redlightON == true)
            {
                myPort.WriteLine("12");
                redlightON = false;
                
            }
            }
            catch (InvalidOperationException)
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add("You are not Connected to the Arduino");
            }         
}

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxPort.SelectedItem = 1;
            statusStrip.Items.Clear();
            statusStrip.Items.Add(comboBoxPort.SelectedItem.ToString() + " is Selected");
        }

        private void comboBoxMaxTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusStrip.Items.Clear();
            statusStrip.Items.Add("Max Temperature Selected " + comboBoxMaxTemp.SelectedItem.ToString() + "°C");
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            try{
                myPort.WriteLine("100");
            }
            catch (InvalidOperationException)
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add("You are not Connected to the Arduino");
            }
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            myPort.WriteLine("90");
            }
            catch (InvalidOperationException)
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add("You are not Connected to the Arduino");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            myPort.Close();
            statusStrip.Items.Clear();
            statusStrip.Items.Add("App is disconnected from Arduino");
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            try{myPort.WriteLine("110"); }
            catch (InvalidOperationException)
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add("You are not Connected to the Arduino");
            }
        }

        private void radioButtonOff_CheckedChanged(object sender, EventArgs e)
        {
            try{myPort.WriteLine("1"); }
            catch (InvalidOperationException)
            {
                statusStrip.Items.Clear();
                statusStrip.Items.Add("You are not Connected to the Arduino");
            }
        }        
    }
}
