using Microsoft.EntityFrameworkCore;

namespace fifaAdministration.Models
{
    public class FifaDbContext : DbContext
    {
        public FifaDbContext(DbContextOptions<FifaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
