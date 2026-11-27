using API.API.DAL.Models;

namespace API.API.DAL.Interfaces
{
    public interface IBill
    {
        public Task Create(Bill bill);
    }
}
