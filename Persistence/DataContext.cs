using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<Value> Values { get; set; }
        //public DbSet<Post> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(
                new Value { Id = 1, Name = "Lizette Munoz" },
                new Value { Id = 5, Name = "Halle" },
                new Value { Id = 12, Name = "Brewski" }
            );
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}