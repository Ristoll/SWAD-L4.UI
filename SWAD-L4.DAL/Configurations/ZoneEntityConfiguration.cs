using SWAD_L4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SWAD_L4.DAL.Configurations
{
    public class ZoneEntityConfiguration : IEntityTypeConfiguration<ZoneEntity>
    {
        public void Configure(EntityTypeBuilder<ZoneEntity> builder)
        {
            builder.HasKey(z => z.ZoneId);
            builder.Property(z => z.Name).IsRequired().HasMaxLength(100);
            builder.Property(o => o.Price).HasPrecision(18, 2);

            builder.HasData(
            new ZoneEntity { ZoneId = 1, Name = "Ігрова зона", Price = 200 },
            new ZoneEntity { ZoneId = 2, Name = "Спортивна зона", Price = 150 },
            new ZoneEntity { ZoneId = 3, Name = "Зона релаксу", Price = 175 },
            new ZoneEntity { ZoneId = 4, Name = "Квест-зона", Price = 300 },
            new ZoneEntity { ZoneId = 5, Name = "Тематична зона", Price = 290 }
        );
        }
    }
}