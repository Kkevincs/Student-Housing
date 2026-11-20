using API.API.DAL.Models;
using API.Repository.Models;

namespace API.API.DAL.Interfaces
{
    public interface IEmployee
    {
        public Task Create(Employee employee);
        public Task Update(Employee employee);
        public Task Delete(int id);
        public Task<List<Employee>> GetAll();
        public Task<Employee> GetById(int id);
    }   
}
