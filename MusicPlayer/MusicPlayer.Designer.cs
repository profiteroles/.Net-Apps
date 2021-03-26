
namespace MusicPlayer
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.playLastBtn = new System.Windows.Forms.Button();
            this.playFirstBtn = new System.Windows.Forms.Button();
            this.openFileVideo = new System.Windows.Forms.OpenFileDialog();
            this.openFileAudio = new System.Windows.Forms.OpenFileDialog();
            this.AddBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numSongs = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.statusMsg = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            resources.ApplyResources(this.WMP, "WMP");
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            // 
            // playLastBtn
            // 
            resources.ApplyResources(this.playLastBtn, "playLastBtn");
            this.playLastBtn.Name = "playLastBtn";
            this.playLastBtn.UseVisualStyleBackColor = true;
            this.playLastBtn.Click += new System.EventHandler(this.playLastBtn_Click);
            // 
            // playFirstBtn
            // 
            resources.ApplyResources(this.playFirstBtn, "playFirstBtn");
            this.playFirstBtn.Name = "playFirstBtn";
            this.playFirstBtn.UseVisualStyleBackColor = true;
            this.playFirstBtn.Click += new System.EventHandler(this.playFirstBtn_Click);
            // 
            // openFileVideo
            // 
            this.openFileVideo.FileName = "openFileVideo";
            resources.ApplyResources(this.openFileVideo, "openFileVideo");
            // 
            // openFileAudio
            // 
            this.openFileAudio.FileName = "openFileAudio";
            resources.ApplyResources(this.openFileAudio, "openFileAudio");
            // 
            // AddBtn
            // 
            resources.ApplyResources(this.AddBtn, "AddBtn");
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            resources.ApplyResources(this.listBox, "listBox");
            this.listBox.Name = "listBox";
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numSongs
            // 
            resources.ApplyResources(this.numSongs, "numSongs");
            this.numSongs.Name = "numSongs";
            this.numSongs.ReadOnly = true;
            // 
            // nextBtn
            // 
            resources.ApplyResources(this.nextBtn, "nextBtn");
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            resources.ApplyResources(this.prevBtn, "prevBtn");
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // statusMsg
            // 
            resources.ApplyResources(this.statusMsg, "statusMsg");
            this.statusMsg.Name = "statusMsg";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.statusMsg);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.numSongs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.playFirstBtn);
            this.Controls.Add(this.playLastBtn);
            this.Controls.Add(this.WMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button playLastBtn;
        private System.Windows.Forms.Button playFirstBtn;
        private System.Windows.Forms.OpenFileDialog openFileVideo;
        private System.Windows.Forms.OpenFileDialog openFileAudio;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numSongs;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.StatusStrip statusMsg;
    }
}

