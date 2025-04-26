using Microsoft.EntityFrameworkCore;
using SWAD_L4.Core.Entities;

namespace SWAD_L4.Core.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly IDbContextFactory _dbContextFactory;

        public CatalogService(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory ?? throw new ArgumentNullException(nameof(dbContextFactory));
        }

        public async Task<List<string>> GetAllAttractionsAsync()
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var attractions = await context.Set<AttractionEntity>().ToListAsync();
            return attractions.Select(a => $"{a.Name} - {a.Price} $").ToList();
        }

        public async Task<List<string>> GetAllZonesAsync()
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var zones = await context.Set<ZoneEntity>().ToListAsync();
            return zones.Select(z => $"{z.Name} - {z.Price} $").ToList();
        }

        public async Task<List<string>> GetAllCharactersAsync()
        {
            using var context = await _dbContextFactory.CreateDbContextAsync();
            var characters = await context.Set<CharacterEntity>().ToListAsync();
            return characters.Select(c => $"{c.CostumeName} - {c.Price} $").ToList();
        }
    }
}