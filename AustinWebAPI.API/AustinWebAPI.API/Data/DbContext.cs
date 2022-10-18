using AustinWebAPI.API.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace AustinWebAPI.API.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkingDifficulty> WalkingDifficulties { get; set; }
    }
}
