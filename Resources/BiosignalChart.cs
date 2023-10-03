using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BC.Resources
{
    public class BiosignalChart
    {
        //private double iChart = 0;

        public static void UpdateChartAxis(Chart chart, string typeChart, double value, double complement)
        {
            if (chart != null && chart.IsHandleCreated)
            {
                double diff = Math.Round(Math.Abs(chart.ChartAreas[typeChart].AxisY.Maximum - value)) + complement;
                
                if (value > chart.ChartAreas[typeChart].AxisY.Maximum)
                {
                    chart.ChartAreas[typeChart].AxisY.Maximum += diff; // Atualiza o valor máximo do eixo Y
                    chart.ChartAreas[typeChart].AxisY.Minimum += diff; // Atualiza o valor mínimo do eixo Y
                }
                else if (value < chart.ChartAreas[typeChart].AxisY.Minimum)
                {
                    chart.ChartAreas[typeChart].AxisY.Maximum -= diff; // Atualiza o valor máximo do eixo Y
                    chart.ChartAreas[typeChart].AxisY.Minimum -= diff; // Atualiza o valor mínimo do eixo Y
                }
            }            
        }

        public static Image CreateThumbnail(Chart chart, int thumbnailWidth, int thumbnailHeight)
        {
            // Capture the chart image
            Bitmap captureBitmap = new Bitmap(chart.Width, chart.Height);
            chart.Invoke((MethodInvoker)(() =>
            {
                chart.DrawToBitmap(captureBitmap, new Rectangle(0, 0, chart.Width, chart.Height));
            }));

            // Resize the captured image
            Image resizedImage = captureBitmap.GetThumbnailImage(thumbnailWidth, thumbnailHeight, null, IntPtr.Zero);

            // Dispose of the capture bitmap
            captureBitmap.Dispose();

            return resizedImage;
        }

        public static void ConfigureChart(Chart chart, ChartConfiguration chartConfiguration)
        {

            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(new ChartArea(chartConfiguration.Name));

            chart.Series.Clear();
            chart.Series.Add(new Series(chartConfiguration.Name));
            chart.Series[chartConfiguration.Name].ChartType = SeriesChartType.Line;
            chart.Series[chartConfiguration.Name].Color = Color.Black;
            chart.Series[chartConfiguration.Name].BorderWidth = 1;
            chart.Series[chartConfiguration.Name].XValueType = ChartValueType.Int32;

            ChartArea chartArea = chart.ChartAreas[chartConfiguration.Name];
            chartArea.BackColor = Color.White;
            chart.Series[chartConfiguration.Name].IsVisibleInLegend = false;
            chart.Series[chartConfiguration.Name].Font = new Font(chart.Series[chartConfiguration.Name].Font.FontFamily, 8f);

            
            chart.ChartAreas[chartConfiguration.Name].AxisX.Minimum = chartConfiguration.AxisXMinimum;
            chart.ChartAreas[chartConfiguration.Name].AxisX.Maximum = chartConfiguration.AxisXMaximum;
            chart.ChartAreas[chartConfiguration.Name].AxisX.Interval = chartConfiguration.AxisXInterval;
            chart.ChartAreas[chartConfiguration.Name].AxisY.Minimum = chartConfiguration.AxisYMinimum;
            chart.ChartAreas[chartConfiguration.Name].AxisY.Maximum = chartConfiguration.AxisYMaximum;
            chart.ChartAreas[chartConfiguration.Name].AxisY.Interval = chartConfiguration.AxisYInterval;

            chart.ChartAreas[chartConfiguration.Name].AxisY.Title = chartConfiguration.AxisYTitle;
            chart.ChartAreas[chartConfiguration.Name].AxisY.LabelStyle.Enabled = chartConfiguration.AxisYLabelStyleEnabled;

            chart.ChartAreas[chartConfiguration.Name].AxisX.Title = chartConfiguration.AxisXTitle;
            chart.ChartAreas[chartConfiguration.Name].AxisX.LabelStyle.Enabled = chartConfiguration.AxisXLabelStyleEnabled;


            // Remove gridlines
            chart.ChartAreas[chartConfiguration.Name].AxisX.MajorGrid.Enabled = chartConfiguration.AxisXMajorGridEnabled;
            chart.ChartAreas[chartConfiguration.Name].AxisY.MajorGrid.Enabled = chartConfiguration.AxisYMajorGridEnabled;

        }

    }

}
