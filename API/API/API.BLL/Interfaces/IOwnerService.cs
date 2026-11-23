using API.API.BLL.DTOs;

namespace API.API.BLL.Interfaces
{
    public interface IOwnerService
    {
        public Task<string> Register(RegisterOwnerDto owner);
    }
}
