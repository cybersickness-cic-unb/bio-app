using BC.Resources;
using System;
using System.Windows.Forms;
using BC.Forms;
using System.Threading;
using System.Net;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using BC.Dal.Business;
using BC.Dal.Entity;
using System.Speech.Recognition;
using System.Linq;
using ComboBox = System.Windows.Forms.ComboBox;

namespace BC
{
    public partial class FrmMain : Form
    {
        #region Class variables
        //Others
        MessageForm obMessage = new MessageForm();

        //Threads
        private Thread tStartCollection;
        private Thread tStartScreenshot;

        private System.Windows.Forms.Timer timer;
        private DateTime startTime;
        

        //Delegates
        delegate void TextBoxDelegate(string message);
        delegate void ClearTextBoxDelegate();
        delegate int GetSizeRtxDelegate();

        
        //Bitalino configuration
        private IPAddress IPAdress;
      
        //Log configuration
        private int numberOfLines = 1000;

        //Chart setup
        private List<double> listSignalData;

        private DriverOpenSignals driver;
        
        private SpeechRecognitionEngine recognizer;

        private string levelCS;

        private BConfig bConfig = new BConfig();
        protected Config eConfig = new Config();

        FrmChartBiosignal obFrmChartECG;
        FrmChartBiosignal obFrmChartEEG;
        FrmChartBiosignal obFrmChartEGG;
        FrmChartBiosignal obFrmChartEMG;
        FrmChartBiosignal obFrmChartEDA;
        FrmChartBiosignal obFrmChartACC;

        
        private bool recording = false;
        private bool startedTimerRecording = false;
        private TimeSpan elapsedTime;

        private System.Windows.Forms.Timer timerStopwatch;

        private Translator obTranslator;
        #endregion

        #region View
        public FrmMain()
        {
            InitializeComponent();
            this.Width = 680;
            this.Height = 775;

            SetLanguage();

            pnlStatusServiceCollection.BackColor = System.Drawing.Color.Red;
            btnStopCollection.Enabled = false;
            btnStartCollection.Enabled = true;            
            rtbLogCollection.SelectionLength = 0;
            rtbLogCollection.SelectionStart = rtbLogCollection.Text.Length;
            rtbLogCollection.BackColor = ColorTranslator.FromHtml("#191970");
            rtbLogCollection.ForeColor = Color.White;
            
            
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; //default time maintenance process
            timer.Tick += MaintenanceProcess;

            timerStopwatch = new System.Windows.Forms.Timer();
            timerStopwatch.Interval = 1000; // 1 second
            timerStopwatch.Tick += timerStopwatch_Tick;

            FillComboBox(cboChannelECG);
            FillComboBox(cboChannelEEG);
            FillComboBox(cboChannelEGG);
            FillComboBox(cboChannelEMG);
            FillComboBox(cboChannelEDA);
            FillComboBox(cboChannelACC);

            SetFormFromConfig();

            startTime = DateTime.Now;
            btnStartRecording.Enabled = false;

            elapsedTime = TimeSpan.Zero;
            UpdateTimeLabel();

            if (String.Compare(eConfig.enableSpeechRecognition,"S") == 0)
                InitializeSpeechRecognition();

        }

        private void SetLanguage()
        {
            obTranslator = new Translator(this.Controls, eConfig.Language, mnsConfig);
        }

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            lblTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void FillComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Id";

            comboBox.Items.Add(new { Text = "select", Id = 0 });

            for (int i = 1; i <= 6; i++)
            {
                comboBox.Items.Add(new { Text = i.ToString(), Id = i });
            }
        }

        private int GetValueChanelConfig(int channel)
        {           
            return channel;
        }
        

        private int GetValueComboSetEntity(ComboBox comboBox)
        {
            return (String.Compare(comboBox.Text, "select") == 0) ? 0 : Convert.ToInt32(comboBox.Text);
        }

        bool HasRepeatedValues(params ComboBox[] comboBoxes)
        {
            HashSet<object> valuesSelected = new HashSet<object>();

            foreach (ComboBox comboBox in comboBoxes)
            {
                object valueSelected = comboBox.Text;

                if (valueSelected != null && valueSelected.ToString() != "select" && !valuesSelected.Add(valueSelected))
                {
                    comboBox.SelectedIndex = 0;
                    OnSelectionChangeCommitted(comboBox);
                    return true;
                }
            }

            return false;
        }

        private static void OnSelectionChangeCommitted(ComboBox comboBox)
        {
            EventHandler handler = (EventHandler)comboBox.GetType().GetMethod("OnSelectionChangeCommitted", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(comboBox, new object[] { EventArgs.Empty });
        }

        private void MaintenanceProcess(object sender, EventArgs e)
        {
            GC.Collect();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MessageBoxHelper.PrepToCenterMessageBoxOnForm(this);
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown
                || e.CloseReason == CloseReason.ApplicationExitCall
                || e.CloseReason == CloseReason.TaskManagerClosing)
            {
                return;
            }

            var response = obMessage.ShowMessage(obTranslator.GetTranslation("exitSystem"), "QUESTION", ConfigSystem.TitleSystem);

            if (response == DialogResult.No)
                e.Cancel = true;
            else
                EndProgram();
        }


        public void UpdatingTextBox(string msg)
        {

            if (this.rtbLogCollection.InvokeRequired)
            {
                this.rtbLogCollection.Invoke(new TextBoxDelegate(UpdatingTextBox), new object[] { msg });
                int lineNumber = Convert.ToInt32(this.rtbLogCollection.Invoke(new GetSizeRtxDelegate(GetSizeRtx)));

                if (lineNumber > numberOfLines)
                    this.rtbLogCollection.Invoke(new ClearTextBoxDelegate(ClearTextBox));
            }
            else
            {
                this.rtbLogCollection.AppendText(msg + "\n");
                rtbLogCollection.ScrollToCaret();
                Log.writeLog(msg, ConfigSystem.GetNameLog);
            }
        }

        private int GetSizeRtx()
        {
            int response = 0;
            response = this.rtbLogCollection.GetLineFromCharIndex(this.rtbLogCollection.TextLength);

            return response;
        }

        private void ClearTextBox()
        {
            this.rtbLogCollection.Clear();
        }

        private void lklOpenLogFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\log\\" + ConfigSystem.GetNameLog);
        }

        private void lblOpenLogFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\log\\");
        }

        private void lblOpenScreenshotsFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\biosignal-data\\screenshots\\");
        }

        private void btnViewECG_Click(object sender, EventArgs e)
        {
            FrmTest frm = new FrmTest();
            frm.ShowDialog();
        }

        private void lklOpenFolderWithCapturedPrintScreen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\biosignal-data\\charts\\");
        }

        private void lklOpenFolderWithCollectedData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\biosignal-data\\json-data-collection\\");
        }

      
        private void lklRemoveAllRecordedBiosignals_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var response = obMessage.ShowMessage(obTranslator.GetTranslation("msgConfirmRemoveRecordBiosignal"), "QUESTION", ConfigSystem.TitleSystem);

            if (response != DialogResult.No)
            {
                RemoveAllRecordBiosignals();
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void mniGeneral_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            FrmConfig frm = new FrmConfig();
            frm.ShowDialog();

            SetFormFromConfig();

            if (String.Compare(eConfig.enableSpeechRecognition, "S") == 0)
                InitializeSpeechRecognition();
            else
                RecognizerStop();

            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void mniChartSetting_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            FrmChartConfig frm = new FrmChartConfig();
            frm.ShowDialog();

            SetFormFromConfig();

            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void mniConvertGameDataWeka_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            FrmConvertGameDataWeka frm = new FrmConvertGameDataWeka();
            frm.ShowDialog();


            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void SaveConfig()
        {
            SetEntityFromForm();
            bConfig.SaveConfig(eConfig);
        }

        private void rdbSaveOriginalImage_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void rdbSaveResizedImage_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void chkAutomaticSaveChart_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void chkAutomaticGenerateOutputToFile_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void chkECG_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void chkEEG_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void chkEGG_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void chkEMG_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void chkEDA_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void chkACC_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void cboChannelECG_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void cboChannelEEG_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void cboChannelEGG_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void cboChannelEMG_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void cboChannelEDA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void cboChannelACC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void lklVisualizeMapping_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            FrmBoardChannelMapping frm = new FrmBoardChannelMapping();
            frm.Show();
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }


        private void mniChangeTheLanguage_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            FrmLanguage frm = new FrmLanguage();
            frm.ShowDialog();

            SetLanguage();

            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        #endregion //end view

        #region Recognition
        private void InitializeSpeechRecognition()
        {
            try
            {
                recognizer = new SpeechRecognitionEngine();

                // Define the keywords to activate voice recognition and select a radiobutton
                var keywords = new Choices();
                keywords.Add("zero");
                keywords.Add("one");
                keywords.Add("two");
                keywords.Add("three");

                var grammarBuilder = new GrammarBuilder();
                grammarBuilder.Append(keywords);

                var grammar = new Grammar(grammarBuilder);
                recognizer.LoadGrammar(grammar);
                recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

                // Configure default audio input
                recognizer.SetInputToDefaultAudioDevice();

                // start recognition
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                ptbEnableSpeechRecognition.Visible = true;
            }
            catch (Exception ex)
            {
                obMessage.ShowMessage(obTranslator.GetTranslation("msgproblemEnableVoiceRecognition"), "EXCLAMATION", ConfigSystem.TitleSystem);
                eConfig.enableSpeechRecognition = "N";
                bConfig.SaveConfig(eConfig);
            }

        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Obter o texto reconhecido
            string recognizedText = e.Result.Text.ToLower();

            if (recognizedText.Contains("zero"))
                rdbLevel0.Checked = true;
            else if (recognizedText.Contains("one"))
                rdbLevel1.Checked = true;
            else if (recognizedText.Contains("two"))
                rdbLevel2.Checked = true;
            else if (recognizedText.Contains("three"))
                rdbLevel3.Checked = true;

        }

        private void RecognizerStop()
        {
            // Stop speech recognition            
            if (recognizer != null)
            {
                try
                {
                    recognizer.RecognizeAsyncStop();
                    // Release the resources of the SpeechRecognitionEngine object
                    recognizer.Dispose();
                    ptbEnableSpeechRecognition.Visible = false;
                }
                catch { }
            }

        }

        #endregion

        #region Entity
        private void SetEntityFromForm()
        {
            try
            {

                if (eConfig != null)
                {
                    eConfig.saveOriginalSizeImage = rdbSaveOriginalImage.Checked ? "S" : "N";
                    eConfig.saveResizedImage = rdbSaveOriginalImage.Checked ? "N" : "S";

                    eConfig.automaticallySaveChart = chkAutomaticSaveChart.Checked ? "S" : "N";
                    eConfig.automaticallyGenerateOutputToFile = chkAutomaticGenerateOutputToFile.Checked ? "S" : "N";

                    if (cboChannelECG.SelectedIndex > 0)
                    {
                        chkECG.Checked = true;
                        eConfig.captureECG = "S";
                    }
                    else
                    {
                        eConfig.captureECG = "N";
                        chkECG.Checked = false;
                    }

                    if (cboChannelEEG.SelectedIndex > 0)
                    {
                        chkEEG.Checked = true;
                        eConfig.captureEEG = "S";
                    }
                    else
                    {
                        eConfig.captureEEG = "N";
                        chkEEG.Checked = false;
                    }

                    if (cboChannelEGG.SelectedIndex > 0)
                    {
                        chkEGG.Checked = true;
                        eConfig.captureEGG = "S";
                    }
                    else
                    {
                        eConfig.captureEGG = "N";
                        chkEGG.Checked = false;
                    }

                    if (cboChannelEMG.SelectedIndex > 0)
                    {
                        chkEMG.Checked = true;
                        eConfig.captureEMG = "S";
                    }
                    else
                    {
                        chkEMG.Checked = false;
                        eConfig.captureEMG = "N";
                    }

                    if (cboChannelEDA.SelectedIndex > 0)
                    {
                        chkEDA.Checked = true;
                        eConfig.captureEDA = "S";
                    }
                    else
                    {
                        chkEDA.Checked = false;
                        eConfig.captureEDA = "N";
                    }

                    if (cboChannelACC.SelectedIndex > 0)
                    {
                        chkACC.Checked = true;
                        eConfig.captureACC = "S";
                    }
                    else
                    {
                        chkACC.Checked = false;
                        eConfig.captureACC = "N";
                    }


                    bool repeatedValues = HasRepeatedValues(cboChannelECG, cboChannelEEG, cboChannelEGG, cboChannelEMG, cboChannelEDA, cboChannelACC);
                    if (repeatedValues)
                        throw new Exception(obTranslator.GetTranslation("msgConflictChannelSensors"));

                    eConfig.channelECG = GetValueComboSetEntity(cboChannelECG);
                    eConfig.channelEEG = GetValueComboSetEntity(cboChannelEEG);
                    eConfig.channelEGG = GetValueComboSetEntity(cboChannelEGG);
                    eConfig.channelEMG = GetValueComboSetEntity(cboChannelEMG);
                    eConfig.channelEDA = GetValueComboSetEntity(cboChannelEDA);
                    eConfig.channelACC = GetValueComboSetEntity(cboChannelACC);


                }
            }
            catch (Exception ex)
            {
                obMessage.ShowMessage(ex.Message, "ERROR", ConfigSystem.TitleSystem);
            }

        }

        private void SetFormFromConfig()
        {
            eConfig = bConfig.GetConfig();
            txtIPadress.Text = eConfig.IpAddress;
            txtPort.Text = eConfig.Port.ToString();
            txtDeviceMacAddress.Text = eConfig.MacAddress;
            txtSamplingFreq.Text = eConfig.SamplingFreq.ToString();
            rdbSaveResizedImage.Text = obTranslator.GetTranslation("rdbSaveResizedImage") + ": " + eConfig.ResizeWidthTo + "px by " + eConfig.ResizeHeightTo + " px";

            rdbSaveOriginalImage.Checked = eConfig.saveOriginalSizeImage == "S";
            rdbSaveResizedImage.Checked = eConfig.saveResizedImage == "S";

            chkAutomaticSaveChart.Checked = eConfig.automaticallySaveChart == "S";
            chkAutomaticGenerateOutputToFile.Checked = eConfig.automaticallyGenerateOutputToFile == "S";

            chkECG.Checked = eConfig.captureECG == "S";
            chkEEG.Checked = eConfig.captureEEG == "S";
            chkEGG.Checked = eConfig.captureEGG == "S";
            chkEMG.Checked = eConfig.captureEMG == "S";
            chkEDA.Checked = eConfig.captureEDA == "S";
            chkACC.Checked = eConfig.captureACC == "S";

            cboChannelECG.SelectedIndex = GetValueChanelConfig(eConfig.channelECG);
            cboChannelEEG.SelectedIndex = GetValueChanelConfig(eConfig.channelEEG);
            cboChannelEGG.SelectedIndex = GetValueChanelConfig(eConfig.channelEGG);
            cboChannelEMG.SelectedIndex = GetValueChanelConfig(eConfig.channelEMG);
            cboChannelEDA.SelectedIndex = GetValueChanelConfig(eConfig.channelEDA);
            cboChannelACC.SelectedIndex = GetValueChanelConfig(eConfig.channelACC);

        }

        #endregion

        #region Recording
        private void RemoveAllRecordBiosignals(bool doNotShowMessage = true)
        {
            string[] folders = { "level-1", "level-2", "level-3", "none" };
            bool okCharts = FileManager.ToRemove("charts", folders);
            bool okJson = FileManager.ToRemove("json-data-collection");

            if (doNotShowMessage)
            {
                if (okCharts && okJson)
                    obMessage.ShowMessage(obTranslator.GetTranslation("msgRemovedChartJson"), "INFORMATION", ConfigSystem.TitleSystem);
                else if (okCharts)
                    obMessage.ShowMessage(obTranslator.GetTranslation("msgRemovedChartFiles"), "INFORMATION", ConfigSystem.TitleSystem);
                else
                    obMessage.ShowMessage(obTranslator.GetTranslation("msgRemovedJsonFiles"), "INFORMATION", ConfigSystem.TitleSystem);
            }

        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            if (!chkAutomaticSaveChart.Checked && !chkAutomaticGenerateOutputToFile.Checked)
                obMessage.ShowMessage(obTranslator.GetTranslation("msgMandatorySelectCheckBoxAutoSave"), "EXCLAMATION", ConfigSystem.TitleSystem);
            else
            {
                if (!recording)
                {
                    elapsedTime = TimeSpan.Zero;
                    UpdateTimeLabel();
                    timerStopwatch.Start();

                    RemoveAllRecordBiosignals(false);

                    btnStartRecording.Text = obTranslator.GetTranslation("textAlterButtonStopRecording");
                    btnStartRecording.BackColor = Color.OrangeRed;

                    tStartScreenshot = new Thread(delegate ()
                    {
                        recording = true;
                        startTime = DateTime.Now;
                        timer.Start();
                        while (true)
                        {
                            if (chkAutomaticSaveChart.Checked)
                            {
                                try
                                {
                                    if (driver.IsFormOpen("FrmECG"))
                                        obFrmChartECG.SaveChart("ECG", rdbSaveOriginalImage.Checked);

                                    if (driver.IsFormOpen("FrmEEG"))
                                        obFrmChartEEG.SaveChart("EEG", rdbSaveOriginalImage.Checked);

                                    if (driver.IsFormOpen("FrmEGG"))
                                        obFrmChartEGG.SaveChart("EGG", rdbSaveOriginalImage.Checked);

                                    if (driver.IsFormOpen("FrmEMG"))
                                        obFrmChartEMG.SaveChart("EMG", rdbSaveOriginalImage.Checked);

                                    if (driver.IsFormOpen("FrmEDA"))
                                        obFrmChartEDA.SaveChart("EDA", rdbSaveOriginalImage.Checked);

                                    if (driver.IsFormOpen("FrmACC"))
                                        obFrmChartACC.SaveChart("ACC", rdbSaveOriginalImage.Checked);
                                }
                                catch (Exception ex)
                                {
                                    obMessage.ShowMessage(ex.Message, "ERROR");
                                }

                                Thread.Sleep(TimeSpan.FromSeconds(eConfig.recordingTimeInterval));
                            }

                        }
                    });
                    tStartScreenshot.IsBackground = true;
                    tStartScreenshot.Start();
                    UpdatingTextBox(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " start recording");
                }
                else
                {
                    if (tStartScreenshot != null)
                    {
                        if (tStartScreenshot.IsAlive)
                            tStartScreenshot.Abort();
                    }

                    timer.Stop();
                    startTime = DateTime.Now;

                    elapsedTime = TimeSpan.Zero;
                    timerStopwatch.Stop();
                    UpdateTimeLabel();

                    recording = false;
                    startedTimerRecording = false;

                    btnStartRecording.Text = obTranslator.GetTranslation("btnStartRecording");
                    btnStartRecording.BackColor = Color.LightGreen;
                    UpdatingTextBox(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " stop recording");
                }
            }
        }
        #endregion

        #region Collection
        private void btnStartCollection_Click(object sender, EventArgs e)
        {
            SetFormFromConfig();
            try
            {
                CloseAllFormsExceptMain();

                if (chkECG.Checked)
                    OpenFrmChart("ECG");

                if (chkEEG.Checked)
                    OpenFrmChart("EEG");

                if (chkEGG.Checked)
                    OpenFrmChart("EGG");

                if (chkEMG.Checked)
                    OpenFrmChart("EMG");

                if (chkEDA.Checked)
                    OpenFrmChart("EDA");

                if (chkACC.Checked)
                    OpenFrmChart("ACC");

                OrganizeWindows();

                if (IPAddress.TryParse(eConfig.IpAddress, out IPAdress))
                {
                    driver = new DriverOpenSignals(this, obFrmChartECG, obFrmChartEEG, obFrmChartEGG, obFrmChartEMG, obFrmChartEDA, obFrmChartACC);
                    tStartCollection = new Thread(() => driver.StartClient(IPAdress, eConfig.Port));
                    tStartCollection.IsBackground = true;
                    tStartCollection.Start();
                    pnlStatusServiceCollection.BackColor = System.Drawing.Color.Green;
                    lblCollectionStatus.Text = "On";

                    btnStartCollection.Enabled = false;
                    btnStopCollection.Enabled = true;
                    btnStartRecording.Enabled = true;
                    string strActiveChannels = DataProcessing.GetChannelsConverted(eConfig);

                    timer.Start();
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    driver.SendCommand("config, " + eConfig.MacAddress + ", activechannels, " + strActiveChannels);
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    driver.SendCommand("enable, " + eConfig.MacAddress);
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                    driver.SendCommand("config, " + eConfig.MacAddress + ", samplingfreq, " + eConfig.SamplingFreq); //Hz = 10, 100 or 1000
                    Thread.Sleep(TimeSpan.FromSeconds(2));

                    driver.SendCommand("start");
                    listSignalData = new List<double>();
                    gpbSensors.Enabled = false;
                }
                else
                {
                    obMessage.ShowMessage("Error associating IP addres", "ERROR");

                }

            }
            catch (Exception ex)
            {
                UpdatingTextBox(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ex.Message);
                UpdatingTextBox(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " error starting service");

            }

        }

        private void btnStopCollection_Click(object sender, EventArgs e)
        {
            gpbSensors.Enabled = true;
            driver.SendCommand("stop");
            driver.CloseClient();

            tStartCollection.Abort();
            btnStopCollection.Enabled = false;
            btnStartCollection.Enabled = true;
            btnStartRecording.Enabled = false;
            pnlStatusServiceCollection.BackColor = System.Drawing.Color.Red;

            lblCollectionStatus.Text = "Off";

            if (chkAutomaticSaveChart.Checked)
            {
                try
                {
                    if (tStartScreenshot != null)
                    {
                        if (tStartScreenshot.IsAlive)
                            tStartScreenshot.Abort();
                    }

                    recording = true;
                    btnStartRecording.Enabled = true;
                    btnStartRecording.PerformClick();
                    btnStartRecording.Enabled = false;
                    elapsedTime = TimeSpan.Zero;

                    timer.Stop();
                    startTime = DateTime.MinValue;


                }
                catch (Exception ex)
                {
                    UpdatingTextBox(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ex.Message);
                }
                UpdatingTextBox(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " stop saving charts");
            }

        }

        private void OrganizeWindows()
        {
            // Obtém a coleção de telas
            Screen[] screens = Screen.AllScreens;

            // Filtra as janelas abertas, exceto a janela principal
            var windowsToArrange = Application.OpenForms.Cast<Form>().Where(f => f != this).ToList();

            // Calcula o tamanho e a posição da janela principal
            int mainWindowWidth = screens[0].Bounds.Width / 2;
            int mainWindowHeight = screens[0].Bounds.Height;
            //this.Size = new Size(mainWindowWidth, mainWindowHeight);
            this.Location = new Point(screens[0].Bounds.Left, screens[0].Bounds.Top);

            // Calcula o tamanho das demais janelas
            int windowWidth = (screens[0].Bounds.Width - mainWindowWidth) / 2;
            int windowHeight = screens[0].Bounds.Height / ((windowsToArrange.Count + 1) / 2);

            // Ajusta a posição das demais janelas
            int currentX = screens[0].Bounds.Left + mainWindowWidth;
            int currentY = screens[0].Bounds.Top;

            foreach (Form form in windowsToArrange)
            {
                form.Size = new Size(windowWidth, windowHeight);
                form.Location = new Point(currentX, currentY);

                currentX += windowWidth;
                if (currentX + windowWidth > screens[0].Bounds.Right)
                {
                    currentX = screens[0].Bounds.Left + mainWindowWidth;
                    currentY += windowHeight;
                }
            }
        }

        private void CloseAllFormsExceptMain()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form form = Application.OpenForms[i];
                if (form != null && form != this)
                {
                    form.Close();
                }
            }
        }
        #endregion

        #region Exit
        private void EndProgram()
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                obMessage.ShowMessage(obTranslator.GetTranslation("msgErrorExitSystem") +  " => " + ex.Message, "ERROR",
                    ConfigSystem.TitleSystem);
            }

        }

        private void OpenFrmChart(string typeBioSignal)
        {
            try
            {
                this.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                if (String.Compare(typeBioSignal, "ECG") == 0)
                {
                    obFrmChartECG = new FrmChartBiosignal(this, typeBioSignal, eConfig.channelECG);
                    obFrmChartECG.Name = "Frm" + typeBioSignal;
                    obFrmChartECG.Text = typeBioSignal;
                    obFrmChartECG.Show();
                }
                else if (String.Compare(typeBioSignal, "EEG") == 0)
                {
                    obFrmChartEEG = new FrmChartBiosignal(this, typeBioSignal, eConfig.channelEEG);
                    obFrmChartEEG.Name = "Frm" + typeBioSignal;
                    obFrmChartEEG.Text = typeBioSignal;
                    obFrmChartEEG.Show();
                }
                else if (String.Compare(typeBioSignal, "EGG") == 0)
                {
                    obFrmChartEGG = new FrmChartBiosignal(this, typeBioSignal, eConfig.channelEGG);
                    obFrmChartEGG.Name = "Frm" + typeBioSignal;
                    obFrmChartEGG.Text = typeBioSignal;
                    obFrmChartEGG.Show();
                }
                else if (String.Compare(typeBioSignal, "EMG") == 0)
                {
                    obFrmChartEMG = new FrmChartBiosignal(this, typeBioSignal, eConfig.channelEMG);
                    obFrmChartEMG.Name = "Frm" + typeBioSignal;
                    obFrmChartEMG.Text = typeBioSignal;
                    obFrmChartEMG.Show();
                }
                else if (String.Compare(typeBioSignal, "EDA") == 0)
                {
                    obFrmChartEDA = new FrmChartBiosignal(this, typeBioSignal, eConfig.channelEDA);
                    obFrmChartEDA.Name = "Frm" + typeBioSignal;
                    obFrmChartEDA.Text = typeBioSignal;
                    obFrmChartEDA.Show();
                }
                else if (String.Compare(typeBioSignal, "ACC") == 0)
                {
                    obFrmChartACC = new FrmChartBiosignal(this, typeBioSignal, eConfig.channelACC);
                    obFrmChartACC.Name = "Frm" + typeBioSignal;
                    obFrmChartACC.Text = typeBioSignal;
                    obFrmChartACC.Show();
                }

                this.Enabled = true;
                this.Cursor = Cursors.Default;
            }
            catch
            {
                throw;
            }
           
        }

        private void Exit()
        {
            MessageBoxHelper.PrepToCenterMessageBoxOnForm(this);

            var response = obMessage.ShowMessage(obTranslator.GetTranslation("exitSystem"), "QUESTION", ConfigSystem.TitleSystem);

            if (response != DialogResult.No)
            {
                EndProgram();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        #endregion

        #region capture the data

        public string  GetLevelCS()
        {
            string _levelCS = "";

            if (rdbLevel0.Checked)
                _levelCS = "none";
            else if (rdbLevel1.Checked)
                _levelCS = "level-1";
            else if (rdbLevel2.Checked)
                _levelCS = "level-2";
            else if (rdbLevel3.Checked)
                _levelCS = "level-3";

            return _levelCS;
        }

        public void AddJsonBiosignals(string jsonBiosignals)
        {
            if (recording)
            {
                string ts = Util.GetTimeStamp(startTime);
                if (!startedTimerRecording)
                {
                    startedTimerRecording = true;
                    ts = "0";                    
                }
                
                string setOfConvertedBiosignals = "{\"TimeStamp\": " + ts + ",\"LevelCS\": " + Util.ConvertToNumericValue(GetLevelCS()) + ",";
                setOfConvertedBiosignals += DataProcessing.GetDataJsonSignals(jsonBiosignals);
                setOfConvertedBiosignals += "},\r\n";
                GenerateFile(setOfConvertedBiosignals);
            }            
        }
        
        public void GenerateFile(string setOfConvertedBiosignals)
        {
            if (chkAutomaticGenerateOutputToFile.Checked)
            {
                if (setOfConvertedBiosignals.Length > 0)
                {
                 
                    string path = Directory.GetCurrentDirectory();
                    string target = path + "\\biosignal-data\\json-data-collection";
                    string fileName = "json-data.json";
                    string pathFile = target + "\\" + fileName;

                    try
                    {

                        File.AppendAllText(pathFile, setOfConvertedBiosignals);

                        UpdatingTextBox(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " file with biosignals and according to the CS level generated ");
                    }
                    catch (Exception ex)
                    {
                        UpdatingTextBox(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " An error occurred while adding content to the text file: " + ex.Message);

                    }

                }
            }
        }

        #endregion

    }   
}