using API.API.DAL.Models;
using API.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API.Repository
{
    public class HousingDbContext : DbContext
    {
        public HousingDbContext(DbContextOptions<HousingDbContext> options) : base(options)
        {  
        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Location> Locations {  get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Score> Scores {  get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Chore>()                  // for the Chore class…
                .HasOne(c => c.StudentNav)                // …each chore has one student (a creator)…
                .WithMany(s => s.CreatedChores)           // …and a student has many created chores…
                .HasForeignKey(c => c.StudentId)          // …linked through the StudentId column…
                .OnDelete(DeleteBehavior.SetNull);        // …when that student is deleted, set StudentId to NULL
        }
    }
}
