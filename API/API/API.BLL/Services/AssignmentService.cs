using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Repositories;
using API.Repository.Models;
using AutoMapper;

namespace API.API.BLL.Services
{
    public class AssignmentService : IAssigmentService
    {
        private readonly AssignmentRepository _repo;
        private readonly IMapper _mapper;

        public AssignmentService(IMapper mapper, AssignmentRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task Create(CreateAssignmentDto assignmentDto)
        {
            Assignment NewAssignment = _mapper.Map<Assignment>(assignmentDto);
            await _repo.Create(NewAssignment);
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Assignment>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Assignment> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(GetAssigmentDto getAssigmentDto)
        {
            Assignment updateable = _mapper.Map<Assignment>(getAssigmentDto);
            await _repo.Update(updateable);
        }
    }
}
