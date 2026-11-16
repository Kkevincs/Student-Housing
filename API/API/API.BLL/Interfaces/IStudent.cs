using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IStudent
    {
        public Task Create();
        public Task Update();
        public Task Delete();
        public Task<Student> GetById(int id);
        public Task<List<Student>> GetAll();
    }
}
