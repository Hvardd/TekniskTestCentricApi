using Microsoft.EntityFrameworkCore;

namespace TekniskTestCentricAPI.DataModels
{
    public class ContinentAdminContext : DbContext
    {
        public ContinentAdminContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Continent> Continent { get; set; }

        public DbSet<Country> Country { get; set; }
    }
}
