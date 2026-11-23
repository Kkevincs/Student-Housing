using API.API.BLL.DTOs;
using API.API.BLL.Interfaces;
using API.API.DAL.Models;
using API.API.DAL.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace API.API.BLL.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly OwnerRepository _repo;
        private readonly IMapper _mapper;
        private readonly AuthenticationService _auth;

        public OwnerService(OwnerRepository repo, IMapper mapper, AuthenticationService auth)
        {
            _repo = repo;
            _mapper = mapper;
            _auth = auth;
        }

        public async Task<string> Register(RegisterOwnerDto owner)
        {
            Owner createable = _mapper.Map<Owner>(owner);
            createable.PasswordHash = new PasswordHasher<Owner>().HashPassword(createable, owner.Password);
            await _repo.Create(createable);
            return _auth.GenerateToken(createable.Id, "Owner");
        }
    }
}
