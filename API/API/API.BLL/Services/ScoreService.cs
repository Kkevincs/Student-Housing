using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Repositories;
using API.Repository.Interfaces;
using API.Repository.Models;
using AutoMapper;

namespace API.API.BLL.Services
{
    public class ScoreService : IScoreService
    {
        private readonly ScoreRepository _repo;
        private readonly IMapper _mapper;

        public ScoreService(ScoreRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Create(CreateScoreDto score)
        {
            Score createable = _mapper.Map<Score>(score);
            await _repo.Create(createable);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<Score>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Score> GetById(int id)
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
