using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface IStudent
    {
        public Task Create(Student student);
        public Task Update(Assignment assignment);
        public Task Delete(int id);
        public Task<List<Student>> GetAll();
        public Task<Student> GetById(int id);
    }
}
