using Microsoft.EntityFrameworkCore;

namespace fifaAdministration.Models
{
    public class FifaDbContext : DbContext
    {
        public FifaDbContext(DbContextOptions<FifaDbContext> options)
            : base(options)
        {
        }

        public DbSet<FifaDbContext> FifaItems { get; set; }
    }
}
