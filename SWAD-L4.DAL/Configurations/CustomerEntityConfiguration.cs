using SWAD_L4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SWAD_L4.DAL.Configurations
{
    public class CustomerEntityConfiguration : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.HasKey(c => c.CustomerId);
            builder.Property(c => c.NickName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.HasMany(c => c.Orders).WithOne(o => o.Customer).HasForeignKey(o => o.CustomerId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
