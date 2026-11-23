using API.API.BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.API.PL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentCsvController : Controller
    {
        private readonly AddRoomsAndStudentsFromCsv _csv;

        public StudentCsvController(AddRoomsAndStudentsFromCsv csv)
        {
            _csv = csv;
        }

        [HttpGet]
        public async Task<IActionResult> Load()
        {
            await _csv.Create("House-Student records.csv");
            return Ok();
        }
    }
}
