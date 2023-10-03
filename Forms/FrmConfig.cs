using BC.Dal.Entity;
using System;
using System.Windows.Forms;
using BC.Dal.Business;
using BC.Resources;
using BC.Forms;

namespace BC
{
    public partial class FrmConfig : Form
    {
        private BConfig bConfig = new BConfig();
        protected Config eConfig = new Config();

        //Others
        MessageForm obMessage = new MessageForm();
        private Translator obTranslator;
        public FrmConfig()
        {
            InitializeComponent();
            eConfig = bConfig.GetConfig();
            obTranslator = new Translator(this.Controls, eConfig.Language);
            this.Text = obTranslator.GetTranslation("FrmConfig");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AllowOnlyNumbers(System.Windows.Forms.TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        private void SetFormFromEntity()
        {
            try
            {
                eConfig = bConfig.GetConfig();
                if (eConfig != null)
                {
                    txtMacAddress.Text = eConfig.MacAddress;
                    txtIpAdress.Text = eConfig.IpAddress;
                    txtPort.Text = eConfig.Port.ToString();
                    txtResizeWidthTo.Text = eConfig.ResizeWidthTo.ToString();
                    txtResizeHeightTo.Text = eConfig.ResizeHeightTo.ToString();
                    cboSamplingFreq.SelectedItem = eConfig.SamplingFreq.ToString();
                    txtRecordingTimeInterval.Text = eConfig.recordingTimeInterval.ToString();
                    chkptbEnableSpeechRecognition.Checked = (String.Compare(eConfig.enableSpeechRecognition, "S") == 0);                     
                }
            }
            catch (Exception ex)
            {
                obMessage.ShowMessage(ex.Message, obTranslator.GetTranslation("titleMsgError"), ConfigSystem.TitleSystem);
  
            }
        }

        private void SetEntityFromForm()
        {
            try
            {
               
                if (eConfig != null)
                {
                    eConfig.MacAddress = txtMacAddress.Text;
                    eConfig.IpAddress = txtIpAdress.Text;
                    eConfig.Port = Convert.ToInt32(txtPort.Text);                    
                    eConfig.ResizeWidthTo = Convert.ToInt32(txtResizeWidthTo.Text);
                    eConfig.ResizeHeightTo = Convert.ToInt32(txtResizeHeightTo.Text);
                    eConfig.recordingTimeInterval = Convert.ToInt32(txtRecordingTimeInterval.Text);
                    eConfig.enableSpeechRecognition = (chkptbEnableSpeechRecognition.Checked ? "S" : "N");
                    if (!string.IsNullOrEmpty(cboSamplingFreq.Text))
                        eConfig.SamplingFreq = Convert.ToInt32(cboSamplingFreq.Text);
                    else
                        eConfig.SamplingFreq = 0;
                   
                }
            }
            catch (Exception ex)
            {
                obMessage.ShowMessage(ex.Message, obTranslator.GetTranslation("titleMsgError"), ConfigSystem.TitleSystem);
            }

        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                eConfig = bConfig.GetConfig();
                if (eConfig != null)
                {
                    SetEntityFromForm();
                    if (eConfig.recordingTimeInterval <= 0)
                        obMessage.ShowMessage(obTranslator.GetTranslation("msgNecessaryDefineIntervalRecording"), "EXCLAMATION", ConfigSystem.TitleSystem);
                    else
                    {
                        bConfig.SaveConfig(eConfig);
                        obMessage.ShowMessage(obTranslator.GetTranslation("msgConfigureSuccess"), "INFORMATION", ConfigSystem.TitleSystem);
                        Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                obMessage.ShowMessage(ex.Message, obTranslator.GetTranslation("titleMsgError"), ConfigSystem.TitleSystem);
            }
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void ApplyAllowOnlyNumbersToTextBoxes(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                
                if (control is System.Windows.Forms.TextBox textBox && textBox != txtIpAdress)
                    AllowOnlyNumbers(textBox);
                else if (control.HasChildren)
                    ApplyAllowOnlyNumbersToTextBoxes(control.Controls);
            }
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            SetFormFromEntity();
            ApplyAllowOnlyNumbersToTextBoxes(this.Controls);
        }

       
    }
}
