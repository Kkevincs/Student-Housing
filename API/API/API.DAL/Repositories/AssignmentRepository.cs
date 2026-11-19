using API.Repository;
using API.Repository.Interfaces;
using API.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace API.API.DAL.Repositories
{
    public class AssignmentRepository : IAssignment
    {
        private readonly HousingDbContext _housingDbContext;

        public AssignmentRepository(HousingDbContext housingDbContext)
        {
            _housingDbContext = housingDbContext;
        }

        public async Task Create(Assignment assignment)
        {
            _housingDbContext.Assignments.Add(assignment);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Assignment removable = await _housingDbContext.Assignments.FindAsync(id);
            _housingDbContext.Remove(removable);
            await _housingDbContext.SaveChangesAsync();
        }
        public async Task Update(Assignment assignment) {
        
            _housingDbContext.Assignments.Update(assignment);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task<List<Assignment>> GetAll()
        {
            return await _housingDbContext.Assignments.ToListAsync();
        }

        public async Task<Assignment> GetById(int id)
        {
            return await _housingDbContext.Assignments
                .FindAsync(id);
        }
    }
}
