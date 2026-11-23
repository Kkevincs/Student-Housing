using API.API.BLL.DTOs;
using API.API.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.API.PL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeCsvRead : Controller
    {

        private readonly AddEmployeesFromCsv _csv;

        public EmployeeCsvRead(AddEmployeesFromCsv csv)
        {
            _csv = csv;
        }

        [HttpGet]
        public async Task<IActionResult> LoadEmployees(){
            await _csv.CsvRead("Student Housing Employees.csv");
            return Ok();
        }
    }
}
