using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Models;
using API.API.DAL.Repositories;
using API.Repository.Interfaces;
using API.Repository.Models;
using AutoMapper;

namespace API.API.BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _repo;
        private readonly IMapper _mapper;

        public EmployeeService(EmployeeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task Create(CreateEmployeeDto employee)
        {
            Employee createable = _mapper.Map<Employee>(employee);
            await _repo.Create(createable);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(GetEmployeeDto employee)
        {
            Employee updateable = _mapper.Map<Employee>(employee);
            await _repo.Update(updateable);
        }
    }
}
