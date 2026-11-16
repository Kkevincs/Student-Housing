using API
using API.Repository;
using API.Repository.Interfaces;
using API.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace API.API.DAL.Repositories
{
    public class ScoreRepository : IScore
    {
        private readonly HousingDbContext _housingDbContext;

        public ScoreRepository(HousingDbContext housingDbContext)
        {
            _housingDbContext = housingDbContext;
        }

        public async Task Create(Score Score)
        {
            _housingDbContext.Scores.Add(Score);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task Delete(Score score)
        {
            _housingDbContext.Scores.Remove(score);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task<List<Score>> GetAll()
        {
            return await _housingDbContext.Scores.ToListAsync();
        }

        public async Task<Score> GetById(int id)
        {
            return await _housingDbContext.Scores.FindAsync(id);
        }

        public async Task Update(Score score)
        {
            _housingDbContext.Scores.Update(score);
            await _housingDbContext.SaveChangesAsync();
        }
    }
}
