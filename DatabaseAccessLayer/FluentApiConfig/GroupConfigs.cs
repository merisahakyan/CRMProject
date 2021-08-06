using DatabaseAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseAccessLayer.FluentApiConfig
{
    public class GroupConfigs : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Id).IsRequired();
            builder.Property(g => g.Name).HasMaxLength(20).IsRequired();
            builder.Property(g => g.CreatedBy).IsRequired();
            builder.Property(g => g.CreatedDate).IsRequired();
        }
    }
}
