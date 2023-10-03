using BC.Dal.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BC.Dal.Business
{
    public class BConfigurationChart
    {
        public ConfigurationChart GetConfigurationChart(string chart)
        {
            ConfigurationChart configurationChart = new ConfigurationChart();
            try
            {
                using (var context = new AppContext())
                {
                    configurationChart = context.ConfigurationCharts
                        .FirstOrDefault(c => c.Chart == chart);
                }
            }
            catch
            {
                throw;
            }
            return configurationChart;
        }

        public List<ConfigurationChart> GetConfigurationChartList()
        {
            List<ConfigurationChart> configurationChartList = new List<ConfigurationChart>();
            try
            {
                using (var context = new AppContext())
                {
                    configurationChartList = context.ConfigurationCharts.ToList();
                }
            }
            catch
            {
                throw;
            }
            return configurationChartList;
        }


        public void SaveConfigurationChar(ConfigurationChart configurationChart)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var existingConfigurationChart = context.ConfigurationCharts.Find(configurationChart.Id);
                    if (existingConfigurationChart != null)
                    {
                        context.Entry(existingConfigurationChart).CurrentValues.SetValues(configurationChart);
                        context.SaveChanges();
                    }
                }
            }
            catch { throw; }

        }
    }
}
