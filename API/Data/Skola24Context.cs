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
            //relations
            modelBuilder.Entity<School>()
                .HasKey(sc => sc.Id);

            modelBuilder.Entity<School>()
                .HasMany(st => st.Students)
                .WithOne(sc => sc.School)
                .HasForeignKey(st => st.SchoolId);

            modelBuilder.Entity<School>()
                .HasIndex(sc => sc.SchoolName)
                .IsUnique()
                .HasDatabaseName("IX_SchoolName");

            modelBuilder.Entity<Student>()
                .HasKey(st => st.Id);

            modelBuilder.Entity<Student>()
                .HasMany(ab => ab.Absences)
                .WithOne(st => st.Student)
                .HasForeignKey(ab => ab.StudentId);

            modelBuilder.Entity<Absence>()
                .HasKey(ab => ab.Id);

            ////seeding
            //SeedingHelper.GenerateSchools(modelBuilder);
            //SeedingHelper.GenerateStudents(modelBuilder);
            //SeedingHelper.GenerateAbsence(modelBuilder);
        }

    }
}