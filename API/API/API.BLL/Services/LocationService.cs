using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Repositories;
using API.Repository.Interfaces;
using API.Repository.Models;
using AutoMapper;


namespace API.API.BLL.Services
{
    public class LocationService : ILocationService
    {
        private readonly LocationRepository _repo;
        private readonly IMapper _mapper;

        public LocationService(LocationRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Create(CreateLocationDto location)
        {
            Location createable = _mapper.Map<Location>(location);
            await _repo.Create(createable);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<Location>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Location> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(int id)
        {
            await _repo.Update(id);
        }
    }
}