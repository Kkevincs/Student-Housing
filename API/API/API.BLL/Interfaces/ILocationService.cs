using API.API.BLL.DTOs;
using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface ILocationService
    {
        public Task Create(CreateLocationDto house);
        public Task Update(int id);
        public Task Delete(int id);
        public Task<Location> GetById(int id);
        public Task<List<Location>> GetAll();
    }
}
