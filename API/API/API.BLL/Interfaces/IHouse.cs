using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IHouse
    {
        public Task Create();
        public Task Update();
        public Task Delete();
        public Task<House> GetById(int id);
        public Task<List<House>> GetAll();
    }
}
