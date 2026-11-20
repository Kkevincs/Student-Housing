using API;

using API.API.BLL.Interfaces;
using API.Repository;
using API.Repository.Interfaces;
using API.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace API.API.DAL.Repositories
{
    public class RoomRepository : IRoom
    {
        private readonly HousingDbContext _housingDbContext;

        public RoomRepository(HousingDbContext housingDbContext)
        {
            _housingDbContext = housingDbContext;
        }

        public async Task Create(Room room)
        {
            _housingDbContext.Rooms.Add(room);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Room deleteable = await _housingDbContext.Rooms.FindAsync(id);
            _housingDbContext.Rooms.Remove(deleteable);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task<List<Room>> GetAll()
        {
            return await _housingDbContext.Rooms.ToListAsync();
        }

        public async Task<Room> GetById(int id)
        {
            return await _housingDbContext.Rooms.FindAsync(id);
        }

        public async Task Update(Room room)
        {

            _housingDbContext.Rooms.Update(room);
            await _housingDbContext.SaveChangesAsync();
        }
    }
}
