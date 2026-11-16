using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IAssigment
    {
        public Task Create();
        public Task Update();
        public Task Delete();
        public Task<Assignment> GetById(int id);
        public Task<List<Assignment>> GetAll();

    }
}
