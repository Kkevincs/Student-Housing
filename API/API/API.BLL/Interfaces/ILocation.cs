using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface ILocation
    {
        public Task Create();
        public Task Update();
        public Task Delete();
        public Task<Location> GetById(int id);
        public Task<List<Location>> GetAll();
    }
}
