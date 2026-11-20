using API.API.BLL.DTOs;
using API.API.BLL.Services;
using API.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.API.PL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScoreController : Controller
    {
        private readonly ScoreService _service;

        public ScoreController(ScoreService service)
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
        public async Task<IActionResult> Create([FromBody] CreateScoreDto score)
        {
            await _service.Create(score);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(GetScoreDto score)
        {
            await _service.Update(score);
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
