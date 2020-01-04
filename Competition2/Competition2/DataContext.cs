using Competition2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Competition2
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions DbContextOptions) : base(DbContextOptions)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
