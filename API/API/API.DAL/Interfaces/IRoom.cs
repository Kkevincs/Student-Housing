using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface IRoom
    {
        public Task Create(Room room);
        public Task Update(Assignment assignment);
        public Task Delete(int id);
        public Task<List<Room>> GetAll();
        public Task<Room> GetById(int id);
    }
}
