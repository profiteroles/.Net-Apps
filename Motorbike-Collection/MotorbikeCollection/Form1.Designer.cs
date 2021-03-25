namespace MotorbikeCollection
{
    partial class MotorbikeForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ListBoxOutput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusMsg = new System.Windows.Forms.StatusStrip();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxMake = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBSearch = new System.Windows.Forms.Button();
            this.buttonLS = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(496, 191);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.toolTip.SetToolTip(this.buttonAdd, "Add details to ListBox");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.Location = new System.Drawing.Point(12, 70);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(399, 264);
            this.ListBoxOutput.TabIndex = 1;
            this.toolTip.SetToolTip(this.ListBoxOutput, "All your bikes will be listed here");
            this.ListBoxOutput.SelectedIndexChanged += new System.EventHandler(this.ListBoxOutput_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Motorcycle Collection";
            // 
            // statusMsg
            // 
            this.statusMsg.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusMsg.Location = new System.Drawing.Point(0, 428);
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Size = new System.Drawing.Size(800, 22);
            this.statusMsg.TabIndex = 3;
            this.statusMsg.Text = "statusStrip1";
            this.toolTip.SetToolTip(this.statusMsg, "Check system status");
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(602, 191);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.toolTip.SetToolTip(this.buttonClear, "Clear all the Bike Details");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(602, 220);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Reset all your List & information you insert");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxMake
            // 
            this.textBoxMake.Location = new System.Drawing.Point(576, 70);
            this.textBoxMake.Name = "textBoxMake";
            this.textBoxMake.Size = new System.Drawing.Size(100, 20);
            this.textBoxMake.TabIndex = 6;
            this.toolTip.SetToolTip(this.textBoxMake, "Model of the Bike");
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(576, 96);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxModel, "Make of the Bike");
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(576, 125);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 8;
            this.toolTip.SetToolTip(this.textBoxCost, "Cost of the Bike");
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(576, 153);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 9;
            this.toolTip.SetToolTip(this.textBoxTotal, "Summary of the Bikes Listed");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total";
            // 
            // buttonBSearch
            // 
            this.buttonBSearch.Location = new System.Drawing.Point(494, 267);
            this.buttonBSearch.Name = "buttonBSearch";
            this.buttonBSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonBSearch.TabIndex = 14;
            this.buttonBSearch.Text = "B-Search";
            this.toolTip.SetToolTip(this.buttonBSearch, "Bineary Search from ListBox");
            this.buttonBSearch.UseVisualStyleBackColor = true;
            this.buttonBSearch.Click += new System.EventHandler(this.buttonBSearch_Click);
            // 
            // buttonLS
            // 
            this.buttonLS.Location = new System.Drawing.Point(602, 266);
            this.buttonLS.Name = "buttonLS";
            this.buttonLS.Size = new System.Drawing.Size(75, 23);
            this.buttonLS.TabIndex = 15;
            this.buttonLS.Text = "L-Search";
            this.toolTip.SetToolTip(this.buttonLS, "Linear Search from the List Box");
            this.buttonLS.UseVisualStyleBackColor = true;
            this.buttonLS.Click += new System.EventHandler(this.buttonLS_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(494, 297);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.toolTip.SetToolTip(this.buttonSave, "Save the Entered Data Only");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(602, 297);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 17;
            this.buttonLoad.Text = "Load";
            this.toolTip.SetToolTip(this.buttonLoad, "Load Saved Data");
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // MotorbikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLS);
            this.Controls.Add(this.buttonBSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMake);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.statusMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxOutput);
            this.Controls.Add(this.buttonAdd);
            this.Name = "MotorbikeForm";
            this.Text = "Motorbike Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox ListBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusMsg;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBSearch;
        private System.Windows.Forms.Button buttonLS;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

