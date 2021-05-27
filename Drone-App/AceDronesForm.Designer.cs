namespace AceDrones
{
    partial class AceDronesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAcc = new System.Windows.Forms.TextBox();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.textBoxEngCon = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxSerialNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusMsg = new System.Windows.Forms.StatusStrip();
            this.listBoxDrones = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchCustomerIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxTCustID = new System.Windows.Forms.TextBox();
            this.textBoxTSerialNo = new System.Windows.Forms.TextBox();
            this.labelTSerialNo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTransID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddDrone = new System.Windows.Forms.Button();
            this.listBoxCust = new System.Windows.Forms.ListBox();
            this.listBoxTrans = new System.Windows.Forms.ListBox();
            this.buttonAddCust = new System.Windows.Forms.Button();
            this.buttonAddTrans = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(912, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.textBoxAcc);
            this.groupBox1.Controls.Add(this.textBoxRange);
            this.groupBox1.Controls.Add(this.textBoxEngCon);
            this.groupBox1.Controls.Add(this.textBoxModel);
            this.groupBox1.Controls.Add(this.textBoxSerialNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(44, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(394, 471);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drone Information";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(176, 367);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker.MaxDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(196, 31);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Value = new System.DateTime(2020, 11, 16, 0, 0, 0, 0);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(176, 312);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(196, 31);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxAcc
            // 
            this.textBoxAcc.Location = new System.Drawing.Point(176, 258);
            this.textBoxAcc.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAcc.Name = "textBoxAcc";
            this.textBoxAcc.Size = new System.Drawing.Size(196, 31);
            this.textBoxAcc.TabIndex = 4;
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(176, 208);
            this.textBoxRange.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(196, 31);
            this.textBoxRange.TabIndex = 3;
            // 
            // textBoxEngCon
            // 
            this.textBoxEngCon.Location = new System.Drawing.Point(176, 154);
            this.textBoxEngCon.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxEngCon.Name = "textBoxEngCon";
            this.textBoxEngCon.Size = new System.Drawing.Size(196, 31);
            this.textBoxEngCon.TabIndex = 2;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(176, 104);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(196, 31);
            this.textBoxModel.TabIndex = 1;
            this.textBoxModel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxModel_MouseDoubleClick);
            // 
            // textBoxSerialNo
            // 
            this.textBoxSerialNo.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxSerialNo.Enabled = false;
            this.textBoxSerialNo.Location = new System.Drawing.Point(176, 50);
            this.textBoxSerialNo.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSerialNo.Multiline = true;
            this.textBoxSerialNo.Name = "textBoxSerialNo";
            this.textBoxSerialNo.Size = new System.Drawing.Size(196, 31);
            this.textBoxSerialNo.TabIndex = 7;
            this.textBoxSerialNo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSerialNo_MouseDoubleClick);
            this.textBoxSerialNo.MouseHover += new System.EventHandler(this.textBoxSerialNo_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 373);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Purchase Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 317);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 263);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Accessories";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Range";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Eng. Config";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Serial Number";
            // 
            // statusMsg
            // 
            this.statusMsg.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusMsg.Location = new System.Drawing.Point(0, 846);
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusMsg.Size = new System.Drawing.Size(1952, 22);
            this.statusMsg.TabIndex = 6;
            this.statusMsg.Text = "statusStrip1";
            // 
            // listBoxDrones
            // 
            this.listBoxDrones.Font = new System.Drawing.Font("Century", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDrones.FormattingEnabled = true;
            this.listBoxDrones.ItemHeight = 34;
            this.listBoxDrones.Location = new System.Drawing.Point(454, 198);
            this.listBoxDrones.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxDrones.Name = "listBoxDrones";
            this.listBoxDrones.Size = new System.Drawing.Size(382, 582);
            this.listBoxDrones.TabIndex = 7;
            this.listBoxDrones.SelectedIndexChanged += new System.EventHandler(this.listBoxDrones_SelectedIndexChanged);
            this.listBoxDrones.MouseHover += new System.EventHandler(this.listBoxDrones_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCountry);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.textBoxCity);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxCustID);
            this.groupBox2.Controls.Add(this.labelCity);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(848, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(382, 271);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Information";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(158, 208);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(196, 31);
            this.textBoxCountry.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(158, 104);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 31);
            this.textBoxName.TabIndex = 10;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(158, 154);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(196, 31);
            this.textBoxCity.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 56);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 25);
            this.label14.TabIndex = 14;
            this.label14.Text = "Customer ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 110);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Full Name";
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxCustID.ContextMenuStrip = this.contextMenuStrip;
            this.textBoxCustID.Location = new System.Drawing.Point(158, 50);
            this.textBoxCustID.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(196, 31);
            this.textBoxCustID.TabIndex = 9;
            this.textBoxCustID.Text = "C001";
            this.textBoxCustID.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxCustID_MouseDoubleClick);
            this.textBoxCustID.MouseHover += new System.EventHandler(this.textBoxCustID_MouseHover);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchCustomerIDToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(302, 42);
            // 
            // searchCustomerIDToolStripMenuItem
            // 
            this.searchCustomerIDToolStripMenuItem.Name = "searchCustomerIDToolStripMenuItem";
            this.searchCustomerIDToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.searchCustomerIDToolStripMenuItem.Text = "Search Customer ID";
            this.searchCustomerIDToolStripMenuItem.Click += new System.EventHandler(this.searchCustomerIDToolStripMenuItem_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(104, 160);
            this.labelCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(49, 25);
            this.labelCity.TabIndex = 16;
            this.labelCity.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Country";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxTCustID);
            this.groupBox3.Controls.Add(this.textBoxTSerialNo);
            this.groupBox3.Controls.Add(this.labelTSerialNo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textBoxTransID);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(848, 508);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(382, 272);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction Information";
            // 
            // textBoxTCustID
            // 
            this.textBoxTCustID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxTCustID.Enabled = false;
            this.textBoxTCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTCustID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTCustID.Location = new System.Drawing.Point(170, 102);
            this.textBoxTCustID.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTCustID.Name = "textBoxTCustID";
            this.textBoxTCustID.Size = new System.Drawing.Size(196, 37);
            this.textBoxTCustID.TabIndex = 26;
            this.textBoxTCustID.MouseHover += new System.EventHandler(this.textBoxTCustID_MouseHover);
            // 
            // textBoxTSerialNo
            // 
            this.textBoxTSerialNo.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxTSerialNo.Enabled = false;
            this.textBoxTSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTSerialNo.Location = new System.Drawing.Point(170, 152);
            this.textBoxTSerialNo.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTSerialNo.Name = "textBoxTSerialNo";
            this.textBoxTSerialNo.Size = new System.Drawing.Size(196, 37);
            this.textBoxTSerialNo.TabIndex = 27;
            this.textBoxTSerialNo.MouseHover += new System.EventHandler(this.textBoxTSerialNo_MouseHover);
            // 
            // labelTSerialNo
            // 
            this.labelTSerialNo.AutoSize = true;
            this.labelTSerialNo.Location = new System.Drawing.Point(18, 158);
            this.labelTSerialNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTSerialNo.Name = "labelTSerialNo";
            this.labelTSerialNo.Size = new System.Drawing.Size(148, 25);
            this.labelTSerialNo.TabIndex = 24;
            this.labelTSerialNo.Text = "Serial Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 54);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "Transaction ID";
            // 
            // textBoxTransID
            // 
            this.textBoxTransID.Location = new System.Drawing.Point(170, 48);
            this.textBoxTransID.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxTransID.Name = "textBoxTransID";
            this.textBoxTransID.Size = new System.Drawing.Size(196, 31);
            this.textBoxTransID.TabIndex = 15;
            this.textBoxTransID.DoubleClick += new System.EventHandler(this.textBoxTransID_DoubleClick);
            this.textBoxTransID.MouseHover += new System.EventHandler(this.textBoxTransID_MouseHover);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 108);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 25);
            this.label16.TabIndex = 23;
            this.label16.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(912, 442);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 59);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transactions";
            // 
            // buttonAddDrone
            // 
            this.buttonAddDrone.Font = new System.Drawing.Font("Century", 10.875F);
            this.buttonAddDrone.Location = new System.Drawing.Point(450, 94);
            this.buttonAddDrone.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddDrone.Name = "buttonAddDrone";
            this.buttonAddDrone.Size = new System.Drawing.Size(386, 44);
            this.buttonAddDrone.TabIndex = 7;
            this.buttonAddDrone.Text = "Add Drone";
            this.buttonAddDrone.UseVisualStyleBackColor = true;
            this.buttonAddDrone.Click += new System.EventHandler(this.buttonAddDrone_Click);
            this.buttonAddDrone.MouseHover += new System.EventHandler(this.buttonAddDrone_MouseHover);
            // 
            // listBoxCust
            // 
            this.listBoxCust.Font = new System.Drawing.Font("Century", 10.875F);
            this.listBoxCust.FormattingEnabled = true;
            this.listBoxCust.ItemHeight = 34;
            this.listBoxCust.Location = new System.Drawing.Point(1242, 213);
            this.listBoxCust.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxCust.Name = "listBoxCust";
            this.listBoxCust.Size = new System.Drawing.Size(585, 208);
            this.listBoxCust.TabIndex = 11;
            this.listBoxCust.SelectedIndexChanged += new System.EventHandler(this.listBoxCust_SelectedIndexChanged);
            this.listBoxCust.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCust_MouseDoubleClick);
            this.listBoxCust.MouseHover += new System.EventHandler(this.listBoxCust_MouseHover);
            // 
            // listBoxTrans
            // 
            this.listBoxTrans.Font = new System.Drawing.Font("Century", 10.875F);
            this.listBoxTrans.FormattingEnabled = true;
            this.listBoxTrans.ItemHeight = 34;
            this.listBoxTrans.Location = new System.Drawing.Point(1242, 572);
            this.listBoxTrans.Margin = new System.Windows.Forms.Padding(6);
            this.listBoxTrans.Name = "listBoxTrans";
            this.listBoxTrans.Size = new System.Drawing.Size(585, 208);
            this.listBoxTrans.TabIndex = 12;
            this.listBoxTrans.SelectedIndexChanged += new System.EventHandler(this.listBoxTrans_SelectedIndexChanged);
            this.listBoxTrans.MouseHover += new System.EventHandler(this.listBoxTrans_MouseHover);
            // 
            // buttonAddCust
            // 
            this.buttonAddCust.Font = new System.Drawing.Font("Century", 10.875F);
            this.buttonAddCust.Location = new System.Drawing.Point(1242, 100);
            this.buttonAddCust.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddCust.Name = "buttonAddCust";
            this.buttonAddCust.Size = new System.Drawing.Size(444, 44);
            this.buttonAddCust.TabIndex = 13;
            this.buttonAddCust.Text = "Add Customer";
            this.buttonAddCust.UseVisualStyleBackColor = true;
            this.buttonAddCust.Click += new System.EventHandler(this.buttonAddCust_Click);
            this.buttonAddCust.MouseHover += new System.EventHandler(this.buttonAddCust_MouseHover);
            // 
            // buttonAddTrans
            // 
            this.buttonAddTrans.Font = new System.Drawing.Font("Century", 10.875F);
            this.buttonAddTrans.Location = new System.Drawing.Point(1242, 467);
            this.buttonAddTrans.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddTrans.Name = "buttonAddTrans";
            this.buttonAddTrans.Size = new System.Drawing.Size(444, 44);
            this.buttonAddTrans.TabIndex = 16;
            this.buttonAddTrans.Text = "Add Transaction";
            this.buttonAddTrans.UseVisualStyleBackColor = true;
            this.buttonAddTrans.Click += new System.EventHandler(this.buttonAddTrans_Click);
            this.buttonAddTrans.MouseHover += new System.EventHandler(this.buttonAddTrans_MouseHover);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Serial #";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(591, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 25);
            this.label17.TabIndex = 16;
            this.label17.Text = "Engine Con";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(750, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 25);
            this.label18.TabIndex = 17;
            this.label18.Text = "Price";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1611, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 25);
            this.label19.TabIndex = 20;
            this.label19.Text = "City";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1414, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 25);
            this.label20.TabIndex = 19;
            this.label20.Text = "Full Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1259, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 25);
            this.label21.TabIndex = 18;
            this.label21.Text = "Cust ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1552, 532);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 25);
            this.label22.TabIndex = 23;
            this.label22.Text = "Serial #";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1393, 532);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(130, 25);
            this.label23.TabIndex = 22;
            this.label23.Text = "Customer ID";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1259, 532);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 25);
            this.label24.TabIndex = 21;
            this.label24.Text = "Trans ID";
            // 
            // AceDronesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1952, 868);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonAddTrans);
            this.Controls.Add(this.buttonAddCust);
            this.Controls.Add(this.listBoxTrans);
            this.Controls.Add(this.listBoxCust);
            this.Controls.Add(this.buttonAddDrone);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxDrones);
            this.Controls.Add(this.statusMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AceDronesForm";
            this.Text = "Ace Drones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AceDronesForm_FormClosing);
            this.Load += new System.EventHandler(this.AceDronesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusMsg;
        private System.Windows.Forms.ListBox listBoxDrones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAcc;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.TextBox textBoxEngCon;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxSerialNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddDrone;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTCustID;
        private System.Windows.Forms.TextBox textBoxTSerialNo;
        private System.Windows.Forms.Label labelTSerialNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxTransID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBoxCust;
        private System.Windows.Forms.ListBox listBoxTrans;
        private System.Windows.Forms.Button buttonAddCust;
        private System.Windows.Forms.Button buttonAddTrans;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem searchCustomerIDToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}

