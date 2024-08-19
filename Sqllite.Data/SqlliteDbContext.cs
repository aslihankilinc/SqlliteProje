using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Sqllite.Data
{
    public class SqlliteDbContext : DbContext
    {
        protected readonly IConfiguration configuration;

        private string _conStringName;

        public SqlliteDbContext(string conStringName)
        {
            _conStringName = conStringName;
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                                                  .SetBasePath(Directory.GetCurrentDirectory())
                                                   .AddJsonFile("appsettings.json")
                                                   .Build();
            configuration = configurationRoot;
        }

        public SqlliteDbContext(DbContextOptions<SqlliteDbContext> dbContextOptions)
            : base((DbContextOptions)(object)dbContextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conString = string.Empty;
            conString = configuration.GetConnectionString(_conStringName);
            options.UseSqlite(conString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    }
