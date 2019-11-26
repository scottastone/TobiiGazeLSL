namespace Tobii_Gaze_GUI
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.streamLSLButton = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lslHandle = new System.Windows.Forms.TextBox();
            this.lslType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetLSLButton = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // streamLSLButton
            // 
            this.streamLSLButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.streamLSLButton.Location = new System.Drawing.Point(6, 35);
            this.streamLSLButton.Name = "streamLSLButton";
            this.streamLSLButton.Size = new System.Drawing.Size(73, 20);
            this.streamLSLButton.TabIndex = 0;
            this.streamLSLButton.Text = "Stream";
            this.streamLSLButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.streamLSLButton.UseVisualStyleBackColor = true;
            this.streamLSLButton.CheckedChanged += new System.EventHandler(this.streamLSLButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetLSLButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lslType);
            this.groupBox1.Controls.Add(this.lslHandle);
            this.groupBox1.Controls.Add(this.streamLSLButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lslHandle
            // 
            this.lslHandle.Location = new System.Drawing.Point(109, 35);
            this.lslHandle.Name = "lslHandle";
            this.lslHandle.Size = new System.Drawing.Size(109, 20);
            this.lslHandle.TabIndex = 1;
            this.lslHandle.Text = "TobiiGaze";
            this.lslHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lslType
            // 
            this.lslType.Location = new System.Drawing.Point(109, 61);
            this.lslType.Name = "lslType";
            this.lslType.Size = new System.Drawing.Size(109, 20);
            this.lslType.TabIndex = 2;
            this.lslType.Text = "Gaze";
            this.lslType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stream Handle / Type";
            // 
            // resetLSLButton
            // 
            this.resetLSLButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.resetLSLButton.Location = new System.Drawing.Point(6, 60);
            this.resetLSLButton.Name = "resetLSLButton";
            this.resetLSLButton.Size = new System.Drawing.Size(73, 20);
            this.resetLSLButton.TabIndex = 4;
            this.resetLSLButton.Text = "Reset";
            this.resetLSLButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetLSLButton.UseVisualStyleBackColor = true;
            this.resetLSLButton.CheckedChanged += new System.EventHandler(this.resetLSLButton_CheckedChanged);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 141);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI";
            this.Text = "Tobii LSL Gaze Streamer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox streamLSLButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lslType;
        private System.Windows.Forms.TextBox lslHandle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox resetLSLButton;
    }
}