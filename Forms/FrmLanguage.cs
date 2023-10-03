using BC.Dal.Business;
using BC.Dal.Entity;
using BC.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC.Forms
{
    public partial class FrmLanguage : Form
    {
        private BConfig bConfig = new BConfig();
        protected Config eConfig = new Config();

        //Others
        MessageForm obMessage = new MessageForm();
        private Translator obTranslator;
        public FrmLanguage()
        {
            InitializeComponent();
            eConfig = bConfig.GetConfig();
            obTranslator = new Translator(this.Controls, eConfig.Language);           
            this.Text = obTranslator.GetTranslation("FrmLanguage");
        }

        private void SetFormFromEntity()
        {
            try
            {
                eConfig = bConfig.GetConfig();
                if (eConfig != null)
                {
                    rdbPortuguese.Checked = (String.Compare(eConfig.Language, "PT") == 0);
                    rdbEnglish.Checked = (String.Compare(eConfig.Language, "EN") == 0);
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
                   eConfig.Language = (rdbPortuguese.Checked ? "PT" : "EN");
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
                SetEntityFromForm();
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

        private void FrmLanguage_Load(object sender, EventArgs e)
        {
            SetFormFromEntity();
        }
    }
}
