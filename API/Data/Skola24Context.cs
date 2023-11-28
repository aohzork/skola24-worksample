using API.Data.EFModels;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Skola24Context : DbContext
    {
        public Skola24Context(DbContextOptions<Skola24Context> options) : base(options) { }

        public DbSet<Absence> Absences { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
