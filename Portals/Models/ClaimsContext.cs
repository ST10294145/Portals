using Microsoft.EntityFrameworkCore;

namespace Portals.Models
{
    public class ClaimsContext : DbContext
    {
        public DbSet<HR> HRS { get; set; }

        public ClaimsContext(DbContextOptions options) : base(options) 
        {

        }
    }
}
