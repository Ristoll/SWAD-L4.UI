using Microsoft.EntityFrameworkCore;

namespace SWAD_L4.Core
{
    public interface IDbContextFactory
    {
        Task<DbContext> CreateDbContextAsync();
    }
}
