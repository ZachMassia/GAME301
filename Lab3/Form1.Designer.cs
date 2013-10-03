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
            this.ttsTextBox = new System.Windows.Forms.TextBox();
            this.ttsBtn = new System.Windows.Forms.Button();
            this.ttsGroupBox = new System.Windows.Forms.GroupBox();
            this.ttsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttsTextBox
            // 
            this.ttsTextBox.Location = new System.Drawing.Point(6, 19);
            this.ttsTextBox.Name = "ttsTextBox";
            this.ttsTextBox.Size = new System.Drawing.Size(425, 20);
            this.ttsTextBox.TabIndex = 0;
            // 
            // ttsBtn
            // 
            this.ttsBtn.Location = new System.Drawing.Point(356, 45);
            this.ttsBtn.Name = "ttsBtn";
            this.ttsBtn.Size = new System.Drawing.Size(75, 23);
            this.ttsBtn.TabIndex = 1;
            this.ttsBtn.Text = "Say It";
            this.ttsBtn.UseVisualStyleBackColor = true;
            this.ttsBtn.Click += new System.EventHandler(this.ttsBtn_Click);
            // 
            // ttsGroupBox
            // 
            this.ttsGroupBox.Controls.Add(this.ttsTextBox);
            this.ttsGroupBox.Controls.Add(this.ttsBtn);
            this.ttsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ttsGroupBox.Name = "ttsGroupBox";
            this.ttsGroupBox.Size = new System.Drawing.Size(437, 76);
            this.ttsGroupBox.TabIndex = 2;
            this.ttsGroupBox.TabStop = false;
            this.ttsGroupBox.Text = "Enter some text";
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 97);
            this.Controls.Add(this.ttsGroupBox);
            this.Name = "Lab3";
            this.Text = "Lab 3 - TTS";
            this.ttsGroupBox.ResumeLayout(false);
            this.ttsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ttsTextBox;
        private System.Windows.Forms.Button ttsBtn;
        private System.Windows.Forms.GroupBox ttsGroupBox;
    }
}

