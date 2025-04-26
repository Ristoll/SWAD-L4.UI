using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SWAD_L4.DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LeisureDbContext>
    {
        public LeisureDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LeisureDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LeisureDb;Trusted_Connection=True;");

            return new LeisureDbContext(optionsBuilder.Options);
        }
    }
}