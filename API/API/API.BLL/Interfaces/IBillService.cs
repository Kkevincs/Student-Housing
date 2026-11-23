using API.API.BLL.DTOs;

namespace API.API.BLL.Interfaces
{
    public interface IBillService
    {
        public Task Create(CreateBillDto bill);
    }
}
