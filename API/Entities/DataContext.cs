using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ApiUser> Users { get; set; }
    }
}