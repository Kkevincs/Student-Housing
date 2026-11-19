using API;
using API.Repository;
using API.Repository.Interfaces;
using API.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace API.API.DAL.Repositories
{
    public class LocationRepository : ILocation
    {
        private readonly HousingDbContext _housingDbContext;

        public LocationRepository(HousingDbContext housingDbContext)
        {
            _housingDbContext = housingDbContext;
        }

        public async Task Create(Location location)
        {
            _housingDbContext.Locations.Add(location);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Location deleteable = await _housingDbContext.Locations.FindAsync(id);
            _housingDbContext.Locations.Remove(deleteable);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task<List<Location>> GetAll()
        {
            return await _housingDbContext.Locations.ToListAsync();
        }

        public async Task<Location> GetById(int id)
        {
            return await _housingDbContext.Locations.FindAsync(id);
        }

        public async Task Update(Assignment assignment)
        {

            _housingDbContext.Assignments.Update(assignment);
            await _housingDbContext.SaveChangesAsync();
        }
    }
}
