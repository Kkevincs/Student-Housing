using API.API.DAL.Models;

namespace API.API.DAL.Interfaces
{
    public interface IOwner
    {
        public Task Create(Owner owner);
    }
}
