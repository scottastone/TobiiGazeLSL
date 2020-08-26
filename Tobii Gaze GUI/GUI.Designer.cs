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
            this.numFixations = new System.Windows.Forms.TextBox();
            this.lslFixationTypeHandle = new System.Windows.Forms.TextBox();
            this.lslFixationHandle = new System.Windows.Forms.TextBox();
            this.resetLSLButton = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lslType = new System.Windows.Forms.TextBox();
            this.lslHandle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numFixations);
            this.groupBox1.Controls.Add(this.lslFixationTypeHandle);
            this.groupBox1.Controls.Add(this.lslFixationHandle);
            this.groupBox1.Controls.Add(this.resetLSLButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lslType);
            this.groupBox1.Controls.Add(this.lslHandle);
            this.groupBox1.Controls.Add(this.streamLSLButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
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
            this.resetLSLButton.Location = new System.Drawing.Point(6, 60);
            this.resetLSLButton.Name = "resetLSLButton";
            this.resetLSLButton.Size = new System.Drawing.Size(73, 20);
            this.resetLSLButton.TabIndex = 4;
            this.resetLSLButton.Text = "Reset";
            this.resetLSLButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetLSLButton.UseVisualStyleBackColor = true;
            this.resetLSLButton.CheckedChanged += new System.EventHandler(this.resetLSLButton_CheckedChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fixations:";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 144);
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
        private System.Windows.Forms.TextBox lslFixationTypeHandle;
        private System.Windows.Forms.TextBox lslFixationHandle;
        private System.Windows.Forms.TextBox numFixations;
        private System.Windows.Forms.Label label2;
    }
}