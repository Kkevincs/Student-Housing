using API.API.DAL.Interfaces;
using API.API.DAL.Models;
using API.Repository;

namespace API.API.DAL.Repositories
{
    public class OwnerRepository : IOwner
    {
        private readonly HousingDbContext _housingDbContext;

        public OwnerRepository(HousingDbContext housingDbContext)
        {
            _housingDbContext = housingDbContext;
        }

        public async Task Create(Owner owner)
        {
            _housingDbContext.Owners.Add(owner);
            await _housingDbContext.SaveChangesAsync();
        }
    }
}
