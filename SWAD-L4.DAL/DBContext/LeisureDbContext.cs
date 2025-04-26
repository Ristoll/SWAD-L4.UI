using SWAD_L4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using SWAD_L4.DAL.Configurations;
using SWAD_L4.Core;

namespace SWAD_L4.DAL
{
    public class LeisureDbContext : DbContext, IDbContext
    {
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ZoneEntity> Zones { get; set; }
        public DbSet<AttractionEntity> Attractions { get; set; }
        public DbSet<CharacterEntity> Characters { get; set; }

        public DbSet<OrderZoneEntity> OrderZones { get; set; }
        public DbSet<OrderAttractionEntity> OrderAttractions { get; set; }
        public DbSet<OrderCharacterEntity> OrderCharacters { get; set; }

        public LeisureDbContext(DbContextOptions<LeisureDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ZoneEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AttractionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterEntityConfiguration());

            modelBuilder.ApplyConfiguration(new OrderZoneEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderAttractionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderCharacterEntityConfiguration());
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
