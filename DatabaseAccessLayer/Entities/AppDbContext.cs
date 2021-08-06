using DatabaseAccessLayer.FluentApiConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.Entities
{
    public class AppDbContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<ClientGroup> ClientGroups { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

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
