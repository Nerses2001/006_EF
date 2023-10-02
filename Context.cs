
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace _006_EF
{
    internal class Context : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = ".",
                InitialCatalog = "OneToManyTest",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
            };
            optionsBuilder.UseSqlServer(builder.ConnectionString);

        }
    }
}
