using Microsoft.EntityFrameworkCore;

namespace BookRelation
{
    public class DataContext : DbContext
    {
        private readonly DataContext _dataContext;
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.Page> Pages { get; set; }
        public DbSet<Models.Vote> Votes { get; set; }
    }
}
