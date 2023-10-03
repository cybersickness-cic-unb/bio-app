using BC.Dal;
using BC.Dal.Business;
using BC.Dal.Entity;
using BC.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BC.Forms
{
    public partial class FrmChartConfig : Form
    {
        BConfigurationChart oBConfigurationChart = new BConfigurationChart();
        ConfigurationChart configurationChart;
        MessageForm obMessage = new MessageForm();
        private BConfig bConfig = new BConfig();
        protected Config eConfig = new Config();
        private Translator obTranslator;
        public FrmChartConfig()
        {
            InitializeComponent();
            eConfig = bConfig.GetConfig();
            obTranslator = new Translator(this.Controls, eConfig.Language);
            this.Text = obTranslator.GetTranslation("FrmChartConfig");
        }

        private void FrmChartConfig_Load(object sender, EventArgs e)
        {
            cboSelectChart.Items.Clear();

            List<ConfigurationChart> listConfigurationChart = oBConfigurationChart.GetConfigurationChartList();
            foreach (ConfigurationChart itemConfigurationChart in listConfigurationChart)
                cboSelectChart.Items.Add(itemConfigurationChart.Chart);

            cboSelectChart.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboSelectChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                configurationChart  = oBConfigurationChart.GetConfigurationChart(cboSelectChart.Text);
                if (configurationChart != null)
                    rtbJson.Text = configurationChart.Json;
            }
            catch(Exception ex)
            {
                obMessage.ShowMessage(ex.Message, "ERROR", ConfigSystem.TitleSystem);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (!String.IsNullOrEmpty(rtbJson.Text) && configurationChart != null)
                {
                    var jsonTest = JsonConvert.DeserializeObject<ChartConfiguration>(rtbJson.Text);
                    configurationChart.Json = rtbJson.Text;
                    oBConfigurationChart.SaveConfigurationChar(configurationChart);
                    obMessage.ShowMessage(obTranslator.GetTranslation("msgConfigureChangedSuccess"), "INFORMATION", ConfigSystem.TitleSystem);
                }
                else
                    obMessage.ShowMessage(obTranslator.GetTranslation("msgNecessaryFillChartConfigurationJsonFormat"), "ERROR", ConfigSystem.TitleSystem);

            }
            catch (Exception ex)
            {
                obMessage.ShowMessage(ex.Message, "ERROR", ConfigSystem.TitleSystem);
            }
            this.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void lklRestoreChartConfiguration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rtbJson.Text = configurationChart.JsonTemplate;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
