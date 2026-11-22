using API.API.DAL.Interfaces;
using API.API.DAL.Models;
using API.Repository;
using API.Repository.Interfaces;
using API.Repository.Models;
using Microsoft.EntityFrameworkCore;


namespace API.API.DAL.Repositories
{
    public class EmployeeRepository : IEmployee
    {
        private readonly HousingDbContext _housingDbContext;

        public EmployeeRepository(HousingDbContext housingDbContext)
        {
            _housingDbContext = housingDbContext;
        }

        public async Task Create(Employee employee)
        {
            _housingDbContext.Employee.Add(employee);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Employee deletable = await _housingDbContext.Employee.FindAsync(id);
            _housingDbContext.Employee.Remove(deletable);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _housingDbContext.Employee.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _housingDbContext.Employee.FindAsync(id);
        }

        public async Task Update(Employee employee)
        {
            _housingDbContext.Employee.Update(employee);
            await _housingDbContext.SaveChangesAsync();
        }
    }

}


