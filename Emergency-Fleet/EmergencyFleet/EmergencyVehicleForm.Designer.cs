namespace EmergencyFleet
{
    partial class EmergencyVehicleForm
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
            this.listBoxVehicle = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.vehicleIDBox = new System.Windows.Forms.TextBox();
            this.makeBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.situationCodeBox = new System.Windows.Forms.TextBox();
            this.addPoliceButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.policeOverloadButton = new System.Windows.Forms.Button();
            this.responseTypeBox = new System.Windows.Forms.TextBox();
            this.personnelBox = new System.Windows.Forms.TextBox();
            this.addFireButton = new System.Windows.Forms.Button();
            this.fireOverloadButton = new System.Windows.Forms.Button();
            this.numberPatientsBox = new System.Windows.Forms.TextBox();
            this.addMedicalButton = new System.Windows.Forms.Button();
            this.medicalOverloadButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxVehicle
            // 
            this.listBoxVehicle.FormattingEnabled = true;
            this.listBoxVehicle.Location = new System.Drawing.Point(12, 125);
            this.listBoxVehicle.Name = "listBoxVehicle";
            this.listBoxVehicle.Size = new System.Drawing.Size(501, 290);
            this.listBoxVehicle.TabIndex = 0;
            this.listBoxVehicle.SelectedIndexChanged += new System.EventHandler(this.listBoxVehicle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Make:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Situation Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Response Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Personnel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Number Patients";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // vehicleIDBox
            // 
            this.vehicleIDBox.Location = new System.Drawing.Point(171, 30);
            this.vehicleIDBox.Name = "vehicleIDBox";
            this.vehicleIDBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleIDBox.TabIndex = 13;
            // 
            // makeBox
            // 
            this.makeBox.Location = new System.Drawing.Point(171, 63);
            this.makeBox.Name = "makeBox";
            this.makeBox.Size = new System.Drawing.Size(100, 20);
            this.makeBox.TabIndex = 14;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(171, 93);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(100, 20);
            this.modelBox.TabIndex = 15;
            // 
            // situationCodeBox
            // 
            this.situationCodeBox.Location = new System.Drawing.Point(647, 57);
            this.situationCodeBox.Name = "situationCodeBox";
            this.situationCodeBox.Size = new System.Drawing.Size(100, 20);
            this.situationCodeBox.TabIndex = 19;
            // 
            // addPoliceButton
            // 
            this.addPoliceButton.Location = new System.Drawing.Point(757, 55);
            this.addPoliceButton.Name = "addPoliceButton";
            this.addPoliceButton.Size = new System.Drawing.Size(75, 23);
            this.addPoliceButton.TabIndex = 20;
            this.addPoliceButton.Text = "Add Police";
            this.addPoliceButton.UseVisualStyleBackColor = true;
            this.addPoliceButton.Click += new System.EventHandler(this.addPoliceButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(647, 88);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(100, 20);
            this.typeBox.TabIndex = 21;
            // 
            // policeOverloadButton
            // 
            this.policeOverloadButton.Location = new System.Drawing.Point(757, 86);
            this.policeOverloadButton.Name = "policeOverloadButton";
            this.policeOverloadButton.Size = new System.Drawing.Size(75, 23);
            this.policeOverloadButton.TabIndex = 22;
            this.policeOverloadButton.Text = "Overloaded";
            this.policeOverloadButton.UseVisualStyleBackColor = true;
            this.policeOverloadButton.Click += new System.EventHandler(this.policeOverloadButton_Click);
            // 
            // responseTypeBox
            // 
            this.responseTypeBox.Location = new System.Drawing.Point(114, 35);
            this.responseTypeBox.Name = "responseTypeBox";
            this.responseTypeBox.Size = new System.Drawing.Size(100, 20);
            this.responseTypeBox.TabIndex = 23;
            // 
            // personnelBox
            // 
            this.personnelBox.Location = new System.Drawing.Point(114, 64);
            this.personnelBox.Name = "personnelBox";
            this.personnelBox.Size = new System.Drawing.Size(100, 20);
            this.personnelBox.TabIndex = 0;
            // 
            // addFireButton
            // 
            this.addFireButton.Location = new System.Drawing.Point(224, 33);
            this.addFireButton.Name = "addFireButton";
            this.addFireButton.Size = new System.Drawing.Size(75, 23);
            this.addFireButton.TabIndex = 24;
            this.addFireButton.Text = "Add Fire";
            this.addFireButton.UseVisualStyleBackColor = true;
            this.addFireButton.Click += new System.EventHandler(this.addFireButton_Click);
            // 
            // fireOverloadButton
            // 
            this.fireOverloadButton.Location = new System.Drawing.Point(224, 60);
            this.fireOverloadButton.Name = "fireOverloadButton";
            this.fireOverloadButton.Size = new System.Drawing.Size(75, 23);
            this.fireOverloadButton.TabIndex = 25;
            this.fireOverloadButton.Text = "Overloaded";
            this.fireOverloadButton.UseVisualStyleBackColor = true;
            this.fireOverloadButton.Click += new System.EventHandler(this.fireOverloadButton_Click);
            // 
            // numberPatientsBox
            // 
            this.numberPatientsBox.Location = new System.Drawing.Point(114, 25);
            this.numberPatientsBox.Name = "numberPatientsBox";
            this.numberPatientsBox.Size = new System.Drawing.Size(100, 20);
            this.numberPatientsBox.TabIndex = 6;
            // 
            // addMedicalButton
            // 
            this.addMedicalButton.Location = new System.Drawing.Point(224, 25);
            this.addMedicalButton.Name = "addMedicalButton";
            this.addMedicalButton.Size = new System.Drawing.Size(75, 23);
            this.addMedicalButton.TabIndex = 27;
            this.addMedicalButton.Text = "Add Medical";
            this.addMedicalButton.UseVisualStyleBackColor = true;
            this.addMedicalButton.Click += new System.EventHandler(this.addMedicalButton_Click);
            // 
            // medicalOverloadButton
            // 
            this.medicalOverloadButton.Location = new System.Drawing.Point(224, 55);
            this.medicalOverloadButton.Name = "medicalOverloadButton";
            this.medicalOverloadButton.Size = new System.Drawing.Size(75, 23);
            this.medicalOverloadButton.TabIndex = 28;
            this.medicalOverloadButton.Text = "Overloaded";
            this.medicalOverloadButton.UseVisualStyleBackColor = true;
            this.medicalOverloadButton.Click += new System.EventHandler(this.medicalOverloadButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.medicalOverloadButton);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.addMedicalButton);
            this.groupBox1.Controls.Add(this.numberPatientsBox);
            this.groupBox1.Location = new System.Drawing.Point(533, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 113);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medical";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Controls.Add(this.fireOverloadButton);
            this.groupBox2.Controls.Add(this.personnelBox);
            this.groupBox2.Controls.Add(this.addFireButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.responseTypeBox);
            this.groupBox2.Location = new System.Drawing.Point(533, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 127);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fire";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(533, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 137);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Police";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type:";
            // 
            // EmergencyVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.policeOverloadButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.addPoliceButton);
            this.Controls.Add(this.situationCodeBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.makeBox);
            this.Controls.Add(this.vehicleIDBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxVehicle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "EmergencyVehicleForm";
            this.Text = "My Emergency Fleet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox vehicleIDBox;
        private System.Windows.Forms.TextBox makeBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox situationCodeBox;
        private System.Windows.Forms.Button addPoliceButton;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button policeOverloadButton;
        private System.Windows.Forms.TextBox responseTypeBox;
        private System.Windows.Forms.TextBox personnelBox;
        private System.Windows.Forms.Button addFireButton;
        private System.Windows.Forms.Button fireOverloadButton;
        private System.Windows.Forms.TextBox numberPatientsBox;
        private System.Windows.Forms.Button addMedicalButton;
        private System.Windows.Forms.Button medicalOverloadButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
    }
}

