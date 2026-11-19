using API.API.BLL.DTOs;
using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IStudentService
    {
        public Task Create(CreateStudentDto student);
        public Task Update(GetAssigmentDto);
        public Task Delete(int id);
        public Task<Student> GetById(int id);
        public Task<List<Student>> GetAll();
    }
}
