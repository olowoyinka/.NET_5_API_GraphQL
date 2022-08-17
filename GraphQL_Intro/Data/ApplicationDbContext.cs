using GraphQL_Intro.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL_Intro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; } 
    }
 }