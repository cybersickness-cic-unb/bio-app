using BC.Resources;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using System.Windows.Forms;
using BC.Dal.Business;
using BC.Dal.Entity;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace BC.Forms
{
    public partial class FrmBaseBiosignal : Form
    {
        
        private string levelCS;
        private double i = 0;
        private BConfig bConfig = new BConfig();
        protected Config eConfig = new Config();

        MessageForm obMessage = new MessageForm();
        protected FrmMain frmMain;


        private DateTime startTime;

        public delegate void UpdateChartDelegate(string typeBioSignal, string jsonData, Chart chart, ChartConfiguration configurationChart);


        public void SaveChart(Chart chart, string typeSignal, bool saveOriginalImage)
        {
            if (chart != null && chart.IsHandleCreated)
            {
                levelCS = frmMain.GetLevelCS();
                // Save the capture to a file
                string path = Directory.GetCurrentDirectory();
                string target = path + "\\biosignal-data\\charts";

                string fileName = "chart-" + typeSignal + "-" + Util.GetTimeStamp(startTime) + ".jpg";
                string pathFile = target + "\\" + levelCS + "\\" + fileName;

                int desiredWidth = eConfig.ResizeWidthTo;
                int desiredHeight = eConfig.ResizeHeightTo;

                if (saveOriginalImage)
                    chart.Invoke((MethodInvoker)(() => chart.SaveImage(pathFile, System.Drawing.Imaging.ImageFormat.Jpeg)));
                else
                {
                    Image thumbnail = BiosignalChart.CreateThumbnail(chart, desiredWidth, desiredHeight);

                    thumbnail.Save(pathFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                    thumbnail.Dispose();
                }
            }
        }

        public void UpdateChart(string typeBioSignal, string jsonData, Chart chart, ChartConfiguration chartConfiguration)
        {
            try
            {
                if (chart != null && chart.IsHandleCreated)
                {
                    if (chart.InvokeRequired)
                        chart.Invoke(new UpdateChartDelegate(UpdateChart), new object[] { typeBioSignal, jsonData, chart, chartConfiguration });
                    else
                    {
                        List<dynamic> unitValue = DataProcessing.LoadDataFromJson(jsonData, typeBioSignal);

                        foreach (double value in unitValue)
                        {
                            BiosignalChart.UpdateChartAxis(chart, "biosignal", value, chartConfiguration.AxisYComplement);

                            chart.Series["biosignal"].Points.AddXY(i, (value));

                            i += chartConfiguration.ScaleMovePointToPointOnTheAxisX;

                            if (i >= chart.ChartAreas["biosignal"].AxisX.Maximum)
                            {
                                chart.ChartAreas["biosignal"].AxisX.Minimum += chartConfiguration.AxisXMinimumNewPositionAfterMaxingout;
                                chart.ChartAreas["biosignal"].AxisX.Maximum += chartConfiguration.AxisXMaximumNewPositionAfterMaxingout;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                //obMessage.ShowMessage("Error: " + ex.Message, "ERROR");
            }
        }

        public class RootObject
        {
            public int ReturnCode { get; set; }
            public ReturnData ReturnData { get; set; }
        }


        public class ReturnData
        {
            [JsonProperty("MAC_ADDRESS")]
            public List<List<dynamic>> Signal { get; set; }
        }
    }
}
