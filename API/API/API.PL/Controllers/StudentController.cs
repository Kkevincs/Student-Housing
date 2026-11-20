using API.API.BLL.DTOs;
using API.API.BLL.Services;
using API.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.API.PL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly StudentService _service;

        public StudentController(StudentService service)
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
        public async Task<IActionResult> Create([FromBody] CreateStudentDto student)
        {
            await _service.Create(student);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(GetStudentDto student)
        {
            await _service.Update(student);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }

        [HttpPost]
        public async Task<GetStudentDto> Register(CreateStudentDto student)
        { 
            
        }
    }
}
