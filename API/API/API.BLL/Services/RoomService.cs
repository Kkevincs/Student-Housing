using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Repositories;
using API.Repository.Interfaces;
using API.Repository.Models;
using AutoMapper;

namespace API.API.BLL.Services
{
    public class RoomService : IRoomService
    {
        private readonly RoomRepository _repo;
        private readonly IMapper _mapper;

        public RoomService(RoomRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Create(CreateRoomDto room)
        {
            Room createable = _mapper.Map<Room>(room);
            await _repo.Create(createable);
        }

        public async Task CreateWithId(Room room)
        {
            await _repo.Create(room);
        }

        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }

        public async Task<List<Room>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Room> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task Update(GetRoomDto room)
        {
            Room updateable = _mapper.Map<Room>(room);
            await _repo.Update(updateable);
        }
    }
}
