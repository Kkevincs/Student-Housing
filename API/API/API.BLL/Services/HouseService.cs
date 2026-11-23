using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Repositories;
using API.Repository.Models;
using AutoMapper;


namespace API.API.BLL.Services
{
    public class HouseService : IHouseService
    {
        private readonly HouseRepository _repo;
        private readonly IMapper _mapper;

        public HouseService(HouseRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Create(CreateHouseDto house)
        {
            House createable = _mapper.Map<House>(house);
            await _repo.Create(createable);
        }

        public async Task CreateWithId(House hosue)
        {
            await _repo.Create(hosue);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<House>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<House> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(GetHouseDto house)
        {
            House updateable = _mapper.Map<House>(house);
            await _repo.Update(updateable);
        }
    }
}
