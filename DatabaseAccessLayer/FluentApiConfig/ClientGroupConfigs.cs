using DatabaseAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.FluentApiConfig
{
    public class ClientGroupConfigs : IEntityTypeConfiguration<ClientGroup>
    {
        public void Configure(EntityTypeBuilder<ClientGroup> builder)
        {

            builder.HasKey(cg => cg.Id);

            builder.Property(cg => cg.Id).IsRequired();
            builder.Property(cg => cg.ClientId).IsRequired();
            builder.Property(cg => cg.GroupId).IsRequired();
            builder.Property(cg => cg.CreatedBy).IsRequired();
            builder.Property(cg => cg.CreatedDate).IsRequired();

            builder.HasOne(cg => cg.Client)
                .WithMany(c => c.Groups)
                .HasForeignKey(cg => cg.ClientId);

            builder.HasOne(cg => cg.Group)
                .WithMany(g => g.Clients)
                .HasForeignKey(cg => cg.GroupId);
        }
    }
}
