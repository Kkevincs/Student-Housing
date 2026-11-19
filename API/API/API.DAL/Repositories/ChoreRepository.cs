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

        public async Task Delete(int id)
        {
            Chore deletable = await _housingDbContext.Chores.FindAsync(id);
            _housingDbContext.Chores.Remove(deletable);
            await _housingDbContext.SaveChangesAsync();
        }

        public Task<List<Chore>> GetAll()
        {
            return _housingDbContext.Chores.ToListAsync();
        }

        public async Task<Chore> GetById(int id)
        {
            return await _housingDbContext.Chores.FindAsync(id);
        }

        public async Task Update(Assignment assignment)
        {

            _housingDbContext.Assignments.Update(assignment);
            await _housingDbContext.SaveChangesAsync();
        }
    }
}
