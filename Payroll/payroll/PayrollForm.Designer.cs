
namespace payroll
{
    partial class PayrollForm
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.TextField = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.statusMsg = new System.Windows.Forms.StatusStrip();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 25;
            this.ListBox.Location = new System.Drawing.Point(30, 42);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(751, 154);
            this.ListBox.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(1127, 96);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(150, 44);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(803, 96);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(6);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(150, 44);
            this.InsertBtn.TabIndex = 19;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // TextField
            // 
            this.TextField.Location = new System.Drawing.Point(803, 42);
            this.TextField.Margin = new System.Windows.Forms.Padding(6);
            this.TextField.Name = "TextField";
            this.TextField.Size = new System.Drawing.Size(474, 31);
            this.TextField.TabIndex = 18;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(803, 152);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(474, 44);
            this.ResetBtn.TabIndex = 23;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // statusMsg
            // 
            this.statusMsg.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusMsg.Location = new System.Drawing.Point(0, 272);
            this.statusMsg.Name = "statusMsg";
            this.statusMsg.Size = new System.Drawing.Size(1693, 22);
            this.statusMsg.TabIndex = 24;
            this.statusMsg.Text = "statusStrip1";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(965, 96);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(150, 44);
            this.SearchBtn.TabIndex = 22;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 294);
            this.Controls.Add(this.statusMsg);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.TextField);
            this.Controls.Add(this.ListBox);
            this.Name = "PayrollForm";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox TextField;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.StatusStrip statusMsg;
        private System.Windows.Forms.Button SearchBtn;
    }
}

