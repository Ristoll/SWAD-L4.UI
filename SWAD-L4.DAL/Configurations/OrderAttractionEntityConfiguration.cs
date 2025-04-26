using SWAD_L4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SWAD_L4.DAL.Configurations
{
    public class OrderAttractionEntityConfiguration : IEntityTypeConfiguration<OrderAttractionEntity>
    {
        public void Configure(EntityTypeBuilder<OrderAttractionEntity> builder)
        {
            builder.HasKey(oa => new { oa.OrderId, oa.AttractionId });

            builder.HasData(
            new OrderAttractionEntity { OrderId = 1, AttractionId = 1 },
            new OrderAttractionEntity { OrderId = 1, AttractionId = 2 },
            new OrderAttractionEntity { OrderId = 2, AttractionId = 3 },
            new OrderAttractionEntity { OrderId = 3, AttractionId = 4 },
            new OrderAttractionEntity { OrderId = 3, AttractionId = 5 }
        );
        }
    }
}