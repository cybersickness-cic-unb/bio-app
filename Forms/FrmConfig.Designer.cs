namespace BC
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.gpbConnection = new System.Windows.Forms.GroupBox();
            this.cboSamplingFreq = new System.Windows.Forms.ComboBox();
            this.txtMacAddress = new System.Windows.Forms.TextBox();
            this.lblMacAddress = new System.Windows.Forms.Label();
            this.lblHzSamplingFreq = new System.Windows.Forms.Label();
            this.lblSamplingFreq = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtIpAdress = new System.Windows.Forms.TextBox();
            this.lblIpAdress = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gpbResizeGraphics = new System.Windows.Forms.GroupBox();
            this.txtResizeWidthTo = new System.Windows.Forms.TextBox();
            this.lblResizeWidthTo = new System.Windows.Forms.Label();
            this.txtResizeHeightTo = new System.Windows.Forms.TextBox();
            this.lblResizeHeightTo = new System.Windows.Forms.Label();
            this.lblRecordingTimeInterval = new System.Windows.Forms.Label();
            this.txtRecordingTimeInterval = new System.Windows.Forms.TextBox();
            this.lblUnitTimeInterval = new System.Windows.Forms.Label();
            this.chkptbEnableSpeechRecognition = new System.Windows.Forms.CheckBox();
            this.ptbEnableSpeechRecognition = new System.Windows.Forms.PictureBox();
            this.gpbConnection.SuspendLayout();
            this.gpbResizeGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEnableSpeechRecognition)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConnection
            // 
            this.gpbConnection.Controls.Add(this.cboSamplingFreq);
            this.gpbConnection.Controls.Add(this.txtMacAddress);
            this.gpbConnection.Controls.Add(this.lblMacAddress);
            this.gpbConnection.Controls.Add(this.lblHzSamplingFreq);
            this.gpbConnection.Controls.Add(this.lblSamplingFreq);
            this.gpbConnection.Controls.Add(this.txtPort);
            this.gpbConnection.Controls.Add(this.lblPort);
            this.gpbConnection.Controls.Add(this.txtIpAdress);
            this.gpbConnection.Controls.Add(this.lblIpAdress);
            this.gpbConnection.Location = new System.Drawing.Point(25, 18);
            this.gpbConnection.Margin = new System.Windows.Forms.Padding(4);
            this.gpbConnection.Name = "gpbConnection";
            this.gpbConnection.Padding = new System.Windows.Forms.Padding(4);
            this.gpbConnection.Size = new System.Drawing.Size(615, 116);
            this.gpbConnection.TabIndex = 0;
            this.gpbConnection.TabStop = false;
            this.gpbConnection.Text = "Connection";
            // 
            // cboSamplingFreq
            // 
            this.cboSamplingFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSamplingFreq.FormattingEnabled = true;
            this.cboSamplingFreq.Items.AddRange(new object[] {
            "10",
            "100",
            "1000"});
            this.cboSamplingFreq.Location = new System.Drawing.Point(469, 70);
            this.cboSamplingFreq.Name = "cboSamplingFreq";
            this.cboSamplingFreq.Size = new System.Drawing.Size(93, 24);
            this.cboSamplingFreq.TabIndex = 7;
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.Location = new System.Drawing.Point(152, 31);
            this.txtMacAddress.MaxLength = 40;
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Size = new System.Drawing.Size(162, 22);
            this.txtMacAddress.TabIndex = 1;
            // 
            // lblMacAddress
            // 
            this.lblMacAddress.AutoSize = true;
            this.lblMacAddress.Location = new System.Drawing.Point(37, 34);
            this.lblMacAddress.Name = "lblMacAddress";
            this.lblMacAddress.Size = new System.Drawing.Size(87, 16);
            this.lblMacAddress.TabIndex = 0;
            this.lblMacAddress.Text = "Mac Address";
            // 
            // lblHzSamplingFreq
            // 
            this.lblHzSamplingFreq.AutoSize = true;
            this.lblHzSamplingFreq.Location = new System.Drawing.Point(568, 75);
            this.lblHzSamplingFreq.Name = "lblHzSamplingFreq";
            this.lblHzSamplingFreq.Size = new System.Drawing.Size(23, 16);
            this.lblHzSamplingFreq.TabIndex = 8;
            this.lblHzSamplingFreq.Text = "Hz";
            // 
            // lblSamplingFreq
            // 
            this.lblSamplingFreq.AutoSize = true;
            this.lblSamplingFreq.Location = new System.Drawing.Point(339, 75);
            this.lblSamplingFreq.Name = "lblSamplingFreq";
            this.lblSamplingFreq.Size = new System.Drawing.Size(95, 16);
            this.lblSamplingFreq.TabIndex = 6;
            this.lblSamplingFreq.Text = "Sampling Freq";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(469, 31);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.MaxLength = 5;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(92, 22);
            this.txtPort.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(403, 34);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 16);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // txtIpAdress
            // 
            this.txtIpAdress.Location = new System.Drawing.Point(152, 72);
            this.txtIpAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtIpAdress.MaxLength = 20;
            this.txtIpAdress.Name = "txtIpAdress";
            this.txtIpAdress.Size = new System.Drawing.Size(162, 22);
            this.txtIpAdress.TabIndex = 5;
            // 
            // lblIpAdress
            // 
            this.lblIpAdress.AutoSize = true;
            this.lblIpAdress.Location = new System.Drawing.Point(60, 75);
            this.lblIpAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIpAdress.Name = "lblIpAdress";
            this.lblIpAdress.Size = new System.Drawing.Size(64, 16);
            this.lblIpAdress.TabIndex = 4;
            this.lblIpAdress.Text = "IP adress";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(298, 381);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 53);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(480, 381);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 53);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gpbResizeGraphics
            // 
            this.gpbResizeGraphics.Controls.Add(this.txtResizeWidthTo);
            this.gpbResizeGraphics.Controls.Add(this.lblResizeWidthTo);
            this.gpbResizeGraphics.Controls.Add(this.txtResizeHeightTo);
            this.gpbResizeGraphics.Controls.Add(this.lblResizeHeightTo);
            this.gpbResizeGraphics.Location = new System.Drawing.Point(24, 154);
            this.gpbResizeGraphics.Margin = new System.Windows.Forms.Padding(4);
            this.gpbResizeGraphics.Name = "gpbResizeGraphics";
            this.gpbResizeGraphics.Padding = new System.Windows.Forms.Padding(4);
            this.gpbResizeGraphics.Size = new System.Drawing.Size(616, 97);
            this.gpbResizeGraphics.TabIndex = 1;
            this.gpbResizeGraphics.TabStop = false;
            this.gpbResizeGraphics.Text = "In case of resizing the graphics, define dimensions";
            // 
            // txtResizeWidthTo
            // 
            this.txtResizeWidthTo.Location = new System.Drawing.Point(172, 41);
            this.txtResizeWidthTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtResizeWidthTo.MaxLength = 5;
            this.txtResizeWidthTo.Name = "txtResizeWidthTo";
            this.txtResizeWidthTo.Size = new System.Drawing.Size(116, 22);
            this.txtResizeWidthTo.TabIndex = 1;
            // 
            // lblResizeWidthTo
            // 
            this.lblResizeWidthTo.AutoSize = true;
            this.lblResizeWidthTo.Location = new System.Drawing.Point(301, 43);
            this.lblResizeWidthTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResizeWidthTo.Name = "lblResizeWidthTo";
            this.lblResizeWidthTo.Size = new System.Drawing.Size(111, 16);
            this.lblResizeWidthTo.TabIndex = 2;
            this.lblResizeWidthTo.Text = "Resize Height To";
            // 
            // txtResizeHeightTo
            // 
            this.txtResizeHeightTo.Location = new System.Drawing.Point(441, 38);
            this.txtResizeHeightTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtResizeHeightTo.MaxLength = 5;
            this.txtResizeHeightTo.Name = "txtResizeHeightTo";
            this.txtResizeHeightTo.Size = new System.Drawing.Size(121, 22);
            this.txtResizeHeightTo.TabIndex = 3;
            // 
            // lblResizeHeightTo
            // 
            this.lblResizeHeightTo.AutoSize = true;
            this.lblResizeHeightTo.Location = new System.Drawing.Point(27, 43);
            this.lblResizeHeightTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResizeHeightTo.Name = "lblResizeHeightTo";
            this.lblResizeHeightTo.Size = new System.Drawing.Size(106, 16);
            this.lblResizeHeightTo.TabIndex = 0;
            this.lblResizeHeightTo.Text = "Resize Width To";
            // 
            // lblRecordingTimeInterval
            // 
            this.lblRecordingTimeInterval.AutoSize = true;
            this.lblRecordingTimeInterval.Location = new System.Drawing.Point(22, 274);
            this.lblRecordingTimeInterval.Name = "lblRecordingTimeInterval";
            this.lblRecordingTimeInterval.Size = new System.Drawing.Size(150, 16);
            this.lblRecordingTimeInterval.TabIndex = 2;
            this.lblRecordingTimeInterval.Text = "Graph recording interval";
            // 
            // txtRecordingTimeInterval
            // 
            this.txtRecordingTimeInterval.Location = new System.Drawing.Point(196, 271);
            this.txtRecordingTimeInterval.MaxLength = 5;
            this.txtRecordingTimeInterval.Name = "txtRecordingTimeInterval";
            this.txtRecordingTimeInterval.Size = new System.Drawing.Size(116, 22);
            this.txtRecordingTimeInterval.TabIndex = 3;
            // 
            // lblUnitTimeInterval
            // 
            this.lblUnitTimeInterval.AutoSize = true;
            this.lblUnitTimeInterval.Location = new System.Drawing.Point(323, 274);
            this.lblUnitTimeInterval.Name = "lblUnitTimeInterval";
            this.lblUnitTimeInterval.Size = new System.Drawing.Size(67, 16);
            this.lblUnitTimeInterval.TabIndex = 6;
            this.lblUnitTimeInterval.Text = "second(s)";
            // 
            // chkptbEnableSpeechRecognition
            // 
            this.chkptbEnableSpeechRecognition.AutoSize = true;
            this.chkptbEnableSpeechRecognition.Location = new System.Drawing.Point(78, 325);
            this.chkptbEnableSpeechRecognition.Name = "chkptbEnableSpeechRecognition";
            this.chkptbEnableSpeechRecognition.Size = new System.Drawing.Size(197, 20);
            this.chkptbEnableSpeechRecognition.TabIndex = 8;
            this.chkptbEnableSpeechRecognition.Text = "Enable Speech Recognition";
            this.chkptbEnableSpeechRecognition.UseVisualStyleBackColor = true;
            // 
            // ptbEnableSpeechRecognition
            // 
            this.ptbEnableSpeechRecognition.Image = global::BC.Properties.Resources.SpeechRecognition;
            this.ptbEnableSpeechRecognition.Location = new System.Drawing.Point(25, 317);
            this.ptbEnableSpeechRecognition.Name = "ptbEnableSpeechRecognition";
            this.ptbEnableSpeechRecognition.Size = new System.Drawing.Size(40, 35);
            this.ptbEnableSpeechRecognition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEnableSpeechRecognition.TabIndex = 9;
            this.ptbEnableSpeechRecognition.TabStop = false;
            // 
            // FrmConfig
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(663, 458);
            this.Controls.Add(this.ptbEnableSpeechRecognition);
            this.Controls.Add(this.chkptbEnableSpeechRecognition);
            this.Controls.Add(this.lblUnitTimeInterval);
            this.Controls.Add(this.txtRecordingTimeInterval);
            this.Controls.Add(this.lblRecordingTimeInterval);
            this.Controls.Add(this.gpbResizeGraphics);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gpbConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BC Settings";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.gpbConnection.ResumeLayout(false);
            this.gpbConnection.PerformLayout();
            this.gpbResizeGraphics.ResumeLayout(false);
            this.gpbResizeGraphics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEnableSpeechRecognition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConnection;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gpbResizeGraphics;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtIpAdress;
        private System.Windows.Forms.Label lblIpAdress;
        private System.Windows.Forms.TextBox txtResizeWidthTo;
        private System.Windows.Forms.Label lblResizeWidthTo;
        private System.Windows.Forms.TextBox txtResizeHeightTo;
        private System.Windows.Forms.Label lblResizeHeightTo;
        private System.Windows.Forms.Label lblSamplingFreq;
        private System.Windows.Forms.Label lblHzSamplingFreq;
        private System.Windows.Forms.TextBox txtMacAddress;
        private System.Windows.Forms.Label lblMacAddress;
        private System.Windows.Forms.ComboBox cboSamplingFreq;
        private System.Windows.Forms.Label lblRecordingTimeInterval;
        private System.Windows.Forms.TextBox txtRecordingTimeInterval;
        private System.Windows.Forms.Label lblUnitTimeInterval;
        private System.Windows.Forms.CheckBox chkptbEnableSpeechRecognition;
        private System.Windows.Forms.PictureBox ptbEnableSpeechRecognition;
    }
}