using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IScore
    {
        public Task Create();
        public Task Update();
        public Task Delete();
        public Task<Score> GetById(int id);
        public Task<List<Score>> GetAll();
    }
}
