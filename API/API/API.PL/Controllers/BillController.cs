using API.API.BLL.DTOs;
using API.API.BLL.Services;
using API.API.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.API.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly BillService _service;

        public BillController(BillService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBillDto bill)
        {
            await _service.Create(bill);
            return Ok();
        }
    }
}
