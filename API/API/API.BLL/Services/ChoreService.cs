using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Repositories;
using API.Repository.Interfaces;
using API.Repository.Models;
using AutoMapper;

namespace API.API.BLL.Services
{
    public class ChoreService : IChoreService
    {
        private readonly ChoreRepository _repo;
        private readonly IMapper _mapper;

        public ChoreService(ChoreRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Create(CreateChoreDto chore)
        {
            Chore createable = _mapper.Map<Chore>(chore);
            createable.CreatedAt = DateTime.Now;
            await _repo.Create(createable);

        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<Chore>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Chore> GetById(int id)
        {
           return await _repo.GetById(id);
        }

        public async Task Update(GetChoreDto chore)
        {
            Chore updateable = _mapper.Map<Chore>(chore);
            await _repo.Update(updateable);
        }
    }
}
