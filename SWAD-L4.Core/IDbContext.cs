using Microsoft.EntityFrameworkCore;

namespace SWAD_L4.Core
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}