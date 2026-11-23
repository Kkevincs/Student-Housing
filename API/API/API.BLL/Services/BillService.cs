using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Interfaces;
using API.API.DAL.Models;
using API.API.DAL.Repositories;
using AutoMapper;

namespace API.API.BLL.Services
{
    public class BillService : IBillService
    {
        private readonly BillRepository _repo;
        private readonly IMapper _mapper;

        public BillService(BillRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Create(CreateBillDto bill)
        {
            Bill creatable = _mapper.Map<Bill>(bill);
            await _repo.Create(creatable);
        }
    }
}
