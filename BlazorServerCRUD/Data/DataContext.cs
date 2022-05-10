using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUD.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Name = "xyz", Developer = "abc", Release = new DateTime(2004, 1, 1) },
                new Game { Id = 2, Name = "sdf", Developer = "xzc", Release = new DateTime(2003, 4, 5) }
                );
        }

        public DbSet<Game> Games => Set<Game>();
    }
}
