using API.API.BLL.DTOs;
using API.API.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.API.PL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OwnerController : Controller
    {
        private readonly OwnerService _service;

        public OwnerController(OwnerService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterOwnerDto owner)
        {
            return Ok(await _service.Register(owner));
        }
    }
}
