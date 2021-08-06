using DatabaseAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseAccessLayer.FluentApiConfig
{
    public class ClientConfigs : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.FirstName).HasMaxLength(20).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(20).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(30).IsRequired();
            builder.Property(c => c.PhoneNumber).HasMaxLength(9).IsRequired();
            builder.Property(c => c.CreatedBy).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();


           
        }
    }
}
