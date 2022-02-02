using K205Agency.Models;
using Microsoft.EntityFrameworkCore;

namespace K205Agency.Data
{
    public class AgencyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AgencyDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Masthead> Mastheads { get; set; }
    }
}
