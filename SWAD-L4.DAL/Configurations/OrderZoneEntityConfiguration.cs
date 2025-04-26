using SWAD_L4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SWAD_L4.DAL.Configurations
{
    public class OrderZoneEntityConfiguration : IEntityTypeConfiguration<OrderZoneEntity>
    {
        public void Configure(EntityTypeBuilder<OrderZoneEntity> builder)
        {
            builder.HasKey(oz => new { oz.OrderId, oz.ZoneId });

            builder.HasData(
            new OrderZoneEntity { OrderId = 1, ZoneId = 1 },
            new OrderZoneEntity { OrderId = 1, ZoneId = 2 },
            new OrderZoneEntity { OrderId = 2, ZoneId = 3 },
            new OrderZoneEntity { OrderId = 2, ZoneId = 4 },
            new OrderZoneEntity { OrderId = 3, ZoneId = 5 }
        );
        }
    }
}