using API.API.BLL.DTOs;
using API.API.BLL.Services;
using API.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.API.PL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HouseController : Controller
    {
        private readonly HouseService _service;

        public HouseController(HouseService service)
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.GetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateHouseDto house)
        {
            await _service.Create(house);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id)
        {
            await _service.Update(id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}