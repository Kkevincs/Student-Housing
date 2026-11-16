using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface IHouse
    {
        public Task Create(House house);
        public Task Update(House house);
        public Task Delete(House house);
        public Task<List<House>> GetAll();
        public Task<House> GetById(int id);
    }
}
