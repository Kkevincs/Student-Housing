using API.API.BLL.DTOs;
using API.Repository.Models;

namespace API.API.BLL.Interfaces
{
    public interface IHouseService
    {
        public Task Create(CreateHouseDto house);
        public Task Update(GetAssigmentDto);
        public Task Delete( int id);
        public Task<House> GetById(int id);
        public Task<List<House>> GetAll();
    }
}
