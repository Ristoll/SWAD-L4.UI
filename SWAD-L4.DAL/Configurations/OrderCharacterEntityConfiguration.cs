using SWAD_L4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SWAD_L4.DAL.Configurations
{
    public class OrderCharacterEntityConfiguration : IEntityTypeConfiguration<OrderCharacterEntity>
    {
        public void Configure(EntityTypeBuilder<OrderCharacterEntity> builder)
        {
            builder.HasKey(oc => new { oc.OrderId, oc.CharacterId });

            builder.HasData(
            new OrderCharacterEntity { OrderId = 1, CharacterId = 1 },
            new OrderCharacterEntity { OrderId = 2, CharacterId = 2 },
            new OrderCharacterEntity { OrderId = 3, CharacterId = 3 },
            new OrderCharacterEntity { OrderId = 4, CharacterId = 4 },
            new OrderCharacterEntity { OrderId = 5, CharacterId = 5 }
        );
        }
    }
}