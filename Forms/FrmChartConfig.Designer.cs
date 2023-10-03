namespace BC.Forms
{
    partial class FrmChartConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChartConfig));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSelectChart = new System.Windows.Forms.Label();
            this.cboSelectChart = new System.Windows.Forms.ComboBox();
            this.lblChartJson = new System.Windows.Forms.Label();
            this.rtbJson = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lklRestoreChartConfiguration = new System.Windows.Forms.LinkLabel();
            this.rtbObservation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(401, 717);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 53);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSelectChart
            // 
            this.lblSelectChart.AutoSize = true;
            this.lblSelectChart.Location = new System.Drawing.Point(15, 21);
            this.lblSelectChart.Name = "lblSelectChart";
            this.lblSelectChart.Size = new System.Drawing.Size(100, 16);
            this.lblSelectChart.TabIndex = 0;
            this.lblSelectChart.Text = "Select the Chart";
            // 
            // cboSelectChart
            // 
            this.cboSelectChart.FormattingEnabled = true;
            this.cboSelectChart.Location = new System.Drawing.Point(18, 40);
            this.cboSelectChart.Name = "cboSelectChart";
            this.cboSelectChart.Size = new System.Drawing.Size(213, 24);
            this.cboSelectChart.TabIndex = 1;
            this.cboSelectChart.SelectedIndexChanged += new System.EventHandler(this.cboSelectChart_SelectedIndexChanged);
            // 
            // lblChartJson
            // 
            this.lblChartJson.AutoSize = true;
            this.lblChartJson.Location = new System.Drawing.Point(15, 77);
            this.lblChartJson.Name = "lblChartJson";
            this.lblChartJson.Size = new System.Drawing.Size(207, 16);
            this.lblChartJson.TabIndex = 2;
            this.lblChartJson.Text = "Chart configuration in Json Format";
            // 
            // rtbJson
            // 
            this.rtbJson.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbJson.Location = new System.Drawing.Point(18, 96);
            this.rtbJson.Name = "rtbJson";
            this.rtbJson.Size = new System.Drawing.Size(719, 396);
            this.rtbJson.TabIndex = 3;
            this.rtbJson.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(577, 717);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 53);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lklRestoreChartConfiguration
            // 
            this.lklRestoreChartConfiguration.AutoSize = true;
            this.lklRestoreChartConfiguration.Location = new System.Drawing.Point(310, 77);
            this.lklRestoreChartConfiguration.Name = "lklRestoreChartConfiguration";
            this.lklRestoreChartConfiguration.Size = new System.Drawing.Size(170, 16);
            this.lklRestoreChartConfiguration.TabIndex = 6;
            this.lklRestoreChartConfiguration.TabStop = true;
            this.lklRestoreChartConfiguration.Text = "Restore Chart Configuration";
            this.lklRestoreChartConfiguration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRestoreChartConfiguration_LinkClicked);
            // 
            // rtbObservation
            // 
            this.rtbObservation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbObservation.Location = new System.Drawing.Point(18, 513);
            this.rtbObservation.Name = "rtbObservation";
            this.rtbObservation.ReadOnly = true;
            this.rtbObservation.Size = new System.Drawing.Size(719, 193);
            this.rtbObservation.TabIndex = 7;
            this.rtbObservation.Text = resources.GetString("rtbObservation.Text");
            // 
            // FrmChartConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(757, 786);
            this.Controls.Add(this.rtbObservation);
            this.Controls.Add(this.lklRestoreChartConfiguration);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbJson);
            this.Controls.Add(this.lblChartJson);
            this.Controls.Add(this.cboSelectChart);
            this.Controls.Add(this.lblSelectChart);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmChartConfig";
            this.Text = "Chart Configuration";
            this.Load += new System.EventHandler(this.FrmChartConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSelectChart;
        private System.Windows.Forms.ComboBox cboSelectChart;
        private System.Windows.Forms.Label lblChartJson;
        private System.Windows.Forms.RichTextBox rtbJson;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lklRestoreChartConfiguration;
        private System.Windows.Forms.RichTextBox rtbObservation;
    }
}