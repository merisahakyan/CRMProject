using DatabaseAccessLayer.FluentApiConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DatabaseAccessLayer.Entities
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<ClientGroup> ClientGroups { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.Development.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfigs());
            modelBuilder.ApplyConfiguration(new GroupConfigs());
            modelBuilder.ApplyConfiguration(new EmailTemplateConfigs());
            modelBuilder.ApplyConfiguration(new ClientGroupConfigs());
            base.OnModelCreating(modelBuilder);
        }
    }
}
