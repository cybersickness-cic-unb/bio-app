using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Data.SQLite;
using BC.Dal.Entity;

namespace BC.Dal
{
    public class AppContext : DbContext
    {
        public AppContext() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "db.db", ForeignKeys = true }.ConnectionString
            }, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Conventions.Remove<PluralizingTableNameConvention>();
            mb.Entity<Config>().ToTable("config");
            mb.Entity<ConfigurationChart>().ToTable("configuration_chart");
            base.OnModelCreating(mb);
        }

        public DbSet<Config> Configs { get; set; }      
        public DbSet<ConfigurationChart> ConfigurationCharts { get; set; }      
    }
}
