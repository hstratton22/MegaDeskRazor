using Microsoft.EntityFrameworkCore;

namespace SacramentPlanner.Data
{
    public class SacramentPlannerContext : DbContext
    {
        public SacramentPlannerContext (DbContextOptions<SacramentPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentPlanner.Models.Plan> Plan { get; set; }

        public DbSet<SacramentPlanner.Models.Hymns> Hymns { get; set; }

        public DbSet<SacramentPlanner.Models.Speaker> Speakers { get; set; }

    }
}
