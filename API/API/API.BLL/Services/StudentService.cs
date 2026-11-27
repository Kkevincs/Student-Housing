using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Repositories;
using API.Repository.Models;
using AutoMapper;

namespace API.API.BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentRepository _repo;
        private readonly IMapper _mapper;

        public StudentService(StudentRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Create(CreateStudentDto student)
        {
            Student createable = _mapper.Map<Student>(student);
            await _repo.Create(createable);
        }

        public async Task CreateWithId(Student student)
        {
            await _repo.Create(student);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<Student>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Student> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(GetStudentDto student)
        {
            Student updateable = _mapper.Map<Student>(student);
            await _repo.Update(updateable);
        }
    }
}
