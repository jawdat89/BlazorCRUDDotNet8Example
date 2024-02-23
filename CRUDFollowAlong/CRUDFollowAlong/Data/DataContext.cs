using CRUDFollowAlong.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDFollowAlong.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Game> Games => Set<Game>();
    }
}
