using Microsoft.EntityFrameworkCore;

namespace SWAD_L4.DAL
{
    public class DbContextFactory : IDbContextFactory<LeisureDbContext>
    {
        LeisureDbContext IDbContextFactory<LeisureDbContext>.CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<LeisureDbContext>();
            return new LeisureDbContext(optionsBuilder.Options);
        }
    }
}