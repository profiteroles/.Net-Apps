
namespace TemperatureApp
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
            this.groupBoxComPort = new System.Windows.Forms.GroupBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.groupBoxMoonLight = new System.Windows.Forms.GroupBox();
            this.radioButtonOff = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.labelOutsideTemp = new System.Windows.Forms.Label();
            this.labelInsideDHT = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.textBoxOutsideTemp = new System.Windows.Forms.TextBox();
            this.textBoxInsideTemp = new System.Windows.Forms.TextBox();
            this.textBoxHumidity = new System.Windows.Forms.TextBox();
            this.comboBoxMaxTemp = new System.Windows.Forms.ComboBox();
            this.buttonMaxTemp = new System.Windows.Forms.Button();
            this.buttonLED = new System.Windows.Forms.Button();
            this.progressBarOutTemp = new System.Windows.Forms.ProgressBar();
            this.progressBarInTemp = new System.Windows.Forms.ProgressBar();
            this.progressBarHumidity = new System.Windows.Forms.ProgressBar();
            this.myPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxComPort.SuspendLayout();
            this.groupBoxMoonLight.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComPort
            // 
            this.groupBoxComPort.Controls.Add(this.buttonDisconnect);
            this.groupBoxComPort.Controls.Add(this.buttonConnect);
            this.groupBoxComPort.Controls.Add(this.comboBoxPort);
            this.groupBoxComPort.Location = new System.Drawing.Point(38, 32);
            this.groupBoxComPort.Name = "groupBoxComPort";
            this.groupBoxComPort.Size = new System.Drawing.Size(106, 114);
            this.groupBoxComPort.TabIndex = 0;
            this.groupBoxComPort.TabStop = false;
            this.groupBoxComPort.Text = "COM Port";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDisconnect.Location = new System.Drawing.Point(15, 80);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(14, 46);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12"});
            this.comboBoxPort.Location = new System.Drawing.Point(15, 19);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(74, 21);
            this.comboBoxPort.TabIndex = 0;
            this.comboBoxPort.Text = "COM9";
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxPort_SelectedIndexChanged);
            // 
            // groupBoxMoonLight
            // 
            this.groupBoxMoonLight.Controls.Add(this.radioButtonOff);
            this.groupBoxMoonLight.Controls.Add(this.radioButtonBlue);
            this.groupBoxMoonLight.Controls.Add(this.radioButtonRed);
            this.groupBoxMoonLight.Controls.Add(this.radioButtonGreen);
            this.groupBoxMoonLight.Location = new System.Drawing.Point(38, 165);
            this.groupBoxMoonLight.Name = "groupBoxMoonLight";
            this.groupBoxMoonLight.Size = new System.Drawing.Size(106, 131);
            this.groupBoxMoonLight.TabIndex = 1;
            this.groupBoxMoonLight.TabStop = false;
            this.groupBoxMoonLight.Text = "Mood Light";
            // 
            // radioButtonOff
            // 
            this.radioButtonOff.AutoSize = true;
            this.radioButtonOff.Location = new System.Drawing.Point(7, 102);
            this.radioButtonOff.Name = "radioButtonOff";
            this.radioButtonOff.Size = new System.Drawing.Size(39, 17);
            this.radioButtonOff.TabIndex = 3;
            this.radioButtonOff.TabStop = true;
            this.radioButtonOff.Text = "Off";
            this.radioButtonOff.UseVisualStyleBackColor = true;
            this.radioButtonOff.CheckedChanged += new System.EventHandler(this.radioButtonOff_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(7, 78);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 55);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(7, 32);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(54, 17);
            this.radioButtonGreen.TabIndex = 0;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // labelOutsideTemp
            // 
            this.labelOutsideTemp.AutoSize = true;
            this.labelOutsideTemp.Location = new System.Drawing.Point(192, 44);
            this.labelOutsideTemp.Name = "labelOutsideTemp";
            this.labelOutsideTemp.Size = new System.Drawing.Size(109, 13);
            this.labelOutsideTemp.TabIndex = 2;
            this.labelOutsideTemp.Text = "Outside Temp (LM35)";
            // 
            // labelInsideDHT
            // 
            this.labelInsideDHT.AutoSize = true;
            this.labelInsideDHT.Location = new System.Drawing.Point(192, 88);
            this.labelInsideDHT.Name = "labelInsideDHT";
            this.labelInsideDHT.Size = new System.Drawing.Size(109, 13);
            this.labelInsideDHT.TabIndex = 3;
            this.labelInsideDHT.Text = "Inside Temp (DHT11)";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(192, 133);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(122, 13);
            this.labelHumidity.TabIndex = 4;
            this.labelHumidity.Text = "Inside Humidity (DHT11)";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Location = new System.Drawing.Point(0, 310);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(467, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statussStrip";
            // 
            // textBoxOutsideTemp
            // 
            this.textBoxOutsideTemp.Location = new System.Drawing.Point(320, 41);
            this.textBoxOutsideTemp.Name = "textBoxOutsideTemp";
            this.textBoxOutsideTemp.ReadOnly = true;
            this.textBoxOutsideTemp.Size = new System.Drawing.Size(100, 20);
            this.textBoxOutsideTemp.TabIndex = 6;
            // 
            // textBoxInsideTemp
            // 
            this.textBoxInsideTemp.Location = new System.Drawing.Point(320, 85);
            this.textBoxInsideTemp.Name = "textBoxInsideTemp";
            this.textBoxInsideTemp.ReadOnly = true;
            this.textBoxInsideTemp.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsideTemp.TabIndex = 7;
            // 
            // textBoxHumidity
            // 
            this.textBoxHumidity.Location = new System.Drawing.Point(320, 130);
            this.textBoxHumidity.Name = "textBoxHumidity";
            this.textBoxHumidity.ReadOnly = true;
            this.textBoxHumidity.Size = new System.Drawing.Size(100, 20);
            this.textBoxHumidity.TabIndex = 8;
            // 
            // comboBoxMaxTemp
            // 
            this.comboBoxMaxTemp.FormattingEnabled = true;
            this.comboBoxMaxTemp.Items.AddRange(new object[] {
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38"});
            this.comboBoxMaxTemp.Location = new System.Drawing.Point(351, 184);
            this.comboBoxMaxTemp.Name = "comboBoxMaxTemp";
            this.comboBoxMaxTemp.Size = new System.Drawing.Size(69, 21);
            this.comboBoxMaxTemp.TabIndex = 9;
            this.comboBoxMaxTemp.Text = "26";
            this.comboBoxMaxTemp.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaxTemp_SelectedIndexChanged);
            // 
            // buttonMaxTemp
            // 
            this.buttonMaxTemp.Location = new System.Drawing.Point(235, 184);
            this.buttonMaxTemp.Name = "buttonMaxTemp";
            this.buttonMaxTemp.Size = new System.Drawing.Size(94, 23);
            this.buttonMaxTemp.TabIndex = 10;
            this.buttonMaxTemp.Text = "Temp Max";
            this.buttonMaxTemp.UseVisualStyleBackColor = true;
            this.buttonMaxTemp.Click += new System.EventHandler(this.buttonMaxTemp_Click);
            // 
            // buttonLED
            // 
            this.buttonLED.BackColor = System.Drawing.Color.Red;
            this.buttonLED.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLED.Location = new System.Drawing.Point(205, 221);
            this.buttonLED.Name = "buttonLED";
            this.buttonLED.Size = new System.Drawing.Size(215, 53);
            this.buttonLED.TabIndex = 11;
            this.buttonLED.Text = "Red LED Toggle";
            this.buttonLED.UseVisualStyleBackColor = false;
            this.buttonLED.Click += new System.EventHandler(this.buttonLED_Click);
            // 
            // progressBarOutTemp
            // 
            this.progressBarOutTemp.Location = new System.Drawing.Point(320, 67);
            this.progressBarOutTemp.Maximum = 50;
            this.progressBarOutTemp.Name = "progressBarOutTemp";
            this.progressBarOutTemp.Size = new System.Drawing.Size(100, 12);
            this.progressBarOutTemp.Step = 8;
            this.progressBarOutTemp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarOutTemp.TabIndex = 12;
            // 
            // progressBarInTemp
            // 
            this.progressBarInTemp.Location = new System.Drawing.Point(320, 112);
            this.progressBarInTemp.Maximum = 50;
            this.progressBarInTemp.Name = "progressBarInTemp";
            this.progressBarInTemp.Size = new System.Drawing.Size(100, 12);
            this.progressBarInTemp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarInTemp.TabIndex = 14;
            // 
            // progressBarHumidity
            // 
            this.progressBarHumidity.Location = new System.Drawing.Point(320, 156);
            this.progressBarHumidity.Name = "progressBarHumidity";
            this.progressBarHumidity.Size = new System.Drawing.Size(100, 12);
            this.progressBarHumidity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarHumidity.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 332);
            this.Controls.Add(this.progressBarHumidity);
            this.Controls.Add(this.progressBarInTemp);
            this.Controls.Add(this.progressBarOutTemp);
            this.Controls.Add(this.buttonLED);
            this.Controls.Add(this.buttonMaxTemp);
            this.Controls.Add(this.comboBoxMaxTemp);
            this.Controls.Add(this.textBoxHumidity);
            this.Controls.Add(this.textBoxInsideTemp);
            this.Controls.Add(this.textBoxOutsideTemp);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelInsideDHT);
            this.Controls.Add(this.labelOutsideTemp);
            this.Controls.Add(this.groupBoxMoonLight);
            this.Controls.Add(this.groupBoxComPort);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IoT Prototype";
            this.groupBoxComPort.ResumeLayout(false);
            this.groupBoxMoonLight.ResumeLayout(false);
            this.groupBoxMoonLight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComPort;
        private System.Windows.Forms.GroupBox groupBoxMoonLight;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.Label labelOutsideTemp;
        private System.Windows.Forms.Label labelInsideDHT;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox textBoxOutsideTemp;
        private System.Windows.Forms.TextBox textBoxInsideTemp;
        private System.Windows.Forms.TextBox textBoxHumidity;
        private System.Windows.Forms.ComboBox comboBoxMaxTemp;
        private System.Windows.Forms.Button buttonMaxTemp;
        private System.Windows.Forms.Button buttonLED;
        private System.Windows.Forms.ProgressBar progressBarOutTemp;
        private System.Windows.Forms.ProgressBar progressBarInTemp;
        private System.Windows.Forms.ProgressBar progressBarHumidity;
        public System.IO.Ports.SerialPort myPort;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

