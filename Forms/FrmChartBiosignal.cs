using BC.Dal.Business;
using BC.Dal.Entity;
using BC.Forms;
using BC.Resources;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BC
{
    public partial class FrmChartBiosignal : FrmBaseBiosignal
    {
        private Chart chartBiosignal;
        private int channel;
        private string nameChart;

        //Others
        MessageForm obMessage = new MessageForm();
        public FrmChartBiosignal(FrmMain _frmMain, string _nameChart, int _channel)
        {
            try
            {
                frmMain = _frmMain;
                nameChart = _nameChart;
                InitializeComponent();
                ConfigureCharts();
                channel = _channel;
            }
            catch
            {
                throw;
            }
            
        }

        private void FrmChartBiosignal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Lógica de fechamento do formulário
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChartBiosignal));
            this.chartBiosignal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartBiosignal)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBiosignal
            // 
            this.chartBiosignal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "biosignal";
            this.chartBiosignal.ChartAreas.Add(chartArea1);
            legend1.Name = "biosignal";
            this.chartBiosignal.Legends.Add(legend1);
            this.chartBiosignal.Location = new System.Drawing.Point(13, 13);
            this.chartBiosignal.Name = "chartBiosignal";
            series1.ChartArea = "biosignal";
            series1.Legend = "biosignal";
            series1.Name = "biosignal";
            this.chartBiosignal.Series.Add(series1);
            this.chartBiosignal.Size = new System.Drawing.Size(579, 309);
            this.chartBiosignal.TabIndex = 0;
            this.chartBiosignal.Text = "biosignal";
            // 
            // FrmChartBiosignal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 331);
            this.Controls.Add(this.chartBiosignal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChartBiosignal";
            this.Text = "FrmChartBiosignal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChartBiosignal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartBiosignal)).EndInit();
            this.ResumeLayout(false);

        }


        private void ConfigureCharts()
        {
            BConfigurationChart oBConfigurationChart = new BConfigurationChart();            
            ConfigurationChart entityConfigurationChart = oBConfigurationChart.GetConfigurationChart(nameChart);

            if (entityConfigurationChart != null)
            {
                try
                {
                    // Configure the chart
                    ChartConfiguration entityChartConfigurationEntity = new ChartConfiguration();
                    entityChartConfigurationEntity = JsonConvert.DeserializeObject<ChartConfiguration>(entityConfigurationChart.Json);

                    entityChartConfigurationEntity.Name = "biosignal";

                    BiosignalChart.ConfigureChart(chartBiosignal, entityChartConfigurationEntity);
                }
                catch (Exception ex)
                {
                    Log.writeLog(ex.Message, ConfigSystem.GetNameLog);
                }
                
            }
            
        }



        public void UpdateChart(string jsonData, ChartConfiguration chartConfiguration, string typeBioSignal)
        {
            UpdateChart(typeBioSignal, jsonData, chartBiosignal, chartConfiguration);
        }

        public void SaveChart(string typeSignal, bool saveOriginalImage)
        {
            SaveChart(chartBiosignal, typeSignal, saveOriginalImage);
        }

        private void FrmECG_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxHelper.PrepToCenterMessageBoxOnForm(this);
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown
                || e.CloseReason == CloseReason.ApplicationExitCall
                || e.CloseReason == CloseReason.TaskManagerClosing)
            {
                return;
            }

            var response = obMessage.ShowMessage("Exit System?", "QUESTION", ConfigSystem.TitleSystem);

            if (response == DialogResult.No)
                e.Cancel = true;
            else
                Dispose();
        }
    }
}
