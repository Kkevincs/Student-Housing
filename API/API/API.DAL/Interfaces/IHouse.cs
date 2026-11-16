using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface IHouse
    {
        public Task Create(House house);
        public Task Update(int id);
        public Task Delete(int id);
        public Task<List<House>> GetAll();
        public Task<House> GetById(int id);
    }
}
