using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface IScore
    {
        public Task Create(Score Score);
        public Task Update(Assignment assignment);
        public Task Delete(int id);
        public Task<List<Score>> GetAll();
        public Task<Score> GetById(int id);
    }
}
