using SWAD_L4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SWAD_L4.DAL.Configurations
{
    public class AttractionEntityConfiguration : IEntityTypeConfiguration<AttractionEntity>
    {
        public void Configure(EntityTypeBuilder<AttractionEntity> builder)
        {
            builder.HasKey(a => a.AttractionId);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
            builder.Property(a => a.Price).HasPrecision(18, 2);

            builder.HasData(
            new AttractionEntity { AttractionId = 1, Name = "Батут", Price = 150 },
            new AttractionEntity { AttractionId = 2, Name = "Лабіринт", Price = 200 },
            new AttractionEntity { AttractionId = 3, Name = "Колесо огляду", Price = 250 },
            new AttractionEntity { AttractionId = 4, Name = "Гойдалки", Price = 100 },
            new AttractionEntity { AttractionId = 5, Name = "Зимова карусель", Price = 180 }
        );
        }
    }
}