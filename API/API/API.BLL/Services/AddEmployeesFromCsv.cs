using API.API.BLL.DTOs;
using API.API.DAL.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.API.BLL.Services
{
    public class AddEmployeesFromCsv
    {
        private readonly EmployeeService _service;

        public AddEmployeesFromCsv(EmployeeService service)
        {
            _service = service;
        }

        public async Task CsvRead(string FileName)
        {
            foreach (var item in File.ReadAllLines(FileName).Skip(1))
            {
                await _service.CreateWithId(new Employee(item));
                
            }
            
        }
    }
}
