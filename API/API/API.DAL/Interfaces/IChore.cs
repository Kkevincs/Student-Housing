using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface IChore
    {
        public async Task Create(Chore chore);
        public Task Update(Chore chore);
        public Task Delete(Chore chore);
        public Task<List<Chore>> GetAll();
        public Task<Chore> GetById(int id);
    }
}
