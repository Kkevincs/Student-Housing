using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface IRoom
    {
        public Task Create(Room room);
        public Task Update(Room room);
        public Task Delete(Room room);
        public Task<List<Location> GetAll();
        public Task<Location> GetById(int id);
    }
}
