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

        public async Task Delete(Location location)
        {
            _housingDbContext.Locations.Remove(location);
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

        public async Task Update(Location location)
        {
            _housingDbContext.Locations.Update(location);
            await _housingDbContext.SaveChangesAsync();
        }
    }
}
