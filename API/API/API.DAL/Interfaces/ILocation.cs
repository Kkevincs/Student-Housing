using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface ILocation
    {
        public Task Create(Location location);
        public Task Update(int id);
        public Task Delete(int id);
        public Task<List<Location>> GetAll();
        public Task<Location> GetById(int id);
    }
}
