using API.API.BLL.DTOs;
using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IRoomService
    {
        public Task Create(CreateRoomDto room);
        public Task Update(GetRoomDto room);
        public Task Delete(int id);
        public Task<Room> GetById(int id);
        public Task<List<Room>> GetAll();
    }
}
