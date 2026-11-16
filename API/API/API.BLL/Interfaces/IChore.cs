using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IChore
    {
        public Task Create();
        public Task Update();
        public Task Delete();
        public Task<Chore> GetById(int id);
        public Task<List<Chore>> GetAll();
    }
}
