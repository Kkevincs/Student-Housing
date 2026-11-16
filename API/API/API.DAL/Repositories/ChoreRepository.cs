using API.Repository;
using API.Repository.Interfaces;
using API.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace API.API.DAL.Repositories
{
    public class ChoreRepository : IChore
    {
        private readonly HousingDbContext _housingDbContext;

        public ChoreRepository(HousingDbContext housingDbContext)
        {
            _housingDbContext = housingDbContext;
        }

        public async Task Create(Chore chore)
        {
            _housingDbContext.Chores.Add(chore);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task Delete(Chore chore)
        {
            _housingDbContext.Remove(chore);
            await _housingDbContext.SaveChangesAsync();
        }

        public Task<List<Chore>> GetAll()
        {
            return _housingDbContext.Chores.ToListAsync();
        }

        public async Task<Chore> GetById(int id)
        {
            return await _housingDbContext.chore.FindAsync(id);
        }

        public async Task Update(Chore chore)
        {
            _housingDbContext.Chores.Update(chore);
            await _housingDbContext.SaveChangesAsync();
        }
    }
}
