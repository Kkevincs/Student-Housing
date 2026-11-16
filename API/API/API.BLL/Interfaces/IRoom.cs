using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IRoom
    {
        public Task Create();
        public Task Update();
        public Task Delete();
        public Task<Room> GetById(int id);
        public Task<List<Room>> GetAll();
    }
}
