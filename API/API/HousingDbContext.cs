using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace API
{
    public class HousingDbContext : DbContext
    {
        public HousingDbContext(DbContextOptions<HousingDbContext> options) : base(options)
        {

            
        }

        DbSet<Assignment> Assignments { get; set; }
        DbSet<Chore> Chores { get; set; }
        DbSet<House> Houses { get; set; }
        DbSet<Location> Locations {  get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<Score> Scores {  get; set; }
        DbSet<Student> Students { get; set; }
    }
}
