using API.API.BLL.DTOs;
using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IAssigmentService
    {
        public Task Create(CreateAssignmentDto assignment);
        public Task Update(int id);
        public Task Delete(int id);
        public Task<Assignment> GetById(int id);
        public Task<List<Assignment>> GetAll();

    }
}
