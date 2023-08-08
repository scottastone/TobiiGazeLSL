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
            this.rightEyeVisible = new System.Windows.Forms.CheckBox();
            this.leftEyeVisible = new System.Windows.Forms.CheckBox();
            this.lslEyePositionTypeHandle = new System.Windows.Forms.TextBox();
            this.lslEyePositionHandle = new System.Windows.Forms.TextBox();
            this.dataCountLabel = new System.Windows.Forms.Label();
            this.dataSentCounter = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.mouseYBox = new System.Windows.Forms.TextBox();
            this.mouseXBox = new System.Windows.Forms.TextBox();
            this.gazeYBox = new System.Windows.Forms.TextBox();
            this.gazeXBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lslMouseSampleRate = new System.Windows.Forms.TextBox();
            this.lslMouseTypeHandle = new System.Windows.Forms.TextBox();
            this.lslMouseHandle = new System.Windows.Forms.TextBox();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.uptimeTextbox = new System.Windows.Forms.TextBox();
            this.fixationLabel = new System.Windows.Forms.Label();
            this.numFixations = new System.Windows.Forms.TextBox();
            this.lslFixationTypeHandle = new System.Windows.Forms.TextBox();
            this.lslFixationHandle = new System.Windows.Forms.TextBox();
            this.resetLSLButton = new System.Windows.Forms.CheckBox();
            this.lslType = new System.Windows.Forms.TextBox();
            this.lslHandle = new System.Windows.Forms.TextBox();
            this.streamGaze = new System.Windows.Forms.CheckBox();
            this.streamFixation = new System.Windows.Forms.CheckBox();
            this.streamMouse = new System.Windows.Forms.CheckBox();
            this.streamEyePos = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // streamLSLButton
            // 
            this.streamLSLButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.streamLSLButton.Location = new System.Drawing.Point(5, 16);
            this.streamLSLButton.Name = "streamLSLButton";
            this.streamLSLButton.Size = new System.Drawing.Size(65, 20);
            this.streamLSLButton.TabIndex = 0;
            this.streamLSLButton.Text = "Stream";
            this.streamLSLButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.streamLSLButton.UseVisualStyleBackColor = true;
            this.streamLSLButton.CheckedChanged += new System.EventHandler(this.StreamLSLButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.streamEyePos);
            this.groupBox1.Controls.Add(this.streamMouse);
            this.groupBox1.Controls.Add(this.streamFixation);
            this.groupBox1.Controls.Add(this.streamGaze);
            this.groupBox1.Controls.Add(this.rightEyeVisible);
            this.groupBox1.Controls.Add(this.leftEyeVisible);
            this.groupBox1.Controls.Add(this.lslEyePositionTypeHandle);
            this.groupBox1.Controls.Add(this.lslEyePositionHandle);
            this.groupBox1.Controls.Add(this.dataCountLabel);
            this.groupBox1.Controls.Add(this.dataSentCounter);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.mouseYBox);
            this.groupBox1.Controls.Add(this.mouseXBox);
            this.groupBox1.Controls.Add(this.gazeYBox);
            this.groupBox1.Controls.Add(this.gazeXBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lslMouseSampleRate);
            this.groupBox1.Controls.Add(this.lslMouseTypeHandle);
            this.groupBox1.Controls.Add(this.lslMouseHandle);
            this.groupBox1.Controls.Add(this.uptimeLabel);
            this.groupBox1.Controls.Add(this.uptimeTextbox);
            this.groupBox1.Controls.Add(this.fixationLabel);
            this.groupBox1.Controls.Add(this.numFixations);
            this.groupBox1.Controls.Add(this.lslFixationTypeHandle);
            this.groupBox1.Controls.Add(this.lslFixationHandle);
            this.groupBox1.Controls.Add(this.resetLSLButton);
            this.groupBox1.Controls.Add(this.lslType);
            this.groupBox1.Controls.Add(this.lslHandle);
            this.groupBox1.Controls.Add(this.streamLSLButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rightEyeVisible
            // 
            this.rightEyeVisible.Appearance = System.Windows.Forms.Appearance.Button;
            this.rightEyeVisible.AutoSize = true;
            this.rightEyeVisible.BackColor = System.Drawing.Color.Crimson;
            this.rightEyeVisible.Location = new System.Drawing.Point(545, 84);
            this.rightEyeVisible.Name = "rightEyeVisible";
            this.rightEyeVisible.Size = new System.Drawing.Size(20, 23);
            this.rightEyeVisible.TabIndex = 29;
            this.rightEyeVisible.Text = " ";
            this.rightEyeVisible.UseVisualStyleBackColor = false;
            // 
            // leftEyeVisible
            // 
            this.leftEyeVisible.Appearance = System.Windows.Forms.Appearance.Button;
            this.leftEyeVisible.AutoSize = true;
            this.leftEyeVisible.BackColor = System.Drawing.Color.Crimson;
            this.leftEyeVisible.Location = new System.Drawing.Point(519, 84);
            this.leftEyeVisible.Name = "leftEyeVisible";
            this.leftEyeVisible.Size = new System.Drawing.Size(20, 23);
            this.leftEyeVisible.TabIndex = 28;
            this.leftEyeVisible.Text = " ";
            this.leftEyeVisible.UseVisualStyleBackColor = false;
            // 
            // lslEyePositionTypeHandle
            // 
            this.lslEyePositionTypeHandle.Location = new System.Drawing.Point(456, 61);
            this.lslEyePositionTypeHandle.Name = "lslEyePositionTypeHandle";
            this.lslEyePositionTypeHandle.Size = new System.Drawing.Size(109, 20);
            this.lslEyePositionTypeHandle.TabIndex = 26;
            this.lslEyePositionTypeHandle.Text = "Position";
            this.lslEyePositionTypeHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lslEyePositionHandle
            // 
            this.lslEyePositionHandle.Location = new System.Drawing.Point(456, 35);
            this.lslEyePositionHandle.Name = "lslEyePositionHandle";
            this.lslEyePositionHandle.Size = new System.Drawing.Size(109, 20);
            this.lslEyePositionHandle.TabIndex = 25;
            this.lslEyePositionHandle.Text = "EyePos";
            this.lslEyePositionHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataCountLabel
            // 
            this.dataCountLabel.AutoSize = true;
            this.dataCountLabel.Location = new System.Drawing.Point(0, 114);
            this.dataCountLabel.Name = "dataCountLabel";
            this.dataCountLabel.Size = new System.Drawing.Size(38, 13);
            this.dataCountLabel.TabIndex = 24;
            this.dataCountLabel.Text = "Count:";
            // 
            // dataSentCounter
            // 
            this.dataSentCounter.Location = new System.Drawing.Point(45, 110);
            this.dataSentCounter.Margin = new System.Windows.Forms.Padding(2);
            this.dataSentCounter.Name = "dataSentCounter";
            this.dataSentCounter.ReadOnly = true;
            this.dataSentCounter.Size = new System.Drawing.Size(52, 20);
            this.dataSentCounter.TabIndex = 23;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(6, 65);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 23);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mouseYBox
            // 
            this.mouseYBox.Location = new System.Drawing.Point(410, 110);
            this.mouseYBox.Name = "mouseYBox";
            this.mouseYBox.Size = new System.Drawing.Size(39, 20);
            this.mouseYBox.TabIndex = 21;
            this.mouseYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mouseXBox
            // 
            this.mouseXBox.Location = new System.Drawing.Point(365, 110);
            this.mouseXBox.Name = "mouseXBox";
            this.mouseXBox.Size = new System.Drawing.Size(39, 20);
            this.mouseXBox.TabIndex = 20;
            this.mouseXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gazeYBox
            // 
            this.gazeYBox.Location = new System.Drawing.Point(178, 110);
            this.gazeYBox.Name = "gazeYBox";
            this.gazeYBox.Size = new System.Drawing.Size(39, 20);
            this.gazeYBox.TabIndex = 19;
            this.gazeYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gazeXBox
            // 
            this.gazeXBox.Location = new System.Drawing.Point(133, 110);
            this.gazeXBox.Name = "gazeXBox";
            this.gazeXBox.Size = new System.Drawing.Size(39, 20);
            this.gazeXBox.TabIndex = 18;
            this.gazeXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Freq:";
            // 
            // lslMouseSampleRate
            // 
            this.lslMouseSampleRate.Location = new System.Drawing.Point(377, 84);
            this.lslMouseSampleRate.Name = "lslMouseSampleRate";
            this.lslMouseSampleRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lslMouseSampleRate.Size = new System.Drawing.Size(73, 20);
            this.lslMouseSampleRate.TabIndex = 15;
            this.lslMouseSampleRate.Text = "1000";
            this.lslMouseSampleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lslMouseSampleRate.TextChanged += new System.EventHandler(this.lslMouseSampleRate_TextChanged);
            this.lslMouseSampleRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lslMouseSampleRate_KeyPress);
            // 
            // lslMouseTypeHandle
            // 
            this.lslMouseTypeHandle.Location = new System.Drawing.Point(341, 61);
            this.lslMouseTypeHandle.Name = "lslMouseTypeHandle";
            this.lslMouseTypeHandle.Size = new System.Drawing.Size(109, 20);
            this.lslMouseTypeHandle.TabIndex = 13;
            this.lslMouseTypeHandle.Text = "Position";
            this.lslMouseTypeHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lslMouseHandle
            // 
            this.lslMouseHandle.Location = new System.Drawing.Point(341, 35);
            this.lslMouseHandle.Name = "lslMouseHandle";
            this.lslMouseHandle.Size = new System.Drawing.Size(109, 20);
            this.lslMouseHandle.TabIndex = 12;
            this.lslMouseHandle.Text = "MousePos";
            this.lslMouseHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Location = new System.Drawing.Point(-2, 92);
            this.uptimeLabel.Name = "uptimeLabel";
            this.uptimeLabel.Size = new System.Drawing.Size(43, 13);
            this.uptimeLabel.TabIndex = 11;
            this.uptimeLabel.Text = "Uptime:";
            // 
            // uptimeTextbox
            // 
            this.uptimeTextbox.Location = new System.Drawing.Point(45, 88);
            this.uptimeTextbox.Name = "uptimeTextbox";
            this.uptimeTextbox.ReadOnly = true;
            this.uptimeTextbox.Size = new System.Drawing.Size(52, 20);
            this.uptimeTextbox.TabIndex = 10;
            this.uptimeTextbox.Text = "0";
            this.uptimeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fixationLabel
            // 
            this.fixationLabel.AutoSize = true;
            this.fixationLabel.Location = new System.Drawing.Point(224, 87);
            this.fixationLabel.Name = "fixationLabel";
            this.fixationLabel.Size = new System.Drawing.Size(51, 13);
            this.fixationLabel.TabIndex = 8;
            this.fixationLabel.Text = "Fixations:";
            // 
            // numFixations
            // 
            this.numFixations.Location = new System.Drawing.Point(279, 84);
            this.numFixations.Margin = new System.Windows.Forms.Padding(2);
            this.numFixations.Name = "numFixations";
            this.numFixations.ReadOnly = true;
            this.numFixations.Size = new System.Drawing.Size(56, 20);
            this.numFixations.TabIndex = 7;
            // 
            // lslFixationTypeHandle
            // 
            this.lslFixationTypeHandle.Location = new System.Drawing.Point(226, 61);
            this.lslFixationTypeHandle.Name = "lslFixationTypeHandle";
            this.lslFixationTypeHandle.Size = new System.Drawing.Size(109, 20);
            this.lslFixationTypeHandle.TabIndex = 6;
            this.lslFixationTypeHandle.Text = "Fixation";
            this.lslFixationTypeHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lslFixationHandle
            // 
            this.lslFixationHandle.Location = new System.Drawing.Point(226, 35);
            this.lslFixationHandle.Name = "lslFixationHandle";
            this.lslFixationHandle.Size = new System.Drawing.Size(109, 20);
            this.lslFixationHandle.TabIndex = 5;
            this.lslFixationHandle.Text = "TobiiFixation";
            this.lslFixationHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resetLSLButton
            // 
            this.resetLSLButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.resetLSLButton.Location = new System.Drawing.Point(5, 41);
            this.resetLSLButton.Name = "resetLSLButton";
            this.resetLSLButton.Size = new System.Drawing.Size(65, 20);
            this.resetLSLButton.TabIndex = 4;
            this.resetLSLButton.Text = "Reset";
            this.resetLSLButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetLSLButton.UseVisualStyleBackColor = true;
            this.resetLSLButton.CheckedChanged += new System.EventHandler(this.resetLSLButton_CheckedChanged);
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
            // lslHandle
            // 
            this.lslHandle.Location = new System.Drawing.Point(109, 35);
            this.lslHandle.Name = "lslHandle";
            this.lslHandle.Size = new System.Drawing.Size(109, 20);
            this.lslHandle.TabIndex = 1;
            this.lslHandle.Text = "TobiiGaze";
            this.lslHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // streamGaze
            // 
            this.streamGaze.Appearance = System.Windows.Forms.Appearance.Button;
            this.streamGaze.AutoSize = true;
            this.streamGaze.Checked = true;
            this.streamGaze.CheckState = System.Windows.Forms.CheckState.Checked;
            this.streamGaze.Location = new System.Drawing.Point(133, 9);
            this.streamGaze.Name = "streamGaze";
            this.streamGaze.Size = new System.Drawing.Size(50, 23);
            this.streamGaze.TabIndex = 30;
            this.streamGaze.Text = "Enable";
            this.streamGaze.UseVisualStyleBackColor = true;
            // 
            // streamFixation
            // 
            this.streamFixation.Appearance = System.Windows.Forms.Appearance.Button;
            this.streamFixation.AutoSize = true;
            this.streamFixation.Checked = true;
            this.streamFixation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.streamFixation.Location = new System.Drawing.Point(253, 9);
            this.streamFixation.Name = "streamFixation";
            this.streamFixation.Size = new System.Drawing.Size(50, 23);
            this.streamFixation.TabIndex = 31;
            this.streamFixation.Text = "Enable";
            this.streamFixation.UseVisualStyleBackColor = true;
            // 
            // streamMouse
            // 
            this.streamMouse.Appearance = System.Windows.Forms.Appearance.Button;
            this.streamMouse.AutoSize = true;
            this.streamMouse.Checked = true;
            this.streamMouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.streamMouse.Location = new System.Drawing.Point(377, 9);
            this.streamMouse.Name = "streamMouse";
            this.streamMouse.Size = new System.Drawing.Size(50, 23);
            this.streamMouse.TabIndex = 32;
            this.streamMouse.Text = "Enable";
            this.streamMouse.UseVisualStyleBackColor = true;
            // 
            // streamEyePos
            // 
            this.streamEyePos.Appearance = System.Windows.Forms.Appearance.Button;
            this.streamEyePos.AutoSize = true;
            this.streamEyePos.Checked = true;
            this.streamEyePos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.streamEyePos.Location = new System.Drawing.Point(489, 9);
            this.streamEyePos.Name = "streamEyePos";
            this.streamEyePos.Size = new System.Drawing.Size(50, 23);
            this.streamEyePos.TabIndex = 33;
            this.streamEyePos.Text = "Enable";
            this.streamEyePos.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 168);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "LSL Gaze and Mouse Tracker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox streamLSLButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lslType;
        private System.Windows.Forms.TextBox lslHandle;
        private System.Windows.Forms.CheckBox resetLSLButton;
        private System.Windows.Forms.TextBox lslFixationTypeHandle;
        private System.Windows.Forms.TextBox lslFixationHandle;
        private System.Windows.Forms.TextBox numFixations;
        private System.Windows.Forms.Label fixationLabel;
        private System.Windows.Forms.TextBox uptimeTextbox;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.TextBox lslMouseTypeHandle;
        private System.Windows.Forms.TextBox lslMouseHandle;
        private System.Windows.Forms.TextBox lslMouseSampleRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gazeYBox;
        private System.Windows.Forms.TextBox gazeXBox;
        private System.Windows.Forms.TextBox mouseYBox;
        private System.Windows.Forms.TextBox mouseXBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox dataSentCounter;
        private System.Windows.Forms.Label dataCountLabel;
        private System.Windows.Forms.TextBox lslEyePositionTypeHandle;
        private System.Windows.Forms.TextBox lslEyePositionHandle;
        private System.Windows.Forms.CheckBox leftEyeVisible;
        private System.Windows.Forms.CheckBox rightEyeVisible;
        private System.Windows.Forms.CheckBox streamMouse;
        private System.Windows.Forms.CheckBox streamFixation;
        private System.Windows.Forms.CheckBox streamGaze;
        private System.Windows.Forms.CheckBox streamEyePos;
    }
}