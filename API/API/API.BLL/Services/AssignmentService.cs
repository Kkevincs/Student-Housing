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
        private readonly Mapper _mapper;

        public AssignmentService(AssignmentRepository repo)
        {
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

        public Task Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
