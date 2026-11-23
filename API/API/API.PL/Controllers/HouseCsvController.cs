using API.API.BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.API.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseCsvController : ControllerBase
    {
        private readonly AddPropertysFromCsv _csv;

        public HouseCsvController(AddPropertysFromCsv csv)
        {
            _csv = csv;
        }

        [HttpGet]
        public async Task<IActionResult> Load() {
            await _csv.LoadCsv("Properties.csv");
            return Ok();
        }
    }
}
