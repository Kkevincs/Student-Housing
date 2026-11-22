using API.API.BLL.DTOs;
using API.API.DAL.Models;
using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IEmployeeService
    {
        public Task Create(CreateEmployeeDto employee);
        public Task Update(GetEmployeeDto employee);
        public Task Delete(int id);
        public Task<Employee> GetById(int id);
        public Task<List<Employee>> GetAll();
    }
}
