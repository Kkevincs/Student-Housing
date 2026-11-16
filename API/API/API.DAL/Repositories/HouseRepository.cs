using API.Repository;
using API.Repository.Interfaces;
using API.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace API.API.DAL.Repositories
{
    public class HouseRepository : IHouse
    {
        private readonly HousingDbContext _housingDbContext;

        public HouseRepository(HousingDbContext housingDbContext)
        {
            _housingDbContext = housingDbContext;
        }

        public async Task Create(House house)
        {
            _housingDbContext.Houses.Add(house);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task Delete(House house)
        {
            _housingDbContext.Houses.Remove(house);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task<List<House>> GetAll()
        {
            return await _housingDbContext.Houses.ToListAsync();
        }

        public async Task<House> GetById(int id)
        {
            return await _housingDbContext.Houses.FindAsync(id);
        }

        public async Task Update(House house)
        {
            _housingDbContext.Houses.Update(house);
            await _housingDbContext.SaveChangesAsync();
        }
    }
}
