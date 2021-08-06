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
    public class EmailTemplateConfigs : IEntityTypeConfiguration<EmailTemplate>
    {
        public void Configure(EntityTypeBuilder<EmailTemplate> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.Name).HasMaxLength(20).IsRequired();
            builder.Property(e => e.Body).HasMaxLength(4000).IsRequired();
            builder.Property(e => e.CreatedBy).IsRequired();
            builder.Property(e => e.CreatedDate).IsRequired();
        }
    }
}
