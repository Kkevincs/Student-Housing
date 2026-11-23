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
    }
}
