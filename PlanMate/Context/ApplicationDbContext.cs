using System.Data.Entity;
using PlanMate.Entities;

namespace PlanMate.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
