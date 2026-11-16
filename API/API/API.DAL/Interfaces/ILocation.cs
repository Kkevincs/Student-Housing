using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface ILocation
    {
        public Task Create(Location location);
        public Task Update(Location location);
        public Task Delete(Location location);
        public Task<List<Location>> GetAll();
        public Task<Location> GetById(int id);
    }
}
