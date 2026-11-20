using API.API.BLL.DTOs;
using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IChoreService
    {
        public Task Create(CreateChoreDto chore);
        public Task Update(GetChoreDto chore);
        public Task Delete(int id);
        public Task<Chore> GetById(int id);
        public Task<List<Chore>> GetAll();
    }
}
