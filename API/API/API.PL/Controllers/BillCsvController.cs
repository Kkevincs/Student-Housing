using API.API.BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.API.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillCsvController : ControllerBase
    {
        private readonly AddBillsFromCsv _csv;

        public BillCsvController(AddBillsFromCsv csv)
        {
            _csv = csv;
        }

        [HttpGet]
        public async Task<IActionResult> Load() {
            await _csv.Create("Gas and electricty bills.csv");
            return Ok();
        }
    }
}
