using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface IChore
    {
        public Task Create(Chore chore);
        public Task Update(int id);
        public Task Delete(int id);
        public Task<List<Chore>> GetAll();
        public Task<Chore> GetById(int id);
    }
}
