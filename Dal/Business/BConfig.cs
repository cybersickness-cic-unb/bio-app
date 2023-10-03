using BC.Dal.Entity;
using System.Linq;


namespace BC.Dal.Business
{
    public class BConfig
    {
        public Config GetConfig()
        {
            Config config = new Config();
            try
            {
                using (var context = new AppContext())
                {
                    config = context.Configs
                        .First<Config>();
                }
            }
            catch
            {
                throw;
            }
            return config;
        }

        public void SaveConfig(Config config)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var existingConfig = context.Configs.Find(config.Id);
                    if (existingConfig != null)
                    {
                        context.Entry(existingConfig).CurrentValues.SetValues(config);
                        context.SaveChanges();
                    }
                }
            }
            catch {  throw; }

        }
    }
}
