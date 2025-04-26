using SWAD_L4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SWAD_L4.DAL.Configurations
{
    public class CharacterEntityConfiguration : IEntityTypeConfiguration<CharacterEntity>
    {
        public void Configure(EntityTypeBuilder<CharacterEntity> builder)
        {
            builder.HasKey(c => c.CharacterId);
            builder.Property(c => c.CostumeName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Price).HasPrecision(18, 2);

            builder.HasData(
            new CharacterEntity { CharacterId = 1, CostumeName = "Міккі Маус", Price = 300 },
            new CharacterEntity { CharacterId = 2, CostumeName = "Поні Іскорка", Price = 350 },
            new CharacterEntity { CharacterId = 3, CostumeName = "Соня з Ведмедиком", Price = 250 },
            new CharacterEntity { CharacterId = 4, CostumeName = "Кіт Матроскін", Price = 270 },
            new CharacterEntity { CharacterId = 5, CostumeName = "Снігуронька", Price = 400 }
        );
        }
    }
}