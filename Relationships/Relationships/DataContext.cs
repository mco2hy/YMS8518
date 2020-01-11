using Microsoft.EntityFrameworkCore;

namespace Relationships
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Personal> Personals { get; set; }
        public DbSet<Models.Address> Addresses { get; set; }
    }
}
