namespace Lab3
{
    partial class Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.pcPictureBox = new System.Windows.Forms.PictureBox();
            this.playWavBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wavPlayerBox = new System.Windows.Forms.GroupBox();
            this.wavListBox = new System.Windows.Forms.ListBox();
            this.wavConvertBox = new System.Windows.Forms.GroupBox();
            this.wavConvertBtn = new System.Windows.Forms.Button();
            this.wavTextBox = new System.Windows.Forms.TextBox();
            this.playBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.wavPlayerBox.SuspendLayout();
            this.wavConvertBox.SuspendLayout();
            this.playBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playerPictureBox.Image")));
            this.playerPictureBox.Location = new System.Drawing.Point(0, 273);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(32, 32);
            this.playerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPictureBox.TabIndex = 0;
            this.playerPictureBox.TabStop = false;
            // 
            // pcPictureBox
            // 
            this.pcPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pcPictureBox.Image")));
            this.pcPictureBox.Location = new System.Drawing.Point(464, 19);
            this.pcPictureBox.Name = "pcPictureBox";
            this.pcPictureBox.Size = new System.Drawing.Size(32, 32);
            this.pcPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPictureBox.TabIndex = 1;
            this.pcPictureBox.TabStop = false;
            // 
            // playWavBtn
            // 
            this.playWavBtn.Location = new System.Drawing.Point(52, 26);
            this.playWavBtn.Name = "playWavBtn";
            this.playWavBtn.Size = new System.Drawing.Size(75, 23);
            this.playWavBtn.TabIndex = 2;
            this.playWavBtn.Text = "Play Wav";
            this.playWavBtn.UseVisualStyleBackColor = true;
            this.playWavBtn.Click += new System.EventHandler(this.playWavBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(526, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // wavPlayerBox
            // 
            this.wavPlayerBox.Controls.Add(this.wavListBox);
            this.wavPlayerBox.Controls.Add(this.playWavBtn);
            this.wavPlayerBox.Location = new System.Drawing.Point(12, 12);
            this.wavPlayerBox.Name = "wavPlayerBox";
            this.wavPlayerBox.Size = new System.Drawing.Size(136, 58);
            this.wavPlayerBox.TabIndex = 4;
            this.wavPlayerBox.TabStop = false;
            this.wavPlayerBox.Text = "Play a wave file";
            // 
            // wavListBox
            // 
            this.wavListBox.FormattingEnabled = true;
            this.wavListBox.Items.AddRange(new object[] {
            "Sound",
            "Text"});
            this.wavListBox.Location = new System.Drawing.Point(6, 19);
            this.wavListBox.Name = "wavListBox";
            this.wavListBox.Size = new System.Drawing.Size(40, 30);
            this.wavListBox.TabIndex = 0;
            // 
            // wavConvertBox
            // 
            this.wavConvertBox.Controls.Add(this.wavConvertBtn);
            this.wavConvertBox.Controls.Add(this.wavTextBox);
            this.wavConvertBox.Location = new System.Drawing.Point(174, 12);
            this.wavConvertBox.Name = "wavConvertBox";
            this.wavConvertBox.Size = new System.Drawing.Size(340, 58);
            this.wavConvertBox.TabIndex = 5;
            this.wavConvertBox.TabStop = false;
            this.wavConvertBox.Text = "Convert text to wave";
            // 
            // wavConvertBtn
            // 
            this.wavConvertBtn.Location = new System.Drawing.Point(243, 26);
            this.wavConvertBtn.Name = "wavConvertBtn";
            this.wavConvertBtn.Size = new System.Drawing.Size(91, 23);
            this.wavConvertBtn.TabIndex = 1;
            this.wavConvertBtn.Text = "Convert to .wav";
            this.wavConvertBtn.UseVisualStyleBackColor = true;
            this.wavConvertBtn.Click += new System.EventHandler(this.wavConvertBtn_Click);
            // 
            // wavTextBox
            // 
            this.wavTextBox.Location = new System.Drawing.Point(6, 29);
            this.wavTextBox.Name = "wavTextBox";
            this.wavTextBox.Size = new System.Drawing.Size(231, 20);
            this.wavTextBox.TabIndex = 0;
            // 
            // playBox
            // 
            this.playBox.Controls.Add(this.playerPictureBox);
            this.playBox.Controls.Add(this.pcPictureBox);
            this.playBox.Location = new System.Drawing.Point(12, 76);
            this.playBox.Name = "playBox";
            this.playBox.Size = new System.Drawing.Size(502, 311);
            this.playBox.TabIndex = 7;
            this.playBox.TabStop = false;
            this.playBox.Text = "Play Area";
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 412);
            this.Controls.Add(this.playBox);
            this.Controls.Add(this.wavConvertBox);
            this.Controls.Add(this.wavPlayerBox);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Lab3";
            this.Text = "Lab 3 - TTS";
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.wavPlayerBox.ResumeLayout(false);
            this.wavConvertBox.ResumeLayout(false);
            this.wavConvertBox.PerformLayout();
            this.playBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.PictureBox pcPictureBox;
        private System.Windows.Forms.Button playWavBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox wavPlayerBox;
        private System.Windows.Forms.ListBox wavListBox;
        private System.Windows.Forms.GroupBox wavConvertBox;
        private System.Windows.Forms.Button wavConvertBtn;
        private System.Windows.Forms.TextBox wavTextBox;
        private System.Windows.Forms.GroupBox playBox;

    }
}

