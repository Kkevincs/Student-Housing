using API.Repository.Models;

namespace API.Repository.Interfaces
{
    public interface IStudent
    {
        public Task Create(Student student);
        public Task Update(Student student);
        public Task Delete(Student student);
        public Task<List<Student>> GetAll();
        public Task<Student> GetById(int id);
    }
}
