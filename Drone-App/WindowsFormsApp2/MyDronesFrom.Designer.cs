namespace WindowsFormsApp2
{
    partial class MyDronesFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.textBoxEngine = new System.Windows.Forms.TextBox();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.textBoxAcc = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusMsg = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Engine Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Accessories";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(305, 94);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(238, 134);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged_1);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(171, 206);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add New Drone";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBoxEngine
            // 
            this.textBoxEngine.Location = new System.Drawing.Point(171, 94);
            this.textBoxEngine.Name = "textBoxEngine";
            this.textBoxEngine.Size = new System.Drawing.Size(100, 20);
            this.textBoxEngine.TabIndex = 5;
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(171, 121);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(100, 20);
            this.textBoxRange.TabIndex = 6;
            // 
            // textBoxAcc
            // 
            this.textBoxAcc.Location = new System.Drawing.Point(171, 151);
            this.textBoxAcc.Name = "textBoxAcc";
            this.textBoxAcc.Size = new System.Drawing.Size(100, 20);
            this.textBoxAcc.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(171, 180);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // statusMsg
            // 
            this.statusMsg.Location = new System.Drawing.Point(0, 428);
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Size = new System.Drawing.Size(800, 22);
            this.statusMsg.TabIndex = 10;
            this.statusMsg.Text = "statusStrip1";
            // 
            // MyDronesFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusMsg);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAcc);
            this.Controls.Add(this.textBoxRange);
            this.Controls.Add(this.textBoxEngine);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyDronesFrom";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBoxEngine;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.TextBox textBoxAcc;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusMsg;
    }
}

