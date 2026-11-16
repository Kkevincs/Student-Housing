using API.API.BLL.DTOs;
using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IScoreService
    {
        public Task Create(CreateScoreDto score);
        public Task Update(int id);
        public Task Delete(int id);
        public Task<Score> GetById(int id);
        public Task<List<Score>> GetAll();
    }
}
