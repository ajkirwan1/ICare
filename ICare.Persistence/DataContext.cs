using ICare.Domain;
using Microsoft.EntityFrameworkCore;

namespace ICare.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
