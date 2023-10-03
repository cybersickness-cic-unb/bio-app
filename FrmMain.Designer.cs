namespace BC
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbLogCollection = new System.Windows.Forms.GroupBox();
            this.rtbLogCollection = new System.Windows.Forms.RichTextBox();
            this.lklOpenLogFile = new System.Windows.Forms.LinkLabel();
            this.lblOpenLogFolder = new System.Windows.Forms.LinkLabel();
            this.chkAutomaticSaveChart = new System.Windows.Forms.CheckBox();
            this.pnlStatusServiceCollection = new System.Windows.Forms.Panel();
            this.lblCollectionStatus = new System.Windows.Forms.Label();
            this.btnStopCollection = new System.Windows.Forms.Button();
            this.btnStartCollection = new System.Windows.Forms.Button();
            this.gpbCollectionController = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.gpbSensors = new System.Windows.Forms.GroupBox();
            this.lklVisualizeMapping = new System.Windows.Forms.LinkLabel();
            this.lblChannel2 = new System.Windows.Forms.Label();
            this.lblChannel1 = new System.Windows.Forms.Label();
            this.cboChannelACC = new System.Windows.Forms.ComboBox();
            this.cboChannelEDA = new System.Windows.Forms.ComboBox();
            this.cboChannelEMG = new System.Windows.Forms.ComboBox();
            this.cboChannelEGG = new System.Windows.Forms.ComboBox();
            this.cboChannelEEG = new System.Windows.Forms.ComboBox();
            this.cboChannelECG = new System.Windows.Forms.ComboBox();
            this.chkACC = new System.Windows.Forms.CheckBox();
            this.chkEMG = new System.Windows.Forms.CheckBox();
            this.chkEEG = new System.Windows.Forms.CheckBox();
            this.chkEDA = new System.Windows.Forms.CheckBox();
            this.chkEGG = new System.Windows.Forms.CheckBox();
            this.chkECG = new System.Windows.Forms.CheckBox();
            this.lklRemoveAllRecordedBiosignals = new System.Windows.Forms.LinkLabel();
            this.lklOpenFolderCollectedData = new System.Windows.Forms.LinkLabel();
            this.chkAutomaticGenerateOutputToFile = new System.Windows.Forms.CheckBox();
            this.lklOpenFoldersSavedCharts = new System.Windows.Forms.LinkLabel();
            this.rdbSaveResizedImage = new System.Windows.Forms.RadioButton();
            this.rdbSaveOriginalImage = new System.Windows.Forms.RadioButton();
            this.gpbLevelOfCS = new System.Windows.Forms.GroupBox();
            this.rdbLevel3 = new System.Windows.Forms.RadioButton();
            this.rdbLevel2 = new System.Windows.Forms.RadioButton();
            this.rdbLevel1 = new System.Windows.Forms.RadioButton();
            this.rdbLevel0 = new System.Windows.Forms.RadioButton();
            this.lblIPadress = new System.Windows.Forms.Label();
            this.txtIPadress = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblDeviceMacAddress = new System.Windows.Forms.Label();
            this.txtDeviceMacAddress = new System.Windows.Forms.TextBox();
            this.lblFreq = new System.Windows.Forms.Label();
            this.txtSamplingFreq = new System.Windows.Forms.TextBox();
            this.lblHzFreq = new System.Windows.Forms.Label();
            this.mnsConfig = new System.Windows.Forms.MenuStrip();
            this.mniSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.mniChartSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mniProcessData = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConvertGameDataWeka = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniChangeTheLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbEnableSpeechRecognition = new System.Windows.Forms.PictureBox();
            this.gpbLogCollection.SuspendLayout();
            this.gpbCollectionController.SuspendLayout();
            this.gpbSensors.SuspendLayout();
            this.gpbLevelOfCS.SuspendLayout();
            this.mnsConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEnableSpeechRecognition)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(712, 837);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 53);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gpbLogCollection
            // 
            this.gpbLogCollection.Controls.Add(this.rtbLogCollection);
            this.gpbLogCollection.Controls.Add(this.lklOpenLogFile);
            this.gpbLogCollection.Controls.Add(this.lblOpenLogFolder);
            this.gpbLogCollection.Location = new System.Drawing.Point(18, 410);
            this.gpbLogCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbLogCollection.Name = "gpbLogCollection";
            this.gpbLogCollection.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbLogCollection.Size = new System.Drawing.Size(845, 416);
            this.gpbLogCollection.TabIndex = 3;
            this.gpbLogCollection.TabStop = false;
            this.gpbLogCollection.Text = "Log Collection";
            // 
            // rtbLogCollection
            // 
            this.rtbLogCollection.BackColor = System.Drawing.Color.Navy;
            this.rtbLogCollection.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLogCollection.ForeColor = System.Drawing.Color.White;
            this.rtbLogCollection.Location = new System.Drawing.Point(9, 53);
            this.rtbLogCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbLogCollection.Name = "rtbLogCollection";
            this.rtbLogCollection.Size = new System.Drawing.Size(823, 349);
            this.rtbLogCollection.TabIndex = 2;
            this.rtbLogCollection.Text = "";
            // 
            // lklOpenLogFile
            // 
            this.lklOpenLogFile.AutoSize = true;
            this.lklOpenLogFile.Location = new System.Drawing.Point(6, 30);
            this.lklOpenLogFile.Name = "lklOpenLogFile";
            this.lklOpenLogFile.Size = new System.Drawing.Size(91, 16);
            this.lklOpenLogFile.TabIndex = 0;
            this.lklOpenLogFile.TabStop = true;
            this.lklOpenLogFile.Text = "Open Log File";
            this.lklOpenLogFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklOpenLogFile_LinkClicked);
            // 
            // lblOpenLogFolder
            // 
            this.lblOpenLogFolder.AutoSize = true;
            this.lblOpenLogFolder.Location = new System.Drawing.Point(228, 30);
            this.lblOpenLogFolder.Name = "lblOpenLogFolder";
            this.lblOpenLogFolder.Size = new System.Drawing.Size(108, 16);
            this.lblOpenLogFolder.TabIndex = 1;
            this.lblOpenLogFolder.TabStop = true;
            this.lblOpenLogFolder.Text = "Open Log Folder";
            this.lblOpenLogFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOpenLogFolder_LinkClicked);
            // 
            // chkAutomaticSaveChart
            // 
            this.chkAutomaticSaveChart.AutoSize = true;
            this.chkAutomaticSaveChart.Checked = true;
            this.chkAutomaticSaveChart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutomaticSaveChart.Location = new System.Drawing.Point(13, 138);
            this.chkAutomaticSaveChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAutomaticSaveChart.Name = "chkAutomaticSaveChart";
            this.chkAutomaticSaveChart.Size = new System.Drawing.Size(157, 20);
            this.chkAutomaticSaveChart.TabIndex = 4;
            this.chkAutomaticSaveChart.Text = "Automatic Save Chart";
            this.chkAutomaticSaveChart.UseVisualStyleBackColor = true;
            this.chkAutomaticSaveChart.Click += new System.EventHandler(this.chkAutomaticSaveChart_Click);
            // 
            // pnlStatusServiceCollection
            // 
            this.pnlStatusServiceCollection.Location = new System.Drawing.Point(67, 28);
            this.pnlStatusServiceCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlStatusServiceCollection.Name = "pnlStatusServiceCollection";
            this.pnlStatusServiceCollection.Size = new System.Drawing.Size(757, 26);
            this.pnlStatusServiceCollection.TabIndex = 1;
            // 
            // lblCollectionStatus
            // 
            this.lblCollectionStatus.AutoSize = true;
            this.lblCollectionStatus.Location = new System.Drawing.Point(13, 33);
            this.lblCollectionStatus.Name = "lblCollectionStatus";
            this.lblCollectionStatus.Size = new System.Drawing.Size(44, 16);
            this.lblCollectionStatus.TabIndex = 0;
            this.lblCollectionStatus.Text = "Status";
            // 
            // btnStopCollection
            // 
            this.btnStopCollection.Location = new System.Drawing.Point(676, 180);
            this.btnStopCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStopCollection.Name = "btnStopCollection";
            this.btnStopCollection.Size = new System.Drawing.Size(147, 35);
            this.btnStopCollection.TabIndex = 10;
            this.btnStopCollection.Text = "Stop Collection";
            this.btnStopCollection.UseVisualStyleBackColor = true;
            this.btnStopCollection.Click += new System.EventHandler(this.btnStopCollection_Click);
            // 
            // btnStartCollection
            // 
            this.btnStartCollection.Location = new System.Drawing.Point(676, 142);
            this.btnStartCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartCollection.Name = "btnStartCollection";
            this.btnStartCollection.Size = new System.Drawing.Size(147, 35);
            this.btnStartCollection.TabIndex = 9;
            this.btnStartCollection.Text = "Start Collection";
            this.btnStartCollection.UseVisualStyleBackColor = true;
            this.btnStartCollection.Click += new System.EventHandler(this.btnStartCollection_Click);
            // 
            // gpbCollectionController
            // 
            this.gpbCollectionController.Controls.Add(this.lblTime);
            this.gpbCollectionController.Controls.Add(this.btnStartRecording);
            this.gpbCollectionController.Controls.Add(this.gpbSensors);
            this.gpbCollectionController.Controls.Add(this.lklRemoveAllRecordedBiosignals);
            this.gpbCollectionController.Controls.Add(this.lklOpenFolderCollectedData);
            this.gpbCollectionController.Controls.Add(this.chkAutomaticGenerateOutputToFile);
            this.gpbCollectionController.Controls.Add(this.lklOpenFoldersSavedCharts);
            this.gpbCollectionController.Controls.Add(this.btnStartCollection);
            this.gpbCollectionController.Controls.Add(this.rdbSaveResizedImage);
            this.gpbCollectionController.Controls.Add(this.rdbSaveOriginalImage);
            this.gpbCollectionController.Controls.Add(this.chkAutomaticSaveChart);
            this.gpbCollectionController.Controls.Add(this.lblCollectionStatus);
            this.gpbCollectionController.Controls.Add(this.btnStopCollection);
            this.gpbCollectionController.Controls.Add(this.pnlStatusServiceCollection);
            this.gpbCollectionController.Location = new System.Drawing.Point(18, 74);
            this.gpbCollectionController.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbCollectionController.Name = "gpbCollectionController";
            this.gpbCollectionController.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbCollectionController.Size = new System.Drawing.Size(845, 253);
            this.gpbCollectionController.TabIndex = 10;
            this.gpbCollectionController.TabStop = false;
            this.gpbCollectionController.Text = "Collection Controller";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(708, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 20);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "lblTime";
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.BackColor = System.Drawing.Color.LightGreen;
            this.btnStartRecording.ForeColor = System.Drawing.Color.Black;
            this.btnStartRecording.Location = new System.Drawing.Point(675, 92);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(147, 44);
            this.btnStartRecording.TabIndex = 12;
            this.btnStartRecording.Text = "Start Recording";
            this.btnStartRecording.UseVisualStyleBackColor = false;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // gpbSensors
            // 
            this.gpbSensors.Controls.Add(this.lklVisualizeMapping);
            this.gpbSensors.Controls.Add(this.lblChannel2);
            this.gpbSensors.Controls.Add(this.lblChannel1);
            this.gpbSensors.Controls.Add(this.cboChannelACC);
            this.gpbSensors.Controls.Add(this.cboChannelEDA);
            this.gpbSensors.Controls.Add(this.cboChannelEMG);
            this.gpbSensors.Controls.Add(this.cboChannelEGG);
            this.gpbSensors.Controls.Add(this.cboChannelEEG);
            this.gpbSensors.Controls.Add(this.cboChannelECG);
            this.gpbSensors.Controls.Add(this.chkACC);
            this.gpbSensors.Controls.Add(this.chkEMG);
            this.gpbSensors.Controls.Add(this.chkEEG);
            this.gpbSensors.Controls.Add(this.chkEDA);
            this.gpbSensors.Controls.Add(this.chkEGG);
            this.gpbSensors.Controls.Add(this.chkECG);
            this.gpbSensors.Location = new System.Drawing.Point(368, 65);
            this.gpbSensors.Name = "gpbSensors";
            this.gpbSensors.Size = new System.Drawing.Size(302, 150);
            this.gpbSensors.TabIndex = 7;
            this.gpbSensors.TabStop = false;
            this.gpbSensors.Text = "Capture sensor data";
            // 
            // lklVisualizeMapping
            // 
            this.lklVisualizeMapping.AutoSize = true;
            this.lklVisualizeMapping.Location = new System.Drawing.Point(10, 126);
            this.lklVisualizeMapping.Name = "lklVisualizeMapping";
            this.lklVisualizeMapping.Size = new System.Drawing.Size(117, 16);
            this.lklVisualizeMapping.TabIndex = 14;
            this.lklVisualizeMapping.TabStop = true;
            this.lklVisualizeMapping.Text = "Visualize Mapping";
            this.lklVisualizeMapping.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklVisualizeMapping_LinkClicked);
            // 
            // lblChannel2
            // 
            this.lblChannel2.AutoSize = true;
            this.lblChannel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChannel2.Location = new System.Drawing.Point(220, 24);
            this.lblChannel2.Name = "lblChannel2";
            this.lblChannel2.Size = new System.Drawing.Size(54, 16);
            this.lblChannel2.TabIndex = 13;
            this.lblChannel2.Text = "channel";
            // 
            // lblChannel1
            // 
            this.lblChannel1.AutoSize = true;
            this.lblChannel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChannel1.Location = new System.Drawing.Point(78, 24);
            this.lblChannel1.Name = "lblChannel1";
            this.lblChannel1.Size = new System.Drawing.Size(54, 16);
            this.lblChannel1.TabIndex = 12;
            this.lblChannel1.Text = "channel";
            // 
            // cboChannelACC
            // 
            this.cboChannelACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChannelACC.FormattingEnabled = true;
            this.cboChannelACC.Location = new System.Drawing.Point(223, 98);
            this.cboChannelACC.Name = "cboChannelACC";
            this.cboChannelACC.Size = new System.Drawing.Size(67, 23);
            this.cboChannelACC.TabIndex = 11;
            this.cboChannelACC.SelectionChangeCommitted += new System.EventHandler(this.cboChannelACC_SelectionChangeCommitted);
            // 
            // cboChannelEDA
            // 
            this.cboChannelEDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChannelEDA.FormattingEnabled = true;
            this.cboChannelEDA.Location = new System.Drawing.Point(81, 98);
            this.cboChannelEDA.Name = "cboChannelEDA";
            this.cboChannelEDA.Size = new System.Drawing.Size(67, 23);
            this.cboChannelEDA.TabIndex = 10;
            this.cboChannelEDA.SelectionChangeCommitted += new System.EventHandler(this.cboChannelEDA_SelectionChangeCommitted);
            // 
            // cboChannelEMG
            // 
            this.cboChannelEMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChannelEMG.FormattingEnabled = true;
            this.cboChannelEMG.Location = new System.Drawing.Point(223, 71);
            this.cboChannelEMG.Name = "cboChannelEMG";
            this.cboChannelEMG.Size = new System.Drawing.Size(67, 23);
            this.cboChannelEMG.TabIndex = 9;
            this.cboChannelEMG.SelectionChangeCommitted += new System.EventHandler(this.cboChannelEMG_SelectionChangeCommitted);
            // 
            // cboChannelEGG
            // 
            this.cboChannelEGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChannelEGG.FormattingEnabled = true;
            this.cboChannelEGG.Location = new System.Drawing.Point(81, 71);
            this.cboChannelEGG.Name = "cboChannelEGG";
            this.cboChannelEGG.Size = new System.Drawing.Size(67, 23);
            this.cboChannelEGG.TabIndex = 8;
            this.cboChannelEGG.SelectionChangeCommitted += new System.EventHandler(this.cboChannelEGG_SelectionChangeCommitted);
            // 
            // cboChannelEEG
            // 
            this.cboChannelEEG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChannelEEG.FormattingEnabled = true;
            this.cboChannelEEG.Location = new System.Drawing.Point(223, 44);
            this.cboChannelEEG.Name = "cboChannelEEG";
            this.cboChannelEEG.Size = new System.Drawing.Size(67, 23);
            this.cboChannelEEG.TabIndex = 7;
            this.cboChannelEEG.SelectionChangeCommitted += new System.EventHandler(this.cboChannelEEG_SelectionChangeCommitted);
            // 
            // cboChannelECG
            // 
            this.cboChannelECG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChannelECG.FormattingEnabled = true;
            this.cboChannelECG.ItemHeight = 15;
            this.cboChannelECG.Location = new System.Drawing.Point(81, 44);
            this.cboChannelECG.Name = "cboChannelECG";
            this.cboChannelECG.Size = new System.Drawing.Size(67, 23);
            this.cboChannelECG.TabIndex = 6;
            this.cboChannelECG.SelectionChangeCommitted += new System.EventHandler(this.cboChannelECG_SelectionChangeCommitted);
            // 
            // chkACC
            // 
            this.chkACC.AutoSize = true;
            this.chkACC.Checked = true;
            this.chkACC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkACC.Enabled = false;
            this.chkACC.Location = new System.Drawing.Point(160, 100);
            this.chkACC.Name = "chkACC";
            this.chkACC.Size = new System.Drawing.Size(56, 20);
            this.chkACC.TabIndex = 5;
            this.chkACC.Text = "ACC";
            this.chkACC.UseVisualStyleBackColor = true;
            this.chkACC.Click += new System.EventHandler(this.chkACC_Click);
            // 
            // chkEMG
            // 
            this.chkEMG.AutoSize = true;
            this.chkEMG.Checked = true;
            this.chkEMG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEMG.Enabled = false;
            this.chkEMG.Location = new System.Drawing.Point(160, 75);
            this.chkEMG.Name = "chkEMG";
            this.chkEMG.Size = new System.Drawing.Size(59, 20);
            this.chkEMG.TabIndex = 3;
            this.chkEMG.Text = "EMG";
            this.chkEMG.UseVisualStyleBackColor = true;
            this.chkEMG.Click += new System.EventHandler(this.chkEMG_Click);
            // 
            // chkEEG
            // 
            this.chkEEG.AutoSize = true;
            this.chkEEG.Checked = true;
            this.chkEEG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEEG.Enabled = false;
            this.chkEEG.Location = new System.Drawing.Point(160, 48);
            this.chkEEG.Name = "chkEEG";
            this.chkEEG.Size = new System.Drawing.Size(57, 20);
            this.chkEEG.TabIndex = 1;
            this.chkEEG.Text = "EEG";
            this.chkEEG.UseVisualStyleBackColor = true;
            this.chkEEG.Click += new System.EventHandler(this.chkEEG_Click);
            // 
            // chkEDA
            // 
            this.chkEDA.AutoSize = true;
            this.chkEDA.Checked = true;
            this.chkEDA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEDA.Enabled = false;
            this.chkEDA.Location = new System.Drawing.Point(13, 100);
            this.chkEDA.Name = "chkEDA";
            this.chkEDA.Size = new System.Drawing.Size(57, 20);
            this.chkEDA.TabIndex = 4;
            this.chkEDA.Text = "EDA";
            this.chkEDA.UseVisualStyleBackColor = true;
            this.chkEDA.Click += new System.EventHandler(this.chkEDA_Click);
            // 
            // chkEGG
            // 
            this.chkEGG.AutoSize = true;
            this.chkEGG.Checked = true;
            this.chkEGG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEGG.Enabled = false;
            this.chkEGG.Location = new System.Drawing.Point(13, 75);
            this.chkEGG.Name = "chkEGG";
            this.chkEGG.Size = new System.Drawing.Size(58, 20);
            this.chkEGG.TabIndex = 2;
            this.chkEGG.Text = "EGG";
            this.chkEGG.UseVisualStyleBackColor = true;
            this.chkEGG.Click += new System.EventHandler(this.chkEGG_Click);
            // 
            // chkECG
            // 
            this.chkECG.AutoSize = true;
            this.chkECG.Checked = true;
            this.chkECG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkECG.Enabled = false;
            this.chkECG.Location = new System.Drawing.Point(13, 48);
            this.chkECG.Name = "chkECG";
            this.chkECG.Size = new System.Drawing.Size(57, 20);
            this.chkECG.TabIndex = 0;
            this.chkECG.Text = "ECG";
            this.chkECG.UseVisualStyleBackColor = true;
            this.chkECG.Click += new System.EventHandler(this.chkECG_Click);
            // 
            // lklRemoveAllRecordedBiosignals
            // 
            this.lklRemoveAllRecordedBiosignals.AutoSize = true;
            this.lklRemoveAllRecordedBiosignals.Location = new System.Drawing.Point(10, 223);
            this.lklRemoveAllRecordedBiosignals.Name = "lklRemoveAllRecordedBiosignals";
            this.lklRemoveAllRecordedBiosignals.Size = new System.Drawing.Size(207, 16);
            this.lklRemoveAllRecordedBiosignals.TabIndex = 6;
            this.lklRemoveAllRecordedBiosignals.TabStop = true;
            this.lklRemoveAllRecordedBiosignals.Text = "Remove All Recorded Biosignals";
            this.lklRemoveAllRecordedBiosignals.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRemoveAllRecordedBiosignals_LinkClicked);
            // 
            // lklOpenFolderCollectedData
            // 
            this.lklOpenFolderCollectedData.AutoSize = true;
            this.lklOpenFolderCollectedData.Location = new System.Drawing.Point(612, 224);
            this.lklOpenFolderCollectedData.Name = "lklOpenFolderCollectedData";
            this.lklOpenFolderCollectedData.Size = new System.Drawing.Size(188, 16);
            this.lklOpenFolderCollectedData.TabIndex = 11;
            this.lklOpenFolderCollectedData.TabStop = true;
            this.lklOpenFolderCollectedData.Text = "Open Folder of Collected Data";
            this.lklOpenFolderCollectedData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklOpenFolderWithCollectedData_LinkClicked);
            // 
            // chkAutomaticGenerateOutputToFile
            // 
            this.chkAutomaticGenerateOutputToFile.AutoSize = true;
            this.chkAutomaticGenerateOutputToFile.Checked = true;
            this.chkAutomaticGenerateOutputToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutomaticGenerateOutputToFile.Location = new System.Drawing.Point(13, 172);
            this.chkAutomaticGenerateOutputToFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAutomaticGenerateOutputToFile.Name = "chkAutomaticGenerateOutputToFile";
            this.chkAutomaticGenerateOutputToFile.Size = new System.Drawing.Size(254, 20);
            this.chkAutomaticGenerateOutputToFile.TabIndex = 5;
            this.chkAutomaticGenerateOutputToFile.Text = "Automatically Generate Output To File";
            this.chkAutomaticGenerateOutputToFile.UseVisualStyleBackColor = true;
            this.chkAutomaticGenerateOutputToFile.Click += new System.EventHandler(this.chkAutomaticGenerateOutputToFile_Click);
            // 
            // lklOpenFoldersSavedCharts
            // 
            this.lklOpenFoldersSavedCharts.AutoSize = true;
            this.lklOpenFoldersSavedCharts.Location = new System.Drawing.Point(319, 223);
            this.lklOpenFoldersSavedCharts.Name = "lklOpenFoldersSavedCharts";
            this.lklOpenFoldersSavedCharts.Size = new System.Drawing.Size(187, 16);
            this.lklOpenFoldersSavedCharts.TabIndex = 8;
            this.lklOpenFoldersSavedCharts.TabStop = true;
            this.lklOpenFoldersSavedCharts.Text = "Open Folders of Saved Charts";
            this.lklOpenFoldersSavedCharts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklOpenFolderWithCapturedPrintScreen_LinkClicked);
            // 
            // rdbSaveResizedImage
            // 
            this.rdbSaveResizedImage.AutoSize = true;
            this.rdbSaveResizedImage.Location = new System.Drawing.Point(13, 104);
            this.rdbSaveResizedImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSaveResizedImage.Name = "rdbSaveResizedImage";
            this.rdbSaveResizedImage.Size = new System.Drawing.Size(174, 20);
            this.rdbSaveResizedImage.TabIndex = 3;
            this.rdbSaveResizedImage.Text = "Save captured image at:";
            this.rdbSaveResizedImage.UseVisualStyleBackColor = true;
            this.rdbSaveResizedImage.Click += new System.EventHandler(this.rdbSaveResizedImage_Click);
            // 
            // rdbSaveOriginalImage
            // 
            this.rdbSaveOriginalImage.AutoSize = true;
            this.rdbSaveOriginalImage.Checked = true;
            this.rdbSaveOriginalImage.Location = new System.Drawing.Point(13, 70);
            this.rdbSaveOriginalImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSaveOriginalImage.Name = "rdbSaveOriginalImage";
            this.rdbSaveOriginalImage.Size = new System.Drawing.Size(309, 20);
            this.rdbSaveOriginalImage.TabIndex = 2;
            this.rdbSaveOriginalImage.TabStop = true;
            this.rdbSaveOriginalImage.Text = "Save captured image in original size (814 x 224)";
            this.rdbSaveOriginalImage.UseVisualStyleBackColor = true;
            this.rdbSaveOriginalImage.Click += new System.EventHandler(this.rdbSaveOriginalImage_Click);
            // 
            // gpbLevelOfCS
            // 
            this.gpbLevelOfCS.Controls.Add(this.ptbEnableSpeechRecognition);
            this.gpbLevelOfCS.Controls.Add(this.rdbLevel3);
            this.gpbLevelOfCS.Controls.Add(this.rdbLevel2);
            this.gpbLevelOfCS.Controls.Add(this.rdbLevel1);
            this.gpbLevelOfCS.Controls.Add(this.rdbLevel0);
            this.gpbLevelOfCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLevelOfCS.Location = new System.Drawing.Point(19, 333);
            this.gpbLevelOfCS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbLevelOfCS.Name = "gpbLevelOfCS";
            this.gpbLevelOfCS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbLevelOfCS.Size = new System.Drawing.Size(845, 69);
            this.gpbLevelOfCS.TabIndex = 2;
            this.gpbLevelOfCS.TabStop = false;
            this.gpbLevelOfCS.Text = "Level Of CS";
            // 
            // rdbLevel3
            // 
            this.rdbLevel3.AutoSize = true;
            this.rdbLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLevel3.Location = new System.Drawing.Point(609, 30);
            this.rdbLevel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbLevel3.Name = "rdbLevel3";
            this.rdbLevel3.Size = new System.Drawing.Size(153, 24);
            this.rdbLevel3.TabIndex = 3;
            this.rdbLevel3.Text = "Level 3 (Severe)";
            this.rdbLevel3.UseVisualStyleBackColor = true;
            // 
            // rdbLevel2
            // 
            this.rdbLevel2.AutoSize = true;
            this.rdbLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLevel2.ForeColor = System.Drawing.Color.Red;
            this.rdbLevel2.Location = new System.Drawing.Point(388, 30);
            this.rdbLevel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbLevel2.Name = "rdbLevel2";
            this.rdbLevel2.Size = new System.Drawing.Size(171, 24);
            this.rdbLevel2.TabIndex = 2;
            this.rdbLevel2.Text = "Level 2 (Moderate)";
            this.rdbLevel2.UseVisualStyleBackColor = true;
            // 
            // rdbLevel1
            // 
            this.rdbLevel1.AutoSize = true;
            this.rdbLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLevel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdbLevel1.Location = new System.Drawing.Point(206, 30);
            this.rdbLevel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbLevel1.Name = "rdbLevel1";
            this.rdbLevel1.Size = new System.Drawing.Size(132, 24);
            this.rdbLevel1.TabIndex = 1;
            this.rdbLevel1.Text = "Level 1 (Mild)";
            this.rdbLevel1.UseVisualStyleBackColor = true;
            // 
            // rdbLevel0
            // 
            this.rdbLevel0.AutoSize = true;
            this.rdbLevel0.Checked = true;
            this.rdbLevel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLevel0.ForeColor = System.Drawing.Color.Gray;
            this.rdbLevel0.Location = new System.Drawing.Point(19, 30);
            this.rdbLevel0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbLevel0.Name = "rdbLevel0";
            this.rdbLevel0.Size = new System.Drawing.Size(137, 24);
            this.rdbLevel0.TabIndex = 0;
            this.rdbLevel0.TabStop = true;
            this.rdbLevel0.Text = "Level 0 (none)";
            this.rdbLevel0.UseVisualStyleBackColor = true;
            // 
            // lblIPadress
            // 
            this.lblIPadress.AutoSize = true;
            this.lblIPadress.Location = new System.Drawing.Point(21, 43);
            this.lblIPadress.Name = "lblIPadress";
            this.lblIPadress.Size = new System.Drawing.Size(65, 16);
            this.lblIPadress.TabIndex = 0;
            this.lblIPadress.Text = "IP Adress";
            // 
            // txtIPadress
            // 
            this.txtIPadress.Location = new System.Drawing.Point(118, 41);
            this.txtIPadress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIPadress.Name = "txtIPadress";
            this.txtIPadress.ReadOnly = true;
            this.txtIPadress.Size = new System.Drawing.Size(136, 22);
            this.txtIPadress.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(288, 43);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 16);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(343, 39);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(65, 22);
            this.txtPort.TabIndex = 3;
            // 
            // lblDeviceMacAddress
            // 
            this.lblDeviceMacAddress.AutoSize = true;
            this.lblDeviceMacAddress.Location = new System.Drawing.Point(433, 43);
            this.lblDeviceMacAddress.Name = "lblDeviceMacAddress";
            this.lblDeviceMacAddress.Size = new System.Drawing.Size(81, 16);
            this.lblDeviceMacAddress.TabIndex = 4;
            this.lblDeviceMacAddress.Text = "Device (MA)";
            // 
            // txtDeviceMacAddress
            // 
            this.txtDeviceMacAddress.Location = new System.Drawing.Point(542, 39);
            this.txtDeviceMacAddress.Name = "txtDeviceMacAddress";
            this.txtDeviceMacAddress.ReadOnly = true;
            this.txtDeviceMacAddress.Size = new System.Drawing.Size(174, 22);
            this.txtDeviceMacAddress.TabIndex = 5;
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(748, 43);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(35, 16);
            this.lblFreq.TabIndex = 6;
            this.lblFreq.Text = "Freq";
            // 
            // txtSamplingFreq
            // 
            this.txtSamplingFreq.Location = new System.Drawing.Point(787, 39);
            this.txtSamplingFreq.Name = "txtSamplingFreq";
            this.txtSamplingFreq.ReadOnly = true;
            this.txtSamplingFreq.Size = new System.Drawing.Size(51, 22);
            this.txtSamplingFreq.TabIndex = 7;
            // 
            // lblHzFreq
            // 
            this.lblHzFreq.AutoSize = true;
            this.lblHzFreq.Location = new System.Drawing.Point(842, 43);
            this.lblHzFreq.Name = "lblHzFreq";
            this.lblHzFreq.Size = new System.Drawing.Size(23, 16);
            this.lblHzFreq.TabIndex = 8;
            this.lblHzFreq.Text = "Hz";
            // 
            // mnsConfig
            // 
            this.mnsConfig.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSettings,
            this.mniProcessData,
            this.mniExit});
            this.mnsConfig.Location = new System.Drawing.Point(0, 0);
            this.mnsConfig.Name = "mnsConfig";
            this.mnsConfig.Size = new System.Drawing.Size(882, 28);
            this.mnsConfig.TabIndex = 11;
            this.mnsConfig.Text = "menuStrip1";
            // 
            // mniSettings
            // 
            this.mniSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGeneral,
            this.mniChartSetting,
            this.mniChangeTheLanguage});
            this.mniSettings.Name = "mniSettings";
            this.mniSettings.Size = new System.Drawing.Size(76, 24);
            this.mniSettings.Text = "&Settings";
            // 
            // mniGeneral
            // 
            this.mniGeneral.Name = "mniGeneral";
            this.mniGeneral.Size = new System.Drawing.Size(236, 26);
            this.mniGeneral.Text = "&General";
            this.mniGeneral.Click += new System.EventHandler(this.mniGeneral_Click);
            // 
            // mniChartSetting
            // 
            this.mniChartSetting.Name = "mniChartSetting";
            this.mniChartSetting.Size = new System.Drawing.Size(236, 26);
            this.mniChartSetting.Text = "&Chart Setting";
            this.mniChartSetting.Click += new System.EventHandler(this.mniChartSetting_Click);
            // 
            // mniProcessData
            // 
            this.mniProcessData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniConvertGameDataWeka});
            this.mniProcessData.Name = "mniProcessData";
            this.mniProcessData.Size = new System.Drawing.Size(108, 24);
            this.mniProcessData.Text = "&Process Data";
            // 
            // mniConvertGameDataWeka
            // 
            this.mniConvertGameDataWeka.Name = "mniConvertGameDataWeka";
            this.mniConvertGameDataWeka.Size = new System.Drawing.Size(282, 26);
            this.mniConvertGameDataWeka.Text = "Convert Game Data -> Weka";
            this.mniConvertGameDataWeka.Click += new System.EventHandler(this.mniConvertGameDataWeka_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(47, 24);
            this.mniExit.Text = "&Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniChangeTheLanguage
            // 
            this.mniChangeTheLanguage.Name = "mniChangeTheLanguage";
            this.mniChangeTheLanguage.Size = new System.Drawing.Size(236, 26);
            this.mniChangeTheLanguage.Text = "Change the Language";
            this.mniChangeTheLanguage.Click += new System.EventHandler(this.mniChangeTheLanguage_Click);
            // 
            // ptbEnableSpeechRecognition
            // 
            this.ptbEnableSpeechRecognition.Image = global::BC.Properties.Resources.SpeechRecognition;
            this.ptbEnableSpeechRecognition.Location = new System.Drawing.Point(788, 22);
            this.ptbEnableSpeechRecognition.Name = "ptbEnableSpeechRecognition";
            this.ptbEnableSpeechRecognition.Size = new System.Drawing.Size(47, 37);
            this.ptbEnableSpeechRecognition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEnableSpeechRecognition.TabIndex = 12;
            this.ptbEnableSpeechRecognition.TabStop = false;
            this.ptbEnableSpeechRecognition.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 904);
            this.Controls.Add(this.lblHzFreq);
            this.Controls.Add(this.txtSamplingFreq);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.txtDeviceMacAddress);
            this.Controls.Add(this.lblDeviceMacAddress);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtIPadress);
            this.Controls.Add(this.lblIPadress);
            this.Controls.Add(this.gpbLevelOfCS);
            this.Controls.Add(this.gpbCollectionController);
            this.Controls.Add(this.gpbLogCollection);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.mnsConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsConfig;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "BC - Biosignal Collector";
            this.gpbLogCollection.ResumeLayout(false);
            this.gpbLogCollection.PerformLayout();
            this.gpbCollectionController.ResumeLayout(false);
            this.gpbCollectionController.PerformLayout();
            this.gpbSensors.ResumeLayout(false);
            this.gpbSensors.PerformLayout();
            this.gpbLevelOfCS.ResumeLayout(false);
            this.gpbLevelOfCS.PerformLayout();
            this.mnsConfig.ResumeLayout(false);
            this.mnsConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEnableSpeechRecognition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gpbLogCollection;
        private System.Windows.Forms.CheckBox chkAutomaticSaveChart;
        private System.Windows.Forms.LinkLabel lblOpenLogFolder;
        private System.Windows.Forms.RichTextBox rtbLogCollection;
        private System.Windows.Forms.Panel pnlStatusServiceCollection;
        private System.Windows.Forms.Label lblCollectionStatus;
        private System.Windows.Forms.Button btnStopCollection;
        private System.Windows.Forms.Button btnStartCollection;
        private System.Windows.Forms.LinkLabel lklOpenLogFile;
        private System.Windows.Forms.GroupBox gpbCollectionController;
        private System.Windows.Forms.GroupBox gpbLevelOfCS;
        private System.Windows.Forms.RadioButton rdbLevel3;
        private System.Windows.Forms.RadioButton rdbLevel2;
        private System.Windows.Forms.RadioButton rdbLevel1;
        private System.Windows.Forms.RadioButton rdbLevel0;
        private System.Windows.Forms.RadioButton rdbSaveResizedImage;
        private System.Windows.Forms.RadioButton rdbSaveOriginalImage;
        private System.Windows.Forms.LinkLabel lklOpenFolderCollectedData;
        private System.Windows.Forms.CheckBox chkAutomaticGenerateOutputToFile;
        private System.Windows.Forms.LinkLabel lklOpenFoldersSavedCharts;
        private System.Windows.Forms.Label lblIPadress;
        private System.Windows.Forms.TextBox txtIPadress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblDeviceMacAddress;
        private System.Windows.Forms.TextBox txtDeviceMacAddress;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.TextBox txtSamplingFreq;
        private System.Windows.Forms.Label lblHzFreq;
        private System.Windows.Forms.LinkLabel lklRemoveAllRecordedBiosignals;
        private System.Windows.Forms.GroupBox gpbSensors;
        private System.Windows.Forms.CheckBox chkACC;
        private System.Windows.Forms.CheckBox chkEMG;
        private System.Windows.Forms.CheckBox chkEEG;
        private System.Windows.Forms.CheckBox chkEDA;
        private System.Windows.Forms.CheckBox chkEGG;
        private System.Windows.Forms.CheckBox chkECG;
        private System.Windows.Forms.MenuStrip mnsConfig;
        private System.Windows.Forms.ToolStripMenuItem mniSettings;
        private System.Windows.Forms.ToolStripMenuItem mniChartSetting;
        private System.Windows.Forms.ToolStripMenuItem mniGeneral;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniProcessData;
        private System.Windows.Forms.ToolStripMenuItem mniConvertGameDataWeka;
        private System.Windows.Forms.ComboBox cboChannelECG;
        private System.Windows.Forms.ComboBox cboChannelACC;
        private System.Windows.Forms.ComboBox cboChannelEDA;
        private System.Windows.Forms.ComboBox cboChannelEMG;
        private System.Windows.Forms.ComboBox cboChannelEGG;
        private System.Windows.Forms.ComboBox cboChannelEEG;
        private System.Windows.Forms.Label lblChannel2;
        private System.Windows.Forms.Label lblChannel1;
        private System.Windows.Forms.LinkLabel lklVisualizeMapping;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox ptbEnableSpeechRecognition;
        private System.Windows.Forms.ToolStripMenuItem mniChangeTheLanguage;
    }
}

